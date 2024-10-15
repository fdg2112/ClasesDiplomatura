// Crear una pila de números enteros
Stack<int> pilaDeNumeros = new Stack<int>();
// Operación Push: agregar elementos
pilaDeNumeros.Push(10);
pilaDeNumeros.Push(20);
pilaDeNumeros.Push(30);
// Mostrar el elemento superior (Peek)
Console.WriteLine($"Elemento superior: {pilaDeNumeros.Peek()}"); // Muestra 30
// Operación Pop: quitar elementos
Console.WriteLine($"Elemento removido: {pilaDeNumeros.Pop()}"); // Muestra 30
// Volver a mostrar el elemento superior
Console.WriteLine($"Nuevo elemento superior: {pilaDeNumeros.Peek()}"); // Muestra 20
// Convertir la pila en un arreglo
int[] elementos = pilaDeNumeros.ToArray();
// Optimizar el uso de memoria recortando la capacidad de la pila
pilaDeNumeros.TrimExcess();
// Vaciar la pila
pilaDeNumeros.Clear();
Console.ReadKey();
Console.Clear();

Console.WriteLine("""
    Ejercicio 1: Crear una pila de enteros
    • Declaremos una pila que almacene 5 números enteros.
    • Usemos los métodos Push() para agregar elementos y Pop() para eliminarlos.
    • Mostrar el estado de la pila después de cada operación.
    ________________________________________
""");
Stack<int> intStack = new Stack<int>();
intStack.Push(10);
Console.WriteLine("Elemento agregado: 10");
intStack.Push(20);
Console.WriteLine("Elemento agregado: 20");
intStack.Push(30);
Console.WriteLine("Elemento agregado: 30");
intStack.Push(40);
Console.WriteLine("Elemento agregado: 40");
intStack.Push(50);
Console.WriteLine("Elemento agregado: 50");
Console.WriteLine("\nPila después de Push():");
foreach (var num in intStack) Console.WriteLine(num);
intStack.Pop();
Console.WriteLine("\nElemento eliminado usando Pop(). Pila actualizada:");
foreach (var num in intStack) Console.WriteLine(num);
intStack.Pop();
Console.WriteLine("\nElemento eliminado usando Pop(). Pila actualizada:");
foreach (var num in intStack) Console.WriteLine(num);
Console.ReadKey();
Console.Clear();

Console.WriteLine("""
    Ejercicio 2: Pila de cadenas de texto
    • Creamos una pila que permita almacenar 5 palabras ingresadas por el usuario.
    • Mostramos la palabra superior usando Peek() sin eliminarla.
    • Vaciar la pila usando Pop() en un bucle hasta que esté vacía.
    ________________________________________
""");
Stack<string> wordStack = new Stack<string>();
for (int i = 0; i < 5; i++)
{
    Console.Write($"Ingrese una palabra ({i + 1}/5): ");
    string word = Console.ReadLine();
    wordStack.Push(word);
}
Console.WriteLine($"\nPalabra en la parte superior: {wordStack.Peek()}");
Console.WriteLine("\nVaciando la pila:");
while (wordStack.Count > 0)
{
    Console.WriteLine($"Elemento eliminado: {wordStack.Pop()}");
}
Console.ReadKey();
Console.Clear();

Console.WriteLine("""
    Ejercicio 3: Verificar si un elemento está en la pila
    • Creamos una pila de enteros con 6 valores.
    • Permitimos que el usuario ingrese un número.
    • Verificamos si el número ingresado está en la pila usando Contains() y mostramos el resultado.
    ________________________________________
""");
Stack<int> numStack = new Stack<int>(new int[] { 1, 2, 3, 4, 5, 6 });
Console.Write("Ingrese un número para verificar si está en la pila: ");
int userInput = int.Parse(Console.ReadLine());
if (numStack.Contains(userInput)) Console.WriteLine($"{userInput} está presente en la pila.");
else Console.WriteLine($"{userInput} no está presente en la pila.");
Console.ReadKey();
Console.Clear();

Console.WriteLine("""
    Ejercicio 4: Invertir el contenido de un arreglo
    • Dado un arreglo de enteros, usamos una pila para invertir el contenido del arreglo.
    ________________________________________
""");

int[] originalArray = { 1, 2, 3, 4, 5 };
Stack<int> reverseStack = new Stack<int>();
foreach (int num in originalArray)
    reverseStack.Push(num);
Console.WriteLine("\nArreglo invertido usando pila:");
while (reverseStack.Count > 0)
{
    Console.WriteLine(reverseStack.Pop());
}
Console.ReadKey();
Console.Clear();