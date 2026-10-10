namespace ExtensionMethodElapsedTime
{
    class Program
    {
        static void Main()
        {
            DateTime dt = new DateTime(2026, 10, 10, 8, 10, 45);
            Console.WriteLine(dt.ElapsedTime());
        }
    }
}