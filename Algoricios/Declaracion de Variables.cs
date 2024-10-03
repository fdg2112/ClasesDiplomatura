using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Algoricios
{
    public class Declaracion_de_Variables
    {
        //Ejercicio en Clase
        string? name = "Franco";
        string? lastname = "Gonzalez";
        byte age = 34;
        float height = 1.80f;
        char gender = 'M';
        bool isEmployed = true;

        public void MostrarDatos()
        {
            Console.WriteLine($"Nombre: {name} {lastname}");
            Console.WriteLine($"Edad: {age}");
            Console.WriteLine($"Altura: {height}");
            Console.WriteLine($"Género: {gender}");
            Console.WriteLine($"Empleado: {isEmployed}");
        }

        // -------- Ejercicios de la guía --------
        //1.1.	Escribe un programa que lea la distancia recorrida por un vehículo
        //y la unidad de medida utilizada, y luego imprima estos datos.
        //1.2.	Escribe un programa que lea la temperatura en grados Celsius y la convierta a grados Fahrenheit.
        //1.3.	Escribe un programa que lea el número de horas trabajadas por un empleado en una semana y el tipo de turno (diurno o nocturno). Luego, imprima estos datos.
        //1.4.	Escribe un programa que lea tres números enteros y calcule su promedio.
        //1.5.	Escribe un programa que calcule la hipotenusa de un triángulo rectángulo.
        //1.6.	Escribe un programa que declare una variable booleana. Informar el estado inicial, y después cambiarlo y mostrar el otro.
        //1.7.	Escribe un programa lea los datos de un juguete, nombre, descripción, cantidad en stock y precio.
        //1.8.	Escribe un programa lea la altura de caída de un objeto y calcule la velocidad al tocar el suelo.La gravedad se debe inicializar en 9,8.
        //1.9.	Escribe un programa que guarde cadenas en una variable, que esta contenga la palabra “hola” y la muestre.Seguido que pida ingresar otra palabra para reemplazarla y mostrarla.
        //1.10.	Escribe un programa que declare una variable booleana para dos estados: “ON” y “OFF”. Se debe inicializar en verdadera, informar “ON”, y después cambiarla por falsa y mostrar “OFF”.

    }
}
