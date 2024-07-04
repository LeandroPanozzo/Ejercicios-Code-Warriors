/*
 Contar las letras y los dígitos
Escribe una función que tome una cadena y calcule el número de letras y dígitos que contiene. Devuelve el resultado como tipo anónimo en formato de cadena.

Ejemplos
count_all("Hello World") ➞ "{ LETTERS =  10, DIGITS =  0 }"

count_all("H3ll0 Wor1d") ➞ "{ LETTERS =  7, DIGITS =  3 }"

count_all("149990") ➞ "{ LETTERS =  0, DIGITS = 6 }"
 */
using System.Linq;
using System;

public class Program
{
    public static string ount_all(string txt)
    {
        int contdigi = 0;
        int cont = 0;
        txt.ToLower();
        char[] arr = new char[txt.Length];

        foreach (char c in txt.ToCharArray())
        {
            if (char.IsLetter(c)) { 
                cont++;
            }
            else
            {
                if (char.IsDigit(c))
                {
                    contdigi++;
                }
                
            }
        }

        return "{ LETTERS = " + cont + ", DIGITS = " + contdigi + " }";
    }

    public static void Main(string[] args)
    {
        // Ejemplos
        Console.WriteLine(ount_all("Hello World")); // Salida: { LETTERS = 10, DIGITS = 0 }
        Console.WriteLine(ount_all("H3ll0 Wor1d")); // Salida: { LETTERS = 7, DIGITS = 3 }
        Console.WriteLine(ount_all("149990")); // Salida: { LETTERS = 0, DIGITS = 6 }
    }
}