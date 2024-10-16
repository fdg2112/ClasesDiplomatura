//-----------Ejercicios en Clase----------
//Declarar variables
string? name = "Franco";
string? lastname = "Gonzalez";
byte age = 34;
float height = 1.80f;
char gender = 'M';
bool isEmployed = true;
Console.WriteLine($"Nombre: {name} {lastname}");
Console.WriteLine($"Edad: {age}");
Console.WriteLine($"Altura: {height}");
Console.WriteLine($"Género: {gender}");
Console.WriteLine($"Empleado: {isEmployed}");
Console.ReadKey();
Console.Clear();

//Operadores
const byte NUM1 = 2;
const int NUM2 = 21;
const double NUM3 = 5.53;
float result = 0f;
Console.WriteLine($"NUM1: {NUM1}, NUM2: {NUM2}, NUM3: {NUM3}");
//Sumar los tres números.
result = NUM1 + NUM2 + (float)NUM3;
Console.WriteLine($"Suma de NUM1, NUM2 y NUM3: {result}");
//Restar a NUM1, NUM2 y NUM3.
result = NUM1 - NUM2 - (float)NUM3;
Console.WriteLine($"Resta de NUM1, NUM2 y NUM3: {result}");
//Multiplicar NUM1 por NUM3.
result = NUM1 * (float)NUM3;
Console.WriteLine($"Producto de NUM1 y NUM3: {result}");
//Dividir NUM2 por NUM1.
result = (float)NUM2 / NUM1;
Console.WriteLine($"División de NUM2 por NUM1: {result}");
//Obtener el módulo de NUM2 dividido por NUM3.
result = (float)(NUM2 % NUM3);
Console.WriteLine($"Módulo de NUM2 dividido por NUM3: {result}");
//Restar al resultado del producto de NUM2 y NUM3, el módulo de NUM2 por NUM3.
double product = NUM2 * NUM3;
double module = NUM2 % NUM3;
double final_result = product - module;
Console.WriteLine($"Resultado final: {final_result}");

Console.ReadKey();
Console.Clear();

//Operadores lógicos
int A = 1;
int B = 2;
int C = 3;
int D = 1;
Console.WriteLine($"A: {A}, B: {B}, C: {C}, D: {D}");
//Si A es igual a B, a C o a D. 
bool condition1 = (A == B || A == C || A == D);
Console.WriteLine($"A es igual a B, C o D: {condition1}");
//Si A es distinto a B, a C y a D. 
bool condition2 = (A != B && A != C && A != D);
Console.WriteLine($"A es distinto a B, C y D: {condition2}");
//Si B es mayor o igual C o A igual a D.
bool condition3 = (B >= C || A == D);
Console.WriteLine($"B es mayor o igual a C o A es igual a D: {condition3}");
//Si B es mayor o igual C y A igual a D.
bool condition4 = (B >= C && A == D);
Console.WriteLine($"B es mayor o igual a C y A es igual a D: {condition4}");
//Si C es distinto a D y A menor a B o A mayor a C y D menor a B
bool condition5 = ((C != D && A < B) || (A > C && D < B));
Console.WriteLine($"C es distinto a D y A menor a B o A mayor a C y D menor a B: {condition5}");
//Si C es distinto a D o A menor a B y A mayor a C o D menor a B
bool condition6 = (C != D || (A < B && A > C) || D < B);
Console.WriteLine($"C es distinto a D o A menor a B y A mayor a C o D menor a B: {condition6}");
//Si C es distinto a D y A menor a B o Si A mayor a C y D menor a B
bool condition7 = ((C != D && A < B) || (A > C && D < B));
Console.WriteLine($"C es distinto a D y A menor a B o A mayor a C y D menor a B: {condition7}");
Console.ReadKey();
Console.Clear();

// -------- Ejercicios de la guía --------
Console.WriteLine("""
    1.1. Escribe un programa que lea la distancia recorrida por un vehículo
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
Console.ReadKey();
Console.Clear();

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
Console.ReadKey();
Console.Clear();

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
Console.ReadKey();
Console.Clear();

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
Console.ReadKey();
Console.Clear();

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
Console.ReadKey();
Console.Clear();

Console.WriteLine("""
    1.6. Escribe un programa que declare una variable booleana.
    Informar el estado inicial, y después cambiarlo y mostrar el otro.
    """);
bool booleanVar = true;
Console.WriteLine($"El estado inicial es: {booleanVar}");
booleanVar = !booleanVar;
Console.WriteLine($"El nuevo estado es: {booleanVar}");
Console.ReadKey();
Console.Clear();

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
Console.ReadKey();
Console.Clear();

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
Console.ReadKey();
Console.Clear();

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
Console.ReadKey();
Console.Clear();

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
Console.ReadKey();