using System;

namespace KonditalBeregner;

class Program
{
    public static void Main()
    {
        int intMaxPuls = -1;
        int intHvilePuls = -1;
        Console.Write("Indtast din max puls i heltal slag i minuttet: ");
        string? MaxPuls = Console.ReadLine();
        if (int.TryParse(MaxPuls, out int a))
        {
            intMaxPuls = a;
        }
        Console.Write("Indtast din hvilepuls i heltal slag i minuttet: ");
        string? HvilePuls = Console.ReadLine();
        if (int.TryParse(HvilePuls, out int b))
        {
            intHvilePuls = b;
        }

        //create a static method to calculate kondital
        static double Kondital(int intMaxPuls, int intHvilePuls)
        {
            double intKondital = (double)intMaxPuls / intHvilePuls * 15.3;
            return intKondital;
        }
        Console.WriteLine("Dit kondital er: " + Kondital(intMaxPuls, intHvilePuls));
    }
}

class Kondital
{
    public int MaxPuls { get; set; }
    public int HvilePuls { get; set; }

    public Kondital(int maxPuls, int hvilePuls)
    {
        MaxPuls = maxPuls;
        HvilePuls = hvilePuls;
    }
}