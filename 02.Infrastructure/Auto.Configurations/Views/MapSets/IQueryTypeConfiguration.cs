using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Auto.Configurations.Views.MapSets {
    public interface IQueryTypeConfiguration {
        void Configure(ModelBuilder modelBuilder);
    }
}
