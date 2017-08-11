using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

namespace practica_3


{
    class Cliente

    {
        private string nombre;

        private int monto;

        public Cliente(string nom)

        {

            nombre = nom;

            monto = 0;

        }

        public void Depositar(int m)

        {

            monto = monto + m;

        }

        public void Extraer(int m)

        {

            monto = monto - m;

        }

        public int RetornarMonto()

        {

            return monto;
        }

        public void Imprimir()

        {

            Console.WriteLine(nombre + "tiene depositado la suma de " + monto);

        }
    }

    class Banco

    {

        private Cliente cliente1, cliente2, cliente3;

        public Banco()

        {

            cliente1 = new Cliente("Paco");

            cliente2 = new Cliente("Dora");

            cliente3 = new Cliente("Barney");

        }

        public void Operar()

        {

            cliente1.Depositar(8000);

            cliente2.Depositar(30000);

            cliente3.Depositar(20000);

            cliente3.Extraer(500);

        }

        public void DepositosTotales()

        {

            int t = cliente1.RetornarMonto() +

                    cliente2.RetornarMonto() +

                    cliente3.RetornarMonto();

            Console.WriteLine("El total de dinero en el banco es:" + t);

            cliente1.Imprimir();

            cliente2.Imprimir();

            cliente3.Imprimir();

        }

        static void Main(string[] args)

        {
            Console.WriteLine("Nombre:Oscar Carmona Mendez   16-SIIN-1-164  seccion: 0463");

            Console.WriteLine("Nombre:Alfredo Vazquez Diaz   15-MIIN-1-138   seccion: 0463");

            Banco banco1 = new Banco();

            banco1.Operar();

            banco1.DepositosTotales();

            Console.ReadKey();

        }
    }
}

