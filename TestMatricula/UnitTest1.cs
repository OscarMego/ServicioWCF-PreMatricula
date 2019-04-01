using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestMatricula.MatriculaWS;
using System.ServiceModel;
using System.Collections.Generic;

namespace TestMatricula
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestSolicitudCrear()
        {
            DateTime fecha = DateTime.Now;
            SolicitudMatriculasClient proxy = new SolicitudMatriculasClient();
            SolicitudMatricula solicitudCreado = proxy.CrearSolicitud(new SolicitudMatricula()
            {
                NombreAlumno = "Juanito",
                ApellidosAlumno = "Perez",
                DNI = "88776655",
                Nivel = 'P',
                grado = 'S',
                FechaSolicitud = fecha,
                FechaVisita = fecha,
                NombrePadreApoderado = "Apoderado",
                DNIPadreApoderado = "66778899",
                EmailPadreApoderado = "aporderado@correo.com",
                EstadoSolicitud = 'P'
            });
            Assert.AreEqual("Juanito", solicitudCreado.NombreAlumno);
            Assert.AreEqual("Perez", solicitudCreado.ApellidosAlumno);
            Assert.AreEqual("88776655", solicitudCreado.DNI);
            Assert.AreEqual('P', solicitudCreado.Nivel);
            Assert.AreEqual('S', solicitudCreado.grado);
            Assert.AreEqual(fecha.Date, solicitudCreado.FechaSolicitud);
            Assert.AreEqual(fecha.Date, solicitudCreado.FechaVisita);
            Assert.AreEqual("Apoderado", solicitudCreado.NombrePadreApoderado);
            Assert.AreEqual("66778899", solicitudCreado.DNIPadreApoderado);
            Assert.AreEqual("aporderado@correo.com", solicitudCreado.EmailPadreApoderado);
            Assert.AreEqual('P', solicitudCreado.EstadoSolicitud);
        }
        [TestMethod]
        public void TestSolicitudCrearRepetido()
        {
            try
            {
                DateTime fecha = DateTime.Now;
                SolicitudMatriculasClient proxy = new SolicitudMatriculasClient();
                SolicitudMatricula solicitudCreado = proxy.CrearSolicitud(new SolicitudMatricula()
                {
                    NombreAlumno = "Juanito",
                    ApellidosAlumno = "Perez",
                    DNI = "88776655",
                    Nivel = 'P',
                    grado = 'S',
                    FechaSolicitud = fecha,
                    FechaVisita = fecha,
                    NombrePadreApoderado = "Apoderado",
                    DNIPadreApoderado = "66778899",
                    EmailPadreApoderado = "aporderado@correo.com",
                    EstadoSolicitud = 'P'
                });
            }
            catch (FaultException<RepetidoException> error)
            {
                Assert.AreEqual("Error al intentar creacion", error.Reason.ToString());
                Assert.AreEqual("101", error.Detail.Codigo);
                Assert.AreEqual("El alumno ya existe", error.Detail.Descripcion);
            }


        }
        [TestMethod]
        public void TestSolicitudObtener()
        {
            SolicitudMatriculasClient proxy = new SolicitudMatriculasClient();
            SolicitudMatricula solicitud = proxy.ObtenerSolicitud("88776655");
            Assert.AreEqual("Juanito", solicitud.NombreAlumno);
            Assert.AreEqual("Perez", solicitud.ApellidosAlumno);
            Assert.AreEqual("88776655", solicitud.DNI);
            Assert.AreEqual('P', solicitud.Nivel);
            Assert.AreEqual('S', solicitud.grado);
            Assert.AreEqual("Apoderado", solicitud.NombrePadreApoderado);
            Assert.AreEqual("66778899", solicitud.DNIPadreApoderado);
            Assert.AreEqual("aporderado@correo.com", solicitud.EmailPadreApoderado);
            Assert.AreEqual('P', solicitud.EstadoSolicitud);
        }
        [TestMethod]
        public void TestSolicitudModificar()
        {
            DateTime fecha = DateTime.Now;
            SolicitudMatriculasClient proxy = new SolicitudMatriculasClient();
            SolicitudMatricula solicitudModificado = proxy.ModificarSolicitud(new SolicitudMatricula()
            {
                NombreAlumno = "Juanito",
                ApellidosAlumno = "Perez",
                DNI = "88776655",
                Nivel = 'P',
                grado = 'S',
                FechaSolicitud = fecha,
                FechaVisita = fecha,
                NombrePadreApoderado = "Apoderado2",
                DNIPadreApoderado = "66778899",
                EmailPadreApoderado = "apoderado2@correo.com",
                EstadoSolicitud = 'P'
            });
            Assert.AreEqual("Juanito", solicitudModificado.NombreAlumno);
            Assert.AreEqual("Perez", solicitudModificado.ApellidosAlumno);
            Assert.AreEqual("88776655", solicitudModificado.DNI);
            Assert.AreEqual('P', solicitudModificado.Nivel);
            Assert.AreEqual('S', solicitudModificado.grado);
            Assert.AreEqual(fecha.Date, solicitudModificado.FechaSolicitud);
            Assert.AreEqual(fecha.Date, solicitudModificado.FechaVisita);
            Assert.AreEqual("Apoderado2", solicitudModificado.NombrePadreApoderado);
            Assert.AreEqual("66778899", solicitudModificado.DNIPadreApoderado);
            Assert.AreEqual("apoderado2@correo.com", solicitudModificado.EmailPadreApoderado);
            Assert.AreEqual('P', solicitudModificado.EstadoSolicitud);
        }

        [TestMethod]
        public void TestSolicitudEliminar()
        {
            try
            {
                SolicitudMatriculasClient proxy = new SolicitudMatriculasClient();
                proxy.EliminarSolicitud("44332211");
                Assert.IsTrue(true);
            }
            catch (Exception E)
            {
                Assert.IsTrue(false);
            }
        }
        [TestMethod]
        public void TestSolicitudListar()
        {
            SolicitudMatriculasClient proxy = new SolicitudMatriculasClient();
            SolicitudMatricula[] listObtenida = proxy.ListarSolicitud();
            Assert.AreEqual(1, listObtenida.Length);
        }
    }
}
