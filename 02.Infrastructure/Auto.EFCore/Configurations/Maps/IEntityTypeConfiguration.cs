using Microsoft.EntityFrameworkCore;

namespace Auto.EFCore.Configurations.Maps
{
	public interface IEntityTypeConfiguration
	{
		void Configure(ModelBuilder modelBuilder);
	}
}
