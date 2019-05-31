using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CentralitaHerencia;

namespace CentralForm
{
    public partial class FrmLlamador : Form
    {
        public FrmLlamador()
        {
            InitializeComponent();
        }
        public Centralita centralita;
        public FrmLlamador(Centralita centralita) : this()
        {
            this.centralita = centralita;
            cmbFranja.DataSource = Enum.GetValues(typeof(Provincial.Franja));
            // Lectura
            Provincial.Franja franjas;
            Enum.TryParse<Provincial.Franja>(cmbFranja.SelectedValue.ToString(), out franjas);
        }

        public Centralita Centralita
        {
            get { return centralita; }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNroDestino.ResetText();
            txtNroOrigen.ResetText();
        }

        private void btnLlamar_Click(object sender, EventArgs e)
        {
            string nroDestino = txtNroDestino.Text;
            string nroOrigen = txtNroOrigen.Text;
            Random random = new Random();

            if(txtNroDestino.Text != "" || txtNroDestino.Text[0] != '*')
            {
                if(txtNroDestino.Text[0] == '#')
                {
                    float duracion = (float)random.Next(1,50);
                    Provincial.Franja miFranja = Provincial.Franja.Franja_1;
                    switch (cmbFranja.Text)
                    {
                        case "Franja_1":
                            miFranja = Provincial.Franja.Franja_1;
                        break;
                        case "Franja_2":
                            miFranja = Provincial.Franja.Franja_2;
                        break;
                        case "Franja_3":
                            miFranja = Provincial.Franja.Franja_3;
                        break;
                    }
                    
                    Provincial nuevaProvincial = new Provincial(txtNroOrigen.Text, miFranja , duracion, txtNroDestino.Text);
                    System.Threading.Thread.Sleep(1000);
                    try
                    {
                        centralita += nuevaProvincial;
                    }
                    catch(CentralitaException ex)
                    {
                        MessageBox.Show(ex.Message,"Error en: "+ex.NombreMetodo, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    
                    this.Close();
                }
                else
                {
                    float duracion = (float)random.Next(1,50);
                    System.Threading.Thread.Sleep(1000);
                    Local nuevoLocal = new Local(txtNroOrigen.Text, duracion, txtNroDestino.Text, 2.65f);
                    try
                    {
                        centralita += nuevoLocal;
                    }
                    catch (CentralitaException ex)
                    {
                        MessageBox.Show(ex.Message, "Error en el " + ex.NombreMetodo, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    this.Close();
                }
            }

        }

        private void txtNroDestino_TextChanged(object sender, EventArgs e)
        {
            if(txtNroDestino.Text != "")
            {
                if (txtNroDestino.Text[0] == '#')
                {
                    cmbFranja.Enabled = true;
                }
                else
                {
                    cmbFranja.Enabled = false;
                }
            }
            
        }

        private void btnNumeral_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += "#";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += "0";
        }

        private void btnAsterisco_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += "*";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += "9";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += "8";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += "7";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += "6";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += "5";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += "4";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += "3";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += "2";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += "1";
        }
    }
}
