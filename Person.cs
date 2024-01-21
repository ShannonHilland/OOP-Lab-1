using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    internal class Person
    {
        public int personId { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string favoriteColour { get; set; }
        public int age { get; set; }
        public bool isWorking { get; set; }  

        public Person(int personId, string firstName, string lastName, string favoriteColour, int age, bool isWorking)
        {
            this.personId = personId;
            this.firstName = firstName;
            this.lastName = lastName;
            this.favoriteColour = favoriteColour;
            this.age = age;
            this.isWorking = isWorking;
        }

        public void DisplayPersonInfo()
        {
            string Name = this.firstName + " " + this.lastName;
            Console.WriteLine($"{this.personId}: {Name}'s favorite colour is {this.favoriteColour}");
        }
         public void ChangeFavoriteColour()
        {
            this.favoriteColour = "White";
        }

        public string GetAgeInTenYears()
        {
            return $"{this.firstName} {this.lastName}'s Age in 10 years is: {this.age + 10}";
        }
        
         public override string ToString()
        {   
            return $"Person ID: {personId}\nFirst Name: {firstName}\nLast Name: {lastName}\nFavorite Colour: {favoriteColour}\nAge: {age}\nIs Working: {isWorking}";
        }
    }
}
