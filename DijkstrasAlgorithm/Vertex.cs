namespace DijkstrasAlgorithm;

public class Vertex
{
    public Vertex(string name)
    {
        this.name = name;
    }
    public string name { get; set;}
    public bool processed { get; set; }
    public int pathLength { get; set; }
    public int predecessor { get; set; }
}