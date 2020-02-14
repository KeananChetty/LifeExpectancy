using System;
using System.Collections.Generic;
using System.Text;

namespace LifeExpectancyApp2.Risks
{
    public enum TypeOfQ
    {
        Drinking = 5,
        Smoking = 4,
        Driving = 2,
    }
    public class Question : Person
    {
        public TypeOfQ Type { get; set; }
        public string QuestionName { get; set; }
        public Question(TypeOfQ type, string questionname)
        {
            Type = type;
            QuestionName = questionname;
        }

        public override void LifeExpectancy(Person person)
        {
            string input;
            try
            {
                do
                { 
                    Console.WriteLine($"{QuestionName} \nA) Yes \nB) No");
                    input = Console.ReadLine();
                    if (input == "A" || input == "a")
                    {
                        person.personAge -= (int)Type;
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
