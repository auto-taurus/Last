using System.Composition.Hosting;
using System.Reflection;

namespace OnLineStoreCore.DataLayer.Configurations
{
	public class AutoNewsEntityMapper : EntityMapper
	{
		public AutoNewsEntityMapper()
		{
			// Get current assembly
			var currentAssembly = typeof(AutoNewsDbContext).GetTypeInfo().Assembly;
			
			// Get configuration for container from current assembly
			var configuration = new ContainerConfiguration().WithAssembly(currentAssembly);
			
			// Create container for exports
			using (var container = configuration.CreateContainer())
			{
				// Get all definitions that implement IEntityMap interface
				Configurations = container.GetExports<IEntityTypeConfiguration>();
			}
		}

	}
}
