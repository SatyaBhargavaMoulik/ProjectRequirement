using Microsoft.AspNetCore.Mvc;
using MVC_TDD.Controllers;
using MVC_TDD.Models;

namespace TDDEmpoyeeProject
{
    [TestClass]
    public class EmployeeDataTest
    {
        [TestMethod]
        public void TestMethodEmpData()
        {
            // Arrange
            EmpDetailsController objEmp = new EmpDetailsController();


            // Act
          ViewResult vr =  objEmp.Index() as ViewResult;
          List<Employee> lstEmp = vr.Model as List<Employee>;
          List<Employee> lstEmpInvalidEmpID = lstEmp.Where(eID => eID.EmpID < 0 || eID.EmpID > 100).ToList();
          List<Employee> lstEmpInvalidNames = lstEmp.Where(eName => eName.EmpName.Length < 3 || eName.EmpName.Length > 20).ToList();


              // Assert
            Assert.IsNotNull(lstEmp);
            Assert.IsTrue(lstEmp.Count >= 2);
            Assert.AreEqual(0,lstEmpInvalidEmpID.Count);
            Assert.IsTrue(lstEmpInvalidNames.Count == 0);
        }
    }
}