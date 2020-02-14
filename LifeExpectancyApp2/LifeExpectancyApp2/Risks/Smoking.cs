using System;
using System.Collections.Generic;
using System.Text;

namespace LifeExpectancyApp2.Risks
{
    public class Smoking : Person
    {
        public override void LifeExpectancy(Person person)
        {
            string input;
            try
            {
                do
                {
                    Console.WriteLine("Have you smoked before? \nA) Yes \nB) No");
                    input = Console.ReadLine();
                    if (input == "A" || input == "a")
                    {
                        person.personAge -= 5;
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
                } while (input != "a" && input != "A"&& input != "B" && input != "b");
            }
            catch(Exception Error)
            {
                Console.WriteLine(Error.Message);
            }
        }
    }
}
