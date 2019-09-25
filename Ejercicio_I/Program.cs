using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_I
{
    class Program
    {
        static void Main(string[] args)
        {
            Empleado emp = new Empleado();
            emp.Cargar();
            emp.Imprimir();
            Console.WriteLine();
            if (emp.PagaImpuesto())
            {
                Console.WriteLine("Debe pagar impuesto");
            }
            else
            {
                Console.WriteLine("No debe pagar Impuesto");
            }

            Console.ReadKey();
        }
    }

    class Empleado
    {
        private string nombre;
        private double sueldo;

        private string Nombre { get => nombre; set => nombre = value; }
        private double Sueldo { get => sueldo; set => sueldo = value; }

        public void Cargar()
        {
            Console.Write("Ingrese el nombre del empleado: ");
            Nombre = Console.ReadLine();
            Console.Write("Ingrese el sueldo: ");
            Sueldo = double.Parse(Console.ReadLine());
        }

        public void Imprimir()
        {
            Console.WriteLine();
            Console.WriteLine("Empleado: {0}", Nombre);
            Console.WriteLine("Sueldo: {0:C2}", Sueldo);
        }

        public bool PagaImpuesto()
        {
            if (sueldo > 30000)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
