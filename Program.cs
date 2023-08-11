using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp34
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese las llantas que usa su vehiculo: ");
            int Llantas = Convert.ToInt32(Console.ReadLine());

            if (Llantas == 2)
            {
                vehiculo Moto = new vehiculo(mColor(), mMarca(), mVelocidad(), mLlantas());
                Console.WriteLine("\nLa informacion del carro es: ");
                Moto.infoVehiculo();
            }
            else if (Llantas == 4)
            {
                vehiculo Carro = new vehiculo(cColor(), cMarca(), cVelocidad(), cLlantas());
                Console.WriteLine("\nLa informacion de la moto es: ");
                Carro.infoVehiculo();
            }
            else
            {
                Console.WriteLine("!Dato invalido¡");
            }

            Console.ReadKey();
        }
        static string cColor()
        {
            Console.WriteLine("Digite el color del carro: "); 
            string cC = Console.ReadLine();
            return cC;
        }

        static string cMarca()
        {
            Console.WriteLine("Digite la marca del carro: ");
            string mC = Console.ReadLine();
            return mC;
        }

        static int cVelocidad()
        {
            Console.WriteLine("Ingrese la velocidad maxima del carro; ");
            int vC = Convert.ToInt32(Console.ReadLine());
            return vC;
        }

        static string cLlantas()
        {
            Console.WriteLine("Ingrese el tipo de llantas de su carro: ");
            string lC = Console.ReadLine();
            return lC;
        }

        static string mColor()
        {
            Console.WriteLine("Digite el color de la moto: ");
            string cM = Console.ReadLine();
            return cM;
        }

        static string mMarca()
        {
            Console.WriteLine("Digite la marca de la moto: ");
            string mC = Console.ReadLine();
            return mC;
        }

        static int mVelocidad()
        {
            Console.WriteLine("Ingrese la velocidad maxima de la moto; ");
            int vM = Convert.ToInt32(Console.ReadLine());
            return vM;
        }

        static string mLlantas()
        {
            Console.WriteLine("Ingrese el tipo de llantas de su moto: ");
            string lM = Console.ReadLine();
            return lM;
        }
    }

    class vehiculo
    {
        public string Color { get; set; }
        public string Marca { get; set; }
        private int Velocidad { get; set; }
        public string Llantas { get; set; }

        public vehiculo(string Color, string Marca, int Velocidad, string Llantas)
        {
            this.Color = Color;
            this.Marca = Marca;
            this.Velocidad = Velocidad;
            this.Llantas = Llantas;
        }

        public void infoVehiculo()
        {
            Console.WriteLine("El color de su vehiculo es: " + Color);
            Console.WriteLine("La marca de su vehiculo es: " + Marca);
            Console.WriteLine("La velocidad maxima de su vehiculo es: " + Velocidad + "km/h");
            Console.WriteLine("El tipo de llantas de su vehiculo es: " + Llantas);
        }
    }
}
