using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_II
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa que imprime el cuadrante en el que se encuentran X e Y");

            Plano plano = new Plano();
            plano.Cargar();
            plano.ImprimirCuadrante();

            Console.ReadKey();
        }
    }

    class Plano
    {
        private int X;
        private int Y;

        public int Y1 { get => Y; set => Y = value; }
        public int X1 { get => X; set => X = value; }

        public void Cargar()
        {
            Console.Write("Ingrese el valor de X: ");
            X1 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el valor de Y: ");
            Y1= int.Parse(Console.ReadLine());
        }

        public void ImprimirCuadrante()
        {
            if (X > 0 && Y > 0)
            {
                Console.WriteLine("X = {0} y Y = {1} se encuentra en el 'Primer Cuadrante'.",
                    X,Y);
            }
            else if (X < 0 && Y > 0)
            {
                Console.WriteLine("X = {0} y Y = {1} se encuentra en el 'Segundo Cuadrante'.",
                    X, Y);
            }
            else if (X < 0 && Y < 0)
            {
                Console.WriteLine("X = {0} y Y = {1} se encuentra en el 'Tercer Cuadrante'.",
                    X, Y);
            }
            else
            {
                Console.WriteLine("X = {0} y Y = {1} se encuentra en el 'Cuarto Cuadrante'.",
                    X, Y);
            }
        }
    }
}
