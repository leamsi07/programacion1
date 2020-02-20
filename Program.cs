using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodos
{
    class Program
    {
      
        static void Main(string[] args)
        {
              Program n = new Program();
        bool seguir = true;
            string entrada = "";

            while (seguir)
            {
                Console.Clear();
                Console.WriteLine("Bienvenidos a el listado de empleados de la empresa ");
                Console.WriteLine("Elija la opcion que desee: ");
                Console.WriteLine("1 metodo llamado HolaEstudiante");
                Console.WriteLine("2 Metodo que recorra los numeros del 1-50  ");
                Console.WriteLine("3 Metodo con un programa que genere un número al azar entre 1 y 100");
                Console.WriteLine("4 Clase vehiculo");
                Console.WriteLine("5 Clase producto");
                Console.WriteLine("6 Salir");
                entrada = Console.ReadLine();
                switch (entrada)
                {

                    case "1":
                        Console.Clear();
                        
                        n.HolaEstudiante();

                        break;

                    case "2":
                        
                        Console.Clear();
                        n.Numeros();
                        break;

                    case "3":
                        Console.Clear();
                        n.Random();
                       
                        break;
                    case "4":
                        Console.Clear();
                        Vehiculo v = new Vehiculo();
                        v.Atributos();
                        v.EstadoOn();
                      

                        break;
                    case "5":
                        Console.Clear();
                        producto p = new producto();
                        p.ProductoDisponible();
                        break;

                    case "6":
                        Console.WriteLine("Adios :(");
                        Console.ReadLine();
                        seguir = false;
                        break;
                   

                    default:
                        Console.WriteLine("Algo anda mal :( elija la opcion correcta :)");
                        Console.ReadLine();
                        break;
                }
            }
     
        }

        public void HolaEstudiante()
        {
            Console.WriteLine("Hola, estudiante Larrisa Manoela. Bienvenido a programación I ");
        }
        public void Numeros()
        {
            Console.WriteLine("Numeros del 1 al 50");
            Console.ReadLine();
            for (int i =1; i<51; i++)
            {
            
                Console.WriteLine(i);
              
            }
           
        }

        public void Random()
        {
            const int oportunidades = 6;

            byte i, adivinado;
           
             Random k  = new Random();
           int aleatorio= k.Next(1, 100);
            
           
            i = 1; adivinado = 0;
            do
            {
                Console.WriteLine("Intenta acertar el numero Random");
                int valor = int.Parse(Console.ReadLine());
                if (aleatorio == valor)
                {
                    Console.WriteLine("Acertaste correctamente el numero es ", aleatorio);
                }
                else 
                {
                    Console.WriteLine("Siga intentando esta cerca");

                }
                i++;
            } while (((i <= oportunidades) & (adivinado == 0)));
            if ((adivinado == 0))
            {
                Console.Write("Has agotado los intentos... El numero fue: " + aleatorio);
            }

            Console.ReadKey();
        }

       
    }
}
