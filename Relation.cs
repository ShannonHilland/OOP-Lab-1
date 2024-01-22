using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    internal class Relation
    {
        private string person1;
        private string person2;
        private enum RelationType {Sister, Brother, Mother, Father };

        public Relation(string first, string second)  
        {
            person1 = first;
            person2 = second;
        }

        public void ShowRelationShip()
        {
            if ((person1 == "Gina" && person2 == "Mary") || (person1 == "Mary" && person2 == "Gina")) {
                Console.WriteLine($"Relationship between {person1} and {person2} is: {RelationType.Sister.ToString()}hood");
            }
            if ((person1 == "Ian" && person2 == "Mike") || (person1 == "Mike" && person2 == "Ian"))
            {
                Console.WriteLine($"Relationship between {person1} and {person2} is: {RelationType.Brother.ToString()}hood");
            }
            else
            {
                Console.WriteLine($"There is no relationship between {person1} and {person2}");
            }
            
        }
    }
}
