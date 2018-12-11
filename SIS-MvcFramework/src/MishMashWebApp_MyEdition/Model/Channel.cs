using System.Collections.Generic;

namespace MishMashWebApp_MyEdition.Model
{
    public class Channel
    {
        public Channel()
        {
            this.Tags = new HashSet<ChannelsTags>();
            this.Followers = new HashSet<UsersChannels>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public ChannelType Type { get; set; }

        public ICollection<ChannelsTags> Tags { get; set; }

        public virtual ICollection<UsersChannels> Followers { get; set; }
    }
}