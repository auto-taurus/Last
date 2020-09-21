using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace OnLineStoreCore.DataLayer.Configurations
{
	public interface IEntityMapper
	{
		IEnumerable<IEntityTypeConfiguration> Configurations { get; }

		void ConfigureEntities(ModelBuilder modelBuilder);
	}
}
