using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NufusKayitSistemi.Models
{
    public class Kisi
    {
        public int KisiId { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int SehirId { get; set; }
        public Sehir Sehir { get; set; }

    }
}
