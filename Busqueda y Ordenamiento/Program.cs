using System.Diagnostics;

int ObtenerPrimero(int[] arreglo)
{
    return arreglo[0];  // O(1) - Tiempo constante
}

void MostrarTodos(int[] arreglo)
{
    for (int i = 0; i < arreglo.Length; i++)
    {
        Console.WriteLine(arreglo[i]); // O(n) - Tiempo lineal
    }
}

void Burbuja(int[] arreglo)
{
    for (int i = 0; i < arreglo.Length; i++)
    {
        for (int j = 0; j < arreglo.Length - 1 - i; j++)
        {
            if (arreglo[j] > arreglo[j + 1])
            {
                // Intercambiar
                int temp = arreglo[j];
                arreglo[j] = arreglo[j + 1];
                arreglo[j + 1] = temp;
            }
        }
    }
}

int[] array = { 1, 2 };
ObtenerPrimero(array);
MostrarTodos(array);
Burbuja(array);

int BusquedaLineal(int[] arreglo, int valorBuscado)
{
    for (int i = 0; i < arreglo.Length; i++)
    {
        if (arreglo[i] == valorBuscado)
            return i; // Retorna el índice si se encuentra el valor
    }
    return -1; // Retorna -1 si no se encuentra
}

int BusquedaBinaria(int[] arreglo, int valorBuscado)
{
    int inicio = 0, fin = arreglo.Length - 1;

    while (inicio <= fin)
    {
        int mitad = (inicio + fin) / 2;
        if (arreglo[mitad] == valorBuscado)
            return mitad;
        else if (arreglo[mitad] < valorBuscado)
            inicio = mitad + 1;
        else
            fin = mitad - 1;
    }

    return -1; // Retorna -1 si no se encuentra
}

void OrdenamientoBurbuja(int[] arreglo)
{
    for (int i = 0; i < arreglo.Length - 1; i++)
    {
        for (int j = 0; j < arreglo.Length - 1 - i; j++)
        {
            if (arreglo[j] > arreglo[j + 1])
            {
                // Intercambiar
                int temp = arreglo[j];
                arreglo[j] = arreglo[j + 1];
                arreglo[j + 1] = temp;
            }
        }
    }
}

void OrdenamientoInsercion(int[] arreglo)
{
    for (int i = 1; i < arreglo.Length; i++)
    {
        int valor = arreglo[i];
        int j = i - 1;
        while (j >= 0 && arreglo[j] > valor)
        {
            arreglo[j + 1] = arreglo[j];
            j--;
        }
        arreglo[j + 1] = valor;
    }
}

void OrdenamientoRapido(int[] arreglo, int izquierda, int derecha)
{
    if (izquierda < derecha)
    {
        int indicePivote = Particionar(arreglo, izquierda, derecha);
        OrdenamientoRapido(arreglo, izquierda, indicePivote - 1);
        OrdenamientoRapido(arreglo, indicePivote + 1, derecha);
    }
}

int Particionar(int[] arreglo, int izquierda, int derecha)
{
    int pivote = arreglo[derecha];
    int i = izquierda - 1;
    for (int j = izquierda; j < derecha; j++)
    {
        if (arreglo[j] <= pivote)
        {
            i++;
            // Intercambiar
            int temp = arreglo[i];
            arreglo[i] = arreglo[j];
            arreglo[j] = temp;
        }
    }

    // Intercambiar pivote
    int temp1 = arreglo[i + 1];
    arreglo[i + 1] = arreglo[derecha];
    arreglo[derecha] = temp1;

    return i + 1;
}

int[] arreglo = { 1, 2 };
BusquedaLineal(arreglo, 1);
BusquedaBinaria(arreglo, 1);
OrdenamientoBurbuja(arreglo);
OrdenamientoInsercion(arreglo);




Console.WriteLine("""
    Ejercicio 1: Búsqueda Lineal y Binaria
    • Crear un programa que permita al usuario ingresar una lista de números.
    • Luego buscar un número usando búsqueda lineal y binaria.
    ________________________________________
""");
// Ingresamos los números
List<int> numbersList = new List<int>();
int numInput;
Console.WriteLine("Ingrese números para la lista (ingrese -1 para finalizar): ");
while (true)
{
    numInput = int.Parse(Console.ReadLine());
    if (numInput == -1) break;
    numbersList.Add(numInput);
}
// Búsqueda Lineal
Console.Write("Ingrese un número a buscar (Búsqueda Lineal): ");
int searchNumberLinear = int.Parse(Console.ReadLine());
bool foundLinear = false;
foreach (var num in numbersList)
{
    if (num == searchNumberLinear)
    {
        foundLinear = true;
        break;
    }
}
Console.WriteLine(foundLinear ? "El número fue encontrado (Búsqueda Lineal)." : "El número no se encuentra (Búsqueda Lineal).");
// Ordenamos la lista para la Búsqueda Binaria
numbersList.Sort();
// Búsqueda Binaria
Console.Write("Ingrese un número a buscar (Búsqueda Binaria): ");
int searchNumberBinary = int.Parse(Console.ReadLine());
int binarySearchResult = numbersList.BinarySearch(searchNumberBinary);
Console.WriteLine(binarySearchResult >= 0 ? "El número fue encontrado (Búsqueda Binaria)." : "El número no se encuentra (Búsqueda Binaria).");
Console.ReadKey();
Console.Clear();

Console.WriteLine("""
    Ejercicio 2: Implementar Bubble Sort
    • Permitir al usuario ingresar una lista de números y ordenarla usando Bubble Sort.
    ________________________________________
""");
// Ingresamos los números
List<int> bubbleSortList = new List<int>();
Console.WriteLine("Ingrese números para la lista (ingrese -1 para finalizar): ");
while (true)
{
    numInput = int.Parse(Console.ReadLine());
    if (numInput == -1) break;
    bubbleSortList.Add(numInput);
}
// Bubble Sort
for (int i = 0; i < bubbleSortList.Count - 1; i++)
{
    for (int j = 0; j < bubbleSortList.Count - i - 1; j++)
    {
        if (bubbleSortList[j] > bubbleSortList[j + 1])
        {
            int temp = bubbleSortList[j];
            bubbleSortList[j] = bubbleSortList[j + 1];
            bubbleSortList[j + 1] = temp;
        }
    }
}
Console.WriteLine("\nLista ordenada con Bubble Sort:");
foreach (var num in bubbleSortList) Console.WriteLine(num);
Console.ReadKey();
Console.Clear();

Console.WriteLine("""
    Ejercicio: Comparación de Algoritmos
    • Crear dos arreglos: uno con números y otro con palabras.
    • Implementar Insertion Sort para los números y Quick Sort para las palabras.
    ________________________________________
""");

// Función Insertion Sort (para números)
void InsertionSort(int[] array)
{
    for (int i = 1; i < array.Length; i++)
    {
        int key = array[i];
        int j = i - 1;
        while (j >= 0 && array[j] > key)
        {
            array[j + 1] = array[j];
            j--;
        }
        array[j + 1] = key;
    }
}

// Función Quick Sort (para palabras)
void QuickSort(string[] array, int left, int right)
{
    if (left < right)
    {
        int pivotIndex = Partition(array, left, right);
        QuickSort(array, left, pivotIndex - 1);
        QuickSort(array, pivotIndex + 1, right);
    }
}

int Partition(string[] array, int left, int right)
{
    string pivot = array[right];
    int i = left - 1;
    for (int j = left; j < right; j++)
    {
        if (string.Compare(array[j], pivot) < 0)
        {
            i++;
            string temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
    }
    string tempPivot = array[i + 1];
    array[i + 1] = array[right];
    array[right] = tempPivot;
    return i + 1;
}

// Ingresamos números para el arreglo de números
Console.WriteLine("Ingrese números para el arreglo (ingrese -1 para finalizar): ");
numbersList = new List<int>();
while (true)
{
    numInput = int.Parse(Console.ReadLine());
    if (numInput == -1) break;
    numbersList.Add(numInput);
}
int[] numberArray = numbersList.ToArray();

// Ingresamos palabras para el arreglo de palabras
Console.WriteLine("Ingrese palabras para el arreglo (ingrese 'fin' para finalizar): ");
List<string> wordsList = new List<string>();
string wordInput;
while (true)
{
    wordInput = Console.ReadLine();
    if (wordInput.ToLower() == "fin") break;
    wordsList.Add(wordInput);
}
string[] wordArray = wordsList.ToArray();
Console.ReadKey();
Console.Clear();


