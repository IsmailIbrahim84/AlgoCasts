using System;

namespace reversestring
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "apple";
             char[] resutl;
            string temp="";
            resutl = input.ToCharArray();

            for (int i=resutl.Length-1;i>=0;i--)
            {
                temp += resutl[i];
            }
          // Console.WriteLine (temp);
        }

        
    }
}
