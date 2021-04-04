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

            var sut = new MapEntryManager();
            // 1. Map entry
            sut.SetID(490);
            sut.SetMap_id(1);
            sut.SetAddress("Arcas 3, 7000 Chur");
            sut.SetLink("https://www.zummetzgertor.ch/menu");
            sut.SetTitle("Zum Metzgertor");
            sut.SetLat("46.84793681554992");
            sut.SetLng("9.531904334802588");
            sut.SaveMapEntry();

            // 2. Map entry
            sut.SetID(491);
            sut.SetMap_id(1);
            sut.SetAddress("Juchs, 7013 Domat/Ems");
            sut.SetLink(null);
            sut.SetTitle("Restaurant Juchs");
            sut.SetLat("46.82170488691142");
            sut.SetLng("9.487039303937985");
            sut.SaveMapEntry();


            // 3. Map entry
            sut.SetID(491);
            sut.SetMap_id(1);
            sut.SetAddress("Gassa Sutò 61, 7013 Domat/Ems");
            sut.SetLink(null);
            sut.SetTitle("Restaurant Term Bel");
            sut.SetLat(null);
            sut.SetLng(null);
            sut.SaveMapEntry();


            // Act
            var jsonstringactual = sut.GetCurrentMarkersJSON();
            List<MapEntry> actual = JsonConvert.DeserializeObject<List<MapEntry>>(jsonstringactual);

            // Assert
            Assert.That(actual.Count, Is.EqualTo(3));
        }
    }
}