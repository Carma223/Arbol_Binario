using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appArbolBinario
{
    class Nodo_Arbol
    {
        public char info;                //Dato a almacenar en el nodo
        public Nodo_Arbol Izquierdo;     //Nodo izquierdo del arbol
        public Nodo_Arbol Derecho;      //Nodo derecho del arbol
        public Nodo_Arbol Padre;        //Nodo raíz del árbol
        public int altura;
        public int nivel;
        public Rectangle nodo;          //Para dibujar el nodo del árbol

        private Nodo_Arbol arbol; //Se declara un objeto de la clase Arbol_Binario

        public Nodo_Arbol() //Constructor por defecto
        {
        }

        public Nodo_Arbol Arbol
        {
            get { return arbol; }
            set { arbol = value; }
        }

        //Constructor de parametros

        public Nodo_Arbol(char nueva_info, Nodo_Arbol izquierdo, Nodo_Arbol derecho, Nodo_Arbol padre)
        {
            info = nueva_info;
            Izquierdo = izquierdo;
            Derecho = derecho;
            Padre = padre;
            altura = 0;
        }
        
        //Funcion para insertar un nodo en el Arbol Binario
        public Nodo_Arbol Insertar ( char x, Nodo_Arbol t, int level)
        {
            if (t == null) // Si el nodo que s
            {
                t = new Nodo_Arbol(x, null, null, null);
                t.nivel = level;
            } 
            else if (x < t.info)
            {
                level++;
                t.Derecho = Insertar (x, t.Derecho, level);
            }
            else if(x > t.info)
            {
                level++;
                t.Derecho = Insertar(x, t.Derecho, level);
            }
            else
            {
                MessageBox.Show("Dato existente en el arbol", "Error de infreso");
            }
        }
    }
}
