using System.Collections.Generic;

namespace MishMashWebApp_MyEdition.Model
{
    public class User
    {
        public User()
        {
            this.Chanels = new HashSet<UsersChannels>();
        }

        public int Id { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public string Email { get; set; }

        public virtual ICollection<UsersChannels> Chanels { get; set; }

        public Role Role { get; set; }
    }
}
