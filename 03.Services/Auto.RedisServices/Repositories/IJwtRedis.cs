﻿using Auto.CacheEntities.RedisValues;
using Auto.Commons.Ioc.IContract;
using System.Threading.Tasks;

namespace Auto.RedisServices.Repositories {
    public interface IJwtRedis : ISingletonInject {
        /// <summary>
        /// 新增 Jwt token
        /// </summary>
        /// <param name="dto">用户信息数据传输对象</param>
        /// <returns></returns>
        JwtAuthorValue Create(MemberInfoValue dto);
        /// <summary>
        /// 刷新 Token
        /// </summary>
        /// <param name="token">Token</param>
        /// <param name="dto">用户信息数据传输对象</param>
        /// <returns></returns>
        Task<JwtAuthorValue> RefreshAsync(string token, MemberInfoValue dto);
        /// <summary>
        /// 判断当前 Token 是否有效
        /// </summary>
        /// <returns></returns>
        Task<bool> IsCurrentActiveTokenAsync();
        /// <summary>
        /// 停用当前 Token
        /// </summary>
        /// <returns></returns>
        Task<bool> DeactivateCurrentAsync();
        /// <summary>
        /// 判断 Token 是否有效
        /// </summary>
        /// <param name="token">Token</param>
        /// <returns></returns>
        Task<bool> IsActiveAsync(string token);
        /// <summary>
        /// 停用 Token
        /// </summary>
        /// <returns></returns>
        Task<bool> DeactivateAsync(string token);
    }
}
