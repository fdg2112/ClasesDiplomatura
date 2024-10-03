//3.1. Escribe un programa que pida ingresar un número
//y determine si un número está en el rango de 10 a 20 inclusive.
Console.Write("Ingrese un número: ");
int number = int.Parse(Console.ReadLine());
if (number >= 10 && number <= 20) Console.WriteLine("El número está en el rango de 10 a 20.");

//3.2. Escribe un programa que pida ingresar "bien" o "mal"
//para indicar como está un ejercicio corregido. Debe mostrarse “El ejercicio está” y el estado,
//sólo si se ingresó una de estas dos. (Considerar variantes en mayúsculas y minúsculas).
Console.Write("¿Cómo está el ejercicio corregido? (bien/mal): ");
string? correction = Console.ReadLine().ToLower();
if (correction == "bien" || correction == "mal") Console.WriteLine($"El ejercicio está {correction}.");

//3.3. Escribe un programa que determine si una persona es adolescente (entre 13 y 19 años).
Console.Write("Ingrese su edad: ");
int age = int.Parse(Console.ReadLine());
if (age >= 13 && age <= 19) Console.WriteLine("Es adolescente.");

//3.4. Escribe un programa que determine si una letra es una vocal.
Console.Write("Ingrese una letra: ");
char inputChar = Console.ReadKey().KeyChar;
Console.WriteLine();
if (inputChar == 'a' || inputChar == 'e' || inputChar == 'i' || inputChar == 'o' || inputChar == 'u' ||
    inputChar == 'A' || inputChar == 'E' || inputChar == 'I' || inputChar == 'O' || inputChar == 'U') Console.WriteLine("Es una vocal.");

//3.5. Escribe un programa que determine si un número es par y mayor a 10 mostrar
//“Es par y mayor a 10” o si es impar y mayor a 10 “Es impar y mayor a 10”.
//Sino mostrar “No es mayor a 10”.
Console.Write("Ingrese un número: ");
int num = int.Parse(Console.ReadLine());
if (num % 2 == 0 && num > 10) Console.WriteLine("Es par y mayor a 10.");
if (num % 2 != 0 && num > 10) Console.WriteLine("Es impar y mayor a 10.");
if (num < 10) Console.WriteLine("No es mayor a 10.");

//3.6. Escribe un programa que pida ingresar una letra y determine si es mayúscula.
Console.Write("Ingrese una letra: ");
inputChar = Console.ReadKey().KeyChar;
Console.WriteLine();
if (inputChar == 'A' || inputChar == 'B' || inputChar == 'C' || inputChar == 'D' || inputChar == 'E' ||
    inputChar == 'F' || inputChar == 'G' || inputChar == 'H' || inputChar == 'I' || inputChar == 'J' ||
    inputChar == 'K' || inputChar == 'L' || inputChar == 'M' || inputChar == 'N' || inputChar == 'O' ||
    inputChar == 'P' || inputChar == 'Q' || inputChar == 'R' || inputChar == 'S' || inputChar == 'T' ||
    inputChar == 'U' || inputChar == 'V' || inputChar == 'W' || inputChar == 'X' || inputChar == 'Y' ||
    inputChar == 'Z' || inputChar == 'Ñ') Console.WriteLine("Es una letra mayúscula.");
//if (char.IsUpper(inputChar)) Console.WriteLine("Es una letra mayúscula.");

//3.7. Escribe un programa que determine si un número es impar y menor a 10.
Console.Write("Ingrese un número: ");
num = int.Parse(Console.ReadLine());
if (num % 2 != 0 && num < 10) Console.WriteLine("Es impar y menor a 10.");

//3.8. Escribe un programa que determine si una persona es mayor de edad y no es jubilada (menos de 65 años).
Console.Write("Ingrese su edad: ");
age = int.Parse(Console.ReadLine());
if (age >= 18 && age < 65) Console.WriteLine("Es mayor de edad y no es jubilado.");

//3.9. Escribe un programa que determine si una letra es una vocal mayúscula.
Console.Write("Ingrese una letra: ");
inputChar = Console.ReadKey().KeyChar;
Console.WriteLine();
if (inputChar == 'A' || inputChar == 'E' || inputChar == 'I' || inputChar == 'O' || inputChar == 'U') Console.WriteLine("Es una vocal mayúscula.");


//3.10.	Escribe un programa que determine si un número no es par y positivo.
Console.Write("Ingrese un número: ");
num = int.Parse(Console.ReadLine());
if (num % 2 != 0 && num > 0) Console.WriteLine("El número no es par y es positivo.");

//3.11.	Escribe un programa que determine si una persona no es apta para donar sangre.
//Debe ser mayor de 18 años y pesar más de 50 kg.
Console.Write("Ingrese su edad: ");
age = int.Parse(Console.ReadLine());
Console.Write("Ingrese su peso (kg): ");
float weight = float.Parse(Console.ReadLine());
if (age < 18 || weight <= 50) Console.WriteLine("No es apta para donar sangre.");

//3.12.	Escribe un programa que determine si una persona no es menor de edad.
//Considerar que la edad de una persona puede estar entre 1 y 130.
//Sino indicar que la edad ingresada no es coherente.
Console.Write("Ingrese su edad: ");
age = int.Parse(Console.ReadLine());
if (age >= 18 && age <= 130) Console.WriteLine("No es menor de edad.");
else Console.WriteLine("La edad ingresada no es coherente.");

//3.13.	Escribe un programa que determine si un estudiante aprobó una materia.
//La nota debe ser mayor a 60, y además debe tener una asistencia mayor al 75%.
Console.Write("Ingrese la nota del estudiante: ");
int grade = int.Parse(Console.ReadLine());
Console.Write("Ingrese el porcentaje de asistencia: ");
int attendance = int.Parse(Console.ReadLine());
if (grade > 60 && attendance > 75) Console.WriteLine("El estudiante aprobó.");

//3.14.	Escribe un programa que determine si el caracter ingresado es un número.
Console.Write("Ingrese un caracter: ");
inputChar = Console.ReadKey().KeyChar;
Console.WriteLine();
if (inputChar == '0' || inputChar == '1' || inputChar == '2' || inputChar == '3' || inputChar == '4' ||
    inputChar == '5' || inputChar == '6' || inputChar == '7' || inputChar == '8' || inputChar == '9') Console.WriteLine("El caracter es un número.");
//if (char.IsDigit(inputChar)) Console.WriteLine("El caracter es un número.");

//3.15.	Escribe un programa que determine si el caracter ingresado es un número o un símbolo.
Console.Write("Ingrese un caracter: ");
inputChar = Console.ReadKey().KeyChar;
Console.WriteLine();
char.ToUpper(inputChar);
if (!(inputChar == 'A' || inputChar == 'B' || inputChar == 'C' || inputChar == 'D' || inputChar == 'E' ||
    inputChar == 'F' || inputChar == 'G' || inputChar == 'H' || inputChar == 'I' || inputChar == 'J' ||
    inputChar == 'K' || inputChar == 'L' || inputChar == 'M' || inputChar == 'N' || inputChar == 'O' ||
    inputChar == 'P' || inputChar == 'Q' || inputChar == 'R' || inputChar == 'S' || inputChar == 'T' ||
    inputChar == 'U' || inputChar == 'V' || inputChar == 'W' || inputChar == 'X' || inputChar == 'Y' ||
    inputChar == 'Z' || inputChar == 'Ñ') && (inputChar == '0' || inputChar == '1' || inputChar == '2' || 
    inputChar == '3' || inputChar == '4' || inputChar == '5' || inputChar == '6' || inputChar == '7' || 
    inputChar == '8' || inputChar == '9')) Console.WriteLine("El caracter es un número o un símbolo.");
//if (char.IsDigit(inputChar) || !char.IsinputCharOrDigit(inputChar)) Console.WriteLine("El caracter es un número o un símbolo.");

//3.16.	Escribe un programa que lea dos caracteres, debe indicar si ambos son números, o ambos son caracteres.
Console.Write("Ingrese el primer caracter: ");
char char1 = Console.ReadKey().KeyChar;
Console.WriteLine();
Console.Write("Ingrese el segundo caracter: ");
char char2 = Console.ReadKey().KeyChar;
Console.WriteLine();
if (char.IsDigit(char1) && char.IsDigit(char2)) Console.WriteLine("Ambos caracteres son números.");
if (char.IsLetter(char1) && char.IsLetter(char2)) Console.WriteLine("Ambos caracteres son letras.");

//3.17.	Escribe un programa que indique ingresar un caracter y determine si es una vocal
//y si es mayúscula o minúscula. Debe mostrar el mensaje “Es la vocal” seguido por el caracter ingresado,
//seguido por “mayúscula.” o “minúscula.” según el caso.
Console.Write("Ingrese una vocal: ");
inputChar = Console.ReadKey().KeyChar;
Console.WriteLine();
if (inputChar == 'A' || inputChar == 'E' || inputChar == 'I' || inputChar == 'O' || inputChar == 'U') Console.WriteLine($"Es la vocal {inputChar} mayúscula");
if (inputChar == 'a' || inputChar == 'e' || inputChar == 'i' || inputChar == 'o' || inputChar == 'u') Console.WriteLine($"Es la vocal {inputChar} minúscula");

//3.18.	Escribir un programa que pida ingresar tres números. Indicar si los 3 son impares.
Console.Write("Ingrese el primer número: ");
int num1 = int.Parse(Console.ReadLine());
Console.Write("Ingrese el segundo número: ");
int num2 = int.Parse(Console.ReadLine());
Console.Write("Ingrese el tercer número: ");
int num3 = int.Parse(Console.ReadLine());
if (num1 % 2 != 0 && num2 % 2 != 0 && num3 % 2 != 0) Console.WriteLine("Los 3 números son impares.");

//3.19.	Escribir un programa que pida ingresar tres números. Indicar si al menos uno es par.
Console.Write("Ingrese el primer número: ");
num1 = int.Parse(Console.ReadLine());
Console.Write("Ingrese el segundo número: ");
num2 = int.Parse(Console.ReadLine());
Console.Write("Ingrese el tercer número: ");
num3 = int.Parse(Console.ReadLine());
if (num1 % 2 == 0 || num2 % 2 == 0 || num3 % 2 == 0) Console.WriteLine("Al menos uno de los numeros ingresados es par.");

//3.20.	Escribir un programa que pida ingresar tres números. Indicar si hay al menos 2 impares y 1 par o viceversa.
Console.Write("Ingrese el primer número: ");
num1 = int.Parse(Console.ReadLine());
Console.Write("Ingrese el segundo número: ");
num2 = int.Parse(Console.ReadLine());
Console.Write("Ingrese el tercer número: ");
num3 = int.Parse(Console.ReadLine());
int count1 = 0, count2 = 0;
if (num1 % 2 == 0) count1++; else count2++;
if (num2 % 2 == 0) count1++; else count2++;
if (num3 % 2 == 0) count1++; else count2++;
if (count1 == 2 && count2 == 1 || count1 == 1 && count2 == 2) Console.WriteLine("Hay al menos 2 impares y 1 par o viceversa.");


