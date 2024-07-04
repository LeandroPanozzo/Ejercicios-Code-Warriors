/*
 Cree una función que tome una cadena y devuelva el número (recuento) de vocales que contiene.

Ejemplos
CountVowels("Celebration") ➞ 5

CountVowels("Palm") ➞ 1

CountVowels("Prediction") ➞ 4
 */
using System;
public class Program
{
    public static int CountVowels(string str)
    {
        str.ToLower();
        char[] vocales = { 'a', 'e', 'i', 'o', 'u' };
        int cont = 0;
        foreach (char c in str) {

            if (Array.Exists(vocales, vocal => vocal == char.ToLower(c)))
            {
                cont++;
            }

        }
        return cont;
    }
}

/*
 Usamos un bucle foreach para iterar sobre cada carácter en la cadena str.
Utilizamos Array.Exists para verificar si el carácter actual (c) existe en el arreglo vocales. Para asegurarnos de manejar tanto las vocales mayúsculas como minúsculas, convertimos cada carácter a minúscula utilizando char.ToLower(c) antes de compararlo con los elementos del arreglo vocales

La expresión vocales, vocal => vocal es una forma de expresión lambda que se usa para indicar una función que toma un argumento y simplemente lo devuelve sin ninguna transformación.
vocales: Esto representa el primer parámetro de la expresión lambda, que en este caso parece ser un arreglo llamado vocales.
vocal: Esto representa cada elemento del arreglo vocales mientras se itera sobre él(sobre cada letra). Cada elemento del arreglo se puede referir como vocal dentro del cuerpo de la expresión lambda.
=>: Esto es la sintaxis de flecha que se utiliza para separar los parámetros de la expresión lambda de su cuerpo.
vocal: Esto es lo que devuelve la expresión lambda. En este caso, simplemente devuelve el elemento vocal sin ningún cambio.
 */