﻿using MishMashWebApp_MyEdition.Model;

namespace MishMashWebApp_MyEdition.ViewModels.Channels
{
    public class BaseChannelViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public ChannelType Type { get; set; }

        public int FollowersCount { get; set; }
    }
}