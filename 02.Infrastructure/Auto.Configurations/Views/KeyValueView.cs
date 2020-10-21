using Auto.Entities.Dtos;
using Microsoft.EntityFrameworkCore;
using System.Composition;

namespace Auto.Configurations.Views {
    [Export(typeof(IConfigurations))]
    public class KeyValueView : IConfigurations {
        public void Configure(ModelBuilder builder) {
            builder.Query<KeyValueDto>().ToView("KeyValueDto");
        }
    }
}
