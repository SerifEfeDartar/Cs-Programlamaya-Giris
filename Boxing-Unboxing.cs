using System; // Gerekli Kütüphaneler Eklenir.

namespace Github
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi = 10; // Kutulanacak Değişken Oluşturulur.
                    
            object KUTU = sayi; // Kutulamanın Yapılacağı Object Değişken Oluşturulur Ve Kutulama Yapılır.

            int AcılanKutuSonuc = (int)KUTU; // Kutudan Çıkarma İşlemi Yapılır.
        }
    }
}