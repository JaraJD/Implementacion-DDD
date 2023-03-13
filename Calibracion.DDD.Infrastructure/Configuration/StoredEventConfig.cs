using Calibracion.DDD.Domain.Generics;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calibracion.DDD.Infrastructure.Configuration
{
	public class StoredEventConfig : IEntityTypeConfiguration<StoredEvent>
	{
		public void Configure(EntityTypeBuilder<StoredEvent> builder)
		{
			builder.ToTable("storedEvent");

			builder.HasKey(p => p.StoredId);
		}
	}
}
