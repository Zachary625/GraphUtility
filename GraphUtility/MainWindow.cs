using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace GraphUtility
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private struct Coordinate2D
        {
            public double x;
            public double y;
            public static Coordinate2D operator -(Coordinate2D a, Coordinate2D b)
            {
                return new Coordinate2D() { x = a.x - b.x, y = a.y - b.y };
            }
            public static Coordinate2D operator +(Coordinate2D a, Coordinate2D b)
            {
                return new Coordinate2D() { x = a.x + b.x, y = a.y + b.y };
            }

            public double Magnitute
            {
                get
                {
                    return Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
                }
            }
        }

        private class DoubleComparer : IComparer<double>
        {
            public int Compare(double a, double b)
            {
                return Math.Sign(a - b);
            }
        }
        Dictionary<string, Coordinate2D> NodeCoordinates = new Dictionary<string, Coordinate2D>();
        private string[][] NodeConnectivity;
        private Graph<double> Graph;

        private PathSetForGraph<double> GraphPaths;

        private Thread mappingThread;

        private void LogClear()
        {
            this.Invoke((MethodInvoker)delegate ()
            {
                ListBox_Log.Items.Clear();
            });
        }

        public void Log(string logContent, bool add = true)
        {
            this.Invoke((MethodInvoker)delegate ()
            {
                if (add)
                {
                    ListBox_Log.Items.Add(logContent);
                }
                else if (ListBox_Log.Items.Count > 0)
                {
                    ListBox_Log.Items[ListBox_Log.Items.Count - 1] = logContent;
                }
            });
        }

        private void LoadVerticesInfo(string fileName)
        {
            if (!File.Exists(fileName))
            {
                return;
            }
            string[] lines = File.ReadAllLines(fileName);

            NodeCoordinates = new Dictionary<string, Coordinate2D>();
            for (int i = 0; i < lines.Length; i++)
            {
                string[] split = lines[i].Split(' ');
                if (split.Length == 3)
                {
                    string name = split[0];
                    double x = 0, y = 0;
                    bool xParsed = double.TryParse(split[1], out x);
                    bool yParsed = double.TryParse(split[2], out y);
                    if (!xParsed)
                    {
                        Log(string.Format("Vertex x error at line {0}: {1}", (i + 1), split[1]));
                    }
                    if (!yParsed)
                    {
                        Log(string.Format("Vertex y error at line {0}: {1}", (i + 1), split[2]));
                    }
                    if (xParsed && yParsed)
                    {
                        NodeCoordinates[split[0]] = new Coordinate2D() { x = x, y = y };
                    }
                }
                else
                {
                    Log(string.Format("Vertex definition error at line {0}: {1}", (i + 1), lines[i]));
                }
            }
        }

        private void LoadEdgesInfo(string fileName)
        {
            if (!File.Exists(fileName))
            {
                return;
            }
            string[] lines = File.ReadAllLines(fileName);
            NodeConnectivity = new string[lines.Length][];
            for (int i = 0; i < lines.Length; i++)
            {
                string[] split = lines[i].Split(' ');
                if (split.Length != 2)
                {
                    Log(string.Format("Edge definition error at line {0}", (i + 1), lines[i]));
                }
                else
                {
                    if (!NodeCoordinates.ContainsKey(split[0]))
                    {
                        Log(string.Format("Edge definition line {0} referred to undefined vertex: {1}", (i + 1), split[0]));
                    }
                    if (!NodeCoordinates.ContainsKey(split[1]))
                    {
                        Log(string.Format("Edge definition line {0} referred to undefined vertex: {1}", (i + 1), split[1]));
                    }

                    if (NodeCoordinates.ContainsKey(split[0]) && NodeCoordinates.ContainsKey(split[1]))
                    {
                        NodeConnectivity[i] = new string[2];
                        NodeConnectivity[i][0] = split[0];
                        NodeConnectivity[i][1] = split[1];
                    }
                }
            }
        }

        private void Button_SelectVerticesFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = false;
            ofd.CheckFileExists = true;
            DialogResult dr = ofd.ShowDialog(this);
            if (dr != DialogResult.Yes && dr != DialogResult.OK)
            {
                return;
            }
            TextBox_VerticesFilePath.Text = ofd.FileName;
            LoadVerticesInfo(ofd.FileName);
        }

        private void Button_SelectEdgesFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = false;
            ofd.CheckFileExists = true;
            DialogResult dr = ofd.ShowDialog(this);
            if (dr != DialogResult.Yes && dr != DialogResult.OK)
            {
                return;
            }
            TextBox_EdgesFilePath.Text = ofd.FileName;
            LoadEdgesInfo(ofd.FileName);
        }

        private void Button_Build_Click(object sender, EventArgs e)
        {
            if (NodeCoordinates == null || NodeConnectivity == null)
            {
                Log("Incomplete Graph, please make sure correct vertices file and edges file are loaded.");
                return;
            }

            Graph = new Graph<double>(false, (double d1, double d2) => { return d1 + d2; });
            foreach (KeyValuePair<string, Coordinate2D> pair in NodeCoordinates)
            {
                Graph.Vertex(pair.Key);
            }

            for (int i = 0; i < NodeConnectivity.Length; i++)
            {
                Graph[NodeConnectivity[i][0], NodeConnectivity[i][1]] = (NodeCoordinates[NodeConnectivity[i][0]] - NodeCoordinates[NodeConnectivity[i][1]]).Magnitute;
            }
            Log(string.Format("Graph built. {0} vertices, {1} edges.", Graph.Vertices.Count, Graph.Edges.Count));
        }

        private void ClearMappingProgress()
        {
            this.Invoke((MethodInvoker)delegate ()
            {
                Progress_Graph = 0;
                Progress_Vertex = 0;
                UpdateFindProgress();
            });
        }

        private void ClearGraphMap()
        {
            this.Invoke((MethodInvoker)delegate ()
            {
                ListBox_Source.Items.Clear();
                ListBox_Target.Items.Clear();
                TreeView_Paths.Nodes.Clear();
            });
        }

        private void Mapped()
        {
            this.Invoke((MethodInvoker)delegate () {
                Button_Map.Text = "Map";

                ClearGraphMap();
                string[] vertexNames = Graph.Vertices.Keys.ToArray();
                ListBox_Source.Items.AddRange(vertexNames);
                ListBox_Target.Items.AddRange(vertexNames);
            });
        }

        private void Button_Map_Click(object sender, EventArgs e)
        {
            ClearMappingProgress();

            if (mappingThread != null)
            {
                mappingThread.Abort();
                mappingThread = null;
                Mapped();
            }
            else
            {
                ProgressBar_PathSetFromVertex.Maximum = Graph.Vertices.Count - 1;
                ProgressBar_PathSetForGraph.Maximum = Graph.Vertices.Count;

                mappingThread = new Thread(new ThreadStart(() => 
                {
                    this.GraphPaths = PathFinder.Get(PathFinder.PathFindingAlrogithm.Dijkstra).FindPathsForGraph<double>(Graph, new PathFinder.PathFinderOptions<double>()
                    {
                        Parallel = true,
                        OnGraphProgress = OnGraphProgress,
                        OnVertexProgress = OnVertexProgress,
                        OnCompare = (double d1, double d2) => { return Math.Sign(d1 - d2); },
                    });

                    mappingThread = null;

                    Mapped();
                    UpdatePathsTreeView();
                }));
                mappingThread.Start();
                Button_Map.Text = "Abort";
            }
        }

        private int Progress_Graph = 0;
        private int Progress_Vertex = 0;

        private void OnVertexProgress(PathSetFromVertex<double> vertexPathsSet)
        {
            Progress_Vertex = vertexPathsSet.Count;
            UpdateFindProgress();
        }

        private void OnGraphProgress(PathSetForGraph<double> graphPathsSet)
        {
            Progress_Graph = graphPathsSet.Count;
            UpdateFindProgress();
        }

        private void UpdateFindProgress()
        {
            this.Invoke((MethodInvoker) delegate ()
            {
                ProgressBar_PathSetFromVertex.Value = Progress_Vertex;
                ProgressBar_PathSetForGraph.Value = Progress_Graph;
            });
        }

        private string selectedSource;
        private string selectedTarget;
        private void ListBox_Source_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedSource = ListBox_Source.SelectedItem.ToString();
            if (mappingThread != null)
            {
                Log("Please wait till mapping is done.");
                return;
            }
            if (GraphPaths == null)
            {
                Log("Please make a graph map first.");
                return;
            }
            UpdatePathsTreeView();
        }

        private void ListBox_Target_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedTarget = ListBox_Target.SelectedItem.ToString();
            if (mappingThread != null)
            {
                Log("Please wait till mapping is done.");
                return;
            }
            if (GraphPaths == null)
            {
                Log("Please make a graph map first.");
                return;
            }
            UpdatePathsTreeView();
        }

        private void UpdatePathsTreeView()
        {
            this.Invoke((MethodInvoker)delegate ()
            {
                TreeView_Paths.Nodes.Clear();
                if (GraphPaths == null)
                {
                    return;
                }
                if (string.IsNullOrEmpty(selectedSource) || string.IsNullOrEmpty(selectedTarget))
                {
                    return;
                }
                if (selectedSource == selectedTarget)
                {
                    Log("Source == Target!!!");
                    return;
                }

                VertexPaths<double> paths = GraphPaths[Graph.Vertices[selectedSource]][Graph.Vertices[selectedTarget]];
                Log(string.Format("Showing {0} -> {1}: {2} paths available.", selectedSource, selectedTarget, paths.Paths.Count));
                if (paths.Paths.Count > 0)
                {
                    Log(string.Format("Paths has value of {0}", paths.Paths[0].Value));
                }

                foreach (Path<double> path in paths.Paths)
                {
                    TreeView_Paths.Nodes.Add(path.VertexRouteString);
                    foreach (Edge<double> edge in path.Route)
                    {
                        TreeView_Paths.Nodes[TreeView_Paths.Nodes.Count - 1].Nodes.Add(edge.Name);
                    }
                }

            });
        }

        private void Button_Clear_Click(object sender, EventArgs e)
        {
            ClearMappingProgress();
            ClearGraphMap();
            LogClear();

            NodeCoordinates = null;
            NodeConnectivity = null;
            Graph = null;
            GraphPaths = null;

        }

        private void Button_Save_Click(object sender, EventArgs e)
        {

        }
    }

}
