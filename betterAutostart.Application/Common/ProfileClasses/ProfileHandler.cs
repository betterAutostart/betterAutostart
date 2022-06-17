using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;   

namespace betterAutostart.Application.Common.ProfileClasses
{
    class ProfileHandler
    {
        private List<Profile> profileList;

        /// <summary>
        /// Instantiate ProfileHandler
        /// </summary>
        public ProfileHandler()
        {
            this.profileList = new List<Profile>();
        }

        /// <summary>
        /// Add new blank profile
        /// </summary>
        public void AddNewProfile()
        {
            Profile tempProfile = new Profile();
            profileList.Add(tempProfile);
        }

        /// <summary>
        /// Add an already existing project
        /// </summary>
        /// <param name="p">Existing Profile to add</param>
        public void AddExistingProfile(Profile p)
        {
            this.profileList.Add(p);
        }

        /// <summary>
        /// Deletes a existing profile
        /// </summary>
        /// <param name="p">Profile to delete</param>
        public void DeleteProfile(Profile p)
        {
            this.profileList = this.profileList.Where(val => val != p).ToList();
            Config.SaveSystem.DeleteProfile(p, p.Name);
        }

        /// <summary>
        /// Get all profiles
        /// </summary>
        /// <returns></returns>
        public List<Profile> GetProfiles()
        {
            return this.profileList;
        }
    }
}
