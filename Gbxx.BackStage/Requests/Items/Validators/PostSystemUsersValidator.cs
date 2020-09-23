using Auto.DataServices.Contracts;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Gbxx.BackStage.Requests.Items.Validators {
    public class PostSystemUsersValidator : AbstractValidator<SystemUsersRequest> {
        private ISystemUsersRepository _ISystemUsersRepository { get; set; }

        public PostSystemUsersValidator(ISystemUsersRepository systemUsersRepository) {
            this._ISystemUsersRepository = systemUsersRepository;
            #region Generated Constructor
            RuleFor(p => p.UsersName)
                .NotEmpty().WithMessage("用户名不能为空！")
                .MustAsync(ExistUsersName).WithMessage("用户名已存在！");
            RuleFor(p => p.LoginName)
                .NotEmpty().Length(6, 50).WithMessage("登录名不能为空且长度必须符合6-50个位数！")
                .MustAsync(ExistLoginName).WithMessage("登录名已存在！");
            RuleFor(p => p.Password).NotEmpty().Length(6, 50).WithMessage("密码不能为空且长度必须符合6-50个位数！");
            RuleFor(p => p.Email).MaximumLength(50).EmailAddress().WithMessage("邮箱格式不正确！");
            #endregion
        }

        private async Task<bool> ExistUsersName(SystemUsersRequest model, string arg, CancellationToken token) {
            var flag = false;
            if (model.UsersId > 0) {
                flag = await this._ISystemUsersRepository.IsExistAsync(e => e.UsersId != model.UsersId && e.UsersName == arg);
            }
            else {
                flag = await this._ISystemUsersRepository.IsExistAsync(e => e.UsersName == arg);
            }
            return !flag;
        }
        private async Task<bool> ExistLoginName(SystemUsersRequest model, string arg, CancellationToken token) {
            var flag = false;
            if (model.UsersId > 0) {
                flag = await this._ISystemUsersRepository.IsExistAsync(e => e.UsersId != model.UsersId && e.LoginName == arg);
            }
            else
                flag = await this._ISystemUsersRepository.IsExistAsync(e => e.LoginName == arg);
            return !flag;
        }
    }
}
