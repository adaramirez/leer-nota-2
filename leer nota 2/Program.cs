using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leer_nota_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1;
            Console.WriteLine("ingrese la nota: ");
            n1 = int.Parse(Console.ReadLine());

            switch (n1)
            {
                case 20:
                case 19: Console.WriteLine("sobresaliente");
                    break;

                case 18:
                case 17:
                case 16:
                    Console.WriteLine("muy bueno");
                    break;

                case 15:
                case 14:
                case 13:
                case 12:
                    Console.WriteLine("bueno");
                    break;

                case 11:
                case 10:
                case 9:
                case 8:
                case 7:
                case 6:
                case 5:
                case 4:
                case 3:
                case 2:
                case 1:
                case 0:
                    Console.WriteLine("regular");
                    break;


                default: Console.WriteLine("nota no valida");
                    break;
            }
            Console.WriteLine("pulse enter para salir");
            Console.ReadLine();
            }
        }
    }

