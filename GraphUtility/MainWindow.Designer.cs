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
            this.TextBox_VertexFilePath = new System.Windows.Forms.TextBox();
            this.ListBox_Log = new System.Windows.Forms.ListBox();
            this.TextBox_EdgeFilePath = new System.Windows.Forms.TextBox();
            this.Button_SelectEdgesFile = new System.Windows.Forms.Button();
            this.ListBox_Source = new System.Windows.Forms.ListBox();
            this.ListBox_Target = new System.Windows.Forms.ListBox();
            this.TreeView_Paths = new System.Windows.Forms.TreeView();
            this.Label_VertexFile = new System.Windows.Forms.Label();
            this.Label_EdgeFile = new System.Windows.Forms.Label();
            this.Button_Build = new System.Windows.Forms.Button();
            this.ProgressBar_PathSetFromVertex = new System.Windows.Forms.ProgressBar();
            this.ProgressBar_PathSetForGraph = new System.Windows.Forms.ProgressBar();
            this.Button_Go = new System.Windows.Forms.Button();
            this.Label_AllVerticesPaths = new System.Windows.Forms.Label();
            this.Label_CurrentVertexProgress = new System.Windows.Forms.Label();
            this.Button_Clear = new System.Windows.Forms.Button();
            this.Button_Save = new System.Windows.Forms.Button();
            this.Button_Help = new System.Windows.Forms.Button();
            this.Panel_FileFormat = new System.Windows.Forms.Panel();
            this.RadioButton_Connectivity = new System.Windows.Forms.RadioButton();
            this.RadioButton_Coordinate = new System.Windows.Forms.RadioButton();
            this.Panel_FileFormat.SuspendLayout();
            this.SuspendLayout();
            // 
            // Button_SelectVerticesFile
            // 
            this.Button_SelectVerticesFile.Location = new System.Drawing.Point(708, 10);
            this.Button_SelectVerticesFile.Name = "Button_SelectVerticesFile";
            this.Button_SelectVerticesFile.Size = new System.Drawing.Size(44, 23);
            this.Button_SelectVerticesFile.TabIndex = 0;
            this.Button_SelectVerticesFile.Text = "Load";
            this.Button_SelectVerticesFile.UseVisualStyleBackColor = true;
            this.Button_SelectVerticesFile.Click += new System.EventHandler(this.Button_SelectVertexFile_Click);
            // 
            // TextBox_VertexFilePath
            // 
            this.TextBox_VertexFilePath.Location = new System.Drawing.Point(307, 12);
            this.TextBox_VertexFilePath.Name = "TextBox_VertexFilePath";
            this.TextBox_VertexFilePath.ReadOnly = true;
            this.TextBox_VertexFilePath.Size = new System.Drawing.Size(394, 21);
            this.TextBox_VertexFilePath.TabIndex = 1;
            // 
            // ListBox_Log
            // 
            this.ListBox_Log.FormattingEnabled = true;
            this.ListBox_Log.HorizontalScrollbar = true;
            this.ListBox_Log.ItemHeight = 12;
            this.ListBox_Log.Location = new System.Drawing.Point(545, 139);
            this.ListBox_Log.Name = "ListBox_Log";
            this.ListBox_Log.Size = new System.Drawing.Size(257, 400);
            this.ListBox_Log.TabIndex = 2;
            // 
            // TextBox_EdgeFilePath
            // 
            this.TextBox_EdgeFilePath.Location = new System.Drawing.Point(307, 39);
            this.TextBox_EdgeFilePath.Name = "TextBox_EdgeFilePath";
            this.TextBox_EdgeFilePath.ReadOnly = true;
            this.TextBox_EdgeFilePath.Size = new System.Drawing.Size(394, 21);
            this.TextBox_EdgeFilePath.TabIndex = 4;
            // 
            // Button_SelectEdgesFile
            // 
            this.Button_SelectEdgesFile.Location = new System.Drawing.Point(708, 37);
            this.Button_SelectEdgesFile.Name = "Button_SelectEdgesFile";
            this.Button_SelectEdgesFile.Size = new System.Drawing.Size(44, 23);
            this.Button_SelectEdgesFile.TabIndex = 3;
            this.Button_SelectEdgesFile.Text = "Load";
            this.Button_SelectEdgesFile.UseVisualStyleBackColor = true;
            this.Button_SelectEdgesFile.Click += new System.EventHandler(this.Button_SelectEdgeFile_Click);
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
            // Label_VertexFile
            // 
            this.Label_VertexFile.AutoSize = true;
            this.Label_VertexFile.Location = new System.Drawing.Point(230, 15);
            this.Label_VertexFile.Name = "Label_VertexFile";
            this.Label_VertexFile.Size = new System.Drawing.Size(71, 12);
            this.Label_VertexFile.TabIndex = 8;
            this.Label_VertexFile.Text = "Vertex File";
            // 
            // Label_EdgeFile
            // 
            this.Label_EdgeFile.AutoSize = true;
            this.Label_EdgeFile.Location = new System.Drawing.Point(239, 42);
            this.Label_EdgeFile.Name = "Label_EdgeFile";
            this.Label_EdgeFile.Size = new System.Drawing.Size(59, 12);
            this.Label_EdgeFile.TabIndex = 9;
            this.Label_EdgeFile.Text = "Edge File";
            // 
            // Button_Build
            // 
            this.Button_Build.Location = new System.Drawing.Point(758, 10);
            this.Button_Build.Name = "Button_Build";
            this.Button_Build.Size = new System.Drawing.Size(44, 50);
            this.Button_Build.TabIndex = 10;
            this.Button_Build.Text = "Build";
            this.Button_Build.UseVisualStyleBackColor = true;
            this.Button_Build.Click += new System.EventHandler(this.Button_Build_Click);
            // 
            // ProgressBar_PathSetFromVertex
            // 
            this.ProgressBar_PathSetFromVertex.Location = new System.Drawing.Point(97, 68);
            this.ProgressBar_PathSetFromVertex.Name = "ProgressBar_PathSetFromVertex";
            this.ProgressBar_PathSetFromVertex.Size = new System.Drawing.Size(604, 23);
            this.ProgressBar_PathSetFromVertex.TabIndex = 11;
            // 
            // ProgressBar_PathSetForGraph
            // 
            this.ProgressBar_PathSetForGraph.Location = new System.Drawing.Point(97, 97);
            this.ProgressBar_PathSetForGraph.Name = "ProgressBar_PathSetForGraph";
            this.ProgressBar_PathSetForGraph.Size = new System.Drawing.Size(604, 23);
            this.ProgressBar_PathSetForGraph.TabIndex = 12;
            // 
            // Button_Go
            // 
            this.Button_Go.Location = new System.Drawing.Point(708, 68);
            this.Button_Go.Name = "Button_Go";
            this.Button_Go.Size = new System.Drawing.Size(45, 52);
            this.Button_Go.TabIndex = 13;
            this.Button_Go.Text = "Go";
            this.Button_Go.UseVisualStyleBackColor = true;
            this.Button_Go.Click += new System.EventHandler(this.Button_Go_Click);
            // 
            // Label_AllVerticesPaths
            // 
            this.Label_AllVerticesPaths.AutoSize = true;
            this.Label_AllVerticesPaths.Location = new System.Drawing.Point(13, 102);
            this.Label_AllVerticesPaths.Name = "Label_AllVerticesPaths";
            this.Label_AllVerticesPaths.Size = new System.Drawing.Size(77, 12);
            this.Label_AllVerticesPaths.TabIndex = 15;
            this.Label_AllVerticesPaths.Text = "All Vertices";
            // 
            // Label_CurrentVertexProgress
            // 
            this.Label_CurrentVertexProgress.AutoSize = true;
            this.Label_CurrentVertexProgress.Location = new System.Drawing.Point(4, 74);
            this.Label_CurrentVertexProgress.Name = "Label_CurrentVertexProgress";
            this.Label_CurrentVertexProgress.Size = new System.Drawing.Size(89, 12);
            this.Label_CurrentVertexProgress.TabIndex = 14;
            this.Label_CurrentVertexProgress.Text = "Current Vertex";
            // 
            // Button_Clear
            // 
            this.Button_Clear.Location = new System.Drawing.Point(63, 10);
            this.Button_Clear.Name = "Button_Clear";
            this.Button_Clear.Size = new System.Drawing.Size(50, 50);
            this.Button_Clear.TabIndex = 16;
            this.Button_Clear.Text = "Clear";
            this.Button_Clear.UseVisualStyleBackColor = true;
            this.Button_Clear.Click += new System.EventHandler(this.Button_Clear_Click);
            // 
            // Button_Save
            // 
            this.Button_Save.Location = new System.Drawing.Point(758, 68);
            this.Button_Save.Name = "Button_Save";
            this.Button_Save.Size = new System.Drawing.Size(44, 52);
            this.Button_Save.TabIndex = 17;
            this.Button_Save.Text = "Save";
            this.Button_Save.UseVisualStyleBackColor = true;
            this.Button_Save.Click += new System.EventHandler(this.Button_Save_Click);
            // 
            // Button_Help
            // 
            this.Button_Help.BackColor = System.Drawing.Color.LightSkyBlue;
            this.Button_Help.Font = new System.Drawing.Font("Verdana", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Help.ForeColor = System.Drawing.Color.RoyalBlue;
            this.Button_Help.Location = new System.Drawing.Point(7, 10);
            this.Button_Help.Name = "Button_Help";
            this.Button_Help.Size = new System.Drawing.Size(50, 50);
            this.Button_Help.TabIndex = 18;
            this.Button_Help.Text = "?";
            this.Button_Help.UseVisualStyleBackColor = false;
            this.Button_Help.Click += new System.EventHandler(this.Button_Help_Click);
            // 
            // Panel_FileFormat
            // 
            this.Panel_FileFormat.Controls.Add(this.RadioButton_Connectivity);
            this.Panel_FileFormat.Controls.Add(this.RadioButton_Coordinate);
            this.Panel_FileFormat.Location = new System.Drawing.Point(115, 10);
            this.Panel_FileFormat.Name = "Panel_FileFormat";
            this.Panel_FileFormat.Size = new System.Drawing.Size(109, 52);
            this.Panel_FileFormat.TabIndex = 19;
            // 
            // RadioButton_Connectivity
            // 
            this.RadioButton_Connectivity.AutoSize = true;
            this.RadioButton_Connectivity.Location = new System.Drawing.Point(11, 29);
            this.RadioButton_Connectivity.Name = "RadioButton_Connectivity";
            this.RadioButton_Connectivity.Size = new System.Drawing.Size(95, 16);
            this.RadioButton_Connectivity.TabIndex = 1;
            this.RadioButton_Connectivity.Text = "Connectivity";
            this.RadioButton_Connectivity.UseVisualStyleBackColor = true;
            this.RadioButton_Connectivity.CheckedChanged += new System.EventHandler(this.RadioButton_Connectivity_CheckedChanged);
            // 
            // RadioButton_Coordinate
            // 
            this.RadioButton_Coordinate.AutoSize = true;
            this.RadioButton_Coordinate.Checked = true;
            this.RadioButton_Coordinate.Location = new System.Drawing.Point(11, 7);
            this.RadioButton_Coordinate.Name = "RadioButton_Coordinate";
            this.RadioButton_Coordinate.Size = new System.Drawing.Size(83, 16);
            this.RadioButton_Coordinate.TabIndex = 0;
            this.RadioButton_Coordinate.TabStop = true;
            this.RadioButton_Coordinate.Text = "Coordinate";
            this.RadioButton_Coordinate.UseVisualStyleBackColor = true;
            this.RadioButton_Coordinate.CheckedChanged += new System.EventHandler(this.RadioButton_Coordinate_CheckedChanged);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 551);
            this.Controls.Add(this.Panel_FileFormat);
            this.Controls.Add(this.Button_Help);
            this.Controls.Add(this.Button_Save);
            this.Controls.Add(this.Button_Clear);
            this.Controls.Add(this.Label_AllVerticesPaths);
            this.Controls.Add(this.Label_CurrentVertexProgress);
            this.Controls.Add(this.Button_Go);
            this.Controls.Add(this.ProgressBar_PathSetForGraph);
            this.Controls.Add(this.ProgressBar_PathSetFromVertex);
            this.Controls.Add(this.Button_Build);
            this.Controls.Add(this.Label_EdgeFile);
            this.Controls.Add(this.Label_VertexFile);
            this.Controls.Add(this.TreeView_Paths);
            this.Controls.Add(this.ListBox_Target);
            this.Controls.Add(this.ListBox_Source);
            this.Controls.Add(this.TextBox_EdgeFilePath);
            this.Controls.Add(this.Button_SelectEdgesFile);
            this.Controls.Add(this.ListBox_Log);
            this.Controls.Add(this.TextBox_VertexFilePath);
            this.Controls.Add(this.Button_SelectVerticesFile);
            this.Name = "MainWindow";
            this.Text = "MainWindow";
            this.Panel_FileFormat.ResumeLayout(false);
            this.Panel_FileFormat.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Button_SelectVerticesFile;
        private System.Windows.Forms.TextBox TextBox_VertexFilePath;
        private System.Windows.Forms.ListBox ListBox_Log;
        private System.Windows.Forms.TextBox TextBox_EdgeFilePath;
        private System.Windows.Forms.Button Button_SelectEdgesFile;
        private System.Windows.Forms.ListBox ListBox_Source;
        private System.Windows.Forms.ListBox ListBox_Target;
        private System.Windows.Forms.TreeView TreeView_Paths;
        private System.Windows.Forms.Label Label_VertexFile;
        private System.Windows.Forms.Label Label_EdgeFile;
        private System.Windows.Forms.Button Button_Build;
        private System.Windows.Forms.ProgressBar ProgressBar_PathSetFromVertex;
        private System.Windows.Forms.ProgressBar ProgressBar_PathSetForGraph;
        private System.Windows.Forms.Button Button_Go;
        private System.Windows.Forms.Label Label_AllVerticesPaths;
        private System.Windows.Forms.Label Label_CurrentVertexProgress;
        private System.Windows.Forms.Button Button_Clear;
        private System.Windows.Forms.Button Button_Save;
        private System.Windows.Forms.Button Button_Help;
        private System.Windows.Forms.Panel Panel_FileFormat;
        private System.Windows.Forms.RadioButton RadioButton_Connectivity;
        private System.Windows.Forms.RadioButton RadioButton_Coordinate;
    }
}

