using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace Archivos
{
    public class Xml<T> : IArchivo<T>
    {
        public void Guardar(string archivo, T datos)
        {
            XmlSerializer serializador = new XmlSerializer(typeof(T));
            XmlTextWriter escritor = null;
            try
            {
                escritor = new XmlTextWriter(archivo, null);
                serializador.Serialize(escritor, datos);
            }
            catch (Exception)
            {
            }
            finally
            {
                escritor.Close();
            }
        }
        public void Leer(string archivo, out T datos)
        {
       
            XmlSerializer serializador = new XmlSerializer(typeof(T));
            XmlTextReader lector = null;
            try
            {
                lector = new XmlTextReader(archivo);
                datos = (T)serializador.Deserialize(lector);
            }
            catch (Exception)
            {
                datos = default(T);
            }
            finally
            {
                lector.Close();
            }
        }
    }
}
