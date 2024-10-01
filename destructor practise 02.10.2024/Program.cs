using System.Collections;
using System.Collections.Generic;

class Program
{
    public static void Main(string[] args)
    {
        //Task1
        using (Film film = new Film("Film Title", "Studio", "Genre", 120, 2024))
        {

        }
        Film f = new Film("Film Title", "Studio", "Genre", 120, 2024);
        f.ShowInfo();
        f = null;
        GC.Collect(); //Вызываются автоматически
        GC.WaitForPendingFinalizers();

        //Task2
        using (Spectacle spectacle = new Spectacle("Title", "NameOfTheatre", "Genre", 60, 10))
        {
            Console.WriteLine($"Spectacle: {spectacle.title}");
        }
        Spectacle s = new Spectacle("Title", "NameOfTheatre", "Genre", 60, 10);
        s.ShowInfo();
        s = null;
        GC.Collect(); //Вызываются автоматически
        GC.WaitForPendingFinalizers();
    }
}
