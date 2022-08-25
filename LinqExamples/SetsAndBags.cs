namespace SetsAndBags;

public class SetsAndBags
{
    public static void output(IEnumerable<string> cohort)
    {
        Console.Write("");
        Console.WriteLine(string.Join(", ", cohort.ToArray()));
        Console.WriteLine("");
    }
}