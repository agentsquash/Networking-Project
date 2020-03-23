using System;
using System.Collections.Generic;
using System.Text;

namespace Networking_Project
{
	class Networking
	{
		protected bool status;
		public Networking()
		{
			bool input_valid = false;

			Console.WriteLine("Welcome to The Game!\n");
			Console.WriteLine("1: Connect to a game");
			Console.WriteLine("2: Host a game");
			Console.WriteLine("\n0: Quit the game");
			do
			{
				input_valid = true;
				
			} while (!input_valid);
		}
	}
}
