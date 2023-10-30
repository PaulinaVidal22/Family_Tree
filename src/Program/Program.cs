using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Person MaternalGrandFather = new Person(85, "Carlos", "Masculine");
            Person MaternalGrandMother = new Person(83, "Rosa", "Femenine");
            Person PaternalGrandFather = new Person(75, "Juan", "Masculine");
            Person PaternalGrandMother = new Person(72, "Alicia", "Femenine");
            Person Father = new Person(50, "Fernando", "Masculine");
            Person Mother = new Person(52, "Mariana", "Femenine");
            Person Son1 = new Person(18, "Benjamín", "Masculine");
            Person Daughter = new Person(16, "Emma", "Femenine");
            Person Son2 = new Person(5, "Milo", "Masculine");


            Node n1 = new Node(MaternalGrandFather);
            Node n2 = new Node(MaternalGrandMother);
            Node n3 = new Node(PaternalGrandFather);
            Node n4 = new Node(PaternalGrandMother);
            Node n5 = new Node(Father);
            Node n6 = new Node(Mother);
            Node n7 = new Node(Son1);
            Node n8 = new Node(Daughter);
            Node n9 = new Node(Son2);

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

            
            // visitar el árbol aquí

        }
    }
}
