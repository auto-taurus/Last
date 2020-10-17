using System;
using System.Collections.Generic;
using System.Composition.Hosting;
using System.Reflection;
using System.Text;

namespace Auto.Configurations.Views.MapSets {
    public class AutoNewsViewMapper : ViewMapper {
        public AutoNewsViewMapper() {
            // Get current assembly
            var currentAssembly = typeof(AutoNewsContext).GetTypeInfo().Assembly;

            // Get configuration for container from current assembly
            var configuration = new ContainerConfiguration().WithAssembly(currentAssembly);

            // Create container for exports
            using (var container = configuration.CreateContainer()) {
                // Get all definitions that implement IEntityMap interface
                Configurations = container.GetExports<IQueryTypeConfiguration>();
            }
        }

    }
}
