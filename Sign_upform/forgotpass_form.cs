using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Sign_upform
{
    public partial class forgotpass_form : Form
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
        public forgotpass_form()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Welcome_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label_email_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Kiểm tra điều kiện tối thiểu là 8 ký tự và hiển thị invalid_pass nếu không đạt
            if (textBox1.Text.Length < 8|| textBox1.Text.Length>24)
            {
                invalid_pass.Visible = true;
            }
            else
            {
                invalid_pass.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void forgotpass_form_Load(object sender, EventArgs e)
        {
            button1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, button1.Width,
         button1.Height, 12, 12)); // bo tròn khung login(panel)
            panel1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel1.Width,
         panel1.Height, 12, 12));
            invalid_pass.Visible = false;
        }

        private void invalid_pass_Click(object sender, EventArgs e)
        {

        }
    }
}
