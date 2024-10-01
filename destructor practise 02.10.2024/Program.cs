using System.Collections;
using System.Collections.Generic;

class Program
{
    public static void Main(string[] args)
    {
        //Task1
        Film film = new Film("Film Title", "Studio", "Genre", 120, 2024);
        film.ShowInfo();
        film = null;
        GC.Collect(); //Вызываются автоматически
        GC.WaitForPendingFinalizers();

        //Task2
        using (var spectacle = new Spectacle("Title", "NameOfTheatre", "Genre", 60, 10))
        {
            Console.WriteLine($"Spectacle: {spectacle.title}");
        }
    }
}