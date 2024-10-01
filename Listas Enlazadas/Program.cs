//using System.Collections.Generic;
//// Crear una lista enlazada de enteros
//LinkedList<int> lista = new LinkedList<int>();


//// Operaciones AddFirst y AddLast
//lista.AddFirst(10); // Agregar 10 al principio
//lista.AddLast(20);  // Agregar 20 al final
//lista.AddLast(30);  // Agregar 30 al final

//// Recorrer y mostrar los elementos de la lista
//Console.WriteLine("Elementos en la lista:");
//foreach (int numero in lista) Console.WriteLine(numero);

//var nodo = lista.Find(20); // Buscar un elemento en la lista
//if (nodo != null)
//{
//    Console.WriteLine($"Encontrado: {nodo.Value}");
//}
//lista.Remove(20); // Eliminar un elemento de la lista
//Console.WriteLine("Elementos después de eliminar 20:");
//foreach (int numero in lista) Console.WriteLine(numero);


//LinkedList<int> segundaLista = new LinkedList<int>();
//foreach (var item in segundaLista) lista.AddLast(item);

//LinkedList<int> listaInvertida = new LinkedList<int>();
//var nodoActual = lista.Last;
//while (nodoActual != null)
//{
//    listaInvertida.AddLast(nodoActual.Value);
//    nodoActual = nodoActual.Previous;
//}

//LinkedList<int> primeraMitad = new LinkedList<int>();
//LinkedList<int> segundaMitad = new LinkedList<int>();
//int contador = 0;
//foreach (var item in lista)
//{
//    if (contador < lista.Count / 2)
//        primeraMitad.AddLast(item);
//    else
//        segundaMitad.AddLast(item);
//    contador++;
//}

//LinkedList<int> lista = new LinkedList<int>();
//lista.AddLast(10); // Primer nodo
//lista.AddLast(20); // Segundo nodo
//lista.AddLast(30); // Tercer nodo

//LinkedListNode<int> nodo = lista.Find(20); // Obtenemos una referencia al segundo nodo (con valor 20)

//// Ver los valores de Next y Previous
//LinkedListNode<int> siguienteNodo = nodo.Next;   // Referencia al siguiente nodo (con valor 30)
//LinkedListNode<int> nodoAnterior = nodo.Previous; // Referencia al nodo anterior (con valor 10)
//Console.WriteLine(nodo.Value);         // Muestra 20
//Console.WriteLine(siguienteNodo.Value); // Muestra 30 (el siguiente nodo)
//Console.WriteLine(nodoAnterior.Value);  // Muestra 10 (el nodo anterior)


//// Crear una lista enlazada
//LinkedList<int> lista = new LinkedList<int>();
//lista.AddLast(10);
//lista.AddLast(20);
//lista.AddLast(30);

//// Buscar un nodo con el valor 20
//LinkedListNode<int> nodo20 = lista.Find(20);
//if (nodo20 != null)
//{
//    // Insertar antes y después del nodo encontrado
//    lista.AddBefore(nodo20, 15); // Inserta 15 antes de 20
//    lista.AddAfter(nodo20, 25);  // Inserta 25 después de 20
//}

//// Recorrer la lista y mostrar los valores
//LinkedListNode<int> nodoActual = lista.First;
//while (nodoActual != null)
//{
//    Console.WriteLine(nodoActual.Value); // Muestra el valor de cada nodo
//    nodoActual = nodoActual.Next;       // Avanza al siguiente nodo
//}



////Ejercicio 1
//LinkedList<int> listaNumeros = new LinkedList<int>();
//string opcion = "";
//do
//{
//    Console.WriteLine("\n--- Menú ---");
//    Console.WriteLine("1. Agregar un número al final");
//    Console.WriteLine("2. Eliminar un número específico");
//    Console.WriteLine("3. Mostrar la lista");
//    Console.WriteLine("4. Salir");
//    opcion = Console.ReadLine();
//    switch (opcion)
//    {
//        case "1":
//            Console.Write("Ingrese el número a agregar: ");
//            int numero = int.Parse(Console.ReadLine());
//            listaNumeros.AddLast(numero);
//            Console.WriteLine($"Número {numero} agregado.");
//            break;

//        case "2":
//            Console.Write("Ingrese el número a eliminar: ");
//            numero = int.Parse(Console.ReadLine());
//            if (listaNumeros.Remove(numero)) Console.WriteLine($"Número {numero} eliminado.");
//            else Console.WriteLine($"El número {numero} no se encontró en la lista.");
//            break;

//        case "3":
//            Console.WriteLine("Números en la lista:");
//            foreach (var num in listaNumeros) Console.WriteLine(num);
//            break;

//        case "4":
//            Console.WriteLine("Saliendo del programa...");
//            break;

//        default:
//            Console.WriteLine("Opción no válida.");
//            break;
//    }

//} while (opcion != "4");

////Ejercicio 2
//LinkedList<string> listaPalabras = new LinkedList<string>();
//listaPalabras.AddLast("hola");
//listaPalabras.AddLast("mundo");
//listaPalabras.AddLast("programacion");
//Console.Write("Ingrese la palabra a buscar: ");
//string palabraBuscada = Console.ReadLine();
//LinkedListNode<string> nodoEncontrado = listaPalabras.Find(palabraBuscada);
//if (nodoEncontrado != null) Console.WriteLine($"La palabra '{palabraBuscada}' se encuentra en la lista.");
//else Console.WriteLine($"La palabra '{palabraBuscada}' no está en la lista.");

////Ejercicio 3
//LinkedList<int> lista1 = new LinkedList<int>();
//LinkedList<int> lista2 = new LinkedList<int>();
//lista1.AddLast(1);
//lista1.AddLast(2);
//lista1.AddLast(3);
//lista2.AddLast(4);
//lista2.AddLast(5);
//lista2.AddLast(6);
//foreach (var num in lista2) lista1.AddLast(num);
//Console.WriteLine("Lista concatenada:");
//foreach (var num in lista1) Console.WriteLine(num);

//// Ejercicio 4
//listaPalabras.Clear();
//listaPalabras.AddLast("uno");
//listaPalabras.AddLast("dos");
//listaPalabras.AddLast("tres");
//LinkedList<string> listaInvertida = new LinkedList<string>();
//LinkedListNode<string> nodoActual = listaPalabras.Last;
//while (nodoActual != null)
//{
//    listaInvertida.AddLast(nodoActual.Value);
//    nodoActual = nodoActual.Previous; // Avanzar hacia atrás
//}
//Console.WriteLine("Lista invertida:");
//foreach (var palabra in listaInvertida)
//{
//    Console.WriteLine(palabra);
//}

