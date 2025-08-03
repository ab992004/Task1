namespace MainTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Number of small carpets: ");
            int SmallCarpet = Convert.ToInt32(Console.ReadLine());
            Console.Write("Number of large carpets: ");
            int LargeCarpet = Convert.ToInt32(Console.ReadLine());
            int TotalPribe = SmallCarpet * 25 + LargeCarpet * 35;
            double TotalWithTax = TotalPribe + TotalPribe * 0.06;
            Console.WriteLine($"Total estimate: ${TotalWithTax}");

        }
    }
}
