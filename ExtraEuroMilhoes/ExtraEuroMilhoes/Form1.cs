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
        public Form1()
        {
            InitializeComponent();
            InitializeContainers();

            displayTotal();
        }

        private void displayTotal()
        {
            lblValor.Text = "Valor total da aposta: 0";
        }

        private void BtnPrincipal_Click(object sender, EventArgs e)
        {
            EuroButton btn = sender as EuroButton;
            btn.Selected = !btn.Selected;
            var Container = btn.Parent.Parent;
            Debug.WriteLine($"Click {btn.Name} inside {Container.Name}");
        }

        private void BtnEstrela_Click(object sender, EventArgs e)
        {
            EuroButton btn = sender as EuroButton;
            btn.Selected = !btn.Selected;
            var Container = btn.Parent.Parent;
            Debug.WriteLine($"Click {btn.Name} inside {Container.Name}");
        }
    }
}
