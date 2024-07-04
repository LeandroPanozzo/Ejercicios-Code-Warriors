/*
 Dada una cadena, cree una función para invertir el caso. Todas las letras minúsculas deben estar en mayúsculas y viceversa.

Ejemplos
ReverseCase("Happy Birthday") ➞ "hAPPY bIRTHDAY"

ReverseCase("MANY THANKS") ➞ "many thanks"

ReverseCase("sPoNtAnEoUs") ➞ "SpOnTaNeOuS"
 */
using System;
public class Program
{
    public static string ReverseCase(string str)
    {
        string cambio="";

        foreach(char c in str)
        {
            if (char.IsUpper(c))
            {
                cambio += char.ToLower(c);
            }
            else
            {
                if ((char.IsLower(c)))
                {
                    cambio += char.ToUpper(c);
                }
                else
                {
                    cambio += c;
                }
                
            }
        }
            return cambio;
    }
}