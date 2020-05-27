﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UnitesWebConverter_Nabeel_Mahdee.ServiceReferenceToWeight {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReferenceToWeight.WebService1Soap")]
    public interface WebService1Soap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/kilogramToGram", ReplyAction="*")]
        double kilogramToGram(double kg);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/kilogramToGram", ReplyAction="*")]
        System.Threading.Tasks.Task<double> kilogramToGramAsync(double kg);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/gramToKilogram", ReplyAction="*")]
        double gramToKilogram(double g);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/gramToKilogram", ReplyAction="*")]
        System.Threading.Tasks.Task<double> gramToKilogramAsync(double g);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/poundToKilogram", ReplyAction="*")]
        double poundToKilogram(double lb);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/poundToKilogram", ReplyAction="*")]
        System.Threading.Tasks.Task<double> poundToKilogramAsync(double lb);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/kilogramToPound", ReplyAction="*")]
        double kilogramToPound(double kg);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/kilogramToPound", ReplyAction="*")]
        System.Threading.Tasks.Task<double> kilogramToPoundAsync(double kg);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/poundToGram", ReplyAction="*")]
        double poundToGram(double lb);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/poundToGram", ReplyAction="*")]
        System.Threading.Tasks.Task<double> poundToGramAsync(double lb);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/gramToPound", ReplyAction="*")]
        double gramToPound(double gm);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/gramToPound", ReplyAction="*")]
        System.Threading.Tasks.Task<double> gramToPoundAsync(double gm);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WebService1SoapChannel : UnitesWebConverter_Nabeel_Mahdee.ServiceReferenceToWeight.WebService1Soap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WebService1SoapClient : System.ServiceModel.ClientBase<UnitesWebConverter_Nabeel_Mahdee.ServiceReferenceToWeight.WebService1Soap>, UnitesWebConverter_Nabeel_Mahdee.ServiceReferenceToWeight.WebService1Soap {
        
        public WebService1SoapClient() {
        }
        
        public WebService1SoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WebService1SoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebService1SoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebService1SoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public double kilogramToGram(double kg) {
            return base.Channel.kilogramToGram(kg);
        }
        
        public System.Threading.Tasks.Task<double> kilogramToGramAsync(double kg) {
            return base.Channel.kilogramToGramAsync(kg);
        }
        
        public double gramToKilogram(double g) {
            return base.Channel.gramToKilogram(g);
        }
        
        public System.Threading.Tasks.Task<double> gramToKilogramAsync(double g) {
            return base.Channel.gramToKilogramAsync(g);
        }
        
        public double poundToKilogram(double lb) {
            return base.Channel.poundToKilogram(lb);
        }
        
        public System.Threading.Tasks.Task<double> poundToKilogramAsync(double lb) {
            return base.Channel.poundToKilogramAsync(lb);
        }
        
        public double kilogramToPound(double kg) {
            return base.Channel.kilogramToPound(kg);
        }
        
        public System.Threading.Tasks.Task<double> kilogramToPoundAsync(double kg) {
            return base.Channel.kilogramToPoundAsync(kg);
        }
        
        public double poundToGram(double lb) {
            return base.Channel.poundToGram(lb);
        }
        
        public System.Threading.Tasks.Task<double> poundToGramAsync(double lb) {
            return base.Channel.poundToGramAsync(lb);
        }
        
        public double gramToPound(double gm) {
            return base.Channel.gramToPound(gm);
        }
        
        public System.Threading.Tasks.Task<double> gramToPoundAsync(double gm) {
            return base.Channel.gramToPoundAsync(gm);
        }
    }
}