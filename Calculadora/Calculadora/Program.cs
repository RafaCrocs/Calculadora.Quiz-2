namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora");
            Console.WriteLine("Ingrese el primer número:");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo número:");
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Seleccione la operación (+, -, *, /):");
            string operacion = Console.ReadLine();
            double resultado = 0;
            switch (operacion)
            {
                case "+":
                    resultado = num1 + num2;
                    break;
                case "-":
                    resultado = num1 - num2;
                    break;
                case "*":
                    resultado = num1 * num2;
                    break;
                case "/":
                    if (num2 != 0)
                    {
                        resultado = num1 / num2;
                    }
                    else
                    {
                        Console.WriteLine("ERROR. División por cero no permitida.");
                        return;
                    }
                    break;
                default:
                    Console.WriteLine("Operación no válida.");
                    return;
                Console.WriteLine("El resultado es: " + resultado);
                Console.WriteLine("Gracias... ¡Hasta luego!");
            }
        }
    }
}
