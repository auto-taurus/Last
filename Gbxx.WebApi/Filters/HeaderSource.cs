using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gbxx.WebApi.Filters {
    /// <summary>
    /// 请求头Header来源Source信息
    /// </summary>
    public class HeaderSource {
        /// <summary>
        /// 来源IP
        /// </summary>
        public string Ip { get; set; }
        /// <summary>
        /// 来源设备
        /// </summary>
        public string Device { get; set; }
        /// <summary>
        /// 设备版本
        /// </summary>
        public string DeviceVers { get; set; }
        /// <summary>
        /// 系统版本
        /// </summary>
        public string SystemVers { get; set; }
    }

    /// <summary>
    /// 来源设备基础信息 验证
    /// </summary>
    public class HeaderSourceValidator : AbstractValidator<HeaderSource> {
        /// <summary>
        /// 
        /// </summary>
        public HeaderSourceValidator() {
            RuleFor(a => a.Device).NotEmpty().WithMessage("请传递设备信息！")
                                  .Length(1, 20).WithMessage("设备信息长度为1-20！");
            RuleFor(a => a.SystemVers).NotEmpty().WithMessage("请传递系统版本号！")
                                      .Length(1, 20).WithMessage("系统版本号长度为1-20！");
        }
    }
}
