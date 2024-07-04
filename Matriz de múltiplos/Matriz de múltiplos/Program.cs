/*
 Cree una función que tome dos números como argumentos ( num, length) y devuelva una matriz de múltiplos de numhasta que la longitud de la matriz alcance length.

Ejemplos
ArrayOfMultiples(7, 5) ➞ [7, 14, 21, 28, 35]

ArrayOfMultiples(12, 10) ➞ [12, 24, 36, 48, 60, 72, 84, 96, 108, 120]

ArrayOfMultiples(17, 6) ➞ [17, 34, 51, 68, 85, 102]
 */

using System;
/*
 Matriz de múltiplos
Cree una función que tome dos números como argumentos ( num, length) y devuelva una matriz de múltiplos de numhasta que la longitud de la matriz alcance length.

Ejemplos
ArrayOfMultiples(7, 5) ➞ [7, 14, 21, 28, 35]

ArrayOfMultiples(12, 10) ➞ [12, 24, 36, 48, 60, 72, 84, 96, 108, 120]

ArrayOfMultiples(17, 6) ➞ [17, 34, 51, 68, 85, 102]
 */
public class Program
{
    public static int[] ArrayOfMultiples(int num, int length)
    {
        int[] longitud = new int[length];
        
        for (int i = 0; i < longitud.Length; i++) {
            
            longitud[i] = num * (i+1);
            
        }

        return longitud;
    }
}