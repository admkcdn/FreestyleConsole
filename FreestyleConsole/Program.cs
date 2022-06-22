using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZarOdev
{
    internal class Program
    {
        public static int counter = 0;
        static void Main(string[] args)
        {
            Console.Write("kaç adet zat atılaccak onu bi alayım efendim hemen gönder şimdi: ");
            int diceCounter = int.Parse(Console.ReadLine());

            Dice zar = new Dice(diceCounter);

            zar.roll();
            //zar.showNumbers();
            //zar.calculatePoints();


            Console.ReadKey();
        }

        class Dice
        {
            private string numbers = "";
            private int point = 0;
            private int diceCounter = 0;
            Random random = new Random();

            public Dice(int DiceCounter)
            {
                this.diceCounter = DiceCounter;
            }


            public void roll()
            {
                int rolled;
                int j = 0;

                for (int i = 0; i < diceCounter; i++)
                {
                    rolled = random.Next(1, 7);
                    if (rolled % 2 == 0)
                    {
                        //numbers = numbers + rolled.ToString() + ' ';
                        //Console.WriteLine("Gelen sayı: {0}",rolled);
                        if (j == i - 1)
                        {
                            i--;
                        }
                        else
                        {
                            Console.WriteLine("Gelen sayı: {0} --- {1}", rolled, i);
                            j = i;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Gelen sayı: {0} --- {1}", rolled, i);
                    }
                }
            }

            public void showNumbers()
            {
                numbers = numbers.Trim();
                var numbersAll = numbers.Split(' ').Select(Int32.Parse).ToArray();
                for (int i = 0; i < numbersAll.Length; i++)
                {
                    Console.WriteLine("{0}. atışta gelen sayı: {1}", (i + 1), (numbersAll[i]));
                }
            }

            public void calculatePoints()
            {
                if (point >= 500)
                {
                    Console.WriteLine("KAZANDINIZ! --- Puanınız: {0}", point);
                }
                else
                {
                    Console.WriteLine("KAYBETTİNİZ!--- Puanınız: {0}", point);
                }
            }
        }
    }
}