using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Auto.EFCore.Configurations.Entities {
    public interface IEntityTypeConfiguration {
        void Configure(ModelBuilder modelBuilder);
    }
}
