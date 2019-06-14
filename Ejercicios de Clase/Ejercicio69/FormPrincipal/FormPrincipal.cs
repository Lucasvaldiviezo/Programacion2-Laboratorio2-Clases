using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormPrincipal
{
    public partial class FormPrincipal : Form
    {
        private FormTestDelegados nuevoTest;
        private FormMostrar nuevoMostrar;
        public FormPrincipal()
        {
            InitializeComponent();
            mostrarToolStripMenuItem.Enabled = false;
        }

        private void testDelegadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nuevoTest = new FormTestDelegados();
            nuevoTest.MdiParent = this;
            nuevoTest.Show();
        }

        private void mostrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nuevoMostrar = new FormMostrar();
            nuevoMostrar.MdiParent = this;
            nuevoMostrar.Show();
            nuevoTest.EventoNombre += nuevoMostrar.ActualizarNombre;
        }

        private void FormPrincipal_MdiChildActivate(object sender, EventArgs e)
        {
            if(mostrarToolStripMenuItem.Enabled == true)
            {
                mostrarToolStripMenuItem.Enabled = false;
            }else
            {
                mostrarToolStripMenuItem.Enabled = true;
            }
        }
    }
}
