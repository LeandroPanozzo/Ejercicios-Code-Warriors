/*
 Éowyn has written the function IsOdd() to check if a given number is odd or not. Unfortunately, the function does not return the correct result for all the inputs. Help her fix the error.

Examples
IsOdd(-5) ➞ true

IsOdd(25) ➞ true

IsOdd(0) ➞ false
 */
public class Program
{
    public static bool IsOdd(int num)
    {
        if (num %2== 0) {  return false; }
        return true;
    }
}