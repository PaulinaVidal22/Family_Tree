namespace Library
{
    public class OldestChildVisitor : IVisitor
    {
        public Node OldestChild { get; private set; }

        public void Visit(Node node)
        {
            if (!node.Visited)
            {
                if (node.Children.Count == 0) // for verifying that is a leaf node
                {
                    if (OldestChild == null || node.Person.Age > OldestChild.Person.Age)
                    {
                        OldestChild = node;
                    }
                }

                node.Visited = true;

                foreach (var child in node.Children)
                {
                    Visit(child);
                }
            }
        }
    }
}