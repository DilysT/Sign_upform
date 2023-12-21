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
    public partial class Toppicks : Form
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
        int flagPictureBox6 = 1;  // Separate flag for pictureBox6
        int flagHeartActive = 1; // Separate flag for heart_active
        public Toppicks()
        {
            InitializeComponent();
            Load += Toppicks_Load;
            play_bar.Visible = false;
            guna2Panel2.Hide();
        }
        private void Toppicks_Click(object sender, EventArgs e)
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
                else if (control is Button button)
                { 
                    transfer_images.Image = button.BackgroundImage;
                }

            }

        }
        private void Toppicks_Load(object sender, EventArgs e)
        {
            guna2TrackBar1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, guna2TrackBar1.Width,
     guna2TrackBar1.Height, 5, 5));
            pictureBox5.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pictureBox5.Width,
   pictureBox5.Height, 8, 8));
            linkicon.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, linkicon.Width,
  linkicon.Height, 10, 5));

            // Gán sự kiện click cho form
            Click += Toppicks_Click;
            foreach (Control control in panel2.Controls)
            {
                control.Click += panel2_Click;
            }

            avatar_button.Click += panel2_Click;
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

       
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {
            // khung share
        }
        private void pictureBox7_Click(object sender, EventArgs e)
        {
            // Kiểm tra trạng thái hiện tại của guna2Panel2
            if (guna2Panel2.Visible)
            {
                guna2Panel2.Hide(); // Nếu đang hiển thị thì ẩn đi
            }
            else
            {
                guna2Panel2.Show(); // Nếu đang ẩn thì hiển thị
            }
        }
        private void heart_active_Click(object sender, EventArgs e)
        {


            flagHeartActive *= -1;
            if (flagHeartActive == -1)
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
        private void pictureBox6_Click(object sender, EventArgs e)
        {

                flagPictureBox6 *= -1;
                if (flagPictureBox6 == -1)
                {//liên kết đến kho ảnh trong máy(cần phải tải về trước)
                    Bitmap b = new Bitmap(@"C:\Users\PC\Downloads\heart.PNG");
                   pictureBox6.Image = b; // gọi lại biến để xuất ảnh
                }
                else
                {
                    Bitmap c = new Bitmap(@"C:\Users\PC\Downloads\Frame 517.PNG");
                    pictureBox6.Image = c;
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

        private void avatar_button_Click(object sender, EventArgs e)
        {

        }
        private void guna2Button3_Click_1(object sender, EventArgs e)
        {

        }

    }
}
