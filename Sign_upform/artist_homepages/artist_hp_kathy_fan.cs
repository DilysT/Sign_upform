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
    public partial class artist_hp_kathy_fan : Form
    {
        private const int ScrollThreshold = 1;
        private int lastScrollValue = 0;
        public artist_hp_kathy_fan()
        {
            InitializeComponent();
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

        private void avatar_panel_Paint(object sender, PaintEventArgs e)
        {
           
        }
    }
}
