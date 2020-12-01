using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExtraEuroMilhoes
{
    class Aposta : FlowLayoutPanel
    {
        public float price { get; set; }
        public List<int> Principais { get; set; } = new List<int>();
        public List<int> Estrelas { get; set; } = new List<int>();

        public float calcularPreco()
        {
            price = 0;
            if(Principais.Count >= 5 && Estrelas.Count >= 2)
            {
                price = 2.50f;
            }
            return price;
        }
    }
}
