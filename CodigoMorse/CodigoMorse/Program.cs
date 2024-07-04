/*
 En este kata tienes que escribir un decodificador de código Morse sencillo . Si bien el código Morse ahora ha sido reemplazado en gran medida por los canales de comunicación de voz y datos digitales, todavía se utiliza en algunas aplicaciones en todo el mundo.
El código Morse codifica cada carácter como una secuencia de "puntos" y "guiones". Por ejemplo, la letra Ase codifica como ·−, la letra Qse codifica como −−·−y el dígito 1se codifica como ·−−−−. El código Morse no distingue entre mayúsculas y minúsculas y tradicionalmente se utilizan letras mayúsculas. Cuando el mensaje está escrito en código Morse, se utiliza un solo espacio para separar los códigos de caracteres y 3 espacios para separar las palabras. Por ejemplo, el mensaje HEY JUDEen código Morse es ···· · −·−−   ·−−− ··− −·· ·.

NOTA: Los espacios adicionales antes o después del código no tienen significado y deben ignorarse.

Además de letras, dígitos y algunos signos de puntuación, existen algunos códigos de servicio especiales, el más notorio de ellos es la señal de socorro internacional SOS (que fue emitida por primera vez por Titanic ), que está codificada como ···−−−···. Estos códigos especiales se tratan como caracteres especiales únicos y normalmente se transmiten como palabras separadas.

Su tarea es implementar una función que tome el código morse como entrada y devuelva una cadena decodificada legible por humanos.

Por ejemplo:

MorseCodeDecoder.Decode(".... . -.--   .--- ..- -.. .")
//should return "HEY JUDE"
 */

using System;
using System.Collections.Generic;

public class MorseCodeDecoder
{
    private static readonly Dictionary<string, char> MorseCode = new Dictionary<string, char>()
    {
        /*
         Un diccionario es una estructura de datos que almacena pares clave-valor, lo que significa que puedes buscar un valor (en este caso, un carácter) asociado a una clave (en este caso, una cadena de texto que representa el código Morse).

        La declaración private static readonly significa lo siguiente:

        private: Esto significa que el diccionario solo es accesible dentro de la clase donde está definido.
        static: Indica que el diccionario es compartido entre todas las instancias de la clase. En otras palabras, solo hay una copia de este diccionario independientemente de cuántas veces se instancie la clase DecodificadorMorse.
        readonly: Indica que el diccionario no puede ser modificado después de su inicialización. Una vez que se asignan los valores de las claves y los valores asociados, no se pueden cambiar.
        La parte Dictionary<string, char>() indica que estamos creando un diccionario donde las claves son de tipo string y los valores son de tipo char.

        Por lo tanto, en resumen, esta línea de código declara un diccionario llamado CodigoMorse que mapea cadenas de texto (código Morse) a caracteres en el alfabeto y números. Este diccionario se utiliza para decodificar el código Morse proporcionado.
        */
        {".-", 'A'}, {"-...", 'B'}, {"-.-.", 'C'}, {"-..", 'D'}, {".", 'E'},
        {"..-.", 'F'}, {"--.", 'G'}, {"....", 'H'}, {"..", 'I'}, {".---", 'J'},
        {"-.-", 'K'}, {".-..", 'L'}, {"--", 'M'}, {"-.", 'N'}, {"---", 'O'},
        {".--.", 'P'}, {"--.-", 'Q'}, {".-.", 'R'}, {"...", 'S'}, {"-", 'T'},
        {"..-", 'U'}, {"...-", 'V'}, {".--", 'W'}, {"-..-", 'X'}, {"-.--", 'Y'},
        {"--..", 'Z'},
        {"-----", '0'}, {".----", '1'}, {"..---", '2'}, {"...--", '3'}, {"....-", '4'},
        {".....", '5'}, {"-....", '6'}, {"--...", '7'}, {"---..", '8'}, {"----.", '9'},
        {".-.-.-", '.'}, {"--..--", ','}, {"..--..", '?'}, {".----.", '\''}, {"-.-.--", '!'},
        {"-..-.", '/'}, {"-.--.", '('}, {"-.--.-", ')'}, {".-...", '&'}, {"---...", ':'},
        {"-.-.-.", ';'}, {"-...-", '='}, {".-.-.", '+'}, {"-....-", '-'}, {"..--.-", '_'},
        {".-..-.", '"'}, {".--.-.", '@'}
    };

    public static string Decode(string morseCode)
    {
        string[] words = morseCode.Trim().Split("   ", StringSplitOptions.RemoveEmptyEntries);
        List<string> decodedWords = new List<string>();

        foreach (string word in words)
        {
            string[] letters = word.Split(" ");
            string decodedWord = "";
            foreach (string letter in letters)
            {
                if (MorseCode.ContainsKey(letter))
                {
                    decodedWord += MorseCode[letter];
                }
            }
            decodedWords.Add(decodedWord);
        }

        return string.Join(" ", decodedWords);

        /*
         string[] words = morseCode.Trim().Split(" ", StringSplitOptions.RemoveEmptyEntries);:

Trim() elimina cualquier espacio en blanco al principio y al final de la cadena morseCode.
Split(" ") divide la cadena morseCode en palabras basadas en el espacio triple, que indica el final de una palabra en código Morse.
StringSplitOptions.RemoveEmptyEntries se utiliza para eliminar las cadenas vacías después de la división, lo que puede ocurrir si hay espacios triples consecutivos.
List<string> decodedWords = new List<string>();:

Se crea una lista llamada decodedWords para almacenar las palabras decodificadas.
foreach (string word in words):

Se itera sobre cada palabra en la matriz words.
string[] letters = word.Split(' ');:

Se divide la palabra actual en caracteres individuales, utilizando el espacio como delimitador, ya que en el código Morse cada letra está separada por un espacio simple.
string decodedWord = "";:

Se inicializa una cadena vacía llamada decodedWord para almacenar la palabra decodificada.
foreach (string letter in letters):

Se itera sobre cada letra en la palabra actual.
if (MorseCode.ContainsKey(letter)):

Se verifica si la letra actual está presente como una clave en el diccionario MorseCode que mapea el código Morse a caracteres.
decodedWord += MorseCode[letter];:

Si la letra es válida, se agrega su equivalente al alfabeto o número al final de la palabra decodificada.
decodedWords.Add(decodedWord);:

Una vez que se decodifica completamente una palabra, se agrega a la lista de palabras decodificadas.
return string.Join(" ", decodedWords);:

Finalmente, todas las palabras decodificadas se unen en una sola cadena, separadas por un espacio simple, y se devuelve como el resultado de la función.
         */
    }
}