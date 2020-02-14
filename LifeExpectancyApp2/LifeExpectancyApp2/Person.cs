using System;
using System.Collections.Generic;
using System.Text;

namespace LifeExpectancyApp2
{
    public enum Gender 
    {
    Male,
    Female
    }
    public class Person
    {
        public Gender _gender { get; set; }
        public int personAge { get; set; }

        private int maxpersonAgeMale = 65;
        private int maxpersonAgeFemale = 70;

      

        public Person()
        {

        }

        public Person(Gender gender)
        {
            _gender = gender;

            if (_gender == Gender.Male)
            {
                personAge = maxpersonAgeMale;
            }
            else if (_gender == Gender.Female)
            {
                personAge = maxpersonAgeFemale;
            }
        }

        public virtual void LifeExpectancy(Person person)
        {

        }
    }
}
