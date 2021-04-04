using System;

namespace ZPdbPlugIn
{
    internal class MapEntry
    {
        public MapEntry()
        {
        }

        internal MapEntry(long id, int map_id, string address, string description, string pic, string link, string icon, string lat, string lng, string anim, string title, int infoopen, string category, int approved, int retina, int type, string did, int sticky, string other_data)
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

        public long Id { get; set; }
        public int Map_id { get; set; } = 1;
        public string Address { get; set; }
        public string Description { get; set; } = "";
        public string Pic { get; set; } = "";
        public string Link { get; set; } = "";
        public string Icon { get; set; } = "";
        public string Lat { get; set; }
        public string Lng { get; set; }
        public string Anim { get; set; } = "0";

        public string Title { get; set; }
        public int Infoopen { get; set; } = 0;
        public string Category { get; set; } = "";
        public int Approved { get; set; } = 1;
        public int Retina { get; set; } = 1;
        public int Type { get; set; } = 0;

        public string Did { get; set; } = "";
        public int Sticky { get; set; } = 0;
        public string Other_data { get; set; } = "";
  

    }
}
