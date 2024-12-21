using System;

class TimeSpanConverter
{
    
    public int Minutes { get; set; }
    public int Seconds { get; set; }

    
    public TimeSpanConverter(int minutes, int seconds)
    {
        Minutes = minutes;
        Seconds = seconds;
    }

    
    public int TotalSeconds()
    {
        return (Minutes * 60) + Seconds;
    }
}

class Program
{
    static void Main()
    {
    
        Console.Write("Введите количество минут: ");
        int minutes = int.Parse(Console.ReadLine());

        Console.Write("Введите количество секунд: ");
        int seconds = int.Parse(Console.ReadLine());

        
        TimeSpanConverter timeSpan = new TimeSpanConverter(minutes, seconds);

        
        int totalSeconds = timeSpan.TotalSeconds();
        Console.WriteLine($"Общее количество секунд: {totalSeconds}");
    }
}
