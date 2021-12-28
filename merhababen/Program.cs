using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace merhababen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("İstediğiniz konutu seçin 1) Daire 2) villa");
            int secimkonut = int.Parse(Console.ReadLine());
            if (secimkonut==1)
            {
                Console.WriteLine("İstediğniz alma bicimi 1) satın 2) kiralama");
                int secimalıs = int.Parse(Console.ReadLine());
                if (secimalıs==1)
                {
                    Console.WriteLine("Bütçenizi giriniz:");
                    double butce = double.Parse(Console.ReadLine());
                    if (butce >= 50000)
                    {
                        Console.WriteLine("satın alabilirsiniz.");
                    }
                    else
                        Console.WriteLine("satın alamazsınız.");
                }
                else
                {
                    Console.WriteLine("Bütçenizi giriniz:");
                    double butce = double.Parse(Console.ReadLine());
                    if (butce>=1000)
                    {
                        Console.WriteLine("Kiralayabilirsiniz.");
                    }
                    else
                    {
                        Console.WriteLine("Kiralayamazsınız.");
                    }
                }
            }
            else
            {
                Console.WriteLine("İstediğniz alma bicimi 1) satın 2) kiralama");
                int secimalıs = int.Parse(Console.ReadLine());
                if (secimalıs == 1)
                {
                    Console.WriteLine("Bütçenizi giriniz:");
                    double butce = double.Parse(Console.ReadLine());
                    if (butce >= 500000)
                    {
                        Console.WriteLine("satın alabilirsiniz.");
                    }
                    else
                        Console.WriteLine("satın alamazsınız.");
                }
                else
                {
                    Console.WriteLine("Bütçenizi giriniz:");
                    double butce = double.Parse(Console.ReadLine());
                    if (butce >= 200000)
                    {
                        Console.WriteLine("Kiralayabilirsiniz.");
                    }
                    else
                    {
                        Console.WriteLine("Kiralayamazsınız.");
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
