using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {
        
        int length = 10;
        box[] b;
        Label date;
        Label price;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            b = new box[length];
            for (int i = 0; i < length; i++)
            {
                b[i] = new box(i, 1, 50, 40);
                this.Controls.Add(b[i]);
            }
            date.Text = "20/09/15";
            date.Location = new System.Drawing.Point(193, 10);
            price.Text = "€599";
            price.Location = new System.Drawing.Point(220, 10);
                
        }

        public Button addButton(int x, int y, int length, int width)
        {
            Button b2 = new Button();
            b2.SetBounds(x * length, y * width, length, width);
            b2.Text = "b";
            this.Controls.Add(b2);
            return b2;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void b_Click(object sender, EventArgs e)
        {
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

       
    }
}
