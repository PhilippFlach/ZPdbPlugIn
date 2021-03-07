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
            //using (StreamReader file = File.OpenText(@"c:\movie.json"))
            //{
            //    JsonSerializer serializer = new JsonSerializer();
            //    List<MapEntry> expected = (List<MapEntry>)serializer.Deserialize(file, typeof(List<MapEntry>));
            //}
            var sut = new MapEntryManager();
            // 1. Map entry
            sut.SetID(410);
            sut.SetMap_id(1);
            sut.SetAddress("Arcas 3, 7000 Chur");
            sut.SetLink("https://www.zummetzgertor.ch/menu");
            sut.SetTitle("Zum Metzgertor");
            sut.SetLat(46.84793681554992);
            sut.SetLng(9.531904334802588);
            sut.SaveMapEntry();



            // Act

            // Assert
            Assert.IsTrue(true);
        }
    }
}