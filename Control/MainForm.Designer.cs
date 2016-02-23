namespace Control
{
    partial class MainForm
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.buttonInit = new System.Windows.Forms.Button();
            this.buttonData = new System.Windows.Forms.Button();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.fullToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.comboSerial = new System.Windows.Forms.ComboBox();
            this.buttonSerial = new System.Windows.Forms.Button();
            this.labelStatue = new System.Windows.Forms.Label();
            this.textIn = new System.Windows.Forms.TextBox();
            this.textOut = new System.Windows.Forms.TextBox();
            this.buttonSend = new System.Windows.Forms.Button();
            this.labelData1 = new System.Windows.Forms.Label();
            this.groupBoxIn = new System.Windows.Forms.GroupBox();
            this.textData4 = new System.Windows.Forms.TextBox();
            this.labelData4 = new System.Windows.Forms.Label();
            this.textData3 = new System.Windows.Forms.TextBox();
            this.labelData3 = new System.Windows.Forms.Label();
            this.textData2 = new System.Windows.Forms.TextBox();
            this.labelData2 = new System.Windows.Forms.Label();
            this.textData1 = new System.Windows.Forms.TextBox();
            this.buttonSet = new System.Windows.Forms.Button();
            this.buttonCMD3 = new System.Windows.Forms.Button();
            this.buttonCMD1 = new System.Windows.Forms.Button();
            this.buttonCMD2 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPagePara = new System.Windows.Forms.TabPage();
            this.textPara4 = new System.Windows.Forms.TextBox();
            this.labelPara1 = new System.Windows.Forms.Label();
            this.labelPara4 = new System.Windows.Forms.Label();
            this.textPara1 = new System.Windows.Forms.TextBox();
            this.textPara3 = new System.Windows.Forms.TextBox();
            this.labelPara2 = new System.Windows.Forms.Label();
            this.labelPara3 = new System.Windows.Forms.Label();
            this.textPara2 = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textPara8 = new System.Windows.Forms.TextBox();
            this.labelPara5 = new System.Windows.Forms.Label();
            this.labelPara8 = new System.Windows.Forms.Label();
            this.textPara5 = new System.Windows.Forms.TextBox();
            this.textPara7 = new System.Windows.Forms.TextBox();
            this.labelPara6 = new System.Windows.Forms.Label();
            this.labelPara7 = new System.Windows.Forms.Label();
            this.textPara6 = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.textPara12 = new System.Windows.Forms.TextBox();
            this.labelPara9 = new System.Windows.Forms.Label();
            this.labelPara12 = new System.Windows.Forms.Label();
            this.textPara9 = new System.Windows.Forms.TextBox();
            this.textPara11 = new System.Windows.Forms.TextBox();
            this.labelPara10 = new System.Windows.Forms.Label();
            this.labelPara11 = new System.Windows.Forms.Label();
            this.textPara10 = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.settingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.programHelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBoxIn.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPagePara.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonInit
            // 
            this.buttonInit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonInit.Enabled = false;
            this.buttonInit.Location = new System.Drawing.Point(546, 73);
            this.buttonInit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonInit.Name = "buttonInit";
            this.buttonInit.Size = new System.Drawing.Size(73, 32);
            this.buttonInit.TabIndex = 1;
            this.buttonInit.Text = "Init";
            this.buttonInit.UseVisualStyleBackColor = true;
            this.buttonInit.Click += new System.EventHandler(this.buttonInit_Click);
            // 
            // buttonData
            // 
            this.buttonData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonData.Enabled = false;
            this.buttonData.Location = new System.Drawing.Point(626, 73);
            this.buttonData.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonData.Name = "buttonData";
            this.buttonData.Size = new System.Drawing.Size(76, 32);
            this.buttonData.TabIndex = 3;
            this.buttonData.Text = "Start";
            this.buttonData.UseVisualStyleBackColor = true;
            this.buttonData.Click += new System.EventHandler(this.buttonData_Click);
            // 
            // chart
            // 
            this.chart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.AxisX.ScrollBar.IsPositionedInside = false;
            chartArea1.AxisY.IsStartedFromZero = false;
            chartArea1.CursorX.IsUserEnabled = true;
            chartArea1.CursorX.IsUserSelectionEnabled = true;
            chartArea1.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea1);
            this.chart.ContextMenuStrip = this.contextMenuStrip1;
            legend1.Alignment = System.Drawing.StringAlignment.Far;
            legend1.DockedToChartArea = "ChartArea1";
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Left;
            legend1.Enabled = false;
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend1";
            this.chart.Legends.Add(legend1);
            this.chart.Location = new System.Drawing.Point(12, 33);
            this.chart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chart.Name = "chart";
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.MarkerSize = 8;
            series1.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Diamond;
            series1.Name = "Series";
            this.chart.Series.Add(series1);
            this.chart.Size = new System.Drawing.Size(526, 556);
            this.chart.TabIndex = 2;
            this.chart.Text = "chart1";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fullToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(104, 28);
            // 
            // fullToolStripMenuItem
            // 
            this.fullToolStripMenuItem.Name = "fullToolStripMenuItem";
            this.fullToolStripMenuItem.Size = new System.Drawing.Size(103, 24);
            this.fullToolStripMenuItem.Text = "Full";
            this.fullToolStripMenuItem.Click += new System.EventHandler(this.fullToolStripMenuItem_Click);
            // 
            // serialPort
            // 
            this.serialPort.BaudRate = 115200;
            this.serialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort_DataReceived);
            // 
            // comboSerial
            // 
            this.comboSerial.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboSerial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboSerial.FormattingEnabled = true;
            this.comboSerial.ItemHeight = 23;
            this.comboSerial.Location = new System.Drawing.Point(546, 33);
            this.comboSerial.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboSerial.MaxDropDownItems = 100;
            this.comboSerial.Name = "comboSerial";
            this.comboSerial.Size = new System.Drawing.Size(109, 31);
            this.comboSerial.TabIndex = 4;
            this.comboSerial.DropDown += new System.EventHandler(this.comboSerial_DropDown);
            // 
            // buttonSerial
            // 
            this.buttonSerial.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSerial.Font = new System.Drawing.Font("微软雅黑", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonSerial.Location = new System.Drawing.Point(662, 33);
            this.buttonSerial.Name = "buttonSerial";
            this.buttonSerial.Size = new System.Drawing.Size(76, 32);
            this.buttonSerial.TabIndex = 5;
            this.buttonSerial.Text = "Open";
            this.buttonSerial.UseVisualStyleBackColor = true;
            this.buttonSerial.Click += new System.EventHandler(this.buttonSerial_Click);
            // 
            // labelStatue
            // 
            this.labelStatue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelStatue.AutoSize = true;
            this.labelStatue.BackColor = System.Drawing.Color.Red;
            this.labelStatue.Location = new System.Drawing.Point(743, 36);
            this.labelStatue.Name = "labelStatue";
            this.labelStatue.Size = new System.Drawing.Size(25, 23);
            this.labelStatue.TabIndex = 6;
            this.labelStatue.Text = "   ";
            // 
            // textIn
            // 
            this.textIn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textIn.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textIn.Location = new System.Drawing.Point(546, 557);
            this.textIn.Multiline = true;
            this.textIn.Name = "textIn";
            this.textIn.Size = new System.Drawing.Size(225, 32);
            this.textIn.TabIndex = 7;
            // 
            // textOut
            // 
            this.textOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textOut.Font = new System.Drawing.Font("微软雅黑", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textOut.Location = new System.Drawing.Point(546, 519);
            this.textOut.Multiline = true;
            this.textOut.Name = "textOut";
            this.textOut.Size = new System.Drawing.Size(146, 32);
            this.textOut.TabIndex = 8;
            // 
            // buttonSend
            // 
            this.buttonSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSend.Enabled = false;
            this.buttonSend.Font = new System.Drawing.Font("微软雅黑", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonSend.Location = new System.Drawing.Point(702, 519);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(69, 32);
            this.buttonSend.TabIndex = 9;
            this.buttonSend.Text = "Send";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // labelData1
            // 
            this.labelData1.AutoSize = true;
            this.labelData1.Location = new System.Drawing.Point(5, 26);
            this.labelData1.Name = "labelData1";
            this.labelData1.Size = new System.Drawing.Size(57, 23);
            this.labelData1.TabIndex = 10;
            this.labelData1.Text = "Data1";
            // 
            // groupBoxIn
            // 
            this.groupBoxIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxIn.Controls.Add(this.textData4);
            this.groupBoxIn.Controls.Add(this.labelData4);
            this.groupBoxIn.Controls.Add(this.textData3);
            this.groupBoxIn.Controls.Add(this.labelData3);
            this.groupBoxIn.Controls.Add(this.textData2);
            this.groupBoxIn.Controls.Add(this.labelData2);
            this.groupBoxIn.Controls.Add(this.textData1);
            this.groupBoxIn.Controls.Add(this.labelData1);
            this.groupBoxIn.Location = new System.Drawing.Point(545, 303);
            this.groupBoxIn.Name = "groupBoxIn";
            this.groupBoxIn.Size = new System.Drawing.Size(225, 167);
            this.groupBoxIn.TabIndex = 11;
            this.groupBoxIn.TabStop = false;
            // 
            // textData4
            // 
            this.textData4.BackColor = System.Drawing.SystemColors.Window;
            this.textData4.Enabled = false;
            this.textData4.Location = new System.Drawing.Point(115, 120);
            this.textData4.Name = "textData4";
            this.textData4.ReadOnly = true;
            this.textData4.Size = new System.Drawing.Size(104, 30);
            this.textData4.TabIndex = 17;
            // 
            // labelData4
            // 
            this.labelData4.AutoSize = true;
            this.labelData4.Location = new System.Drawing.Point(115, 93);
            this.labelData4.Name = "labelData4";
            this.labelData4.Size = new System.Drawing.Size(57, 23);
            this.labelData4.TabIndex = 16;
            this.labelData4.Text = "Data4";
            // 
            // textData3
            // 
            this.textData3.BackColor = System.Drawing.SystemColors.Window;
            this.textData3.Enabled = false;
            this.textData3.Location = new System.Drawing.Point(5, 120);
            this.textData3.Name = "textData3";
            this.textData3.ReadOnly = true;
            this.textData3.Size = new System.Drawing.Size(104, 30);
            this.textData3.TabIndex = 15;
            // 
            // labelData3
            // 
            this.labelData3.AutoSize = true;
            this.labelData3.Location = new System.Drawing.Point(5, 93);
            this.labelData3.Name = "labelData3";
            this.labelData3.Size = new System.Drawing.Size(57, 23);
            this.labelData3.TabIndex = 14;
            this.labelData3.Text = "Data3";
            // 
            // textData2
            // 
            this.textData2.BackColor = System.Drawing.SystemColors.Window;
            this.textData2.Enabled = false;
            this.textData2.Location = new System.Drawing.Point(115, 53);
            this.textData2.Name = "textData2";
            this.textData2.ReadOnly = true;
            this.textData2.Size = new System.Drawing.Size(104, 30);
            this.textData2.TabIndex = 13;
            // 
            // labelData2
            // 
            this.labelData2.AutoSize = true;
            this.labelData2.Location = new System.Drawing.Point(115, 26);
            this.labelData2.Name = "labelData2";
            this.labelData2.Size = new System.Drawing.Size(57, 23);
            this.labelData2.TabIndex = 12;
            this.labelData2.Text = "Data2";
            // 
            // textData1
            // 
            this.textData1.BackColor = System.Drawing.SystemColors.Window;
            this.textData1.Enabled = false;
            this.textData1.Location = new System.Drawing.Point(5, 53);
            this.textData1.Name = "textData1";
            this.textData1.ReadOnly = true;
            this.textData1.Size = new System.Drawing.Size(104, 30);
            this.textData1.TabIndex = 11;
            // 
            // buttonSet
            // 
            this.buttonSet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSet.Enabled = false;
            this.buttonSet.Location = new System.Drawing.Point(710, 73);
            this.buttonSet.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonSet.Name = "buttonSet";
            this.buttonSet.Size = new System.Drawing.Size(61, 32);
            this.buttonSet.TabIndex = 12;
            this.buttonSet.Text = "Set";
            this.buttonSet.UseVisualStyleBackColor = true;
            this.buttonSet.Click += new System.EventHandler(this.buttonSet_Click);
            // 
            // buttonCMD3
            // 
            this.buttonCMD3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCMD3.Enabled = false;
            this.buttonCMD3.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonCMD3.Location = new System.Drawing.Point(702, 482);
            this.buttonCMD3.Name = "buttonCMD3";
            this.buttonCMD3.Size = new System.Drawing.Size(68, 32);
            this.buttonCMD3.TabIndex = 21;
            this.buttonCMD3.Text = "CMD3";
            this.buttonCMD3.UseVisualStyleBackColor = true;
            this.buttonCMD3.Click += new System.EventHandler(this.buttonCMD3_Click);
            // 
            // buttonCMD1
            // 
            this.buttonCMD1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCMD1.Enabled = false;
            this.buttonCMD1.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonCMD1.Location = new System.Drawing.Point(546, 482);
            this.buttonCMD1.Name = "buttonCMD1";
            this.buttonCMD1.Size = new System.Drawing.Size(68, 32);
            this.buttonCMD1.TabIndex = 22;
            this.buttonCMD1.Text = "CMD1";
            this.buttonCMD1.UseVisualStyleBackColor = true;
            this.buttonCMD1.Click += new System.EventHandler(this.buttonCMD1_Click);
            // 
            // buttonCMD2
            // 
            this.buttonCMD2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCMD2.Enabled = false;
            this.buttonCMD2.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonCMD2.Location = new System.Drawing.Point(624, 482);
            this.buttonCMD2.Name = "buttonCMD2";
            this.buttonCMD2.Size = new System.Drawing.Size(68, 32);
            this.buttonCMD2.TabIndex = 23;
            this.buttonCMD2.Text = "CMD2";
            this.buttonCMD2.UseVisualStyleBackColor = true;
            this.buttonCMD2.Click += new System.EventHandler(this.buttonCMD2_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPagePara);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(546, 113);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(225, 188);
            this.tabControl1.TabIndex = 24;
            // 
            // tabPagePara
            // 
            this.tabPagePara.BackColor = System.Drawing.Color.Transparent;
            this.tabPagePara.Controls.Add(this.textPara4);
            this.tabPagePara.Controls.Add(this.labelPara1);
            this.tabPagePara.Controls.Add(this.labelPara4);
            this.tabPagePara.Controls.Add(this.textPara1);
            this.tabPagePara.Controls.Add(this.textPara3);
            this.tabPagePara.Controls.Add(this.labelPara2);
            this.tabPagePara.Controls.Add(this.labelPara3);
            this.tabPagePara.Controls.Add(this.textPara2);
            this.tabPagePara.Location = new System.Drawing.Point(4, 32);
            this.tabPagePara.Name = "tabPagePara";
            this.tabPagePara.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePara.Size = new System.Drawing.Size(217, 152);
            this.tabPagePara.TabIndex = 0;
            this.tabPagePara.Text = "Grp1";
            // 
            // textPara4
            // 
            this.textPara4.Enabled = false;
            this.textPara4.Location = new System.Drawing.Point(116, 108);
            this.textPara4.Name = "textPara4";
            this.textPara4.Size = new System.Drawing.Size(94, 30);
            this.textPara4.TabIndex = 25;
            // 
            // labelPara1
            // 
            this.labelPara1.AutoSize = true;
            this.labelPara1.Location = new System.Drawing.Point(6, 14);
            this.labelPara1.Name = "labelPara1";
            this.labelPara1.Size = new System.Drawing.Size(54, 23);
            this.labelPara1.TabIndex = 18;
            this.labelPara1.Text = "Para1";
            // 
            // labelPara4
            // 
            this.labelPara4.AutoSize = true;
            this.labelPara4.Location = new System.Drawing.Point(116, 81);
            this.labelPara4.Name = "labelPara4";
            this.labelPara4.Size = new System.Drawing.Size(54, 23);
            this.labelPara4.TabIndex = 24;
            this.labelPara4.Text = "Para4";
            // 
            // textPara1
            // 
            this.textPara1.Enabled = false;
            this.textPara1.Location = new System.Drawing.Point(6, 41);
            this.textPara1.Name = "textPara1";
            this.textPara1.Size = new System.Drawing.Size(92, 30);
            this.textPara1.TabIndex = 19;
            // 
            // textPara3
            // 
            this.textPara3.Enabled = false;
            this.textPara3.Location = new System.Drawing.Point(6, 108);
            this.textPara3.Name = "textPara3";
            this.textPara3.Size = new System.Drawing.Size(92, 30);
            this.textPara3.TabIndex = 23;
            // 
            // labelPara2
            // 
            this.labelPara2.AutoSize = true;
            this.labelPara2.Location = new System.Drawing.Point(116, 14);
            this.labelPara2.Name = "labelPara2";
            this.labelPara2.Size = new System.Drawing.Size(54, 23);
            this.labelPara2.TabIndex = 20;
            this.labelPara2.Text = "Para2";
            // 
            // labelPara3
            // 
            this.labelPara3.AutoSize = true;
            this.labelPara3.Location = new System.Drawing.Point(6, 81);
            this.labelPara3.Name = "labelPara3";
            this.labelPara3.Size = new System.Drawing.Size(54, 23);
            this.labelPara3.TabIndex = 22;
            this.labelPara3.Text = "Para3";
            // 
            // textPara2
            // 
            this.textPara2.Enabled = false;
            this.textPara2.Location = new System.Drawing.Point(118, 41);
            this.textPara2.Name = "textPara2";
            this.textPara2.Size = new System.Drawing.Size(92, 30);
            this.textPara2.TabIndex = 21;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Transparent;
            this.tabPage2.Controls.Add(this.textPara8);
            this.tabPage2.Controls.Add(this.labelPara5);
            this.tabPage2.Controls.Add(this.labelPara8);
            this.tabPage2.Controls.Add(this.textPara5);
            this.tabPage2.Controls.Add(this.textPara7);
            this.tabPage2.Controls.Add(this.labelPara6);
            this.tabPage2.Controls.Add(this.labelPara7);
            this.tabPage2.Controls.Add(this.textPara6);
            this.tabPage2.Location = new System.Drawing.Point(4, 32);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(217, 152);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Grp2";
            // 
            // textPara8
            // 
            this.textPara8.Enabled = false;
            this.textPara8.Location = new System.Drawing.Point(116, 108);
            this.textPara8.Name = "textPara8";
            this.textPara8.Size = new System.Drawing.Size(94, 30);
            this.textPara8.TabIndex = 25;
            // 
            // labelPara5
            // 
            this.labelPara5.AutoSize = true;
            this.labelPara5.Location = new System.Drawing.Point(6, 14);
            this.labelPara5.Name = "labelPara5";
            this.labelPara5.Size = new System.Drawing.Size(54, 23);
            this.labelPara5.TabIndex = 18;
            this.labelPara5.Text = "Para5";
            // 
            // labelPara8
            // 
            this.labelPara8.AutoSize = true;
            this.labelPara8.Location = new System.Drawing.Point(116, 81);
            this.labelPara8.Name = "labelPara8";
            this.labelPara8.Size = new System.Drawing.Size(54, 23);
            this.labelPara8.TabIndex = 24;
            this.labelPara8.Text = "Para8";
            // 
            // textPara5
            // 
            this.textPara5.Enabled = false;
            this.textPara5.Location = new System.Drawing.Point(6, 41);
            this.textPara5.Name = "textPara5";
            this.textPara5.Size = new System.Drawing.Size(92, 30);
            this.textPara5.TabIndex = 19;
            // 
            // textPara7
            // 
            this.textPara7.Enabled = false;
            this.textPara7.Location = new System.Drawing.Point(6, 108);
            this.textPara7.Name = "textPara7";
            this.textPara7.Size = new System.Drawing.Size(92, 30);
            this.textPara7.TabIndex = 23;
            // 
            // labelPara6
            // 
            this.labelPara6.AutoSize = true;
            this.labelPara6.Location = new System.Drawing.Point(116, 14);
            this.labelPara6.Name = "labelPara6";
            this.labelPara6.Size = new System.Drawing.Size(54, 23);
            this.labelPara6.TabIndex = 20;
            this.labelPara6.Text = "Para6";
            // 
            // labelPara7
            // 
            this.labelPara7.AutoSize = true;
            this.labelPara7.Location = new System.Drawing.Point(6, 81);
            this.labelPara7.Name = "labelPara7";
            this.labelPara7.Size = new System.Drawing.Size(54, 23);
            this.labelPara7.TabIndex = 22;
            this.labelPara7.Text = "Para7";
            // 
            // textPara6
            // 
            this.textPara6.Enabled = false;
            this.textPara6.Location = new System.Drawing.Point(118, 41);
            this.textPara6.Name = "textPara6";
            this.textPara6.Size = new System.Drawing.Size(92, 30);
            this.textPara6.TabIndex = 21;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.Transparent;
            this.tabPage3.Controls.Add(this.textPara12);
            this.tabPage3.Controls.Add(this.labelPara9);
            this.tabPage3.Controls.Add(this.labelPara12);
            this.tabPage3.Controls.Add(this.textPara9);
            this.tabPage3.Controls.Add(this.textPara11);
            this.tabPage3.Controls.Add(this.labelPara10);
            this.tabPage3.Controls.Add(this.labelPara11);
            this.tabPage3.Controls.Add(this.textPara10);
            this.tabPage3.Location = new System.Drawing.Point(4, 32);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(217, 152);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Grp3";
            // 
            // textPara12
            // 
            this.textPara12.Enabled = false;
            this.textPara12.Location = new System.Drawing.Point(116, 108);
            this.textPara12.Name = "textPara12";
            this.textPara12.Size = new System.Drawing.Size(94, 30);
            this.textPara12.TabIndex = 25;
            // 
            // labelPara9
            // 
            this.labelPara9.AutoSize = true;
            this.labelPara9.Location = new System.Drawing.Point(6, 14);
            this.labelPara9.Name = "labelPara9";
            this.labelPara9.Size = new System.Drawing.Size(54, 23);
            this.labelPara9.TabIndex = 18;
            this.labelPara9.Text = "Para9";
            // 
            // labelPara12
            // 
            this.labelPara12.AutoSize = true;
            this.labelPara12.Location = new System.Drawing.Point(116, 81);
            this.labelPara12.Name = "labelPara12";
            this.labelPara12.Size = new System.Drawing.Size(64, 23);
            this.labelPara12.TabIndex = 24;
            this.labelPara12.Text = "Para12";
            // 
            // textPara9
            // 
            this.textPara9.Enabled = false;
            this.textPara9.Location = new System.Drawing.Point(6, 41);
            this.textPara9.Name = "textPara9";
            this.textPara9.Size = new System.Drawing.Size(92, 30);
            this.textPara9.TabIndex = 19;
            // 
            // textPara11
            // 
            this.textPara11.Enabled = false;
            this.textPara11.Location = new System.Drawing.Point(6, 108);
            this.textPara11.Name = "textPara11";
            this.textPara11.Size = new System.Drawing.Size(92, 30);
            this.textPara11.TabIndex = 23;
            // 
            // labelPara10
            // 
            this.labelPara10.AutoSize = true;
            this.labelPara10.Location = new System.Drawing.Point(116, 14);
            this.labelPara10.Name = "labelPara10";
            this.labelPara10.Size = new System.Drawing.Size(64, 23);
            this.labelPara10.TabIndex = 20;
            this.labelPara10.Text = "Para10";
            // 
            // labelPara11
            // 
            this.labelPara11.AutoSize = true;
            this.labelPara11.Location = new System.Drawing.Point(6, 81);
            this.labelPara11.Name = "labelPara11";
            this.labelPara11.Size = new System.Drawing.Size(64, 23);
            this.labelPara11.TabIndex = 22;
            this.labelPara11.Text = "Para11";
            // 
            // textPara10
            // 
            this.textPara10.Enabled = false;
            this.textPara10.Location = new System.Drawing.Point(118, 41);
            this.textPara10.Name = "textPara10";
            this.textPara10.Size = new System.Drawing.Size(92, 30);
            this.textPara10.TabIndex = 21;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(782, 31);
            this.menuStrip1.TabIndex = 25;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // settingToolStripMenuItem
            // 
            this.settingToolStripMenuItem.Name = "settingToolStripMenuItem";
            this.settingToolStripMenuItem.Size = new System.Drawing.Size(80, 27);
            this.settingToolStripMenuItem.Text = "Setting";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(67, 27);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.programHelpToolStripMenuItem,
            this.toolStripMenuItem1,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(61, 27);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // programHelpToolStripMenuItem
            // 
            this.programHelpToolStripMenuItem.Name = "programHelpToolStripMenuItem";
            this.programHelpToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.programHelpToolStripMenuItem.Size = new System.Drawing.Size(222, 28);
            this.programHelpToolStripMenuItem.Text = "Program Help";
            this.programHelpToolStripMenuItem.Click += new System.EventHandler(this.programHelpToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(219, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(222, 28);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 603);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.buttonCMD2);
            this.Controls.Add(this.buttonCMD1);
            this.Controls.Add(this.buttonCMD3);
            this.Controls.Add(this.buttonSet);
            this.Controls.Add(this.groupBoxIn);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.textOut);
            this.Controls.Add(this.textIn);
            this.Controls.Add(this.labelStatue);
            this.Controls.Add(this.buttonSerial);
            this.Controls.Add(this.comboSerial);
            this.Controls.Add(this.chart);
            this.Controls.Add(this.buttonInit);
            this.Controls.Add(this.buttonData);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("微软雅黑", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(260, 620);
            this.Name = "MainForm";
            this.Text = "通用上位机";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBoxIn.ResumeLayout(false);
            this.groupBoxIn.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPagePara.ResumeLayout(false);
            this.tabPagePara.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonInit;
        private System.Windows.Forms.Button buttonData;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.ComboBox comboSerial;
        private System.Windows.Forms.Button buttonSerial;
        private System.Windows.Forms.Label labelStatue;
        private System.Windows.Forms.TextBox textIn;
        private System.Windows.Forms.TextBox textOut;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.Label labelData1;
        private System.Windows.Forms.GroupBox groupBoxIn;
        private System.Windows.Forms.TextBox textData1;
        private System.Windows.Forms.TextBox textData4;
        private System.Windows.Forms.Label labelData4;
        private System.Windows.Forms.TextBox textData3;
        private System.Windows.Forms.Label labelData3;
        private System.Windows.Forms.TextBox textData2;
        private System.Windows.Forms.Label labelData2;
        private System.Windows.Forms.Button buttonSet;
        private System.Windows.Forms.Button buttonCMD3;
        private System.Windows.Forms.Button buttonCMD1;
        private System.Windows.Forms.Button buttonCMD2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPagePara;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox textPara4;
        private System.Windows.Forms.Label labelPara1;
        private System.Windows.Forms.Label labelPara4;
        private System.Windows.Forms.TextBox textPara1;
        private System.Windows.Forms.TextBox textPara3;
        private System.Windows.Forms.Label labelPara2;
        private System.Windows.Forms.Label labelPara3;
        private System.Windows.Forms.TextBox textPara2;
        private System.Windows.Forms.TextBox textPara8;
        private System.Windows.Forms.Label labelPara5;
        private System.Windows.Forms.Label labelPara8;
        private System.Windows.Forms.TextBox textPara5;
        private System.Windows.Forms.TextBox textPara7;
        private System.Windows.Forms.Label labelPara6;
        private System.Windows.Forms.Label labelPara7;
        private System.Windows.Forms.TextBox textPara6;
        private System.Windows.Forms.TextBox textPara12;
        private System.Windows.Forms.Label labelPara9;
        private System.Windows.Forms.Label labelPara12;
        private System.Windows.Forms.TextBox textPara9;
        private System.Windows.Forms.TextBox textPara11;
        private System.Windows.Forms.Label labelPara10;
        private System.Windows.Forms.Label labelPara11;
        private System.Windows.Forms.TextBox textPara10;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem settingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem programHelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fullToolStripMenuItem;
    }
}

