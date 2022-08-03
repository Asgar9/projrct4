using System;

namespace tester
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "agilli cirmaninca ,deli vurdu cayi kecdi";
            bool cas= false;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i]=='a')
                {
                    cas = true; 
                }
            }
            if (cas)
            {
                Console.WriteLine("there is a charachter");
            }
            else
            {
                Console.WriteLine("there is no a charachter");
            }
        }

    }
}
