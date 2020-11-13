using System;
namespace ColossalCaveAdventureGame

	// ToDo -- Change Location to use properties as usual
{
	public class ColossalCaveAdventureGame
	{
		World ourWorld;
		Location currentLocation;
		string command = "";

		public ColossalCaveAdventureGame()
		{
			ourWorld = new World();
			currentLocation = ourWorld.startingLocation;
		}
		
		void runIt()
        {
			while (command != "exit")
			{
				Console.WriteLine(">");
				command = Convert.ToString(Console.ReadLine());
				processCommand(command);
			}
		}

		void processCommand(string userInput)
        {
			switch (userInput)
			{
				case "n":
				case "N":
					moveNorth();
					break;
				case "e":
				case "E":
				moveEast();
					break;
				case "w":
				case "W":
					moveWest();
					break;
				case "s":
				case "S":
					moveSouth();
					break;
				case "exit":
					doAQuit();
					break;
				case "look":
					currentLocation.describeMe();
					break;
			}
        }

		void moveNorth()
        {
			Location nextStep = currentLocation.getNorthneighbor();
			if (nextStep != null)
            {
				currentLocation = nextStep;
				currentLocation.describeMe();
            }
        }
		void moveSouth()
		{
			Location nextStep = currentLocation.getSouthneighbor();
			if (nextStep != null)
			{
				currentLocation = nextStep;
				currentLocation.describeMe();
			}
		}
		void moveEast()
		{
			Location nextStep = currentLocation.getEastneighbor();
			if (nextStep != null)
			{
				currentLocation = nextStep;
				currentLocation.describeMe();
			}
		}
		void moveWest()
		{
			Location nextStep = currentLocation.getWestneighbor();
			if (nextStep != null)
			{
				currentLocation = nextStep;
				currentLocation.describeMe();
			}
		}
		 void doAQuit()
        {
			Environment.Exit(0);
		}
		static void Main(string[] args)
		{
			Console.WriteLine("Welcome to the Jungle Temple!");
			Console.WriteLine("\nAre you ready to play? Y/N");
			bool ready = false;
			string answer;
			do
			{
				answer = Convert.ToString(Console.ReadLine());
				if (answer == "y")
					//read variable, check to see if variable is y or n
				{
					ready = true;
					Console.WriteLine("\nHere we go!");
				}
				else
				{
					Console.WriteLine("Y/N");
					Environment.Exit(1);
				}
			}
			while (!ready);

			ColossalCaveAdventureGame game = new ColossalCaveAdventureGame();
			game.runIt();

			World d = new World();
		}	
	}
}