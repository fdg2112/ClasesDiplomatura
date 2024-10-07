//7.BUCLE PARA
//7.1.	Imprimir números del 1 al 50 que sean múltiplos de 3 y 5.
for (int number = 1; number <= 50; number++)
{
    if (number % 3 == 0 && number % 5 == 0)
        Console.WriteLine($"{number} es múltiplo de 3 y 5.");
}
Console.ReadKey();
Console.Clear();

//7.2.	Contar cuántos números del 1 al 30 son divisibles por 2 o 3.
int count = 0;
for (int number = 1; number <= 30; number++)
{
    if (number % 2 == 0 || number % 3 == 0) count++;
}
Console.WriteLine($"Hay {count} números divisibles por 2 o 3 entre 1 y 30.");
Console.ReadKey();
Console.Clear();

//7.3.	Sumar números del 1 al 50, excluyendo aquellos divisibles por 7.
int sum = 0;
for (int number = 1; number <= 50; number++)
{
    if (number % 7 != 0) sum += number;
}
Console.WriteLine($"La suma de los números del 1 al 50, excluyendo los divisibles por 7, es: {sum}");
Console.ReadKey();
Console.Clear();

//7.4.	Imprimir la suma entre 1 y X cantidad de números.
sum = 0;
Console.Write("Ingrese un valor para X: ");
int x = int.Parse(Console.ReadLine());
for (int number = 1; number <= x; number++)
{
    sum += number;
}
Console.WriteLine($"La suma de los números del 1 al {x} es: {sum}");
Console.ReadKey();
Console.Clear();

//7.5.	Escribe un programa que pida ingresar 10 letras y
//que imprima las vocales cuando son ingresadas.
for (int i = 1; i <= 10; i++)
{
    Console.Write($"Ingrese la letra {i}: ");
    char letter = char.Parse(Console.ReadLine());
    if ("aeiouAEIOU".Contains(letter))
        Console.WriteLine($"Vocal ingresada: {letter}");
}
Console.ReadKey();
Console.Clear();

//7.6.	Escribe un programa que pida ingresar 5 números y que sume sólo los pares.
sum = 0;
for (int i = 1; i <= 5; i++)
{
    Console.Write($"Ingrese el número {i}: ");
    int number = int.Parse(Console.ReadLine());
    if (number % 2 == 0) sum += number;
}
Console.WriteLine($"La suma de los números pares es: {sum}");
Console.ReadKey();
Console.Clear();

//7.7.	Sumar los números impares hasta X y mostrar el resultado.
sum = 0;
Console.Write("Ingrese un valor para X: ");
x = int.Parse(Console.ReadLine());
for (int number = 1; number <= x; number++)
{
    if (number % 2 != 0) sum += number;
}
Console.WriteLine($"La suma de los números impares hasta {x} es: {sum}");
Console.ReadKey();
Console.Clear();

//7.8.	Contar los impares entre 1 y X cantidad de números y mostrar los resultados.
count = 0;
Console.Write("Ingrese un valor para X: ");
x = int.Parse(Console.ReadLine());
for (int number = 1; number <= x; number++)
{
    if (number % 2 != 0) count++;
}
Console.WriteLine($"Hay {count} números impares entre 1 y {x}.");
Console.ReadKey();
Console.Clear();

//7.9.	Calcular el factorial de N y mostrar el resultado.
Console.Write("Ingrese un número para calcular su factorial: ");
int n = int.Parse(Console.ReadLine());
int factorial = 1;
for (int i = 1; i <= n; i++)
{
    factorial *= i;
}
Console.WriteLine($"El factorial de {n} es: {factorial}");
Console.ReadKey();
Console.Clear();

//7.10.	Mostrar los números primos en un rango de números determinado por el usuario.
Console.Write("Ingrese el límite inferior: ");
int lowerLimit = int.Parse(Console.ReadLine());
Console.Write("Ingrese el límite superior: ");
int upperLimit = int.Parse(Console.ReadLine());
Console.WriteLine($"Números primos entre {lowerLimit} y {upperLimit}:");
for (int number = lowerLimit; number <= upperLimit; number++)
{
    bool isPrime = true;
    for (int i = 2; i <= Math.Sqrt(number); i++)
    {
        if (number % i == 0)
        {
            isPrime = false;
            break;
        }
    }
    if (isPrime && number > 1) Console.WriteLine(number);
}
Console.ReadKey();
Console.Clear();


//7.11.	Contar los números pares en un rango de números determinado por el usuario.


//7.12.	Encontrar y mostrar los primeros 15 números primos de 100.


//7.13.	Escribe un programa que pida ingresar 10 números y que sume sólo los pares.
//Si son impares debe restarlos. Mostrar los resultados, indicando
//cuantos pares e impares se ingresaron.


//7.14.	Escribir un programa que pida ingresar una cantidad de letras
//determinadas por el usuario. Contar cada vocal y mostrar al final.


//7.15.	Escribe un programa que pida un número y luego imprima
//todos los números impares desde 1 hasta ese número.


//7.16.	Escribe un programa que sume 5 listados de números
//y muestre el resultado de cada uno. También debe mostrar el promedio de todos.

//7.17.	Escribe un programa que sume 5 listados de números,
//cada listado debe tener mínimamente 1 número y debe acumularse
//e indicar cuanto va acumulado. En cada listado se debe preguntar
//si desea seguir ingresando números o indicar finalizar ingresando “salir” o “s”
//(considerar alternativas de mayúsculas y minúsculas).


//7.18.	Escribe un programa que imprima la tabla de multiplicar del 1 al 10.
//Debe indicarse cada tabla.


//7.19.	Escribe un programa que arme 3 listas de 3 palabras.
//Debe indicarse el número de cada lista.


//7.20.	Escribe un programa que imprima un triángulo rectángulo de asteriscos de 5 filas.
