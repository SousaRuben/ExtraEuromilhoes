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
using System.Text.Json;
using System.Text.Json.Serialization;
using System.IO;
using ExtraEuroMilhoes.models;


namespace ExtraEuroMilhoes
{
    public partial class Form1 : Form
    {
        private const string path = "../../data/file.json"; 
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

        private float calcularTotal()
        {
            total = 0;
            foreach (Aposta aposta in flowUp.Controls)
            {
                total += aposta.price;
            }
            displayTotal(total);

            return total;
        }

        private void calcularAposta(Aposta aposta)
        {
            float preco = aposta.calcularPreco();
            if (preco > 0) calcularTotal();
        }

        private void saveOnFile()
        {
            ReciboAposta recibo = new ReciboAposta();
            recibo.Total = calcularTotal();

            foreach (Aposta item in flowUp.Controls)
            {
                if(item.price != 0)
                {
                    ModelAposta aposta = new ModelAposta();

                    aposta.price = item.price;
                    aposta.Principais = item.Principais;
                    aposta.Estrelas = item.Estrelas;

                    recibo.Apostas.Add(aposta);
                }
            }

            var options = new JsonSerializerOptions
            {
                WriteIndented = true
            };
            
            string jsonString = JsonSerializer.Serialize(recibo, options);
            File.WriteAllText(path, jsonString);
        }

        private void BtnPrincipal_Click(object sender, EventArgs e)
        {
            EuroButton btn = sender as EuroButton;
            var Container = btn.Parent;
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
            saveOnFile();
        }
    }
}
