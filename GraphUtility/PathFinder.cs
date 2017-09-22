using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphUtility
{
    public abstract class PathFinder
    {
        public enum PathFindingAlrogithm
        {
            Dijkstra,
        }
        public delegate void OnVertexProgress<T>(PathSetFromVertex<T> pathSetFromVertex);
        public delegate void OnGraphProgress<T>(PathSetForGraph<T> pathSetForGraph);
        public delegate int Compare<T>(T t1, T t2);

        public class PathFinderOptions<T>
        {
            public bool Parallel;
            public OnVertexProgress<T> OnVertexProgress;
            public OnGraphProgress<T> OnGraphProgress;
            public Compare<T> OnCompare;
        }

        public abstract PathSetForGraph<T> FindPathsForGraph<T>(Graph<T> graph, PathFinderOptions<T> options);
        public abstract PathSetFromVertex<T> FindPathsFromVertex<T>(Graph<T> graph, Vertex<T> vertex, PathFinderOptions<T> options);

        public static PathFinder Get(PathFindingAlrogithm algorithm)
        {
            switch (algorithm)
            {
                case PathFindingAlrogithm.Dijkstra:
                    {
                        return new DijkstraPathFinder();
                    }
            }
            return null;
        }
    }

    public class DijkstraPathFinder: PathFinder
    {
        public override PathSetForGraph<T> FindPathsForGraph<T>(Graph<T> graph, PathFinderOptions<T> options)
        {
            if (options == null || options.OnCompare == null)
            {
                return null;
            }

            PathSetForGraph<T> result = new PathSetForGraph<T>(graph);
            options?.OnGraphProgress?.Invoke(result);
            foreach (KeyValuePair<string, Vertex<T>> pair in graph.Vertices)
            {
                result[pair.Value] = FindPathsFromVertex<T>(graph, pair.Value, options);
                options?.OnGraphProgress?.Invoke(result);
            }
            return result;
        }

        public override PathSetFromVertex<T> FindPathsFromVertex<T>(Graph<T> graph, Vertex<T> vertex, PathFinderOptions<T> options)
        {
            if (options == null || options.OnCompare == null)
            {
                return null;
            }
            PathSetFromVertex<T> result = new PathSetFromVertex<T>(graph, vertex);
            List<Vertex<T>> todoVertices = new List<Vertex<T>>();
            foreach (KeyValuePair<string, Vertex<T>> pair in graph.Vertices)
            {
                todoVertices.Add(pair.Value);
            }

            todoVertices.Remove(vertex);

            Edge<T> tempEdge = null;

            options?.OnVertexProgress?.Invoke(result);

            foreach (Edge<T> edge in vertex.Out)
            {
                if (tempEdge == null)
                {
                    tempEdge = edge;
                }
                else
                {
                    tempEdge = options.OnCompare(edge.Value, tempEdge.Value) < 0 ? edge : tempEdge;
                }
            }
            if (tempEdge == null)
            {
                return result;
            }
            todoVertices.Remove(tempEdge.Target);

            options?.OnVertexProgress?.Invoke(result);

            result[tempEdge.Target] = result[tempEdge.Source] + tempEdge;

            while (todoVertices.Count > 0)
            {
                tempEdge = null;

                // find closest untouched vertex
                foreach (KeyValuePair<string, Edge<T>> pair in graph.Edges)
                {
                    if ((result[pair.Value.Source] != null) && todoVertices.Contains(pair.Value.Target))
                    {
                        if (tempEdge == null)
                        {
                            tempEdge = pair.Value;
                        }
                        else
                        {
                            int compareResult = options.OnCompare(
                                graph.Sum(result[vertex].Value, pair.Value.Value),
                                graph.Sum(result[vertex].Value, tempEdge.Value)
                            );
                            if (compareResult < 0)
                            {
                                tempEdge = pair.Value;
                            }
                        }
                    }
                }

                if (tempEdge == null)
                {
                    break;
                }
                todoVertices.Remove(tempEdge.Target);

                foreach (Edge<T> inEdge in tempEdge.Target.In)
                {
                    if (result[inEdge.Source] != null)
                    {
                        if (result[inEdge.Target] == null)
                        {
                            result[inEdge.Target] = result[inEdge.Source] + inEdge;
                        }
                        else
                        {
                            int compareResult = options.OnCompare(
                                graph.Sum(result[inEdge.Source].Value, inEdge.Value),
                                result[inEdge.Target].Value
                            );
                            // if parallel
                            // {
                            if (compareResult < 0)
                            {
                                result[inEdge.Target].Paths.Clear();
                            }
                            if (compareResult <= 0)
                            {
                                result[inEdge.Target].Paths.AddRange((result[inEdge.Source] + inEdge).Paths);
                            }
                            // }
                        }
                    }
                }

                foreach (Edge<T> outEdge in tempEdge.Target.Out)
                {
                    if (result[outEdge.Target] != null)
                    {
                        int compareResult = options.OnCompare(
                                graph.Sum(result[outEdge.Source].Value, outEdge.Value),
                                result[outEdge.Target].Value
                            );
                        // if parallel
                        // {
                        if (compareResult < 0)
                        {
                            result[outEdge.Target].Paths.Clear();
                        }
                        if (compareResult <= 0)
                        {
                            result[outEdge.Target].Paths.AddRange((result[outEdge.Source] + outEdge).Paths);
                        }
                        // }
                    }
                }

                options?.OnVertexProgress?.Invoke(result);
            }

            return result;
        }
    }
}
