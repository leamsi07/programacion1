using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodos
{
    class Vehiculo
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Color { get; set; }

        public int year { get; set; }

        public void Atributos()
        {
            Marca = "Jeep";
            Modelo = "Grand Cherokee";
            Color = "Blanco perla";
            year = 2018;
            Console.WriteLine("Datos del vehiculo: ");
            Console.WriteLine(Marca +" "+ Modelo);
            Console.WriteLine(Color + " " + year);
            Console.ReadLine();
        }
        public void EstadoOn()
        {
            Console.WriteLine("Vehiculo Encendido");
            Console.ReadLine();
            Console.WriteLine("Desea apagarlo?si/no: ");
            string respuesta = Console.ReadLine();
            if (respuesta == "si")
            {
                EstadoOff();
            }
            else
            {
                Console.WriteLine("El vehiculo se mantiene encendido ");
                Console.ReadLine();
            }
        }
        public void EstadoOff()
        {
            Console.WriteLine("Vehiculo Apagado");
            Console.ReadLine();
            Console.WriteLine("Desea Encenderlo?si/no: ");
            string respuesta = Console.ReadLine();
            if (respuesta == "si")
            {
                EstadoOn();
            }
            else
            {
                Console.WriteLine("El vehiculo se mantiene Apagado ");
                Console.ReadLine();
            }
        }

    }

}
