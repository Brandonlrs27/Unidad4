using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_4_2
{
    class Nodo
    {
        public string nombre;//Variable de tipo string para el nombre
        public Nodo[] vin;//Arreglo de tipo Nodo llamado vin
        public Nodo() { }//Constructor 
        public Nodo(string name)//Construcutor sobrecargado
        {
            nombre = name;//Se iguala la variable nombre al parametro name
        }
    }
}
