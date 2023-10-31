using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            //creating the different people that composes our family tree.
            Person MaternalGrandFather = new Person(85, "Carlos", "Masculine");
            Person MaternalGrandMother = new Person(83, "Rosa", "Femenine");
            Person PaternalGrandFather = new Person(75, "Juan", "Masculine");
            Person PaternalGrandMother = new Person(72, "Alicia", "Femenine");
            Person Father = new Person(50, "Fernando", "Masculine");
            Person Mother = new Person(52, "Mariana", "Femenine");
            Person Son1 = new Person(18, "Benjamín", "Masculine");
            Person Daughter = new Person(16, "Emma", "Femenine");
            Person Son2 = new Person(5, "Milo", "Masculine");


            // creating the different nodes
            Node n1 = new Node(MaternalGrandFather);
            Node n2 = new Node(MaternalGrandMother);
            Node n3 = new Node(PaternalGrandFather);
            Node n4 = new Node(PaternalGrandMother);
            Node n5 = new Node(Father);
            Node n6 = new Node(Mother);
            Node n7 = new Node(Son1);
            Node n8 = new Node(Daughter);
            Node n9 = new Node(Son2);

            // adds children to the different nodes
            n1.AddChildren(n6);
            n2.AddChildren(n6);

            n3.AddChildren(n5);
            n4.AddChildren(n5);

            n5.AddChildren(n7);
            n5.AddChildren(n8);
            n5.AddChildren(n9);
            n6.AddChildren(n7);
            n6.AddChildren(n8);
            n6.AddChildren(n9);


            var ageSumVisitor = new AgeSumVisitor();

            // Then, perform the age sum calculation by calling Visit on all nodes of interest.
            n1.Accept(ageSumVisitor); // MaternalGrandFather
            n2.Accept(ageSumVisitor); // MaternalGrandMother
            n3.Accept(ageSumVisitor); // PaternalGrandFather
            n4.Accept(ageSumVisitor); // PaternalGrandMother

            // Get the sum of ages
            int totalAge = ageSumVisitor.TotalAge;
            Console.WriteLine("Sum of the family ages: " + totalAge);

            // Gets the oldest child
            OldestChildVisitor oldestChildVisitor = new OldestChildVisitor();

            n1.Accept(oldestChildVisitor); // Visits to find the bigger child (leaf node).
            n2.Accept(oldestChildVisitor);
            n3.Accept(oldestChildVisitor);
            n4.Accept(oldestChildVisitor);

            Node oldestChild = oldestChildVisitor.OldestChild;

            if (oldestChildVisitor.OldestChild != null)
            {
                Console.WriteLine($"The older child : {oldestChild.Person.Name}");
            } else
            {
                Console.WriteLine("no child was found (leaf node).");
            }

            // Gets the child with the longest name
            LongestNameVisitor longestNameVisitor = new LongestNameVisitor();

            n1.Accept(longestNameVisitor); // Visits to find the child with the longest name.
            n2.Accept(longestNameVisitor);
            n3.Accept(longestNameVisitor);
            n4.Accept(longestNameVisitor);

            string longestName = longestNameVisitor.LongestName;

            if (!string.IsNullOrEmpty(longestName))
            {
                Console.WriteLine($"The longest name : {longestName}");
            }
            else
            {
                Console.WriteLine("No name was found in the family tree.");
            }
        }
    }
}
