using System.Collections.Generic;

namespace MishMashWebApp_MyEdition.Model
{
    public class Tag
    {
        public Tag()
        {
            this.Channels = new HashSet<ChannelsTags>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<ChannelsTags> Channels { get; set; }
    }
}
