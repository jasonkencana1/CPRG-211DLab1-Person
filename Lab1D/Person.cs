using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1D
{
    internal class Person
    {

        private int personId;
        private string firstName;
        private string lastName;
        private string favoriteColour;
        private int age;
        private bool isWorking;


        //methods
       /* public void DisplayPersonInfo()
        {
            Console.WriteLine(firstName+ " " + lastName);
            Console.WriteLine(this.firstName+ "'s favorite colour is " + this.favoriteColour);
        }*/

        public void DisplayList()
        {
            List<Object> newlist = new List<Object>();
            newlist.Add(this.personId);
            newlist.Add(this.firstName);
            newlist.Add(this.lastName);
            newlist.Add(this.favoriteColour);
            newlist.Add(this.age);
            newlist.Add(this.isWorking);
            foreach (object item in newlist)
            {
                Console.WriteLine(item.ToString());
            }
        }


        public string ChangeFavouriteColor()
        {
            this.favoriteColour = "White";
            return this.favoriteColour;
        }

        public int GetAgeTenYears() 
        { 
            int newAge = age+10;

            return newAge;
        }

        public override string ToString()
        {
            string formatted = "";

            formatted += "Person ID : " + personId + "\n";
            formatted += "First Name : " + firstName + "\n";
            formatted += "Last Name : " + lastName + "\n";
            formatted += "Favourite Color : " + favoriteColour + "\n";
            formatted += "Age : " + age + "\n";
            formatted += "Is Working : " + isWorking;
            return formatted;
        }


        //properties
        public int Id
        {
            get
            {
                return this.personId;
            }
        }
        public string FirstName
        {
            get
            {
                return this.firstName;
            }
        }
        public string LastName
        {
            get
            {
                return this.lastName;
            }
        }
        public string FavoriteColour 
        { 
            get
            {
                return this.favoriteColour;
            }
        }
        public int Age 
        { 
            get
            {
                return this.age;
            }
        }
        public bool IsWorking 
        { 
            get 
            {
                return this.isWorking;
            }
        }

        public Person(int personId, string firstName, string lastName, string favoriteColour, int age, bool isWorking)
        {
            this.personId = personId;
            this.firstName = firstName;
            this.lastName = lastName;
            this.favoriteColour = favoriteColour;
            this.age = age;
            this.isWorking = isWorking;
        }



    }
}
