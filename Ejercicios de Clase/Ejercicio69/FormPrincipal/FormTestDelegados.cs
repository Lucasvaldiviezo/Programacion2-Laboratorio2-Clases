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
    public partial class FormTestDelegados : Form
    {
        private FormPrincipal frmPrincipal;
        public event FormMostrar.DelegadoNombre EventoNombre;
        public FormTestDelegados()
        {
            InitializeComponent();
            frmPrincipal = (FormPrincipal)this.MdiParent;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            
        }
    }
}
