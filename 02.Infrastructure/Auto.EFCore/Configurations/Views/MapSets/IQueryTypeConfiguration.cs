using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Auto.EFCore.Configurations.Views {
    public interface IQueryTypeConfiguration {
        void Configure(ModelBuilder modelBuilder);
    }
}
