using Auto.EFCore.Dto;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Auto.EFCore.Configurations.Views {
    public class WebSpecialView : IQueryTypeConfiguration<WebSpecialDto> {
        public void Configure(QueryTypeBuilder<WebSpecialDto> builder) {
            builder.ToView("WebSpecialDto");
        }
    }
}
