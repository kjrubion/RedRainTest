using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RedRain.Domain;

namespace RedRain.Tests.EntityTests
{
    [TestClass]
    public class ModelEntityTest
    {
        private const string type = "dev";
        private const string contentDesc = "test description";
        private DateTime created = DateTime.Today;

        /// <summary>Given with parameter properties must change.</summary>
        [TestMethod]
        public void Given_with_parameter_properties_must_change()
        {
            var entity = new Entity(type,contentDesc,created);
            Assert.AreEqual(type, entity.Type);
            Assert.AreEqual(contentDesc, entity.ContentDesc);
            Assert.AreEqual(created, entity.Created);
        }

        /// <summary>Givens a empty properties should be empty.</summary>
        [TestMethod]
        public void Given_a_empty_properties_should_be_empty()
        {
            var entity = new Entity();
            Assert.IsNull(entity.Type);
            Assert.IsNull(entity.ContentDesc);
            Assert.IsNull(entity.Created);
        }
    }
}
