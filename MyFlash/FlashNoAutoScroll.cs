using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MyFlash
{
    public partial class FlashNoAutoScroll: UserControl
    {
        public FlashNoAutoScroll()
        {
            InitializeComponent();
            hScrollBar1.Minimum = 0;
            vScrollBar1.Minimum = 0;
            SetScrollBar_H();
            SetScrollBar_V();
        }

        public void SetFlashSize(int nWidth,int nHeight)
        {
            m_Flash.Width = nWidth;
            m_Flash.Height = nHeight;
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            //Flash水平滚动
            if (hScrollBar1.Value < 0)
                return;
            m_Flash.Location = new Point(-hScrollBar1.Value, m_Flash.Location.Y);
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            //Flash垂直滚动
            if (vScrollBar1.Value < 0)
                return;
            m_Flash.Location = new Point(m_Flash.Location.X, -vScrollBar1.Value);
        }


        private void m_Flash_SizeChanged(object sender, EventArgs e)
        {
            SetScrollBar_H();
            SetScrollBar_V();
        }

        private void hScrollBar1_SizeChanged(object sender, EventArgs e)
        {
            //SetScrollBar_H();
        }

        private void vScrollBar1_SizeChanged(object sender, EventArgs e)
        {
            //SetScrollBar_V();
        }

        void SetScrollBar_H()
        {
            hScrollBar1.Maximum = m_Flash.Width - hScrollBar1.Width;
        }

        void SetScrollBar_V()
        {
            vScrollBar1.Maximum = m_Flash.Height - vScrollBar1.Height;
        }



    }
}
