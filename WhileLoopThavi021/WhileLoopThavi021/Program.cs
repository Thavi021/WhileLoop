using System;

namespace WhileLoopThavi021
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            string s;
            while(i < 6)
            {
                s = "Output\n";
                Console.WriteLine(i + ". "+s);
                i++;
            }
            
        }
    }
}
