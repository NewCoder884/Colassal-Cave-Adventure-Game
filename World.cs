using System;

public class World
{
	public Location startingLocation;
	public World()
	{
		//Console.WriteLine("\nEntering Constructor for Wor
		
		Location c = new Location();

		//Console.WriteLine("Location Succesful");
		c.setName("Carnival");
		c.setDescription("large and bustling with children");
		//starting location

		Location directions = new Location();
		directions.setName("city");
		directions.setDescription("a jungle of concrete and brick");

		Location directionsII = new Location();
		directionsII.setName("seaport");
		directionsII.setDescription("smelly and muddy");

		c.setEastneighbor(directionsII);

		c.setWestneighbor(directions);

		c.setEastneighbor(c);

		directionsII.setWestneighbor(c);

		c.describeMe();

		directions.describeMe();

		directionsII.describeMe();

		//c.setNorthneighbor(directions);

		//directions.setSouthneighbor(c);

		//directions.setNorthneighbor(directionsII);

		//directions.setWestneighbor(directionsII);

		//directionsII.setSouthneighbor(directions);

		//directionsII.setWestneighbor(c);

		//directionsII.setEastneighbor(directions);

	}
}


