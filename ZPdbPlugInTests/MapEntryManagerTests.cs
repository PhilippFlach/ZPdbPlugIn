using NUnit.Framework;
using ZPdbPlugIn;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace ZPdbPlugInTests
{
    [TestFixture()]
    public class MapEntryManagerTests
    {
        [Test()]
        public void GetCurrentMarkersJSONTest()
        {
            // Arrange
            using (StreamReader file = File.OpenText(@"c:\movie.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                List<MapEntry> expected = (List<MapEntry>)serializer.Deserialize(file, typeof(List<MapEntry>));
            }

            // Act

            // Assert
            Assert.Fail();
        }
    }
}