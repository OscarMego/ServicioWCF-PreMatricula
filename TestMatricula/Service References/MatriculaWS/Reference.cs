﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TestMatricula.MatriculaWS {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="SolicitudMatricula", Namespace="http://schemas.datacontract.org/2004/07/ServicioDeSolicitudesDePrematricula.Domin" +
        "io")]
    [System.SerializableAttribute()]
    public partial class SolicitudMatricula : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ApellidosAlumnoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DNIField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DNIPadreApoderadoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailPadreApoderadoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private char EstadoSolicitudField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime FechaHoraRegistroField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime FechaSolicitudField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime FechaVisitaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private long IDSolicitudField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private char NivelField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NombreAlumnoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NombrePadreApoderadoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private char gradoField;
        
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
        public string ApellidosAlumno {
            get {
                return this.ApellidosAlumnoField;
            }
            set {
                if ((object.ReferenceEquals(this.ApellidosAlumnoField, value) != true)) {
                    this.ApellidosAlumnoField = value;
                    this.RaisePropertyChanged("ApellidosAlumno");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string DNI {
            get {
                return this.DNIField;
            }
            set {
                if ((object.ReferenceEquals(this.DNIField, value) != true)) {
                    this.DNIField = value;
                    this.RaisePropertyChanged("DNI");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string DNIPadreApoderado {
            get {
                return this.DNIPadreApoderadoField;
            }
            set {
                if ((object.ReferenceEquals(this.DNIPadreApoderadoField, value) != true)) {
                    this.DNIPadreApoderadoField = value;
                    this.RaisePropertyChanged("DNIPadreApoderado");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string EmailPadreApoderado {
            get {
                return this.EmailPadreApoderadoField;
            }
            set {
                if ((object.ReferenceEquals(this.EmailPadreApoderadoField, value) != true)) {
                    this.EmailPadreApoderadoField = value;
                    this.RaisePropertyChanged("EmailPadreApoderado");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public char EstadoSolicitud {
            get {
                return this.EstadoSolicitudField;
            }
            set {
                if ((this.EstadoSolicitudField.Equals(value) != true)) {
                    this.EstadoSolicitudField = value;
                    this.RaisePropertyChanged("EstadoSolicitud");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime FechaHoraRegistro {
            get {
                return this.FechaHoraRegistroField;
            }
            set {
                if ((this.FechaHoraRegistroField.Equals(value) != true)) {
                    this.FechaHoraRegistroField = value;
                    this.RaisePropertyChanged("FechaHoraRegistro");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime FechaSolicitud {
            get {
                return this.FechaSolicitudField;
            }
            set {
                if ((this.FechaSolicitudField.Equals(value) != true)) {
                    this.FechaSolicitudField = value;
                    this.RaisePropertyChanged("FechaSolicitud");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime FechaVisita {
            get {
                return this.FechaVisitaField;
            }
            set {
                if ((this.FechaVisitaField.Equals(value) != true)) {
                    this.FechaVisitaField = value;
                    this.RaisePropertyChanged("FechaVisita");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long IDSolicitud {
            get {
                return this.IDSolicitudField;
            }
            set {
                if ((this.IDSolicitudField.Equals(value) != true)) {
                    this.IDSolicitudField = value;
                    this.RaisePropertyChanged("IDSolicitud");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public char Nivel {
            get {
                return this.NivelField;
            }
            set {
                if ((this.NivelField.Equals(value) != true)) {
                    this.NivelField = value;
                    this.RaisePropertyChanged("Nivel");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NombreAlumno {
            get {
                return this.NombreAlumnoField;
            }
            set {
                if ((object.ReferenceEquals(this.NombreAlumnoField, value) != true)) {
                    this.NombreAlumnoField = value;
                    this.RaisePropertyChanged("NombreAlumno");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NombrePadreApoderado {
            get {
                return this.NombrePadreApoderadoField;
            }
            set {
                if ((object.ReferenceEquals(this.NombrePadreApoderadoField, value) != true)) {
                    this.NombrePadreApoderadoField = value;
                    this.RaisePropertyChanged("NombrePadreApoderado");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public char grado {
            get {
                return this.gradoField;
            }
            set {
                if ((this.gradoField.Equals(value) != true)) {
                    this.gradoField = value;
                    this.RaisePropertyChanged("grado");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="RepetidoException", Namespace="http://schemas.datacontract.org/2004/07/ServicioDeSolicitudesDePrematricula.Error" +
        "es")]
    [System.SerializableAttribute()]
    public partial class RepetidoException : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CodigoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescripcionField;
        
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
        public string Codigo {
            get {
                return this.CodigoField;
            }
            set {
                if ((object.ReferenceEquals(this.CodigoField, value) != true)) {
                    this.CodigoField = value;
                    this.RaisePropertyChanged("Codigo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Descripcion {
            get {
                return this.DescripcionField;
            }
            set {
                if ((object.ReferenceEquals(this.DescripcionField, value) != true)) {
                    this.DescripcionField = value;
                    this.RaisePropertyChanged("Descripcion");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="MatriculaWS.ISolicitudMatriculas")]
    public interface ISolicitudMatriculas {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISolicitudMatriculas/CrearSolicitud", ReplyAction="http://tempuri.org/ISolicitudMatriculas/CrearSolicitudResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(TestMatricula.MatriculaWS.RepetidoException), Action="http://tempuri.org/ISolicitudMatriculas/CrearSolicitudRepetidoExceptionFault", Name="RepetidoException", Namespace="http://schemas.datacontract.org/2004/07/ServicioDeSolicitudesDePrematricula.Error" +
            "es")]
        TestMatricula.MatriculaWS.SolicitudMatricula CrearSolicitud(TestMatricula.MatriculaWS.SolicitudMatricula solicitud);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISolicitudMatriculas/CrearSolicitud", ReplyAction="http://tempuri.org/ISolicitudMatriculas/CrearSolicitudResponse")]
        System.Threading.Tasks.Task<TestMatricula.MatriculaWS.SolicitudMatricula> CrearSolicitudAsync(TestMatricula.MatriculaWS.SolicitudMatricula solicitud);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISolicitudMatriculas/ObtenerSolicitud", ReplyAction="http://tempuri.org/ISolicitudMatriculas/ObtenerSolicitudResponse")]
        TestMatricula.MatriculaWS.SolicitudMatricula ObtenerSolicitud(string dni);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISolicitudMatriculas/ObtenerSolicitud", ReplyAction="http://tempuri.org/ISolicitudMatriculas/ObtenerSolicitudResponse")]
        System.Threading.Tasks.Task<TestMatricula.MatriculaWS.SolicitudMatricula> ObtenerSolicitudAsync(string dni);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISolicitudMatriculas/ModificarSolicitud", ReplyAction="http://tempuri.org/ISolicitudMatriculas/ModificarSolicitudResponse")]
        TestMatricula.MatriculaWS.SolicitudMatricula ModificarSolicitud(TestMatricula.MatriculaWS.SolicitudMatricula solicitud);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISolicitudMatriculas/ModificarSolicitud", ReplyAction="http://tempuri.org/ISolicitudMatriculas/ModificarSolicitudResponse")]
        System.Threading.Tasks.Task<TestMatricula.MatriculaWS.SolicitudMatricula> ModificarSolicitudAsync(TestMatricula.MatriculaWS.SolicitudMatricula solicitud);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISolicitudMatriculas/EliminarSolicitud", ReplyAction="http://tempuri.org/ISolicitudMatriculas/EliminarSolicitudResponse")]
        void EliminarSolicitud(string dni);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISolicitudMatriculas/EliminarSolicitud", ReplyAction="http://tempuri.org/ISolicitudMatriculas/EliminarSolicitudResponse")]
        System.Threading.Tasks.Task EliminarSolicitudAsync(string dni);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISolicitudMatriculas/ListarSolicitud", ReplyAction="http://tempuri.org/ISolicitudMatriculas/ListarSolicitudResponse")]
        TestMatricula.MatriculaWS.SolicitudMatricula[] ListarSolicitud();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISolicitudMatriculas/ListarSolicitud", ReplyAction="http://tempuri.org/ISolicitudMatriculas/ListarSolicitudResponse")]
        System.Threading.Tasks.Task<TestMatricula.MatriculaWS.SolicitudMatricula[]> ListarSolicitudAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ISolicitudMatriculasChannel : TestMatricula.MatriculaWS.ISolicitudMatriculas, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SolicitudMatriculasClient : System.ServiceModel.ClientBase<TestMatricula.MatriculaWS.ISolicitudMatriculas>, TestMatricula.MatriculaWS.ISolicitudMatriculas {
        
        public SolicitudMatriculasClient() {
        }
        
        public SolicitudMatriculasClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public SolicitudMatriculasClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SolicitudMatriculasClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SolicitudMatriculasClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public TestMatricula.MatriculaWS.SolicitudMatricula CrearSolicitud(TestMatricula.MatriculaWS.SolicitudMatricula solicitud) {
            return base.Channel.CrearSolicitud(solicitud);
        }
        
        public System.Threading.Tasks.Task<TestMatricula.MatriculaWS.SolicitudMatricula> CrearSolicitudAsync(TestMatricula.MatriculaWS.SolicitudMatricula solicitud) {
            return base.Channel.CrearSolicitudAsync(solicitud);
        }
        
        public TestMatricula.MatriculaWS.SolicitudMatricula ObtenerSolicitud(string dni) {
            return base.Channel.ObtenerSolicitud(dni);
        }
        
        public System.Threading.Tasks.Task<TestMatricula.MatriculaWS.SolicitudMatricula> ObtenerSolicitudAsync(string dni) {
            return base.Channel.ObtenerSolicitudAsync(dni);
        }
        
        public TestMatricula.MatriculaWS.SolicitudMatricula ModificarSolicitud(TestMatricula.MatriculaWS.SolicitudMatricula solicitud) {
            return base.Channel.ModificarSolicitud(solicitud);
        }
        
        public System.Threading.Tasks.Task<TestMatricula.MatriculaWS.SolicitudMatricula> ModificarSolicitudAsync(TestMatricula.MatriculaWS.SolicitudMatricula solicitud) {
            return base.Channel.ModificarSolicitudAsync(solicitud);
        }
        
        public void EliminarSolicitud(string dni) {
            base.Channel.EliminarSolicitud(dni);
        }
        
        public System.Threading.Tasks.Task EliminarSolicitudAsync(string dni) {
            return base.Channel.EliminarSolicitudAsync(dni);
        }
        
        public TestMatricula.MatriculaWS.SolicitudMatricula[] ListarSolicitud() {
            return base.Channel.ListarSolicitud();
        }
        
        public System.Threading.Tasks.Task<TestMatricula.MatriculaWS.SolicitudMatricula[]> ListarSolicitudAsync() {
            return base.Channel.ListarSolicitudAsync();
        }
    }
}