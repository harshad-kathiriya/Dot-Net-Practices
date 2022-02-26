
using System;
using System.Collections.Generic;

namespace DotnetPractice.Practice
{   
    class DFSGraph
    {
        private int V;
        private List<int>[] adj;

        public DFSGraph(int v)
        {
            V=v;

            adj = new List<int>[v];
            for(int i=0; i< v; i++)
            {
                adj[i] = new List<int>();
            }
        }

        public void AddEdge(int v, int w)
        {
            adj[v].Add(w);
        }

        public void DFSUtil(int v, bool[] visited)
        {
            visited[v] = true;
            Console.Write(v + " ");

            List<int> vList = adj[v];

            foreach(var n in vList)
            {
                if(!visited[n])
                    DFSUtil(n, visited);
            }
        }

        public void DFS(int v)
        {
            bool[] visited = new bool[V];

            DFSUtil(v, visited);
        }

    }



}