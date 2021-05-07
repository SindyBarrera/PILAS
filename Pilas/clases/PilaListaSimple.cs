using System;
using System.Collections.Generic;
using System.Text;

namespace Pilas.clases
{
    class PilaListaSimple
    {
        public Nodo primero;
        int cima;

        //CONSTRUCTOR
        public PilaListaSimple()
        {
            primero = null;
            
        }


        //INSERTAR ELEMENTOS A LA LISTA
        public void InsertarList(object dato)
        {
            //Nuevo nodo que va a recibir como parametro a dato
            Nodo nuevo = new Nodo(dato);

            if (ListaVacia())
            {
                //Inicializa la lista agregando el nuevo nodo al inicio
                primero = nuevo;
            }
            else //agrega los nodos al inicio de la lista
            {
                nuevo.enlace = primero; //Unimos el nodo nuevo con los existentes de la lista
                primero = nuevo;
            }
            cima++; //Incrementamos 
        }

        //METODO SI LA LISTA ESTA VACIA
        public bool ListaVacia()
        {
            if (primero == null)
            {
                return true;
            }
            else
            {
                return false;

            }
        }

        //METODO PARA VISUALIZAR LOS DATOS
        public void VisualizarInverso()
        {
            Nodo actual = primero;
            while (actual != null)
            {
                Console.WriteLine(actual.dato);
                actual = actual.enlace;
            }
        }


        //METODO PARA ELIMINAR EN EL PALINDROMO 
        public object quitarChar()
        {
            char aux;

            if (ListaVacia())
            {
                throw new Exception("PILA VACIA NO HAY DATA");
            }else
            {
              aux = (char)primero.dato;
              primero = primero.enlace;
            
              cima--;
              return aux;
            }

        }


        public void LimpiarPila()
        {
            cima = -1;

        }


        //ELIMINAR 
        public object quitar()
        {
            int aux;
            if (ListaVacia())
            {
                throw new Exception("PILA VACIA NO HAY DATA");
            }
            aux = (int)primero.dato;
            primero = primero.enlace;
            cima--;
            return aux;
        }

        
     

    }
}
