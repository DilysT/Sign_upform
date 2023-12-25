using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sign_upform.Music_toppick
{
    public partial class Toppick : UserControl
    {
        public Toppick()
        {
            InitializeComponent();
            guna2Panel2.Hide(); 
           
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

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        int flagHeartActive = 1;
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            flagHeartActive *= -1;
            if (flagHeartActive == -1)
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
    }
}
