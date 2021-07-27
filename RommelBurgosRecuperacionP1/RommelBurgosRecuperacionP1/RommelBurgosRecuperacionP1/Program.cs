using System;


namespace ArbolB
{
    class Program
    {
        static void Main(string[] args)
        {
            CArbolB arbol = new CArbolB();

            RommelBurgosRecuperacionP1.Nodo raiz = arbol.Insertar(0, null);
            arbol.Insertar(1, raiz)
            arbol.Insertar(2, raiz);
            arbol.Insertar(3, raiz);
            arbol.Insertar(4, raiz);
            arbol.Insertar(5, raiz);
            arbol.Insertar(6, raiz);
            arbol.Insertar(7, raiz);
            arbol.Insertar(8, raiz);
            arbol.Insertar(9, raiz);

            arbol.Transversa(raiz);
        }
    }

    public class CArbolB
    {
        public void Insertar(int v, RommelBurgosRecuperacionP1.Nodo raiz)
        {
            throw new NotImplementedException();
        }

        public void Transversa(RommelBurgosRecuperacionP1.Nodo raiz)
        {
            throw new NotImplementedException();
        }
    }
}


namespace RommelBurgosRecuperacionP1
{
    class Nodo

    {
        private int dato;

        private Nodo izq;
        private Nodo der;

        public int Dato { get => dato; set => dato = value; }
        internal Nodo Izq { get => izq; set => izq = value; }
        internal Nodo Der { get => der; set => der = value; }


        public Nodo()
        {
            dato = 0;
            izq = null;
            der = null;
        }
    }


    class Arbol
    {
        public Nodo raiz;
        public Nodo trabajo;

        public int i = 0;

        public Arbol()
        {
            raiz = null;
        }
    }

    public Nodo Raiz { get => raiz; set => raiz = value; }

    //Inserto Datos

    public Nodo Insertar(int pDato, Nodo pNodo)
    {
        Nodo temp = null;

        if (Nodo == null)
        {
            temp = new Nodo();
            temp.Dato = pDato;


            return temp;
        }

        if (pDato < pNodo.Dato)
        {
            pNodo.Izq = Insertar(pDato, pNodo.Izq);
        }

        if (pDato > pNodo.Dato)
        {
            pNodo.Der = Insertar(pDato, pNodo.Der);
        }
        return pNodo;
    }


    public void Transversa(Nodo pNodo)
    {
        if (pNodo == null)
            return;

        for (int n = 0; n < int; n++)
            Console.WriteLine("");

        Console.WriteLine(pNodo.Dato);


        if (pNodo.Izq != null)
        {
            i++;
            Console.WriteLine("I");
            Transversa(pNodo.Izq);
            i--;
        }


        if (pNodo.Der != null)
        {
            i++;
            Console.WriteLine("D");
            Transversa(pNodo.Der);
            i--;
        }
    }

    public int EncuentraMinimo(Nodo pNodo);
}



