using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Auto.Configurations.Views.MapSets {
    public interface IViewMapper {
        IEnumerable<IQueryTypeConfiguration> Configurations { get; }

        void ConfigureEntities(ModelBuilder modelBuilder);
    }
}
