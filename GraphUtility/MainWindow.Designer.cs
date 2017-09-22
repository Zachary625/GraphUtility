namespace GraphUtility
{
    partial class MainWindow
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.Button_SelectVerticesFile = new System.Windows.Forms.Button();
            this.TextBox_VerticesFilePath = new System.Windows.Forms.TextBox();
            this.ListBox_Log = new System.Windows.Forms.ListBox();
            this.TextBox_EdgesFilePath = new System.Windows.Forms.TextBox();
            this.Button_SelectEdgesFile = new System.Windows.Forms.Button();
            this.ListBox_Source = new System.Windows.Forms.ListBox();
            this.ListBox_Target = new System.Windows.Forms.ListBox();
            this.TreeView_Paths = new System.Windows.Forms.TreeView();
            this.Label_Vertices = new System.Windows.Forms.Label();
            this.Label_Edges = new System.Windows.Forms.Label();
            this.Button_Build = new System.Windows.Forms.Button();
            this.ProgressBar_PathSetFromVertex = new System.Windows.Forms.ProgressBar();
            this.ProgressBar_PathSetForGraph = new System.Windows.Forms.ProgressBar();
            this.Button_Map = new System.Windows.Forms.Button();
            this.Label_AllPaths = new System.Windows.Forms.Label();
            this.Label_CurrentProgress = new System.Windows.Forms.Label();
            this.Button_Clear = new System.Windows.Forms.Button();
            this.Button_Save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Button_SelectVerticesFile
            // 
            this.Button_SelectVerticesFile.Location = new System.Drawing.Point(677, 10);
            this.Button_SelectVerticesFile.Name = "Button_SelectVerticesFile";
            this.Button_SelectVerticesFile.Size = new System.Drawing.Size(59, 23);
            this.Button_SelectVerticesFile.TabIndex = 0;
            this.Button_SelectVerticesFile.Text = "Load...";
            this.Button_SelectVerticesFile.UseVisualStyleBackColor = true;
            this.Button_SelectVerticesFile.Click += new System.EventHandler(this.Button_SelectVerticesFile_Click);
            // 
            // TextBox_VerticesFilePath
            // 
            this.TextBox_VerticesFilePath.Location = new System.Drawing.Point(167, 12);
            this.TextBox_VerticesFilePath.Name = "TextBox_VerticesFilePath";
            this.TextBox_VerticesFilePath.ReadOnly = true;
            this.TextBox_VerticesFilePath.Size = new System.Drawing.Size(504, 21);
            this.TextBox_VerticesFilePath.TabIndex = 1;
            // 
            // ListBox_Log
            // 
            this.ListBox_Log.FormattingEnabled = true;
            this.ListBox_Log.ItemHeight = 12;
            this.ListBox_Log.Location = new System.Drawing.Point(545, 139);
            this.ListBox_Log.Name = "ListBox_Log";
            this.ListBox_Log.Size = new System.Drawing.Size(257, 400);
            this.ListBox_Log.TabIndex = 2;
            // 
            // TextBox_EdgesFilePath
            // 
            this.TextBox_EdgesFilePath.Location = new System.Drawing.Point(167, 39);
            this.TextBox_EdgesFilePath.Name = "TextBox_EdgesFilePath";
            this.TextBox_EdgesFilePath.ReadOnly = true;
            this.TextBox_EdgesFilePath.Size = new System.Drawing.Size(504, 21);
            this.TextBox_EdgesFilePath.TabIndex = 4;
            // 
            // Button_SelectEdgesFile
            // 
            this.Button_SelectEdgesFile.Location = new System.Drawing.Point(677, 37);
            this.Button_SelectEdgesFile.Name = "Button_SelectEdgesFile";
            this.Button_SelectEdgesFile.Size = new System.Drawing.Size(59, 23);
            this.Button_SelectEdgesFile.TabIndex = 3;
            this.Button_SelectEdgesFile.Text = "Load...";
            this.Button_SelectEdgesFile.UseVisualStyleBackColor = true;
            this.Button_SelectEdgesFile.Click += new System.EventHandler(this.Button_SelectEdgesFile_Click);
            // 
            // ListBox_Source
            // 
            this.ListBox_Source.FormattingEnabled = true;
            this.ListBox_Source.ItemHeight = 12;
            this.ListBox_Source.Location = new System.Drawing.Point(10, 139);
            this.ListBox_Source.Name = "ListBox_Source";
            this.ListBox_Source.Size = new System.Drawing.Size(99, 400);
            this.ListBox_Source.TabIndex = 5;
            this.ListBox_Source.SelectedIndexChanged += new System.EventHandler(this.ListBox_Source_SelectedIndexChanged);
            // 
            // ListBox_Target
            // 
            this.ListBox_Target.FormattingEnabled = true;
            this.ListBox_Target.ItemHeight = 12;
            this.ListBox_Target.Location = new System.Drawing.Point(115, 139);
            this.ListBox_Target.Name = "ListBox_Target";
            this.ListBox_Target.Size = new System.Drawing.Size(99, 400);
            this.ListBox_Target.TabIndex = 6;
            this.ListBox_Target.SelectedIndexChanged += new System.EventHandler(this.ListBox_Target_SelectedIndexChanged);
            // 
            // TreeView_Paths
            // 
            this.TreeView_Paths.Location = new System.Drawing.Point(221, 139);
            this.TreeView_Paths.Name = "TreeView_Paths";
            this.TreeView_Paths.Size = new System.Drawing.Size(318, 400);
            this.TreeView_Paths.TabIndex = 7;
            // 
            // Label_Vertices
            // 
            this.Label_Vertices.AutoSize = true;
            this.Label_Vertices.Location = new System.Drawing.Point(78, 15);
            this.Label_Vertices.Name = "Label_Vertices";
            this.Label_Vertices.Size = new System.Drawing.Size(83, 12);
            this.Label_Vertices.TabIndex = 8;
            this.Label_Vertices.Text = "Vertices File";
            // 
            // Label_Edges
            // 
            this.Label_Edges.AutoSize = true;
            this.Label_Edges.Location = new System.Drawing.Point(87, 42);
            this.Label_Edges.Name = "Label_Edges";
            this.Label_Edges.Size = new System.Drawing.Size(65, 12);
            this.Label_Edges.TabIndex = 9;
            this.Label_Edges.Text = "Edges File";
            // 
            // Button_Build
            // 
            this.Button_Build.Location = new System.Drawing.Point(742, 10);
            this.Button_Build.Name = "Button_Build";
            this.Button_Build.Size = new System.Drawing.Size(60, 50);
            this.Button_Build.TabIndex = 10;
            this.Button_Build.Text = "Build";
            this.Button_Build.UseVisualStyleBackColor = true;
            this.Button_Build.Click += new System.EventHandler(this.Button_Build_Click);
            // 
            // ProgressBar_CurrentPath
            // 
            this.ProgressBar_PathSetFromVertex.Location = new System.Drawing.Point(103, 68);
            this.ProgressBar_PathSetFromVertex.Name = "ProgressBar_CurrentPath";
            this.ProgressBar_PathSetFromVertex.Size = new System.Drawing.Size(568, 23);
            this.ProgressBar_PathSetFromVertex.TabIndex = 11;
            // 
            // ProgressBar_AllPaths
            // 
            this.ProgressBar_PathSetForGraph.Location = new System.Drawing.Point(103, 97);
            this.ProgressBar_PathSetForGraph.Name = "ProgressBar_AllPaths";
            this.ProgressBar_PathSetForGraph.Size = new System.Drawing.Size(568, 23);
            this.ProgressBar_PathSetForGraph.TabIndex = 12;
            // 
            // Button_Map
            // 
            this.Button_Map.Location = new System.Drawing.Point(677, 68);
            this.Button_Map.Name = "Button_Map";
            this.Button_Map.Size = new System.Drawing.Size(60, 52);
            this.Button_Map.TabIndex = 13;
            this.Button_Map.Text = "Map";
            this.Button_Map.UseVisualStyleBackColor = true;
            this.Button_Map.Click += new System.EventHandler(this.Button_Map_Click);
            // 
            // Label_AllPaths
            // 
            this.Label_AllPaths.AutoSize = true;
            this.Label_AllPaths.Location = new System.Drawing.Point(23, 101);
            this.Label_AllPaths.Name = "Label_AllPaths";
            this.Label_AllPaths.Size = new System.Drawing.Size(59, 12);
            this.Label_AllPaths.TabIndex = 15;
            this.Label_AllPaths.Text = "All Paths";
            // 
            // Label_CurrentProgress
            // 
            this.Label_CurrentProgress.AutoSize = true;
            this.Label_CurrentProgress.Location = new System.Drawing.Point(14, 75);
            this.Label_CurrentProgress.Name = "Label_CurrentProgress";
            this.Label_CurrentProgress.Size = new System.Drawing.Size(77, 12);
            this.Label_CurrentProgress.TabIndex = 14;
            this.Label_CurrentProgress.Text = "Current Path";
            // 
            // Button_Clear
            // 
            this.Button_Clear.Location = new System.Drawing.Point(12, 10);
            this.Button_Clear.Name = "Button_Clear";
            this.Button_Clear.Size = new System.Drawing.Size(60, 50);
            this.Button_Clear.TabIndex = 16;
            this.Button_Clear.Text = "Clear";
            this.Button_Clear.UseVisualStyleBackColor = true;
            this.Button_Clear.Click += new System.EventHandler(this.Button_Clear_Click);
            // 
            // Button_Save
            // 
            this.Button_Save.Location = new System.Drawing.Point(742, 68);
            this.Button_Save.Name = "Button_Save";
            this.Button_Save.Size = new System.Drawing.Size(60, 52);
            this.Button_Save.TabIndex = 17;
            this.Button_Save.Text = "Save";
            this.Button_Save.UseVisualStyleBackColor = true;
            this.Button_Save.Click += new System.EventHandler(this.Button_Save_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 551);
            this.Controls.Add(this.Button_Save);
            this.Controls.Add(this.Button_Clear);
            this.Controls.Add(this.Label_AllPaths);
            this.Controls.Add(this.Label_CurrentProgress);
            this.Controls.Add(this.Button_Map);
            this.Controls.Add(this.ProgressBar_PathSetForGraph);
            this.Controls.Add(this.ProgressBar_PathSetFromVertex);
            this.Controls.Add(this.Button_Build);
            this.Controls.Add(this.Label_Edges);
            this.Controls.Add(this.Label_Vertices);
            this.Controls.Add(this.TreeView_Paths);
            this.Controls.Add(this.ListBox_Target);
            this.Controls.Add(this.ListBox_Source);
            this.Controls.Add(this.TextBox_EdgesFilePath);
            this.Controls.Add(this.Button_SelectEdgesFile);
            this.Controls.Add(this.ListBox_Log);
            this.Controls.Add(this.TextBox_VerticesFilePath);
            this.Controls.Add(this.Button_SelectVerticesFile);
            this.Name = "MainWindow";
            this.Text = "MainWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Button_SelectVerticesFile;
        private System.Windows.Forms.TextBox TextBox_VerticesFilePath;
        private System.Windows.Forms.ListBox ListBox_Log;
        private System.Windows.Forms.TextBox TextBox_EdgesFilePath;
        private System.Windows.Forms.Button Button_SelectEdgesFile;
        private System.Windows.Forms.ListBox ListBox_Source;
        private System.Windows.Forms.ListBox ListBox_Target;
        private System.Windows.Forms.TreeView TreeView_Paths;
        private System.Windows.Forms.Label Label_Vertices;
        private System.Windows.Forms.Label Label_Edges;
        private System.Windows.Forms.Button Button_Build;
        private System.Windows.Forms.ProgressBar ProgressBar_PathSetFromVertex;
        private System.Windows.Forms.ProgressBar ProgressBar_PathSetForGraph;
        private System.Windows.Forms.Button Button_Map;
        private System.Windows.Forms.Label Label_AllPaths;
        private System.Windows.Forms.Label Label_CurrentProgress;
        private System.Windows.Forms.Button Button_Clear;
        private System.Windows.Forms.Button Button_Save;
    }
}

