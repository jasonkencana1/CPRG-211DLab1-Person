using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Lab1D
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person(1, "Ian", "Brooks", "Red", 30, true);
            Person person2 = new Person(2, "Gina", "James", "Green", 18, false);
            Person person3 = new Person(3, "Mike", "Briscoe", "Blue", 45, true);
            Person person4 = new Person(4, "Mary", "Beals", "Yellow", 28, true);

            Console.WriteLine(person2.Id + ": " + person2.FirstName + " " + person2.LastName + "'s favorite colour is " + person2.FavoriteColour);
            person3.DisplayList();
            Console.WriteLine(person1.Id + ": " + person1.FirstName + " " + person1.LastName + "'s favorite colour is: " + person1.ChangeFavouriteColor());
            Console.WriteLine(person4.FirstName + " " + person4.LastName + "'s Age in 10 years is: " + person4.GetAgeTenYears());

            List<Person> PersonObject = new List<Person>();
            PersonObject.Add(person1);
            PersonObject.Add(person2);
            PersonObject.Add(person3);
            PersonObject.Add(person4);

            int total = 0;

            foreach (Person person in PersonObject)
            {
                total += person.Age;
            }

            double average = (double)total / 4;
            Console.WriteLine("Average age is: " + average);


            //create a variable (youngestPerson) that
            //consists the first index of the object, if the person age on the list is less than
            //youngestPerson than the youngestPerson will become the person on that list 

            Person youngestPerson = PersonObject[0];
            Person oldestPerson = PersonObject[0];
            
            foreach (Person person in PersonObject)
            {
                if(person.Age < youngestPerson.Age) 
                { 
                    youngestPerson = person;
                }
                if(person.Age > oldestPerson.Age)
                {
                    oldestPerson = person;
                }
            }

            Console.WriteLine("the youngest person is: " + youngestPerson.FirstName);
            Console.WriteLine("the oldest person is: " + oldestPerson.FirstName);

            foreach (Person person in PersonObject)
            {
                if (person.FirstName.StartsWith("M"))
                    {
                        Console.WriteLine(person);
                    }
            }

            foreach (Person person in PersonObject)
            {
                if (person.FavoriteColour == "Blue")
                    {
                        Console.WriteLine(person);
                    }
            }

        }

    }
    
}
