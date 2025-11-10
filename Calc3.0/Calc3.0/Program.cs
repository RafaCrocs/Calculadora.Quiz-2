namespace Calc3._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {

                Console.WriteLine("===CALCULADORA===\n");
                Console.WriteLine("Ingrse el primer número:");
                double num1 = PedirNumero();
                Console.WriteLine("Ingrese el segundo número:");
                double num2 = PedirNumero();
                char opcion = opciones();
                switch (opcion)
                {
                    case '+':
                        Console.WriteLine($"El resultado de la suma es: {num1 + num2}");
                        break;
                    case '-':
                        Console.WriteLine($"El resultado de la resta es: {num1 - num2}");
                        break;
                    case '*':
                        Console.WriteLine($"El resultado de la multiplicación es: {num1 * num2}");
                        break;
                    case '/':
                        if (num2 != 0)
                        {
                            Console.WriteLine($"El resultado de la división es: {Math.Round(num1 / num2, 2)}");
                        }
                        else
                        {
                            Console.WriteLine("Error... No se puede dividir por cero.");
                        }
                        break;
                }

                Console.WriteLine("¿Desea realizar otra operación? (s/n): ");
                char respuesta = Repetir();
                if (respuesta == 'n')
                {
                    break;
                }
            }
            Console.WriteLine("Gracias!!");
        }




        static double PedirNumero()
        {
            while (true)
            {
                try
                {
                    double numero = double.Parse(Console.ReadLine());
                    return numero;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Error... Por favor, ingrese un número valido.");
                }
            }
        }
        static char opciones()
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Ingrese la opcion deseada(+, -, *, /): ");
                    char opcion = char.Parse(Console.ReadLine());
                    if (opcion == '+' || opcion == '-' || opcion == '*' || opcion == '/')
                    {
                        return opcion;
                    }
                    else
                    {
                        Console.WriteLine("Opcion invalida. Por favor, ingrese una opcion valida.");

                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Opcion invalida. Por favor, ingrese una opcion valida.");
                }
            }
        }
        static char Repetir()
        {
            while (true)
            {
                try
                {
                    char respuesta = char.Parse(Console.ReadLine());
                    respuesta = char.ToLower(respuesta);
                    if (respuesta == 's' || respuesta == 'n')
                    {
                        return respuesta;
                    }
                    else
                    {
                        Console.WriteLine("Respuesta invalida. Por favor, ingrese 's' para sí o 'n' para no.");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Respuesta invalida. Por favor, ingrese 's' para sí o 'n' para no.");
                }
            }
        }
    }
}

    

