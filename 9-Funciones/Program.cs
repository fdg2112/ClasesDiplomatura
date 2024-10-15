//8.1.Crea un procedimiento que reciba un número entero
//y determine si es par o impar, imprimiendo el resultado.
void CheckEvenOrOdd(int number)
{
    if (number % 2 == 0) Console.WriteLine($"{number} es par.");
    else if (number % 2 != 0) Console.WriteLine($"{number} es impar.");
    else Console.WriteLine("El cero no es par ni impar");
}
Console.Write("Ingrese un número entero: ");
int number = int.Parse(Console.ReadLine());
CheckEvenOrOdd(number);
Console.ReadKey();
Console.Clear();

//8.2.Crea un procedimiento que reciba una lista de números
//y cuente cuántos son positivos y cuántos son negativos, imprimiendo los totales.
void CountPositivesAndNegatives(int totalNumbers)
{
    int positiveCount = 0;
    int negativeCount = 0;
    for (int i = 0; i < totalNumbers; i++)
    {
        Console.Write($"Enter number {i + 1}: ");
        int number = int.Parse(Console.ReadLine());

        if (number > 0) positiveCount++;
        else if (number < 0) negativeCount++;
    }
    Console.WriteLine($"Total positive numbers: {positiveCount}");
    Console.WriteLine($"Total negative numbers: {negativeCount}");
}

//8.3.Crea un procedimiento que reciba un número
//y genere todos los números primos menores o iguales a ese número, imprimiéndolos.
void PrintPrimes(int number)
{
    for (int i = 2; i <= number; i++)
    {
        bool isPrime = true; // Asumimos que 'i' es primo inicialmente.
        for (int j = 2; j <= Math.Sqrt(i); j++) // Este Bucle es para verificar divisores desde 2 
        {                                       // hasta la raíz cuadrada de 'i'.
            if (i % j == 0) // Comprobamos si 'i' es divisible por 'j'.
                isPrime = false; // Si es divisible, no es primo.
        }
        if (isPrime) // Si sigue siendo primo después de verificar divisores...
            Console.WriteLine(i); // Imprimimos 'i' como un número primo.
    }
}

//8.4.Crea un procedimiento que reciba un número entero
//y calcule su factorial, imprimiendo el resultado.
void CalculateFactorial(int number)
{
    int factorial = 1;
    for (int i = 2; i <= number; i++) factorial *= i;

    Console.WriteLine($"El factorial de {number} es: {factorial}");
}
Console.Write("Ingrese un número entero: ");
number = int.Parse(Console.ReadLine());
CalculateFactorial(number);
Console.ReadKey();
Console.Clear();


//8.5.Crea un procedimiento que reciba un número entero,
//entre 1 y 50, y que dibuje un triángulo de asteriscos de esa altura.
void DrawTriangle(int height)
{
    if (height < 1 || height > 50)
    {
        Console.WriteLine("El número debe estar entre 1 y 50.");
        return;
    }
    for (int i = 1; i <= height; i++)
    {
        for (int j = 1; j <= i; j++)
        {
            Console.Write("*");
        }
        Console.WriteLine();
    }
}
Console.Write("Ingrese la altura del triángulo (entre 1 y 50): ");
int height = int.Parse(Console.ReadLine());
DrawTriangle(height);
Console.ReadKey();
Console.Clear();

//8.6.Crea una función que reciba cinco números enteros.
//Deben acumularse y al final multiplicarse por el primero y dividirse por el último.
int AccumulateMultiplyDivide()
{
    int number, result = 0, firstNumber = 0, lastNumber = 0;
    Console.WriteLine("Ingrese 5 números...");
    for (int i = 1; i <= 5; i++)
    {
        Console.Write($"Ingrese el {i}º: ");
        number = int.Parse(Console.ReadLine());
        if (i == 1) firstNumber = number;
        if (i == 5) lastNumber = number;
        result += number;
    }
    result *= firstNumber;
    result /= lastNumber;
    return result;
}
int finalResult = AccumulateMultiplyDivide();
Console.WriteLine($"El resultado de la operación es: {finalResult}");
Console.ReadKey();
Console.Clear();

//8.7.Crea una función que reciba un número entero X
//y devuelva los primeros N números de la serie de Fibonacci.
//(F n = F n – 2 + F n – 1 donde n ≥ 2.)
void Fibonacci(int n)
{
    int a = 0, b = 1, next;
    Console.WriteLine($"Fibonacci 0: {a}");
    if (n > 1) Console.WriteLine($"Fibonacci 1: {b}");
    for (int i = 2; i < n; i++) // Generamos los siguientes números de la serie
    {
        next = a + b; // Suma de los dos anteriores
        Console.WriteLine($"Fibonacci {i}: {next}");
        a = b; // Actualizamos los valores
        b = next;
    }
}
Console.Write("Ingrese la cantidad de numeros de la secuencia de Fibonnaci a mostrar: ");
int num = int.Parse(Console.ReadLine());
Fibonacci(num);

//8.8.Crea una función que reciba una lista de números
//y devuelva el promedio de los mismos.
double CalculateAverage(int totalNumbers)
{
    double sum = 0;
    for (int i = 0; i < totalNumbers; i++)
    {
        Console.Write($"Enter number {i + 1}: ");
        int number = int.Parse(Console.ReadLine());
        sum += number;
    }

    return sum / totalNumbers;
}
Console.Write("Ingrese la cantidad de numeros para obtener su promedio: ");
int quantity = int.Parse(Console.ReadLine());
CalculateAverage(quantity);

