using NUnit.Framework;
using Management2;
using Management2.Models;
using Management2.Processor;
using Management2.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;


namespace Management2TestProject.Test
{
    [TestFixture]
    public class AddDocEntityShould
    {
        [Test]
        public void CreateNew_AddDoc_VieConstructor()
        {
            //Arrange
            string docType = "Nik";
            string docName = "Neurologist";
            string gender = "Male";
            string contactNumber = "987654321";
            string emailId = "nik@gmail.com";
            string password = "123";


            //Act
            Management2.Models.Doctor test=new Management2.Models.Doctor();
            test.DocType = docType;
            test.DocName = docName;
            test.gender = gender;
            test.ContactNumber = contactNumber;
            test.EmailId = emailId;
            test.Password = password;
            
            //Assert
            Assert.That(test, Is.Not.Null);
            Assert.That(test, Is.InstanceOf<Management2.Models.Doctor>());
            Assert.That(test.DocType, Is.EqualTo(docType));
            Assert.That(test.DocName, Is.EqualTo(docName));
            Assert.That(test.gender, Is.EqualTo(gender));
            Assert.That(test.ContactNumber, Is.EqualTo(contactNumber));
            Assert.That(test.EmailId, Is.EqualTo(emailId));
            Assert.That(test.Password, Is.EqualTo(password));

        }
    }
}