using Microsoft.AspNetCore.Mvc.Filters;
using System;

namespace Gbxx.WebApi.Filters {
    public class TokenAuthorAttribute : IAuthorizationFilter {
        public void OnAuthorization(AuthorizationFilterContext context) {
            throw new NotImplementedException();
        }
    }
}
