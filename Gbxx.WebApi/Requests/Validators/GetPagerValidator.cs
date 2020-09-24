using FluentValidation;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gbxx.WebApi.Requests.Validators {
    public class GetPagerValidator : AbstractValidator<GetPager> {
        public GetPagerValidator() {
            RuleSet("pager", () => {
                RuleFor(x => x.PageIndex).NotNull().WithMessage("请传递页码！")
                                   .LessThanOrEqualTo(0).WithMessage("页码必须大于0！");
                RuleFor(x => x.PageSize).NotNull().WithMessage("请传递每页显示条数！")
                                         .LessThanOrEqualTo(0).WithMessage("每页显示条数必须大于0！");
            });
          
        }
        public async Task<bool> IsValidator() {
            GetPager customer = new GetPager();
            GetPagerValidator validator = new GetPagerValidator();
            ValidationResult results = validator.Validate(customer);
            return results.IsValid;
        }
    }
}
