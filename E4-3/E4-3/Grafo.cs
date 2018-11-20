using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E4_3
{
    class Grafo
    {
        char[] puntos;//Aqui estaran los puntos
        bool[,] conexiones;//Aqui las conexiones entre puntos

        public void Crear(char[] arreglo)//Crea puntos y dimensiones de la tabla
        {
            puntos = arreglo;
            conexiones = new bool[arreglo.Length, arreglo.Length];
        }

        public void AddLink(char punto, char[] uniones)//Busca la posicion de punto indicado y le agrega sus relaciones en la tabla
        {
            int x = Array.IndexOf(puntos, punto);
            for (int i = 0; i < uniones.Length; i++)
            {
                conexiones[x, Array.IndexOf(puntos, uniones[i])] = true;
            }
        }
       
        public void Trayectorias()//Aqui llama a otro metodo para imprimir trayectoria de una manera recursiva
        {
            string pasos = "";
            for (int i = 0; i < puntos.Length; i++)
            {
                ImprimirUniones();
                Caminos(i, pasos, conexiones);
                Console.ReadKey();
                Console.Clear();
            }
        }
        public void ImprimirUniones()//Imprime el formato de la tabla 
        {
            for (int i = 0; i < puntos.Length; i++)
            {
                Console.SetCursorPosition((i * 7) + 5, 0);
                Console.Write(puntos[i]);
            }

            for (int i = 0; i < puntos.Length; i++)
            {
                Console.SetCursorPosition(0, i + 1);
                Console.Write(puntos[i]);
            }

            for (int i = 0; i < puntos.Length; i++)
            {
                for (int o = 0; o < puntos.Length; o++)
                {
                    Console.SetCursorPosition((i * 7) + 3, o + 1);
                    Console.Write(conexiones[i, o]);
                }
            }
            Console.SetCursorPosition(0, puntos.Length + 2);
        }
        private void Caminos(int vertice, string pasos, bool[,] conexiones)//Teniendo el vertice de incio, una variable que guarde los pasos y una copia de la tabla de realciones
        {
            bool ligas = false;//Indicador si el vertice tiene conexiones todavia
            bool[,] tem;
            pasos = pasos + " => " + puntos[vertice];//Se agrega los pasos contados al camino
            for (int i = 0; i < puntos.Length; i++)
            {//For para pasar por las conexiones
                if (conexiones[vertice, i] == true)//Si hay una relacion
                {
                    tem = conexiones;//Se copia la tabla
                    ligas = true;//Se indica que hay un camino existente
                    for (int o = 0; o < puntos.Length; o++)
                    {//Se modifica para indicar que ya se tomo ese camino
                        tem[o, vertice] = false;
                        tem[o, i] = false;
                    }
                    Caminos(i, pasos, tem);
                }
            }
            if (!ligas)//Se imprime si ya no hay conexiones
            {
                Console.WriteLine(pasos);
            }
        }
    }
}
