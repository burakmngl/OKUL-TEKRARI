using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _KitapDukkani
{
    class Kitap
    {
        public string KitapAdı { get; set; }
        public string KitapTürü { get; set; }
        public int SayfaSayısı { get; set; }
        public decimal KitapFiyatı { get; set; }
        public Yazar Yazarı { get; set; }
    }
}
