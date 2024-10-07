// -------- Ejercicios de la guía --------

// 2.1. Escribe un programa que lea la edad de una persona e imprima "Mayor de edad" si la persona tiene 18 años o más.
Console.Write("Ingrese su edad: ");
int age = int.Parse(Console.ReadLine());
if (age >= 18) Console.WriteLine("Mayor de edad");
Console.ReadKey();
Console.Clear();

//2.2.	Escribe un programa que lea la cantidad de una distancia recorrida y la unidad de medida.
//Si la distancia es mayor a 0 se debe mostrar “Se recorrió” y ambos datos. Sino informar de distancia incorrecta.
Console.Write("Ingrese la distancia recorrida: ");
float distance = float.Parse(Console.ReadLine());
Console.Write("Ingrese la unidad de medida: ");
string? unit = Console.ReadLine();
if (distance >= 0) Console.WriteLine($"Se recorrió {distance} {unit}.");
else Console.WriteLine("La distancia ingresada es inchoerente");
Console.ReadKey();
Console.Clear();

// 2.3. Escribe un programa que lea un número y determine si es positivo.
Console.Write("Ingrese un número: ");
int number = int.Parse(Console.ReadLine());
if (number > 0) Console.WriteLine("El número es positivo.");
else Console.WriteLine("El número no es positivo.");
Console.ReadKey();
Console.Clear();

// 2.4. Escribe un programa que lea una temperatura en grados Celsius y determine si es mayor a 25.
Console.Write("Ingrese la temperatura en Cº: ");
float tempC = float.Parse(Console.ReadLine());
if (tempC > 25) Console.WriteLine("Hace calor");
else Console.WriteLine("Hace frío");
Console.ReadKey();
Console.Clear();

// 2.5. Escribe un programa que lea la nota de un examen y determine si el estudiante aprobó.
Console.Write("Ingrese la nota del examen: ");
float grade = float.Parse(Console.ReadLine());
if (grade >= 6) Console.WriteLine("Aprobó");
else Console.WriteLine("Reprobó");
Console.ReadKey();
Console.Clear();

// 2.6. Escribe un programa que lea un número entero y determine si es par o impar.
Console.Write("Ingrese un número entero: ");
int intNumber = int.Parse(Console.ReadLine());
if (intNumber % 2 == 0) Console.WriteLine("El número es par.");
else Console.WriteLine("El número es impar.");
Console.ReadKey();
Console.Clear();

// 2.7.	Escribe un programa que lea el salario mensual de una persona
// y determine si debe pagar impuestos (salario mayor a $400.000).
// Además, debe imprimir el mensaje "Salario alto" si el salario es mayor o igual a $700.000,
// en caso contrario mostrar “Salario bajo”.
Console.Write("Ingrese su salario mensual: ");
float salary = float.Parse(Console.ReadLine());
if (salary > 400000) Console.WriteLine("Debe pagar impuestos.");
if (salary >= 700000) Console.WriteLine("Salario alto");
else Console.WriteLine("Salario bajo");
Console.ReadKey();
Console.Clear();

// 2.8.	Escribe un programa que lea si un empleado está habilitado para hacer horas extras.
// Si lo está, imprimir el mensaje “Habilitado para extras”,
// en caso contrario que imprima “No habilitado para extras”.
// Además, debe leer la cantidad de horas trabajadas en una semana y determine si tiene horas extras
// (se considera si tiene más de 40 horas) imprimir el mensaje “Tiene horas extras”,
// en caso contrario imprimir “No tiene horas extras”.
Console.Write("¿Está habilitado para hacer horas extras? (sí/no): ");
string? isEnabled = Console.ReadLine();
if (isEnabled?.ToLower() == "sí") Console.WriteLine("Habilitado para extras");
else Console.WriteLine("No habilitado para extras.");
Console.Write("Ingrese la cantidad de horas trabajadas en la semana: ");
int hoursWorked = int.Parse(Console.ReadLine());
if (hoursWorked > 40) Console.WriteLine("Tiene horas extras.");
else Console.WriteLine("No tiene horas extras.");
Console.ReadKey();
Console.Clear();

// 2.9.	Escribe un programa que lea la calificación de un estudiante y determine
// si está aprobado o no (si la calificación mayor o igual a 60).
// Además, debe imprimir si está “Regular” o “Libre” (el límite es hasta 5 faltas).
Console.Write("Ingrese la calificación: ");
float qualification = float.Parse(Console.ReadLine());
if (qualification >= 60) Console.WriteLine("Aprobado");
else Console.WriteLine("No aprobado");
float attendance = float.Parse(Console.ReadLine());
if (attendance > 5) Console.WriteLine("El alumno quedó Libre");
else Console.WriteLine("El alumno está en condición Regular");
Console.ReadKey();
Console.Clear();

// 2.10. Escribe un programa que lea el precio de un producto y determine si es caro (precio mayor a 100).
// Además, debe imprimir "En oferta" si el precio es menor a 50.
Console.Write("Ingrese el precio del producto: ");
float productPrice = float.Parse(Console.ReadLine());
if (productPrice > 100) Console.WriteLine("Es caro.");
if (productPrice < 50) Console.WriteLine("En oferta.");
Console.ReadKey();
Console.Clear();

// 2.11. Escribe un programa que lea la velocidad de un vehículo y determine
// si está excediendo el límite de velocidad (mayor a 120 km/h) imprimiendo el mensaje “Exceso de Velocidad”.
// Además, debe imprimir "Velocidad baja" si la velocidad es menor a 20 km/h.
Console.Write("Ingrese la velocidad del vehículo (km/h): ");
float vehicleSpeed = float.Parse(Console.ReadLine());
if (vehicleSpeed > 120) Console.WriteLine("Exceso de Velocidad.");
if (vehicleSpeed < 20) Console.WriteLine("Velocidad baja.");
Console.ReadKey();
Console.Clear();

// 2.12. Escribe un programa que pida ingresar un caracter y determine si la letra es “a” o no.
Console.Write("Ingrese un caracter: ");
char character = Console.ReadKey().KeyChar;
Console.WriteLine();
if (character == 'a') Console.WriteLine("Es la letra 'a'.");
else Console.WriteLine("No es la letra 'a'.");
Console.ReadKey();
Console.Clear();

// 2.13. Escribe un programa que pida ingresar una palabra y determine si es "hola" o no.
Console.Write("Ingrese una palabra: ");
string? word = Console.ReadLine();
if (word == "hola") Console.WriteLine("La palabra es 'hola'.");
else Console.WriteLine("La palabra no es 'hola'.");
Console.ReadKey();
Console.Clear();

// 2.14. Escribe un programa que active un switch ingresando la palabra “ON” y lo apague con “OFF”.
Console.Write("Ingrese ON para activar o OFF para desactivar: ");
string? switchState = Console.ReadLine();
if (switchState.ToUpper() == "ON") Console.WriteLine("El switch está activado.");
if (switchState.ToUpper() == "OFF") Console.WriteLine("El switch está desactivado.");
Console.ReadKey();
Console.Clear();

// 2.15. Escribe un programa que muestre el precio de un producto con o sin IVA que vale $1000,
// indicando si es “CON” o “SIN” para mostrarlo.
float price = 1000;
Console.Write("¿Mostrar precio CON IVA o SIN IVA? (CON/SIN): ");
string? priceType = Console.ReadLine();
if (priceType?.ToUpper() == "CON")
{
    float priceWithIVA = price * 1.21f;
    Console.WriteLine($"El precio CON IVA es: {priceWithIVA}");
}
else Console.WriteLine($"El precio SIN IVA es: {price}");
Console.ReadKey();
Console.Clear();

// 2.16. Escribe un programa que indique ingresar un caracter y determine si la letra es “a”, muestre “Es la “a” minúscula”.
// Si la letra es “e”, muestre “Es la “e” minúscula”. Si la letra es “i”, muestre “Es la “i” minúscula”.
// Si la letra es “o”, muestre “Es la “o” minúscula”. Si la letra es “u”, muestre “Es la “u” minúscula”.
// Si la letra es “A”, muestre “Es la “A” mayúscula”. Si la letra es “E”, muestre “Es la “E” mayúscula”.
// Si la letra es “I”, muestre “Es la “I” mayúscula”. Si la letra es “O”, muestre “Es la “O” mayúscula”.
// Si la letra es “U”, muestre “Es la “U” mayúscula”.
Console.Write("Ingrese un caracter: ");
char inputChar = Console.ReadKey().KeyChar;
Console.WriteLine();
if (inputChar == 'a') Console.WriteLine("Es la 'a' minúscula.");
if (inputChar == 'e') Console.WriteLine("Es la 'e' minúscula.");
if (inputChar == 'i') Console.WriteLine("Es la 'i' minúscula.");
if (inputChar == 'o') Console.WriteLine("Es la 'o' minúscula.");
if (inputChar == 'u') Console.WriteLine("Es la 'u' minúscula.");
if (inputChar == 'A') Console.WriteLine("Es la 'A' mayúscula.");
if (inputChar == 'E') Console.WriteLine("Es la 'E' mayúscula.");
if (inputChar == 'I') Console.WriteLine("Es la 'I' mayúscula.");
if (inputChar == 'O') Console.WriteLine("Es la 'O' mayúscula.");
if (inputChar == 'U') Console.WriteLine("Es la 'U' mayúscula.");
Console.ReadKey();
Console.Clear();

