using Prototype.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VkNet;
using VkNet.Enums.Filters;

namespace Prototype.SocialNetwork
{
    public class VK : ISocialNetwork
    {
        private VkApi Vk;
        private List<string> Query;
        private string NameSocialNetwork;

        public VK()
        {
            Query = new List<string>();
            Vk = new VkApi();
            NameSocialNetwork = "Вконтакте";
        }

        public bool IsAuthorized
        {
            get
            {
                return Vk.IsAuthorized;
            }
        }

        public string Name
        {
            get
            {
                return NameSocialNetwork;
            }
        }

        public bool Autorization()
        {
            try
            {
                Vk.Authorize(new ApiAuthParams()
                {
                    ApplicationId = 5913355,
                    Login = "79655776464",
                    Password = "Prototype8080",
                    Settings = Settings.All
                });
                return true;
            }
            catch
            {
                return false;
            }
        }

        public void AddQuery(string query)
        {
            Query.Add(query);
        }

        public void RemoveQuery(string query)
        {
            Query.Remove(query);
        }

        public List<Review> GetComments(DateTime dateStart, DateTime dateFinish, bool discussions, bool topics)
        {
            List<Review> v = new List<Review>();
            Review r = new Review("123", "123.ru");
            v.Add(r);
            return v;
        }
    }
}
