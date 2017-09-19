using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphUtility
{
    public static class GraphUtility
    {
        public delegate void OnProgress(double progress);
        public static OnProgress OnFindAllPathsProgress;
        public static OnProgress OnFindPathProgress;

        public static Dictionary<Vertex<T>, Dictionary<Vertex<T>, List<Path<T>>>> FindAllPaths<T>(Graph<T> graph)
        {
            Dictionary<Vertex<T>, Dictionary<Vertex<T>, List<Path<T>>>> result = new Dictionary<Vertex<T>, Dictionary<Vertex<T>, List<Path<T>>>>();
            OnFindAllPathsProgress?.Invoke(result.Count / (double)graph.Vertices.Count);
            foreach (KeyValuePair<string, Vertex<T>> pair in graph.Vertices)
            {
                result[pair.Value] = FindPathsForVertex<T>(graph, pair.Value);
                OnFindAllPathsProgress?.Invoke(result.Count / (double)graph.Vertices.Count);
            }
            return result;
        }

        private static T QueryValue<T>(Graph<T> graph, Dictionary<Vertex<T>, List<Path<T>>> result, Vertex<T> source, Vertex<T> target)
        {
            if (source == target)
            {
                return default(T);
            }
            else
            {
                return result[target][0].Value;
            }
        }

        private static T ConcatinatedValue<T>(Graph<T> graph, Dictionary<Vertex<T>, List<Path<T>>> result, Vertex<T> source, Edge<T> extension)
        {
            return graph.Plus(QueryValue<T>(graph, result, source, extension.Source), extension.Value);
            if (extension.Source == source)
            {
                return extension.Value;
            }
            else
            {
                return graph.Plus(result[extension.Source][0].Value, extension.Value);
            }
        }

        public static Dictionary<Vertex<T>, List<Path<T>>> FindPathsForVertex<T>(Graph<T> graph, Vertex<T> vertex)
        {

            Dictionary<Vertex<T>, List<Path<T>>> result = new Dictionary<Vertex<T>, List<Path<T>>>();
            List<Vertex<T>> todoVertices = new List<Vertex<T>>();
            foreach (KeyValuePair<string, Vertex<T>> pair in graph.Vertices)
            {
                todoVertices.Add(pair.Value);
            }

            todoVertices.Remove(vertex);

            Edge<T> tempEdge = null;

            OnFindPathProgress?.Invoke((graph.Vertices.Count - todoVertices.Count) / (double)graph.Vertices.Count);

            foreach (Edge<T> edge in vertex.Out)
            {
                if (tempEdge == null)
                {
                    tempEdge = edge;
                }
                else
                {
                    tempEdge = graph.Comparer.Compare(edge.Value, tempEdge.Value) < 0 ? edge : tempEdge;
                }
            }
            if (tempEdge == null)
            {
                return result;
            }
            todoVertices.Remove(tempEdge.Target);
            OnFindPathProgress?.Invoke((graph.Vertices.Count - todoVertices.Count) / (double)graph.Vertices.Count);

            result[tempEdge.Target] = new List<Path<T>>()
                {
                    new Path<T>(graph),
                };
            result[tempEdge.Target][0].Route.Add(tempEdge);

            while (todoVertices.Count > 0)
            {
                tempEdge = null;

                // find closest untouched vertex
                foreach (KeyValuePair<string, Edge<T>> pair in graph.Edges)
                {
                    if ((result.ContainsKey(pair.Value.Source) || pair.Value.Source == vertex) && todoVertices.Contains(pair.Value.Target))
                    {
                        if (tempEdge == null)
                        {
                            tempEdge = pair.Value;
                        }
                        else
                        {
                            int compareResult = graph.Comparer.Compare(
                                ConcatinatedValue<T>(graph, result, vertex, pair.Value),
                                ConcatinatedValue<T>(graph, result, vertex, tempEdge)
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

                result[tempEdge.Target] = Concatinate<T>(graph, result, vertex, tempEdge.Source, tempEdge);

                foreach (Edge<T> outEdge in tempEdge.Target.Out)
                {
                    if ((result.ContainsKey(outEdge.Target))|| outEdge.Target == vertex)
                    {
                        int compareResult = graph.Comparer.Compare(
                                ConcatinatedValue<T>(graph, result, vertex, outEdge),
                                QueryValue<T>(graph, result, vertex, outEdge.Target)
                            );
                        if (compareResult < 0)
                        {
                            result[outEdge.Target].Clear();
                        }
                        if (compareResult <= 0)
                        {
                            result[outEdge.Target].AddRange(Concatinate<T>(graph, result, vertex, outEdge.Source, outEdge));
                        }
                    }
                }

                OnFindPathProgress?.Invoke((graph.Vertices.Count - todoVertices.Count) / (double)graph.Vertices.Count);
            }

            return result;
        }

        private static List<Path<T>> Concatinate<T>(Graph<T> graph, Dictionary<Vertex<T>, List<Path<T>>> result, Vertex<T> source, Vertex<T> target, Edge<T> extension)
        {
            List<Path<T>> tempPaths = new List<Path<T>>();
            if (source == target)
            {
                Path<T> tempPath = new Path<T>(graph);
                tempPath.Route.Add(extension);
                tempPaths.Add(tempPath);
            }
            else
            {
                foreach (Path<T> path in result[target])
                {
                    Path<T> tempPath = new Path<T>(graph);
                    tempPath.Route.AddRange(path.Route);
                    tempPath.Route.Add(extension);
                    tempPaths.Add(tempPath);
                }
            }
            return tempPaths;
        }

    }


    // peer edges not allowed
    public class Graph<T>
    {
        public string Name;
        public bool Directional = false;
        public delegate T PlusDelegate(T t1, T t2);
        public PlusDelegate Plus;
        public IComparer<T> Comparer;
        private Dictionary<string, Vertex<T>> _Vertices = new Dictionary<string, Vertex<T>>();
        public Dictionary<string, Vertex<T>> Vertices { get { return _Vertices; } }
        private Dictionary<string, Edge<T>> _Edges = new Dictionary<string, Edge<T>>();
        public Dictionary<string, Edge<T>> Edges { get { return _Edges; } }

        public T this[string source, string target]
        {
            get
            {
                foreach (KeyValuePair<string, Edge<T>> pair in this.Edges)
                {
                    if (pair.Value.Source.Name == source && pair.Value.Target.Name == target)
                    {
                        return pair.Value.Value;
                    }
                }
                return default(T);
            }
            set
            {
                if (!Vertices.ContainsKey(source))
                {
                    Vertices[source] = new Vertex<T>(this) { Name = source };
                }
                if (!Vertices.ContainsKey(target))
                {
                    Vertices[target] = new Vertex<T>(this) { Name = target };
                }
                bool found = false;
                foreach (KeyValuePair<string, Edge<T>> pair in this.Edges)
                {
                    if (pair.Value.Source.Name == source && pair.Value.Target.Name == target)
                    {
                        found = true;
                        pair.Value.Value = value;
                        break;
                    }
                }
                if (!found)
                {
                    Edge<T> positiveEdge = new Edge<T>(this)
                    {
                        Name = Vertices[source].Name + " -> " + Vertices[target].Name,
                        Source = Vertices[source], Target = Vertices[target],
                        Value = value,
                    };
                    positiveEdge.Source.Out.Add(positiveEdge);
                    positiveEdge.Target.In.Add(positiveEdge);
                    this.Edges[positiveEdge.Name] = positiveEdge;

                    if (!Directional)
                    {
                        Edge<T> negativeEdge = new Edge<T>(this)
                        {
                            Name = Vertices[target].Name + " -> " + Vertices[source].Name,
                            Source = Vertices[target],
                            Target = Vertices[source],
                            Value = value,
                        };
                        negativeEdge.Source.Out.Add(negativeEdge);
                        negativeEdge.Target.In.Add(negativeEdge);
                        this.Edges[negativeEdge.Name] = negativeEdge;
                    }
                }
            }
        }
    }

    public class VertexPaths<T>: IGraphElement<T>
    {
        public Graph<T> Graph { get; }
        public Vertex<T> Source { get; }

        public bool MultiPaths { get; }

        private Dictionary<Vertex<T>, List<Path<T>>> paths = new Dictionary<Vertex<T>, List<GraphUtility.Path<T>>>();
        public VertexPaths(Graph<T> graph, Vertex<T> source, bool multiPaths = false)
        {
            Graph = graph;
            Source = source;
            MultiPaths = multiPaths;
        }

        public List<Path<T>> this[Vertex<T> vertex]
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }
    }

    public interface IGraphValue<T>
    {
        T Value { get; }
    }

    public interface IGraphElement<T>
    {
        Graph<T> Graph { get; }
    }

    public class Vertex<T> : IGraphElement<T>, IGraphValue<T>
    {
        public string Name;
        public Graph<T> Graph { get; }

        private T _Value = default(T);
        public T Value { get { return _Value; } set { _Value = value; } }
        public Edge<T> Self { get; set; }
        private List<Edge<T>> _In = new List<Edge<T>>();
        public List<Edge<T>> In { get { return _In; } }
        private List<Edge<T>> _Out = new List<Edge<T>>();
        public List<Edge<T>> Out { get { return _Out; } }

        public Vertex (Graph<T> graph)
        {
            Graph = graph;
        }
    }

    public class Edge<T>: IGraphElement<T>, IGraphValue<T>
    {
        public string Name;
        public Graph<T> Graph { get; }

        public Vertex<T> Source { get; set; }
        public Vertex<T> Target { get; set; }

        private T _Value = default(T);
        public T Value { get { return _Value; } set { _Value = value; } }
        public Edge(Graph<T> graph)
        {
            Graph = graph;
        }
    }

    public class Path<T>: IGraphElement<T>, IGraphValue<T>
    {
        public Graph<T> Graph { get; }
        public Vertex<T> Source
        {
            get
            {
                if (Route.Count <= 0)
                {
                    return null;
                }
                return Route[0].Source;
            }
        }
        public Vertex<T> Target
        {
            get
            {
                if (Route.Count <= 0)
                {
                    return null;
                }
                return Route[Route.Count - 1].Target;
            }
        }

        public T Value
        {
            get
            {
                if (this.Graph == null || this.Graph.Plus == null || Route.Count <= 0)
                {
                    return default(T);
                }

                T result = default(T);
                result = this.Graph.Plus(result, Route[0].Source.Value);
                for (int i = 0; i < Route.Count; i++)
                {
                    result = this.Graph.Plus(result, Route[i].Value);
                    result = this.Graph.Plus(result, Route[i].Target.Value);
                }
                return result;
            }
        }

        private List<Edge<T>> _Route = new List<Edge<T>>();
        public List<Edge<T>> Route { get { return _Route; } }

        public Path(Graph<T> graph)
        {
            Graph = graph;
        }

        public string VertexRouteString(string concatinator = " -> ")
        {
            List<string> vertexNames = new List<string>();
            vertexNames.Add(Route[0].Source.Name);
            for (int i = 0; i < Route.Count; i++)
            {
                vertexNames.Add(Route[i].Target.Name);
            }
            return string.Join(concatinator, vertexNames.ToArray());
        }
    }

}
