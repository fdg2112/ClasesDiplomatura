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

//Console.WriteLine("""
//1.1 Escribe un programa que lea la distancia recorrida por un vehículo
//y la unidad de medida utilizada, y luego imprima estos datos.
//""");
//try
//{
//    Console.Write("Ingrese la distancia recorrida: ");
//    string? inputDistance = Console.ReadLine();
//    if (string.IsNullOrWhiteSpace(inputDistance)) throw new ArgumentNullException();
//    float distance = float.Parse(inputDistance);
//    if (distance < 0) throw new ArgumentOutOfRangeException("distance", "La distancia no puede ser un número negativo.");
//    else if (distance > 100000000) throw new ArgumentOutOfRangeException("", "La distancia es demasiado grande.");
//    Console.Write("Ingrese Metros, Millas, Kilómetros: ");
//    string? measure = Console.ReadLine();
//    if (!string.IsNullOrWhiteSpace(measure)) Console.WriteLine($"La distancia ingresada fue: {distance} {measure}");
//    else Console.WriteLine("Debe especificar la unidad de distancia");
//}
//catch (ArgumentNullException)
//{
//    Console.WriteLine("Error: No se ingresó ningún valor para la distancia.");
//}
//catch (FormatException)
//{
//    Console.WriteLine("Error: La distancia ingresada no es un número válido.");
//}
//catch (ArgumentOutOfRangeException ex)
//{
//    Console.WriteLine($"Error: El número ingresado está fuera de los parámetros especificados. {ex.Message}");
//}
//catch (Exception ex)
//{
//    Console.WriteLine($"Ocurrió un error inesperado: {ex.Message}");
//}

//Console.WriteLine("""
//1.2. Escribe un programa que lea la temperatura en grados Celsius 
//y la convierta a grados Fahrenheit.
//""");
//try
//{
//    Console.Write("Ingrese la temperatura en Cº: ");
//    string? inputTempC = Console.ReadLine();
//    if (string.IsNullOrWhiteSpace(inputTempC)) throw new ArgumentNullException();
//    float tempC = float.Parse(inputTempC);
//    if (tempC < -273.15f) throw new ArgumentOutOfRangeException("", "La temperatura no puede ser menor al cero absoluto (-273.15 ºC).");
//    //al "parsear" el inputTempC en tempC si el valor supera la capacidad del float
//    //lo convierte en "infinito" pero sigue en formato float
//    else if (float.IsInfinity(tempC)) throw new OverflowException();
//    float tempF = (tempC * 1.8f) + 32;
//    Console.WriteLine($"La temperatura en Fº es: {tempF}");
//}
//catch (FormatException)
//{
//    Console.WriteLine("Error: La temperatura ingresada no es un número válido.");
//}
//catch (ArgumentOutOfRangeException ex)
//{
//    Console.WriteLine($"Error: {ex.Message}");
//}
//catch (ArgumentNullException)
//{
//    Console.WriteLine("Error: No se ingresó ningún valor para la temperatura.");
//}
//catch (Exception ex)
//{
//    Console.WriteLine($"Ocurrió un error inesperado: {ex.Message}");
//}


//Console.WriteLine("""
//2.1. Escribe un programa que lea la edad de una persona 
//e imprima "Mayor de edad" si la persona tiene 18 años o más.
//""");

//try
//{
//    Console.Write("Ingrese su edad: ");
//    string? inputAge = Console.ReadLine();
//    if (string.IsNullOrWhiteSpace(inputAge)) throw new ArgumentNullException();
//    int age = int.Parse(inputAge);
//    if (age < 0) throw new ArgumentOutOfRangeException("age", "La edad no puede ser negativa.");
//    if (age >= 18) Console.WriteLine("Mayor de edad");
//    else Console.WriteLine("Menor de edad");
//}
//catch (FormatException)
//{
//    Console.WriteLine("Error: La edad ingresada no es un número entero válido.");
//}
//catch (OverflowException)
//{
//    Console.WriteLine("Error: El número ingresado excede el rango permitido para enteros.");
//}
//catch (ArgumentOutOfRangeException ex)
//{
//    Console.WriteLine($"Error: {ex.Message}");
//}
//catch (ArgumentNullException)
//{
//    Console.WriteLine("No se ingresó ningún valor.");
//}
//catch (Exception ex)
//{
//    Console.WriteLine($"Ocurrió un error inesperado: {ex.Message}");
//}


//Console.WriteLine("""
//2.6. Escribe un programa que lea un número entero y determine si es par o impar.
//""");

//try
//{
//    Console.Write("Ingrese un número entero: ");
//    string? inputNumber = Console.ReadLine();
//    if (string.IsNullOrWhiteSpace(inputNumber)) throw new ArgumentNullException();
//    int intNumber = int.Parse(inputNumber);
//    if (intNumber % 2 == 0) Console.WriteLine("El número es par.");
//    else Console.WriteLine("El número es impar.");
//}
//catch (FormatException)
//{
//    Console.WriteLine("Error: El valor ingresado no es un número entero válido.");
//}
//catch (OverflowException)
//{
//    Console.WriteLine("Error: El número ingresado excede el rango permitido para enteros.");
//}
//catch (ArgumentNullException)
//{
//    Console.WriteLine("No se ingresó ningún valor.");
//}
//catch (Exception ex)
//{
//    Console.WriteLine($"Ocurrió un error inesperado: {ex.Message}");
//}

//3.9. Escribe un programa que determine si una letra es una vocal mayúscula.
//Console.WriteLine("""
//Ingrese una letra (A, E, I, O, U):
//""");
//try
//{
//    Console.Write("Ingrese una letra: ");
//    char inputChar = Console.ReadKey().KeyChar;
//    Console.WriteLine();
//    if (!char.IsLetter(inputChar)) throw new ArgumentException("El carácter ingresado no es una letra válida.");
//    if ("AEIOU".Contains(inputChar)) Console.WriteLine("Es una vocal mayúscula.");
//    else Console.WriteLine("No es una vocal mayúscula.");
//}
//catch (ArgumentException ex)
//{
//    Console.WriteLine($"Error: {ex.Message}");
//}
//catch (Exception ex)
//{
//    Console.WriteLine($"Ocurrió un error inesperado: {ex.Message}");
//}

//Console.WriteLine("""
//3.12. Escribe un programa que determine si una persona no es menor de edad.
//Considerar que la edad de una persona puede estar entre 1 y 130.
//Sino indicar que la edad ingresada no es coherente.
//""");
//try
//{
//    Console.Write("Ingrese su edad: ");
//    string? inputAge = Console.ReadLine();
//    if (string.IsNullOrWhiteSpace(inputAge)) throw new ArgumentNullException();
//    int age = int.Parse(inputAge);
//    if (age < 1 || age > 130) throw new ArgumentOutOfRangeException();
//    if (age >= 18) Console.WriteLine("No es menor de edad.");
//    else Console.WriteLine("Es menor de edad.");
//}
//catch (FormatException)
//{
//    Console.WriteLine("Error: La edad ingresada no es un número entero válido.");
//}
//catch (OverflowException)
//{
//    Console.WriteLine("Error: El número ingresado excede el rango permitido para enteros.");
//}
//catch (ArgumentNullException)
//{
//    Console.WriteLine("No se ingresó ningún valor.");
//}
//catch (ArgumentOutOfRangeException)
//{
//    Console.WriteLine("La edad ingresada no es coherente.");
//}
//catch (Exception ex)
//{
//    Console.WriteLine($"Ocurrió un error inesperado: {ex.Message}");
//}

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

//try
//{
//    Console.WriteLine("Determinar si el año es biciesto");
//    Console.Write("Indique el año: ");
//    string? input = Console.ReadLine();
//    if (string.IsNullOrWhiteSpace(input))
//    {
//        throw new ArgumentNullException();
//    }
//    int year = int.Parse(input);
//    if (year < 0 || year > 9999) // Ajustar el rango a gusto
//    {
//        throw new ArgumentOutOfRangeException();
//    }
//    if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
//        Console.WriteLine("Es un año bisiesto");
//    else
//        Console.WriteLine("No es un año bisiesto");
//    Console.ReadKey();
//    Console.Clear();
//}
//catch (ArgumentNullException)
//{
//    Console.WriteLine("La entrada no puede estar vacía.");
//}
//catch (ArgumentOutOfRangeException)
//{
//    Console.WriteLine("El año debe estar entre 0 y 9999.");
//}
//catch (OverflowException)
//{
//    Console.WriteLine("El número excede la capacidad del tipo de dato entero.");
//}
//catch (FormatException)
//{
//    Console.WriteLine("La entrada debe ser un número entero.");
//}
//catch (Exception ex)
//{
//    Console.WriteLine($"Ocurrió un error inesperado: {ex.Message}");
//}

//Console.WriteLine("""
//4.15. Escribe un programa que permita leer tres valores y
//almacenarlos en las variables A, B y C respectivamente.
//El algoritmo debe imprimir cuál es el mayor y cuál es el menor.
//""");

//try
//{
//    Console.Write("Ingrese el primer valor (A): ");
//    string? inputA = Console.ReadLine();
//    if (string.IsNullOrWhiteSpace(inputA)) throw new ArgumentNullException("A", "No se ingresó ningún valor en A.");
//    int a = int.Parse(inputA);
//    Console.Write("Ingrese el segundo valor (B): ");
//    string? inputB = Console.ReadLine();
//    if (string.IsNullOrWhiteSpace(inputB)) throw new ArgumentNullException("B", "No se ingresó ningún valor en B.");
//    int b = int.Parse(inputB);
//    Console.Write("Ingrese el tercer valor (C): ");
//    string? inputC = Console.ReadLine();
//    if (string.IsNullOrWhiteSpace(inputC)) throw new ArgumentNullException("C", "No se ingresó ningún valor en C.");
//    int c = int.Parse(inputC);

//    // Determinamos el mayor
//    if (a > b && a > c)
//        Console.WriteLine($"El mayor es: {a}");
//    else if (b > a && b > c)
//        Console.WriteLine($"El mayor es: {b}");
//    else
//        Console.WriteLine($"El mayor es: {c}");

//    // Determinamos el menor
//    if (a < b && a < c)
//        Console.WriteLine($"El menor es: {a}");
//    else if (b < a && b < c)
//        Console.WriteLine($"El menor es: {b}");
//    else
//        Console.WriteLine($"El menor es: {c}");
//}
//catch (FormatException)
//{
//    Console.WriteLine("Error: Uno de los valores ingresados no es un número entero válido.");
//}
//catch (OverflowException)
//{
//    Console.WriteLine("Error: Uno de los números ingresados excede el rango permitido para enteros.");
//}
//catch (ArgumentNullException ex)
//{
//    Console.WriteLine($"Error: {ex.Message}");
//}
//catch (Exception ex)
//{
//    Console.WriteLine($"Ocurrió un error inesperado: {ex.Message}");
//}

//5.5.Escribe un programa que imprima la suma de los números ingresados,
//pero sólo de los impares. Cuando se ingrese uno par, el programa debe parar
//y mostrar el resultado.
//try
//{
//    int number = 0;
//    int sum = 0;
//    Console.Write("Ingrese un número: ");
//    while (true) // Bucle infinito hasta que se ingrese un número par
//    {
//        string? inputNumber = Console.ReadLine();
//        if (string.IsNullOrWhiteSpace(inputNumber))
//            throw new ArgumentNullException("El valor ingresado no puede estar vacío.");
//        number = int.Parse(inputNumber);
//        if (number % 2 == 0) // Si el número es par, salimos del bucle
//            break;
//        sum += number; // Solo sumamos si el número es impar
//        Console.Write("Ingrese un número: ");
//    }
//    Console.WriteLine($"La suma de los números impares es: {sum}");
//}
//catch (FormatException)
//{
//    Console.WriteLine("Error: El valor ingresado no es un número entero válido.");
//}
//catch (OverflowException)
//{
//    Console.WriteLine("Error: El número ingresado excede el rango permitido para enteros.");
//}
//catch (ArgumentNullException ex)
//{
//    Console.WriteLine($"Error: {ex.Message}");
//}
//catch (Exception ex)
//{
//    Console.WriteLine($"Ocurrió un error inesperado: {ex.Message}");
//}

//Console.WriteLine("""
//5.9. Escribe un programa que multiplique los números ingresados.
//Debe preguntar si desea ingresar un número y correr hasta ingresar “no”.
//(Tomar en cuenta mayúsculas y minúsculas).
//""");

//int number = 0;
//int product = 1;
//string? response = "";

//try
//{
//    while (true) // Bucle infinito hasta que el usuario ingrese "no"
//    {
//        Console.Write("¿Desea ingresar un número (si/no)? ");
//        response = Console.ReadLine();

//        if (response?.ToLower() == "no") // Verifica si el usuario ingresa "no"
//            break;

//        if (response?.ToLower() != "si") // Solo aceptamos "si" o "no"
//        {
//            Console.WriteLine("Por favor, ingrese 'si' o 'no'.");
//            continue; // Vuelve a preguntar si no se ingresa una respuesta válida
//        }

//        Console.Write("Ingrese un número: ");

//        string? inputNumber = Console.ReadLine();
//        if (string.IsNullOrWhiteSpace(inputNumber))
//            throw new ArgumentNullException("El valor ingresado no puede estar vacío.");

//        number = int.Parse(inputNumber);
//        product *= number;
//    }

//    Console.WriteLine($"El producto de los números ingresados es: {product}");
//}
//catch (FormatException)
//{
//    Console.WriteLine("Error: El valor ingresado no es un número entero válido.");
//}
//catch (OverflowException)
//{
//    Console.WriteLine("Error: El número ingresado excede el rango permitido para enteros.");
//}
//catch (ArgumentNullException ex)
//{
//    Console.WriteLine($"Error: {ex.Message}");
//}
//catch (Exception ex)
//{
//    Console.WriteLine($"Ocurrió un error inesperado: {ex.Message}");
//}
