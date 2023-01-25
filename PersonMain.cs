using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class PersonMain
    {
        static void Main(string[] args)
        {
            Person person1 = new Person(1,"Ian", "Brooks", "Red", 30, true);
            Person person2 = new Person(2,"Gina","James", "Green", 18, false);
            Person person3 = new Person(3, "Mike", "Briscoe", "blue", 45, true);
            Person person4 = new Person(4, "Mary", "Beals", "Yellow", 28, true);

            

            //Display's Gina info as a sentence that shows her id, name, and favorite color
            Console.WriteLine(person2.FirstName + " " + person2.LastName + " her id is: " + person2.Id + " her favorite color is: " + person2.FavoriteColor);

            //display all of Mike's info as a list
            Console.WriteLine(person3.ToString());

            //change Ian's favorite color to white, than display it in a sentence
            person1.ChangeFavoriteColor();
            Console.WriteLine(person1.FirstName + " " + person1.LastName + " id is: " + person1.Id + " his favorite color is: " + person1.FavoriteColor);

            //Display Mary's age after 10 years
            Console.WriteLine( person4.DisplayPersonInfo() + "'s age in 10 years is going to be: " + person4.GetAgeInTenYears());

           List<Person> people= new List<Person>();

            people.Add(person1);    
            people.Add(person2);
            people.Add(person3);
            people.Add(person4);

            //It works if I do it all in one for loop
            //However it doesn't print it in the order I want it to
            double age = 0;
            double ageAverage;
            for (int i = 0; i < people.Count; i++)
            {
                age += people[i].Age;
            }

            ageAverage = age / people.Count;
            Console.WriteLine("The average age is: " + ageAverage);

            int max = people[0].Age;
            int min = people[0].Age;

            for (int i = 0; i < people.Count; i++)
            {
                if (people[i].Age > max)
                {
                    max = people[i].Age;
                    string maxName = people[i].DisplayPersonInfo();
                    Console.WriteLine("The Oldest person is " + maxName + " and is " + max + " years old");
                }

                if (people[i].Age < min)
                {
                    min = people[i].Age;
                    string minName = people[i].DisplayPersonInfo();
                    Console.WriteLine("The youngest age is " + minName + " and is " + min + " years old");
                }
            }


            for (int i = 0; i < people.Count; i++)
            {
                string name = people[i].FirstName;
                char nameChar = name[0];

                if (nameChar == 'M')
                {
                    Console.WriteLine("First letter of their name start with a 'M' is " + people[i].DisplayPersonInfo());
                }

            }

            for (int i = 0; i < people.Count; i++)
            {
                string color = people[i].FavoriteColor;
                if (color == "blue")
                {
                    Console.WriteLine("The people who like the color blue are: \n" + people[i].ToString() );
                }

            }

        }
    }
}
