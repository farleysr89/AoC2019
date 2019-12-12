using System;

namespace AdventCode4
{
    class Program
    {
        static void Main(string[] args)
        {
            int lower = 153517;
            int upper = 630395;
            int count = 0;
            for(int x = lower;x<= upper; x++)
            {
                if (DupCheck(x.ToString()) && IncCheck(x.ToString()))
                    count++;
            }
            Console.WriteLine(count);
            //Console.WriteLine(DupCheck("111111"));
            //Console.WriteLine(IncCheck("111111"));            
            //Console.WriteLine(DupCheck("223450"));
            //Console.WriteLine(IncCheck("223450"));            
            //Console.WriteLine(DupCheck("123789"));
            //Console.WriteLine(IncCheck("123789"));
        }

        public static bool DupCheck(string x)
        {
            int[] counts = new int[10];
            foreach (char z in x)
            {
                counts[Int32.Parse(z.ToString())] += 1;
            }
            foreach(int z in counts)
            {
                if (z == 2)
                    return true;
            }
            return false;
        }        
        public static bool IncCheck(string x)
        {
            int y = x[0];
            foreach(int z in x.Substring(1))
            {
                if (z < y)
                    return false;
                y = z;
            }
            return true;
        }
    }
}
