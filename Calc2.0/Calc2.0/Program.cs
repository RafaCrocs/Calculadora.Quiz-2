namespace Calc2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                bool a = true;
                    Console.WriteLine("Calculadora");
                    Console.WriteLine("Ingrese el primer numero");
                    double num1 = Revisar();
                    Console.WriteLine("Ingrese el segundo numero");
                    double num2 = Revisar();
                    double resultado = 0;
                do
                {
                    Console.WriteLine("Ingrese la operacion deseada(+, -, *, /)\nENTER para salir... ");
                    string operacion = Console.ReadLine();
                    switch (operacion)
                    {
                        case "+":
                            resultado = num1 + num2;
                            Console.WriteLine($"Su resultado es: {resultado}");
                            break;
                        case "-":
                            resultado = num1 - num2;
                            Console.WriteLine($"Su resultado es: {resultado}");
                            break;
                        case "*":
                            resultado = num1 * num2;
                            Console.WriteLine($"Su resultado es: {resultado}");
                            break;
                        case "/":
                            if (num2 != 0)
                            {
                                resultado = num1 / num2;
                                Console.WriteLine($"Su resultado es: {resultado}");
                            }
                            else
                            {
                                Console.WriteLine("ERROR...\nNo se puede dividir entre 0");
                            }
                            break;
                        case "":
                            Console.WriteLine("...Gracias...");
                            a = false;
                            break;
                        default:
                            Console.WriteLine("Operacion no valida\nIntente nuevamente");
                            break;
                    }

                } while (a);
            }
            catch
            {
                Console.WriteLine("ERROR. Intente nuevamente");

            }
            ;
        }
        static double Revisar()
        {
            while (true)
            {
                if (double.TryParse(Console.ReadLine(), out double num))
                {
                    return num;
                    break;
                }
                else
                {
                    Console.WriteLine("No se permiten letras, intentelo nuevamente...");
                }
            }
        }
    }
}
