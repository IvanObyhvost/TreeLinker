namespace TreeLinker
{
    partial class Form1
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
            this.urlLink = new System.Windows.Forms.Label();
            this.tbLink = new System.Windows.Forms.TextBox();
            this.btBuildTree = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.numDepthTree = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbException = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToXmlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lbWaite = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numDepthTree)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // urlLink
            // 
            this.urlLink.AutoSize = true;
            this.urlLink.Location = new System.Drawing.Point(6, 33);
            this.urlLink.Name = "urlLink";
            this.urlLink.Size = new System.Drawing.Size(60, 13);
            this.urlLink.TabIndex = 0;
            this.urlLink.Text = "Enter URL:";
            // 
            // tbLink
            // 
            this.tbLink.Location = new System.Drawing.Point(86, 30);
            this.tbLink.Name = "tbLink";
            this.tbLink.Size = new System.Drawing.Size(199, 20);
            this.tbLink.TabIndex = 1;
            // 
            // btBuildTree
            // 
            this.btBuildTree.Location = new System.Drawing.Point(435, 28);
            this.btBuildTree.Name = "btBuildTree";
            this.btBuildTree.Size = new System.Drawing.Size(116, 23);
            this.btBuildTree.TabIndex = 2;
            this.btBuildTree.Text = "Build tree";
            this.btBuildTree.UseVisualStyleBackColor = true;
            this.btBuildTree.Click += new System.EventHandler(this.btBuildTree_Click);
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(23, 105);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(837, 422);
            this.treeView1.TabIndex = 3;
            // 
            // numDepthTree
            // 
            this.numDepthTree.Location = new System.Drawing.Point(388, 31);
            this.numDepthTree.Name = "numDepthTree";
            this.numDepthTree.Size = new System.Drawing.Size(41, 20);
            this.numDepthTree.TabIndex = 5;
            this.numDepthTree.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbException);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.numDepthTree);
            this.groupBox1.Controls.Add(this.tbLink);
            this.groupBox1.Controls.Add(this.urlLink);
            this.groupBox1.Controls.Add(this.btBuildTree);
            this.groupBox1.Location = new System.Drawing.Point(23, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(557, 72);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search options";
            // 
            // lbException
            // 
            this.lbException.ForeColor = System.Drawing.Color.Red;
            this.lbException.Location = new System.Drawing.Point(86, 54);
            this.lbException.Name = "lbException";
            this.lbException.Size = new System.Drawing.Size(199, 15);
            this.lbException.TabIndex = 7;
            this.lbException.Text = "Exception";
            this.lbException.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "For example: http://gitaristtv.ru/";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(308, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Search depth:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(888, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToXmlToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToXmlToolStripMenuItem
            // 
            this.saveToXmlToolStripMenuItem.Name = "saveToXmlToolStripMenuItem";
            this.saveToXmlToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.saveToXmlToolStripMenuItem.Text = "Save to xml";
            this.saveToXmlToolStripMenuItem.Click += new System.EventHandler(this.saveToXmlToolStripMenuItem_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(586, 60);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(274, 23);
            this.progressBar1.TabIndex = 9;
            // 
            // lbWaite
            // 
            this.lbWaite.Location = new System.Drawing.Point(631, 42);
            this.lbWaite.Name = "lbWaite";
            this.lbWaite.Size = new System.Drawing.Size(194, 13);
            this.lbWaite.TabIndex = 10;
            this.lbWaite.Text = "Please wait, building tree...";
            this.lbWaite.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbWaite.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 535);
            this.Controls.Add(this.lbWaite);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dependency Tree Links Online";
            ((System.ComponentModel.ISupportInitialize)(this.numDepthTree)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label urlLink;
        private System.Windows.Forms.TextBox tbLink;
        private System.Windows.Forms.Button btBuildTree;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.NumericUpDown numDepthTree;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbException;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToXmlToolStripMenuItem;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lbWaite;
    }
}

