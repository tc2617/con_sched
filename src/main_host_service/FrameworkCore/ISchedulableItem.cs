using System.Collections.Generic;

namespace Framework.FrameworkCore
{
	public interface ISchedulableItem
	{
		string Name { get; set; }
		string Description { get; set; }
		decimal Duration { get; set; }
		ICollection<ISchedulableResource> Resources { get; }
	}
}
