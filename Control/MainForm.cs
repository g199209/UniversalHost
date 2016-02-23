/**
  **************************************************************
  * @file       MainForm.cs
  * @author     高明飞
  * @version    V1.0
  * @date       2016-2-23
  *
  * @brief      程序主窗体
  *
  * @details 
  * @verbatim
  * 程序主窗体
  *
  * 修改记录：
  * 2015-4-14 :
  *   - File Created.
  *
  * @endverbatim
  ***************************************************************
  */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Control
{
    public partial class MainForm : Form
    {
        private string SerialData = "";
        private string[,] SeriesName;
        private bool IsStart = false;
        private TextBox[] TextPara = new TextBox[12];
        private TextBox[] TextData = new TextBox[4];
        private Label[] LabelPara = new Label[12];
        private Label[] LabelData = new Label[4];
        private Button[] buttonCMD = new Button[3];

        public MainForm()
        {
            InitializeComponent();

            TextPara[0] = textPara1;
            TextPara[1] = textPara2;
            TextPara[2] = textPara3;
            TextPara[3] = textPara4;
            TextPara[4] = textPara5;
            TextPara[5] = textPara6;
            TextPara[6] = textPara7;
            TextPara[7] = textPara8;
            TextPara[8] = textPara9;
            TextPara[9] = textPara10;
            TextPara[10] = textPara11;
            TextPara[11] = textPara12;

            TextData[0] = textData1;
            TextData[1] = textData2;
            TextData[2] = textData3;
            TextData[3] = textData4;

            LabelPara[0] = labelPara1;
            LabelPara[1] = labelPara2;
            LabelPara[2] = labelPara3;
            LabelPara[3] = labelPara4;
            LabelPara[4] = labelPara5;
            LabelPara[5] = labelPara6;
            LabelPara[6] = labelPara7;
            LabelPara[7] = labelPara8;
            LabelPara[8] = labelPara9;
            LabelPara[9] = labelPara10;
            LabelPara[10] = labelPara11;
            LabelPara[11] = labelPara12;

            LabelData[0] = labelData1;
            LabelData[1] = labelData2;
            LabelData[2] = labelData3;
            LabelData[3] = labelData4;

            buttonCMD[0] = buttonCMD1;
            buttonCMD[1] = buttonCMD2;
            buttonCMD[2] = buttonCMD3;
        }

        private void comboSerial_DropDown(object sender, EventArgs e)
        {
            UpdateSerial();
        }

        private void UpdateSerial()
        {
            string[] ports = SerialPort.GetPortNames();
            Array.Sort(ports);
            comboSerial.Items.Clear();
            comboSerial.Items.AddRange(ports);
        }

        private void buttonSerial_Click(object sender, EventArgs e)
        {
            //Open serial
            if(!serialPort.IsOpen)
            {
                try
                {
                    serialPort.PortName = comboSerial.Text;
                    serialPort.Open();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                } 
            }
            //Close serial
            else
            {
                if(IsStart)
                {
                    serialPort.WriteLine("&2");
                    buttonData.Text = "Start";
                    IsStart = false;
                    labelStatue.BackColor = IsStart ? Color.Green : Color.Yellow;
                }
                try
                {
                    serialPort.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                if (!serialPort.IsOpen)
                {
                    foreach (TextBox tb in TextPara)
                    {
                        tb.Enabled = false;
                    }
                    foreach (TextBox tb in TextData)
                    {
                        tb.Enabled = false;
                    }
                    foreach(Button btn in buttonCMD)
                    {
                        btn.Enabled = false;
                    }
                    buttonSet.Enabled = false;
                    buttonData.Enabled = false;
                }
                
                
            }
            //Update button and label
            buttonSerial.Text = serialPort.IsOpen ? "Close" : "Open";
            labelStatue.BackColor = serialPort.IsOpen ? Color.Yellow : Color.Red;
            buttonInit.Enabled = serialPort.IsOpen;
            buttonSend.Enabled = serialPort.IsOpen;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Close serial
            if(serialPort.IsOpen)
            {
                try
                {
                    serialPort.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void serialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            int n = serialPort.BytesToRead;
            byte[] buf = new byte[n];
            serialPort.Read(buf, 0, n);
            string res = System.Text.Encoding.Default.GetString(buf);
            SerialData = SerialData + res;
            while (ParseSerial()) ;
        }

        private bool ParseSerial()
        {
            // Find one frame
            if (!SerialData.Contains("\n"))
                return false;
            Regex rgx = new Regex(@"(.*?)\n");
            Match m = rgx.Match(SerialData);
            SerialData = rgx.Replace(SerialData,"",1);
            string validData = m.Groups[1].Value;

            // Parse message
            string [] msg;
            if (validData.Contains("$"))
            {
                msg = validData.Split('$');
                UpdateMessage(msg[1]);
                return true;
            }

            // Parse Initialize data
            // &3@3@1@1#voltage#current#power#speed#torque&3@P@I@D#1#0.5#0.2&2@Temp@Height&2@Up@Down&
            string[] pieces;
            int k = 1;
            if (validData.Contains("&"))
            {
                // Chart
                // Count
                pieces = validData.Split(new Char[] { '&', '@', '#' });
                int chartN = Int32.Parse(pieces[k]);

                // ChartN为0说明没有图表，不需要初始化Chart
                if(chartN != 0)
                {
                    int[] chartCount = new int[chartN];
                    for (int i = 0; i < chartN; i++)
                    {
                        k++;
                        chartCount[i] = Int32.Parse(pieces[k]);
                    }
                    // Name
                    int[] tmp = new int[chartN];
                    chartCount.CopyTo(tmp, 0);
                    Array.Sort(tmp);
                    SeriesName = new string[chartN, tmp[chartN - 1]];
                    for (int i = 0; i < chartN; i++)
                    {
                        for (int j = 0; j < chartCount[i]; j++)
                        {
                            k++;
                            SeriesName[i, j] = pieces[k];
                        }
                    }
                    ChartInit(chartN, chartCount);
                }
                
                // Parameter
                k++;
                int paraN = Int32.Parse(pieces[k]);
                string [] ParaName = new string[paraN];
                string [] Paravalue = new string[paraN];
                for (int i = 0; i < paraN; i++)
                {
                    k++;
                    ParaName[i] = pieces[k];
                }
                for (int i = 0; i < paraN; i++)
                {
                    k++;
                    Paravalue[i] = pieces[k];
                }

                // Data
                k++;
                int dataN = Int32.Parse(pieces[k]);
                string [] DataName = new string[dataN];
                for (int i = 0; i < dataN; i++)
                {
                    k++;
                    DataName[i] = pieces[k];
                }
                textboxInit(paraN, ParaName, Paravalue, dataN, DataName);

                // Command
                k++;
                int CMDN = Int32.Parse(pieces[k]);
                string[] CMDName = new string[CMDN];
                for (int i = 0; i < CMDN; i++)
                {
                    k++;
                    CMDName[i] = pieces[k];
                }
                CMDInit(CMDN, CMDName);

                return true;
            }

            // Parse data
            // !1@1#23!1@2#15!1@3#2.4!2@1#980!3@1#-56.45!0@1#23.5
            if(IsStart)
            {
                rgx = new Regex(@"!\d*@\d*#[\d\.\-]*");
                m = rgx.Match(validData);
                string[] num;
                while (m.Success)
                {
                    num = m.Value.Split(new Char[] { '!', '@', '#' });
                    UpdateData(Int32.Parse(num[1]), Int32.Parse(num[2]), Double.Parse(num[3]));
                    m = m.NextMatch();
                }
            }
            return true;
        }



        private void UpdateData(int m, int n, double num)
        {
            this.Invoke((EventHandler)(delegate
            {
                if (m == 0)
                    TextData[n - 1].Text = num.ToString();
                else
                {
                    chart.Series[SeriesName[m - 1, n - 1]].Points.AddY(num);
                    if (chart.ChartAreas[m - 1].AxisX.Maximum - chart.ChartAreas[m - 1].AxisX.Minimum > 200)
                        chart.ChartAreas[m - 1].AxisX.Minimum = chart.ChartAreas[m - 1].AxisX.Maximum - 200;
                }
                    
            }));
        }

        private void UpdateMessage(string msg)
        {
            this.Invoke((EventHandler)(delegate
            {
                textIn.AppendText(msg + "\n");
            }));
        }

        private void ChartInit(int N, int [] count)
        {
            ChartArea myChartArea;
            Series mySeries;
            Legend myLegend;

            this.Invoke((EventHandler)(delegate
            {
                chart.ChartAreas.Clear();
                chart.Series.Clear();
                chart.Legends.Clear();

                for (int i = 0; i < N; i++)
                {
                    myChartArea = new ChartArea();
                    myChartArea.Name = "ChartAreas" + i.ToString();
                    chart.ChartAreas.Add(myChartArea);
                    chart.ChartAreas[i].CursorX.AutoScroll = true;
                    chart.ChartAreas[i].AxisX.ScrollBar.Enabled = true;
                    chart.ChartAreas[i].CursorX.IsUserEnabled = true;
                    chart.ChartAreas[i].CursorX.IsUserSelectionEnabled = true;
                    chart.ChartAreas[i].AxisX.ScaleView.Zoomable = true;
                    chart.ChartAreas[i].CursorY.AutoScroll = true;
                    chart.ChartAreas[i].AxisY.ScrollBar.Enabled = true;
                    chart.ChartAreas[i].CursorY.IsUserEnabled = true;
                    chart.ChartAreas[i].CursorY.IsUserSelectionEnabled = true;
                    chart.ChartAreas[i].AxisY.ScaleView.Zoomable = true;
                    chart.ChartAreas[i].AxisY.IsStartedFromZero = false; // IsStartedFromZero

                    myLegend = new Legend();
                    myLegend.Name = "Legend" + i.ToString();
                    chart.Legends.Add(myLegend);
                    chart.Legends[i].DockedToChartArea = ("ChartAreas" + i.ToString());
                    chart.Legends[i].Alignment = StringAlignment.Far;
                    chart.Legends[i].Docking = Docking.Left;

                    for(int j = 0;j<count[i];j++)
                    {
                        mySeries = new Series();
                        mySeries.Name = SeriesName[i, j];
                        chart.Series.Add(mySeries);
                        chart.Series[SeriesName[i, j]].MarkerStyle = MarkerStyle.None;
                        chart.Series[SeriesName[i, j]].MarkerSize = 8;
                        chart.Series[SeriesName[i, j]].ChartArea = ("ChartAreas" + i.ToString());
                        chart.Series[SeriesName[i, j]].ChartType = SeriesChartType.FastLine;
                        chart.Series[SeriesName[i, j]].BorderWidth = 2;
                        chart.Series[SeriesName[i, j]].Legend = ("Legend" + i.ToString());
                    }
                }

                
            }));
        }

        private void textboxInit(int paraN, string [] paraName, string [] paraValue, int dataN, string [] dataName)
        {
            this.Invoke((EventHandler)(delegate
            {
                for(int i = 0;i<paraN;i++)
                {
                    TextPara[i].Enabled = true;
                    //TextPara[i].Text = paraValue[i];
                    LabelPara[i].Text = paraName[i];
                }

                for (int i = 0; i < dataN; i++)
                {
                    TextData[i].Enabled = true;
                    TextData[i].Clear();
                    LabelData[i].Text = dataName[i];
                }

                if (paraN > 0)
                    buttonSet.Enabled = true;
            }));
        }

        private void CMDInit(int CMDN, string[] CMDName)
        {
            this.Invoke((EventHandler)(delegate
            {
                for (int i = 0; i < CMDN; i++)
                {
                    buttonCMD[i].Enabled = true;
                    buttonCMD[i].Text = CMDName[i];
                }
            }));
        }

        private void buttonInit_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort.WriteLine("&0");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            buttonData.Enabled = true;
            buttonData.Text = "Start";
            IsStart = false;
            labelStatue.BackColor = IsStart ? Color.Green : Color.Yellow;
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            serialPort.WriteLine(textOut.Text);
        }

        private void buttonCMD1_Click(object sender, EventArgs e)
        {
            serialPort.WriteLine("&A");
        }

        private void buttonCMD2_Click(object sender, EventArgs e)
        {
            serialPort.WriteLine("&B");
        }

        private void buttonCMD3_Click(object sender, EventArgs e)
        {
            serialPort.WriteLine("&C");
        }

        private void buttonSet_Click(object sender, EventArgs e)
        {
            string s = "";
            int i = 0;
            //!1#2389!2#5.3!3#-7
            foreach (TextBox tb in TextPara)
            {
                if (!tb.Enabled)
                    break;
                i++;
                s += ("!" + i.ToString() + "#");
                s += tb.Text;
            }
            serialPort.WriteLine(s);
        }

        private void buttonData_Click(object sender, EventArgs e)
        {
            // End
            if(IsStart)
            {
                buttonData.Text = "Start";
                serialPort.WriteLine("&2");
                IsStart = false;
            }
            // Start
            else
            {
                buttonData.Text = "End";
                serialPort.WriteLine("&1");
                IsStart = true;
            }
            labelStatue.BackColor = IsStart ? Color.Green : Color.Yellow;
        }

        private void programHelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HelpBox helpForm = new HelpBox();
            helpForm.Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox aboutForm = new AboutBox();
            aboutForm.Show();
        }

        private void fullToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach(ChartArea carea in chart.ChartAreas)
            {
                carea.AxisX.Minimum = 0;
            }
        }

    }
}
