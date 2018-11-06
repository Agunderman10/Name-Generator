using System;

namespace NameGenerator
{
    class NameGeneratorClass : NamesContainer
    {
        static void Main(string[] args)
        {

            //asks user for desired name gender
            Console.WriteLine("Are you looking for a boy or girl name?");
            //assigns user specified gender to gender variable
            string gender = Console.ReadLine();

            //initilizes random class
            Random rand = new Random();

            
            //if user wants a boy name...
            if(gender.Equals("boy") || gender.Equals("Boy"))
            {
                //sets index of the array to a random number in between 0 and BoysNames length
                int BoysIndex = rand.Next(0, BoysNames.Length);
                //prints a random index of the array as a name
                Console.WriteLine(BoysNames[BoysIndex]);
            }
            //if user wants a girl name...
            else if(gender.Equals("girl") || gender.Equals("Girl"))
            {
                //sets index of the array to a random number in between 0 and GirlsNames length
                int GirlsIndex = rand.Next(0, GirlsNames.Length);
                //prints a random index of the array as a name
                Console.WriteLine(GirlsNames[GirlsIndex]);
            }
            else
            {
                Console.WriteLine("Error. Gender is invalid. Make sure you specified either a 'boy' or a 'girl'.");
            }

            //keeps the console window from closing
            while(true)
            {
                string exitCommand = Console.ReadLine();
                if(exitCommand.Equals("exit") || exitCommand.Equals("Exit"))
                {
                    Environment.Exit(0);
                }
            }
        }
    }
}
