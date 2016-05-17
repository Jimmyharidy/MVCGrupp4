using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NUnit.Framework;

namespace MVCTestProject
{
   [TestFixture]
    public class Test
    {
       [Test]
       public void AddCorrectCalculation()
       {
           // Arange
          
           // Act
           var actual =Class1.Add(3, 2);
           // Assert
           Assert.AreEqual(expected, actual);
       }
    }
}
