//1 Escribir un programa que solicite al usuario un número del 1 al 12
//e imprima el nombre del mes del año correspondiente.
//Por ejemplo, si el usuario ingresa 3, el programa debería mostrar “Marzo".
Console.Write("Ingrese un número del 1 al 12 para indicar el mes: ");
int month = int.Parse(Console.ReadLine());
switch (month)
{
    case 1:
        Console.WriteLine("Enero");
        break;
    case 2:
        Console.WriteLine("Febrero");
        break;
    case 3:
        Console.WriteLine("Marzo");
        break;
    case 4:
        Console.WriteLine("Abril");
        break;
    case 5:
        Console.WriteLine("Mayo");
        break;
    case 6:
        Console.WriteLine("Junio");
        break;
    case 7:
        Console.WriteLine("Julio");
        break;
    case 8:
        Console.WriteLine("Agosto");
        break;
    case 9:
        Console.WriteLine("Septiembre");
        break;
    case 10:
        Console.WriteLine("Octubre");
        break;
    case 11:
        Console.WriteLine("Noviembre");
        break;
    case 12:
        Console.WriteLine("Diciembre");
        break;
    default:
        Console.WriteLine("Número inválido");
        break;
}
Console.ReadKey();
Console.Clear();

//2 Crear un programa que reciba una nota del 1 al 10 y clasifique la nota
//como "Insuficiente", “Regular", "Bueno", "Muy Bueno“, “Sobresaliente” o "Excelente".
Console.Write("Ingrese una nota del 1 al 10: ");
int grade = int.Parse(Console.ReadLine());
switch (grade)
{
    case 1:
    case 2:
    case 3:
        Console.WriteLine("Insuficiente");
        break;
    case 4:
    case 5:
        Console.WriteLine("Regular");
        break;
    case 6:
    case 7:
        Console.WriteLine("Bueno");
        break;
    case 8:
        Console.WriteLine("Muy Bueno");
        break;
    case 9:
        Console.WriteLine("Sobresaliente");
        break;
    case 10:
        Console.WriteLine("Excelente");
        break;
    default:
        Console.WriteLine("Nota inválida");
        break;
}
Console.ReadKey();
Console.Clear();

//3 Pedir al usuario que ingrese dos números y un operador (+, -, *, /).
//Utilizar un switch-case para realizar la operación matemática correspondiente
//y mostrar el resultado. Por ejemplo, si el usuario
//ingresa 5, + y 3 el programa debe mostrar 8.
Console.Write("Ingrese el primer número: ");
int num1 = int.Parse(Console.ReadLine());
Console.Write("Ingrese el operador (+, -, *, /): ");
char op = Console.ReadLine()[0];
Console.Write("Ingrese el segundo número: ");
int num2 = int.Parse(Console.ReadLine());
switch (op)
{
    case '+':
        Console.WriteLine($"Resultado: {num1 + num2}");
        break;
    case '-':
        Console.WriteLine($"Resultado: {num1 - num2}");
        break;
    case '*':
        Console.WriteLine($"Resultado: {num1 * num2}");
        break;
    case '/':
        if (num2 != 0)
            Console.WriteLine($"Resultado: {num1 / num2}");
        else
            Console.WriteLine("No se puede dividir por cero");
        break;
    default:
        Console.WriteLine("Operador inválido");
        break;
}
Console.ReadKey();
Console.Clear();

//4 Solicitar al usuario que ingrese una letra. Utilizar un switch-case
//para determinar si la letra es una vocal (a, e, i, o, u) o una consonante.
Console.Write("Ingrese una letra: ");
char letter = char.Parse(Console.ReadLine().ToLower());
switch (letter)
{
    case 'a':
    case 'e':
    case 'i':
    case 'o':
    case 'u':
        Console.WriteLine("Es una vocal");
        break;
    default:
        Console.WriteLine("Es una consonante");
        break;
}
Console.ReadKey();
Console.Clear();

//5 Escribir un programa que reciba una calificación en formato de letra (A, B, C, D, F)
//e imprima un mensaje que explique lo que significa. Por ejemplo, A puede significar
//"Excelente", B "Bueno", etc.
Console.Write("Ingrese una calificación (A, B, C, D, F): ");
char gradeLetter = char.Parse(Console.ReadLine().ToUpper());
switch (gradeLetter)
{
    case 'A':
        Console.WriteLine("Excelente");
        break;
    case 'B':
        Console.WriteLine("Bueno");
        break;
    case 'C':
        Console.WriteLine("Regular");
        break;
    case 'D':
        Console.WriteLine("Insuficiente");
        break;
    case 'F':
        Console.WriteLine("Reprobado");
        break;
    default:
        Console.WriteLine("Calificación inválida");
        break;
}
Console.ReadKey();
Console.Clear();

//6 Pedir al usuario que ingrese un carácter y utilizar un switch-case
//para determinar si el carácter es un dígito (0-9), una letra, o un símbolo especial. 
Console.Write("Ingrese un carácter: ");
char character = Console.ReadKey().KeyChar;
Console.WriteLine();
switch (character)
{
    case >= '0' and <= '9':
        Console.WriteLine("Es un dígito");
        break;
    case >= 'a' and <= 'z':
    case >= 'A' and <= 'Z':
        Console.WriteLine("Es una letra");
        break;
    default:
        Console.WriteLine("Es un símbolo especial");
        break;
}

//Console.Write("Ingrese un carácter: ");
//char character = Console.ReadLine()[0];
//switch (character)
//{
//    case char c when char.IsDigit(c):
//        Console.WriteLine("Es un dígito");
//        break;
//    case char c when char.IsLetter(c):
//        Console.WriteLine("Es una letra");
//        break;
//    default:
//        Console.WriteLine("Es un símbolo especial");
//        break;
//}
Console.ReadKey();
Console.Clear();

//7 Crear un programa que solicite al usuario el nombre de un mes
//en minúsculas (por ejemplo, enero) y utilice un switch-case para imprimir
//el número correspondiente del mes (1 para enero, 2 para febrero, etc.).
Console.Write("Ingrese el nombre del mes en minúsculas: ");
string monthName = Console.ReadLine().ToLower();
switch (monthName)
{
    case "enero":
        Console.WriteLine("1");
        break;
    case "febrero":
        Console.WriteLine("2");
        break;
    case "marzo":
        Console.WriteLine("3");
        break;
    case "abril":
        Console.WriteLine("4");
        break;
    case "mayo":
        Console.WriteLine("5");
        break;
    case "junio":
        Console.WriteLine("6");
        break;
    case "julio":
        Console.WriteLine("7");
        break;
    case "agosto":
        Console.WriteLine("8");
        break;
    case "septiembre":
        Console.WriteLine("9");
        break;
    case "octubre":
        Console.WriteLine("10");
        break;
    case "noviembre":
        Console.WriteLine("11");
        break;
    case "diciembre":
        Console.WriteLine("12");
        break;
    default:
        Console.WriteLine("Mes inválido");
        break;
}
Console.ReadKey();
Console.Clear();

//8 Pedir al usuario que ingrese un comando (start, stop, pause, reset).
//Utilizar un switch-case para imprimir un mensaje correspondiente a la acción del comando.
//Por ejemplo, si el usuario ingresa start, el programa debería mostrar "Iniciando...".
Console.Write("Ingrese un comando (start, stop, pause, reset): ");
string command = Console.ReadLine().ToLower();
switch (command)
{
    case "start":
        Console.WriteLine("Iniciando...");
        break;
    case "stop":
        Console.WriteLine("Deteniendo...");
        break;
    case "pause":
        Console.WriteLine("Pausando...");
        break;
    case "reset":
        Console.WriteLine("Reiniciando...");
        break;
    default:
        Console.WriteLine("Comando inválido");
        break;
}
Console.ReadKey();
Console.Clear();

//9 Escribir un programa que reciba una cadena (string) que represente un idioma
//(español, inglés, francés, etc.) y utilice un switch-case para imprimir un saludo
//en ese idioma. Por ejemplo, si el usuario ingresa “español”, el programa debería mostrar "Hola". 
Console.Write("Ingrese un idioma (español, inglés, francés, etc.): ");
string language = Console.ReadLine().ToLower();
switch (language)
{
    case "español":
        Console.WriteLine("Hola");
        break;
    case "inglés":
        Console.WriteLine("Hello");
        break;
    case "francés":
        Console.WriteLine("Bonjour");
        break;
    case "alemán":
        Console.WriteLine("Hallo");
        break;
    case "italiano":
        Console.WriteLine("Ciao");
        break;
    default:
        Console.WriteLine("Idioma no soportado");
        break;
}
Console.ReadKey();
Console.Clear();