﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Bu kod araç tarafından oluşturuldu.
//     Çalışma Zamanı Sürümü:4.0.30319.42000
//
//     Bu dosyada yapılacak değişiklikler yanlış davranışa neden olabilir ve
//     kod yeniden oluşturulursa kaybolur.
// </auto-generated>
//------------------------------------------------------------------------------

namespace burcnee.ServisBurc {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServisBurc.IBurcServis")]
    public interface IBurcServis {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBurcServis/BurcYorumuGetir", ReplyAction="http://tempuri.org/IBurcServis/BurcYorumuGetirResponse")]
        string BurcYorumuGetir();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBurcServis/BurcYorumuGetir", ReplyAction="http://tempuri.org/IBurcServis/BurcYorumuGetirResponse")]
        System.Threading.Tasks.Task<string> BurcYorumuGetirAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBurcServis/BurcGezegeniGetir", ReplyAction="http://tempuri.org/IBurcServis/BurcGezegeniGetirResponse")]
        string[] BurcGezegeniGetir(string burc);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBurcServis/BurcGezegeniGetir", ReplyAction="http://tempuri.org/IBurcServis/BurcGezegeniGetirResponse")]
        System.Threading.Tasks.Task<string[]> BurcGezegeniGetirAsync(string burc);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBurcServis/BurclarGetir", ReplyAction="http://tempuri.org/IBurcServis/BurclarGetirResponse")]
        string[] BurclarGetir();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBurcServis/BurclarGetir", ReplyAction="http://tempuri.org/IBurcServis/BurclarGetirResponse")]
        System.Threading.Tasks.Task<string[]> BurclarGetirAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IBurcServisChannel : burcnee.ServisBurc.IBurcServis, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class BurcServisClient : System.ServiceModel.ClientBase<burcnee.ServisBurc.IBurcServis>, burcnee.ServisBurc.IBurcServis {
        
        public BurcServisClient() {
        }
        
        public BurcServisClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public BurcServisClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BurcServisClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BurcServisClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string BurcYorumuGetir() {
            return base.Channel.BurcYorumuGetir();
        }
        
        public System.Threading.Tasks.Task<string> BurcYorumuGetirAsync() {
            return base.Channel.BurcYorumuGetirAsync();
        }
        
        public string[] BurcGezegeniGetir(string burc) {
            return base.Channel.BurcGezegeniGetir(burc);
        }
        
        public System.Threading.Tasks.Task<string[]> BurcGezegeniGetirAsync(string burc) {
            return base.Channel.BurcGezegeniGetirAsync(burc);
        }
        
        public string[] BurclarGetir() {
            return base.Channel.BurclarGetir();
        }
        
        public System.Threading.Tasks.Task<string[]> BurclarGetirAsync() {
            return base.Channel.BurclarGetirAsync();
        }
    }
}
