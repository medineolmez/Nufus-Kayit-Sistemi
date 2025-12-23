using NufusKayitSistemi.Data;
using NufusKayitSistemi.Models;
using Microsoft.EntityFrameworkCore;

class Program
{
    static void Main()
    {
        using var context = new NufusContext();

        // CREATE
        

        var sehir = new Sehir { SehirAdi = "İstanbul" };
        context.Sehirler.Add(sehir);
        context.SaveChanges();

        var kisi = new Kisi { Ad = "Ayşe", Soyad = "KAYA", SehirId = sehir.Id };
        context.Kisiler.Add(kisi);
        context.SaveChanges();

        // READ
        var kisiler = context.Kisiler.Include(k => k.Sehir).ToList();
        Console.WriteLine("\nKişiler Listesi:");
        foreach (var k in kisiler)
        {
            Console.WriteLine($"{k.Ad} {k.Soyad} - {k.Sehir.SehirAdi}");
        }

        // UPDATE
        var guncellenecek = context.Kisiler.FirstOrDefault(x => x.Ad == "Ayşe");
        if (guncellenecek != null)
        {
            guncellenecek.Soyad = "ATEŞ";
            context.SaveChanges();
        }

        // DELETE
        var silinecek = context.Sehirler.FirstOrDefault(x => x.SehirAdi == "İstanbul");
        if (silinecek != null)
        {
            context.Sehirler.Remove(silinecek);
            context.SaveChanges();
        }

        Console.WriteLine("\nİşlemler tamamlandı!");
    }

    static void AddKisi(string ad, string soyad, string sehirAdi)
    {
        using var context = new NufusContext();
        var sehir = context.Sehirler.FirstOrDefault(s => s.SehirAdi == sehirAdi);

        if (sehir == null)
        {
            sehir = new Sehir { SehirAdi = sehirAdi };
            context.Sehirler.Add(sehir);
            context.SaveChanges();
        }

        var kisi = new Kisi { Ad = ad, Soyad = soyad, SehirId = sehir.Id };
        context.Kisiler.Add(kisi);
        context.SaveChanges();
    }

}
