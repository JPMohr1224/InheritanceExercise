using System;
namespace Inheritance
{
	public class Bird : Animal
	{

		public int howManyWings;
		public string name;
		public bool isASongbird;
		public string color;

		public void introduce()
		{
			Console.WriteLine($"Ths is a {name}, it has {howManyWings} wings.");
		}
	}
}

