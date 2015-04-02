namespace Timer
{
    using System;

    public delegate void Delegater(DateTime now);
    
    class Timer
    {
        public static void SevenSeconds(DateTime now)
        {
            int secondsInterval = 2;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("//Press any key to stop the program//");
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine("The interval is {0} seconds.", secondsInterval);
            Console.WriteLine();
            int used = DateTime.Now.Second;
            while (!Console.KeyAvailable)
            {
                if ((DateTime.Now.Second - secondsInterval) == used && DateTime.Now.Second != used)
                {
                    Console.WriteLine(DateTime.Now);
                    used = DateTime.Now.Second;
                }
            }
        }

        static void Main()
        {
            Delegater del = new Delegater(SevenSeconds);
            del(DateTime.Now);
        }
    }
}
