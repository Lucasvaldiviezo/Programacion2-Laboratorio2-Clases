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
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        public Centralita centralita = new Centralita("Telefonica");

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            FrmLlamador nuevoLlamada = new FrmLlamador(centralita);
            nuevoLlamada.ShowDialog();
        }
    }
}
