using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.FrameworkCore
{
	public interface ISchedulableResource
	{
		/// <summary>
		/// Specifies if <see cref="ISchedulableItem"/> can be schedule without this
		/// </summary>
		bool Required { get; set; }
	}
}
