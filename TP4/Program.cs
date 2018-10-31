using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP4
{
    class Program
    {
        static void Main(string[] args)
        {
            Controlador cont = new Controlador();
            int respuesta = -1;
            while (respuesta != 2)
            {
                Console.WriteLine("1.Dividir");
                Console.WriteLine("2.Salir");
                respuesta = Convert.ToInt16(Console.ReadLine());
                switch (respuesta)
                {
                    case 1:
                        Console.Clear();
                        try
                        {
                            Console.Write("Ingrese dividendo: ");
                            int div = Convert.ToInt16(Console.ReadLine());
                            Console.Write("Ingrese divisor: ");
                            float res = cont.Dividir(div, Convert.ToInt16(Console.ReadLine()));
                            Console.WriteLine("El resultado es: {0}", res);
                        }
                        catch (DivisionPorCeroException ex)
                        {
                            Console.WriteLine(ex.Message);
                            Console.WriteLine("Stack trace: {0}", ex.StackTrace);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Excepcion generica: {0}", ex.Message);
                            Console.WriteLine("Stack trace: {0}", ex.StackTrace);
                        }
                        Console.ReadKey();
                        break;
                    default:
                        break;
                }
                Console.Clear();
            }
        }
    }
}
