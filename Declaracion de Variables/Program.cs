bool stop = false;
while (!stop)
{
    Console.Clear();
    Console.WriteLine(@"
    Ejercicios de Declaración de Variables:
    ---------------------------------------
                1 - Ejercicio 1
                2 - Ejercicio 2
                3 - Ejercicio 3
                4 - Ejercicio 4
                5 - Ejercicio 5
                6 - Ejercicio 6
                7 - Ejercicio 7
                8 - Ejercicio 8
                9 - Ejercicio 9
               10 - Ejercicio 10
    ----------------------------------------
        s o S - Para terminar el programa
    ----------------------------------------
    ");
    Console.Write("   Ingrese la opción del ejercicio a ejecutar: ");
    string? opcion = Console.ReadLine();
    if (opcion == null) opcion = "";
    switch (opcion.ToLower())
    {
        case "1":
            Console.Clear();
            Ejercicio1();
            break;
        case "2":
            Console.Clear();
            Ejercicio2();
            break;
        case "3":
            Console.Clear();
            Ejercicio3();
            break;
        case "4":
            Console.Clear();
            Ejercicio4();
            break;
        case "5":
            Console.Clear();
            Ejercicio5();
            break;
        case "6":
            Console.Clear();
            Ejercicio6();
            break;
        case "7":
            Console.Clear();
            Ejercicio7();
            break;
        case "8":
            Console.Clear();
            Ejercicio8();
            break;
        case "9":
            Console.Clear();
            Ejercicio9();
            break;
        case "10":
            Console.Clear();
            Ejercicio10();
            break;
        case "s":
            stop = true;
            break;
        default:
            Console.Clear();
            Console.WriteLine(@"
    ------------------------------------------------------------
    
        Opción incorrecta. Presione una tecla para continuar.

    ------------------------------------------------------------
    ");
            Console.ReadKey();
            break;
    }
}
Console.WriteLine(@"
                ....VOLVIENDO AL MENÚ PRINCIPAL....
    ");
Thread.Sleep(1000);

static void Ejercicio1()
{
    Console.WriteLine("""
    1.1 Escribe un programa que lea la distancia recorrida por un vehículo
    y la unidad de medida utilizada, y luego imprima estos datos.
    """);
    float distance = 0;
    string? measure;
    Console.Write("Ingrese la distancia recorrida: ");
    if (float.TryParse(Console.ReadLine(), out distance))
    {
        Console.Write("Ingrese Metros, Millas, Kilómetros: ");
        measure = Console.ReadLine();
        Console.WriteLine($"La distancia ingresada fue: {distance} {measure}");
    }
    else Console.WriteLine("Error: La distancia ingresada no es válida.");
    Console.WriteLine(@"

            ....VOLVIENDO AL MENÚ....

    ");
    Thread.Sleep(5000);
}

static void Ejercicio2()
{
    Console.WriteLine("""
    1.2. Escribe un programa que lea la temperatura en grados Celsius 
    y la convierta a grados Fahrenheit.
    """);
    float tempC = 0;
    Console.Write("Ingrese la temperatura en Cº: ");
    if (float.TryParse(Console.ReadLine(), out tempC))
    {
        float tempF = (tempC * 1.8f) + 32;
        Console.WriteLine($"La temperatura en Fº es: {tempF}");
    }
    else Console.WriteLine("Error: La temperatura ingresada no es válida.");
    Console.WriteLine(@"

            ....VOLVIENDO AL MENÚ....

    ");
    Thread.Sleep(5000);
}

static void Ejercicio3()
{
    Console.WriteLine("""
    1.3. Escribe un programa que lea el número de horas trabajadas por un empleado en una semana
    y el tipo de turno (diurno o nocturno). Luego, imprima estos datos.
    """);
    int hours = 0;
    string? shift;
    Console.Write("Ingrese la cantidad de horas trabajadas: ");
    if (int.TryParse(Console.ReadLine(), out hours))
    {
        Console.Write("Indique si fueron Diurnas o Nocturnas: ");
        shift = Console.ReadLine();
        Console.WriteLine($"Se trabajaron: {hours} horas {shift}");
    }
    else Console.WriteLine("Error: La cantidad de horas ingresada no es válida.");
    Console.WriteLine(@"
            ....SALIENDO....
    ");
    Thread.Sleep(5000);
}

static void Ejercicio4()
{
    Console.WriteLine("""
    1.4. Escribe un programa que lea tres números enteros y calcule su promedio.
    """);
    int number1 = 0, number2 = 0, number3 = 0;
    Console.Write("Ingrese el primer número: ");
    if (int.TryParse(Console.ReadLine(), out number1) &&
        int.TryParse(Console.ReadLine(), out number2) &&
        int.TryParse(Console.ReadLine(), out number3))
    {
        float average = (number1 + number2 + number3) / 3f;
        Console.WriteLine($"El promedio es: {average}");
    }
    else Console.WriteLine("Error: Uno o más números ingresados no son válidos.");
    Console.WriteLine(@"

            ....VOLVIENDO AL MENÚ....

    ");
    Thread.Sleep(5000);
}

static void Ejercicio5()
{
    Console.WriteLine("""
    1.5. Escribe un programa que calcule la hipotenusa de un triángulo rectángulo.
    """);
    float cath1 = 0, cath2 = 0;
    Console.Write("Ingrese la longitud del primer cateto: ");
    if (float.TryParse(Console.ReadLine(), out cath1))
    {
        Console.Write("Ingrese la longitud del segundo cateto: ");
        if (float.TryParse(Console.ReadLine(), out cath2))
        {
            float hypo = (float)Math.Sqrt((cath1 * cath1) + (cath2 * cath2));
            Console.WriteLine($"La hipotenusa es: {hypo}");
        }
        else Console.WriteLine("Error: La longitud del segundo cateto no es válida.");
    }
    else Console.WriteLine("Error: La longitud del primer cateto no es válida.");
    Console.WriteLine(@"

            ....VOLVIENDO AL MENÚ....

    ");
    Thread.Sleep(5000);
}

static void Ejercicio6()
{
    Console.WriteLine("""
    1.6. Escribe un programa que declare una variable booleana.
    Informar el estado inicial, y después cambiarlo y mostrar el otro.
    """);
    bool booleanVar = true;
    Console.WriteLine($"El estado inicial es: {booleanVar}");
    booleanVar = !booleanVar;
    Console.WriteLine($"El nuevo estado es: {booleanVar}");
    Console.WriteLine(@"

            ....VOLVIENDO AL MENÚ....

    ");
    Thread.Sleep(5000);
}

static void Ejercicio7()
{
    Console.WriteLine("""
    1.7. Escribe un programa que lea los datos de un juguete: 
    nombre, descripción, cantidad en stock y precio.
    """);
    string? toyName, toyDescription;
    int stockQuantity = 0;
    float toyPrice = 0;
    Console.Write("Ingrese el nombre del juguete: ");
    toyName = Console.ReadLine();
    Console.Write("Ingrese la descripción del juguete: ");
    toyDescription = Console.ReadLine();
    Console.Write("Ingrese la cantidad en stock: ");
    if (int.TryParse(Console.ReadLine(), out stockQuantity))
    {
        Console.Write("Ingrese el precio del juguete: ");
        if (float.TryParse(Console.ReadLine(), out toyPrice))
        {
            Console.WriteLine($"Juguete: {toyName}, Descripción: {toyDescription}, Stock: {stockQuantity}, Precio: {toyPrice}");
        }
        else Console.WriteLine("Error: El precio ingresado no es válido.");
    }
    else Console.WriteLine("Error: La cantidad en stock ingresada no es válida.");
    Console.WriteLine(@"

            ....VOLVIENDO AL MENÚ....

    ");
    Thread.Sleep(5000);
}

static void Ejercicio8()
{
    Console.WriteLine("""
    1.8. Escribe un programa que lea la altura de caída de un objeto y calcule la velocidad
    al tocar el suelo. La gravedad se debe inicializar en 9,8. (v = sqrt(2*g*h)) 
    """);
    float fallHeight = 0;
    const float GRAVITY = 9.8f;
    Console.Write("Ingrese la altura de caída (en metros): ");
    if (float.TryParse(Console.ReadLine(), out fallHeight))
    {
        float velocity = (float)Math.Sqrt(2 * GRAVITY * fallHeight);
        Console.WriteLine($"La velocidad al tocar el suelo es: {velocity} m/s");
    }
    else Console.WriteLine("Error: La altura ingresada no es válida.");
    Console.WriteLine(@"

            ....VOLVIENDO AL MENÚ....

    ");
    Thread.Sleep(5000);
}

static void Ejercicio9()
{
    Console.WriteLine("""
    1.9. Escribe un programa que guarde cadenas en una variable, 
    que contenga la palabra “hola” y la muestre.
    Seguido que pida ingresar otra palabra para reemplazarla y mostrarla.
    """);
    string? greeting = "hola";
    Console.WriteLine($"Palabra original: {greeting}");
    Console.Write("Ingrese otra palabra para reemplazarla: ");
    greeting = Console.ReadLine();
    Console.WriteLine($"Palabra reemplazada: {greeting}");
    Console.WriteLine(@"

            ....VOLVIENDO AL MENÚ....

    ");
    Thread.Sleep(5000);
}

static void Ejercicio10()
{
    Console.WriteLine("""
    1.10. Escribe un programa que declare una variable booleana para dos estados: “ON” y “OFF”.
    Se debe inicializar en verdadera, informar “ON”, y después cambiarla por falsa y mostrar “OFF”.
    """);
    bool isActive = true;
    Console.WriteLine($"Variable en ON: {isActive}");
    isActive = false;
    //bool isActive = true;
    //Console.WriteLine($"Estado inicial: {(isActive ? "ON" : "OFF")}");
    //isActive = false;
    //Console.WriteLine($"Estado después de cambiar: {(isActive ? "ON" : "OFF")}");
    Console.WriteLine($"Variable en OFF: {isActive}");
    Console.WriteLine(@"

            ....VOLVIENDO AL MENÚ....

    ");
    Thread.Sleep(5000);
}