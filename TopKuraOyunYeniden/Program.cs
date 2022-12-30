using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopKuraOyunYeniden
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Oyun oyunum=new Oyun(); 
            oyunum.start();
            oyunum.Play();
            Console.ReadLine();
        }
    }
}
