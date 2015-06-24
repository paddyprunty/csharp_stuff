using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public class course_item
    {
        public box[] cb;
        Label date=new Label();
        Label price=new Label();
        int framewidth;
        

        public course_item( int y, int length, int width)
        {
            cb = new box[12];
            for (int i = 0; i < cb.Length; i++)
            {
                cb[i] = new box(i, y, length, width);

            }
            date.Text = "20/09/15";
            date.Location = new System.Drawing.Point(cb.Length * length,y*length+ length / 2);
            price.Text = "€599";
            price.Location = new System.Drawing.Point((cb.Length * length) +50,(y*length)+ length/2);
            

        }

        public box[] getBox()
        {
            return cb;
        }
        public Label getDate()
        {
            return date;
        }

        public Label getPrice()
        {
            return price;
        }

    }
}
