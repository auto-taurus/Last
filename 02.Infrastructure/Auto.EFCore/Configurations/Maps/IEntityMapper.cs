using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Auto.EFCore.Configurations.Maps
{
	public interface IEntityMapper
	{
		IEnumerable<IEntityTypeConfiguration> Configurations { get; }

		void ConfigureEntities(ModelBuilder modelBuilder);
	}
}
