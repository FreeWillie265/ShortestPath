namespace DijkstrasAlgorithm;

public class Edge
{
    public Edge(Vertex vertex1, Vertex vertex2)
    {
        Vertex1 = vertex1;
        Vertex2 = vertex2;
        Weight = 1;
    }
    public Vertex Vertex1 { get; set; }
    public Vertex Vertex2 { get; set; }
    public int Weight { get; set; } = 1;
}