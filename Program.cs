// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");

UndirectedGraph g1 = new();

DirectedGraph d1 = new();

g1.AddEdge(2, 5);
d1.AddEdge(2, 5);



// Undirected graph

// Graph class
public class UndirectedGraph
{
    // List to store the edges in the graph
    List<Tuple<int, int>> edges = new();

    // Method to add an edge to the graph
    public void AddEdge(int u, int v)
    {
        edges.Add(new Tuple<int, int>(u, v));
    }
}

// Directed graph

// Graph class
public class DirectedGraph
{
    // Dictionary to store the edges in the graph
    Dictionary<int, List<int>> edges = new Dictionary<int, List<int>>();

    // Method to add an edge to the graph
    public void AddEdge(int u, int v)
    {
        if (!edges.ContainsKey(u))
            edges.Add(u, new List<int>());

        edges[u].Add(v);
    }
}
