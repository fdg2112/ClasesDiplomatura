
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



