﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Sign_upform
{

    public partial class Login : Form
    {

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
            (
               int nLeftRect,
               int nTopRect,
               int nRightRect,
               int nBottomRect,
               int nWidthEllipse,
               int nHeightEllipse
            );


        public Login()
        {
            InitializeComponent();

        }

        private void Login_Load(object sender, EventArgs e)
        {
            panel1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel1.Width,
           panel1.Height, 12, 12)); // bo tròn khung login(panel)
            button1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, button1.Width,
           button1.Height, 15, 15));
            invalid_pass.Visible = false;
        }

   
       
       

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

        }

        private void label_email_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Kiểm tra điều kiện tối thiểu là 8 ký tự và hiển thị invalid_pass nếu không đạt
            if (textBox1.Text.Length < 8 || textBox1.Text.Length > 24)
            {
                invalid_pass.Visible = true;
            }
            else
            {
                invalid_pass.Visible = false;
            }
    }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void label6_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

            // The password character is an asterisk.
            textBox2.PasswordChar = '*';
            // The control will allow no more than 14 characters.
            textBox2.MaxLength = 25;
            // Kiểm tra điều kiện tối thiểu là 8 ký tự và hiển thị invalid_pass nếu không đạt
            if (textBox2.Text.Length < 8 || textBox2.Text.Length > 24)
            {
                invalid_pass.Visible = true;
            }
            else
            {
                invalid_pass.Visible = false;
            }
    }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void Welcome_Click(object sender, EventArgs e)
        {

        }

        private void invalid_pass_Click(object sender, EventArgs e)
        {

        }
    }
}
