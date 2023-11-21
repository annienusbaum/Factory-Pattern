using System;
namespace FactoryPattern
{
	public class Dragon : ICreature
	{
		public void PerformSpecialAction()
        {
            Console.WriteLine("Your wish is my command. We can fly and breath fire on anyone who may get in our way.");
        }
    }

}

