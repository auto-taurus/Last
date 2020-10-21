using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Composition.Hosting;
using System.Reflection;

namespace Auto.Configurations {
    public class EntityMapper : IEntityMapper {
        public EntityMapper() {
            var currentAssembly = typeof(NewsContext).GetTypeInfo().Assembly;
            // Get configuration for container from current assembly
            var configuration = new ContainerConfiguration().WithAssembly(currentAssembly);
            // Create container for exports
            using (var container = configuration.CreateContainer()) {
                // Get all definitions that implement IEntityMap interface
                Configurations = container.GetExports<IConfigurations>();
            }
        }
        public IEnumerable<IConfigurations> Configurations { get; set; }
        public void ConfigureEntities(ModelBuilder modelBuilder) {
            foreach (var item in Configurations) {
                item.Configure(modelBuilder);
            }
        }
    }
}
