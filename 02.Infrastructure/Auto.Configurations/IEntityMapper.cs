using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Auto.Configurations {
    public interface IEntityMapper {
        IEnumerable<IConfigurations> Configurations { get; }

        void ConfigureEntities(ModelBuilder modelBuilder);
    }
}
