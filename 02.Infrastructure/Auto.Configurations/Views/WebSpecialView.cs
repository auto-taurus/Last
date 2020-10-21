using Auto.Entities.Dtos;
using Microsoft.EntityFrameworkCore;
using System.Composition;

namespace Auto.Configurations.Views {
    [Export(typeof(IConfigurations))]
    public class WebSpecialView : IConfigurations {
        public void Configure(ModelBuilder builder) {
            builder.Query<WebSpecialDto>().ToView("WebSpecialDto");
        }
    }
}
