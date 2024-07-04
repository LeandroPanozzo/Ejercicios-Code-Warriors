/*
 Cree una función que tome una matriz de números y devuelva los números mínimo y máximo, en ese orden.

Ejemplos
FindMinMax([1, 2, 3, 4, 5]) ➞ [1, 5]

FindMinMax([2334454, 5]) ➞ [5, 2334454]

FindMinMax([1]) ➞ [1, 1]
 */
using System;
using System.Linq;
public class Program
{
    public static double[] FindMinMax(double[] values)
    {
        double[] result = new double[2];
        result[0] = values.Min();
        result[1] = values.Max();

        
        return result;


    }
}