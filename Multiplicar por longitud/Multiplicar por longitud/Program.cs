/*
 Cree una función para multiplicar todos los valores de una matriz por la cantidad de valores de la matriz dada.

Ejemplos
MultiplyByLength([2, 3, 1, 0]) ➞ [8, 12, 4, 0]

MultiplyByLength([4, 1, 1]) ➞ ([12, 3, 3])

MultiplyByLength([1, 0, 3, 3, 7, 2, 1]) ➞  [7, 0, 21, 21, 49, 14, 7]

MultiplyByLength([0]) ➞ ([0])
 */
public class Program
{
    public static int[] MultiplyByLength(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] *= arr.Length;
        }
        return arr;
    }
}