using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphUtility
{
    // peer edges not allowed
    public class Graph<T>
    {
        public string Name;

        public readonly bool Directional;
        public delegate T SumDelegate(T t1, T t2);
        public readonly SumDelegate Sum;
        private Dictionary<string, Vertex<T>> _Vertices = new Dictionary<string, Vertex<T>>();
        public Dictionary<string, Vertex<T>> Vertices { get { return _Vertices; } }
        private Dictionary<string, Edge<T>> _Edges = new Dictionary<string, Edge<T>>();
        public Dictionary<string, Edge<T>> Edges { get { return _Edges; } }

        public Graph(bool directional, SumDelegate sum)
        {
            Directional = directional;
            Sum = sum;
        }

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
                    Vertex(source);
                }
                if (!Vertices.ContainsKey(target))
                {
                    Vertex(target);
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

        public Vertex<T> Vertex(string name = "", T value = default(T))
        {
            if (this.Vertices.ContainsKey(name))
            {
                return null;
            }

            Vertex<T> vertex = new Vertex<T>(this);
            vertex.Name = name;
            vertex.Value = value;
            this.Vertices[vertex.Name] = vertex;

            vertex.Self = new SelfLoopEdge<T>(this);
            vertex.Self.Vertex = vertex;
            vertex.Self.Name = vertex.Name + " -> " + vertex.Name;
            this.Edges[vertex.Self.Name] = vertex.Self;

            return vertex;
        }

        public Edge<T> Edge(Vertex<T> source, Vertex<T> target, string name = "", T value = default(T))
        {
            if (source == null || target == null)
            {
                return null;
            }
            if (source.Graph != this || target.Graph != this)
            {
                return null;
            }
            if (source == target)
            {
                return null;
            }
            if (this.Edges.ContainsKey(name))
            {
                return null;
            }

            Edge<T> edge = new Edge<T>(this);
            edge.Name = name;
            edge.Source = source;
            edge.Target = target;
            edge.Value = value;

            this.Edges[edge.Name] = edge;
            source.Out.Add(edge);
            target.In.Add(edge);

            return edge;
        }
    }

    public class PathSetForGraph<T> : GraphObject<T>
    {
        private Dictionary<Vertex<T>, PathSetFromVertex<T>> _VertexPaths = new Dictionary<Vertex<T>, PathSetFromVertex<T>>();

        public PathSetFromVertex<T> this[Vertex<T> vertex]
        {
            get
            {
                if (!_VertexPaths.ContainsKey(vertex))
                {
                    return null;
                }
                return _VertexPaths[vertex];
            }
            set
            {
                _VertexPaths[vertex] = value;
            }
        }

        public int Count
        {
            get
            {
                return _VertexPaths.Count;
            }
        }

        public PathSetForGraph(Graph<T> graph): base(graph)
        {
        }

    }

    public class PathSetFromVertex<T>: GraphObject<T>
    {
        public Vertex<T> Source { get; }

        private VertexPaths<T> SelfPath;
        private Dictionary<Vertex<T>, VertexPaths<T>> _Paths = new Dictionary<Vertex<T>, VertexPaths<T>>();
        public PathSetFromVertex(Graph<T> graph, Vertex<T> source): base(graph)
        {
            Source = source;

            SelfPath = new VertexPaths<T>(this.Graph, source, source);
            SelfPath.Paths.Add(new Path<T>(this.Graph));
            SelfPath.Paths[0].Route.Add(source.Self);
        }

        public int Count
        {
            get
            {
                return _Paths.Count;
            }
        }

        public VertexPaths<T> this[Vertex<T> vertex]
        {
            get
            {
                if (vertex == Source)
                {
                    return SelfPath;
                }
                if (!_Paths.ContainsKey(vertex))
                {
                    return null;
                }
                return _Paths[vertex];
            }
            set
            {
                _Paths[vertex] = value;
            }
        }
    }

    public class VertexPaths<T>: GraphObject<T>
    {
        private Vertex<T> _Source;
        private Vertex<T> _Target;

        public Vertex<T> Source { get { return _Source; } }
        public Vertex<T> Target { get { return _Target; } }

        public T Value
        {
            get
            {
                if (Paths.Count <= 0)
                {
                    return default(T);
                }
                return Paths[0].Value;
            }
        }

        private List<Path<T>> _Paths = new List<Path<T>>();
        public List<Path<T>> Paths { get { return _Paths; } }

        public VertexPaths(Graph<T> graph, Vertex<T> source, Vertex<T> target):base(graph)
        {
            _Source = source;
            _Target = target;
        }


        public static VertexPaths<T> operator +(VertexPaths<T> paths, Edge<T> edge)
        {
            if (paths.Source == edge.Target)
            {
                return null;
            }
            if (paths.Target != edge.Source)
            {
                return null;
            }
            if (paths.Graph != edge.Graph)
            {
                return null;
            }

            VertexPaths<T> result = new VertexPaths<T>(paths.Graph, paths.Source, edge.Target);
            foreach (Path<T> path in paths.Paths)
            {
                Path<T> tempPath = path + edge;
                result.Paths.Add(tempPath);
            }
            return result;
        }


    }

    public interface IGraphValue<T>
    {
        T Value { get; }
    }

    public abstract class GraphObject<T>
    {
        public Graph<T> Graph { get; }
        public GraphObject(Graph<T> graph)
        {
            Graph = graph;
        }
    }

    public class Vertex<T> : GraphObject<T>, IGraphValue<T>
    {
        public string Name;

        private T _Value = default(T);
        public T Value { get { return _Value; } set { _Value = value; } }
        public SelfLoopEdge<T> Self { get; set; }
        private List<Edge<T>> _In = new List<Edge<T>>();
        public List<Edge<T>> In { get { return _In; } }
        private List<Edge<T>> _Out = new List<Edge<T>>();
        public List<Edge<T>> Out { get { return _Out; } }

        public Vertex (Graph<T> graph): base(graph)
        {
        }
    }

    public class Edge<T>: GraphObject<T>, IGraphValue<T>
    {
        public string Name;

        public virtual Vertex<T> Source { get; set; }
        public virtual Vertex<T> Target { get; set; }

        private T _Value = default(T);
        public virtual T Value { get { return _Value; } set { _Value = value; } }
        public Edge(Graph<T> graph): base(graph)
        {
        }
    }

    public class SelfLoopEdge<T> : Edge<T>
    {
        private Vertex<T> _Vertex;
        public Vertex<T> Vertex { get { return _Vertex; } set { _Vertex = value; } }
        public override Vertex<T> Source { get { return _Vertex; } set { _Vertex = value; } }
        public override Vertex<T> Target { get { return _Vertex; } set { _Vertex = value; } }
        public SelfLoopEdge(Graph<T> graph) : base(graph)
        {
        }
    }

    public class Path<T>: GraphObject<T>, IGraphValue<T>
    {
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
                if (this.Graph == null || this.Graph.Sum == null || Route.Count <= 0)
                {
                    return default(T);
                }

                T result = default(T);
                result = this.Graph.Sum(result, Route[0].Source.Value);
                for (int i = 0; i < Route.Count; i++)
                {
                    result = this.Graph.Sum(result, Route[i].Value);
                    result = this.Graph.Sum(result, Route[i].Target.Value);
                }
                return result;
            }
        }

        private List<Edge<T>> _Route = new List<Edge<T>>();
        public List<Edge<T>> Route { get { return _Route; } }

        public Path(Graph<T> graph): base(graph)
        {
        }

        public static Path<T> operator +(Path<T> path, Edge<T> edge)
        {
            if (path == null || edge == null)
            {
                return null;
            }
            if (path.Graph != edge.Graph)
            {
                return null;
            }
            if (path.Target != edge.Source)
            {
                return null;
            }
            Path<T> result = new Path<T>(path.Graph);
            if (path.Source != path.Target)
            {
                result.Route.AddRange(path.Route);
            }
            result.Route.Add(edge);
            return result;
        }

        public string VertexRouteString
        {
            get
            {
                string concatinator = " -> ";
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

}
