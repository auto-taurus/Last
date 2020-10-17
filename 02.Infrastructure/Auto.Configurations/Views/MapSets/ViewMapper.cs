using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Auto.Configurations.Views.MapSets {

    public class ViewMapper : IViewMapper {
        public ViewMapper() {
        }
        public IEnumerable<IQueryTypeConfiguration> Configurations { get; set; }
        public void ConfigureEntities(ModelBuilder modelBuilder) {
            foreach (var item in Configurations) {
                item.Configure(modelBuilder);
            }
        }
    }
}
