using Microsoft.EntityFrameworkCore;

namespace OnLineStoreCore.DataLayer.Configurations
{
	public interface IEntityTypeConfiguration
	{
		void Configure(ModelBuilder modelBuilder);
	}
}
