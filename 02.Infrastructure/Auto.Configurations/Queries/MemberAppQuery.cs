using Auto.Entities.Dtos;
using Microsoft.EntityFrameworkCore;
using System.Composition;

namespace Auto.Configurations.Queries {
    [Export(typeof(IConfigurations))]
    public class MemberAppQuery : IConfigurations {
        public void Configure(ModelBuilder builder) {
            builder.Query<MemberAppDto>(a => {
                a.ToView("MemberAppDto");
                a.Ignore(b => b.TodayBeans)
                 .Ignore(b => b.TodayRead)
                 .Ignore(b => b.Ratio)
                 .Ignore(b => b.RatioValue);
            });
        }
    }
}
