using System;
using System.Collections.Generic;
using System.Text;

namespace LifeExpectancyApp2.Risks
{
    public class Exercise : Person 
    {
        public override void LifeExpectancy(Person person)
        {
            string input;
            int Life = 4;
            try
            {
                do
                {
                    Console.WriteLine("Do you Exercise? \nA) Yes \nB) No");
                    input = Console.ReadLine();
                    if (input == "A" || input == "a")
                    {
                        Console.WriteLine("Your Good.");
                    }
                    else if (input == "B" || input == "b")
                    {
                        person.personAge -= Life;
                        Console.WriteLine(person.personAge);
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
