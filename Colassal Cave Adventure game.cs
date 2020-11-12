using System;
namespace ColossalCaveAdventureGame

	// ToDo -- Change Location to use properties as usual
{
	public class ColossalCaveAdventureGame
	{
		public ColossalCaveAdventureGame()
		{

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

			World d = new World();
		}	
	}
}