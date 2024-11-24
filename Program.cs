using System;
using System.Collections.Generic;

public class Limonadas
{
    public bool DarCambio(int[] billetes)
    {
        int cinco = 0, diez = 0;

        foreach (int billete in billetes)
        {
            if (billete == 5)
            {
                cinco++;
            }
            else if (billete == 10)
            {
                if (cinco == 0)
                {
                    return false;
                }
                cinco--;
                diez++;
            }
            else if (billete == 20)
            {
                if (diez > 0 && cinco > 0)
                {
                    diez--;
                    cinco--;
                }
                else if (cinco >= 3)
                {
                    cinco -= 3;
                }
                else
                {
                    return false;
                }
            }
        }
        return true;
    }

    public static void Main(string[] args)
    {
        Limonadas puesto = new Limonadas();

        Console.WriteLine(puesto.DarCambio(new int[] { 5, 5, 5, 10, 20 }));
        Console.WriteLine(puesto.DarCambio(new int[] { 5, 5, 10, 10, 20 }));
        Console.WriteLine(puesto.DarCambio(new int[] { 10, 10 }));
        Console.WriteLine(puesto.DarCambio(new int[] { 5, 5, 10 }));
    }
}
