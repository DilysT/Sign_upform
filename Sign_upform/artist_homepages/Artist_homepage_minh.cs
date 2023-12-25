using System;
using System.Windows.Forms;

namespace Sign_upform.artist_homepages
{
    public partial class Artist_homepage_minh : Form
    {
        private const int ScrollThreshold = 1;
        private int lastScrollValue = 0;

        public Artist_homepage_minh()
        {
            InitializeComponent();
            // Thêm sự kiện Scroll cho thanh cuộn (scroll bar) của panel2
            panel2.Scroll += panel2_Scroll;
        }
        private void panel2_Scroll(object sender, ScrollEventArgs e)
        {
            // Xử lý sự kiện Scroll
            if (Math.Abs(e.NewValue - lastScrollValue) > ScrollThreshold)
            {
                if (e.NewValue > lastScrollValue)
                {
                    // Kéo xuống dưới
                    avatar_panel.Visible = false;
                }
                else
                {
                    // Kéo lên trên
                    avatar_panel.Visible = true;
                }

                lastScrollValue = e.NewValue;
            }
        }



        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void avatar_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {

        }
    }
}
