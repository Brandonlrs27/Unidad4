using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_4_2
{
    class Arbol
    {
        int CoordX = 0, CoordY = 2;//Coordenadas para la posicion del arbol 
        public void AgregarVin(Nodo node, string name, string[] names)//Metodo llamado AgregarVin para relacionar cada nodo
        {
            if (node.vin != null)//Si el atributo vinculo de node es diferente de null
            {
                foreach (Nodo item in node.vin)//por cada item de la clase Nodo en vin 
                {
                    AgregarVin(item, name, names);//Se llama al metodo AgregarVin
                }
            }
            else// Si no es asi
            {
                if (node.nombre == name)//si el atributo nombre de la clase Node es igual al parametro name 
                {
                    node.vin = new Nodo[names.Length];//se crea un nuevo arreglo Nodo que se le asigna al atributo vinculo 
                    for (int i = 0; i < names.Length; i++)//for que va desde 0 hasta el tamaño del arreglo names - 1 
                    {
                        node.vin[i] = new Nodo(names[i]);//se crea un nuevo arreglo de Node con parametro names en i, y se iguala al atributo vinculo en la posicion i 
                    }
                }
            }
        }     
        public void ArbolA()//Metodo que imprime el arbol A 
        {
            Console.WriteLine("Arbol A");
            Nodo RootNode = new Nodo("E");//Se crea un objeto Nodo que es la raiz, en este caso es E
            Arbol Arbol = new Arbol();//se crea un objeto de tipo Arbol llamado Arbol
            Arbol.AgregarVin(RootNode, "E", new string[] { "F", "A" });//se llama el metodo AgregarVin dandole distintos parametros
            Arbol.AgregarVin(RootNode, "A", new string[] { "B", "C", "D" });//se llama el metodo AgregarVin dandole distintos parametros
            Arbol.Imprimir(RootNode);//Se llama el metodo Imprimir
            Arbol.NivelAltura();//Se llama al metodo NivelAltura que imprime la altura y el nivel 
            Console.WriteLine("Ruta al elemento mas largo: E-->A-->(B,C,D)");
                                                                             
            Console.ReadKey();
        }

        public void ArbolB() //Igual con el metodo ArbolA pero con parametros del ejercicio B
        {
            Console.WriteLine("Arbol B");
            Nodo RootNode = new Nodo("C");
            Arbol Arbol = new Arbol();
            Arbol.AgregarVin(RootNode, "C", new string[] { "D", "F", "G", "A" });
            Arbol.AgregarVin(RootNode, "A", new string[] { "B" });
            Arbol.AgregarVin(RootNode, "B", new string[] { "E" });
            Arbol.Imprimir(RootNode);
            Arbol.NivelAltura();
            Console.WriteLine("Ruta al elemento mas largo: C-->A-->B-->E");
                                                                       
            Console.ReadKey();
        }

        public void ArbolC() //Igual con el metodo ArbolA pero con parametros del ejercicio C
        {
            Console.WriteLine("Arbol C");
            Nodo NodoRaiz = new Nodo("K");
            Arbol Arbolito = new Arbol();
            Arbolito.AgregarVin(NodoRaiz, "K", new string[] { "A", "C", "B", "D" });
            Arbolito.AgregarVin(NodoRaiz, "D", new string[] { "I    J", "E" });
            Arbolito.AgregarVin(NodoRaiz, "E", new string[] { "F", "G" });
            Arbolito.AgregarVin(NodoRaiz, "G", new string[] { "H" });
            Arbolito.Imprimir(NodoRaiz);
            Arbolito.NivelAltura();
            Console.WriteLine("Ruta al elemento mas largo: K-->D-->E-->G-->H");
                                                                               
            Console.ReadKey();
        }
        public void NivelAltura()//Metodo que imprime altura y nivel
        {
            Console.WriteLine("\n\nAltura: {0}", Height);//se imprime en consola Altura
            Console.WriteLine("Nivel: {0}", Level);//se imprime en consola Nivel
                                                   
        }
        int Height = 0, Level = 0;// se crean las variables height y level del arbol 
        public void Imprimir(Nodo node)//Creacion del metodo imprimir al que se le manda un parametro de tipo Node
        {

            if (node.vin != null)// si el atributo vinculo de node es diferente a null
            {
                Console.SetCursorPosition(CoordX, CoordY);//se usa SetCursorPosition con parametros CoordX y CoordY para que se escriba en cierta parte de la consola 
                Console.Write(node.nombre);//Se imprime el atributo nombre 
                CoordX += 5;
                CoordY++;
                for (int i = 0; i < node.vin.Length; i++)// for desde 0 hasta el tamaño del arreglo vinculo 
                {
                    Imprimir(node.vin[i]);//se llama el metodo impresion con parametro vinculo en la posicion i 
                }
                CoordX += 5;// se le suma a la coordenada x 5 
            }
            else// si no 
            {
                Console.SetCursorPosition(CoordX, CoordY);// el cursor se posiciona en las coordenadas 
                Console.Write(node.nombre);// se imprime el atributo nombre 
                CoordY++;// se incrementa la coordenada y 
            }

            Height = ((CoordY - 1) / 2) - 1;// altura se iguala a ((CoordY - 1) /2) - 1
            Level = Height;// level se iguala a height 
        }

    }
}
