using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Arbol Ejercicio = new Arbol();//Se crea un objeto de tipo Arbol llamado Ejercicio
            Ejercicio.ArbolA();//se llama al metodo ArbolA de la clase Ejercicio
            Console.Clear();
            Ejercicio.ArbolB();//Asi igual con los otros 2 metodos para arbol B y C
            Console.Clear();
            Ejercicio.ArbolC();
        }
    }
}
