using System.Data.SqlTypes;

namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What kind of creature do you want?");
            string userInput = Console.ReadLine();

            ICreature mythicalCreature = CreatureFactory.GetCreature(userInput);
            mythicalCreature.PerformSpecialAction();


            mythicalCreature.PerformSpecialAction();
        }
    }
}





// PROGRAM.CS EXAMPLE -------------------------------------------------------------------------------------
//  using System;

//namespace FactoryPatternApp
//{
//class Program
// {
//  static void Main(string[] args)
// {
//     //Ask the user for the phone they wish to create
//    Console.WriteLine("What kind of phone do you want to create?");
//    string userPhone = Console.ReadLine();

//Choose the correct type of phone to create through the factory method that implements the ICallable interface
//     ICallable phone = PhoneFactory.GetPhone(userPhone);
//     phone.Build();
//    Console.ReadLine();
//}}}


//ICallable phone = PhoneFactory.GetPhone(userPhone);:
//This line declares a variable named phone of type ICallable and assigns it the result of the GetPhone method from the PhoneFactory class.
///The PhoneFactory class is expected to implement a method that returns an object that implements the ICallable interface.

//string userPhone = Console.ReadLine();: This line declares a variable named userPhone and assigns it the value entered by the user using Console.ReadLine().
//Console.ReadLine() reads the next line of characters from the standard input stream.
//ICallable phone = PhoneFactory.GetPhone(userPhone);:
////This line declares a variable named phone of type ICallable and assigns it the result of the GetPhone method from the PhoneFactory class.
/////The PhoneFactory class is expected to implement a method that returns an object that implements the ICallable interface.


//***********Example of bad practice************//

//Console.WriteLine("What kind of phone do you want to create?");
//string userPhone = Console.ReadLine();

//if (userPhone.ToLower() == "android")
//{
//    AndroidPhone android = new AndroidPhone();
//    android.Build();
//    Console.ReadLine();
//}
//else if (userPhone.ToLower() == "apple")
//{
//    ApplePhone apple = new ApplePhone();
//    apple.Build();
//    Console.ReadLine();
//}
//else if (userPhone.ToLower() == "iphone")
//{
//    ApplePhone apple = new ApplePhone();
//    apple.Build();
//    Console.ReadLine();
//}
//else if (userPhone.ToLower() == "google")
//{
//    GooglePhone google = new GooglePhone();
//    google.Build();
//    Console.ReadLine();
//}
//else
//{
//    AndroidPhone android = new AndroidPhone();
//    android.Build();
//    Console.ReadLine();
//}
//    }
// }
//}
//------------------------------------------------------------------------------------------------------------


//ORIGINAL INSTRUCTIONS DO NOT EDIT! 16 LINES BELOW--------------------------------------------------------------------------------------------------------------------------
//Create a console app that utilizes factory pattern by taking a user’s input of how many tires are on a vehicle and, based on their input, creates that type of vehicle.
//Complete this using an interface. You must have at least 2 subclasses.
//For instance, if I type 4 into the console, the program would create a car or truck, or if someone types 2 it would create a motorcycle.

//Feel free to use something other than vehicles if you want to be creative, but the other constraints still apply!


//Create an Interface named IVehicle that has a stubbed out public void Drive method.
//Create 2 new public classes that will conform to IVehicle.
//Example) Car, Motorcycle, BigRig
//Note: These classes must conform to IVehicle and implement the Drive() method - which will just Console.WriteLine(“Building a new Car!”)

//Now we will make our static VehicleFactory class.
//It will contain a static method GetVehicle(), that will return an IVehicle based on the amount of tires it’s given as a parameter
//Call this functionality in the Main method.
//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------


//MY VERSION OF THE ORIGINAL INSTRUCTIONS DO NOT EDIT! 16 LINES BELOW--------------------------------------------------------------------------------------------------------------------------
//Create a console app that utilizes factory pattern by taking a user’s input of what part of their skin they want to focus on, based on their input, creates that type beauty product.
//Complete this using an interface. You must have at least 2 subclasses.
//For instance, if I type face into the console, the program would create a cleanser or lotion, or if someone types body it would create a perfume.

//Create an Interface named IVehicle that has a stubbed out public void Drive method.
//Create 2 new public classes that will conform to IVehicle.
//Example) Car, Motorcycle, BigRig
//Note: These classes must conform to IVehicle and implement the Drive() method - which will just Console.WriteLine(“Building a new Car!”)

//Now we will make our static VehicleFactory class.
//It will contain a static method GetVehicle(), that will return an IVehicle based on the amount of tires it’s given as a parameter
//Call this functionality in the Main method.



//program cs. 
//  Console.WriteLine("What be of phone do you want to create?");
//   string userPhone = Console.ReadLine();

//  //Choose the correct type of phone to create through the factory method that implements the ICallable interface
//ICallable phone = PhoneFactory.GetPhone(userPhone);
//phone.Build();
//Console.ReadLine();


