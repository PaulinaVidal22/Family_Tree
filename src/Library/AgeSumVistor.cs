namespace Library
{
    public class AgeSumVisitor : IVisitor
{
    public int TotalAge { get; private set; }

    public void Visit(Node node)
    {
        if (!node.Visited)
        {
            TotalAge += node.Person.Age;
            node.Visited = true;
            
            foreach (var child in node.Children)
            {
                Visit(child);
            }
        }
    }
}

}
