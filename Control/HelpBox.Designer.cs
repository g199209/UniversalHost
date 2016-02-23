namespace Control
{
    partial class HelpBox
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
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("通信协议");
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("初始化设置");
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("数据更新");
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("字符串");
            System.Windows.Forms.TreeNode treeNode25 = new System.Windows.Forms.TreeNode("下位机数据包", new System.Windows.Forms.TreeNode[] {
            treeNode22,
            treeNode23,
            treeNode24});
            System.Windows.Forms.TreeNode treeNode26 = new System.Windows.Forms.TreeNode("初始化指令");
            System.Windows.Forms.TreeNode treeNode27 = new System.Windows.Forms.TreeNode("通信控制");
            System.Windows.Forms.TreeNode treeNode28 = new System.Windows.Forms.TreeNode("参数设置");
            System.Windows.Forms.TreeNode treeNode29 = new System.Windows.Forms.TreeNode("控制指令");
            System.Windows.Forms.TreeNode treeNode30 = new System.Windows.Forms.TreeNode("上位机数据包", new System.Windows.Forms.TreeNode[] {
            treeNode26,
            treeNode27,
            treeNode28,
            treeNode29});
            this.textBox = new System.Windows.Forms.TextBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // textBox
            // 
            this.textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox.BackColor = System.Drawing.SystemColors.Window;
            this.textBox.Location = new System.Drawing.Point(214, 22);
            this.textBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.ReadOnly = true;
            this.textBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox.Size = new System.Drawing.Size(664, 397);
            this.textBox.TabIndex = 1;
            // 
            // treeView1
            // 
            this.treeView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.treeView1.Location = new System.Drawing.Point(18, 22);
            this.treeView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.treeView1.Name = "treeView1";
            treeNode21.Name = "Node1";
            treeNode21.Text = "通信协议";
            treeNode22.Name = "Node3";
            treeNode22.Text = "初始化设置";
            treeNode23.Name = "Node4";
            treeNode23.Text = "数据更新";
            treeNode24.Name = "Node5";
            treeNode24.Text = "字符串";
            treeNode25.Checked = true;
            treeNode25.Name = "Node2";
            treeNode25.Text = "下位机数据包";
            treeNode26.Name = "Node7";
            treeNode26.Text = "初始化指令";
            treeNode27.Name = "Node8";
            treeNode27.Text = "通信控制";
            treeNode28.Name = "Node9";
            treeNode28.Text = "参数设置";
            treeNode29.Name = "Node10";
            treeNode29.Text = "控制指令";
            treeNode30.Checked = true;
            treeNode30.Name = "Node6";
            treeNode30.Text = "上位机数据包";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode21,
            treeNode25,
            treeNode30});
            this.treeView1.Size = new System.Drawing.Size(179, 397);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // HelpBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 438);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.treeView1);
            this.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "HelpBox";
            this.Text = "HelpBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.TreeView treeView1;
    }
}