
namespace Lab_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create four objects
            Person Ian = new Person(1, "Ian", "Brooks", "Red", 30, true);
            Person Gina = new Person(2, "Gina", "James", "Green", 18, false);
            Person Mike = new Person(3, "Mike", "Briscoe", "Blue", 45, true);
            Person Mary = new Person(4, "Mary", "Beals", "Yellow", 28, true);

            //Display Gina's info in sentence
            Gina.DisplayPersonInfo();

            //Display Mike's info in list
            Console.WriteLine(Mike.ToString());

            //Change Ian's favourite colour, and display
            Ian.ChangeFavoriteColour();
            Ian.DisplayPersonInfo();

            //Display Mary's age in 10 years
            Console.WriteLine(Mary.GetAgeInTenYears());

            //Create two relationships and display
            Relation relation1 = new Relation("Gina", "Mary");
            Relation relation2 = new Relation("Ian", "Mike");
            relation1.ShowRelationShip();
            relation2.ShowRelationShip();

            //add all person objects into a list
            List<Person> PersonList = new List<Person>();
            PersonList.Add(Ian); PersonList.Add(Gina); PersonList.Add(Mike); PersonList.Add(Mary);

            //Display average age
            float age = 0;
            foreach (Person person in PersonList)
            {
                age += (float)person.age;
            }
            float averageAge = age / PersonList.Count;
            Console.WriteLine($"Average age is: {averageAge}");

            //Display the youngest and oldest person
            int youngest = 100;
            string youngestPerson = "";
            foreach (Person person in PersonList)
            {
                if (person.age < youngest)
                {
                    youngest = person.age;
                    youngestPerson = person.firstName;
                }
            }
            Console.WriteLine($"The youngest person is: {youngestPerson}");
            int oldest = 0;
            string oldestPerson = "";
            foreach (Person person in PersonList)
            {
                if (person.age > oldest)
                {
                    oldest = person.age;
                    oldestPerson = person.firstName;
                }
            }
            Console.WriteLine($"The oldest person is: {oldestPerson}");

            //Display people whose name starts with "M"
            foreach (Person person in PersonList)
            {
                char firstChar = person.firstName[0];
                if (firstChar == 'M')
                {
                    Console.WriteLine(person.ToString());
                }
            }

            //Display people that like the colour blue
            foreach (Person person in PersonList)
            {
                if (person.favoriteColour == "Blue")
                {
                    Console.WriteLine(person.ToString());
                }
            }
        }

     
    }
}
