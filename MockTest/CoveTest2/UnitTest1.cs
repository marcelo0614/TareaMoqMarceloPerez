using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Core;
using Moq;
using System.Collections.Generic;

namespace CoveTest2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Validate_test()
        {
            Mock<IServicio> mockServicio = new Mock<IServicio>();
            mockServicio.Setup(x => x.Validar(It.IsAny<string>()));
            Admin admin = new Admin("aa", "11", mockServicio.Object);
            Assert.IsNotNull(admin);
        }

        [TestMethod]
        public void GetAlumnosCount_test()
        {
            List<Alumno> ListaAlumnos = new List<Alumno>();
            ListaAlumnos.Add(new Alumno() { CI = 1234, Nombre = "Maria Lopez 2" });
            ListaAlumnos.Add(new Alumno() { CI = 5678, Nombre = "Juan Rivera2" });
            Mock<IServicio> mockServicio = new Mock<IServicio>();
            mockServicio.Setup(g => g.GetAlumnos()).Returns(ListaAlumnos);
            Admin admin = new Admin("aa", "11", mockServicio.Object);
            Assert.AreEqual(2, admin.GetNotas().Count);
        }

        [TestMethod]
        public void GetNotas_test()
        {
            List<Alumno> ListaAlumnos = new List<Alumno>();
            ListaAlumnos.Add(new Alumno() { CI = 1234, Nombre = "Maria Lopez 3" });
            ListaAlumnos.Add(new Alumno() { CI = 5678, Nombre = "Juan Rivera 3" });
            Mock<IServicio> mockServicio = new Mock<IServicio>();
            mockServicio.Setup(g => g.GetAlumnos()).Returns(ListaAlumnos);
            mockServicio.Setup(n => n.GetNota(It.IsAny<int>())).Returns(50);
            Admin admin = new Admin("aa", "11", mockServicio.Object);
            Assert.AreEqual(2, admin.GetNotas().Count);
            Assert.AreEqual(50, admin.GetNotas()[0].Nota);
        }



    }
}
