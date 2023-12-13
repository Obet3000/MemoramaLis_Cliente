﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MemoramaLis_Cliente.ServicioPartida {
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServicioPartida.IServicioPartida", CallbackContract=typeof(MemoramaLis_Cliente.ServicioPartida.IServicioPartidaCallback))]
    public interface IServicioPartida {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IServicioPartida/UnirseAPartida")]
        void UnirseAPartida(MemoramaLis_Cliente.ServicioPartida.JugadoresDTO jugador, string codigoDePartida);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IServicioPartida/UnirseAPartida")]
        System.Threading.Tasks.Task UnirseAPartidaAsync(MemoramaLis_Cliente.ServicioPartida.JugadoresDTO jugador, string codigoDePartida);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IServicioPartida/EnviarMovimiento")]
        void EnviarMovimiento(int movimiento, string nombreUsuario, string codigoDePartida, string resultado, string tipo);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IServicioPartida/EnviarMovimiento")]
        System.Threading.Tasks.Task EnviarMovimientoAsync(int movimiento, string nombreUsuario, string codigoDePartida, string resultado, string tipo);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IServicioPartida/SalirDePartida")]
        void SalirDePartida(string nombreDeUsuario, string codigoDePartida);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IServicioPartida/SalirDePartida")]
        System.Threading.Tasks.Task SalirDePartidaAsync(string nombreDeUsuario, string codigoDePartida);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IServicioPartida/CrearPartida")]
        void CrearPartida(string codigoDePartida);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IServicioPartida/CrearPartida")]
        System.Threading.Tasks.Task CrearPartidaAsync(string codigoDePartida);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IServicioPartida/BorrarPartida")]
        void BorrarPartida(string codigoDePartida);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IServicioPartida/BorrarPartida")]
        System.Threading.Tasks.Task BorrarPartidaAsync(string codigoDePartida);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IServicioPartida/ContarJugadores")]
        void ContarJugadores(string codigoDePartida);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IServicioPartida/ContarJugadores")]
        System.Threading.Tasks.Task ContarJugadoresAsync(string codigoDePartida);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IServicioPartida/IniciarJuego")]
        void IniciarJuego(string codigoDePartida);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IServicioPartida/IniciarJuego")]
        System.Threading.Tasks.Task IniciarJuegoAsync(string codigoDePartida);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IServicioPartida/ActualizarInformacionDeJugador")]
        void ActualizarInformacionDeJugador(MemoramaLis_Cliente.ServicioPartida.JugadoresDTO jugador, string codigoDePartida);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IServicioPartida/ActualizarInformacionDeJugador")]
        System.Threading.Tasks.Task ActualizarInformacionDeJugadorAsync(MemoramaLis_Cliente.ServicioPartida.JugadoresDTO jugador, string codigoDePartida);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IServicioPartida/ReportarJugador")]
        void ReportarJugador(string nombreDeUSuario, string codigoDePartida);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IServicioPartida/ReportarJugador")]
        System.Threading.Tasks.Task ReportarJugadorAsync(string nombreDeUSuario, string codigoDePartida);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IServicioPartida/TerminarPartida")]
        void TerminarPartida(string codigoDePartida);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IServicioPartida/TerminarPartida")]
        System.Threading.Tasks.Task TerminarPartidaAsync(string codigoDePartida);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IServicioPartida/PasarTurno")]
        void PasarTurno(int turno, string codigoDePartida);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IServicioPartida/PasarTurno")]
        System.Threading.Tasks.Task PasarTurnoAsync(int turno, string codigoDePartida);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServicioPartidaCallback {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IServicioPartida/RecibirTablero")]
        void RecibirTablero(System.Collections.Generic.Dictionary<int, string> tablero);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IServicioPartida/RecibirMovimiento")]
        void RecibirMovimiento(string nombreJugador, int movimiento, string resultado);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IServicioPartida/ExpulsarJugador")]
        void ExpulsarJugador(string nombreJugador);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IServicioPartida/ObtenerListaDeJugadores")]
        void ObtenerListaDeJugadores(MemoramaLis_Cliente.ServicioPartida.JugadoresDTO[] jugadores);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IServicioPartida/ObtenerJugadorReportado")]
        void ObtenerJugadorReportado(bool estado);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IServicioPartida/RespuestaDeUnirseAPartida")]
        void RespuestaDeUnirseAPartida(string codigoDeRespuesta);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IServicioPartida/MostrarTerminarPartida")]
        void MostrarTerminarPartida(string[] ganadores, int puntos);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IServicioPartida/RecibirEstadoDePartida")]
        void RecibirEstadoDePartida(string codigoDeRespuesta);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IServicioPartida/RecibirTurno")]
        void RecibirTurno(int turno);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IServicioPartida/RecibirGanador")]
        void RecibirGanador(MemoramaLis_Cliente.ServicioPartida.JugadoresDTO ganador);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServicioPartidaChannel : MemoramaLis_Cliente.ServicioPartida.IServicioPartida, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServicioPartidaClient : System.ServiceModel.DuplexClientBase<MemoramaLis_Cliente.ServicioPartida.IServicioPartida>, MemoramaLis_Cliente.ServicioPartida.IServicioPartida {
        
        public ServicioPartidaClient(System.ServiceModel.InstanceContext callbackInstance) : 
                base(callbackInstance) {
        }
        
        public ServicioPartidaClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName) : 
                base(callbackInstance, endpointConfigurationName) {
        }
        
        public ServicioPartidaClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, string remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public ServicioPartidaClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public ServicioPartidaClient(System.ServiceModel.InstanceContext callbackInstance, System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, binding, remoteAddress) {
        }
        
        public void UnirseAPartida(MemoramaLis_Cliente.ServicioPartida.JugadoresDTO jugador, string codigoDePartida) {
            base.Channel.UnirseAPartida(jugador, codigoDePartida);
        }
        
        public System.Threading.Tasks.Task UnirseAPartidaAsync(MemoramaLis_Cliente.ServicioPartida.JugadoresDTO jugador, string codigoDePartida) {
            return base.Channel.UnirseAPartidaAsync(jugador, codigoDePartida);
        }
        
        public void EnviarMovimiento(int movimiento, string nombreUsuario, string codigoDePartida, string resultado, string tipo) {
            base.Channel.EnviarMovimiento(movimiento, nombreUsuario, codigoDePartida, resultado, tipo);
        }
        
        public System.Threading.Tasks.Task EnviarMovimientoAsync(int movimiento, string nombreUsuario, string codigoDePartida, string resultado, string tipo) {
            return base.Channel.EnviarMovimientoAsync(movimiento, nombreUsuario, codigoDePartida, resultado, tipo);
        }
        
        public void SalirDePartida(string nombreDeUsuario, string codigoDePartida) {
            base.Channel.SalirDePartida(nombreDeUsuario, codigoDePartida);
        }
        
        public System.Threading.Tasks.Task SalirDePartidaAsync(string nombreDeUsuario, string codigoDePartida) {
            return base.Channel.SalirDePartidaAsync(nombreDeUsuario, codigoDePartida);
        }
        
        public void CrearPartida(string codigoDePartida) {
            base.Channel.CrearPartida(codigoDePartida);
        }
        
        public System.Threading.Tasks.Task CrearPartidaAsync(string codigoDePartida) {
            return base.Channel.CrearPartidaAsync(codigoDePartida);
        }
        
        public void BorrarPartida(string codigoDePartida) {
            base.Channel.BorrarPartida(codigoDePartida);
        }
        
        public System.Threading.Tasks.Task BorrarPartidaAsync(string codigoDePartida) {
            return base.Channel.BorrarPartidaAsync(codigoDePartida);
        }
        
        public void ContarJugadores(string codigoDePartida) {
            base.Channel.ContarJugadores(codigoDePartida);
        }
        
        public System.Threading.Tasks.Task ContarJugadoresAsync(string codigoDePartida) {
            return base.Channel.ContarJugadoresAsync(codigoDePartida);
        }
        
        public void IniciarJuego(string codigoDePartida) {
            base.Channel.IniciarJuego(codigoDePartida);
        }
        
        public System.Threading.Tasks.Task IniciarJuegoAsync(string codigoDePartida) {
            return base.Channel.IniciarJuegoAsync(codigoDePartida);
        }
        
        public void ActualizarInformacionDeJugador(MemoramaLis_Cliente.ServicioPartida.JugadoresDTO jugador, string codigoDePartida) {
            base.Channel.ActualizarInformacionDeJugador(jugador, codigoDePartida);
        }
        
        public System.Threading.Tasks.Task ActualizarInformacionDeJugadorAsync(MemoramaLis_Cliente.ServicioPartida.JugadoresDTO jugador, string codigoDePartida) {
            return base.Channel.ActualizarInformacionDeJugadorAsync(jugador, codigoDePartida);
        }
        
        public void ReportarJugador(string nombreDeUSuario, string codigoDePartida) {
            base.Channel.ReportarJugador(nombreDeUSuario, codigoDePartida);
        }
        
        public System.Threading.Tasks.Task ReportarJugadorAsync(string nombreDeUSuario, string codigoDePartida) {
            return base.Channel.ReportarJugadorAsync(nombreDeUSuario, codigoDePartida);
        }
        
        public void TerminarPartida(string codigoDePartida) {
            base.Channel.TerminarPartida(codigoDePartida);
        }
        
        public System.Threading.Tasks.Task TerminarPartidaAsync(string codigoDePartida) {
            return base.Channel.TerminarPartidaAsync(codigoDePartida);
        }
        
        public void PasarTurno(int turno, string codigoDePartida) {
            base.Channel.PasarTurno(turno, codigoDePartida);
        }
        
        public System.Threading.Tasks.Task PasarTurnoAsync(int turno, string codigoDePartida) {
            return base.Channel.PasarTurnoAsync(turno, codigoDePartida);
        }
    }
}
