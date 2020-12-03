using Auto.Commons;
using Auto.DataServices.Contracts;
using FluentValidation;
using Microsoft.AspNetCore.Http;
using System.Threading;
using System.Threading.Tasks;

namespace Gbxx.BackStage.Models.Post {
    public class LoginUserPost {
        /// <summary>
        /// 登录名
        /// </summary>
        public string LoginName { get; set; }
        /// <summary>
        /// 登录密码
        /// </summary>
        public string Password { get; set; }
        /// <summary>
        /// 验证码
        /// </summary>
        public string VeriCode { get; set; }
    }
    public class PostSystemUsersValidator : AbstractValidator<LoginUserPost> {
        private ISystemUsersRepository _ISystemUsersRepository { get; set; }

        private readonly IHttpContextAccessor _httpContextAccessor;
        private ISession _session => _httpContextAccessor.HttpContext.Session;
        public PostSystemUsersValidator(ISystemUsersRepository systemUsersRepository, IHttpContextAccessor httpContextAccessor) {
            this._ISystemUsersRepository = systemUsersRepository;
            this._httpContextAccessor = httpContextAccessor;
            #region Generated Constructor
            RuleFor(p => p.LoginName).NotEmpty().WithMessage("用户名不能为空！")
                                     .Length(6, 50).WithMessage("登录名不能为空且长度必须符合6-50个位数！")
                                     .MustAsync(ExistLoginName).WithMessage("用户不存在！");
            RuleFor(p => p.Password).NotEmpty().WithMessage("请输入密码！")
                                    .MustAsync(IsCorrectPassword).WithMessage("密码错误！");
            RuleFor(p => p.VeriCode).NotEmpty().WithMessage("请输入验证码！")
                                    .Must(IsCorrectCode)
                                    .WithMessage("验证码输入不正确！");
            ;
            #endregion
        }
        private bool IsCorrectCode(string arg) {
            return arg != _session.GetString("VerifyCode");
        }

        private async Task<bool> ExistLoginName(string arg, CancellationToken token) {
            return await this._ISystemUsersRepository.IsExistAsync(e => e.LoginName == arg);
        }
        private async Task<bool> IsCorrectPassword(string arg, CancellationToken token) {
            var passWord = Tools.Md5(arg);
            return await this._ISystemUsersRepository.IsExistAsync(e => e.Password == passWord);
        }
    }
}
