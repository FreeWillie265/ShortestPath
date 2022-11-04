// See https://aka.ms/new-console-template for more information

using DijkstrasAlgorithm;

void addVerticies(Graph graph)
{
    graph.AddVertex("Bunda_Turnoff"); //0.
    graph.AddVertex("Ma_Tank_Petroda"); //1.
    graph.AddVertex("Institute_for_Youth"); //2.
    graph.AddVertex("Likuni_RB"); //3.
    graph.AddVertex("Town_Hall_RB"); //4.
    graph.AddVertex("Shoprite"); //5.
    graph.AddVertex("Mchinji_RB"); //6
    graph.AddVertex("CrossRoads_RB"); //7
    graph.AddVertex("Chilambula_RB"); //8
    graph.AddVertex("KCH_RB"); //9
    graph.AddVertex("Bwandiro_TJ"); //10
    graph.AddVertex("Lilongwe_Sanctuary"); //11
    graph.AddVertex("Bingu_Stadium_RB"); //12
    graph.AddVertex("Area18_Interchange"); //13
    graph.AddVertex("Parliament_RB"); //14
    graph.AddVertex("Area25"); //15
    graph.AddVertex("Kanengo"); //16
}

void addEdges(Graph graph)
{
    //Bunda_Turnoff
    graph.AddEdge(0, 1);
    graph.AddEdge(0, 3);
    
    // Ma_Tank_Petroda
    graph.AddEdge(1, 2);
    graph.AddEdge(1, 4);
    
    // Institute_for_Youth
    graph.AddEdge(2, 11);
    
    // Likuni_RB
    graph.AddEdge(3, 6);
    graph.AddEdge(3, 4);
    
    // Town_Hall_RB
    graph.AddEdge(4, 5);
    
    // Shoprite
    graph.AddEdge(5, 7);
    graph.AddEdge(5, 9);
    
    // Mchinji_RB
    graph.AddEdge(6, 12);
    graph.AddEdge(6, 7);
    
    // CrossRoads_RB
    graph.AddEdge(7, 8);
    graph.AddEdge(7, 10);
    
    // Chilambula_RB
    graph.AddEdge(8, 9);
    graph.AddEdge(8, 10);
    
    // KCH_RB
    graph.AddEdge(9, 11);
    
    // Bwandiro_TJ
    graph.AddEdge(10, 13);
    
    // Lilongwe_Sanctuary
    graph.AddEdge(11, 14);
    
    // Bingu_Stadium_RB
    graph.AddEdge(12, 13);
    graph.AddEdge(12, 15);
    
    // Area18_Interchange
    graph.AddEdge(13, 14);
    graph.AddEdge(13, 16);
    
    // Parliament_RB
    
    // Area25
    graph.AddEdge(15, 16);
}

void main()
{
    int exit = 0;

    Graph graph = new Graph();
    addVerticies(graph);
    addEdges(graph);
    
    string source = "";
    string destination = "";

    while (exit == 0)
    {
        Console.WriteLine("Choose a landmark from the following: \n" +
                          "Bunda_Turnoff, Ma_Tank_Petroda, Institute_for_Youth, Likuni_RB \n" +
                          "Town_Hall_RB, Shoprite, Mchinji_RB, CrossRoads_RB \n" +
                          "Chilambula_RB, KCH_RB, Bwandiro_TJ, Lilongwe_Sanctuary \n" +
                          "Bingu_Stadium_RB, Area18_Interchange, Parliament_RB, Area25, Kanengo \n\n");
        Console.WriteLine("Enter source: ");
        source = Console.ReadLine();
        Console.WriteLine("Enter destination: ");
        destination = Console.ReadLine();

        graph.Execute(source, destination);
        Console.WriteLine("Do you want to exit? (1 for yes, 0 for no)");
        exit = Convert.ToInt32(Console.ReadLine());
    }
}

main();