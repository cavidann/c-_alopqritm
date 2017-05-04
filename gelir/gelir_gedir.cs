using System;

namespace ConsoleApp1
{
    class gelir_gedir
    {
        static void Main(string[] args)
        {
            Console.Write("gunluk geliri daxil edin : ");
            int gunluk_gelir=Convert.ToInt16(Console.ReadLine());
            Console.Write("gun sayini daxil edin : ");
            int gun_sayi= Convert.ToInt16(Console.ReadLine());
            int brut_gelir = gunluk_gelir * gun_sayi;
            double faiz= (brut_gelir>=1000)?faiz=brut_gelir*0.18 : faiz=brut_gelir*0.04;
            double net_gelir = brut_gelir - faiz;
            Console.Write("faiz : {0}, \n net_gelir: {1}", faiz, net_gelir);
            Console.ReadLine();
        }
    }
}