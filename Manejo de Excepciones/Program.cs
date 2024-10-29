//Console.WriteLine("Inicio del programa.");
//int a = 10;
//int b = 5;
//int suma = Sumar(a, b);
//Console.WriteLine("Resultado de la suma: " + suma);
//int resta = Restar(a, b);
//Console.WriteLine("Resultado de la resta: " + resta);
//Console.WriteLine("Fin del programa.");
//static int Sumar(int x, int y)
//{
//    return x + y;
//}
//static int Restar(int x, int y)
//{
//    return x - y;
//}

//try
//{
//    string entrada = "abc";
//    int numero = int.Parse(entrada);
//    Console.WriteLine("Se ingresó: " + numero);
//}
//catch (Exception ex)
//{
//    Console.WriteLine($"Ocurrió una excepción: {ex.Message}");
//    Console.WriteLine($"Detalles: {ex.StackTrace}");
//}

//try
//{
//    // Se solicita al usuario que ingrese dos números
//    Console.Write("Ingrese el primer número: ");
//    int num1 = int.Parse(Console.ReadLine());

//    Console.Write("Ingrese el segundo número: ");
//    int num2 = int.Parse(Console.ReadLine());

//    // Se intenta realizar la división
//    int resultado = num1 / num2;
//    Console.WriteLine("El resultado de la división es: " + resultado);
//}
//catch (Exception ex) // Captura cualquier tipo de excepción
//{
//    // Se muestra un mensaje de error genérico
//    Console.WriteLine("Ocurrió un error: " + ex.Message);
//}

//static void AbrirArchivo(string ruta) { /* implementación aquí */ }
//static void ModificarArchivo(string ruta)
//{
//    // Simula la modificación del archivo
//    throw new FileLoadException();
//}
//static void CerrarArchivo(string ruta) { /* implementación aquí */ }

//string rutaArchivo = @"C:\Users\Franco\Documentos\Archivo.txt"; // Usar el prefijo @ para rutas literales
//try
//{
//    Console.WriteLine("Intentando abrir el archivo...");
//    AbrirArchivo(rutaArchivo);
//    Console.WriteLine("Intentando modificar el archivo...");
//    ModificarArchivo(rutaArchivo);
//}
//catch (Exception ex)
//{
//    Console.WriteLine($"Ocurrió un error: {ex.Message}");
//}
//finally
//{
//    Console.WriteLine("Cerrando el archivo...");
//    CerrarArchivo(rutaArchivo);
//}
//Console.WriteLine("Proceso finalizado.");

//try
//{
//    string entrada = Console.ReadLine();
//    int numero = int.Parse(entrada);  // Lanza FormatException
//}
//catch (FormatException ex)
//{
//    Console.WriteLine($"Error: {ex.Message}");
//}

//try
//{
//    int divisor = 0;
//    int resultado = 10 / divisor;  // Lanza DivideByZeroException
//}
//catch (DivideByZeroException ex)
//{
//    Console.WriteLine($"Error: {ex.Message}");
//}

//try
//{
//    void ImprimirMensaje(string? mensaje)
//    {
//        if (mensaje == null) throw new ArgumentNullException();
//        Console.WriteLine(mensaje);
//    }

//    ImprimirMensaje(null);  // Lanza ArgumentNullException
//}
//catch (ArgumentNullException ex)
//{
//    Console.WriteLine($"Error: {ex.Message}");
//}


//// Función que simula el retiro de dinero
//static void RetirarDinero(ref decimal saldo, decimal cantidad)
//{
//    if (cantidad > saldo)
//    {
//        throw new InsufficientFundsException(); // Lanza la excepción si no hay fondos suficientes
//    }
//    else
//    {
//        saldo = saldo - cantidad;
//    }
//}

//// Código principal donde se usa la función y se maneja la excepción
//decimal saldo = 180000; // Saldo inicial
//try
//{
//    RetirarDinero(ref saldo, 150000); // Intentar retirar $150.000
//}
//catch (InsufficientFundsException ex)
//{
//    Console.WriteLine($"Error: {ex.Message}"); // Muestra: "Error: Fondos insuficientes para realizar la operación."
//    Console.WriteLine($"Saldo actual: {saldo}");
//}

//// Definición de la excepción personalizada
//public class InsufficientFundsException : Exception
//{
//    public InsufficientFundsException() : base("Fondos insuficientes para realizar la operación.") { }
//}


// Ejercicios

//1.1, 1.2, 2.1, 2.6, 3.9, 3.12, 4.12, 4.15, 5.5, 5.9, 6.8, 6.14, 7.13, 7.17, 8.6 y 8.8


//4.12.	Escribe un programa que lea un año y determine si es bisiesto.
//Un año es bisiesto si es divisible por 4, pero no por 100,
//excepto que también sea divisible por 400
//Console.Write("Indique el año: ");
//if (int.TryParse(Console.ReadLine(), out int year1))
//{
//    if ((year1 % 4 == 0 && year1 % 100 != 0) || year1 % 400 == 0) Console.WriteLine("Es un año bisiesto");
//    else Console.WriteLine("No es un año bisiesto");
//}
//else Console.WriteLine("No se pudo convertir el número");
//Console.ReadKey();
//Console.Clear();

try
{
    Console.Write("Indique el año: ");
    string? input = Console.ReadLine();
    if (string.IsNullOrWhiteSpace(input))
    {
        throw new ArgumentNullException();
    }
    int year = int.Parse(input);
    if (year < 0 || year > 9999) // Ajustar el rango a gusto
    {
        throw new ArgumentOutOfRangeException();
    }
    if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
        Console.WriteLine("Es un año bisiesto");
    else
        Console.WriteLine("No es un año bisiesto");
    Console.ReadKey();
    Console.Clear();
}
catch (ArgumentNullException)
{
    Console.WriteLine("La entrada no puede estar vacía.");
}
catch (ArgumentOutOfRangeException)
{
    Console.WriteLine("El año debe estar entre 0 y 9999.");
}
catch (OverflowException)
{
    Console.WriteLine("El número excede la capacidad del tipo de dato entero.");
}
catch (FormatException)
{
    Console.WriteLine("La entrada debe ser un número entero.");
}
catch (Exception ex)
{
    Console.WriteLine($"Ocurrió un error inesperado: {ex.Message}");
}


