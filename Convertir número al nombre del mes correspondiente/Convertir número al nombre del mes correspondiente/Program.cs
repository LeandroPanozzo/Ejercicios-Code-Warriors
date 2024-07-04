/*
 Cree una función que tome un número (del 1 al 12) y devuelva el nombre del mes correspondiente como una cadena.
Por ejemplo, si se le proporciona 3como entrada, su función debería devolver "March", porque marzo es el tercer mes.
 */
public class Program
{
    public static string MonthName(int num)
    {
        string[] months = { "enero", "febrero", "marzo", "abril", "mayo", "junio", "julio", "agosto", "septiembre", "octubre", "noviembre", "diciembre" };
        string mes="";
        for (int i = 0; i < months.Length; i++)
        {
            if (i+1==num)
            {
                mes= months[i];
                break;
            }
        }
        return mes;
    }
}