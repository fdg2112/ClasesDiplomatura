//// Agregar elementos
//using System.Collections.Generic;

//List<int> numbers = new List<int>();
//numbers.Add(10);
//numbers.Add(20);
//Console.WriteLine("Lista después de agregar elementos:");
//foreach (int num in numbers) Console.Write($"{num} ");

//// Insertar elementos en una posición específica
//numbers.Insert(1, 15); // Inserta 15 en la posición 1
//Console.WriteLine("Lista después de insertar 15 en la posición 1:");
//foreach (int num in numbers) Console.Write($"{num} ");

//// Eliminar elementos
//numbers.Remove(20); // Elimina la primera ocurrencia de 20
//Console.WriteLine("Lista después de eliminar el número 20:");
//foreach (int num in numbers) Console.Write($"{num} ");

//// Eliminar por índice
//numbers.RemoveAt(0); // Elimina el elemento en la posición 0
//Console.WriteLine("Lista después de eliminar el elemento en la posición 0:");
//foreach (int num in numbers) Console.Write($"{num} ");

//// Limpiar la lista
//numbers.Clear();
//Console.WriteLine($"Lista después de limpiar: {numbers.Count} elementos.");

//// Acceso por índice
//Console.WriteLine($"Índice de la primera ocurrencia del número 10: {numbers.IndexOf(10)}");
//Console.WriteLine($"Índice de la última ocurrencia del número 10: {numbers.LastIndexOf(10)}");

//// Buscar elementos
//Console.WriteLine($"¿La lista contiene el número 15? {numbers.Contains(15)}");
//int found = numbers.Find(x => x > 10); // Encuentra el primer número mayor a 10
//Console.WriteLine($"Primer número mayor a 10 encontrado: {found}");

//// Concatenar y Proyectar
//List<int> list1 = new List<int> { 1, 2, 3 };
//List<int> list2 = new List<int> { 4, 5, 6 };
//List<int> concatenated = list1.Concat(list2).ToList();
//Console.WriteLine("Resultado de concatenar las dos listas:");
//foreach (int num in concatenated) Console.Write($"{num} ");

//// Ordenar y manipular la lista
//concatenated.Sort(); // Ordena la lista en orden ascendente
//Console.WriteLine("Lista ordenada:");
//foreach (int num in concatenated) Console.Write($"{num} ");

//concatenated.Reverse(); // Invierte el orden de los elementos
//Console.WriteLine("Lista invertida:");
//foreach (int num in concatenated) Console.Write($"{num} ");

//LinkedList<int> linkedList = new LinkedList<int>();

//// Agregar algunos elementos a la lista
//linkedList.AddLast(10);
//linkedList.AddLast(20);
//linkedList.AddLast(30);
//linkedList.AddLast(40);
//linkedList.AddLast(50);

//// Buscar un número mayor que 25 usando un predicado
//linkedList.FirstOrDefault(x => x > 25);


//void OrdenamientoInsercion(int[] arreglo)
//{
//    // Comienza desde el segundo elemento (índice 1) porque se asume que el primer elemento ya está "ordenado"
//    for (int i = 1; i < arreglo.Length; i++)
//    {
//        // Guardamos el valor actual que estamos intentando insertar en el subarreglo ordenado
//        int valor = arreglo[i];
//        // `j` es el índice del elemento anterior al que estamos intentando insertar
//        int j = i - 1;
//        // Comparamos el valor actual con los elementos del subarreglo ordenado de derecha a izquierda
//        // Si el valor actual es menor que el valor en la posición `j`, desplazamos el valor en la posición `j` hacia la derecha
//        while (j >= 0 && arreglo[j] > valor)
//        {
//            // Desplazamos el elemento en la posición `j` a la posición `j+1`
//            arreglo[j + 1] = arreglo[j];

//            // Decrementamos `j` para seguir comparando con el siguiente elemento del subarreglo ordenado
//            j--;
//        }
//        // Colocamos el valor en la posición correcta del subarreglo ordenado
//        // El valor ahora se coloca en la posición `j + 1` porque en el bucle `while` salimos
//        // cuando `arreglo[j]` es mayor o cuando llegamos al principio
//        arreglo[j + 1] = valor;
//    }
//}

//OrdenamientoInsercion();

//void OrdenamientoBurbuja(int[] arreglo)
//{
//    // Ciclo exterior, recorre todo el arreglo
//    // 'i' va de 0 a arreglo.Length - 1, porque después de cada pasada el último elemento ya estará en su lugar
//    for (int i = 0; i < arreglo.Length - 1; i++)
//    {
//        // Ciclo interior, compara cada elemento con el siguiente
//        // Después de cada pasada, el mayor elemento se coloca al final, por eso se reduce el rango con -i
//        for (int j = 0; j < arreglo.Length - 1 - i; j++)
//        {
//            // Si el elemento actual es mayor que el siguiente, se intercambian
//            if (arreglo[j] > arreglo[j + 1])
//            {
//                // Intercambiar los elementos
//                int temp = arreglo[j];  // Almacena temporalmente el valor de arreglo[j]
//                arreglo[j] = arreglo[j + 1]; // Coloca el valor de arreglo[j + 1] en la posición de arreglo[j]
//                arreglo[j + 1] = temp; // Coloca el valor temporal (original de arreglo[j]) en la posición de arreglo[j + 1]
//            }
//        }
//    }
//}

//OrdenamientoBurbuja();

//void OrdenamientoRapido(int[] arreglo, int izquierda, int derecha)
//{
//    // Si el índice izquierdo es menor que el derecho,
//    // se continúa con la partición y los subarreglos
//    if (izquierda < derecha)
//    {
//        // Realiza la partición y obtiene el índice del pivote
//        int indicePivote = Particionar(arreglo, izquierda, derecha);
//        // Llama recursivamente a OrdenamientoRapido para ordenar la parte izquierda
//        OrdenamientoRapido(arreglo, izquierda, indicePivote - 1);
//        // Llama recursivamente a OrdenamientoRapido para ordenar la parte derecha
//        OrdenamientoRapido(arreglo, indicePivote + 1, derecha);
//    }
//}

//int Particionar(int[] arreglo, int izquierda, int derecha)
//{
//    // El pivote es el último elemento del arreglo
//    int pivote = arreglo[derecha];
//    // 'i' es el índice del último elemento menor que el pivote
//    int i = izquierda - 1;
//    // Recorre los elementos desde izquierda hasta derecha - 1
//    for (int j = izquierda; j < derecha; j++)
//    {
//        // Si el elemento actual es menor o igual que el pivote
//        if (arreglo[j] <= pivote)
//        {
//            // Incrementa 'i' y intercambia los elementos en 'i' y 'j'
//            i++;
//            // Intercambiar
//            int temp = arreglo[i];
//            arreglo[i] = arreglo[j];
//            arreglo[j] = temp;
//        }
//    }
//    // Coloca el pivote en su posición correcta (i + 1)
//    int temp2 = arreglo[i + 1];
//    arreglo[i + 1] = arreglo[derecha];
//    arreglo[derecha] = temp2;
//    // Retorna el índice del pivote
//    return i + 1;
//}

// Ejemplo de arreglo a ordenar
int[] arreglo = { 5, 3, 8, 6, 2, 7, 4, 1 };

Console.WriteLine("Arreglo original: " + string.Join(", ", arreglo));

// Llamamos a OrdenamientoRapido para ordenar el arreglo completo
OrdenamientoRapido(arreglo, 0, arreglo.Length - 1);

Console.WriteLine("Arreglo ordenado: " + string.Join(", ", arreglo));

static void OrdenamientoRapido(int[] arreglo, int izquierda, int derecha)
{
    // Caso base: cuando no hay elementos que ordenar
    if (izquierda < derecha)
    {
        // Realiza la partición y obtiene el índice del pivote
        int indicePivote = Particionar(arreglo, izquierda, derecha);

        // Ordena la parte izquierda del arreglo
        OrdenamientoRapido(arreglo, izquierda, indicePivote - 1);

        // Ordena la parte derecha del arreglo
        OrdenamientoRapido(arreglo, indicePivote + 1, derecha);
    }
}

static int Particionar(int[] arreglo, int izquierda, int derecha)
{
    // El pivote es el último elemento
    int pivote = arreglo[derecha];
    Console.WriteLine($"\nPivote elegido: {pivote}");

    // Índice del último elemento menor que el pivote
    int i = izquierda - 1;

    // Recorremos el arreglo desde el índice `izquierda` hasta `derecha - 1`
    for (int j = izquierda; j < derecha; j++)
    {
        // Si el elemento actual es menor o igual al pivote
        if (arreglo[j] <= pivote)
        {
            i++;
            // Intercambiamos los elementos en las posiciones i y j
            int temp = arreglo[i];
            arreglo[i] = arreglo[j];
            arreglo[j] = temp;
            Console.WriteLine("Intercambio: " + string.Join(", ", arreglo));
        }
    }

    // Coloca el pivote en su posición correcta
    int temp2 = arreglo[i + 1];
    arreglo[i + 1] = arreglo[derecha];
    arreglo[derecha] = temp2;

    Console.WriteLine("Arreglo tras colocar el pivote: " + string.Join(", ", arreglo));

    // Retorna la posición final del pivote
    return i + 1;
}