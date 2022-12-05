using System;

namespace Kondital;

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

