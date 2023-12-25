using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Sign_upform
{
    public partial class Artist_homepage : Form
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

        public Artist_homepage()
        {
            InitializeComponent();
            Load += Artist_homepage_Load;
            play_bar.Visible = false;
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {

        }

        private void transfer_images_Click(object sender, EventArgs e)
        {

        }
        int flag = -1;
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

        int flags = 1;
        private void pictureBox39_Click(object sender, EventArgs e)
        {
            flags *= -1;
            if (flags == -1)
            {//liên kết đến kho ảnh trong máy(cần phải tải về trước)
                Bitmap b = new Bitmap(@"C:\Users\PC\OneDrive - Trường ĐH CNTT - University of Information Technology\Project CNPM-webapp\Homepage-pic\angle-left 3.png");
                pictureBox39.Image = b; // gọi lại biến để xuất ảnh
            }
            else
            {
                Bitmap c = new Bitmap(@"C:\Users\PC\OneDrive - Trường ĐH CNTT - University of Information Technology\Project CNPM-webapp\Homepage-pic\Pause.png");
               pictureBox39.Image = c;
            }
        }

        private void play_bar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
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
        private void Artist_homepage_Click(object sender, EventArgs e)
        {

        }

        private void Artist_homepage_Load(object sender, EventArgs e)
        {
            guna2TrackBar1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, guna2TrackBar1.Width,
     guna2TrackBar1.Height, 5, 5));
            pictureBox5.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pictureBox5.Width,
    pictureBox5.Height, 12, 12));
           
            // Gán sự kiện click cho form
            Click += Artist_homepage_Click;
            foreach (Control control in panel2.Controls)
            {
                control.Click += panel2_Click;
            }
        } 

        private void guna2GradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2TrackBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        
    }
}
