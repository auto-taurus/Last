using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gbxx.WebApi.Areas.v1.Models {
    /// <summary>
    /// Header来源设备基础信息
    /// </summary>
    public class DeviceArgs {
        /// <summary>
        /// 来源ip
        /// </summary>
        public string Ip { get; set; }
        /// <summary>
        /// 设备信息
        /// </summary>
        public string Device { get; set; }
        /// <summary>
        /// 版本号
        /// </summary>
        public string Version { get; set; }
    }

    /// <summary>
    /// 来源设备基础信息 验证
    /// </summary>
    public class DeviceArgsValidator : AbstractValidator<DeviceArgs> {
        /// <summary>
        /// 
        /// </summary>
        public DeviceArgsValidator() {
            RuleFor(a => a.Device).Null().WithMessage("请传递设备信息！");
            RuleFor(a => a.Device).Null().WithMessage("请传递版本号！");
        }
    }
}
