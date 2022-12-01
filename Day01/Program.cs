namespace Day01
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string values = File.ReadAllText(@"C:\Repos\Advent of code\Day1\Day1\input.txt");
            string[] splitValues = values.Split(new[] { "\n\n" }, StringSplitOptions.None);

            var list = splitValues.Select(line => line.Split(new[] { "\n" }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).Sum())
                .OrderByDescending(x => x)
                .ToList();

            Console.WriteLine("Biggest number: " + list.First());
            Console.WriteLine("Biggest 3 numbers sum: " + (list.Take(3).Sum()));
        }
    }
}
