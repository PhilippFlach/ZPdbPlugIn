using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using Newtonsoft.Json;

namespace ZPdbPlugIn
{
    /// <summary>    
    /// Manages a collection of map entries that can be serialized to JSON <see cref="MapEntryManager"/>   
    /// </summary>

    [ComVisible(true)]
    [ClassInterface(ClassInterfaceType.AutoDual)]
    public class MapEntryManager
    {
        readonly List<MapEntry> _mapEntries = new List<MapEntry>();

        MapEntry _currentMapEntry;

        public MapEntryManager()
        {
            _currentMapEntry = new MapEntry();

        }

        /// <summary>
        /// Add current map entry to the collection
        /// </summary>
        /// <returns>Current number of entries in the list</returns>
        [ComVisible(true)]
        public string GetCurrentMarkersJSON()
        {
            string json = JsonConvert.SerializeObject(_mapEntries, Formatting.Indented);
            return json;
        }

        /// <summary>
        /// Add current map entry to the collection
        /// </summary>
        /// <returns>Current number of entries in the list</returns>
        [ComVisible(true)]
        public int SaveMapEntry()
        {
            _mapEntries.Add(_currentMapEntry);
            _currentMapEntry = new MapEntry();
            return _mapEntries.Count;
        }

        [ComVisible(true)]
        public void SetID(long id) => _currentMapEntry.Id = id;

        [ComVisible(true)]
        public void SetMap_id(int map_id) => _currentMapEntry.Map_id = map_id;
        [ComVisible(true)] 
        public void SetAddress(string address) => _currentMapEntry.Address = address;

        [ComVisible(true)]
        public void SetDescription(string description) => _currentMapEntry.Description = description;

        [ComVisible(true)]
        public void SetLink(string link) => _currentMapEntry.Link = link;

        [ComVisible(true)] 
        public void SetLat(string lat) => _currentMapEntry.Lat = lat;

        [ComVisible(true)]
        public void SetLng(string lng) => _currentMapEntry.Lng = lng;

        [ComVisible(true)]
        public void SetTitle(string title) => _currentMapEntry.Title = title;

    }
}
