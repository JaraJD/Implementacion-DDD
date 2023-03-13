using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calibracion.DDD.Domain.CommonsDDD
{
	public class Identity
	{
		public Guid Uuid { get; set; }

		public Identity(Guid uuid)
		{
			if (uuid == Guid.Empty)
				throw new ArgumentException("Id no puede ser vacio");
			this.Uuid = uuid;
		}
	}
}
