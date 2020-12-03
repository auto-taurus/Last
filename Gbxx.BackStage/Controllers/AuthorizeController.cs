using Microsoft.AspNetCore.Authorization;

namespace Gbxx.BackStage.Controllers {
    [Authorize(Policy = "Permission")]
    public class AuthorizeController : DefaultController {
    }
}