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
            
        }

        private void txtNroDestino_TextChanged(object sender, EventArgs e)
        {
            if(txtNroDestino.Text[0] == '#')
            {
                cmbFranja.Enabled = true;
            }else
            {
                cmbFranja.Enabled = false;
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
    }
}
