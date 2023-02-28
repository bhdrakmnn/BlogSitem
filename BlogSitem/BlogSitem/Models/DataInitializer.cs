using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace BlogSitem.Models
{
    public class DataInitializer:DropCreateDatabaseIfModelChanges<DataContext>
    {
        protected override void Seed(DataContext context)
        {
            var kategori = new List<Kategori>()
            {
                new Kategori() {KategoriAd = "C#" },
                new Kategori() {KategoriAd = "Unity" },
                new Kategori() {KategoriAd = "Flutter" },
            };
            foreach (var item in kategori)
            {
                context.Kategoris.Add(item);
            }
            context.SaveChanges();

            var makale = new List<Makale>()
            {
                new Makale() {Baslik="C# Dilindeki Tamel Veri Tipleri ", Aciklama="Öncelikle veri tipi nedir ve ne gibi bir görevi vardır sorularının cevabını arayalım. C# dili için her sınıf bir veri tipidir. Klasik programlama dillerinde karakterler, tamsayılar, kesirli sayılar ve boolean gibi ilkel veri tipleri dile gömülüdür ve her bir veri tipi bir anahtar sözcükle ifade edilmektedir. Fakat C# gibi nesne yönelimli programlama dillerinde her sınıf soyut bir veri yapısını göstermektedir. Bundan dolayı C# ilkel veri tiplerinden arındırılmış haldedir.", Resim="2.png",YayinTarih=Convert.ToDateTime("2023-01-27"),Goruntulenme=0,Onay=true,KategoriId=1,KullaniciAd="bahadirakman"},
                new Makale() {Baslik="C# Sınıf (Class) Yapısı ", Aciklama="C# Sınıf (Class) Yapısı nedir sorusuna vereceğimiz en iyi cevap ise şöyledir. Bir metot, fonksiyon veya davranış tanımlayabiliriz, bu metotlar, fonksiyonlar veya davranışlar, bunları bir araya getirerek bir bütün oluşturmak için ortak ve benzer özelliklere sahiptir. Sınıfı programlama ortamına aktarmak için kullanılan proje taslağı ile karşılaştırabiliriz. Şablon, verilerin nasıl saklanacağını, işleneceğini ve bunlara nasıl erişileceğini tanımlar.ilk olarak bir sınıf tanımlamamız lazım burada bir arabadan yola çıkalım, bir arabanız var. Arabanızın rengi yani  (dış görüntüsü boyası ) bir sınıftır çünkü her arabanın bir rengi vardır. Üstünde barındırdığı mavi yeşil siyah veya beyaz bunlar bir değişken tipidir değişkeni temsil eder veya motor gücü aracın kaç kapılı olduğu vs. metotları temsil eder. genel olarak bir araç ise sınıfı temsil eder. çünkü bu özelliklerin hespi tek bir araçta yanı sınıfta barındırılabilir.", Resim="2.png",YayinTarih=Convert.ToDateTime("2023-01-21"),Goruntulenme=0,Onay=true,KategoriId=1,KullaniciAd="bahadirakman"},
                new Makale() {Baslik="Unity Nedir ", Aciklama="Unity, öncelikli olarak bilgisayarlar, konsollar ve mobil cihazlar için video oyunları ve simülasyonları geliştirmek için kullanılan ve Unity Technologies tarafından geliştirilen çapraz platform bir oyun motorudur. İlk kez yalnızca Apple'ın 2005'teki Worldwide Developers Conference'da OS X için ilan edildi, bu tarihten itibaren 27 platformu hedeflemek üzere genişletildi.Unity oyun motoru; film sektörü, otomotiv sektörü, mimari, mühendislik ve inşaat gibi video oyunları dışındaki farklı endüstriler tarafından da benimsenmiş ve kullanılmaktadır.Unity'nin altı ana sürümü yayınlandı. 2006 WWDC gösterisinde Apple, Unity'yi En İyi Mac OS X Grafik Kullanımı kategorisinde birinci olarak seçti.Unity motoru ile yazılmış oyunlara örnek olarak Battlestar Galactica Online, Firewatch, Unturned, Layers of Fear, Armello, The Long Dark ve Traffic Racer verilebilir. Ayrıca Unity'nin değiştirilmiş sürümünü kullanan Pillars of Eternity ve Tyranny de bu motor kullanılarak yapılan rol yapma oyunlarındandır.Unity, piyasaya sürülmesinden bu yana birçok yeni sürüm ve yenilik yayınlamaktadır. Platformun sunduğu en son kararlı sürüm 2019.3.13'tür ve Mayıs 2020'de piyasaya sürülmüştür.", Resim="3.png",YayinTarih=Convert.ToDateTime("2022-11-27"),Goruntulenme=0,Onay=true,KategoriId=2,KullaniciAd="ipeksevindik"},
            };
            foreach (var item in makale)
            {
                context.Makales.Add(item);
            }
            context.SaveChanges();

            base.Seed(context);
        }
    }
}