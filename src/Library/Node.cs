using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public class Node
    {
        private Person person;

        private List<Node> children = new List<Node>();
        public bool Visited { get; set; }

        public Person Person {
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
        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
            foreach (var child in Children)
            {
                child.Accept(visitor);
            }
        }

    }
}
