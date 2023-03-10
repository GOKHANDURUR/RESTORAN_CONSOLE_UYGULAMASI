using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restoran_v1
{
    internal class Urunler:IUrunler
    {
        public int kucukboy { get; set; }
        public int ortaboy { get; set; }
        public int buyukboy { get; set; }
        public int sarımsaklıekmek { get; set; }
        public int tavukparcaları { get; set; }
        public int patates { get; set; }
        public int sufle { get; set; }
        public int tiramisu { get; set; }
        public int mozaikpasta { get; set; }
        public int kucukayran { get; set; }
        public int buyukayran { get; set; }
        public int su { get; set; }

        public bool durum { get; set; }
    }
}
