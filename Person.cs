using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class Person
    {
        private int id;
        private string firstName;
        private string lastName;
        private int age;
        private string favoriteColor;
        private bool isWorking;

        //have get/set for the private 
        public int Id
        {
            get { return this.id; }
            set { this.id = value; }
        }

        public string FirstName
        {
            get { return this.firstName; }  
            set { this.firstName = value; }
        }

        public string LastName
        {
            get { return this.lastName; }   
            set { this.lastName = value; }  
        }

        public int Age
        {
            get { return this.age; }    
            set { this.age = value; }
        }

        public string FavoriteColor
        {
            get { return this.favoriteColor; }
            set { this.favoriteColor = value; }
        }

        public bool IsWorking
        {
            get
            {
                /*
                string working;

                if (this.isWorking == true)
                {
                    working = "True";
                }
                else
                {
                    working = "False";
                }

                return working;
                */
                return this.isWorking;
            }
            set { this.isWorking = value; }
        }

        public Person(int id, string firstName, string lastName, string favoriteColor, int age, bool isWorking) 
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.favoriteColor = favoriteColor;
            this.isWorking = isWorking;
        } 

        public override string ToString() 
        {
            string format = "";

            format += "ID: " + id + "\n";
            format += "First Name: " + firstName + "\n";
            format += "Last Name: " + lastName + "\n";
            format += "Age: " + age + "\n";
            format += "Favorite color: " + favoriteColor + "\n";
            format += "Is working: " + isWorking + "\n";
            return format;
        }

        public string ChangeFavoriteColor()
        {
            return favoriteColor = "white";
        }

        public string DisplayPersonInfo()
        {
            string name;
            name = firstName + " " +lastName;
            return name;
        }

        public int GetAgeInTenYears()
        {
            return age + 10;
        }
    }
}
