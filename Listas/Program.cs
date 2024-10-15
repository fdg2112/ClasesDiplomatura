
using System.Collections.Generic;
// Crear una lista de enteros
List<int> listaNumeros = new List<int>();

// Operación Add: agregar elementos
listaNumeros.Add(10);
listaNumeros.Add(20);
listaNumeros.Add(30);

// Mostrar los elementos de la lista y su indice
Console.WriteLine("Elementos en la lista:");
foreach (int numero in listaNumeros) Console.WriteLine($"Elemento: {numero}, índice: {listaNumeros.IndexOf(numero)}");

// Buscar un elemento en la lista
if (listaNumeros.Contains(20)) Console.WriteLine("El número 20 está en la lista.");

// Eliminar un elemento de la lista
listaNumeros.Remove(20);
Console.WriteLine("Elementos después de eliminar 20:");
foreach (int numero in listaNumeros) Console.WriteLine($"Elemento: {numero}, índice: {listaNumeros.IndexOf(numero)}");

// Insertar elemento
listaNumeros.Insert(1, 40);
Console.WriteLine("Elementos después de insertar 40 en el índice 1:");
foreach (int numero in listaNumeros) Console.WriteLine($"Elemento: {numero}, índice: {listaNumeros.IndexOf(numero)}");

Console.WriteLine("""
    Ejercicio 1: Agregar y eliminar elementos
    • Crear una lista de enteros que permita agregar y eliminar números.
    • Mostrar los números en la lista después de cada operación.
    ________________________________________
""");
List<int> intList = new List<int>();
intList.Add(5);
Console.WriteLine("Número agregado: 5");
intList.Add(10);
Console.WriteLine("Número agregado: 10");
intList.Add(15);
Console.WriteLine("Número agregado: 15");
Console.WriteLine("\nLista después de agregar elementos:");
foreach (var num in intList) Console.WriteLine(num);
intList.Remove(10);
Console.WriteLine("\nNúmero eliminado: 10");
Console.WriteLine("\nLista después de eliminar el número:");
foreach (var num in intList) Console.WriteLine(num);
Console.ReadKey();
Console.Clear();

Console.WriteLine("""
    Ejercicio 2: Buscar en la lista
    • Crear una lista de palabras.
    • Permitir que el usuario busque una palabra en la lista y mostrar si se encuentra o no.
    ________________________________________
""");
List<string> wordList = new List<string> { "manzana", "banana", "pera", "uva", "naranja" };
Console.WriteLine("Lista de palabras: manzana, banana, pera, uva, naranja");
Console.Write("Ingrese una palabra para buscar: ");
string wordSearch = Console.ReadLine();
if (wordList.Contains(wordSearch)) Console.WriteLine($"La palabra '{wordSearch}' se encuentra en la lista.");
else Console.WriteLine($"La palabra '{wordSearch}' no se encuentra en la lista.");
Console.ReadKey();
Console.Clear();

Console.WriteLine("""
    Ejercicio 3: Concatenar dos listas
    • Crear dos listas de números.
    • Concatenar las dos listas en una sola y mostrar el resultado.
    ________________________________________
""");
List<int> firstList = new List<int> { 1, 2, 3 };
List<int> secondList = new List<int> { 4, 5, 6 };
List<int> combinedList = firstList.Concat(secondList).ToList();
Console.WriteLine("Lista combinada:");
foreach (var num in combinedList) Console.WriteLine(num);
Console.ReadKey();
Console.Clear();

Console.WriteLine("""
    Ejercicio 4: Ordenar una lista
    • Crear una lista de enteros y ordenar los elementos de menor a mayor.
    ________________________________________
""");
List<int> unsortedList = new List<int> { 7, 1, 5, 3, 9 };
unsortedList.Sort();
Console.WriteLine("Lista ordenada de menor a mayor:");
foreach (var num in unsortedList) Console.WriteLine(num);
Console.ReadKey();
Console.Clear();

Console.WriteLine("""
    Ejercicio 5: Revertir una lista
    • Crear una lista de palabras y revertir el orden de los elementos en la lista.
    ________________________________________
""");
List<string> words = new List<string> { "rojo", "verde", "azul", "amarillo" };
words.Reverse();
Console.WriteLine("Lista de palabras en orden inverso:");
foreach (var word in words) Console.WriteLine(word);
Console.ReadKey();
Console.Clear();

