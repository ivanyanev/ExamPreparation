using MishMashWebApp_MyEdition.Model;
using System.Collections.Generic;

namespace MishMashWebApp_MyEdition.ViewModels.Channels
{
    public class ChannelViewModel
    {
        public string Name { get; set; }

        public ChannelType Type { get; set; }

        public string Description { get; set; }

        public IEnumerable<string> Tags { get; set; }

        public string TagsAsString => string.Join(", ", this.Tags);

        public int FollowersCount { get; set; }
    }
}
