using Microsoft.EntityFrameworkCore;

namespace Auto.Configurations.Maps
{
	public interface IEntityTypeConfiguration
	{
		void Configure(ModelBuilder modelBuilder);
	}
}
