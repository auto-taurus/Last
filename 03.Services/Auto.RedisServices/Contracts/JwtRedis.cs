using Auto.Entities.Datas;
using Auto.RedisServices.Entities;
using Auto.RedisServices.Repositories;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Primitives;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Auto.RedisServices.Contracts {
    public class JwtRedis : IJwtRedis {
        #region Initialize

        /// <summary>
        /// 已授权的 Token 信息集合
        /// </summary>
        private static ISet<JwtAuthorData> _tokens = new HashSet<JwtAuthorData>();
        /// <summary>
        /// 分布式缓存
        /// </summary>
        private readonly IRedisStore _IRedisStore;
        /// <summary>
        /// 配置信息
        /// </summary>
        private readonly IConfiguration _configuration;
        /// <summary>
        /// 获取 HTTP 请求上下文
        /// </summary>
        private readonly IHttpContextAccessor _httpContextAccessor;
        /// <summary>
        /// 
        /// </summary>
        private readonly String _customPrefix = "token";

        /// <summary>
        /// ctor
        /// </summary>
        /// <param name="cache"></param>
        /// <param name="httpContextAccessor"></param>
        /// <param name="configuration"></param>
        public JwtRedis(IRedisStore redisStore, IHttpContextAccessor httpContextAccessor, IConfiguration configuration) {
            _IRedisStore = redisStore;
            _httpContextAccessor = httpContextAccessor;
            _configuration = configuration;
        }

        #endregion

        #region API Implements

        /// <summary>
        /// 新增 Token
        /// </summary>
        /// <param name="dto">用户信息数据传输对象</param>
        /// <returns></returns>
        public JwtAuthorData Create(MemberInfos dto) {
            JwtSecurityTokenHandler tokenHandler = new JwtSecurityTokenHandler();
            SymmetricSecurityKey key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Authentication:JwtBearer:SecurityKey"]));

            DateTime authTime = DateTime.UtcNow;
            DateTime expiresAt = authTime.AddMinutes(Convert.ToDouble(_configuration["Authentication:JwtBearer:TokenMinutes"]));

            //将用户信息添加到 Claim 中
            var identity = new ClaimsIdentity(JwtBearerDefaults.AuthenticationScheme);

            IEnumerable<Claim> claims = new Claim[] {
                new Claim(ClaimTypes.NameIdentifier,  dto.MemberId.ToString()),
                new Claim(ClaimTypes.Name,            dto.Name),
                new Claim(ClaimTypes.GivenName,       dto.NickName),
                new Claim(ClaimTypes.MobilePhone,     dto.Phone),
                new Claim(ClaimTypes.SerialNumber,    dto.Code),
                new Claim(ClaimTypes.Upn,             dto.Alipay),
                new Claim(ClaimTypes.Spn,             dto.Wechat),
                new Claim(ClaimTypes.Expiration,      expiresAt.ToString())
            };
            identity.AddClaims(claims);
            //签发一个加密后的用户信息凭证，用来标识用户的身份，并把用户信息添加请求上下文中
            _httpContextAccessor.HttpContext.SignInAsync(JwtBearerDefaults.AuthenticationScheme, new ClaimsPrincipal(identity));

            var tokenDescriptor = new SecurityTokenDescriptor {
                Subject = new ClaimsIdentity(claims),//创建声明信息
                Issuer = _configuration["Authentication:JwtBearer:Issuer"],//Jwt token 的签发者
                Audience = _configuration["Authentication:JwtBearer:Audience"],//Jwt token 的接收者
                Expires = expiresAt,//过期时间
                SigningCredentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256)//创建 token
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);

            //存储 Token 信息
            var jwt = new JwtAuthorData {
                MemberId = dto.MemberId,
                Token = tokenHandler.WriteToken(token),
                Auths = new DateTimeOffset(authTime).ToUnixTimeSeconds(),
                Expires = new DateTimeOffset(expiresAt).ToUnixTimeSeconds(),
            };

            if (!_tokens.Add(jwt)) {
                jwt = default(JwtAuthorData);
            }
            return jwt;
        }

        /// <summary>
        /// 停用 Token
        /// </summary>
        /// <param name="token">Token</param>
        /// <returns></returns>
        public async Task<bool> DeactivateAsync(string token) {
            var tokenKey = GetKey(token);
            var number = _IRedisStore.GetRandomNumber(tokenKey);
            return await _IRedisStore.Do(db => db.StringSetAsync(tokenKey,
                                                                 token,
                                                                 TimeSpan.FromMinutes(Convert.ToDouble(_configuration["Authentication:JwtBearer:Minutes"]))
                                                                 ), number);
        }

        /// <summary>
        /// 停用当前 Token
        /// </summary>
        /// <returns></returns>
        public async Task<bool> DeactivateCurrentAsync()
        => await DeactivateAsync(GetCurrentAsync());

        /// <summary>
        /// 判断 Token 是否有效
        /// </summary>
        /// <param name="token">Token</param>
        /// <returns></returns>
        public async Task<bool> IsActiveAsync(string token) {
            var tokenKey = GetKey(token);
            var number = _IRedisStore.GetRandomNumber(tokenKey);
            return await _IRedisStore.Do(db => db.KeyExistsAsync(tokenKey), number);
        }

        /// <summary>
        /// 判断当前 Token 是否有效
        /// </summary>
        /// <returns></returns>
        public async Task<bool> IsCurrentActiveTokenAsync()
        => await IsActiveAsync(GetCurrentAsync());

        /// <summary>
        /// 刷新 Token
        /// </summary>
        /// <param name="token">Token</param>
        /// <param name="dto">用户信息</param>
        /// <returns></returns>
        public async Task<JwtAuthorData> RefreshAsync(string token, MemberInfos dto) {
            var jwtOld = GetExistenceToken(token);
            if (jwtOld == null) {
                return null;
            }
            var jwt = Create(dto);
            //停用修改前的 Token 信息
            await DeactivateCurrentAsync();
            return jwt;
        }

        #endregion

        #region Method

        /// <summary>
        /// 设置缓存中过期 Token 值的 key
        /// </summary>
        /// <param name="token">Token</param>
        /// <returns></returns>
        private string GetKey(string token)
            => $"{_customPrefix}:{token}";

        /// <summary>
        /// 获取 HTTP 请求的 Token 值
        /// </summary>
        /// <returns></returns>
        private string GetCurrentAsync() {
            //http header
            var authorizationHeader = _httpContextAccessor
                .HttpContext.Request.Headers["authorization"];

            //token
            return authorizationHeader == StringValues.Empty
                ? string.Empty
                : authorizationHeader.Single().Split(" ").Last();// bearer tokenvalue
        }

        /// <summary>
        /// 判断是否存在当前 Token
        /// </summary>
        /// <param name="token">Token</param>
        /// <returns></returns>
        private JwtAuthorData GetExistenceToken(string token)
            => _tokens.SingleOrDefault(x => x.Token == token);

        #endregion
    }
}
