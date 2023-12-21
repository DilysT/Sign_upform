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
    public partial class Signup : Form
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
        public Signup()
        {
            InitializeComponent();
            this.Load += Signup_Load;
        }
        private void Signup_Load(object sender, EventArgs e)
        {
            panel1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel1.Width,
           panel1.Height, 12, 12)); // bo tròn khung login(panel)
            button1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, button1.Width,
           button1.Height, 15, 15));
            invalid_pass.Visible = false;

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
         //box điền text email
    }
        private void textBox2_TextChanged(object sender, EventArgs e)//điền chữ trong khung pass
        {

            // The password character is an asterisk.
            textBox2.PasswordChar = '*';
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
        private void textBox3_TextChanged(object sender, EventArgs e)//điền chữ trong khung pass
        {


            // The password character is an asterisk.
            textBox3.PasswordChar = '*';
            // Kiểm tra điều kiện tối thiểu là 8 ký tự và hiển thị invalid_pass nếu không đạt
            if (textBox3.Text.Length < 8 || textBox3.Text.Length > 24)
            {
                invalid_pass.Visible = true;
            }
            else
            {
                invalid_pass.Visible = false;
            }
        
    }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void Welcome_Click(object sender, EventArgs e)
        {
            // header sign-up
        }

        private void label_email_Click(object sender, EventArgs e)
        {
            //tựa đề email
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //khung hình chữ email
        }

        private void label3_Click(object sender, EventArgs e)
        {
            //label pass
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            // khung pass
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            //hình i accept term_condition
        }

      

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) ||
         string.IsNullOrWhiteSpace(textBox2.Text) ||
         string.IsNullOrWhiteSpace(textBox3.Text) ||
         textBox2.Text != textBox3.Text)
            {
                invalid_pass.Visible = true;
            }
            // Kiểm tra sự khác biệt giữa mật khẩu trong textBox2 và textBox3
            // Nếu mật khẩu không khớp, hiển thị PictureBox invalid_pass
            if (textBox1.Text.Length < 8 || textBox1.Text.Length > 24|| textBox2.Text.Length < 8 || textBox2.Text.Length > 24|| textBox3.Text.Length < 8 || textBox3.Text.Length > 24)
            {
                invalid_pass.Visible = true;
            }
            else
            {
                Form formBackground = new Form();
                try
                {
                    using (Form2 uu = new Form2())
                    {
                        formBackground.StartPosition = FormStartPosition.Manual;
                        formBackground.FormBorderStyle = FormBorderStyle.None;
                        formBackground.Opacity = .5d;
                        formBackground.BackColor = Color.Black;
                        formBackground.WindowState = FormWindowState.Maximized;
                        formBackground.TopMost = true;
                        formBackground.Location = this.Location;
                        formBackground.ShowInTaskbar = false;
                        formBackground.Show();

                        uu.Owner = formBackground;

                        // Center Form2 on the screen
                        uu.StartPosition = FormStartPosition.CenterParent;

                        uu.ShowDialog();

                        formBackground.Dispose();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    formBackground.Dispose();
                }//nút sign_up 
                invalid_pass.Visible=false;
            }
            }
           
    

        private void label4_Click(object sender, EventArgs e)
        {
            //chữ don't have account
        }

    

   
        int flag = 1;
        private void button2_Click(object sender, EventArgs e) // tạo ô tick bằng thêm hiệu ứng chuyển cảnh
        {
            flag *= -1;
            if (flag == -1)
            {//liên kết đến kho ảnh trong máy(cần phải tải về trước)
                Bitmap b = new Bitmap(@"C:\Users\PC\OneDrive - Trường ĐH CNTT - University of Information Technology\Project CNPM-webapp\login\CNPM pic\tick_icon.JPG");
                button2.Image = b; // gọi lại biến để xuất ảnh
            }
            else
            {
                Bitmap c = new Bitmap(@"C:\Users\PC\OneDrive - Trường ĐH CNTT - University of Information Technology\Project CNPM-webapp\login\CNPM pic\khung_tick.JPG");
                button2.Image = c;
            }
        }

       
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void Signup_Load_1(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void invalid_pass_Click(object sender, EventArgs e)
        {
            
        }
    }
}
