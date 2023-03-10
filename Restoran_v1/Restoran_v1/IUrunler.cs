using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restoran_v1
{
    internal interface IUrunler
    {
        int kucukboy { get; set; }
        int ortaboy { get; set; }
        int buyukboy { get; set; }
        int sarımsaklıekmek { get; set; }
        int tavukparcaları { get; set; }
        int patates { get; set; }
        int sufle { get; set; }
        int tiramisu { get; set; }
        int mozaikpasta { get; set; }
        int kucukayran { get; set; }
        int buyukayran { get; set; }
        int su { get; set; }

        bool durum { get; set; }
    }
}
