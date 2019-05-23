using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace ConsolaProbar
{
    class Program
    {
        static void Main(string[] args)
        {
            Contabilidad<Factura, Recibo> contable = new Contabilidad<Factura, Recibo>();
            Factura factura1 = new Factura(20);
            Factura factura2 = new Factura(30);
            Factura factura3 = new Factura(40);
            Recibo recibo1 = new Recibo(50);
            Recibo recibo2 = new Recibo();
            Recibo recibo3 = new Recibo(70);

            contable += factura1;
            contable += factura2;
            contable += factura3;
            contable += recibo1;
            contable += recibo2;
            contable += recibo3;


            Console.WriteLine(contable.Mostrar());

            Console.ReadKey();
        }
    }
}
