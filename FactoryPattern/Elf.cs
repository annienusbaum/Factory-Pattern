using System;
namespace FactoryPattern
{
	public class Elf : ICreature
	{
		public void PerformSpecialAction()
		{
			Console.WriteLine("Casting a magical spell, your wish is my command.! At your service, I am an elegant elf.");
        }
    }
	
}

