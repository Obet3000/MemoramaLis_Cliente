﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MemoramaLis_Cliente.AutentificacionServicio {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="JugadoresDTO", Namespace="http://schemas.datacontract.org/2004/07/Dominio")]
    [System.SerializableAttribute()]
    public partial class JugadoresDTO : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ContraseniaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool EstadoConexionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FotosField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string IdJugadorField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NombreJugadorField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int puntosField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Contrasenia {
            get {
                return this.ContraseniaField;
            }
            set {
                if ((object.ReferenceEquals(this.ContraseniaField, value) != true)) {
                    this.ContraseniaField = value;
                    this.RaisePropertyChanged("Contrasenia");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Email {
            get {
                return this.EmailField;
            }
            set {
                if ((object.ReferenceEquals(this.EmailField, value) != true)) {
                    this.EmailField = value;
                    this.RaisePropertyChanged("Email");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool EstadoConexion {
            get {
                return this.EstadoConexionField;
            }
            set {
                if ((this.EstadoConexionField.Equals(value) != true)) {
                    this.EstadoConexionField = value;
                    this.RaisePropertyChanged("EstadoConexion");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Fotos {
            get {
                return this.FotosField;
            }
            set {
                if ((object.ReferenceEquals(this.FotosField, value) != true)) {
                    this.FotosField = value;
                    this.RaisePropertyChanged("Fotos");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string IdJugador {
            get {
                return this.IdJugadorField;
            }
            set {
                if ((object.ReferenceEquals(this.IdJugadorField, value) != true)) {
                    this.IdJugadorField = value;
                    this.RaisePropertyChanged("IdJugador");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NombreJugador {
            get {
                return this.NombreJugadorField;
            }
            set {
                if ((object.ReferenceEquals(this.NombreJugadorField, value) != true)) {
                    this.NombreJugadorField = value;
                    this.RaisePropertyChanged("NombreJugador");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int puntos {
            get {
                return this.puntosField;
            }
            set {
                if ((this.puntosField.Equals(value) != true)) {
                    this.puntosField = value;
                    this.RaisePropertyChanged("puntos");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="AutentificacionServicio.IAutentificacionServicio", CallbackContract=typeof(MemoramaLis_Cliente.AutentificacionServicio.IAutentificacionServicioCallback))]
    public interface IAutentificacionServicio {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IAutentificacionServicio/AutentificacionUsuario")]
        void AutentificacionUsuario(string email, string contrasenia);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IAutentificacionServicio/AutentificacionUsuario")]
        System.Threading.Tasks.Task AutentificacionUsuarioAsync(string email, string contrasenia);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IAutentificacionServicioCallback {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IAutentificacionServicio/RespuestaAutentificacion")]
        void RespuestaAutentificacion(MemoramaLis_Cliente.AutentificacionServicio.JugadoresDTO jugador);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IAutentificacionServicioChannel : MemoramaLis_Cliente.AutentificacionServicio.IAutentificacionServicio, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class AutentificacionServicioClient : System.ServiceModel.DuplexClientBase<MemoramaLis_Cliente.AutentificacionServicio.IAutentificacionServicio>, MemoramaLis_Cliente.AutentificacionServicio.IAutentificacionServicio {
        
        public AutentificacionServicioClient(System.ServiceModel.InstanceContext callbackInstance) : 
                base(callbackInstance) {
        }
        
        public AutentificacionServicioClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName) : 
                base(callbackInstance, endpointConfigurationName) {
        }
        
        public AutentificacionServicioClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, string remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public AutentificacionServicioClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public AutentificacionServicioClient(System.ServiceModel.InstanceContext callbackInstance, System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, binding, remoteAddress) {
        }
        
        public void AutentificacionUsuario(string email, string contrasenia) {
            base.Channel.AutentificacionUsuario(email, contrasenia);
        }
        
        public System.Threading.Tasks.Task AutentificacionUsuarioAsync(string email, string contrasenia) {
            return base.Channel.AutentificacionUsuarioAsync(email, contrasenia);
        }
    }
}
