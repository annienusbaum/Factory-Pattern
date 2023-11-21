using FactoryPattern;

public static class CreatureFactory
{
    public static ICreature GetCreature(string choice)
    {
        switch(choice)
        {
            case "dragon":
                return new Dragon();
            case "elf":
                return new Elf();
            default:
                return new Dragon();
        }
       
    }
}


//static method called
//// static GetCreature(string choice)
/// switch (choice)
/// {
/// case "elf":
/// case "dragon":
/// default:
/// break;
/// }
/// MISSING RETURN TYPE
/// ICREATURE IS THE RETURN TYPE