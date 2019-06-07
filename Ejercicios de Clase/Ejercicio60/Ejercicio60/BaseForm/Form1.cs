using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Acces;

namespace BaseForm
{
    public partial class FormBase : Form
    {
        public Base nuevaBase;
        public FormBase()
        {
            InitializeComponent();
            nuevaBase = new Base();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            nuevaBase.Agregar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            nuevaBase.Modificar();
        }
    }
}
