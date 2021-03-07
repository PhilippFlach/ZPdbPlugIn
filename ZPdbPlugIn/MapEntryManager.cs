using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace ZPdbPlugIn
{
    /// <summary>    
    /// Manages a collection of map entries that can be serialized to JSON <see cref="MapEntryManager"/>   
    /// </summary>

    [ComVisible(true)]
    [ClassInterface(ClassInterfaceType.AutoDual)]
    public class MapEntryManager
    {
        List<MapEntry> _mapEntries = new List<MapEntry>();

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
        public int SaveMapEntry()
        {
            _mapEntries.Add(_currentMapEntry);
            _currentMapEntry = new MapEntry();
            return _mapEntries.Count;
        }

    }
}
