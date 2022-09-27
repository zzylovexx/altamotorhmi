using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Timers;

using EtherCAT_DLL;
using EtherCAT_DLL_Err;

namespace EtherCat
{
    public partial class Form1 : Form
    {
        ushort cardnum;
        public static ushort cardno;
        ushort checkvariable;
        public static string staticerr, fstatusword;
        ushort slaveNum;
        public int count = 0;


        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            sidepanel.Top = button1.Top;
            
            csppanel1.Hide();
            mutiMotorCT1.Hide();
            hprPanel1.Hide();
            groupBox2.BringToFront();
            


        }

        private void button2_Click(object sender, EventArgs e)
        {
            sidepanel.Top = button2.Top;
            csppanel1.Show();
            mutiMotorCT1.Hide();
            hprPanel1.Hide();
            csppanel1.BringToFront();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            checkvariable = CEtherCAT_DLL.CS_ECAT_Master_Open(ref cardnum);
            if (checkvariable != CEtherCAT_DLL_Err.ERR_ECAT_NO_ERROR)
                staticerr = "find card has error";
            else if (cardnum == 0)
            {
                staticerr = "no card be found";
            }
            else
            {
                textBox8.Text = cardnum.ToString();
                button5.Enabled = true;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            checkvariable = CEtherCAT_DLL.CS_ECAT_Master_Get_CardSeq(0, ref cardno);
            checkvariable = CEtherCAT_DLL.CS_ECAT_Master_Initial(cardno);
            if (checkvariable != CEtherCAT_DLL_Err.ERR_ECAT_NO_ERROR)
            {
                staticerr = "initial card has erroe";
            }
            else
            {
                textBox9.Text = "initial done";
                button6.Enabled = true;
                button6.Text = "Find slave";
                fstatusword = "initial done";
            }
        }

        private void  timer1_Tick(object sender, EventArgs e)
        {
            checkmotor();
            ushort ret;
            int speed = 0, pos = 0;
            ushort statusword = 0;
            byte umode = 0;
            int modepositio = 0;
            

            
            
                ret = CEtherCAT_DLL.CS_ECAT_Slave_Motion_Get_Current_Speed(cardno, Motor.Driver[now_motor], Motor.motor[now_motor], ref speed);
                currentspeedtext.Text = speed.ToString();
                

                ret = CEtherCAT_DLL.CS_ECAT_Slave_Motion_Get_StatusWord(cardno, Motor.Driver[now_motor], Motor.motor[now_motor], ref statusword);
                statuswordtext.Text = statusword.ToString();

                ret = CEtherCAT_DLL.CS_ECAT_Slave_Motion_Get_MoveMode(cardno, Motor.Driver[now_motor], Motor.motor[now_motor], ref umode);
                motiontext.Text = umode.ToString();

                ret = CEtherCAT_DLL.CS_ECAT_Slave_Motion_Get_Command(cardno, Motor.Driver[now_motor], Motor.motor[now_motor], ref modepositio);
                textBox2.Text = modepositio.ToString();
                ret = CEtherCAT_DLL.CS_ECAT_Slave_Motion_Get_Position(cardno, Motor.Driver[now_motor], Motor.motor[now_motor], ref pos);
                textBox3.Text = pos.ToString();
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            mutiMotorCT1.Show();
            hprPanel1.Hide();
            csppanel1.Hide();
            mutiMotorCT1.BringToFront();
            sidepanel.Top = button3.Top;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int count=0;
            count++;
            if (count % 2 == 1)
            {
                timer1.Enabled = true;
                button7.Text = "Close timer";
            }
            else
            {
                timer1.Enabled = false;
                button7.Text = "Open timer";
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            comboBox1.SelectedIndex = 0;
            hprPanel1.Hide();
            csppanel1.Hide();
            mutiMotorCT1.Hide();
            
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        public int now_motor;
        public void checkmotor()
        {
            now_motor = comboBox1.SelectedIndex;
            


        }

        private void button8_Click(object sender, EventArgs e)
        {
            sidepanel.Top = button8.Top;
            csppanel1.Hide();
            mutiMotorCT1.Hide();
            hprPanel1.Show();
            hprPanel1.BringToFront();
        }

        

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void 按鈕ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //colorDialog1.ShowDialog();
            if (colorDialog1.ShowDialog() ==DialogResult.OK)
             button1.BackColor = button2.BackColor = button3.BackColor = button8.BackColor = colorDialog1.Color;
        }

        private void 背景ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            //colorDialog2.ShowDialog();
            if (colorDialog2.ShowDialog() == DialogResult.OK)
            this.BackColor = colorDialog2.Color;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            checkvariable = CEtherCAT_DLL.CS_ECAT_Master_Get_SlaveNum(cardno, ref slaveNum);
            if (checkvariable != CEtherCAT_DLL_Err.ERR_ECAT_NO_ERROR)
            {
                staticerr = "get slavenum got wrong";

            }
            else
            {
                textBox10.Text = slaveNum.ToString();
                fstatusword = "get slavenum";

            }
        }

        private Form activeform = null;

        private void button7_Click_1(object sender, EventArgs e)
        {
            
            count++;
            if (count % 2 != 0)
            {
                timer1.Start();

            }
            else if (count%2 == 0)
            {
                timer1.Stop();
            }
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void openchildform(Form childform)
        {
            if (activeform != null)
                activeform.Close();
            activeform = childform;
            childform.TopLevel = false;
            childform.FormBorderStyle = FormBorderStyle.None;
            statuspanel.Controls.Add(childform);
            statuspanel.Tag = childform;

            childform.BringToFront();
            childform.Show();


        }

      



    }
}
