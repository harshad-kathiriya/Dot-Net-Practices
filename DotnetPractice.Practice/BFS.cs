
// C# program to print BFS traversal
// from a given source vertex.
// BFS(int s) traverses vertices
// reachable from s.

using System;
using System.Collections.Generic;
using System.Linq;

namespace DotnetPractice.Practice
{
    class BFSGraph
    {
        private int _V;
        LinkedList<int>[] _adj;

        public BFSGraph(int V)
        {
            _adj = new LinkedList<int>[V];
            for(int i=0; i< _adj.Length; i++)
            {
                _adj[i] = new LinkedList<int>();
            }
            _V = V;
        }

        public void AddEdge(int v, int w)
        {
            _adj[v].AddLast(w);
        }

        public void BFS(int s)
        {
            bool[] visited = new bool[_V];

            for(int i=0; i<_V; i++)
            {
                visited[i] = false;
            }

            LinkedList<int> queue = new LinkedList<int>();
            visited[s] = true;
            queue.AddLast(s);

            while (queue.Any())
            {
               // dequeue a vertex from queue and print it
               s = queue.First();
               Console.Write(s + " ");
               queue.RemoveFirst();

               LinkedList<int> list = _adj[s];

               foreach (var val in list)
               {
                   if(!visited[val])
                   {
                       visited[val] = true;
                       queue.AddLast(val);
                   }
               }     
            }

        }
    }
}

