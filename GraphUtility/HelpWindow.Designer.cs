namespace GraphUtility
{
    partial class HelpWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode37 = new System.Windows.Forms.TreeNode("Coordinate");
            System.Windows.Forms.TreeNode treeNode38 = new System.Windows.Forms.TreeNode("Connectivity");
            System.Windows.Forms.TreeNode treeNode39 = new System.Windows.Forms.TreeNode("Select File Format", new System.Windows.Forms.TreeNode[] {
            treeNode37,
            treeNode38});
            System.Windows.Forms.TreeNode treeNode40 = new System.Windows.Forms.TreeNode("<vertex x y>");
            System.Windows.Forms.TreeNode treeNode41 = new System.Windows.Forms.TreeNode("Vertex File", new System.Windows.Forms.TreeNode[] {
            treeNode40});
            System.Windows.Forms.TreeNode treeNode42 = new System.Windows.Forms.TreeNode("<vertex1 vertex2>");
            System.Windows.Forms.TreeNode treeNode43 = new System.Windows.Forms.TreeNode("Edge File", new System.Windows.Forms.TreeNode[] {
            treeNode42});
            System.Windows.Forms.TreeNode treeNode44 = new System.Windows.Forms.TreeNode("File Format", new System.Windows.Forms.TreeNode[] {
            treeNode41,
            treeNode43});
            System.Windows.Forms.TreeNode treeNode45 = new System.Windows.Forms.TreeNode("2D float-point coordinates.");
            System.Windows.Forms.TreeNode treeNode46 = new System.Windows.Forms.TreeNode("Unique vertex names.");
            System.Windows.Forms.TreeNode treeNode47 = new System.Windows.Forms.TreeNode("Requirements", new System.Windows.Forms.TreeNode[] {
            treeNode45,
            treeNode46});
            System.Windows.Forms.TreeNode treeNode48 = new System.Windows.Forms.TreeNode("Coordinate Format", new System.Windows.Forms.TreeNode[] {
            treeNode44,
            treeNode47});
            System.Windows.Forms.TreeNode treeNode49 = new System.Windows.Forms.TreeNode("<Vertex1 Vertex2 Value>");
            System.Windows.Forms.TreeNode treeNode50 = new System.Windows.Forms.TreeNode("Edge File", new System.Windows.Forms.TreeNode[] {
            treeNode49});
            System.Windows.Forms.TreeNode treeNode51 = new System.Windows.Forms.TreeNode("File Format", new System.Windows.Forms.TreeNode[] {
            treeNode50});
            System.Windows.Forms.TreeNode treeNode52 = new System.Windows.Forms.TreeNode("Connectivity Format", new System.Windows.Forms.TreeNode[] {
            treeNode51});
            System.Windows.Forms.TreeNode treeNode53 = new System.Windows.Forms.TreeNode("Select File(s)", new System.Windows.Forms.TreeNode[] {
            treeNode48,
            treeNode52});
            System.Windows.Forms.TreeNode treeNode54 = new System.Windows.Forms.TreeNode("Construct a graph by loaded file(s)");
            System.Windows.Forms.TreeNode treeNode55 = new System.Windows.Forms.TreeNode("Build Graph", new System.Windows.Forms.TreeNode[] {
            treeNode54});
            System.Windows.Forms.TreeNode treeNode56 = new System.Windows.Forms.TreeNode("Finds all paths in the graph.");
            System.Windows.Forms.TreeNode treeNode57 = new System.Windows.Forms.TreeNode("Progress bars for current vertex and all vertices.");
            System.Windows.Forms.TreeNode treeNode58 = new System.Windows.Forms.TreeNode("Run Mapping", new System.Windows.Forms.TreeNode[] {
            treeNode56,
            treeNode57});
            System.Windows.Forms.TreeNode treeNode59 = new System.Windows.Forms.TreeNode("1. Select Source");
            System.Windows.Forms.TreeNode treeNode60 = new System.Windows.Forms.TreeNode("2. Select Target");
            System.Windows.Forms.TreeNode treeNode61 = new System.Windows.Forms.TreeNode("3. View Paths");
            System.Windows.Forms.TreeNode treeNode62 = new System.Windows.Forms.TreeNode("View Result", new System.Windows.Forms.TreeNode[] {
            treeNode59,
            treeNode60,
            treeNode61});
            System.Windows.Forms.TreeNode treeNode63 = new System.Windows.Forms.TreeNode("Not available yet.");
            System.Windows.Forms.TreeNode treeNode64 = new System.Windows.Forms.TreeNode("Save Result as File", new System.Windows.Forms.TreeNode[] {
            treeNode63});
            System.Windows.Forms.TreeNode treeNode65 = new System.Windows.Forms.TreeNode("Clear all loaded files and data.");
            System.Windows.Forms.TreeNode treeNode66 = new System.Windows.Forms.TreeNode("Clear", new System.Windows.Forms.TreeNode[] {
            treeNode65});
            System.Windows.Forms.TreeNode treeNode67 = new System.Windows.Forms.TreeNode("Name: Einherjar");
            System.Windows.Forms.TreeNode treeNode68 = new System.Windows.Forms.TreeNode("Email: zachary625@outlook.com");
            System.Windows.Forms.TreeNode treeNode69 = new System.Windows.Forms.TreeNode("Use as you like.");
            System.Windows.Forms.TreeNode treeNode70 = new System.Windows.Forms.TreeNode("Remember me.");
            System.Windows.Forms.TreeNode treeNode71 = new System.Windows.Forms.TreeNode("Permission", new System.Windows.Forms.TreeNode[] {
            treeNode69,
            treeNode70});
            System.Windows.Forms.TreeNode treeNode72 = new System.Windows.Forms.TreeNode("About This Shit", new System.Windows.Forms.TreeNode[] {
            treeNode67,
            treeNode68,
            treeNode71});
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.Button_OK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(13, 13);
            this.treeView1.Name = "treeView1";
            treeNode37.Name = "节点9";
            treeNode37.Text = "Coordinate";
            treeNode38.Name = "节点10";
            treeNode38.Text = "Connectivity";
            treeNode39.Name = "节点0";
            treeNode39.Text = "Select File Format";
            treeNode40.Name = "节点34";
            treeNode40.Text = "<vertex x y>";
            treeNode41.Name = "节点32";
            treeNode41.Text = "Vertex File";
            treeNode42.Name = "节点35";
            treeNode42.Text = "<vertex1 vertex2>";
            treeNode43.Name = "节点33";
            treeNode43.Text = "Edge File";
            treeNode44.Name = "节点31";
            treeNode44.Text = "File Format";
            treeNode45.Name = "节点37";
            treeNode45.Text = "2D float-point coordinates.";
            treeNode46.Name = "节点38";
            treeNode46.Text = "Unique vertex names.";
            treeNode47.Name = "节点36";
            treeNode47.Text = "Requirements";
            treeNode48.Name = "节点12";
            treeNode48.Text = "Coordinate Format";
            treeNode49.Name = "节点40";
            treeNode49.Text = "<Vertex1 Vertex2 Value>";
            treeNode50.Name = "节点39";
            treeNode50.Text = "Edge File";
            treeNode51.Name = "节点16";
            treeNode51.Text = "File Format";
            treeNode52.Name = "节点13";
            treeNode52.Text = "Connectivity Format";
            treeNode53.Name = "节点1";
            treeNode53.Text = "Select File(s)";
            treeNode54.Name = "节点17";
            treeNode54.Text = "Construct a graph by loaded file(s)";
            treeNode55.Name = "节点2";
            treeNode55.Text = "Build Graph";
            treeNode56.Name = "节点42";
            treeNode56.Text = "Finds all paths in the graph.";
            treeNode57.Name = "节点43";
            treeNode57.Text = "Progress bars for current vertex and all vertices.";
            treeNode58.Name = "节点3";
            treeNode58.Text = "Run Mapping";
            treeNode59.Name = "节点19";
            treeNode59.Text = "1. Select Source";
            treeNode60.Name = "节点20";
            treeNode60.Text = "2. Select Target";
            treeNode61.Name = "节点21";
            treeNode61.Text = "3. View Paths";
            treeNode62.Name = "节点4";
            treeNode62.Text = "View Result";
            treeNode63.Name = "节点22";
            treeNode63.Text = "Not available yet.";
            treeNode64.Name = "节点5";
            treeNode64.Text = "Save Result as File";
            treeNode65.Name = "节点23";
            treeNode65.Text = "Clear all loaded files and data.";
            treeNode66.Name = "节点6";
            treeNode66.Text = "Clear";
            treeNode67.Name = "节点24";
            treeNode67.Text = "Name: Einherjar";
            treeNode68.Name = "节点26";
            treeNode68.Text = "Email: zachary625@outlook.com";
            treeNode69.Name = "节点28";
            treeNode69.Text = "Use as you like.";
            treeNode70.Name = "节点29";
            treeNode70.Text = "Remember me.";
            treeNode71.Name = "节点27";
            treeNode71.Text = "Permission";
            treeNode72.Name = "节点7";
            treeNode72.Text = "About This Shit";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode39,
            treeNode53,
            treeNode55,
            treeNode58,
            treeNode62,
            treeNode64,
            treeNode66,
            treeNode72});
            this.treeView1.Size = new System.Drawing.Size(271, 372);
            this.treeView1.TabIndex = 0;
            // 
            // Button_OK
            // 
            this.Button_OK.Location = new System.Drawing.Point(108, 393);
            this.Button_OK.Name = "Button_OK";
            this.Button_OK.Size = new System.Drawing.Size(75, 23);
            this.Button_OK.TabIndex = 1;
            this.Button_OK.Text = "OK";
            this.Button_OK.UseVisualStyleBackColor = true;
            this.Button_OK.Click += new System.EventHandler(this.Button_OK_Click);
            // 
            // HelpWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 428);
            this.Controls.Add(this.Button_OK);
            this.Controls.Add(this.treeView1);
            this.Name = "HelpWindow";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "HelpWindow";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button Button_OK;
    }
}