using Auto.Entities.Dtos;
using Microsoft.EntityFrameworkCore;
using System.Composition;

namespace Auto.Configurations.Views {
    [Export(typeof(IConfigurations))]
    public class KeyNameView : IConfigurations {
        public void Configure(ModelBuilder builder) {
            builder.Query<KeyNameDto>().ToView("KeyNameDto");
        }
    }
}
