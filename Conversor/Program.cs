using System;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

Console.WriteLine("Menu de conversion eliga una opcion:");
Console.WriteLine(" 1. Convertir celcius a fahrenheit");
Console.WriteLine(" 2. Convertir kilometros a millas");
Console.WriteLine(" 3. Kilogramos a libras");
Console.WriteLine(" 4. Salir");

int opcion = Convert.ToInt32(Console.ReadLine());

switch (opcion)
{
    case 1:
        Console.WriteLine("Ingrese la temperatura en Celsius:");
        double celcius = Convert.ToDouble(Console.ReadLine());
        double fahenheit = (celcius * 9 / 5) + 32;
        Console.WriteLine($"{celcius} Celsius es igual a {fahenheit} Fahrenheit");
        break;
    case 2:
        Console.WriteLine("Ingrese la distancia en Kilometros:");
        double kilometros = Convert.ToDouble(Console.ReadLine());
        double millas = kilometros * 0.621371;
        Console.WriteLine($"{kilometros} Kilometros es igual a {millas} Millas");
        break;
        case 3:
        Console.WriteLine("Ingrese el peso en kgs:");
        double kgs = Convert.ToDouble(Console.ReadLine());
        double libras = kgs * 2.20462;
    Console.WriteLine($"{kgs} Kgs = {libras} libras");
        break;
        case 4:
        Console.WriteLine("Gracias por usar el conversor. ¡Regrese pronto!");
        return;
        default:
        Console.WriteLine("Opción no válida. Intente de nuevo.");
        break;


}



