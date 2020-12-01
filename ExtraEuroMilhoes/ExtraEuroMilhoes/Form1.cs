using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace ExtraEuroMilhoes
{
    public partial class Form1 : Form
    {
        public float total = 0;
        public Form1()
        {
            InitializeComponent();
            InitializeContainers();

            displayTotal();
        }

        private void displayTotal(float value = 0)
        {
            lblValor.Text = $"Valor total da aposta: {value}";
        }

        private void calcularTotal()
        {
            total = 0;
            foreach (Aposta aposta in flowUp.Controls)
            {
                total += aposta.price;
            }
            displayTotal(total);
        }

        private void calcularAposta(Aposta aposta)
        {
            float preco = aposta.calcularPreco();
            if (preco > 0) calcularTotal();
        }

        private void BtnPrincipal_Click(object sender, EventArgs e)
        {
            EuroButton btn = sender as EuroButton;
            Principais Container = (Principais) btn.Parent;
            Aposta aposta = (Aposta)Container.Parent;

            int value;
            int.TryParse(btn.Text, out value);
            btn.Selected = !btn.Selected;

            if (btn.Selected) aposta.Principais.Add(value); 
            else aposta.Principais.Remove(value);

            calcularAposta(aposta);
        }

        private void BtnEstrela_Click(object sender, EventArgs e)
        {
            EuroButton btn = sender as EuroButton;
            var Container = btn.Parent;
            Aposta aposta = (Aposta)Container.Parent;

            int value;
            int.TryParse(btn.Text, out value);
            btn.Selected = !btn.Selected;

            if (btn.Selected) aposta.Estrelas.Add(value);
            else aposta.Estrelas.Remove(value);

            calcularAposta(aposta);
        }

        private void btnApostar_Click(object sender, EventArgs e)
        {
            foreach (Aposta item in flowUp.Controls)
            {
                Debug.WriteLine($"{item.Principais.Count} - {item.Estrelas.Count}");
            }
        }
    }
}
