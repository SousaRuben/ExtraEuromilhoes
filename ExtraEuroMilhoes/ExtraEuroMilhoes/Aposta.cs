using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExtraEuroMilhoes
{
    class Aposta : TableLayoutPanel
    {
        private int count = 0;
        private float price = 0;

        public float Price
        {
            get
            {
                price = (float)(count * 0.50);
                return price;
            }
            set
            {
                price = value;
            }
        }

        public int Count 
        { 
            get 
            {
                count = 0;
                foreach (EuroButton button in this.Controls) 
                {
                    if (button.Selected) count++;
                }
                return count; 
            }
            set
            {
                count = value;
            }
        }

    }
}
