using System;

namespace KonditalBeregner;

class Program
{
    public static void Main()
    {
        Console.Write("Indtast din max puls i heltal slag i minuttet: ");
        int maxPuls = Convert.ToInt32(Console.ReadLine());
        Console.Write("Indtast din hvilepuls i heltal slag i minuttet: ");
        int hvilePuls = Convert.ToInt32(Console.ReadLine());
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