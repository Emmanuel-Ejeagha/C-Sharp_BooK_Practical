using System;

namespace Chpt17TreeAndGraph;
/// <summary>Represents a directed unweighted graph structure
public class Graph
{
    // Contains the child nodes for each vertex of the graph
    // assuming that the vertices are numbered 0 ... Size-1
    private List<int>[] childNodes;

    /// <summary>Constructs an empty graph of given size
    /// <param name="size>number of vertices</param>
    public Graph(int size)
    {
        this.childNodes = new List<int>[size];
        for (int i = 0; i < size; i++)
        {
            // Assing an empty list of adjacents for each vertex
            this.childNodes[i] = new List<int>();
        }
    }
    /// <summary>Constructs a graph by given list of child nodes (successors) for each verte</summary>
    /// <param name="childNode">children for each node</param>
    public Graph(List<int>[] childNode)
    {
        this.childNodes = childNode;
    }

    /// <summary>Returns the size of the graph (number of vertices)</summary>
    public int Size
    {
        get { return this.childNodes.Length; }
    }

    /// <summary>Adds new edge from u to v</summary>
    /// <param name="u">the stating vertex</param>
    /// <param name="v">the ending vertex</param>
    public void AddEdge(int u, int v)
    {
        childNodes[u].Add(v);
    }

    /// <summary>Checks whether there is an edge between vertex u and v</summary>
    /// <param name="u">the stating vertex</param>
    /// <param name="v">the ending vertex</param>
    /// <returns>true if there is an edge between vertex u and vertex v</returns>
    public bool HasEdge(int u, int v)
    {
        bool hasEdge = childNodes[u].Contains(v);
        return hasEdge;
    }

    /// <summary>Returns the successors of a given vertex</summary>
    /// <param name="v">The vertex</param>
    /// <returns>List of all successors of vertex v</returns>
    public IList<int> GetSuccessors(int v)
    {
        return childNodes[v];
    }


}
