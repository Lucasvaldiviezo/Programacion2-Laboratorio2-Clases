using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Entidades;

namespace Archivos
{
    public class Texto : IArchivo<Queue<Patente>>
    {
        public void Guardar(string archivo, Queue<Patente> datos)
        {
            StreamWriter archivotxt;
            archivotxt = new StreamWriter(archivo, false);
            try
            {
                foreach (Patente p in datos)
                {
                    archivotxt.Write(p);
                }
            }catch(Exception)
            {

            }
            finally
            {
                archivotxt.Close();
            } 
        }

        public void Leer(string archivo, out Queue<Patente> datos)
        {
            StreamReader archivotxt;
            archivotxt = new StreamReader(archivo);
            datos = new Queue<Patente>();
            Patente patente;
            string aux;
            try
            {
                while(!archivotxt.EndOfStream)
                {
                    aux = archivotxt.ReadLine();
                    if(aux.Length == 6)
                    {
                        patente = new Patente(aux, Patente.Tipo.Vieja);
                        datos.Enqueue(patente);
                    }
                    else if(aux.Length == 7)
                    {
                        patente = new Patente(aux, Patente.Tipo.Mercosur);
                        datos.Enqueue(patente);
                    }
                }
            }
            catch (Exception)
            {
                datos = null;
            }
            finally
            {
                archivotxt.Close();
            }
        }
    }
}
