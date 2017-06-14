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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            Form2 form = new Form2();
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Show(this);
        }

        private void axShockwaveFlash1_Enter(object sender, EventArgs e)
        {
            Console.WriteLine("Flash Mouse Enter");
        }

        private void panel1_Enter(object sender, EventArgs e)
        {
            Console.WriteLine("Panel Mouse Enter");

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Console.WriteLine("Form Paint");

        }
    }
}
