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
    public partial class homepage : Form
    {
       
        public homepage()
        {
            InitializeComponent();
            Load += homepage_Load;
            play_bar.Visible = false;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
           
        }
     
        private void homepage_Click(object sender, EventArgs e)
        {
           
        }
        private void panel2_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem control được click có tag là "blocks" hay không
            if (sender is Control control && control.Tag != null && control.Tag.ToString() == "blocks")
            {
                disable_bar.Visible = false;
                play_bar.Visible = true;
                // Kiểm tra xem control là PictureBox hay không
                if (control is PictureBox pictureBox)
                {
                    // Hiển thị hình ảnh của PictureBox được click trong transfer_image
                    // chuyển dữ liệu đồng bộ giữa các picturebox trong 1 form
                    transfer_images.Image = pictureBox.Image;
                }
                  
            }

        }
        private void homepage_Load(object sender, EventArgs e)
        {
            // Gán sự kiện click cho form
            Click += homepage_Click;
            foreach (Control control in panel2.Controls)
            {
                control.Click += panel2_Click;
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
        private void pictureBox11_Click(object sender, EventArgs e)
        {


        }
        private void disable_bar_Click(object sender, EventArgs e)
        {
        }
        int flag = 1;
        private void heart_active_Click(object sender, EventArgs e)
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

        private void play_bar_Paint(object sender, PaintEventArgs e)
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

        private void transfer_images_Click(object sender, EventArgs e)
        {

        }

        private void guna2TrackBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

    }
}
