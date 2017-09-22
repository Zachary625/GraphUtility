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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Define the edge values implicitly by vertex coordinates.");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Coordinate", new System.Windows.Forms.TreeNode[] {
            treeNode1});
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Define the edge values explicitly.");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Connectivity", new System.Windows.Forms.TreeNode[] {
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Select File Format", new System.Windows.Forms.TreeNode[] {
            treeNode2,
            treeNode4});
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("<vertex x y>");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Vertex File", new System.Windows.Forms.TreeNode[] {
            treeNode6});
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("<vertex1 vertex2>");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Edge File", new System.Windows.Forms.TreeNode[] {
            treeNode8});
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("File Format", new System.Windows.Forms.TreeNode[] {
            treeNode7,
            treeNode9});
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("2D float-point coordinates.");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Unique vertex names.");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Requirements", new System.Windows.Forms.TreeNode[] {
            treeNode11,
            treeNode12});
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Coordinate Format", new System.Windows.Forms.TreeNode[] {
            treeNode10,
            treeNode13});
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("<Vertex1 Vertex2 Value>");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Edge File", new System.Windows.Forms.TreeNode[] {
            treeNode15});
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("File Format", new System.Windows.Forms.TreeNode[] {
            treeNode16});
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("Connectivity Format", new System.Windows.Forms.TreeNode[] {
            treeNode17});
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("Select File(s)", new System.Windows.Forms.TreeNode[] {
            treeNode14,
            treeNode18});
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("Construct a graph by loaded file(s)");
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("Build Graph", new System.Windows.Forms.TreeNode[] {
            treeNode20});
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("Finds all paths in the graph.");
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("Progress bars for current vertex and all vertices.");
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("Run Mapping", new System.Windows.Forms.TreeNode[] {
            treeNode22,
            treeNode23});
            System.Windows.Forms.TreeNode treeNode25 = new System.Windows.Forms.TreeNode("1. Select Source");
            System.Windows.Forms.TreeNode treeNode26 = new System.Windows.Forms.TreeNode("2. Select Target");
            System.Windows.Forms.TreeNode treeNode27 = new System.Windows.Forms.TreeNode("3. View Paths");
            System.Windows.Forms.TreeNode treeNode28 = new System.Windows.Forms.TreeNode("View Result", new System.Windows.Forms.TreeNode[] {
            treeNode25,
            treeNode26,
            treeNode27});
            System.Windows.Forms.TreeNode treeNode29 = new System.Windows.Forms.TreeNode("Not available yet.");
            System.Windows.Forms.TreeNode treeNode30 = new System.Windows.Forms.TreeNode("Save Result as File", new System.Windows.Forms.TreeNode[] {
            treeNode29});
            System.Windows.Forms.TreeNode treeNode31 = new System.Windows.Forms.TreeNode("Clear all loaded files and data.");
            System.Windows.Forms.TreeNode treeNode32 = new System.Windows.Forms.TreeNode("Clear", new System.Windows.Forms.TreeNode[] {
            treeNode31});
            System.Windows.Forms.TreeNode treeNode33 = new System.Windows.Forms.TreeNode("Name: Einherjar");
            System.Windows.Forms.TreeNode treeNode34 = new System.Windows.Forms.TreeNode("Email: zachary625@outlook.com");
            System.Windows.Forms.TreeNode treeNode35 = new System.Windows.Forms.TreeNode("Use as you like.");
            System.Windows.Forms.TreeNode treeNode36 = new System.Windows.Forms.TreeNode("Remember me.");
            System.Windows.Forms.TreeNode treeNode37 = new System.Windows.Forms.TreeNode("Permission", new System.Windows.Forms.TreeNode[] {
            treeNode35,
            treeNode36});
            System.Windows.Forms.TreeNode treeNode38 = new System.Windows.Forms.TreeNode("About This Shit", new System.Windows.Forms.TreeNode[] {
            treeNode33,
            treeNode34,
            treeNode37});
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.Button_OK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(13, 13);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "节点44";
            treeNode1.Text = "Define the edge values implicitly by vertex coordinates.";
            treeNode2.Name = "节点9";
            treeNode2.Text = "Coordinate";
            treeNode3.Name = "节点45";
            treeNode3.Text = "Define the edge values explicitly.";
            treeNode4.Name = "节点10";
            treeNode4.Text = "Connectivity";
            treeNode5.Name = "节点0";
            treeNode5.Text = "Select File Format";
            treeNode6.Name = "节点34";
            treeNode6.Text = "<vertex x y>";
            treeNode7.Name = "节点32";
            treeNode7.Text = "Vertex File";
            treeNode8.Name = "节点35";
            treeNode8.Text = "<vertex1 vertex2>";
            treeNode9.Name = "节点33";
            treeNode9.Text = "Edge File";
            treeNode10.Name = "节点31";
            treeNode10.Text = "File Format";
            treeNode11.Name = "节点37";
            treeNode11.Text = "2D float-point coordinates.";
            treeNode12.Name = "节点38";
            treeNode12.Text = "Unique vertex names.";
            treeNode13.Name = "节点36";
            treeNode13.Text = "Requirements";
            treeNode14.Name = "节点12";
            treeNode14.Text = "Coordinate Format";
            treeNode15.Name = "节点40";
            treeNode15.Text = "<Vertex1 Vertex2 Value>";
            treeNode16.Name = "节点39";
            treeNode16.Text = "Edge File";
            treeNode17.Name = "节点16";
            treeNode17.Text = "File Format";
            treeNode18.Name = "节点13";
            treeNode18.Text = "Connectivity Format";
            treeNode19.Name = "节点1";
            treeNode19.Text = "Select File(s)";
            treeNode20.Name = "节点17";
            treeNode20.Text = "Construct a graph by loaded file(s)";
            treeNode21.Name = "节点2";
            treeNode21.Text = "Build Graph";
            treeNode22.Name = "节点42";
            treeNode22.Text = "Finds all paths in the graph.";
            treeNode23.Name = "节点43";
            treeNode23.Text = "Progress bars for current vertex and all vertices.";
            treeNode24.Name = "节点3";
            treeNode24.Text = "Run Mapping";
            treeNode25.Name = "节点19";
            treeNode25.Text = "1. Select Source";
            treeNode26.Name = "节点20";
            treeNode26.Text = "2. Select Target";
            treeNode27.Name = "节点21";
            treeNode27.Text = "3. View Paths";
            treeNode28.Name = "节点4";
            treeNode28.Text = "View Result";
            treeNode29.Name = "节点22";
            treeNode29.Text = "Not available yet.";
            treeNode30.Name = "节点5";
            treeNode30.Text = "Save Result as File";
            treeNode31.Name = "节点23";
            treeNode31.Text = "Clear all loaded files and data.";
            treeNode32.Name = "节点6";
            treeNode32.Text = "Clear";
            treeNode33.Name = "节点24";
            treeNode33.Text = "Name: Einherjar";
            treeNode34.Name = "节点26";
            treeNode34.Text = "Email: zachary625@outlook.com";
            treeNode35.Name = "节点28";
            treeNode35.Text = "Use as you like.";
            treeNode36.Name = "节点29";
            treeNode36.Text = "Remember me.";
            treeNode37.Name = "节点27";
            treeNode37.Text = "Permission";
            treeNode38.Name = "节点7";
            treeNode38.Text = "About This Shit";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode19,
            treeNode21,
            treeNode24,
            treeNode28,
            treeNode30,
            treeNode32,
            treeNode38});
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