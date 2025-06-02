
class Program
{
    static void Main()
    {
        Numbers numbers = new([1, 2, 3, 4]);
        int total = numbers.Sum;
        Console.WriteLine($"Sum: {total}");

        Lock syncRef = new();

        lock (syncRef)
        {
            Console.WriteLine("New lock acquired.");
        }
    }
}

partial class Numbers
{
    public partial int Sum { get; set; }
    public Numbers(params IEnumerable<int> numbers) => Sum = numbers.Sum();
}

partial class Numbers
{
    private int _sum;
    public partial int Sum { get => _sum; set => _sum = value; }
}
