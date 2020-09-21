using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Auto.EFCore.Configurations.Entities {
    public interface IEntityMapper {
        IEnumerable<IEntityTypeConfiguration> Configurations { get; }

        void ConfigureEntities(ModelBuilder modelBuilder);
    }
}
