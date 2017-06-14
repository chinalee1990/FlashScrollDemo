using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FlashScrollBar
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            flashNoAutoScroll1.m_Flash.Movie = Application.StartupPath + @"\ui\zc_zct.swf";
            flashNoAutoScroll1.m_Flash.ScaleMode = 2;
            flashNoAutoScroll1.SetFlashSize(1920,1080);
        }
    }
}
