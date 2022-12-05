using System;

namespace KonditalBeregner;

class Program
{
    public static void Main()
    {
        Kondital BrugerKondital = new Kondital();
        Console.Write("Indtast din max puls i heltal slag i minuttet: ");
        string? MaxPuls = Console.ReadLine();
        if (int.TryParse(MaxPuls, out int a))
        {
            BrugerKondital.MaxPuls = a;
        }
        Console.Write("Indtast din hvilepuls i heltal slag i minuttet: ");
        string? HvilePuls = Console.ReadLine();
        if (int.TryParse(HvilePuls, out int b))
        {
            BrugerKondital.HvilePuls = b;
        }

        Console.WriteLine("Dit kondital er: " + BrugerKondital.BeregnKondital());
    }
}

class Kondital
{
    public int MaxPuls { get; set; }
    public int HvilePuls { get; set; }

    public double BeregnKondital()
    {
        double intKondital = Math.Round((double)MaxPuls / HvilePuls * 15.3);
        return intKondital;
    }
}