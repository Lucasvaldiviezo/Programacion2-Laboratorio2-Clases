using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace VistaForm
{
    public partial class FormDT : Form
    {
        private DirectorTecnico dt;

        public FormDT()
        {
            InitializeComponent();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            dt = new DirectorTecnico(txtNombre.Text, txtApellido.Text, (int)nudEdad.Value, (int)nudDni.Value, (int)nudExperiencia.Value);
            MessageBox.Show("Se ha creado el DT", "DT",MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            if(dt==null)
            {
                MessageBox.Show("Aun no sea ha creado el DT del formulario", "DT no creado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }else if(dt.ValidarAptitud())
            {
                MessageBox.Show("El DT es apto", "DT Apto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }else if(!dt.ValidarAptitud())
            {
                MessageBox.Show("El DT no es apto", "DT no apto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
