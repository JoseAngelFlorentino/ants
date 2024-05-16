using System;
using System.Text.RegularExpressions;

public class Kata
{
    public static int DeadAntCount(string ants)
    {
        if (ants == null)
        {
            return 0;
        }

        // Reemplazar "ant" con ".."
        string removeliveAnts = Regex.Replace(ants, "ant", "..", RegexOptions.IgnoreCase);

        // Contar letras sueltas
        int aCount = Regex.Matches(removeliveAnts, "a").Count;
        int nCount = Regex.Matches(removeliveAnts, "n").Count;
        int tCount = Regex.Matches(removeliveAnts, "t").Count;

        // Devolver el máximo número de partes
        return Math.Max(Math.Max(aCount, nCount), tCount);
    }

    public static void Main()
    {
        string ants = "...ant...ant..nat.ant.t..ant...ant..ant..ant.anant..t";
        Console.WriteLine(DeadAntCount(ants) + " ants died during the stampede.");  // Output: 3
        Console.ReadLine();
    }
}