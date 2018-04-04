using Microsoft.VisualStudio.TestTools.UnitTesting;
using Student.Business.Logic;
using Student.Common.Logic.FileUtils;
using Student.Common.Logic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student.Business.Logic.Tests
{
    [TestClass()]
    public class StudentBLTests
    {
        private readonly StudentBL studentBL = new StudentBL();

        [DataRow(TypeFormat.Txt)]
        [DataRow(TypeFormat.Json)]
        [DataRow(TypeFormat.Xml)]
        [TestMethod]
        public void BlAddTest( TypeFormat typeFormat)
        {
            Alumno student = new Alumno(Guid.NewGuid(), 1, "45687654h", "Daniel", "Madrigal", 28, "24/06/1990", "05/09/2017");
            var result =studentBL.Add(student,typeFormat);
            Assert.IsTrue(student.Equals(result));
        }

    }
}