using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    internal class Relation
    {
        private enum RelationType {Sister, Brother, Mother, Father};
        private string relation;

        public Relation(string r)  
        {
            relation = r;
            //person2 = second;
        }

        public void ShowRelationShip(Person p1, Person p2)
        {
            if(this.relation == "sister") 
            { 
                Console.WriteLine($"Relationship between {p1.firstName} and {p2.firstName} is: {RelationType.Sister.ToString()}hood");
            }
            if (this.relation == "brother")
            {
                Console.WriteLine($"Relationship between {p1.firstName} and {p2.firstName} is: {RelationType.Brother.ToString()}hood");
            }
           
        }
    }
}
