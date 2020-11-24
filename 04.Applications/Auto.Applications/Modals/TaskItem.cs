using Auto.DataServices.Contracts;
using FluentValidation;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.Text;

namespace Auto.Applications.Modals {
    public class TaskItem {
        /// <summary>
        /// 会员编号
        /// </summary>
        public int? MemberId { get; set; }
        //[BindNever]
        //public string TaskCode { get; set; }
        /// <summary>
        /// 被邀请人
        /// </summary>
        public int InvitedId { get; set; }
        /// <summary>
        /// 内容标识
        /// </summary>
        public string FromId { get; set; }
        /// <summary>
        /// 来源标识
        /// </summary>
        public int? FromMark { get; set; }

        /// <summary>
        /// 来源类型
        /// </summary>
        public int? FromType { get; set; }
    }

    public class TaskItemValidator : AbstractValidator<TaskItem> {
        protected IMemberInfosRepository _IMemberInfoRepository;
        public TaskItemValidator(IMemberInfosRepository memberInfoRepository) {
            this._IMemberInfoRepository = memberInfoRepository;

            //检查用户是否存在
            RuleFor(x => x.MemberId).NotEmpty().WithMessage("MemberId不能为空").MustAsync(async (id, cancellation) => {
                bool exists = await this._IMemberInfoRepository.IsExistAsync(x => x.MemberId == id);
                return exists;
            }).WithMessage("当前用户不存在，请检查");
        }
    }
}
