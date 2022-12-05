using System;

namespace KonditalBeregner;

class Program
{
    public static void Main()
    {
        Console.Write("Indtast din max puls i heltal slag i minuttet: ");
        if (!int.TryParse(Console.ReadLine(), out int MaxPuls))
            throw new Exception();

        Console.Write("Indtast din hvilepuls i heltal slag i minuttet: ");
        if (!int.TryParse(Console.ReadLine(), out int HvilePuls))
            throw new Exception();

        Console.Write("Indtast din vægt i kg: ");
        if (!double.TryParse(Console.ReadLine(), out double Vægt))
            throw new Exception();

        Console.WriteLine("Dit kondital er: " + Kondital.BeregnKondital(MaxPuls, HvilePuls) + " ml/kg/min");
        Console.WriteLine("Din maksimale iltindtagelse er: " + Kondital.BeregnIltIndtagelse(MaxPuls, HvilePuls, Vægt) + " l/ml");
    }
}

class Kondital
{

    public static double BeregnKondital(int MaxPuls, int HvilePuls)
    {
        double intKondital = Math.Round((double)MaxPuls / HvilePuls * 15.3);
        return intKondital;
    }

    public static double BeregnIltIndtagelse(int MaxPuls, int HvilePuls, double Vægt)
    {
        double intIltIndtagelse = Math.Round((double)Kondital.BeregnKondital(MaxPuls, HvilePuls) / Vægt * 1000);
        return intIltIndtagelse;
    }
}