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
    
    
    public partial class FormMostrar : Form
    {
        public delegate void DelegadoNombre(string dato);
        public FormMostrar()
        {
            InitializeComponent();
        }


        public void ActualizarNombre(string dato)
        {
            lblEtiqueta.Text = dato;
        } 
    }
}
