using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Spectacle : IDisposable
{
    private bool disposed = false;
    public string title { get; set; }
    public string nameOfTheatre { get; set; }
    public string genre { get; set; }
    public int Duration { get; set; }
    public int listOfActors { get; set; }
    public Spectacle(string title, string nameOfTheatre, string genre, int duration, int listOfActors)
    {
        this.title = title;
        this.nameOfTheatre = nameOfTheatre;
        this.genre = genre;
        Duration = duration;
        this.listOfActors = listOfActors;
    }

    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }
    protected virtual void Dispose(bool disposing)
    {
        if (disposed) return;
        { }

        if (disposing)
        {
            // Освобождаем управляемые ресурсы
        }
        // освобождаем неуправляемые объекты
        disposed = true;
    }
    ~Spectacle()
    {
        Dispose(false);
        Console.WriteLine($"Spectacle '{title}' has been removed from memory."); 
    }
}
