// Crear una lista enlazada de enteros
LinkedList<int> lista = new LinkedList<int>();
// Operaciones AddFirst y AddLast
lista.AddFirst(10); // Agregar 10 al principio
lista.AddLast(20);  // Agregar 20 al final
lista.AddLast(30);  // Agregar 30 al final

// Recorrer y mostrar los elementos de la lista
Console.WriteLine("Elementos en la lista:");
foreach (int numero in lista) Console.WriteLine(numero);

var nodo = lista.Find(20); // Buscar un elemento en la lista
if (nodo != null) Console.WriteLine($"Encontrado: {nodo.Value}");

lista.Remove(20); // Eliminar un elemento de la lista
Console.WriteLine("Elementos después de eliminar el 20:");
foreach (int numero in lista) Console.WriteLine(numero);

// Agregar elemento al ptincipio y al final la lista
lista.AddFirst(40);
lista.AddLast(50);

// Insertar un valor antes y después de un nodo específico
lista.AddBefore(nodo, 15);
lista.AddAfter(nodo, 25);

// Encuentra el último nodo con el valor 10
lista.FindLast(10);

lista.RemoveFirst();        // Elimina el primer nodo de la lista
lista.RemoveLast();         // Elimina el último nodo de la lista
lista.Remove(nodo);          // Elimina el nodo especificado
lista.Clear();               // Vacia completamente la lista
int cantidad = lista.Count;  // Devuelve cuántos nodos hay en la lista

//<---- OPERACIONES CON LISTAS ---->
// Invertir lista
LinkedList<int> listaInvertida = new LinkedList<int>();
var nodoActual = lista.Last;
while (nodoActual != null)
{
    listaInvertida.AddLast(nodoActual.Value);
    nodoActual = nodoActual.Previous;
}

// Dividir lista
LinkedList<int> primeraMitad = new LinkedList<int>();
LinkedList<int> segundaMitad = new LinkedList<int>();
int contador = 0;
foreach (var item in lista)
{
    if (contador < lista.Count / 2)
        primeraMitad.AddLast(item);
    else
        segundaMitad.AddLast(item);
    contador++;
}

LinkedList<int> lista2 = new LinkedList<int>();
lista.AddLast(10); // Primer nodo
lista.AddLast(20); // Segundo nodo
lista.AddLast(30); // Tercer nodo

// Recorrer la lista y mostrar los valores
LinkedListNode<int> nodoActual2 = lista.First;
while (nodoActual2 != null)
{
    Console.WriteLine(nodoActual2.Value); // Muestra el valor de cada nodo
    nodoActual2 = nodoActual2.Next;       // Avanza al siguiente nodo
}

// Buscar un nodo con el valor 20
LinkedListNode<int> nodo20 = lista2.Find(20); // Obtenemos una referencia al segundo nodo (con valor 20)
if (nodo20 != null)
{
    // Insertar antes y después del nodo encontrado
    lista.AddBefore(nodo20, 15); // Inserta 15 antes de 20
    lista.AddAfter(nodo20, 25);  // Inserta 25 después de 20
}

// Ver los valores de Next y Previous
LinkedListNode<int> siguienteNodo = nodo.Next;   // Referencia al siguiente nodo (con valor 30)
LinkedListNode<int> nodoAnterior = nodo.Previous; // Referencia al nodo anterior (con valor 10)
Console.WriteLine(nodo.Value);         // Muestra 20
Console.WriteLine(siguienteNodo.Value); // Muestra 30 (el siguiente nodo)
Console.WriteLine(nodoAnterior.Value);  // Muestra 10 (el nodo anterior)


Console.WriteLine("""
Ejercicio 1: Insertar y eliminar nodos
Crear una lista enlazada que permita al usuario agregar y eliminar números. 
Mostrar los números en la lista después de cada operación.
""");
LinkedList<int> numberList = new LinkedList<int>();
string option = "";
do
{
    Console.Clear();
    Console.WriteLine("\n--- Menú ---");
    Console.WriteLine("1. Agregar un número al final");
    Console.WriteLine("2. Eliminar un número específico");
    Console.WriteLine("3. Mostrar la lista");
    Console.WriteLine("4. Salir");
    option = Console.ReadLine();
    switch (option)
    {
        case "1":
            Console.Write("Ingrese el número a agregar: ");
            int number = int.Parse(Console.ReadLine());
            numberList.AddLast(number);
            Console.WriteLine($"Número {number} agregado.");
            break;

        case "2":
            Console.Write("Ingrese el número a eliminar: ");
            number = int.Parse(Console.ReadLine());
            if (numberList.Remove(number)) Console.WriteLine($"Número {number} eliminado.");
            else Console.WriteLine($"El número {number} no se encontró en la lista.");
            break;

        case "3":
            Console.WriteLine("Números en la lista:");
            foreach (var num in numberList) Console.WriteLine(num);
            break;

        case "4":
            Console.WriteLine("Saliendo del programa...");
            break;

        default:
            Console.WriteLine("Opción no válida.");
            break;
    }
    Console.ReadKey();
} while (option != "4");
Console.Clear();

// Ejercicio 2: Buscar en la lista enlazada
Console.WriteLine("""
Ejercicio 2: Buscar en la lista enlazada. Crear una lista enlazada de palabras. 
Permitir que el usuario busque una palabra y mostrar si se encuentra o no en la lista.
""");
LinkedList<string> wordList = new LinkedList<string>();
wordList.AddLast("hola");
wordList.AddLast("mundo");
wordList.AddLast("programación");
Console.Write("Ingrese la palabra a buscar: ");
string wordSearched = Console.ReadLine();
LinkedListNode<string> foundNode = wordList.Find(wordSearched);
if (foundNode != null) Console.WriteLine($"La palabra '{wordSearched}' se encuentra en la lista.");
else Console.WriteLine($"La palabra '{wordSearched}' no está en la lista.");
Console.ReadKey();
Console.Clear();

// Ejercicio 3: Concatenar dos listas enlazadas
Console.WriteLine("""
Ejercicio 3: Concatenar dos listas enlazadas. Crear dos listas enlazadas de números. 
Concatenar las dos listas en una sola y mostrar el resultado.
""");
LinkedList<int> list1 = new LinkedList<int>();
LinkedList<int> list2 = new LinkedList<int>();
list1.AddLast(1);
list1.AddLast(2);
list1.AddLast(3);
list2.AddLast(4);
list2.AddLast(5);
list2.AddLast(6);
foreach (var num in list2) list1.AddLast(num);
Console.WriteLine("Lista concatenada:");
foreach (var num in list1) Console.WriteLine(num);
Console.ReadKey();
Console.Clear();

// Ejercicio 4: Revertir una lista enlazada
Console.WriteLine("""
Ejercicio 4: Revertir una lista enlazada
Crear una lista enlazada de palabras e invertir el orden de los nodos.
""");
LinkedList<string> wordListReverse = new LinkedList<string>();
wordListReverse.AddLast("uno");
wordListReverse.AddLast("dos");
wordListReverse.AddLast("tres");
LinkedList<string> reversedList = new LinkedList<string>();
LinkedListNode<string> currentNode = wordListReverse.Last;
while (currentNode != null)
{
    reversedList.AddLast(currentNode.Value);
    currentNode = currentNode.Previous;
}
Console.WriteLine("Lista invertida:");
foreach (var word in reversedList) Console.WriteLine(word);
Console.ReadKey();
Console.Clear();
