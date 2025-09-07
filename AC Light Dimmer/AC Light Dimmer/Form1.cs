using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace AC_Light_Dimmer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static SerialPort Dimmer_Control;
        string strTime;
        string strRead;


        private void Form1_Load(object sender, EventArgs e)
        {
            Con_Controller();
            if (textbox_Comm.Text != "No Connection")
            {
                Dimmer_Control.WriteLine("AA");
                strRead = Dimmer_Control.ReadLine();
            }
            groupbox_Con.Enabled = true;
            radiobutton_Incandescent.Checked = true;
        }


        private void button_Connect_Click(object sender, EventArgs e)
        {
            Con_Controller();
        }


        private void numeric_PowerOutput_ValueChanged(object sender, EventArgs e)
        {
            Set_Output();
            button_OnOff.Text = "OFF";
        }


        private void button_OnOff_Click(object sender, EventArgs e)
        {
            bool bPressed = false;

            if (button_OnOff.Text == "OFF")
            {
                Dimmer_Control.WriteLine("00");
                strRead = Dimmer_Control.ReadLine();
                textbox_Output.Text = "Device Stopped";
                button_OnOff.Text = "ON";
                bPressed = true;
            }

            if (button_OnOff.Text == "ON" && bPressed == false)
            {
                Set_Output();
                button_OnOff.Text = "OFF";
            }
        }



        private void radiobutton_Incandescent_CheckedChanged(object sender, EventArgs e)
        {
            Dimmer_Control.WriteLine("AA");
            strRead = Dimmer_Control.ReadLine();
            groupbox_Bulb.Text = "Bulb Type: " + strRead;
        }

        private void radiobutton_ACLED_CheckedChanged(object sender, EventArgs e)
        {
            Dimmer_Control.WriteLine("BB");
            strRead = Dimmer_Control.ReadLine();
            groupbox_Bulb.Text = "Bulb Type: " + strRead;
        }

        private void radiobutton_DCLED_CheckedChanged(object sender, EventArgs e)
        {
            Dimmer_Control.WriteLine("CC");
            strRead = Dimmer_Control.ReadLine();
            groupbox_Bulb.Text = "Bulb Type: " + strRead;
        }

        /**************************************************************************************************************
         *                                        FUNCTIONS AND ROUTINES
         ************************************************************************************************************** */

        private void Con_Controller() // SEARCH SERIAL PORTS FOR A CONNECTED CONTROLLER
        {
            string strReceive = null;
            string strCom = null;
            string[] iController = new string[10];

            int  iPort = 0;
            bool bCanRead = true;
            bool bFound = false;

            iPort = 0;
            foreach (string s in SerialPort.GetPortNames())
            {
                textbox_Comm.Text = textbox_Comm.Text + s + "\r\n";
                iController[iPort] = s;
                iPort++;
            }
            iController[iPort] = "END";
            Dimmer_Control = new SerialPort();


            iPort = 0;
            bCanRead = true;
            while (iController[iPort] != "END" && iPort < 9)
            {
                Dimmer_Control.BaudRate = 9600;
                Dimmer_Control.ReadTimeout = 1000;
                Dimmer_Control.PortName = iController[iPort];
                Dimmer_Control.Open();
                Dimmer_Control.WriteLine("DM");

                try { strReceive = Dimmer_Control.ReadLine(); }

                catch (TimeoutException)
                {
                    Dimmer_Control.Close();
                    bCanRead = false;

                    if (bFound == false)
                    {
                        textbox_Comm.Text = "No Connection";
                    }
                }


                if (bCanRead == true)
                {
                    strReceive = "";
                    textbox_Comm.Text = "Comm on Port " + iController[iPort];
                    strCom = iController[iPort];
                    Dimmer_Control.Close();
                    bFound = true;
                    groupbox_Bulb.Enabled = true;
                    groupbox_Data.Enabled = true;
                }
                iPort++;
            }// END WHILE(0)

            if (strCom != null)
            {
                Dimmer_Control.PortName = strCom;
                Dimmer_Control.Open();
                textbox_Comm.Text = "PORT: " + strCom;
            }

            if (strCom == null)
            {
                textbox_Comm.Text = "No Connection";
            }
        }


        private void Set_Output()
        {
            textbox_Output.Text = "";

            if (numeric_PowerOutput.Value < 10)             { strTime = "0" + Convert.ToString(numeric_PowerOutput.Value); }
            if (numeric_PowerOutput.Value > 9)              { strTime = Convert.ToString(numeric_PowerOutput.Value); }
            if (numeric_PowerOutput.Value == 100)           { strTime = "II"; }

            textbox_Output.Text = "Power Level: " + strTime + "\r\n";
            Dimmer_Control.WriteLine(strTime);
            strRead = Dimmer_Control.ReadLine();
            textbox_Output.Text = textbox_Output.Text + strRead + " u sec.";
            strRead = Dimmer_Control.ReadLine();
            textbox_Output.Text = textbox_Output.Text + "\r\n" + strRead + " u sec.";
        }

        
    }
}
