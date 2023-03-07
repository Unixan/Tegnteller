namespace Tegnteller
{
    internal class Program
    {
        static void Main()
        {
            var range = 250;
            int maxPercent = 0;
            var counts = new int[range];
            string text = "something";
            while (!string.IsNullOrWhiteSpace(text))
            {
                text = Console.ReadLine();
                foreach (var character in text.ToUpper())
                {
                    maxPercent++;
                    counts[(int)character]++;
                }
                for (var i = 0; i < range; i++)
                {
                    if (counts[i] > 0)
                    {
                        var character = (char)i;
                        double percent = (100 / (double)maxPercent) * (double)counts[i];
                        string print = character + " (" + percent.ToString("F1") + "%)";
                        Console.CursorLeft = Console.BufferWidth - print.Length - 1;
                        Console.WriteLine(print);
                    }
                }
            }
        }
    }
}