// Crear una cola de números enteros
Queue<int> colaDeNumeros = new Queue<int>();
// Operación Enqueue: agregar elementos
colaDeNumeros.Enqueue(10);
colaDeNumeros.Enqueue(20);
colaDeNumeros.Enqueue(30);
// Mostrar el primer elemento en la cola (Peek)
Console.WriteLine($"Primer elemento en la cola: {colaDeNumeros.Peek()}"); // Muestra 10
// Operación Dequeue: quitar el primer elemento
Console.WriteLine($"Elemento removido: {colaDeNumeros.Dequeue()}"); // Muestra 10
// Volver a mostrar el primer elemento en la cola
Console.WriteLine($"Nuevo primer elemento en la cola: {colaDeNumeros.Peek()}"); // Muestra 20
// Convertir la cola en un arreglo
int[] elementos2 = colaDeNumeros.ToArray();
// Optimizar el uso de memoria recortando la capacidad de la cola
colaDeNumeros.TrimExcess();
// Vaciar la cola
colaDeNumeros.Clear();

Console.ReadKey();
Console.Clear();

Console.WriteLine("""
    Ejercicio 1: Crear una cola de enteros
    • Creamos una cola de 5 enteros.
    • Usemos los métodos Enqueue() para agregar elementos y Dequeue() para eliminarlos.
    • Mostremos el contenido de la cola después de cada operación.
    ________________________________________
""");
Queue<int> intQueue = new Queue<int>();
intQueue.Enqueue(10);
Console.WriteLine("Elemento agregado: 10");
intQueue.Enqueue(20);
Console.WriteLine("Elemento agregado: 20");
intQueue.Enqueue(30);
Console.WriteLine("Elemento agregado: 30");
intQueue.Enqueue(40);
Console.WriteLine("Elemento agregado: 40");
intQueue.Enqueue(50);
Console.WriteLine("Elemento agregado: 50");
Console.WriteLine("\nCola después de Enqueue():");
foreach (var num in intQueue) Console.WriteLine(num);
intQueue.Dequeue();
Console.WriteLine("\nElemento eliminado usando Dequeue(). Cola actualizada:");
foreach (var num in intQueue) Console.WriteLine(num);
intQueue.Dequeue();
Console.WriteLine("\nElemento eliminado usando Dequeue(). Cola actualizada:");
foreach (var num in intQueue) Console.WriteLine(num);
Console.ReadKey();
Console.Clear();

Console.WriteLine("""
    Ejercicio 2: Simular una fila de personas
    • Creamos una cola que simule una fila de personas en una tienda.
    • Cada vez que una persona es atendida, eliminamos a la persona del frente de la cola usando Dequeue().
    • Mostramos cuántas personas quedan en la fila usando Count.
    ________________________________________
""");
Queue<string> peopleQueue = new Queue<string>();
peopleQueue.Enqueue("Juan");
peopleQueue.Enqueue("Pedro");
peopleQueue.Enqueue("María");
peopleQueue.Enqueue("Laura");
peopleQueue.Enqueue("Lucas");
Console.WriteLine("\nFila de personas en la tienda:");
foreach (var person in peopleQueue) Console.WriteLine(person);
peopleQueue.Dequeue();
Console.WriteLine($"\nPersona atendida. Quedan {peopleQueue.Count} personas en la fila.");
peopleQueue.Dequeue();
Console.WriteLine($"\nPersona atendida. Quedan {peopleQueue.Count} personas en la fila.");
Console.ReadKey();
Console.Clear();

Console.WriteLine("""
    Ejercicio 3: Convertir una cola a un arreglo
    • Creamos una cola de 5 cadenas de texto.
    • Usamos ToArray() para convertir la cola en un arreglo y mostramos los elementos del arreglo.
    ________________________________________
""");
Queue<string> textQueue = new Queue<string>();
textQueue.Enqueue("Uno");
textQueue.Enqueue("Dos");
textQueue.Enqueue("Tres");
textQueue.Enqueue("Cuatro");
textQueue.Enqueue("Cinco");
string[] queueArray = textQueue.ToArray();
Console.WriteLine("\nCola convertida a arreglo:");
foreach (var element in queueArray) Console.WriteLine(element);
Console.ReadKey();
Console.Clear();

Console.WriteLine("""
    Ejercicio 4: Verificar si un elemento está en la cola
    • Creamos una cola de enteros con 6 valores.
    • Permitimos que el usuario ingrese un número.
    • Verificamos si el número ingresado está en la cola usando Contains() y mostramos el resultado.
    ________________________________________
""");
Queue<int> intQueue2 = new Queue<int>(new int[] { 1, 2, 3, 4, 5, 6 });
Console.Write("Ingrese un número para verificar si está en la cola: ");
int userInput2 = int.Parse(Console.ReadLine());
if (intQueue2.Contains(userInput2)) Console.WriteLine($"{userInput2} está presente en la cola.");
else Console.WriteLine($"{userInput2} no está presente en la cola.");
Console.ReadKey();
Console.Clear();
