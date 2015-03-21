using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timer
{

    public delegate void Delegater(DateTime now);
    
    class Timer
    {
        public static void SevenSeconds(DateTime now)
        {
            int secondsInterval = 2;
            Console.WriteLine("The interval is {0} seconds.", secondsInterval);
            Console.WriteLine();
            int used = DateTime.Now.Second;
            while (true)
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
