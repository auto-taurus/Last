using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gbxx.WebApi.Areas.v1.Models.Post {
    public class PasswordPost {
        public string LoginName { get; set; }
        public string Old { get; set; }
        public string New { get; set; }
    }
    /// <summary>
    /// 
    /// </summary>
    public class PasswordPostValidator : AbstractValidator<PasswordPost> {
        /// <summary>
        /// 
        /// </summary>
        public PasswordPostValidator() {

        }
    }
}
