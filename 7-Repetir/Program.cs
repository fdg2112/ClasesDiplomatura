//6.1.Escribe un programa que imprima los números del 1 al 10.
int number = 1;
do
{
    Console.WriteLine(number);
    number++;
}
while (number <= 10);

//6.2.Escribe un programa que sume los números ingresados hasta
//introducir uno impar. Mostrar el resultado.
int sum = 0;
number = 0;
do
{
    Console.Write("Ingrese un número: ");
    number = int.Parse(Console.ReadLine());
    if (number % 2 == 0) sum += number;
}
while (number % 2 == 0);
Console.WriteLine("La suma es: " + sum);

//6.3.Escribe un programa que sume los números impares y multiplique
//los pares del 1 hasta el 100. Mostrar los resultados.
int sumImpar = 0;
int productPar = 1;
number = 1;
do
{
    if (number % 2 == 0) productPar *= number;
    else sumImpar += number;
    number++;
}
while (number <= 100);
Console.WriteLine("La suma de impares es: " + sumImpar);
Console.WriteLine("El producto de pares es: " + productPar);

//6.4.Escribe un programa que muestre las palabras indicadas y pida
//nuevas hasta indicar que debe “parar” o “salir”.
string word;
do
{
    Console.Write("Ingrese una palabra (o 'parar'/'salir' para terminar): ");
    word = Console.ReadLine().ToLower();
    if (word != "parar" && word != "salir") Console.WriteLine("La palabra ingresada fue: " + word);
}
while (word != "parar" && word != "salir");
Console.WriteLine("El programa ha terminado.");

//6.5.Escribe un programa que imprima los números del 1 hasta el 20,
//pero sólo los impares. Debe acumular los números pares y mostrar el resultado.
sum = 0;
number = 1;
do
{
    if (number % 2 != 0) Console.WriteLine(number);
    else sum += number;
    number++;
}
while (number <= 20);
Console.WriteLine("La suma de los números pares es: " + sum);

//6.6.Escribe un programa que sume los números ingresados,
//pero sólo los múltiplos de 3.El programa debe seguir pidiendo números
//hasta que se le indique que pare. Mostrar el resultado.

//6.7.Escribe un programa que sume los números impares ingresados y los divida por 2.
//Los números pares deben sumarse y dividirse por 3. El programa frenará cuando uno
//de los resultados supere los 100. Mostrar los resultados

//6.8.Escribe un programa que imprima los números ingresados, pero sólo los que
//sean múltiplos de 3 o 5 hasta que su suma supere los 50. Después debe imprimir
//los números ingresados que sean múltiplos de 2 hasta indicar que debe parar con
//la instrucción “stop”. Sumar los resultados de ambos listados y mostrarlos.

//6.9.Escribe un programa que multiplique los números del 1 al 30, pero sólo los que
//sean múltiplos de 3 o 5. Debe sumar los múltiplos de 2 del 31 al 50. Debe dividir
//por 3 cada par entre 50 y 100 y sumarlos. Mostrar el resultado.

//6.10.Escribe un programa que sume los números del 1 al 50, pero sólo
//los que sean múltiplos de 4 o 6 y los guarde en una variable.
//Una vez finalizado el ciclo, preguntar por sí o por no, si se quiere volver a ejecutarlo.
//Una vez finalizado sumar todos los resultados y mostrarlos.

//6.11.Escribe un programa que imprima caracteres, excepto números o símbolos.
//Una vez ingresado una letra debe parar y mostrar qué se ingresó.

//6.12.Escribe un programa que sume de dos en dos los números impares en un rango
//de datos ingresado y los duplique. Se debe verificar que el rango ingresado sea válido.
//Mostrar el resultado.

//6.13.Escribe un programa que imprima los números del 1 al 50,
//pero sólo los que sean múltiplos de 2, 3 o 5. Este programa se debe repetir
//hasta que el usuario lo indique. Al final mostrar la suma de los resultados
//de todos los ciclos.

//6.14.Escribe un programa que acumule los números ingresados,
//y divida por 2 aquellos que sean múltiplos de 4. El bucle debe repetirse
//hasta llegar a superar los 100 o si el numero acumulado es divisible por 5.
//Indicar porqué criterio se finalizó el bucle.

//6.15.Escribir un programa que pida ingresar letras. Debe contarse cada vocal ingresada
//y mostrarse al final. El programa debe finalizar cuando una vocal se llegue a 4 veces ingresada.

//6.16.Escribe un programa que imprima los números del 1 al 100, pero sólo
//los que sean múltiplos de 4 o 5, pero no de 20. Acumular la suma de los números
//impresos e indicar cuantas veces el programa debe repetirse. Mostrar el total de
//la suma de los ciclos.

//6.17.Escribe un programa que sume los números del 1 al 100, pero sólo los que sean
//múltiplos de 5, pero no de 10. Se debe indicar al principio cuantas veces se ejecutará
//el programa. Al finalizar mostrar el resultado de cada ciclo y la suma del total.

//6.18.Escribe un programa que pida ingresar palabras. Al finalizar debe mostrar
//la primera. Para finalizar escribir “s”

//6.19.Escribe un programa que acumule los números del 1 al X, pero sólo
//los que sean múltiplos de 3, y de 4 o 6, pero no de 8 o de 9.

//6.20.Escribe un programa que multiplique los números impares ingresados
//y al final muestre el resultado. El programa debe indicar que cuando se ingrese
//la letra “S” o “s” el programa debe terminará.
