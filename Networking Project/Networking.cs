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
			Console.WriteLine("Welcome to The Game!\n");
			Console.WriteLine("1: Connect to a game");
			Console.WriteLine("2: Host a game");
			Console.WriteLine("\n0: Quit the game\n");
			GetConnectionType();
		}
		private void GetConnectionType()
		{
			bool input_valid = true;
			string user_input;
			int validated_input;

			do
			{
				Console.Write("Please select an option: ");
				user_input = Console.ReadLine();
				input_valid = Int32.TryParse(user_input, out validated_input);
				if (input_valid)
				{
					switch (validated_input)
					{
						case 1:
							status = false;
							break;
						case 2:
							status = true;
							break;
						case 0:
							Environment.Exit(0);
							break;
						default:
							input_valid = false;
							break;
					}
				}

				if (!input_valid)
					Console.WriteLine("Invalid input.\n");
			} while (!input_valid);
		}

		private void SetupHost()
		{

		}
	}
}
