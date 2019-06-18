using Microsoft.VisualStudio.TestTools.UnitTesting;
using Store.Domain.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test {
    [TestClass]
    public class RepositoryTest : BaseTest {
        //gauketot DI repositorebs
        [TestMethod]
        public void UserRepositoryTest() {
            int result = 2 + 2;
            Assert.AreEqual(4, result, "Arithmetic Operation Failed.");
            result = 2 + 2;
            Assert.AreEqual(5, result, "Arithmetic Operation Failed.");
        }
        
    }
}
