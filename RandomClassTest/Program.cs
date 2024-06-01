namespace RandomClassTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int randomInt = random.Next();
            Console.WriteLine(randomInt);

            int zeroToNine = random.Next(10);
            Console.WriteLine(zeroToNine);

            int dieRoll = random.Next(1, 7);
            Console.WriteLine(dieRoll);

            double randomDouble = random.NextDouble();
            Console.WriteLine("Random double: " + randomDouble*100);
            Console.WriteLine("Rzutowanie na float: " + (float)randomDouble * 100F);
            Console.WriteLine("Rzutowanie na decimal: " + (decimal)randomDouble * 100M);

            int zeroOrOne = random.Next(2);
            bool coinFlip = Convert.ToBoolean(zeroOrOne);
            Console.WriteLine(coinFlip);
        }
    }
}
