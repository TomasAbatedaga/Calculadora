namespace CalculadoraSimple
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora Simple\n");

            while (true)
            {
                Console.WriteLine("Seleccione una operacion:");
                Console.WriteLine("1. Suma");
                Console.WriteLine("2. Resta");
                Console.WriteLine("3. Multiplicacion");
                Console.WriteLine("4. Division");
                Console.WriteLine("5. Salir");

                Console.Write("\nIngrese el numero correspondiente a la operacion deseada: ");

                if (!int.TryParse(Console.ReadLine(), out int opcion) || opcion < 1 || opcion > 5)
                {
                    Console.WriteLine("Opción inválida. Por favor, seleccione una opción válida.\n");
                    continue;
                }

                if (opcion == 5)
                {
                    Console.WriteLine("Saliendo de la calculadora...");
                    break;
                }

                Console.Write("Ingrese el primer número: ");
                double num1 = double.Parse(Console.ReadLine());

                Console.Write("Ingrese el segundo número: ");
                double num2 = double.Parse(Console.ReadLine());

                double resultado = 0;

                switch (opcion)
                {
                    case 1:
                        resultado = num1 + num2;
                        break;
                    case 2:
                        resultado = num1 - num2;
                        break;
                    case 3:
                        resultado = num1 * num2;
                        break;
                    case 4:
                        if (num2 == 0)
                        {
                            Console.WriteLine("Error: No se puede dividir por cero.");
                            continue;
                        }
                        resultado = num1 / num2;
                        break;
                }

                Console.WriteLine($"El resultado es: {resultado}\n");
            }
        }
    }
}