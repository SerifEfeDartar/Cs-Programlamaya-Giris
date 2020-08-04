using System; // Gerekli Kütüphaneler Eklenir.

namespace Github
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Adınızı Giriniz: "); // Kullanıcıya Ne Yapacağını Bilnesi İçin Bir İstek Gönderilir.
            string adiniz = Console.ReadLine(); // Kullanıcıdan Veri Alınıp 'adiniz' İsimli String Değişkene Eklenir.

            Console.Clear(); // Temiz Bir Görüntü İçin Ekran Temizlenir.

            Console.WriteLine("Adınız: {0}", adiniz); // İsim Ekrana Yazılır.
            // Ekranın Biz İnceleyene Kadar Açık Kalması İçin 'Console.Readline();' Komutu Kullanılabilir.
        }
    }
}