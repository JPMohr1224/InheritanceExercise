using System;
namespace Inheritance
{
	public class Reptile : Animal
	{
		public bool venomous;
		public string landOrSea;
		public string whatContinent;
		public bool extinct;

		public void whatIsIt()
		{
			Console.WriteLine($"This is {Name}, he is {Age}.");
		}



		
	}
}

