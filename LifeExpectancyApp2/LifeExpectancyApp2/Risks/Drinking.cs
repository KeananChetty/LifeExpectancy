using System;
using System.Collections.Generic;
using System.Text;

namespace LifeExpectancyApp2.Risks
{
    class Drinking : Person 
    {
        public override void LifeExpectancy(Person person)
        {
            string input;
            try
            {
                do
                {
                    Console.WriteLine("Do you drink alcohol before? \nA) Yes \nB) No");
                    input = Console.ReadLine();
                    if (input == "A" || input == "a")
                    {
                        person.personAge -= 4;
                        Console.WriteLine(person.personAge);
                    }
                    else if (input == "B" || input == "b")
                    {
                        Console.WriteLine("Your Good.");
                    }
                    else
                    {
                        Console.WriteLine("Invalid Input");
                    }
                } while (input != "a" && input != "A" && input != "B" && input != "b");
            }
            catch (Exception Error)
            {
                Console.WriteLine(Error.Message);
            }
        }
    }
}
