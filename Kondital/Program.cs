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
        Console.Write("Indtast din vægt i kg: ");
        string? Vægt = Console.ReadLine();
        if (double.TryParse(Vægt, out double c))
        {
            BrugerKondital.Vægt = c;
        }

        Console.WriteLine("Dit kondital er: " + BrugerKondital.BeregnKondital() + " ml/kg/min");
        Console.WriteLine("Din maksimale iltindtagelse er: " + BrugerKondital.BeregnIltIndtagelse() + " l/ml");
    }
}

class Kondital
{
    public int MaxPuls { get; set; }
    public int HvilePuls { get; set; }
    public double Vægt { get; set; }

    public double BeregnKondital()
    {
        double intKondital = Math.Round((double)MaxPuls / HvilePuls * 15.3);
        return intKondital;
    }

    public double BeregnIltIndtagelse()
    {
        double intIltIndtagelse = Math.Round((double)BeregnKondital() / Vægt * 1000);
        return intIltIndtagelse;
    }
}