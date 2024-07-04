/*
 Create a function that takes an integer and returns the factorial of that integer. That is, the integer multiplied by all positive lower integers.

Examples
Factorial(3) ➞ 6

Factorial(5) ➞ 120

Factorial(12) ➞ 479001600
 */
using System;
public class Program
{
    public static int Factorial(int num)
    {
        int result = 1;
        for (int i = num;i > 0;i--)
        {
            result*=i;
        }
        return result;
    }
}