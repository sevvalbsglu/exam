using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace şevvalbaşoğlu220715047
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            UpdateBackgroundColor();
        }
        private void UpdateBackgroundColor()
        {
            int red = trackBar1.Value;
            int green = vScrollBar1.Value;
            int blue = hScrollBar1.Value;
            this.BackColor = Color.FromArgb(red, green, blue);
            label1.Text = $"Current Color: RGB({red},{green},{blue})";
        }
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            UpdateBackgroundColor();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            UpdateBackgroundColor();
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            UpdateBackgroundColor();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
