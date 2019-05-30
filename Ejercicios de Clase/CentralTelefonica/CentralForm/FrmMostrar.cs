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
    public partial class FrmMostrar : Form
    {
        public FrmMostrar()
        {
            InitializeComponent();
        }

        public Centralita centralita;
        public TipoLlamada nuevoTipo;
        public FrmMostrar(Centralita centralita,TipoLlamada llamada) : this()
        {
            this.centralita = centralita;
            this.nuevoTipo = llamada;

        }
    }
}
