using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtraEuroMilhoes.models
{
    class ReciboAposta
    {
        public float Total { set; get; } 
        public DateTime Data { set; get; }
        public List<ModelAposta> Apostas { set; get; } 

        public ReciboAposta()
        {
            Total = 0;
            Data = DateTime.Now;
            Apostas = new List<ModelAposta>();
        }
    }
}
