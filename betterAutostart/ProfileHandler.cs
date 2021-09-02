using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace betterAutostart
{
    class ProfileHandler
    {
        List<Profile> profileList;

        public ProfileHandler()
        {
            this.profileList = new List<Profile>();
        }

        public void addNewProfile()
        {
            Profile tempProfile = new Profile();
            profileList.Add(tempProfile);
        }

        public void AddExistingProfile(Profile p)
        {
            this.profileList.Add(p);
        }

        public List<Profile> GetProfiles()
        {
            return this.profileList;
        }
    }
}
