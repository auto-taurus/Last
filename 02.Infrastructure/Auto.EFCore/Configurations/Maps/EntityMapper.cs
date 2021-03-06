using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Auto.EFCore.Configurations.Maps
{
	public class EntityMapper : IEntityMapper
	{
		public EntityMapper()
		{
		}

		public IEnumerable<IEntityTypeConfiguration> Configurations { get; set; }

		public void ConfigureEntities(ModelBuilder modelBuilder)
		{
			foreach (var item in Configurations)
			{
				item.Configure(modelBuilder);
			}
		}
	}
}
