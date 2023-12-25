using Guna.UI2.WinForms.Suite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sign_upform
{
    public partial class homepage_fan : Form
    {
        public homepage_fan()
        {
            InitializeComponent();
            Load += homepage_fan_Load;
            play_bar.Visible = false;
        }
        private void homepage_fan_Click(object sender, EventArgs e)
        {

        }
        private void panel2_Click(object sender, EventArgs e)
        {
        }
        private void homepage_fan_Load(object sender, EventArgs e)
        {
            // Gán sự kiện click cho form
            Click += homepage_fan_Click;
            foreach (Control control in panel2.Controls)
            {
                control.Click += panel2_Click;
            }
        }
        
       

        private void play_bar_Paint(object sender, PaintEventArgs e)
        {

        }
        int flag = 1;
        private void heart_active_Click_1(object sender, EventArgs e)
        {

            flag *= -1;
            if (flag == -1)
            {//liên kết đến kho ảnh trong máy(cần phải tải về trước)
                Bitmap b = new Bitmap(@"C:\Users\PC\Downloads\heart.PNG");
                heart_active.Image = b; // gọi lại biến để xuất ảnh
            }
            else
            {
                Bitmap c = new Bitmap(@"C:\Users\PC\Downloads\Frame 517.PNG");
                heart_active.Image = c;
            }
        }
        
        private void transfer_images_Click(object sender, EventArgs e)
        {

        }
       
      
     
        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

       
        int flags = 1;
        private void Play_button_Click(object sender, EventArgs e)
        {

            flags *= -1;
            if (flags == -1)
            {//liên kết đến kho ảnh trong máy(cần phải tải về trước)
                Bitmap b = new Bitmap(@"C:\Users\PC\OneDrive - Trường ĐH CNTT - University of Information Technology\Project CNPM-webapp\Homepage-pic\Pause.png");
                Play_button.Image = b; // gọi lại biến để xuất ảnh
            }
            else
            {
                Bitmap c = new Bitmap(@"C:\Users\PC\OneDrive - Trường ĐH CNTT - University of Information Technology\Project CNPM-webapp\Homepage-pic\angle-left 3.png");
                Play_button.Image = c;
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
