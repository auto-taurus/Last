using Microsoft.EntityFrameworkCore;

namespace Auto.Configurations {
    public interface IConfigurations {
        void Configure(ModelBuilder modelBuilder);
    }
}
