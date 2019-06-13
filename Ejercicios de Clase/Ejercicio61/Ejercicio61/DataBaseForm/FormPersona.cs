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

namespace DataBaseForm
{
    public partial class FormPersona : Form
    {
        List<Persona> personas;
        public FormPersona()
        {
            InitializeComponent();
            personas = new List<Persona>();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Persona p = new Persona(txtNombre.Text, txtApellido.Text);
            PersonaDAO.Guardar(p);
            personas = PersonaDAO.Leer();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            
        }
    }
}
