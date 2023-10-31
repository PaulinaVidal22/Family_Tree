namespace Library
{
    public class LongestNameVisitor : IVisitor
    {
        public string LongestName { get; private set; }
        
        public void Visit(Node node)
        {
            if (!node.Visited)
            {
                if (LongestName == null || node.Person.Name.Length > LongestName.Length )
                {
                    LongestName = node.Person.Name;
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