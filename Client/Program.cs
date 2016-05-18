using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WcfService1;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {

            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("Digite el tipo de operacion que desea realizar.");
                Console.WriteLine("'s'(suma), 'r'(resta), 'm'(multiplicacion), 'd'(divicion), o 'e' para salir");
                string input = Console.ReadLine();
                char inputType = input[0];
                string operationType = null;

                switch (inputType)
                {
                    case 's':
                        operationType = "Add";
                        break;

                    case 'r':
                        operationType = "Subtract";
                        break;

                    case 'm':
                        operationType = "Multiply";
                        break;

                    case 'd':
                        operationType = "Divide";
                        break;

                    case 'e':
                        exit = true;
                        break;

                    default:
                        Console.WriteLine("Opcion invalida. Intente de nuevo porfavor.");
                        break;

                }
                if (operationType != null)
                {

                    double val1 = solicitNumber("valor 1");
                    double val2 = solicitNumber("valor 2");

                    MathService math = new MathService();

                    double result = math.Process(val1, val2, operationType);
                    Console.WriteLine();
                    Console.WriteLine("Resultado: "+result);
                    


                }


            }
        }

        public static double solicitNumber(string name)
        {
            Console.WriteLine("Diginte un numero para el " + name);
            double num = Convert.ToDouble(Console.ReadLine());
            return num;
        }

            
        
    }
}
