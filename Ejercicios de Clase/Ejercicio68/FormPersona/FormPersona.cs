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
namespace FormPersona
{
    public partial class FormPersona : Form
    {
        public FormPersona()
        {
            InitializeComponent();
        }
        private Persona persona;
        private event DelegadoString EventoString;

        private void FormPersona_Load(object sender, EventArgs e)
        {
            EventoString += NotificarCambio;
        }
        public void NotificarCambio(string cambio)
        {
            MessageBox.Show(cambio,"Notificacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            int flag = 0;
            if(persona == null)
            {
                persona = new Persona();
                persona.Nombre = txtNombre.Text;
                persona.Apellido = txtApellido.Text;
                btnCrear.Text = "Actualizar";
                EventoString.Invoke("Se ha creado la persona");
            }else
            {
                if (txtApellido.Text != persona.Apellido || txtNombre.Text != persona.Nombre)
                {
                    persona.Nombre = txtNombre.Text;
                    persona.Apellido = txtApellido.Text;
                    EventoString.Invoke("Se ha modificado nombre y/o apellido:" + persona.Mostrar());
                }

            }
        }
    }
}
