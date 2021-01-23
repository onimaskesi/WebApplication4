using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace BurcYorumServis
{
    // NOT: "IService1" arabirim adını kodda ve yapılandırma dosyasında birlikte değiştirmek için "Yeniden Düzenle" menüsündeki "Yeniden Adlandır" komutunu kullanabilirsiniz.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        string BurcYorumuGetir();

        [OperationContract]
        string BurcGezegeniGetir(string burc);

        [OperationContract]
        List<string> BurclarGetir(string burc);
    }

}
