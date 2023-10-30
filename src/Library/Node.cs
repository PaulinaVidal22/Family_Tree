using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public class Node
    {
        private Person person;

        private List<Node> children = new List<Node>();

<<<<<<< HEAD
<<<<<<< HEAD
        public int Number
        {
=======
        public Person Person {
>>>>>>> b8f7f7c353e91824d03df65dcb9283e2b7fd3594
=======
        public Person Person {
>>>>>>> 7a4ba13662763abb122fc1758773366a07df2230
            get
            {
                return this.person;
            }
        }

        public ReadOnlyCollection<Node> Children 
        {
            get
            {
                return this.children.AsReadOnly();
            }
        }

        public Node(Person person)
        {
            this.person = person;
        }

        public void AddChildren(Node n)
        {
            this.children.Add(n);
        }
    }
}
