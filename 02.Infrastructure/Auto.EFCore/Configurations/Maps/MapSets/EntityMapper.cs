using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Auto.EFCore.Configurations.Entities {

    public class EntityMapper : IEntityMapper {
        public EntityMapper() {
        }
        public IEnumerable<IEntityTypeConfiguration> Configurations { get; set; }
        public void ConfigureEntities(ModelBuilder modelBuilder) {
            foreach (var item in Configurations) {
                item.Configure(modelBuilder);
            }
        }
    }
}
