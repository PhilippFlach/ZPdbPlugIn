using System;

namespace ZPdbPlugIn
{
    internal class MapEntry
    {
        public MapEntry()
        {
        }

        internal MapEntry(long id, int map_id, string address, string description, string pic, string link, string icon, double? lat, double? lng, string anim, string title, int infoopen, string category, int approved, int retina, int type, string did, int sticky, string other_data)
        {
            Id = id;
            Map_id = map_id;
            Address = address ?? throw new ArgumentNullException(nameof(address));
            Description = description ?? throw new ArgumentNullException(nameof(description));
            Pic = pic ?? throw new ArgumentNullException(nameof(pic));
            Link = link ?? throw new ArgumentNullException(nameof(link));
            Icon = icon ?? throw new ArgumentNullException(nameof(icon));
            Lat = lat;
            Lng = lng;
            Anim = anim ?? throw new ArgumentNullException(nameof(anim));
            Title = title ?? throw new ArgumentNullException(nameof(title));
            Infoopen = infoopen;
            Category = category ?? throw new ArgumentNullException(nameof(category));
            Approved = approved;
            Retina = retina;
            Type = type;
            Did = did ?? throw new ArgumentNullException(nameof(did));
            Sticky = sticky;
            Other_data = other_data ?? throw new ArgumentNullException(nameof(other_data));
        }

        internal long Id { get; set; }
        internal int Map_id { get; set; }
        internal string Address { get; set; }
        internal string Description { get; set; }
        internal string Pic { get; set; }
        internal string Link { get; set; }
        internal string Icon { get; set; }
        internal double? Lat { get; set; }
        internal double? Lng { get; set; }
        internal string Anim { get; set; }

        internal string Title { get; set; }
        internal int Infoopen { get; set; }
        internal string Category { get; set; }
        internal int Approved { get; set; }
        internal int Retina { get; set; }
        internal int Type { get; set; }

        internal string Did { get; set; }
        internal int Sticky { get; set; }
        internal string Other_data { get; set; }
  

    }
}
