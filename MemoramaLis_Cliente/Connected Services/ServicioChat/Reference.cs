﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MemoramaLis_Cliente.ServicioChat {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServicioChat.IServicioChat", CallbackContract=typeof(MemoramaLis_Cliente.ServicioChat.IServicioChatCallback))]
    public interface IServicioChat {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IServicioChat/UnirseAChat")]
        void UnirseAChat(string nombreUsuario, string codigoDeChat);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IServicioChat/UnirseAChat")]
        System.Threading.Tasks.Task UnirseAChatAsync(string nombreUsuario, string codigoDeChat);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IServicioChat/EnviarMensaje")]
        void EnviarMensaje(string mensaje, string nombreUsuario, string codigoDeChat);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IServicioChat/EnviarMensaje")]
        System.Threading.Tasks.Task EnviarMensajeAsync(string mensaje, string nombreUsuario, string codigoDeChat);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IServicioChat/SalirDelChat")]
        void SalirDelChat(string nombreDeUsuario, string codigoDeChat);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IServicioChat/SalirDelChat")]
        System.Threading.Tasks.Task SalirDelChatAsync(string nombreDeUsuario, string codigoDeChat);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IServicioChat/CrearChat")]
        void CrearChat(string codigoDeChat);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IServicioChat/CrearChat")]
        System.Threading.Tasks.Task CrearChatAsync(string codigoDeChat);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IServicioChat/BorrarChat")]
        void BorrarChat(string codigoDeChat);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IServicioChat/BorrarChat")]
        System.Threading.Tasks.Task BorrarChatAsync(string codigoDeChat);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServicioChatCallback {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IServicioChat/RecibirMensaje")]
        void RecibirMensaje(string nombreJugador, string mensaje);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServicioChatChannel : MemoramaLis_Cliente.ServicioChat.IServicioChat, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServicioChatClient : System.ServiceModel.DuplexClientBase<MemoramaLis_Cliente.ServicioChat.IServicioChat>, MemoramaLis_Cliente.ServicioChat.IServicioChat {
        
        public ServicioChatClient(System.ServiceModel.InstanceContext callbackInstance) : 
                base(callbackInstance) {
        }
        
        public ServicioChatClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName) : 
                base(callbackInstance, endpointConfigurationName) {
        }
        
        public ServicioChatClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, string remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public ServicioChatClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public ServicioChatClient(System.ServiceModel.InstanceContext callbackInstance, System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, binding, remoteAddress) {
        }
        
        public void UnirseAChat(string nombreUsuario, string codigoDeChat) {
            base.Channel.UnirseAChat(nombreUsuario, codigoDeChat);
        }
        
        public System.Threading.Tasks.Task UnirseAChatAsync(string nombreUsuario, string codigoDeChat) {
            return base.Channel.UnirseAChatAsync(nombreUsuario, codigoDeChat);
        }
        
        public void EnviarMensaje(string mensaje, string nombreUsuario, string codigoDeChat) {
            base.Channel.EnviarMensaje(mensaje, nombreUsuario, codigoDeChat);
        }
        
        public System.Threading.Tasks.Task EnviarMensajeAsync(string mensaje, string nombreUsuario, string codigoDeChat) {
            return base.Channel.EnviarMensajeAsync(mensaje, nombreUsuario, codigoDeChat);
        }
        
        public void SalirDelChat(string nombreDeUsuario, string codigoDeChat) {
            base.Channel.SalirDelChat(nombreDeUsuario, codigoDeChat);
        }
        
        public System.Threading.Tasks.Task SalirDelChatAsync(string nombreDeUsuario, string codigoDeChat) {
            return base.Channel.SalirDelChatAsync(nombreDeUsuario, codigoDeChat);
        }
        
        public void CrearChat(string codigoDeChat) {
            base.Channel.CrearChat(codigoDeChat);
        }
        
        public System.Threading.Tasks.Task CrearChatAsync(string codigoDeChat) {
            return base.Channel.CrearChatAsync(codigoDeChat);
        }
        
        public void BorrarChat(string codigoDeChat) {
            base.Channel.BorrarChat(codigoDeChat);
        }
        
        public System.Threading.Tasks.Task BorrarChatAsync(string codigoDeChat) {
            return base.Channel.BorrarChatAsync(codigoDeChat);
        }
    }
}
