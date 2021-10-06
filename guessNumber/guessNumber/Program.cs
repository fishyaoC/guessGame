using System;

namespace guessNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int max = 100, min = 1;
            int password = r.Next(2, 99);
            int guest;
            while (true)
            {
                Console.Write("請輸入一個數字, 介於{0}~{1}之間 : ", min, max);

                
                try
                {   
                    guest = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception )
                {
                    continue;
                }

                if (guest == password)
                {
                    Console.WriteLine("答對了");
                    break;
                }
                else if (guest < password)
                {
                    Console.Write("太小了, ");
                    min = guest;
                }
                else
                {
                    Console.Write("太大了, ");
                    max = guest;
                }
            }
        }
    }
}

   

