using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopKuraOyunYeniden
{
    internal class Oyun
    {
        Torba torba=new Torba();
        Player player1;
        Player player2;
        int[] valuesofBalls;

        public void start()
        {
            player1 = new Player();
            player2 = new Player();
            valuesofBalls = new int[5];
            torba.olustur();
            torba.shuffle();
        }
        public void Play()
        {
            choosing();
            ComputerChoosing();
            Compare();
            Display();
        }
        public void choosing()
        {
            for(int i = 0; i < 5; i++)
            {
                Console.Write("Oyuncu1 için {0}.top numarası seçin==> ",i+1);
                player1.secim[i]=Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("======================================");
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Oyuncu2 için {0}.top numaları seçin==> ",i+1);
                player2.secim[i] = Convert.ToInt32(Console.ReadLine());
            }

        }
        public void ComputerChoosing()
        {
            for(int i=0; i < 5; i++)
            {
                valuesofBalls[i] = torba.Draw();
            }
        }
        public void Compare()
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (player1.secim[j] == valuesofBalls[i])
                    {
                        player1.score++;
                    }
                    else if (player2.secim[j] == valuesofBalls[i])
                    {
                        player2.score++;
                    }
                }
            }
        }
        public void Display()
        {
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Oyuncu 1 seçimleri ==>");
            for(int i = 0; i < 5; i++)
            {
                Console.Write(player1.secim[i]+" ");
            }
            Console.WriteLine("\nOyuncu 2 seçimleri ==>");
            for (int i = 0; i < 5; i++)
            {
                Console.Write(player2.secim[i] + " ");
            }
            Console.WriteLine("\nBilgisayarın seçimleri ==>");
            for (int i = 0; i < 5; i++)
            {
                Console.Write(valuesofBalls[i] + " ");
            }
            Console.WriteLine("\n========================================");
            if(player1.score > player2.score)
            {
                Console.WriteLine("Oyuncu 1 kazandı");
            }
            else if(player2.score > player1.score)
            {
                Console.WriteLine("Oyuncu 2 kazandı");
            }
            else
            {
                Console.WriteLine("Berabere");
            }
        }
    }
}
