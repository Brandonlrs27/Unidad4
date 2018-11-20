using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E4_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Grafo Ejerci = new Grafo();//Creamos la clase 
            Ejerci.Crear(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g' });//Le ingresamos los vertices
            Ejerci.AddLink('a', new char[] { 'a', 'b' });//Y vamos ingresando las relaciones de cada uno
            Ejerci.AddLink('b', new char[] { 'a', 'c', 'g' });
            Ejerci.AddLink('c', new char[] { 'b', 'g', 'd' });
            Ejerci.AddLink('d', new char[] { 'c', 'e', 'f' });
            Ejerci.AddLink('e', new char[] { 'd', 'f' });
            Ejerci.AddLink('f', new char[] { 'g', 'd', 'e' });
            Ejerci.AddLink('g', new char[] { 'b', 'c', 'f' });
            Ejerci.ImprimirUniones();//Imprimimos nuestra tabla de relaciones
            Ejerci.Trayectorias();//E imprimimos todos los posibles caminos
            Console.ReadKey();
        }
    }
}
