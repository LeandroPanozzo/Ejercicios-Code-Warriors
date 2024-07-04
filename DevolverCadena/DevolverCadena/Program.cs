/* 
 Complete la solución para que devuelva verdadero si el primer argumento (cadena) pasado termina con el segundo argumento (también una cadena).

Ejemplos:

solution('abc', 'bc') // returns true
solution('abc', 'd') // returns false
 */
internal class Kata
{
    public bool Solution(string str, string ending)
    {
        if (str.Length < ending.Length)
        {
            return false;
        }
        return str.EndsWith(ending); //EndsWith se utiliza para determinar si una cadena termina con una subcadena especificada
    }
}

class Program
{
    static void Main(string[] args)
    {
        Kata kata = new Kata(); //"instanciación de objeto"

        Console.WriteLine(kata.Solution("abc", "bc"));
        Console.WriteLine(kata.Solution("abc", "d"));
    }
}