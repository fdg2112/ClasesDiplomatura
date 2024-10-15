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
    1.1.Escribe un programa que lea la distancia recorrida por un vehículo
    y la unidad de medida utilizada, y luego imprima estos datos.
    """);
Console.Write("Ingrese la distancia recorrida: ");
float distance = float.Parse(Console.ReadLine());
Console.Write("Ingrese Metros, Millas, Kilometros: ");
string? measure = Console.ReadLine();
Console.WriteLine($"La distancia ingresada fue: {distance} {measure}");
Console.ReadKey();
Console.Clear();

Console.WriteLine("""
    1.2.Escribe un programa que lea la temperatura en grados Celsius 
    y la convierta a grados Fahrenheit.
    """);
Console.Write("Ingrese la temperatura en Cº: ");
float tempC = float.Parse(Console.ReadLine());
float tempF = (tempC * 1.8f) + 32;
Console.WriteLine($"La temperatura en FCº es: {tempF}");
Console.ReadKey();
Console.Clear();

Console.WriteLine("""
    1.3.Escribe un programa que lea el número de horas trabajadas por un empleado en una semana
    y el tipo de turno (diurno o nocturno). Luego, imprima estos datos.
    """);
Console.Write("Ingrese la cantidad de horas hechas: ");
int hours = int.Parse(Console.ReadLine());
Console.Write("Indique si fueron Diurnas o Nocturnas: ");
string? shift = Console.ReadLine();
Console.WriteLine($"Se trabajaron: {hours} horas {shift}");
Console.ReadKey();
Console.Clear();

Console.WriteLine("""
    1.4.Escribe un programa que lea tres números enteros y calcule su promedio.
    """);
Console.Write("Ingrese el primer numero: ");
int number1 = int.Parse(Console.ReadLine());
Console.Write("Ingrese el segundo numero: ");
int number2 = int.Parse(Console.ReadLine());
Console.Write("Ingrese el tercer numero: ");
int number3 = int.Parse(Console.ReadLine());
float average = (number1 +  number2 + number3)/3;
Console.WriteLine($"El promedio es: {average}");
Console.ReadKey();
Console.Clear();

Console.WriteLine("""
    1.5.Escribe un programa que calcule la hipotenusa de un triángulo rectángulo.
    """);
Console.Write("Ingrese la longitud del primer cateto: ");
float cath1 = float.Parse(Console.ReadLine());
Console.Write("Ingrese la longitud del segundo cateto: ");
float cath2 = float.Parse(Console.ReadLine());
float hypo = (float)Math.Sqrt((cath1 * cath1) + (cath2 * cath2));
Console.WriteLine($"La hipotenusa es: {hypo}");
Console.ReadKey();
Console.Clear();

Console.WriteLine("""
    1.6.Escribe un programa que declare una variable booleana.
    Informar el estado inicial, y después cambiarlo y mostrar el otro.
    """);
bool booleanVar = true;
Console.WriteLine($"El estado inicial es: {booleanVar}");
booleanVar = false;
Console.WriteLine($"El nuevo estado es: {booleanVar}");
Console.ReadKey();
Console.Clear();

Console.WriteLine("""
    1.7.Escribe un programa lea los datos de un juguete: 
    nombre, descripción, cantidad en stock y precio.
    """);
Console.Write("Ingrese el nombre del juguete: ");
string? toyName = Console.ReadLine();
Console.Write("Ingrese la descripción del juguete: ");
string? toyDescription = Console.ReadLine();
Console.Write("Ingrese la cantidad en stock: ");
int stockQuantity = int.Parse(Console.ReadLine());
Console.Write("Ingrese el precio del juguete: ");
float toyPrice = float.Parse(Console.ReadLine());
Console.WriteLine($"Juguete: {toyName}, Descripción: {toyDescription}, Stock: {stockQuantity}, Precio: {toyPrice}");
Console.ReadKey();
Console.Clear();

Console.WriteLine("""
    1.8.Escribe un programa lea la altura de caída de un objeto y calcule la velocidad
    al tocar el suelo.La gravedad se debe inicializar en 9,8. (v = sqrt(2*g*h)) 
    """);
Console.Write("Ingrese la altura de caída (en metros): ");
float fallHeight = float.Parse(Console.ReadLine());
const float GRAVITY = 9.8f;
float velocity = (float)Math.Sqrt(2 * GRAVITY * fallHeight);
Console.WriteLine($"La velocidad al tocar el suelo es: {velocity} m/s");
Console.ReadKey();
Console.Clear();

Console.WriteLine("""
    1.9.Escribe un programa que guarde cadenas en una variable, 
    que esta contenga la palabra “hola” y la muestre.
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
    1.10.Escribe un programa que declare una variable booleana para dos estados: “ON” y “OFF”.
    Se debe inicializar en verdadera, informar “ON”, y después cambiarla por falsa y mostrar “OFF”.
    """);
bool isActive = true;
Console.WriteLine($"Variable en ON: {isActive}");
isActive = false;
Console.WriteLine($"Variable en OFF: {isActive}");
//bool isActive = true;
//Console.WriteLine($"Estado inicial: {(isActive ? "ON" : "OFF")}");
//isActive = false;
//Console.WriteLine($"Estado después de cambiar: {(isActive ? "ON" : "OFF")}");
Console.ReadKey();
Console.Clear();