class Numbers
{
    public Numbers(params IEnumerable<int> numbers) { }
}
class Program
{
    static void Main()
    {
        Numbers numbers = new([1, 2, 3, 4]);

        Lock syncRef = new();

        lock (syncRef)
        {
            Console.WriteLine("New lock acquired.");
        }
    }
}
