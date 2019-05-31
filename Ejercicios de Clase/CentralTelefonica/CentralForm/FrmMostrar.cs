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
            MostrarDatos();
        }

        private void MostrarDatos()
        {
            switch(nuevoTipo)
            {
                case TipoLlamada.Local:
                    foreach (Llamada llamada in centralita.Llamadas)
                    {
                        if (llamada is Local)
                        {
                            richTxtMostrar.Text += llamada.ToString();
                        }
                    }
                    richTxtMostrar.Text += "\nEl costo total es: ";
                    richTxtMostrar.Text += Convert.ToString(centralita.GananciasPorLocal);
                break;
                case TipoLlamada.Provincial:
                    foreach (Llamada llamada in centralita.Llamadas)
                    {
                        if (llamada is Provincial)
                        {
                            richTxtMostrar.Text += llamada.ToString();
                        }
                    }
                    richTxtMostrar.Text += "\nEl costo total es: ";
                    richTxtMostrar.Text += Convert.ToString(centralita.GananciasPorProvincial);
                break;
                case TipoLlamada.Todas:
                    foreach (Llamada llamada in centralita.Llamadas)
                    {
                            richTxtMostrar.Text += llamada.ToString();
                    }
                    richTxtMostrar.Text += "\nEl costo total es: ";
                    richTxtMostrar.Text += Convert.ToString(centralita.GananciasPorTotal);
               break;
            }
            
        }
    }
}
