﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UnitesWebConverter_Nabeel_Mahdee.ServiceReferenceLength {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReferenceLength.LengthSoap")]
    public interface LengthSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/kilometerToMeter", ReplyAction="*")]
        double kilometerToMeter(double km);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/kilometerToMeter", ReplyAction="*")]
        System.Threading.Tasks.Task<double> kilometerToMeterAsync(double km);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/meterToKilometer", ReplyAction="*")]
        double meterToKilometer(double m);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/meterToKilometer", ReplyAction="*")]
        System.Threading.Tasks.Task<double> meterToKilometerAsync(double m);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/meterToFoot", ReplyAction="*")]
        double meterToFoot(double m);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/meterToFoot", ReplyAction="*")]
        System.Threading.Tasks.Task<double> meterToFootAsync(double m);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/footToMeter", ReplyAction="*")]
        double footToMeter(double ft);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/footToMeter", ReplyAction="*")]
        System.Threading.Tasks.Task<double> footToMeterAsync(double ft);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/kilometerToFoot", ReplyAction="*")]
        double kilometerToFoot(double km);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/kilometerToFoot", ReplyAction="*")]
        System.Threading.Tasks.Task<double> kilometerToFootAsync(double km);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/footToKilometer", ReplyAction="*")]
        double footToKilometer(double ft);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/footToKilometer", ReplyAction="*")]
        System.Threading.Tasks.Task<double> footToKilometerAsync(double ft);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface LengthSoapChannel : UnitesWebConverter_Nabeel_Mahdee.ServiceReferenceLength.LengthSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class LengthSoapClient : System.ServiceModel.ClientBase<UnitesWebConverter_Nabeel_Mahdee.ServiceReferenceLength.LengthSoap>, UnitesWebConverter_Nabeel_Mahdee.ServiceReferenceLength.LengthSoap {
        
        public LengthSoapClient() {
        }
        
        public LengthSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public LengthSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public LengthSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public LengthSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public double kilometerToMeter(double km) {
            return base.Channel.kilometerToMeter(km);
        }
        
        public System.Threading.Tasks.Task<double> kilometerToMeterAsync(double km) {
            return base.Channel.kilometerToMeterAsync(km);
        }
        
        public double meterToKilometer(double m) {
            return base.Channel.meterToKilometer(m);
        }
        
        public System.Threading.Tasks.Task<double> meterToKilometerAsync(double m) {
            return base.Channel.meterToKilometerAsync(m);
        }
        
        public double meterToFoot(double m) {
            return base.Channel.meterToFoot(m);
        }
        
        public System.Threading.Tasks.Task<double> meterToFootAsync(double m) {
            return base.Channel.meterToFootAsync(m);
        }
        
        public double footToMeter(double ft) {
            return base.Channel.footToMeter(ft);
        }
        
        public System.Threading.Tasks.Task<double> footToMeterAsync(double ft) {
            return base.Channel.footToMeterAsync(ft);
        }
        
        public double kilometerToFoot(double km) {
            return base.Channel.kilometerToFoot(km);
        }
        
        public System.Threading.Tasks.Task<double> kilometerToFootAsync(double km) {
            return base.Channel.kilometerToFootAsync(km);
        }
        
        public double footToKilometer(double ft) {
            return base.Channel.footToKilometer(ft);
        }
        
        public System.Threading.Tasks.Task<double> footToKilometerAsync(double ft) {
            return base.Channel.footToKilometerAsync(ft);
        }
    }
}
