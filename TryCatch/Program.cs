using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatch
{
    class Program
    {
        static void Main(string[] args)
        {

            int a = 6;
            int b = 0;

            try
            {
                int c = a / b;
                Console.WriteLine(c);
            }
            catch(IndexOutOfRangeException e)
            {
                Console.WriteLine("Index out of range");
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("DivideByZero");
            }
            catch (Exception e)
            {
                Console.WriteLine("Ha habido un error");
            }
            finally
            {
                Console.WriteLine("Siempre se va a ejecutar");
            }

            Console.Read();

        }
    }
}
