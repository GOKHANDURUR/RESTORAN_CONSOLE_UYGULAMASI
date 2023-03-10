using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restoran_v1
{
    internal class AnaMenu
    {
        public void anamenu()
        {
            Console.Clear();
            Console.WriteLine("    ANA MENU    ");
            Console.WriteLine("-----------------");
            Console.WriteLine("MASA AÇ   \t[1]");
            Console.WriteLine("MASA İSLEM\t[2]");
            Console.WriteLine("MASA HESAP\t[3]");
            Console.WriteLine("KASA İSLEM\t[4]");
            Console.WriteLine("-----------------");
            Console.WriteLine("ÇIKIS YAP\t[0]");
            Console.WriteLine("-----------------");
        }
        public void masadurum(bool m1, bool m2, bool m3, bool m4, bool m5)
        {
            Console.Clear();
            if (m1 == true)
            {
                Console.WriteLine("1.MASA DOLU");
            }
            else
            {
                Console.WriteLine("1.MASA BOŞ");
            }
            if (m2 == true)
            {
                Console.WriteLine("2.MASA DOLU");
            }
            else
            {
                Console.WriteLine("2.MASA BOŞ");
            }
            if (m3 == true)
            {
                Console.WriteLine("3.MASA DOLU");
            }
            else
            {
                Console.WriteLine("3.MASA BOŞ");
            }
            if (m4 == true)
            {
                Console.WriteLine("4.MASA DOLU");
            }
            else
            {
                Console.WriteLine("4.MASA BOŞ");
            }
            if (m5 == true)
            {
                Console.WriteLine("5.MASA DOLU");
            }
            else
            {
                Console.WriteLine("5.MASA BOŞ");
            }
            Console.WriteLine("--------------------");
            Console.WriteLine("ANA MENU   [0]");
            Console.WriteLine("--------------------");
            Console.Write("MASA AÇMAK İÇİN İD GİRİNİZ:");
        }
        public void menu()
        {
            Console.Clear();
            Console.WriteLine("              MENU");
            Console.WriteLine(" PİZZALAR                   YAN ÜRÜN");
            Console.WriteLine("KÜÇÜK BOY     -15TL     SARIMSAKLI EKMEK      -5TL");
            Console.WriteLine("ORTA BOY      -20TL     ÇITIR TAVUK PARÇALARI -10TL");
            Console.WriteLine("BÜYÜK BOY     -25TL     PATATES               -10TL");
            Console.WriteLine();
            Console.WriteLine("  TATLILAR               İÇEÇEKLER");
            Console.WriteLine("SUFLE         -10TL     K.AYRAN                -3TL");
            Console.WriteLine("TİRAMİSU      -15TL     B.AYRAN                -5TL");
            Console.WriteLine("MOZAİK PASTA  -20TL     SU                     -1TL");
            Console.WriteLine("----------------------------------");
        }
        public void siparisler(int u1, int u2, int u3, int u4, int u5, int u6, int u7, int u8, int u9, int u10, int u11, int u12)
        {
            string d1;
            d1 = "";
            if (u1 > 0)
                for (int i = 0; i < u1; i++)
                {
                    d1 += "KÜÇÜK BOY -15TL\n";
                }
            if (u2 > 0)
                for (int i = 0; i < u2; i++)
                {
                    d1 += "ORTA BOY  -20TL\n";
                }
            if (u3 > 0)
                for (int i = 0; i < u3; i++)
                {
                    d1 += "BÜYÜK BOY  -25TL\n";
                }
            if (u4 > 0)
                for (int i = 0; i < u4; i++)
                {
                    d1 += "SARIMSAKLI EKMEK -5TL\n";
                }
            if (u5 > 0)
                for (int i = 0; i < u5; i++)
                {
                    d1 += "ÇITIR TAVUK PARÇALARI -10TL\n";
                }
            if (u6 > 0)
                for (int i = 0; i < u6; i++)
                {
                    d1 += "PATATES               -10TL\n";
                }
            if (u7 > 0)
                for (int i = 0; i < u7; i++)
                {
                    d1 += "SUFLE         -10TL\n";
                }
            if (u8 > 0)
                for (int i = 0; i < u8; i++)
                {
                    d1 += "TİRAMİSU      -15TL\n";
                }
            if (u9 > 0)
                for (int i = 0; i < u9; i++)
                {
                    d1 += "MOZAİK PASTA  -20TL\n";
                }
            if (u10 > 0)
                for (int i = 0; i < u10; i++)
                {
                    d1 += "K.AYRAN    -3TL\n";
                }
            if (u11 > 0)
                for (int i = 0; i < u11; i++)
                {
                    d1 += "B.AYRAN    -5TL\n";
                }
            if (u12 > 0)
                for (int i = 0; i < u12; i++)
                {
                    d1 += "SU         -1TL\n";
                }
            Console.WriteLine(d1);
            Console.WriteLine("----------------------------------");
            Console.WriteLine("ANAMENU      \t[0]");
            Console.WriteLine("SİPARİŞ EKLE \t[1]");
            Console.WriteLine("GERİ GİT     \t[2]");
            Console.WriteLine("ONAYLA       \t[3]");
            Console.WriteLine("----------------------------------");
            Console.Write("SEÇİMİNİZ:");

        }

        public void siparisler2(int u1, int u2, int u3, int u4, int u5, int u6, int u7, int u8, int u9, int u10, int u11, int u12)
        {
            string d1;
            d1 = "";
            if (u1 > 0)
                for (int i = 0; i < u1; i++)
                {
                    d1 += "KÜÇÜK BOY -15TL\n";
                }
            if (u2 > 0)
                for (int i = 0; i < u2; i++)
                {
                    d1 += "ORTA BOY  -20TL\n";
                }
            if (u3 > 0)
                for (int i = 0; i < u3; i++)
                {
                    d1 += "BÜYÜK BOY  -25TL\n";
                }
            if (u4 > 0)
                for (int i = 0; i < u4; i++)
                {
                    d1 += "SARIMSAKLI EKMEK -5TL\n";
                }
            if (u5 > 0)
                for (int i = 0; i < u5; i++)
                {
                    d1 += "ÇITIR TAVUK PARÇALARI -10TL\n";
                }
            if (u6 > 0)
                for (int i = 0; i < u6; i++)
                {
                    d1 += "PATATES               -10TL\n";
                }
            if (u7 > 0)
                for (int i = 0; i < u7; i++)
                {
                    d1 += "SUFLE         -10TL\n";
                }
            if (u8 > 0)
                for (int i = 0; i < u8; i++)
                {
                    d1 += "TİRAMİSU      -15TL\n";
                }
            if (u9 > 0)
                for (int i = 0; i < u9; i++)
                {
                    d1 += "MOZAİK PASTA  -20TL\n";
                }
            if (u10 > 0)
                for (int i = 0; i < u10; i++)
                {
                    d1 += "K.AYRAN    -3TL\n";
                }
            if (u11 > 0)
                for (int i = 0; i < u11; i++)
                {
                    d1 += "B.AYRAN    -5TL\n";
                }
            if (u12 > 0)
                for (int i = 0; i < u12; i++)
                {
                    d1 += "SU         -1TL\n";
                }
            Console.WriteLine(d1);
            Console.WriteLine("----------------------------------");
            Console.WriteLine("ANAMENU      \t[0]");
            Console.WriteLine("SİPARİŞ SİL  \t[1]");
            Console.WriteLine("GERİ GİT     \t[2]");
            Console.WriteLine("ONAYLA       \t[3]");
            Console.WriteLine("----------------------------------");
            Console.Write("SEÇİMİNİZ:");

        }

        public void siparisler3(int u1, int u2, int u3, int u4, int u5, int u6, int u7, int u8, int u9, int u10, int u11, int u12)
        {
            string d1;
            d1 = "";
            if (u1 > 0)
                for (int i = 0; i < u1; i++)
                {
                    d1 += "KÜÇÜK BOY -15TL\n";
                }
            if (u2 > 0)
                for (int i = 0; i < u2; i++)
                {
                    d1 += "ORTA BOY  -20TL\n";
                }
            if (u3 > 0)
                for (int i = 0; i < u3; i++)
                {
                    d1 += "BÜYÜK BOY  -25TL\n";
                }
            if (u4 > 0)
                for (int i = 0; i < u4; i++)
                {
                    d1 += "SARIMSAKLI EKMEK -5TL\n";
                }
            if (u5 > 0)
                for (int i = 0; i < u5; i++)
                {
                    d1 += "ÇITIR TAVUK PARÇALARI -10TL\n";
                }
            if (u6 > 0)
                for (int i = 0; i < u6; i++)
                {
                    d1 += "PATATES               -10TL\n";
                }
            if (u7 > 0)
                for (int i = 0; i < u7; i++)
                {
                    d1 += "SUFLE         -10TL\n";
                }
            if (u8 > 0)
                for (int i = 0; i < u8; i++)
                {
                    d1 += "TİRAMİSU      -15TL\n";
                }
            if (u9 > 0)
                for (int i = 0; i < u9; i++)
                {
                    d1 += "MOZAİK PASTA  -20TL\n";
                }
            if (u10 > 0)
                for (int i = 0; i < u10; i++)
                {
                    d1 += "K.AYRAN    -3TL\n";
                }
            if (u11 > 0)
                for (int i = 0; i < u11; i++)
                {
                    d1 += "B.AYRAN    -5TL\n";
                }
            if (u12 > 0)
                for (int i = 0; i < u12; i++)
                {
                    d1 += "SU         -1TL\n";
                }
            Console.WriteLine(d1);
           }
        public void menusip()
        {
            Console.Clear();
            Console.WriteLine("K.BOY PİZZA        \t[1]");
            Console.WriteLine("O.BOY PİZZA        \t[2]");
            Console.WriteLine("B.BOY PİZZA        \t[3]");
            Console.WriteLine("SARIMSAKLI EKMEK   \t[4]");
            Console.WriteLine("ÇITIR TAVUK P.     \t[5]");
            Console.WriteLine("PATATES            \t[6]");
            Console.WriteLine("SUFLE              \t[7]");
            Console.WriteLine("TİRAMUSU           \t[8]");
            Console.WriteLine("MOZAİK PASTA       \t[9]");
            Console.WriteLine("K.AYRAN            \t[10]");
            Console.WriteLine("B.AYRAN            \t[11]");
            Console.WriteLine("SU                 \t[12]");
            Console.WriteLine("VAZGEÇ             \t[13]");
            Console.WriteLine("SEÇİMİNİZ: ");

        }

        public void KASA(int s1, int s2, int s3, int s4, int s5, int s6, int s7, int s8, int s9, int s10, int s11, int s12)
        {
            Console.Clear();
            Console.WriteLine("KASA İŞLEMLERİ");
            Console.WriteLine("--------------");
            Console.WriteLine("TOPLAM KAZANÇ:" + s1);
            Console.WriteLine("TOPLAM BAHSİS:" + s2);
            Console.WriteLine("--------------");
            Console.WriteLine("  MASALARA GÖRE KAZANCLAR");
            Console.WriteLine("  MASA1 KAZANC:" + s3 + " MASA1 BAHSİS:" + s4);
            Console.WriteLine("  MASA2 KAZANC:" + s5 + " MASA1 BAHSİS:" + s6);
            Console.WriteLine("  MASA3 KAZANC:" + s7 + " MASA1 BAHSİS:" + s8);
            Console.WriteLine("  MASA4 KAZANC:" + s9 + " MASA1 BAHSİS:" + s10);
            Console.WriteLine("  MASA4 KAZANC:" + s11 + " MASA1 BAHSİS:" + s12);
            Console.WriteLine("--------------");
            Console.WriteLine("ANA MENU  [enter]");
            Console.WriteLine("--------------");

        }

    }
}
