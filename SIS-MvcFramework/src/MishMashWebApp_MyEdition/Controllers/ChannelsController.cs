using MishMashWebApp_MyEdition.ViewModels.Channels;
using SIS.HTTP.Responses;
using SIS.MvcFramework;
using System.Linq;

namespace MishMashWebApp_MyEdition.Controllers
{
    public class ChannelsController : BaseController
    {
        [HttpGet("/Channels/Details")]
        public IHttpResponse Details(int id)
        {
            if (!this.User.IsLoggedIn)
            {
                return this.Redirect("/Users/Login");
            }

            var channelViewModel = this.Db.Channels.Where(x => x.Id == id)
                .Select(x => new ChannelViewModel
                {
                    Type = x.Type,
                    Name = x.Name,
                    Tags = x.Tags.Select(t => t.Tag.Name),
                    Description = x.Description,
                    FollowersCount = x.Followers.Count()
                }).FirstOrDefault();

            return this.View("Channels/Details", channelViewModel);
        }

        [HttpGet("/Channels/Followed")]
        public IHttpResponse Followed()
        {
            if (!this.User.IsLoggedIn)
            {
                return this.Redirect("/Users/Login");
            }

            var followedChannels = this.Db.Channels
                .Where(x => x.Followers.Any(f => f.User.Username == this.User.Username))
                .Select(x => new BaseChannelViewModel
                {
                    Id = x.Id,
                    Type = x.Type,
                    Name = x.Name,
                    FollowersCount = x.Followers.Count(),
                }).ToList();

            var viewModel = new FollowedChannelsViewModel
            {
                FollowedChannels = followedChannels
            };

            return this.View("Channels/Followed", viewModel);
        }

        [HttpGet("/Channels/Follow")]
        public IHttpResponse Follow(int id)
        {
            var user = this.Db.Users.FirstOrDefault(x => x.Username == this.User.Username);

            if (user == null)
            {
                return this.Redirect("/Users/Login");
            }

            if (!this.Db.UsersChannels.Any(x => x.UserId == user.Id && x.ChannelId == id))
            {
                this.Db.UsersChannels.Add(new UsersChannels
                {
                    ChannelId = id,
                    UserId = user.Id
                });

                this.Db.SaveChanges();
            }

            return this.Redirect("/Channels/Followed");
        }

        [HttpGet("/Channels/Unfollow")]
        public IHttpResponse Unfollow(int id)
        {
            var user = this.Db.Users.FirstOrDefault(x => x.Username == this.User.Username);

            if (user == null)
            {
                return this.Redirect("/Users/Login");
            }

            var userInChannel = this.Db.UsersChannels.FirstOrDefault(x => x.UserId == user.Id && x.ChannelId == id);

            if (userInChannel != null)
            {
                this.Db.UsersChannels.Remove(userInChannel);
                this.Db.SaveChanges();
            }

            return this.Redirect("/Channels/Followed");
        }
    }
}
