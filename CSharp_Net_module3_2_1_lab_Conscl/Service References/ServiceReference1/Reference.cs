﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CSharp_Net_module3_2_1_lab_Conscl.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/add", ReplyAction="http://tempuri.org/IService1/addResponse")]
        int add(int a, int b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/add", ReplyAction="http://tempuri.org/IService1/addResponse")]
        System.Threading.Tasks.Task<int> addAsync(int a, int b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Sub", ReplyAction="http://tempuri.org/IService1/SubResponse")]
        int Sub(int a, int b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Sub", ReplyAction="http://tempuri.org/IService1/SubResponse")]
        System.Threading.Tasks.Task<int> SubAsync(int a, int b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Mul", ReplyAction="http://tempuri.org/IService1/MulResponse")]
        int Mul(int a, int b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Mul", ReplyAction="http://tempuri.org/IService1/MulResponse")]
        System.Threading.Tasks.Task<int> MulAsync(int a, int b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Div", ReplyAction="http://tempuri.org/IService1/DivResponse")]
        int Div(int a, int b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Div", ReplyAction="http://tempuri.org/IService1/DivResponse")]
        System.Threading.Tasks.Task<int> DivAsync(int a, int b);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : CSharp_Net_module3_2_1_lab_Conscl.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<CSharp_Net_module3_2_1_lab_Conscl.ServiceReference1.IService1>, CSharp_Net_module3_2_1_lab_Conscl.ServiceReference1.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int add(int a, int b) {
            return base.Channel.add(a, b);
        }
        
        public System.Threading.Tasks.Task<int> addAsync(int a, int b) {
            return base.Channel.addAsync(a, b);
        }
        
        public int Sub(int a, int b) {
            return base.Channel.Sub(a, b);
        }
        
        public System.Threading.Tasks.Task<int> SubAsync(int a, int b) {
            return base.Channel.SubAsync(a, b);
        }
        
        public int Mul(int a, int b) {
            return base.Channel.Mul(a, b);
        }
        
        public System.Threading.Tasks.Task<int> MulAsync(int a, int b) {
            return base.Channel.MulAsync(a, b);
        }
        
        public int Div(int a, int b) {
            return base.Channel.Div(a, b);
        }
        
        public System.Threading.Tasks.Task<int> DivAsync(int a, int b) {
            return base.Channel.DivAsync(a, b);
        }
    }
}
