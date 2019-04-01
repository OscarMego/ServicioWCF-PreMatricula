using ServicioDeSolicitudesDePrematricula.Dominio;
using ServicioDeSolicitudesDePrematricula.Errores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ServicioDeSolicitudesDePrematricula
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "ISolicitudMatriculas" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface ISolicitudMatriculas
    {
        [FaultContract(typeof(RepetidoException))] // El manejador de errores
        [OperationContract]
        SolicitudMatricula CrearSolicitud(SolicitudMatricula solicitud);
        [OperationContract]
        SolicitudMatricula ObtenerSolicitud(String dni);
        [OperationContract]
        SolicitudMatricula ModificarSolicitud(SolicitudMatricula solicitud);
        [OperationContract]
        void EliminarSolicitud(String dni);
        [OperationContract]
        List<SolicitudMatricula> ListarSolicitud();
    }
}
