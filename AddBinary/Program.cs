using System;

namespace AddBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "100";
            string b = "110010";

            Solution solution = new Solution();
            string res = solution.AddBinary(a, b);
            Console.WriteLine(res);
        }
    }
}
