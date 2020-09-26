using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLyHocSinhTHPT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            if(txt_Username.Text=="Admin" && txt_Password.Text=="123456")
            {
                txt_Err.Visible = false;
                Form2 f2 = new Form2();
                f2.Visible = true;
            }    
            else
            {
                txt_Err.Visible = true;
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void txt_Username_Leave(object sender, EventArgs e)
        {
            if(txt_Username.Text=="")
            {
                txt_Username.Text = "Enter Username";
            }
        }

        private void txt_Password_Leave(object sender, EventArgs e)
        {
            if (txt_Password.Text == "")
            {
                txt_Password.Text = "Enter Password";
                txt_Password.PasswordChar = (char)0;
            }
            else txt_Password.PasswordChar = '*';
        }

        private void txt_Password_Enter(object sender, EventArgs e)
        {
            if(txt_Password.Text=="Enter Password")
            {
                txt_Password.Text = "";
                txt_Password.PasswordChar = '*';
            }
        }

        private void txt_Username_Enter(object sender, EventArgs e)
        {
            if(txt_Username.Text=="Enter Username")
            {
                txt_Username.Text = "";
            }
        }

        private void btn_Eye_0_Click(object sender, EventArgs e)
        {
            txt_Password.PasswordChar = (char)0;
            btn_Eye_0.Visible = false;
            btn_Eye.Visible = true;
        }

        private void btn_Eye_Click(object sender, EventArgs e)
        {
            txt_Password.PasswordChar = '*';
            btn_Eye.Visible = false;
            btn_Eye_0.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
