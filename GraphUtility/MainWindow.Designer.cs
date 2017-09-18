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
            this.Button_LoadFile = new System.Windows.Forms.Button();
            this.TextBox_FilePath = new System.Windows.Forms.TextBox();
            this.ListBox_Label = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // Button_LoadFile
            // 
            this.Button_LoadFile.Location = new System.Drawing.Point(730, 12);
            this.Button_LoadFile.Name = "Button_LoadFile";
            this.Button_LoadFile.Size = new System.Drawing.Size(75, 23);
            this.Button_LoadFile.TabIndex = 0;
            this.Button_LoadFile.Text = "Load...";
            this.Button_LoadFile.UseVisualStyleBackColor = true;
            // 
            // TextBox_FilePath
            // 
            this.TextBox_FilePath.Location = new System.Drawing.Point(13, 12);
            this.TextBox_FilePath.Name = "TextBox_FilePath";
            this.TextBox_FilePath.Size = new System.Drawing.Size(711, 21);
            this.TextBox_FilePath.TabIndex = 1;
            // 
            // ListBox_Label
            // 
            this.ListBox_Label.FormattingEnabled = true;
            this.ListBox_Label.ItemHeight = 12;
            this.ListBox_Label.Location = new System.Drawing.Point(548, 40);
            this.ListBox_Label.Name = "ListBox_Label";
            this.ListBox_Label.Size = new System.Drawing.Size(257, 460);
            this.ListBox_Label.TabIndex = 2;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 516);
            this.Controls.Add(this.ListBox_Label);
            this.Controls.Add(this.TextBox_FilePath);
            this.Controls.Add(this.Button_LoadFile);
            this.Name = "MainWindow";
            this.Text = "MainWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Button_LoadFile;
        private System.Windows.Forms.TextBox TextBox_FilePath;
        private System.Windows.Forms.ListBox ListBox_Label;
    }
}

