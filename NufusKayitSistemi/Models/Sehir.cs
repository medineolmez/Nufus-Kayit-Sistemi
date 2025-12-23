using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NufusKayitSistemi.Models
{
    public class Sehir
    {
        public int Id { get; set; }
        public string SehirAdi { get; set; }
        public ICollection<Kisi> Kisiler { get; set; }
    }
}
