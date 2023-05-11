using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        StreamReader streamReader = new StreamReader("input.txt");
        string[] input = streamReader.ReadLine().Split();
        int n = int.Parse(input[0]);
        int m = int.Parse(input[1]);

        List<Edge> edges = new List<Edge>();
        for (int i = 0; i < m; i++)
        {
            input = streamReader.ReadLine().Split();
            int a = int.Parse(input[0]);
            int b = int.Parse(input[1]);
            int c = int.Parse(input[2]);
            edges.Add(new Edge(a, b, c));
        }

        edges.Sort();

        int s1 = Kruskal(n, edges);
        int s2 = Kruskal(n, edges.Skip(1).ToList());

        StreamWriter streamWriter = new StreamWriter("output.txt");
        streamWriter.WriteLine($"{s1} {s2}");
        streamWriter.Close();
    }
    static int Kruskal(int n, List<Edge> edges)
    {
        int[] parent = new int[n + 1];
        for (int i = 1; i <= n; i++)
            parent[i] = i;

        int cost = 0;
        foreach (Edge edge in edges)
        {
            if (parent[edge.A] != parent[edge.B])
            {
                cost += edge.C;
                int oldParent = parent[edge.B];
                for (int i = 1; i <= n; i++)
                {
                    if (parent[i] == oldParent)
                        parent[i] = parent[edge.A];
                }
            }
        }

        return cost;
    }
}

class Edge : IComparable<Edge>
{
    public int A { get; }
    public int B { get; }
    public int C { get; }

    public Edge(int a, int b, int c)
    {
        A = a;
        B = b;
        C = c;
    }

    public int CompareTo(Edge other)
    {
        return C.CompareTo(other.C);
    }
}