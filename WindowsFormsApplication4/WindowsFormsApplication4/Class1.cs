using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    class box:CheckBox
    {
        int number;
        Boolean check = false;

        public box(int x,int y, int length, int width):base()
        {
            number = x + 1;
            this.Appearance = System.Windows.Forms.Appearance.Button;
            this.SetBounds(x*length, y, length, width);
            this.Text = "b";
            this.Name = "b";
            this.CheckedChanged += new System.EventHandler(this.CheckChanged);
            

        }

        private void CheckChanged(object sender, EventArgs e)
        {
            if (check)
            {
                check = false;
                this.Text = "b";
                this.BackColor = System.Drawing.Color.LightGray;
            }
            else
            {
                check = true;
                this.Text = ""+number;
                this.BackColor = System.Drawing.Color.LightGreen;
            }
           
        }

      
    }
}
