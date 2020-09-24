using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gbxx.WebApi.Requests.Validators {
    public class GetBaseValidator : AbstractValidator<GetBase> {
        public GetBaseValidator() {
            RuleFor(x => x.Device).NotNull().WithMessage("请传递设备号！");
            RuleFor(x => x.Version).NotNull().WithMessage("请传递版本号！");
            
        }
    }
}
