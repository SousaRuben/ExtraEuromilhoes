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
        public bool isMultipla { get; set; } = false;
        public float price { get; set; }
        public List<int> Principais { get; set; }
        public List<int> Estrelas { get; set; }

        public Aposta()
        {
            Principais = new List<int>();
            Estrelas = new List<int>();
        }

        public float calcularPreco()
        {
            price = 0;
            if (Principais.Count < 5 || Estrelas.Count < 2)
            {
                return price;
            }

            if(Principais.Count == 5 && Estrelas.Count == 2)
            {
                isMultipla = false;
                return price = 2.50f;
            }

            return price;
        }
    }
}
