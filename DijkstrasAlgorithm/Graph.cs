namespace DijkstrasAlgorithm;

public class Graph
{
    public List<Edge> Edges { get; set; } = new();
    public List<Vertex> Vertices { get; set; } = new();
    
    const int Infinity = 9999999;
    const int Undefined = -1;

    void Dijkstra(int sourceIndex)
    {
        if (sourceIndex == Undefined)
        {
            Console.WriteLine("Source is undefined");
            return;
        }

        int currentVertex;

        for (int i = 0; i < Vertices.Count; i++)
        {
            Vertices[i].pathLength = Infinity;
            Vertices[i].processed = false;
            Vertices[i].predecessor = Undefined;
        }
        
        Vertices[sourceIndex].pathLength = 0;

        while (true)
        {
            currentVertex = MinLengthVertexIndex();
            if (currentVertex == Undefined)
                return;
            
            Vertices[currentVertex].processed = true;

            for (int i = 0; i < Vertices.Count; i++)
            {
                if (IsAdjacent(currentVertex, i) && !Vertices[i].processed)
                {
                    if (Vertices[currentVertex].pathLength + GetWeight(currentVertex, i) < Vertices[i].pathLength)
                    {
                        Vertices[i].pathLength = Vertices[currentVertex].pathLength + GetWeight(currentVertex, i);
                        Vertices[i].predecessor = currentVertex;
                    }
                }
            }
        }
    }

    int MinLengthVertexIndex()
    {
        int min = Infinity;
        int index = Undefined;

        for (int i = 0; i < Vertices.Count; i++)
        {
            if (!Vertices[i].processed && Vertices[i].pathLength < min)
            {
                min = Vertices[i].pathLength;
                index = i;
            }
        }

        return index;
    }
    
    int GetWeight(int vertex1, int vertex2)
    {
        return 1;
    }
    
    void FindShortestPath(int source, int destination)
    {
        List<string> path = new List<string>(Enumerable.Repeat<string>(null, 100));
        int count = 0;

        while (source != destination)
        {
            path[count] = Vertices[destination].name;
            var predecessor = Vertices[destination].predecessor;
            GetWeight(predecessor, destination);
            destination = predecessor;
            count++;
        }

        Console.WriteLine("The shortest path is: ");
        Console.Write(Vertices[source].name);
        for (int i = count; i > 0; i--)
        {
            Console.Write(path[i] + " -> ");
        }
        Console.WriteLine(path[0]);
    }
    
    int GetIndexOfVertex(string vertex)
    {
        for (int i = 0; i < Vertices.Count; i++)
        {
            if (Vertices[i].name.Equals(vertex))
            {
                return i;
            }
        }
        return Undefined;
    }
    
    public void AddVertex(string vertex)
    {
        Vertices.Add(new Vertex(vertex));
    }
    
    public void AddEdge(int vertex1, int vertex2)
    {
        var v1 = Vertices[vertex1];
        var v2 = Vertices[vertex2];
        Edges.Add(new Edge(v1, v2));
    }
    
    bool IsAdjacent(int vertex1, int vertex2)
    {
        foreach (var edge in Edges)
        {
            if ((edge.Vertex1 == Vertices[vertex1] && edge.Vertex2 == Vertices[vertex2]) ||
                (edge.Vertex1 == Vertices[vertex2] && edge.Vertex2 == Vertices[vertex1]))
                return true;
        }
        return false;
    }
    
    public void Execute(string source, string destination)
    {
        int sourceIndex = GetIndexOfVertex(source);
        int destinationIndex = GetIndexOfVertex(destination);

        if (sourceIndex == Undefined)
        {
            Console.WriteLine("Source vertex not found");
            return;
        }
        if (destinationIndex == Undefined)
        {
            Console.WriteLine("Destination vertex not found");
            return;
        }
        
        Dijkstra(sourceIndex);
        FindShortestPath(sourceIndex, destinationIndex);
    }
}