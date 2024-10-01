
//int ObtenerPrimero(int[] arreglo)
//{
//    return arreglo[0];  // O(1) - Tiempo constante
//}

//void MostrarTodos(int[] arreglo)
//{
//    for (int i = 0; i < arreglo.Length; i++)
//    {
//        Console.WriteLine(arreglo[i]); // O(n) - Tiempo lineal
//    }
//}

//void Burbuja(int[] arreglo)
//{
//    for (int i = 0; i < arreglo.Length; i++)
//    {
//        for (int j = 0; j < arreglo.Length - 1 - i; j++)
//        {
//            if (arreglo[j] > arreglo[j + 1])
//            {
//                // Intercambiar
//                int temp = arreglo[j];
//                arreglo[j] = arreglo[j + 1];
//                arreglo[j + 1] = temp;
//            }
//        }
//    }
//}



//int[] array = { 1, 2 };
//ObtenerPrimero(array);
//MostrarTodos(array);
//Burbuja(array);


//int BusquedaLineal(int[] arreglo, int valorBuscado)
//{
//    for (int i = 0; i < arreglo.Length; i++)
//    {
//        if (arreglo[i] == valorBuscado)
//            return i; // Retorna el índice si se encuentra el valor
//    }
//    return -1; // Retorna -1 si no se encuentra
//}

//int BusquedaBinaria(int[] arreglo, int valorBuscado)
//{
//    int inicio = 0, fin = arreglo.Length - 1;

//    while (inicio <= fin)
//    {
//        int mitad = (inicio + fin) / 2;
//        if (arreglo[mitad] == valorBuscado)
//            return mitad;
//        else if (arreglo[mitad] < valorBuscado)
//            inicio = mitad + 1;
//        else
//            fin = mitad - 1;
//    }

//    return -1; // Retorna -1 si no se encuentra
//}

//void OrdenamientoBurbuja(int[] arreglo)
//{
//    for (int i = 0; i < arreglo.Length - 1; i++)
//    {
//        for (int j = 0; j < arreglo.Length - 1 - i; j++)
//        {
//            if (arreglo[j] > arreglo[j + 1])
//            {
//                // Intercambiar
//                int temp = arreglo[j];
//                arreglo[j] = arreglo[j + 1];
//                arreglo[j + 1] = temp;
//            }
//        }
//    }
//}

//void OrdenamientoInsercion(int[] arreglo)
//{
//    for (int i = 1; i < arreglo.Length; i++)
//    {
//        int valor = arreglo[i];
//        int j = i - 1;
//        while (j >= 0 && arreglo[j] > valor)
//        {
//            arreglo[j + 1] = arreglo[j];
//            j--;
//        }
//        arreglo[j + 1] = valor;
//    }
//}

//void OrdenamientoRapido(int[] arreglo, int izquierda, int derecha)
//{
//    if (izquierda < derecha)
//    {
//        int indicePivote = Particionar(arreglo, izquierda, derecha);
//        OrdenamientoRapido(arreglo, izquierda, indicePivote - 1);
//        OrdenamientoRapido(arreglo, indicePivote + 1, derecha);
//    }
//}

//int Particionar(int[] arreglo, int izquierda, int derecha)
//{
//    int pivote = arreglo[derecha];
//    int i = izquierda - 1;
//    for (int j = izquierda; j < derecha; j++)
//    {
//        if (arreglo[j] <= pivote)
//        {
//            i++;
//            // Intercambiar
//            int temp = arreglo[i];
//            arreglo[i] = arreglo[j];
//            arreglo[j] = temp;
//        }
//    }

//    // Intercambiar pivote
//    int temp1 = arreglo[i + 1];
//    arreglo[i + 1] = arreglo[derecha];
//    arreglo[derecha] = temp1;

//    return i + 1;
//}


//int[] array = { 1, 2 };
//BusquedaLineal(array, 1);
//BusquedaBinaria(array, 1);
//OrdenamientoBurbuja(array);
//OrdenamientoInsercion(array);

