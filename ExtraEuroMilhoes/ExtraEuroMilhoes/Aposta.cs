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
        private float price = 0;
        public List<int> Principais { get; set; } = new List<int>();
        public List<int> Estrelas { get; set; } = new List<int>();
    }
}
