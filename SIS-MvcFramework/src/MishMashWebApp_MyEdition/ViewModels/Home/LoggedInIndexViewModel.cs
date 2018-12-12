using MishMashWebApp_MyEdition.Controllers;
using MishMashWebApp_MyEdition.ViewModels.Channels;
using System.Collections.Generic;

namespace MishMashWebApp_MyEdition.ViewModels.Home
{
    public class LoggedInIndexViewModel : BaseController
    {
        public string UserRole { get; set; }

        public IEnumerable<BaseChannelViewModel> YourChannels { get; set; }

        public IEnumerable<BaseChannelViewModel> SuggestedChannels { get; set; }

        public IEnumerable<BaseChannelViewModel> SeeOtherChannels { get; set; }
    }
}
