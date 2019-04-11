using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Moneda;

namespace Ejercicio23
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEuro_Click(object sender, EventArgs e)
        {
            double cantidad;
            if(double.TryParse(txtEuro.Text,out cantidad))
            {
                Euro euro1 = new Euro(cantidad);
                Euro euro2 = new Euro(0);
                Dolar dolar1 = new Dolar(0);
                Peso peso1 = new Peso(0);
                euro2 = (Euro)euro1;
                dolar1 = (Dolar)euro1;
                peso1 = (Peso)euro1;
                
           
                txtEuro2.Text = Convert.ToString(euro2.GetCantidad());
                txtEuro3.Text = Convert.ToString(dolar1.GetCantidad());
                txtEuro4.Text = Convert.ToString(peso1.GetCantidad());
            }
            
        }

        private void btnDolar_Click(object sender, EventArgs e)
        {
            double cantidad;
            if (double.TryParse(txtDolar.Text, out cantidad))
            {
                Dolar dolar1 = new Dolar(cantidad);
                Dolar dolar2 = new Dolar(0);
                Euro euro1 = new Euro(0);
                Peso peso1 = new Peso(0);
                dolar2 = (Dolar)dolar1;
                euro1 = (Euro)dolar1;
                peso1 = (Peso)dolar1;


                txtDolar2.Text = Convert.ToString(dolar2.GetCantidad());
                txtDolar3.Text = Convert.ToString(euro1.GetCantidad());
                txtDolar4.Text = Convert.ToString(peso1.GetCantidad());
            }
        }

        private void btnPeso_Click(object sender, EventArgs e)
        {
            double cantidad;
            if (double.TryParse(txtPeso.Text, out cantidad))
            {
                Peso peso1 = new Peso(cantidad);
                Peso peso2 = new Peso(0);
                Dolar dolar1 = new Dolar(0);
                Euro euro1 = new Euro(0);
                peso2 = (Peso)peso1;
                euro1 = (Euro)peso1;
                dolar1 = (Dolar)peso1;


                txtPeso2.Text = Convert.ToString(dolar1.GetCantidad());
                txtPeso3.Text = Convert.ToString(euro1.GetCantidad());
                txtPeso4.Text = Convert.ToString(peso2.GetCantidad());
            }
        }
    }
}
