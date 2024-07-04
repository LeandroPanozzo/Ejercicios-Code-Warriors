/**Trolls are attacking your comment section!

A common way to deal with this situation is to remove all of the vowels from the trolls' comments, neutralizing the threat.

Your task is to write a function that takes a string and return a new string with all vowels removed.

For example, the string "This website is for losers LOL!" would become "Ths wbst s fr lsrs LL!".

Note: for this kata y isn't considered a vowel.
*/

public static class Kata
{
    public static string Disemvowel(string str)
    {
        string vocales = "aeiouAEIOU";
        string reemplazo = "";

        foreach (char c in str) //Este bucle foreach itera a través de cada carácter c en la cadena de entrada str
        {
            if (!vocales.Contains(c)) // En cada iteración, se verifica si el carácter actual c no está contenido en la cadena vowels. La cadena vowels contiene todas las vocales, tanto en mayúsculas como en minúsculas.
            {
                reemplazo += c;//Si el carácter c no es una vocal (es decir, si no está contenido en la cadena vowels), se agrega al resultado. Esto significa que solo los caracteres que no son vocales se incluirán en la cadena resultante.
            }
            
        }
        return reemplazo;
    }

}
//otra forma

/*
 
 using System;
using System.Text.RegularExpressions;

public static class Kata
{
  public static string Disemvowel(string str)
  {
    return Regex.Replace(str,"[aeiou]", "", RegexOptions.IgnoreCase); //Esta línea utiliza la clase Regex de .NET para realizar una búsqueda y reemplazo en la cadena de entrada str. La expresión regular [aeiou] coincide con cualquier vocal, independientemente de si está en mayúsculas o minúsculas, debido al modificador RegexOptions.IgnoreCase.
  }                                                                   // "" : Es la cadena de reemplazo, en este caso, una cadena vacía. Esto significa que cualquier coincidencia encontrada será eliminada de la cadena de entrada
}


 */

