/*
 Recuento positivo/suma negativa
Crea una función que tome una matriz de números positivos y negativos. Devuelve una matriz donde el primer elemento es el recuento de números positivos y el segundo elemento es la suma de los números negativos.

Ejemplos
CountPosSumNeg([1, 2, 3, 4, 5, 6, 7, 8, 9, 10, -11, -12, -13, -14, -15]) ➞ [10, -65]
// There are a total of 10 positive numbers.
// The sum of all negative numbers equals -65.

CountPosSumNeg([92, 6, 73, -77, 81, -90, 99, 8, -85, 34]) ➞ [7, -252]

CountPosSumNeg([91, -4, 80, -73, -28]) ➞ [2, -105]

CountPosSumNeg([]) ➞ []
Notas
Si se le da una matriz vacía, devuelve una matriz vacía:[]
Convierte la suma a int, no te preocupes por los decimales restantes.
0 no es positivo.
 */
public class Program
{
    public static int[] CountPosSumNeg(double[] arr)
    {
        return new[] { arr.Count(n => n > 0), (int)arr.Sum(n => n < 0 ? n : 0) };
    }
}
/*
 arr.Count(n => n > 0): Utiliza el método Count() de LINQ para contar el número de
elementos en la matriz arr que son mayores que 0. Esto cuenta el número de números positivos en la matriz.

(int)arr.Sum(n => n < 0 ? n : 0): Utiliza el método Sum() de LINQ para sumar los valores de la matriz arr 
que son menores que 0. La expresión (n < 0 ? n : 0) garantiza que solo se sumen los números negativos. 
Luego, se realiza una conversión explícita a int para asegurar que el resultado sea un entero.
 */