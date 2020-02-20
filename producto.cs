using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodos
{
    class producto
    {
        string nombre = "Tv";
        string descripcion = " SmartTv, Samsung, 58 pulgadas, $45000 ";

        public void AgregarNombre(string no)
        {
            no = nombre;
        }
        public void ProductoDisponible()
        {
            Console.WriteLine("Producto " + nombre + " " + descripcion);
            Console.ReadLine();
        }
    }
   
    
}
