/**
  **************************************************************
  * @file       HelpBox.cs
  * @author     高明飞
  * @version    V1.0
  * @date       2016-2-23
  *
  * @brief      帮助窗口
  *
  * @details 
  * @verbatim
  * 帮助窗口
  *
  * 修改记录：
  * 2015-4-15 :
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
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Control
{
    public partial class HelpBox : Form
    {
        private string[] page1 = new string[12];
        private string[] page2 = new string[4];
        private string[] page3 = new string[26];
        private string[] page4 = new string[6];
        private string[] page5 = new string[5];
        private string[] page6 = new string[5];
        private string[] page7 = new string[3];
        private string[] page8 = new string[6];
        private string[] page9 = new string[6];
        private string[] page10 = new string[7];

        public HelpBox()
        {
            InitializeComponent();

            page1[0] = @"上位机与下位机之间以数据包的形式通信。每个数据包有若干字节数据，以ACSII码进行编码，所有数据包均以'\n'结束。";
            page1[1] = @"本程序为一般调试过程设计，故假设上位机与下位机之间的通信信道是稳定可靠的，不考虑传输过程中出现的错误，未加入数据校验环节。";
            page1[2] = @"基本通信过程如下：";
            page1[3] = @"1.上位机发送初始化指令；";
            page1[4] = @"2.下位机发送初始化设置数据包；";
            page1[5] = @"3.上位机发送开始接收数据指令；";
            page1[6] = @"4.下位机根据需要发送数据更新数据包；";
            page1[7] = @"5.上位机根据需要发送参数设置数据包及控制指令；";
            page1[8] = @"6.上位机发送停止接收数据指令后下位机不再发送数据更新数据包；";
            page1[9] = @"注：";
            page1[10] = @"1.下位机发送的字符串数据包始终有效；";
            page1[11] = @"2.上位机也可发送自定义数据至下位机。";

            page2[0] = @"下位机向上位机发送的数据包有以下几类：";
            page2[1] = @"1.初始化设置数据包：初始化上位机设置；";
            page2[2] = @"2.数据更新数据包：此时需要更新显示的数据；";
            page2[3] = @"3.字符串数据包：需要显示在上位机调试窗口中的字符串信息。";

            page3[0] = @"初始化设置数据包用于向上位机提供初始化数据，其结构分为4部分：";
            page3[1] = @"1.  曲线图表初始化";
            page3[2] = @"&{图表数量}@{每个图表中曲线数量}…#{曲线名称}…";
            page3[3] = @"其中，第二组参数数量应等于第一个参数，第三组参数数量应等于第二组参数之和。";
            page3[4] = @"如：";
            page3[5] = @"&3@3@1@1#voltage#current#power#speed#torque";
            page3[6] = @"表示一共有3张图表，1号图表有三条曲线，其名称分别为：voltage、current、power；2号图表有1条曲线，其名称为speed；3号图表有1条曲线，其名称为torque。";
            page3[7] = @"2.  设置参数初始化";
            page3[8] = @"&{参数数量}@{参数名称}…#{初始值}...";
            page3[9] = @"其中第二、三组参数数量应等于第一个参数。";
            page3[10] = @"如：";
            page3[11] = @"&3@P@I@D#1#0.5#0.2";
            page3[12] = @"表示一共有3个可设置的参数，其名称分别为P、I、D，初值为1、0.5、0.2。";
            page3[13] = @"3.  数据显示框初始化";
            page3[14] = @"&{数据数量}@{数据名称}...";
            page3[15] = @"如：";
            page3[16] = @"&2@Temp@Height";
            page3[17] = @"表示一共有2个需要显示在数据显示框内的数据，其名称分别为Temp、Height。";
            page3[18] = @"4.  控制指令初始化";
            page3[19] = @"&{指令数量}@{指令名称}...";
            page3[20] = @"如：";
            page3[21] = @"&2@Up@Down";
            page3[22] = @"表示一共有2条指令，其名称分别为Up、Down。";
            page3[23] = @"需要在所有数据最后附加上一个&，故最终得到的数据包为：";
            page3[24] = @"&3@3@1@1#voltage#current#power#speed#torque&3@P@I@D#1#0.5#0.2&2@Temp@Height&2@Up@Down&";
            page3[25] = @"注意：以上数据的顺序不可更改，否则会发生错误。";

            page4[0] = @"数据更新数据包表示此时需要更新的新数据，其格式如下：";
            page4[1] = @"!{数据分组}@{子分组号}#{数据}";
            page4[2] = @"其中数据分组0代表使用数据显示框显示的数据，数据分组1以后代表左侧图表组号。";
            page4[3] = @"如：";
            page4[4] = @"!1@1#23!1@2#15!1@3#2.4!2@1#980!3@1#-56.45!0@1#23.5";
            page4[5] = @"此数据包表示1号图表第1条曲线增加数据23，1号图表第2条曲线增加数据15，1号图表第3条曲线增加数据2.4，2号图表第1条曲线增加数据980，3号图表第1条曲线增加数据-56.45，第1个数据显示框中的数据更新为23.5";

            page5[0] = @"字符串数据包用于向上位机发送一些调试信息，其格式为：";
            page5[1] = @"${字符串}$";
            page5[2] = @"如：";
            page5[3] = @"$Program Begin$";
            page5[4] = @"此数据包代表发送字符串 Program Begin";

            page6[0] = @"上位机向下位机发送的数据包有以下几类：";
            page6[1] = @"1.初始化指令：发起初始化过程；";
            page6[2] = @"2.通信控制指令：控制下位机是否发送数据；";
            page6[3] = @"3.参数设置数据包：设置参数；";
            page6[4] = @"4.控制指令：控制指令。";

            page7[0] = @"初始化指令用于获取下位机提供的初始化数据，其内容如下:";
            page7[1] = @"&0";
            page7[2] = @"下位机收到此指令后应返回初始化设置数据包。";

            page8[0] = @"通信控制指令用于控制下位机是否发送新数据，共有两条指令：";
            page8[1] = @"1.  开始发送数据：";
            page8[2] = @"&1";
            page8[3] = @"2.  停止发送数据：";
            page8[4] = @"&2";
            page8[5] = @"下位机收到此指令后应开始或停止发送新数据至上位机。";

            page9[0] = @"参数设置数据包用于设置下位机的一些参数，本程序最多支持设置12个参数，基本格式为：";
            page9[1] = @"!{编号}#{数据}";
            page9[2] = @"如：";
            page9[3] = @"!1#2389!2#5.3!3#-7";
            page9[4] = @"此命令代表1号参数设置为2389，2号参数设置为5.3，3号参数设置为-7。";
            page9[5] = @"注意：数据以ASCII进行编码，下位机需用适当方法正确读取所需数据。";

            page10[0] = @"控制指令用于实现一些控制命令，如前进、后退等，其格式为：";
            page10[1] = @"&A";
            page10[2] = @"&B";
            page10[3] = @"&C";
            page10[4] = @"&D";
            page10[5] = @"......";
            page10[6] = @"程序内置控制指令最多有4条（即&A~&D），可通过发送自定义数据发送更多的控制指令。";

            textBox.Lines = page1;
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            switch(e.Node.Name)
            {
                case "Node1":
                    textBox.Lines = page1;
                break;

                case "Node2":
                    textBox.Lines = page2;
                break;

                case "Node3":
                    textBox.Lines = page3;
                break;

                case "Node4":
                    textBox.Lines = page4;
                break;

                case "Node5":
                    textBox.Lines = page5;
                break;

                case "Node6":
                    textBox.Lines = page6;
                break;

                case "Node7":
                    textBox.Lines = page7;
                break;

                case "Node8":
                    textBox.Lines = page8;
                break;

                case "Node9":
                    textBox.Lines = page9;
                break;

                case "Node10":
                    textBox.Lines = page10;
                break;

            }
        }
    }
}
