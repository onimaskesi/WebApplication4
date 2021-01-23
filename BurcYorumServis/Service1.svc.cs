using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace BurcYorumServis
{
    // NOT: "Service1" sınıf adını kodda, svc'de ve yapılandırma dosyasında birlikte değiştirmek için "Yeniden Düzenle" menüsündeki "Yeniden Adlandır" komutunu kullanabilirsiniz.
    // NOT: Bu hizmeti test etmek üzere WCF Test İstemcisi'ni başlatmak için lütfen Çözüm Gezgini'nde Service1.svc'yi veya Service1.svc.cs'yi seçin ve hata ayıklamaya başlayın.
    public class Service1 : IService1
    {
        public List<string> BurclarGetir(string burc)
        {
            List<string> Burclar = new List<string>();
            Burclar.Add("Aslan");
            Burclar.Add("Kova");
            Burclar.Add("Ikizler");
            Burclar.Add("Balik");
            Burclar.Add("Yengec");
            Burclar.Add("Oglak");
            Burclar.Add("Basak");
            Burclar.Add("Akrep");
            Burclar.Add("Yay");
            Burclar.Add("Terazi");
            Burclar.Add("Boga");
            Burclar.Add("Koç");

            return Burclar;
        }

        public string BurcYorumuGetir()
        {
            List<string> Yorumlar = new List<string>();
            Yorumlar.Add("Harika bir gun sizi bekliyor.");
            Yorumlar.Add("Aradiginiz aski bugun bulabilirsiniz.");
            Yorumlar.Add("Sans bugun yuzunuze gulebilir.");
            Yorumlar.Add("Surprizlere acik olun.");
            Yorumlar.Add("Bugun ask hayatinizda buyuk degisiklikler olabilir.");
            Yorumlar.Add("Basariniz insanlarin agzindan dusmeyecek.");
            Yorumlar.Add("Zor bir gun gecireceksiniz.");
            Yorumlar.Add("Ev yasantinizda aradiginiz huzuru bugun bulacaksiniz.");
            Yorumlar.Add("Bol bol kahkaha atacaginiz bir gun olacak.");
            Yorumlar.Add("Harcamalariniza dikkat etmelisiniz.");
            Yorumlar.Add("Talih kusu bugun sizin kafaniza konabilir.");
            Yorumlar.Add("Cok guzel haberler alacaksiniz.");
            Yorumlar.Add("Kotu bir habere kendinizi hazirlayin.");
            Yorumlar.Add("Uzun zamandir ertelediginiz isleri yapmak icin cok guzel bir gun.");
            Yorumlar.Add("Hayatinizin aski bugun karsiniza cikabilir.");
            Yorumlar.Add("Beklenmedik olayla karsi karsiya kalabilirsiniz.");
            Yorumlar.Add("Bugun bakim yapma gununuz.");
            Yorumlar.Add("Kendinizle kaliteli vakit gecirmenin zamani gelmis.");
            Yorumlar.Add("Kendinizi mutlu edecek seyler yapmalisiniz.");
            Yorumlar.Add("Ailenize daha fazla vakit ayirmalisiniz.");
            Yorumlar.Add("Sagliginiza daha fazla dikkat etmelisiniz.");
            Yorumlar.Add("Bir fincan cay esliginde guzel bir film izlemeyi hak ediyorsunuz.");
            Yorumlar.Add("Alisveris yapmak icin guzel bir gun.");
            Yorumlar.Add("Yilanlardan ve yalanlardan uzak durmaniz gerekiyor.");
            Yorumlar.Add("Sonunuzu dusunurseniz kahraman olamayabilirsiniz.");
            Yorumlar.Add("Cesur adimlar atmanin bugun tam zamani.");
            Yorumlar.Add("Verdiginiz kararlarin arkasinda durmalisiniz.");
            Yorumlar.Add("Bugun kendinizi simartma gununuz.");
            Yorumlar.Add("Bir günlük rejimi bozmanin kimseye zarari dokunmaz.");
            Yorumlar.Add("Gizemli kisiliginiz dikkatleri uzerinize cekiyor.");
            Yorumlar.Add("Herkese kullandigin adalet terazisini biraz da kendin icin kullanmalisin. Kendine cok haksizlik ediyorsun.");
            Yorumlar.Add("Sevdigin bir dostuna icini dokmek sana cok iyi gelecektir.");

            Random RandomYorum = new Random();
            int randomNumber = RandomYorum.Next(0, Yorumlar.Count);

            return Yorumlar[randomNumber];

        }

        public string BurcGezegeniGetir(string burc)
        {

            string gezegen = "Dünya";

            if (burc == "Aslan")
            {
                gezegen = "Güneş";
            }
            if (burc == "Koç")
            {
                gezegen = "Mars";
            }
            if (burc == "Boğa")
            {
                gezegen = "Venüs";
            }
            if (burc == "İkizler")
            {
                gezegen = "Merkür";
            }
            if (burc == "Yengeç")
            {
                gezegen = "Ay";
            }
            if (burc == "Başak")
            {
                gezegen = "Merkür";
            }
            if (burc == "Terazi")
            {
                gezegen = "Venüs";
            }
            if (burc == "Akrep")
            {
                gezegen = "Pluto";
            }
            if (burc == "Yay")
            {
                gezegen = "Jupiter";
            }
            if (burc == "Oğlak")
            {
                gezegen = "Satürn";
            }
            if (burc == "Kova")
            {
                gezegen = "Uranüs";
            }
            if (burc == "Balık")
            {
                gezegen = "Neptün";
            }


            return gezegen;
        }
    }
}
