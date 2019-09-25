using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_III
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa que imprime el mas antiguo de 3 socios en un club");
            Club club = new Club();
            Console.WriteLine();
            club.ImprimirMasAntiguo();
            Console.ReadKey();
        }
    }
    class Club
    {
        private Socio[] Socios = new Socio[3];
        public Club()
        {
            string nombre;
            int antiguedad;
            for (int i = 0; i < Socios.GetLength(0); i++)
            {
                Console.Write("Ingrese el nombre del socio {0}: ", i + 1);
                nombre = Console.ReadLine();
                Console.Write("Ingrese los años de antiguedad del socio {0}: ", i + 1);
                antiguedad = int.Parse(Console.ReadLine());
                Socios[i] = new Socio(nombre, antiguedad);
            }
        }    
        
        public void ImprimirMasAntiguo()
        {
            Socio socio = new Socio("",0);
            for (int i = 0; i < Socios.GetLength(0); i++)
            {
                if (Socios[i]._Antiguedad > socio._Antiguedad)
                {
                    socio = Socios[i];
                }
            }
            Console.WriteLine("El socio mas antiguo es {0} con {1} años de antiguedad",
                socio._Nombre, socio._Antiguedad);
        }
    }

    class Socio
    {
        private string Nombre;
        private int Antiguedad;
        public string _Nombre { get => Nombre; set => Nombre = value; }
        public int _Antiguedad { get => Antiguedad; set => Antiguedad = value; }

        public Socio(string nombre , int antiguedad)
        {
            _Nombre = nombre;
            _Antiguedad = antiguedad;
        }


    }
}
