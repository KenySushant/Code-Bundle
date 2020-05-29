namespace Speed_Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            long cycles = 1000000000;

            System.DateTime Start = System.DateTime.Now;

            for (long i = 0; i < cycles; i++)
            {
                // Empty Loop
            }

            System.DateTime End = System.DateTime.Now;

            double duration = End.Subtract(Start).TotalSeconds;

            System.Console.WriteLine("It took {0} seconds to process {1} cycles in C#", duration, cycles);
        }
    }
}
