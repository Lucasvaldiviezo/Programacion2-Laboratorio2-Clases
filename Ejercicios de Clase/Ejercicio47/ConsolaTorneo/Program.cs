using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Deporte;

namespace ConsolaTorneo
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime fecha = new DateTime();
            DateTime fecha2 = new DateTime();
            DateTime fecha3 = new DateTime();
            fecha = DateTime.Now.AddDays(-1);
            fecha2 = DateTime.Now.AddDays(-2);
            fecha3 = DateTime.Now.AddDays(-3);
            Console.Title = "Ejercicio 47";
            Torneo<Equipo> TorneoFutbol = new Torneo<Equipo>("Torneo de Futbol");
            Torneo<Equipo> TorneoBasket = new Torneo<Equipo>("Torneo de Bastket");
            Equipo Futbol1 = new EquipoFutbol("Futbol1",fecha);
            Equipo Futbol2 = new EquipoFutbol("Futbol2",fecha2);
            Equipo Futbol3 = new EquipoFutbol("Futbol3",fecha3);
            Equipo Basquet1 = new EquipoBasket("Basket1",fecha);
            Equipo Basquet2 = new EquipoBasket("Basket2",fecha2);
            Equipo Basquet3 = new EquipoBasket("Basket3",fecha3);
            TorneoFutbol += Futbol1;
            TorneoFutbol += Futbol2;
            TorneoFutbol += Futbol2;
            TorneoFutbol += Futbol3;
            TorneoFutbol += Futbol3;
            TorneoBasket += Basquet1;
            TorneoBasket += Basquet2;
            TorneoBasket += Basquet2;
            TorneoBasket += Basquet3;
            TorneoBasket += Basquet3;

            Console.WriteLine(TorneoFutbol.Mostrar());
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("Partido 1:\n{0}", TorneoFutbol.JugarPartido());
            Console.WriteLine("Partido 2:\n{0}", TorneoFutbol.JugarPartido());
            Console.WriteLine("Partido 3:\n{0}", TorneoFutbol.JugarPartido());
            Console.WriteLine("******************************************************");
            Console.WriteLine(TorneoBasket.Mostrar());
            Console.WriteLine("Partido 1:\n{0}", TorneoBasket.JugarPartido());
            Console.WriteLine("Partido 2:\n{0}", TorneoBasket.JugarPartido());
            Console.WriteLine("Partido 3:\n{0}", TorneoBasket.JugarPartido());
            Console.ReadKey();
        }
    }
}
