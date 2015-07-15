using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using רואה_חד;

namespace רואה_חד_IDE
{
    public partial class Form1 : Form
    {

        CS_Executer prog = new CS_Executer();
        public Form1()
        {
            InitializeComponent();
            MainOnly.Checked = true;
        }

        private void CodeTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Compile_Click(object sender, EventArgs e)
        {
            if (AllCS.Checked)
            {
                if (Namespace.Text != "")
                {
                    if (Class.Text != "")
                    {
                        prog.Run(CodeTextBox.Text, Namespace.Text, Class.Text);
                    }
                    else
                    {
                        MessageBox.Show("הכנס מחלקה");
                    }
                }
                else
                {
                    MessageBox.Show("הכנס שם");
                }
            }
            else if(MainOnly.Checked)
            {
                        prog.RunFunc(CodeTextBox.Text);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void LtoR_CheckedChanged(object sender, EventArgs e)
        {
            if(LtoR.Checked)
            CodeTextBox.RightToLeft = RightToLeft.No;
            else
                CodeTextBox.RightToLeft = RightToLeft.Yes;
        }
    }
}
