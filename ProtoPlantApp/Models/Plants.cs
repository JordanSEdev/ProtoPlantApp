using System;

namespace ProtoPlantApp.Models
{
	public record Plants(
		string name,
		string description,
		DateTime FirstDateTime,
		DateTime LastDateTime,
		DateTime NextDateTime,
		Uri Image,
		List<string> Family,
		List<string> Environment);

		
	
}

