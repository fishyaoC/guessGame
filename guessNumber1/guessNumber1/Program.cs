using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guessNumber1
{
    class Program
    {
        public static int test(string n, int max, int min)
        {
            try
            {
                int i = int.Parse(n);
                if (i > min - 1 && i < max + 1)
                    return 1;
                else
                {
                    Console.WriteLine("錯誤：輸入的數字超出範圍");
                    return 0;
                }
            }
            catch
            {
                Console.WriteLine("錯誤：輸入的不是整數");
                return 0;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("-------------------------");
            Console.WriteLine("***********歡迎**********");
            Console.WriteLine("***1、你有十次機會");
            Console.WriteLine("***2、隨機數的範圍為1-100");
            Console.WriteLine("-------------------------");
            Console.WriteLine("請輸入“Y/y”開始遊戲，輸入其他鍵退出遊戲");
            String S = Console.ReadLine();
            if (S == "Y" || S == "y")
            {
                Random R = new Random();
                int m = R.Next(1, 101);
                int max = 100;
                int min = 1;
                int i;

                Console.WriteLine("-----隨機數生成完畢------");
                for (i = 0; i < 10;)
                {
                    Console.WriteLine("第" + (i + 1) + "次機會，請輸入你的答案：");
                    String n = Console.ReadLine();
                    i++;

                    if (test(n, max, min) == 1)
                    {
                        int j = int.Parse(n);
                        if (i == 10)
                        {
                            Console.WriteLine("次數用盡，遊戲失敗！");
                            break;
                        }

                        if (j == m)
                        {
                            Console.WriteLine("恭喜你，猜對了");
                            break;
                        }
                        else if (j > m)
                        {
                            max = j ;
                            Console.WriteLine("猜錯了，範圍更新為[" + min + "-" + max + "]");
                            continue;
                        }
                        else if (j < m)
                        {
                            min = j ;
                            Console.WriteLine("猜錯了，範圍更新為[" + min + "-" + max + "]");
                            continue;
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("遊戲退出，按任意鍵退出");
            }
        }
    }
}