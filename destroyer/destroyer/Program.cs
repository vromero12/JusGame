using System;

namespace JusGame
{
	class Program 
	{
		static void Main(string[] args)
		{
			string yourName;
			while (true) {
				Console.WriteLine ("What is your name?");

				yourName = Console.ReadLine ();

				if (yourName == "Gabe") {
					Console.WriteLine ("you expire go to the depth of the underworld {0}", yourName);
				} else {
					Console.WriteLine ("live you must!"); 
					while (true) {
						Console.Write ("Do you want to play again [Y/N]?");
						string answer = Console.ReadLine ().ToUpper ();
						if (answer == "Y")
							break; 
						if (answer == "N")
							return;
					}
				}
			}
		}
	}
}