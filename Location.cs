using System;

public class Location
{

	Location northNeighbor;
	Location southNeighbor;
	Location eastNeighbor;
	Location westNeighbor;

	public Location()
	{
		//Console.WriteLine("Entering Constructor for Location");
	}

	public string Name;
	
	public string Description;

	public string getName()
	{
		return Name;
	}

	public void setName(string arg)
	{
		Name = arg;
	}

	public string getDescription()
	{
		return Description;
	}

	public void setDescription(string arg)
	{
		Description = arg;
		//Console.WriteLine("Hello");
	}

	public void describeMe()
	{
		Console.WriteLine("\nThe {0} is {1}.",
			getName(), getDescription());

		if (!(getEastneighbor() is null))
			Console.WriteLine("East of the {0} there is a {1}", getName(), this.getEastneighbor().getName());

		if (!(getWestneighbor() is null))
			Console.WriteLine("West of the {0} there is a {1}", getName(), this.getWestneighbor().getName());

		if (!(getNorthneighbor() is null))
			Console.WriteLine("North of the {0} there is a {1}", getName(), this.getNorthneighbor().getName());

		if (!(getSouthneighbor() is null))
			Console.WriteLine("South of the {0} there is a {1}", getName(), this.getSouthneighbor().getName());
	}

//--------------------------------------------------------------------------------------------------------------------------------------------------------
	
	public Location getNorthneighbor()
	{
		return northNeighbor;
	}	

    public void setNorthneighbor(Location arg)
	{
		northNeighbor = arg;
	}

	public Location getSouthneighbor()
	{
		return southNeighbor;
	}

	public void setSouthneighbor(Location arg)
	{
		southNeighbor = arg;
	}

	public Location getEastneighbor()
	{
		return eastNeighbor;
	}

	public void setEastneighbor(Location arg)
	{
		eastNeighbor = arg;
	}

	public Location getWestneighbor()
	{
		return westNeighbor;
	}

	public void setWestneighbor(Location arg)
	{
		westNeighbor = arg;
	}
}