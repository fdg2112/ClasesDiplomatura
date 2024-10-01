

//Stack<int> pilaDeNumeros = new Stack<int>(); // Crear una pila de números enteros

//// Operación Push: agregar elementos
//pilaDeNumeros.Push(10);
//pilaDeNumeros.Push(20);
//pilaDeNumeros.Push(30);

//// Mostrar el elemento superior (Peek)
//Console.WriteLine($"Elemento superior: {pilaDeNumeros.Peek()}"); // Muestra 30

//// Operación Pop: quitar elementos
//Console.WriteLine($"Elemento removido: {pilaDeNumeros.Pop()}"); // Muestra 30

//bool existe = pilaDeNumeros.Contains(20); // Devuelve true si el valor 20 está en la pila

//// Mostrar cantidad de elementos
//Console.WriteLine($"Cantidad de elementos: {pilaDeNumeros.Count()}"); // Muestra 2

//pilaDeNumeros.Clear(); // Vacía la pila.

//int[] elementos = pilaDeNumeros.ToArray(); // Convierte la pila en un arreglo.

//pilaDeNumeros.TrimExcess(); // Optimiza el uso de memoria reduciendo la capacidad de la pila.


Queue<int> colaDeNumeros = new Queue<int>(); // Crea la cola de numeros

// Operación Enqueue: agregar elementos
colaDeNumeros.Enqueue(10);
colaDeNumeros.Enqueue(20);
colaDeNumeros.Enqueue(30);

// Mostrar el primer elemento en la cola (Peek)
Console.WriteLine($"Primer elemento en la cola: {colaDeNumeros.Peek()}"); // Muestra 10

// Operación Dequeue: quitar el primer elemento
Console.WriteLine($"Elemento removido: {colaDeNumeros.Dequeue()}"); // Muestra 10

bool existe = colaDeNumeros.Contains(20); // Devuelve true si el valor 20 está en la cola

// Mostrar cantidad de elementos
Console.WriteLine($"Cantidad de elementos: {colaDeNumeros.Count()}"); // Muestra 2

colaDeNumeros.Clear(); // Vacía la cola.

int[] elementos = colaDeNumeros.ToArray(); // Convierte la cola en un arreglo.

colaDeNumeros.TrimExcess(); // Optimiza el uso de memoria reduciendo la capacidad de la cola.











