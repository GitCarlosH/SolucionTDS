using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoConsola2
{
    public class Program
    {
        static void Main(string[] args)
        {
           
        }
        public static string Something()
        {
            return "algo";
        }

        public static bool Login(string user, string pass) =>
        
            user == "carlos" && pass == "123456" ? true : false;
        
    }



    // Declaración de un delegado
    delegate void Del(int i, double j);

    class MathClass
    {
        static void Main()
        {
            MathClass m = new MathClass();

            // Declaración del objeto delegado y asignación de la acción del objeto de la clase MathClass
            Del d = m.MultiplyNumbers;

            // Invoke the delegate object.
            Console.WriteLine("Invoking the delegate using 'MultiplyNumbers':");
            for (int i = 1; i <= 5; i++)
            {
                d(i, 2);
            }

            // Keep the console window open in debug mode.
            Console.WriteLine("");
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
        void MultiplyNumbers(int m, double n)
        {
            Console.Write(m * n + " ");

            // Output: Invoking the delegate using 'MultiplyNumbers': 2 4 6 8 10 
        }



    }

    // Declare a delegate
    delegate void Dele();

    class SampleClass
    {
        public void InstanceMethod()
        {
            Console.WriteLine("A message from the instance method.");
        }

        static public void StaticMethod()
        {
            Console.WriteLine("A message from the static method.");
        }
    }

    class TestSampleClass
    {
        static void Main()
        {
            var sc = new SampleClass();

            // Map the delegate to the instance method:
            Dele d = sc.InstanceMethod;
            d();

            // Map to the static method:
            d = SampleClass.StaticMethod;
            d();
        }
    }
    /* Output: A message from the instance method. A message from the static method. */


}
