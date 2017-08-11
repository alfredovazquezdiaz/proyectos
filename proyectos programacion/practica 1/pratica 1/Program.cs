using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Nombre:Oscar Carmona Mendez 16-SIIN-1-164  seccion: 0463");

            Console.WriteLine("Nombre:Alfredo Vasquez Diaz 15-MIIN-138  seccion: 0463");

            {

                int cuenta;

                float saldo, suma;

                string linea;

                suma = 0;

                do

                {

                    Console.Write("Ingrese numero de cuenta:");

                    linea = Console.ReadLine();

                    cuenta = int.Parse(linea);

                    if (cuenta >= 0)

                    {

                        Console.Write("Ingrese Saldo:");

                        linea = Console.ReadLine();

                        saldo = float.Parse(linea);

                        if (saldo > 0)

                        {

                            Console.WriteLine("Saldo Acreedor.");

                            suma = suma + saldo;

                        }

                        else

                        {

                            if (saldo < 0)

                            {
                                Console.WriteLine("Saldo Deudor.");

                            }

                            else

                            {

                                Console.WriteLine("Saldo Nulo.");


                            }
                        }
                    }

                } while (cuenta >= 0);

                Console.Write("Total de saldos Acreedor:");

                Console.Write(suma);

                Console.ReadKey();

            }
        }
    }
}
