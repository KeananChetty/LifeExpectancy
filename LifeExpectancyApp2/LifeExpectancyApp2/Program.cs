using LifeExpectancyApp2.Risks;
using System;

namespace LifeExpectancyApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person(Gender.Male);
            //var smoking = new Smoking();
            //var drinking = new Drinking();

            Question smokingQ = new Question(TypeOfQ.Smoking, "Have you smoked before?");
            Question drinkingQ = new Question(TypeOfQ.Drinking, "Do you drink alcohol before?");
            Question Driving = new Question(TypeOfQ.Driving, "Do you drive recklessly?");
            Exercise exercise = new Exercise();


            smokingQ.LifeExpectancy(person);
            drinkingQ.LifeExpectancy(person);
            Driving.LifeExpectancy(person);
            exercise.LifeExpectancy(person);
            //smoking.LifeExpectancy(person);
            //drinking.LifeExpectancy(person);

            //Console.WriteLine(person.MaxAge());
        }
    }
}
