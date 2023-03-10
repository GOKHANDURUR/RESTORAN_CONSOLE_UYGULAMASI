using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restoran_v1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int toplamkazanc = 0, toplambahsis = 0, masa1kazanc = 0, masa2kazanc = 0, masa3kazanc = 0, masa4kazanc = 0, masa5kazanc = 0, masa1bahsis = 0, masa2bahsis = 0, masa3bahsis = 0, masa4bahsis = 0, masa5bahsis = 0;
            Urunler masa1 = new Urunler();
            masa1.kucukboy = 0;
            masa1.ortaboy = 0;
            masa1.buyukboy = 0;
            masa1.sarımsaklıekmek = 0;
            masa1.tavukparcaları = 0;
            masa1.patates = 0;
            masa1.mozaikpasta = 0;
            masa1.tiramisu = 0;
            masa1.sufle = 0;
            masa1.kucukayran = 0;
            masa1.buyukayran = 0;
            masa1.su = 0;
            masa1.durum = false;

            Urunler masa2 = new Urunler();
            masa2.kucukboy = 0;
            masa2.ortaboy = 0;
            masa2.buyukboy = 0;
            masa2.sarımsaklıekmek = 0;
            masa2.tavukparcaları = 0;
            masa2.patates = 0;
            masa2.mozaikpasta = 0;
            masa2.tiramisu = 0;
            masa2.sufle = 0;
            masa2.kucukayran = 0;
            masa2.buyukayran = 0;
            masa2.su = 0;
            masa2.durum = false;

            Urunler masa3 = new Urunler();
            masa3.kucukboy = 0;
            masa3.ortaboy = 0;
            masa3.buyukboy = 0;
            masa3.sarımsaklıekmek = 0;
            masa3.tavukparcaları = 0;
            masa3.patates = 0;
            masa3.mozaikpasta = 0;
            masa3.tiramisu = 0;
            masa3.sufle = 0;
            masa3.kucukayran = 0;
            masa3.buyukayran = 0;
            masa3.su = 0;
            masa3.durum = false;

            Urunler masa4 = new Urunler();
            masa4.kucukboy = 0;
            masa4.ortaboy = 0;
            masa4.buyukboy = 0;
            masa4.sarımsaklıekmek = 0;
            masa4.tavukparcaları = 0;
            masa4.patates = 0;
            masa4.mozaikpasta = 0;
            masa4.tiramisu = 0;
            masa4.sufle = 0;
            masa4.kucukayran = 0;
            masa4.buyukayran = 0;
            masa4.su = 0;
            masa4.durum = false;

            Urunler masa5 = new Urunler();
            masa5.kucukboy = 0;
            masa5.ortaboy = 0;
            masa5.buyukboy = 0;
            masa5.sarımsaklıekmek = 0;
            masa5.tavukparcaları = 0;
            masa5.patates = 0;
            masa5.mozaikpasta = 0;
            masa5.tiramisu = 0;
            masa5.sufle = 0;
            masa5.kucukayran = 0;
            masa5.buyukayran = 0;
            masa5.su = 0;
            masa5.durum = false;

        An:
            AnaMenu rest = new AnaMenu();
            rest.anamenu();
            Console.Write("SEÇİMİNİZ:");
            int islem = Convert.ToInt32(Console.ReadLine());
            switch (islem)
            {
                case 1:
                    {
                    Z:
                        rest.masadurum(masa1.durum, masa2.durum, masa3.durum, masa4.durum, masa5.durum);
                        int masa = Convert.ToInt32(Console.ReadLine());
                        switch (masa)
                        {
                            case 1:
                                {
                                X:
                                    rest.menu();
                                    Console.WriteLine("         1.MASA SİPARİŞLERİ");
                                    Console.WriteLine("----------------------------------");
                                    rest.siparisler(masa1.kucukboy, masa1.ortaboy, masa1.buyukboy, masa1.sarımsaklıekmek, masa1.tavukparcaları, masa1.patates,
                                    masa1.sufle, masa1.tiramisu, masa1.mozaikpasta, masa1.kucukayran, masa1.buyukayran, masa1.su);
                                    int ekle = Convert.ToInt32(Console.ReadLine());
                                    switch (ekle)
                                    {
                                        case 1:
                                            {
                                                rest.menusip();
                                                int siparis = Convert.ToInt32(Console.ReadLine());
                                                if (siparis == 1)
                                                {
                                                    masa1.kucukboy++;
                                                }
                                                if (siparis == 2)
                                                {
                                                    masa1.ortaboy++;
                                                }
                                                if (siparis == 3)
                                                {
                                                    masa1.buyukboy++;
                                                }
                                                if (siparis == 4)
                                                {
                                                    masa1.sarımsaklıekmek++;
                                                }
                                                if (siparis == 5)
                                                {
                                                    masa1.tavukparcaları++;
                                                }
                                                if (siparis == 6)
                                                {
                                                    masa1.patates++;
                                                }
                                                if (siparis == 7)
                                                {
                                                    masa1.sufle++;
                                                }
                                                if (siparis == 8)
                                                {
                                                    masa1.tiramisu++;
                                                }
                                                if (siparis == 9)
                                                {
                                                    masa1.mozaikpasta++;
                                                }
                                                if (siparis == 10)
                                                {
                                                    masa1.kucukayran++;
                                                }
                                                if (siparis == 11)
                                                {
                                                    masa1.buyukayran++;
                                                }
                                                if (siparis == 12)
                                                {
                                                    masa1.su++;
                                                }
                                                if (siparis == 13)
                                                {
                                                    goto X;
                                                }
                                                goto X;
                                            }
                                        case 2:
                                            {
                                                goto Z;
                                            }
                                        case 3:
                                            {
                                                masa1.durum = true;
                                                goto An;
                                            }
                                        case 0:
                                            {
                                                goto An;
                                            }
                                    }
                                    break;
                                }
                            case 2:
                                {
                                X2:
                                    rest.menu();
                                    Console.WriteLine("         2.MASA SİPARİŞLERİ");
                                    Console.WriteLine("----------------------------------");
                                    rest.siparisler(masa2.kucukboy, masa2.ortaboy, masa2.buyukboy, masa2.sarımsaklıekmek, masa2.tavukparcaları, masa2.patates,
                                     masa2.sufle, masa2.tiramisu, masa2.mozaikpasta, masa2.kucukayran, masa2.buyukayran, masa2.su);
                                    int ekle = Convert.ToInt32(Console.ReadLine());
                                    switch (ekle)
                                    {
                                        case 1:
                                            {
                                                rest.menusip();
                                                int siparis = Convert.ToInt32(Console.ReadLine());
                                                if (siparis == 1)
                                                {
                                                    masa2.kucukboy++;
                                                }
                                                if (siparis == 2)
                                                {
                                                    masa2.ortaboy++;
                                                }
                                                if (siparis == 3)
                                                {
                                                    masa2.buyukboy++;
                                                }
                                                if (siparis == 4)
                                                {
                                                    masa2.sarımsaklıekmek++;
                                                }
                                                if (siparis == 5)
                                                {
                                                    masa2.tavukparcaları++;
                                                }
                                                if (siparis == 6)
                                                {
                                                    masa2.patates++;
                                                }
                                                if (siparis == 7)
                                                {
                                                    masa2.sufle++;
                                                }
                                                if (siparis == 8)
                                                {
                                                    masa2.tiramisu++;
                                                }
                                                if (siparis == 9)
                                                {
                                                    masa2.mozaikpasta++;
                                                }
                                                if (siparis == 10)
                                                {
                                                    masa2.kucukayran++;
                                                }
                                                if (siparis == 11)
                                                {
                                                    masa2.buyukayran++;
                                                }
                                                if (siparis == 12)
                                                {
                                                    masa2.su++;
                                                }
                                                if (siparis == 13)
                                                {
                                                    goto X2;
                                                }
                                                goto X2;
                                            }
                                        case 2:
                                            {
                                                goto Z;
                                            }
                                        case 0:
                                            {
                                                goto An;
                                            }
                                        case 3:
                                            {
                                                masa2.durum = true;
                                                goto An;
                                            }
                                    }
                                    break;
                                }
                            case 3:
                                {
                                X:
                                    rest.menu();
                                    Console.WriteLine("         3.MASA SİPARİŞLERİ");
                                    Console.WriteLine("----------------------------------");
                                    rest.siparisler(masa3.kucukboy, masa3.ortaboy, masa3.buyukboy, masa3.sarımsaklıekmek, masa3.tavukparcaları, masa3.patates,
                                    masa3.sufle, masa3.tiramisu, masa3.mozaikpasta, masa3.kucukayran, masa3.buyukayran, masa3.su);
                                    int ekle = Convert.ToInt32(Console.ReadLine());
                                    switch (ekle)
                                    {
                                        case 1:
                                            {
                                                rest.menusip();
                                                int siparis = Convert.ToInt32(Console.ReadLine());
                                                if (siparis == 1)
                                                {
                                                    masa3.kucukboy++;
                                                }
                                                if (siparis == 2)
                                                {
                                                    masa3.ortaboy++;
                                                }
                                                if (siparis == 3)
                                                {
                                                    masa3.buyukboy++;
                                                }
                                                if (siparis == 4)
                                                {
                                                    masa3.sarımsaklıekmek++;
                                                }
                                                if (siparis == 5)
                                                {
                                                    masa3.tavukparcaları++;
                                                }
                                                if (siparis == 6)
                                                {
                                                    masa3.patates++;
                                                }
                                                if (siparis == 7)
                                                {
                                                    masa3.sufle++;
                                                }
                                                if (siparis == 8)
                                                {
                                                    masa3.tiramisu++;
                                                }
                                                if (siparis == 9)
                                                {
                                                    masa3.mozaikpasta++;
                                                }
                                                if (siparis == 10)
                                                {
                                                    masa3.kucukayran++;
                                                }
                                                if (siparis == 11)
                                                {
                                                    masa3.buyukayran++;
                                                }
                                                if (siparis == 12)
                                                {
                                                    masa3.su++;
                                                }
                                                if (siparis == 13)
                                                {
                                                    goto X;
                                                }
                                                goto X;

                                            }
                                        case 2:
                                            {
                                                goto Z;
                                            }
                                        case 0:
                                            {
                                                goto An;
                                            }
                                        case 3:
                                            {
                                                masa3.durum = true;
                                                goto An;
                                            }
                                    }
                                    break;
                                }
                            case 4:
                                {
                                X:
                                    rest.menu();
                                    Console.WriteLine("         4.MASA SİPARİŞLERİ");
                                    Console.WriteLine("----------------------------------");
                                    rest.siparisler(masa4.kucukboy, masa4.ortaboy, masa4.buyukboy, masa4.sarımsaklıekmek, masa4.tavukparcaları, masa4.patates,
                                    masa4.sufle, masa4.tiramisu, masa4.mozaikpasta, masa4.kucukayran, masa4.buyukayran, masa4.su);
                                    int ekle = Convert.ToInt32(Console.ReadLine());
                                    switch (ekle)
                                    {
                                        case 1:
                                            {
                                                rest.menusip();
                                                int siparis = Convert.ToInt32(Console.ReadLine());
                                                if (siparis == 1)
                                                {
                                                    masa4.kucukboy++;
                                                }
                                                if (siparis == 2)
                                                {
                                                    masa4.ortaboy++;
                                                }
                                                if (siparis == 3)
                                                {
                                                    masa4.buyukboy++;
                                                }
                                                if (siparis == 4)
                                                {
                                                    masa4.sarımsaklıekmek++;
                                                }
                                                if (siparis == 5)
                                                {
                                                    masa4.tavukparcaları++;
                                                }
                                                if (siparis == 6)
                                                {
                                                    masa4.patates++;
                                                }
                                                if (siparis == 7)
                                                {
                                                    masa4.sufle++;
                                                }
                                                if (siparis == 8)
                                                {
                                                    masa4.tiramisu++;
                                                }
                                                if (siparis == 9)
                                                {
                                                    masa4.mozaikpasta++;
                                                }
                                                if (siparis == 10)
                                                {
                                                    masa4.kucukayran++;
                                                    goto X;
                                                }
                                                if (siparis == 11)
                                                {
                                                    masa4.buyukayran++;
                                                    goto X;
                                                }
                                                if (siparis == 12)
                                                {
                                                    masa4.su++;
                                                    goto X;
                                                }
                                                if (siparis == 13)
                                                {
                                                    goto X;
                                                }
                                                break;

                                            }
                                        case 2:
                                            {
                                                goto Z;
                                            }
                                        case 0:
                                            {
                                                goto An;
                                            }
                                        case 3:
                                            {
                                                masa4.durum = true;
                                                goto An;
                                            }
                                    }
                                    break;
                                }
                            case 5:
                                {
                                X:
                                    rest.menu();
                                    Console.WriteLine("         5.MASA SİPARİŞLERİ");
                                    Console.WriteLine("----------------------------------");
                                    rest.siparisler(masa5.kucukboy, masa5.ortaboy, masa5.buyukboy, masa5.sarımsaklıekmek, masa5.tavukparcaları, masa5.patates,
                                    masa5.sufle, masa5.tiramisu, masa5.mozaikpasta, masa5.kucukayran, masa5.buyukayran, masa5.su);
                                    int ekle = Convert.ToInt32(Console.ReadLine());
                                    switch (ekle)
                                    {
                                        case 1:
                                            {
                                                rest.menusip();
                                                int siparis = Convert.ToInt32(Console.ReadLine());
                                                if (siparis == 1)
                                                {
                                                    masa5.kucukboy++;
                                                }
                                                if (siparis == 2)
                                                {
                                                    masa5.ortaboy++;
                                                }
                                                if (siparis == 3)
                                                {
                                                    masa5.buyukboy++;
                                                }
                                                if (siparis == 4)
                                                {
                                                    masa5.sarımsaklıekmek++;
                                                }
                                                if (siparis == 5)
                                                {
                                                    masa5.tavukparcaları++;
                                                }
                                                if (siparis == 6)
                                                {
                                                    masa5.patates++;
                                                }
                                                if (siparis == 7)
                                                {
                                                    masa5.sufle++;
                                                }
                                                if (siparis == 8)
                                                {
                                                    masa5.tiramisu++;
                                                }
                                                if (siparis == 9)
                                                {
                                                    masa5.mozaikpasta++;
                                                }
                                                if (siparis == 10)
                                                {
                                                    masa5.kucukayran++;
                                                }
                                                if (siparis == 11)
                                                {
                                                    masa5.buyukayran++;
                                                }
                                                if (siparis == 12)
                                                {
                                                    masa5.su++;
                                                }
                                                if (siparis == 13)
                                                {
                                                    goto X;
                                                }
                                                goto X;

                                            }
                                        case 2:
                                            {
                                                goto Z;
                                            }
                                        case 0:
                                            {
                                                goto An;
                                            }
                                        case 3:
                                            {
                                                masa5.durum = true;
                                                goto An;
                                            }

                                    }
                                    break;
                                }

                        }
                        break;
                    }
                case 2:
                    {
                    Z:
                        rest.masadurum(masa1.durum, masa2.durum, masa3.durum, masa4.durum, masa5.durum);
                        int masa = Convert.ToInt32(Console.ReadLine());
                        switch (masa)
                        {
                            case 1:
                                {
                                    Console.WriteLine("         1.MASA SİPARİŞLERİ");
                                    Console.WriteLine("----------------------------------");
                                    rest.siparisler3(masa1.kucukboy, masa1.ortaboy, masa1.buyukboy, masa1.sarımsaklıekmek, masa1.tavukparcaları, masa1.patates,
                                    masa1.sufle, masa1.tiramisu, masa1.mozaikpasta, masa1.kucukayran, masa1.buyukayran, masa1.su);
                                    Console.WriteLine("----------------------------------");
                                    Console.WriteLine("SİPARİŞ EKLE [1]");
                                    Console.WriteLine("SİPARİŞ SİL  [2]");
                                    Console.WriteLine("ANA MENU     [0]");
                                    int Secim = Convert.ToInt32((Console.ReadLine()));
                                    switch (Secim)
                                    {
                                        case 1:
                                            {
                                            X:
                                                rest.menu();
                                                Console.WriteLine("         1.MASA SİPARİŞLERİ");
                                                Console.WriteLine("----------------------------------");
                                                rest.siparisler(masa1.kucukboy, masa1.ortaboy, masa1.buyukboy, masa1.sarımsaklıekmek, masa1.tavukparcaları, masa1.patates,
                                                masa1.sufle, masa1.tiramisu, masa1.mozaikpasta, masa1.kucukayran, masa1.buyukayran, masa1.su);
                                                int ekle = Convert.ToInt32(Console.ReadLine());
                                                switch (ekle)
                                                {
                                                    case 1:
                                                        {
                                                            rest.menusip();
                                                            int siparis = Convert.ToInt32(Console.ReadLine());
                                                            if (siparis == 1)
                                                            {
                                                                masa1.kucukboy++;
                                                            }
                                                            if (siparis == 2)
                                                            {
                                                                masa1.ortaboy++;
                                                            }
                                                            if (siparis == 3)
                                                            {
                                                                masa1.buyukboy++;
                                                            }
                                                            if (siparis == 4)
                                                            {
                                                                masa1.sarımsaklıekmek++;
                                                            }
                                                            if (siparis == 5)
                                                            {
                                                                masa1.tavukparcaları++;
                                                            }
                                                            if (siparis == 6)
                                                            {
                                                                masa1.patates++;
                                                            }
                                                            if (siparis == 7)
                                                            {
                                                                masa1.sufle++;
                                                            }
                                                            if (siparis == 8)
                                                            {
                                                                masa1.tiramisu++;
                                                            }
                                                            if (siparis == 9)
                                                            {
                                                                masa1.mozaikpasta++;
                                                            }
                                                            if (siparis == 10)
                                                            {
                                                                masa1.kucukayran++;
                                                            }
                                                            if (siparis == 11)
                                                            {
                                                                masa1.buyukayran++;
                                                            }
                                                            if (siparis == 12)
                                                            {
                                                                masa1.su++;
                                                            }
                                                            if (siparis == 13)
                                                            {
                                                                goto X;
                                                            }
                                                            goto X;
                                                        }
                                                    case 2:
                                                        {
                                                            goto Z;
                                                        }
                                                    case 3:
                                                        {
                                                            masa1.durum = true;
                                                            goto An;
                                                        }
                                                    case 0:
                                                        {
                                                            goto An;
                                                        }
                                                }
                                                break;

                                            }
                                        case 2:
                                            {
                                            X:
                                                rest.menu();
                                                Console.WriteLine("         1.MASA SİPARİŞLERİ");
                                                Console.WriteLine("----------------------------------");
                                                rest.siparisler2(masa1.kucukboy, masa1.ortaboy, masa1.buyukboy, masa1.sarımsaklıekmek, masa1.tavukparcaları, masa1.patates,
                                                masa1.sufle, masa1.tiramisu, masa1.mozaikpasta, masa1.kucukayran, masa1.buyukayran, masa1.su);
                                                int ekle = Convert.ToInt32(Console.ReadLine());
                                                switch (ekle)
                                                {
                                                    case 1:
                                                        {
                                                            rest.menusip();
                                                            int siparis = Convert.ToInt32(Console.ReadLine());
                                                            if (siparis == 1)
                                                            {
                                                                masa1.kucukboy--;
                                                            }
                                                            if (siparis == 2)
                                                            {
                                                                masa1.ortaboy--;
                                                            }
                                                            if (siparis == 3)
                                                            {
                                                                masa1.buyukboy--;
                                                            }
                                                            if (siparis == 4)
                                                            {
                                                                masa1.sarımsaklıekmek--;
                                                            }
                                                            if (siparis == 5)
                                                            {
                                                                masa1.tavukparcaları--;
                                                            }
                                                            if (siparis == 6)
                                                            {
                                                                masa1.patates--;
                                                            }
                                                            if (siparis == 7)
                                                            {
                                                                masa1.sufle--;
                                                            }
                                                            if (siparis == 8)
                                                            {
                                                                masa1.tiramisu--;
                                                            }
                                                            if (siparis == 9)
                                                            {
                                                                masa1.mozaikpasta--;
                                                            }
                                                            if (siparis == 10)
                                                            {
                                                                masa1.kucukayran--;
                                                            }
                                                            if (siparis == 11)
                                                            {
                                                                masa1.buyukayran--;
                                                            }
                                                            if (siparis == 12)
                                                            {
                                                                masa1.su--;
                                                            }
                                                            if (siparis == 13)
                                                            {
                                                                goto X;
                                                            }
                                                            goto X;
                                                        }
                                                    case 2:
                                                        {
                                                            goto Z;
                                                        }
                                                    case 3:
                                                        {
                                                           goto An;
                                                        }
                                                    case 0:
                                                        {
                                                            goto An;
                                                        }
                                                }


                                                break;
                                            }
                                        case 3:
                                            {
                                                goto An;
                                            }


                                    }

                                    break;
                                }
                            case 2:
                                {
                                    Console.WriteLine("         2.MASA SİPARİŞLERİ");
                                    Console.WriteLine("----------------------------------");
                                    rest.siparisler3(masa2.kucukboy, masa2.ortaboy, masa2.buyukboy, masa2.sarımsaklıekmek, masa2.tavukparcaları, masa2.patates,
                                                 masa2.sufle, masa2.tiramisu, masa2.mozaikpasta, masa2.kucukayran, masa2.buyukayran, masa2.su);
                                    Console.WriteLine("----------------------------------");
                                    Console.WriteLine("SİPARİŞ EKLE [1]");
                                    Console.WriteLine("SİPARİŞ SİL  [2]");
                                    Console.WriteLine("ANA MENU     [0]");
                                    int Secim = Convert.ToInt32((Console.ReadLine()));
                                    switch (Secim)
                                    {
                                        case 1:
                                            {
                                            X:
                                                rest.menu();
                                                Console.WriteLine("         2.MASA SİPARİŞLERİ");
                                                Console.WriteLine("----------------------------------");
                                                rest.siparisler(masa2.kucukboy, masa2.ortaboy, masa2.buyukboy, masa2.sarımsaklıekmek, masa2.tavukparcaları, masa2.patates,
                                                   masa2.sufle, masa2.tiramisu, masa2.mozaikpasta, masa2.kucukayran, masa2.buyukayran, masa2.su);
                                                int ekle = Convert.ToInt32(Console.ReadLine());
                                                switch (ekle)
                                                {
                                                    case 1:
                                                        {
                                                            rest.menusip();
                                                            int siparis = Convert.ToInt32(Console.ReadLine());
                                                            if (siparis == 1)
                                                            {
                                                                masa2.kucukboy++;
                                                            }
                                                            if (siparis == 2)
                                                            {
                                                                masa2.ortaboy++;
                                                            }
                                                            if (siparis == 3)
                                                            {
                                                                masa2.buyukboy++;
                                                            }
                                                            if (siparis == 4)
                                                            {
                                                                masa2.sarımsaklıekmek++;
                                                            }
                                                            if (siparis == 5)
                                                            {
                                                                masa2.tavukparcaları++;
                                                            }
                                                            if (siparis == 6)
                                                            {
                                                                masa2.patates++;
                                                            }
                                                            if (siparis == 7)
                                                            {
                                                                masa2.sufle++;
                                                            }
                                                            if (siparis == 8)
                                                            {
                                                                masa2.tiramisu++;
                                                            }
                                                            if (siparis == 9)
                                                            {
                                                                masa2.mozaikpasta++;
                                                            }
                                                            if (siparis == 10)
                                                            {
                                                                masa2.kucukayran++;
                                                            }
                                                            if (siparis == 11)
                                                            {
                                                                masa2.buyukayran++;
                                                            }
                                                            if (siparis == 12)
                                                            {
                                                                masa2.su++;
                                                            }
                                                            if (siparis == 13)
                                                            {
                                                                goto X;
                                                            }
                                                            goto X;
                                                        }
                                                    case 2:
                                                        {
                                                            goto Z;
                                                        }
                                                    case 3:
                                                        {
                                                            masa1.durum = true;
                                                            goto An;
                                                        }
                                                    case 0:
                                                        {
                                                            goto An;
                                                        }
                                                }
                                                break;

                                            }
                                        case 2:
                                            {
                                            X:
                                                rest.menu();
                                                Console.WriteLine("         2.MASA SİPARİŞLERİ");
                                                Console.WriteLine("----------------------------------");
                                                rest.siparisler2(masa2.kucukboy, masa2.ortaboy, masa2.buyukboy, masa2.sarımsaklıekmek, masa2.tavukparcaları, masa2.patates,
                                                masa2.sufle, masa2.tiramisu, masa2.mozaikpasta, masa2.kucukayran, masa2.buyukayran, masa2.su);
                                                int ekle = Convert.ToInt32(Console.ReadLine());
                                                switch (ekle)
                                                {
                                                    case 1:
                                                        {
                                                            rest.menusip();
                                                            int siparis = Convert.ToInt32(Console.ReadLine());
                                                            if (siparis == 1)
                                                            {
                                                                masa2.kucukboy--;
                                                            }
                                                            if (siparis == 2)
                                                            {
                                                                masa2.ortaboy--;
                                                            }
                                                            if (siparis == 3)
                                                            {
                                                                masa2.buyukboy--;
                                                            }
                                                            if (siparis == 4)
                                                            {
                                                                masa2.sarımsaklıekmek--;
                                                            }
                                                            if (siparis == 5)
                                                            {
                                                                masa2.tavukparcaları--;
                                                            }
                                                            if (siparis == 6)
                                                            {
                                                                masa2.patates--;
                                                            }
                                                            if (siparis == 7)
                                                            {
                                                                masa2.sufle--;
                                                            }
                                                            if (siparis == 8)
                                                            {
                                                                masa2.tiramisu--;
                                                            }
                                                            if (siparis == 9)
                                                            {
                                                                masa2.mozaikpasta--;
                                                            }
                                                            if (siparis == 10)
                                                            {
                                                                masa2.kucukayran--;
                                                            }
                                                            if (siparis == 11)
                                                            {
                                                                masa2.buyukayran--;
                                                            }
                                                            if (siparis == 12)
                                                            {
                                                                masa2.su--;
                                                            }
                                                            if (siparis == 13)
                                                            {
                                                                goto X;
                                                            }
                                                            goto X;
                                                        }
                                                    case 2:
                                                        {
                                                            goto Z;
                                                        }
                                                    case 3:
                                                        {
                                                            goto An;
                                                        }
                                                    case 0:
                                                        {
                                                            goto An;
                                                        }
                                                }


                                                break;
                                            }
                                        case 3:
                                            {
                                                goto An;
                                            }


                                    }
                                    break;
                                }
                            case 3:
                                {
                                    Console.WriteLine("         3.MASA SİPARİŞLERİ");
                                    Console.WriteLine("----------------------------------");
                                    rest.siparisler3(masa3.kucukboy, masa3.ortaboy, masa3.buyukboy, masa3.sarımsaklıekmek, masa3.tavukparcaları, masa3.patates,
                                                masa3.sufle, masa3.tiramisu, masa3.mozaikpasta, masa3.kucukayran, masa3.buyukayran, masa3.su);
                                    Console.WriteLine("----------------------------------");
                                    Console.WriteLine("SİPARİŞ EKLE [1]");
                                    Console.WriteLine("SİPARİŞ SİL  [2]");
                                    Console.WriteLine("ANA MENU     [0]");
                                    int Secim = Convert.ToInt32((Console.ReadLine()));
                                    switch (Secim)
                                    {
                                        case 1:
                                            {
                                            X:
                                                rest.menu();
                                                Console.WriteLine("         3.MASA SİPARİŞLERİ");
                                                Console.WriteLine("----------------------------------");
                                                rest.siparisler(masa3.kucukboy, masa3.ortaboy, masa3.buyukboy, masa3.sarımsaklıekmek, masa3.tavukparcaları, masa3.patates,
                                                masa3.sufle, masa3.tiramisu, masa3.mozaikpasta, masa3.kucukayran, masa3.buyukayran, masa3.su);
                                                int ekle = Convert.ToInt32(Console.ReadLine());
                                                switch (ekle)
                                                {
                                                    case 1:
                                                        {
                                                            rest.menusip();
                                                            int siparis = Convert.ToInt32(Console.ReadLine());
                                                            if (siparis == 1)
                                                            {
                                                                masa3.kucukboy++;
                                                            }
                                                            if (siparis == 2)
                                                            {
                                                                masa3.ortaboy++;
                                                            }
                                                            if (siparis == 3)
                                                            {
                                                                masa3.buyukboy++;
                                                            }
                                                            if (siparis == 4)
                                                            {
                                                                masa3.sarımsaklıekmek++;
                                                            }
                                                            if (siparis == 5)
                                                            {
                                                                masa3.tavukparcaları++;
                                                            }
                                                            if (siparis == 6)
                                                            {
                                                                masa3.patates++;
                                                            }
                                                            if (siparis == 7)
                                                            {
                                                                masa3.sufle++;
                                                            }
                                                            if (siparis == 8)
                                                            {
                                                                masa3.tiramisu++;
                                                            }
                                                            if (siparis == 9)
                                                            {
                                                                masa3.mozaikpasta++;
                                                            }
                                                            if (siparis == 10)
                                                            {
                                                                masa3.kucukayran++;
                                                            }
                                                            if (siparis == 11)
                                                            {
                                                                masa3.buyukayran++;
                                                            }
                                                            if (siparis == 12)
                                                            {
                                                                masa3.su++;
                                                            }
                                                            if (siparis == 13)
                                                            {
                                                                goto X;
                                                            }
                                                            goto X;
                                                        }
                                                    case 2:
                                                        {
                                                            goto Z;
                                                        }
                                                    case 3:
                                                        {
                                                            masa1.durum = true;
                                                            goto An;
                                                        }
                                                    case 0:
                                                        {
                                                            goto An;
                                                        }
                                                }
                                                break;

                                            }
                                        case 2:
                                            {
                                            X:
                                                rest.menu();
                                                Console.WriteLine("         3.MASA SİPARİŞLERİ");
                                                Console.WriteLine("----------------------------------");
                                                rest.siparisler2(masa3.kucukboy, masa3.ortaboy, masa3.buyukboy, masa3.sarımsaklıekmek, masa3.tavukparcaları, masa3.patates,
                                                masa3.sufle, masa3.tiramisu, masa3.mozaikpasta, masa3.kucukayran, masa3.buyukayran, masa3.su);
                                                int ekle = Convert.ToInt32(Console.ReadLine());
                                                switch (ekle)
                                                {
                                                    case 1:
                                                        {
                                                            rest.menusip();
                                                            int siparis = Convert.ToInt32(Console.ReadLine());
                                                            if (siparis == 1)
                                                            {
                                                                masa3.kucukboy--;
                                                            }
                                                            if (siparis == 2)
                                                            {
                                                                masa3.ortaboy--;
                                                            }
                                                            if (siparis == 3)
                                                            {
                                                                masa3.buyukboy--;
                                                            }
                                                            if (siparis == 4)
                                                            {
                                                                masa3.sarımsaklıekmek--;
                                                            }
                                                            if (siparis == 5)
                                                            {
                                                                masa3.tavukparcaları--;
                                                            }
                                                            if (siparis == 6)
                                                            {
                                                                masa3.patates--;
                                                            }
                                                            if (siparis == 7)
                                                            {
                                                                masa3.sufle--;
                                                            }
                                                            if (siparis == 8)
                                                            {
                                                                masa3.tiramisu--;
                                                            }
                                                            if (siparis == 9)
                                                            {
                                                                masa3.mozaikpasta--;
                                                            }
                                                            if (siparis == 10)
                                                            {
                                                                masa3.kucukayran--;
                                                            }
                                                            if (siparis == 11)
                                                            {
                                                                masa3.buyukayran--;
                                                            }
                                                            if (siparis == 12)
                                                            {
                                                                masa3.su--;
                                                            }
                                                            if (siparis == 13)
                                                            {
                                                                goto X;
                                                            }
                                                            goto X;
                                                        }
                                                    case 2:
                                                        {
                                                            goto Z;
                                                        }
                                                    case 3:
                                                        {
                                                            goto An;
                                                        }
                                                    case 0:
                                                        {
                                                            goto An;
                                                        }
                                                }


                                                break;
                                            }
                                        case 3:
                                            {
                                                goto An;
                                            }


                                    }
                                    break;
                                }
                            case 4:
                                {
                                    Console.WriteLine("         4.MASA SİPARİŞLERİ");
                                    Console.WriteLine("----------------------------------");
                                    rest.siparisler3(masa4.kucukboy, masa4.ortaboy, masa4.buyukboy, masa4.sarımsaklıekmek, masa4.tavukparcaları, masa4.patates,
                                                masa4.sufle, masa4.tiramisu, masa4.mozaikpasta, masa4.kucukayran, masa4.buyukayran, masa4.su);
                                    Console.WriteLine("----------------------------------");
                                    Console.WriteLine("SİPARİŞ EKLE [1]");
                                    Console.WriteLine("SİPARİŞ SİL  [2]");
                                    Console.WriteLine("ANA MENU     [0]");
                                    int Secim = Convert.ToInt32((Console.ReadLine()));
                                    switch (Secim)
                                    {
                                        case 1:
                                            {
                                            X:
                                                rest.menu();
                                                Console.WriteLine("         4.MASA SİPARİŞLERİ");
                                                Console.WriteLine("----------------------------------");
                                                rest.siparisler(masa4.kucukboy, masa4.ortaboy, masa4.buyukboy, masa4.sarımsaklıekmek, masa4.tavukparcaları, masa4.patates,
                                                masa4.sufle, masa4.tiramisu, masa4.mozaikpasta, masa4.kucukayran, masa4.buyukayran, masa4.su);
                                                int ekle = Convert.ToInt32(Console.ReadLine());
                                                switch (ekle)
                                                {
                                                    case 1:
                                                        {
                                                            rest.menusip();
                                                            int siparis = Convert.ToInt32(Console.ReadLine());
                                                            if (siparis == 1)
                                                            {
                                                                masa4.kucukboy++;
                                                            }
                                                            if (siparis == 2)
                                                            {
                                                                masa4.ortaboy++;
                                                            }
                                                            if (siparis == 3)
                                                            {
                                                                masa4.buyukboy++;
                                                            }
                                                            if (siparis == 4)
                                                            {
                                                                masa4.sarımsaklıekmek++;
                                                            }
                                                            if (siparis == 5)
                                                            {
                                                                masa4.tavukparcaları++;
                                                            }
                                                            if (siparis == 6)
                                                            {
                                                                masa4.patates++;
                                                            }
                                                            if (siparis == 7)
                                                            {
                                                                masa4.sufle++;
                                                            }
                                                            if (siparis == 8)
                                                            {
                                                                masa4.tiramisu++;
                                                            }
                                                            if (siparis == 9)
                                                            {
                                                                masa4.mozaikpasta++;
                                                            }
                                                            if (siparis == 10)
                                                            {
                                                                masa4.kucukayran++;
                                                            }
                                                            if (siparis == 11)
                                                            {
                                                                masa4.buyukayran++;
                                                            }
                                                            if (siparis == 12)
                                                            {
                                                                masa4.su++;
                                                            }
                                                            if (siparis == 13)
                                                            {
                                                                goto X;
                                                            }
                                                            goto X;
                                                        }
                                                    case 2:
                                                        {
                                                            goto Z;
                                                        }
                                                    case 3:
                                                        {
                                                            masa4.durum = true;
                                                            goto An;
                                                        }
                                                    case 0:
                                                        {
                                                            goto An;
                                                        }
                                                }
                                                break;

                                            }
                                        case 2:
                                            {
                                            X:
                                                rest.menu();
                                                Console.WriteLine("         4.MASA SİPARİŞLERİ");
                                                Console.WriteLine("----------------------------------");
                                                rest.siparisler2(masa4.kucukboy, masa4.ortaboy, masa4.buyukboy, masa4.sarımsaklıekmek, masa4.tavukparcaları, masa4.patates,
                                                masa4.sufle, masa4.tiramisu, masa4.mozaikpasta, masa4.kucukayran, masa4.buyukayran, masa4.su);
                                                int ekle = Convert.ToInt32(Console.ReadLine());
                                                switch (ekle)
                                                {
                                                    case 1:
                                                        {
                                                            rest.menusip();
                                                            int siparis = Convert.ToInt32(Console.ReadLine());
                                                            if (siparis == 1)
                                                            {
                                                                masa4.kucukboy--;
                                                            }
                                                            if (siparis == 2)
                                                            {
                                                                masa4.ortaboy--;
                                                            }
                                                            if (siparis == 3)
                                                            {
                                                                masa4.buyukboy--;
                                                            }
                                                            if (siparis == 4)
                                                            {
                                                                masa4.sarımsaklıekmek--;
                                                            }
                                                            if (siparis == 5)
                                                            {
                                                                masa4.tavukparcaları--;
                                                            }
                                                            if (siparis == 6)
                                                            {
                                                                masa4.patates--;
                                                            }
                                                            if (siparis == 7)
                                                            {
                                                                masa4.sufle--;
                                                            }
                                                            if (siparis == 8)
                                                            {
                                                                masa4.tiramisu--;
                                                            }
                                                            if (siparis == 9)
                                                            {
                                                                masa4.mozaikpasta--;
                                                            }
                                                            if (siparis == 10)
                                                            {
                                                                masa4.kucukayran--;
                                                            }
                                                            if (siparis == 11)
                                                            {
                                                                masa4.buyukayran--;
                                                            }
                                                            if (siparis == 12)
                                                            {
                                                                masa4.su--;
                                                            }
                                                            if (siparis == 13)
                                                            {
                                                                goto X;
                                                            }
                                                            goto X;
                                                        }
                                                    case 2:
                                                        {
                                                            goto Z;
                                                        }
                                                    case 3:
                                                        {
                                                            goto An;
                                                        }
                                                    case 0:
                                                        {
                                                            goto An;
                                                        }
                                                }


                                                break;
                                            }
                                        case 3:
                                            {
                                                goto An;
                                            }


                                    }
                                    break;
                                }
                            case 5:
                                {
                                    Console.WriteLine("         5.MASA SİPARİŞLERİ");
                                    Console.WriteLine("----------------------------------");
                                    rest.siparisler3(masa5.kucukboy, masa5.ortaboy, masa5.buyukboy, masa5.sarımsaklıekmek, masa5.tavukparcaları, masa5.patates,
                                                masa5.sufle, masa5.tiramisu, masa5.mozaikpasta, masa5.kucukayran, masa5.buyukayran, masa5.su);
                                    Console.WriteLine("----------------------------------");
                                    Console.WriteLine("SİPARİŞ EKLE [1]");
                                    Console.WriteLine("SİPARİŞ SİL  [2]");
                                    Console.WriteLine("ANA MENU     [0]");
                                    int Secim = Convert.ToInt32((Console.ReadLine()));
                                    switch (Secim)
                                    {
                                        case 1:
                                            {
                                            X:
                                                rest.menu();
                                                Console.WriteLine("         5.MASA SİPARİŞLERİ");
                                                Console.WriteLine("----------------------------------");
                                                rest.siparisler(masa5.kucukboy, masa5.ortaboy, masa5.buyukboy, masa5.sarımsaklıekmek, masa5.tavukparcaları, masa5.patates,
                                                masa5.sufle, masa5.tiramisu, masa5.mozaikpasta, masa5.kucukayran, masa5.buyukayran, masa5.su);
                                                int ekle = Convert.ToInt32(Console.ReadLine());
                                                switch (ekle)
                                                {
                                                    case 1:
                                                        {
                                                            rest.menusip();
                                                            int siparis = Convert.ToInt32(Console.ReadLine());
                                                            if (siparis == 1)
                                                            {
                                                                masa5.kucukboy++;
                                                            }
                                                            if (siparis == 2)
                                                            {
                                                                masa5.ortaboy++;
                                                            }
                                                            if (siparis == 3)
                                                            {
                                                                masa5.buyukboy++;
                                                            }
                                                            if (siparis == 4)
                                                            {
                                                                masa5.sarımsaklıekmek++;
                                                            }
                                                            if (siparis == 5)
                                                            {
                                                                masa5.tavukparcaları++;
                                                            }
                                                            if (siparis == 6)
                                                            {
                                                                masa5.patates++;
                                                            }
                                                            if (siparis == 7)
                                                            {
                                                                masa5.sufle++;
                                                            }
                                                            if (siparis == 8)
                                                            {
                                                                masa5.tiramisu++;
                                                            }
                                                            if (siparis == 9)
                                                            {
                                                                masa5.mozaikpasta++;
                                                            }
                                                            if (siparis == 10)
                                                            {
                                                                masa5.kucukayran++;
                                                            }
                                                            if (siparis == 11)
                                                            {
                                                                masa5.buyukayran++;
                                                            }
                                                            if (siparis == 12)
                                                            {
                                                                masa5.su++;
                                                            }
                                                            if (siparis == 13)
                                                            {
                                                                goto X;
                                                            }
                                                            goto X;
                                                        }
                                                    case 2:
                                                        {
                                                            goto Z;
                                                        }
                                                    case 3:
                                                        {
                                                            goto An;
                                                        }
                                                    case 0:
                                                        {
                                                            goto An;
                                                        }
                                                }
                                                break;

                                            }
                                        case 2:
                                            {
                                            X:
                                                rest.menu();
                                                Console.WriteLine("         5.MASA SİPARİŞLERİ");
                                                Console.WriteLine("----------------------------------");
                                                rest.siparisler2(masa5.kucukboy, masa5.ortaboy, masa5.buyukboy, masa5.sarımsaklıekmek, masa5.tavukparcaları, masa5.patates,
                                                masa5.sufle, masa5.tiramisu, masa5.mozaikpasta, masa5.kucukayran, masa5.buyukayran, masa5.su);
                                                int ekle = Convert.ToInt32(Console.ReadLine());
                                                switch (ekle)
                                                {
                                                    case 1:
                                                        {
                                                            rest.menusip();
                                                            int siparis = Convert.ToInt32(Console.ReadLine());
                                                            if (siparis == 1)
                                                            {
                                                                masa5.kucukboy--;
                                                            }
                                                            if (siparis == 2)
                                                            {
                                                                masa5.ortaboy--;
                                                            }
                                                            if (siparis == 3)
                                                            {
                                                                masa5.buyukboy--;
                                                            }
                                                            if (siparis == 4)
                                                            {
                                                                masa5.sarımsaklıekmek--;
                                                            }
                                                            if (siparis == 5)
                                                            {
                                                                masa5.tavukparcaları--;
                                                            }
                                                            if (siparis == 6)
                                                            {
                                                                masa5.patates--;
                                                            }
                                                            if (siparis == 7)
                                                            {
                                                                masa5.sufle--;
                                                            }
                                                            if (siparis == 8)
                                                            {
                                                                masa5.tiramisu--;
                                                            }
                                                            if (siparis == 9)
                                                            {
                                                                masa5.mozaikpasta--;
                                                            }
                                                            if (siparis == 10)
                                                            {
                                                                masa5.kucukayran--;
                                                            }
                                                            if (siparis == 11)
                                                            {
                                                                masa5.buyukayran--;
                                                            }
                                                            if (siparis == 12)
                                                            {
                                                                masa5.su--;
                                                            }
                                                            if (siparis == 13)
                                                            {
                                                                goto X;
                                                            }
                                                            goto X;
                                                        }
                                                    case 2:
                                                        {
                                                            goto Z;
                                                        }
                                                    case 3:
                                                        {
                                                            goto An;
                                                        }
                                                    case 0:
                                                        {
                                                            goto An;
                                                        }
                                                }
                                                break;
                                            }
                                        case 3:
                                            {
                                                goto An;
                                            }
                                    }
                                    break;
                                }
                        }

                        break;
                    }
                case 3:
                    {
                        Console.Clear();
                        int masa1hesap = (15 * masa1.kucukboy) + (20 * masa1.ortaboy) + (25 * masa1.buyukboy) + 5 * masa1.sarımsaklıekmek + 10 * masa1.tavukparcaları + 10 * masa1.patates
                       + 10 * masa1.sufle + 25 * masa1.tiramisu + 20 * masa1.mozaikpasta + 3 * masa1.kucukayran + 5 * masa1.buyukayran + 1 * masa1.su;
                        int masa2hesap = 15 * masa2.kucukboy + 20 * masa2.ortaboy + 25 * masa2.buyukboy + 5 * masa2.sarımsaklıekmek + 10 * masa2.tavukparcaları + 10 * masa2.patates
                            + 10 * masa2.sufle + 25 * masa2.tiramisu + 20 * masa2.mozaikpasta + 3 * masa2.kucukayran + 5 * masa2.buyukayran + 1 * masa2.su;
                        int masa3hesap = 15 * masa3.kucukboy + 20 * masa3.ortaboy + 25 * masa3.buyukboy + 5 * masa3.sarımsaklıekmek + 10 * masa3.tavukparcaları + 10 * masa3.patates
                            + 10 * masa3.sufle + 25 * masa3.tiramisu + 20 * masa3.mozaikpasta + 3 * masa3.kucukayran + 5 * masa3.buyukayran + 1 * masa3.su;
                        int masa4hesap = 15 * masa4.kucukboy + 20 * masa4.ortaboy + 25 * masa4.buyukboy + 5 * masa4.sarımsaklıekmek + 10 * masa4.tavukparcaları + 10 * masa4.patates
                            + 10 * masa4.sufle + 25 * masa4.tiramisu + 20 * masa4.mozaikpasta + 3 * masa4.kucukayran + 5 * masa4.buyukayran + 1 * masa4.su;
                        int masa5hesap = 15 * masa5.kucukboy + 20 * masa5.ortaboy + 25 * masa5.buyukboy + 5 * masa5.sarımsaklıekmek + 10 * masa5.tavukparcaları + 10 * masa5.patates
                            + 10 * masa5.sufle + 25 * masa5.tiramisu + 20 * masa5.mozaikpasta + 3 * masa5.kucukayran + 5 * masa5.buyukayran + 1 * masa5.su;
                        Console.WriteLine("masa idsini giriniz:");
                        int masaid = Convert.ToInt32(Console.ReadLine());
                        switch (masaid)
                        {
                            case 1:
                                Console.Clear();
                                Console.WriteLine("1.masa hesap:" + masa1hesap);
                                Console.WriteLine("onaylamak için [1]");
                                Console.WriteLine("ana menu için [0]");
                                int az = Convert.ToInt32(Console.ReadLine());
                                switch (az)
                                {
                                    case 1:
                                        Console.Clear();
                                        masa1kazanc += masa1hesap;
                                        Console.WriteLine("bahşiş miktarını girin:");
                                        masa1bahsis += Convert.ToInt32(Console.ReadLine());
                                        masa1.kucukboy = 0;
                                        masa1.ortaboy = 0;
                                        masa1.buyukboy = 0;
                                        masa1.sarımsaklıekmek = 0;
                                        masa1.tavukparcaları = 0;
                                        masa1.patates = 0;
                                        masa1.mozaikpasta = 0;
                                        masa1.tiramisu = 0;
                                        masa1.sufle = 0;
                                        masa1.kucukayran = 0;
                                        masa1.buyukayran = 0;
                                        masa1.su = 0;
                                        masa1.durum = false;
                                        goto An;

                                    case 0:
                                        goto An;

                                }
                                break;
                            case 2:
                                Console.Clear();
                                Console.WriteLine("2.masa hesap:" + masa2hesap);
                                Console.WriteLine("onaylamak için [1]");
                                Console.WriteLine("ana menu için [0]");
                                int az2 = Convert.ToInt32(Console.ReadLine());
                                switch (az2)
                                {
                                    case 1:
                                        Console.Clear();
                                        masa2kazanc += masa2hesap;
                                        Console.WriteLine("bahşiş miktarını girin:");
                                        masa1bahsis += Convert.ToInt32(Console.ReadLine());
                                        masa2.kucukboy = 0;
                                        masa2.ortaboy = 0;
                                        masa2.buyukboy = 0;
                                        masa2.sarımsaklıekmek = 0;
                                        masa2.tavukparcaları = 0;
                                        masa2.patates = 0;
                                        masa2.mozaikpasta = 0;
                                        masa2.tiramisu = 0;
                                        masa2.sufle = 0;
                                        masa2.kucukayran = 0;
                                        masa2.buyukayran = 0;
                                        masa2.su = 0;
                                        masa2.durum = false;
                                        goto An;

                                    case 0:
                                        goto An;
                                }
                                break;
                            case 3:
                                Console.Clear();
                                Console.WriteLine("3.masa hesap:" + masa3hesap);
                                Console.WriteLine("onaylamak için [1]");
                                Console.WriteLine("ana menu için [0]");
                                int az3 = Convert.ToInt32(Console.ReadLine());
                                switch (az3)
                                {
                                    case 1:
                                        Console.Clear();
                                        masa3kazanc += masa3hesap;
                                        Console.WriteLine("bahşiş miktarını girin:");
                                        masa3bahsis += Convert.ToInt32(Console.ReadLine());
                                        masa3.kucukboy = 0;
                                        masa3.ortaboy = 0;
                                        masa3.buyukboy = 0;
                                        masa3.sarımsaklıekmek = 0;
                                        masa3.tavukparcaları = 0;
                                        masa3.patates = 0;
                                        masa3.mozaikpasta = 0;
                                        masa3.tiramisu = 0;
                                        masa3.sufle = 0;
                                        masa3.kucukayran = 0;
                                        masa3.buyukayran = 0;
                                        masa3.su = 0;
                                        masa3.durum = false;
                                        goto An;

                                    case 0:
                                        goto An;
                                }
                                break;

                            case 4:
                                Console.Clear();
                                Console.WriteLine("4.masa hesap:" + masa4hesap);
                                Console.WriteLine("onaylamak için [1]");
                                Console.WriteLine("ana menu için [0]");
                                int az4 = Convert.ToInt32(Console.ReadLine());
                                switch (az4)
                                {
                                    case 1:
                                        Console.Clear();
                                        masa4kazanc += masa4hesap;
                                        Console.WriteLine("bahşiş miktarını girin:");
                                        masa4bahsis += Convert.ToInt32(Console.ReadLine());
                                        masa4.kucukboy = 0;
                                        masa4.ortaboy = 0;
                                        masa4.buyukboy = 0;
                                        masa4.sarımsaklıekmek = 0;
                                        masa4.tavukparcaları = 0;
                                        masa4.patates = 0;
                                        masa4.mozaikpasta = 0;
                                        masa4.tiramisu = 0;
                                        masa4.sufle = 0;
                                        masa4.kucukayran = 0;
                                        masa4.buyukayran = 0;
                                        masa4.su = 0;
                                        masa4.durum = false;
                                        goto An;

                                    case 0:
                                        goto An;

                                }
                                break;

                            case 5:
                                Console.Clear();
                                Console.WriteLine("5.masa hesap:" + masa5hesap);
                                Console.WriteLine("onaylamak için [1]");
                                Console.WriteLine("ana menu için [0]");
                                int az5 = Convert.ToInt32(Console.ReadLine());
                                switch (az5)
                                {
                                    case 1:
                                        Console.Clear();
                                        masa5kazanc += masa5hesap;
                                        Console.WriteLine("bahşiş miktarını girin:");
                                        masa5bahsis += Convert.ToInt32(Console.ReadLine());
                                        masa5.kucukboy = 0;
                                        masa5.ortaboy = 0;
                                        masa5.buyukboy = 0;
                                        masa5.sarımsaklıekmek = 0;
                                        masa5.tavukparcaları = 0;
                                        masa5.patates = 0;
                                        masa5.mozaikpasta = 0;
                                        masa5.tiramisu = 0;
                                        masa5.sufle = 0;
                                        masa5.kucukayran = 0;
                                        masa5.buyukayran = 0;
                                        masa5.su = 0;
                                        masa5.durum = false;
                                        goto An;

                                    case 0:
                                        goto An;

                                }
                                break;
                        }
                        break;
                    }
                case 4:
                    {
                        toplamkazanc = masa1kazanc + masa2kazanc + masa3kazanc + masa4kazanc + masa5kazanc;
                        toplambahsis = masa1bahsis + masa2bahsis + masa3bahsis + masa4bahsis + masa5bahsis;
                        rest.KASA(toplamkazanc, toplambahsis, masa1kazanc, masa1bahsis, masa2kazanc, masa2bahsis, masa3kazanc, masa3bahsis, masa4kazanc, masa4bahsis, masa5kazanc, masa5bahsis);
                        Console.ReadKey();
                        goto An;
                    }
                case 0:
                    {
                        break;
                    }
            }
        }
    }
}
