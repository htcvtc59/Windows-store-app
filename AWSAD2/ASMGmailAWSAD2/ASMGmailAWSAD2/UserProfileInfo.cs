using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace ASMGmailAWSAD2
{
    public class UserProfileInfo
    {
        public async static Task<UserProfile> getProfile(string idToken)
        {
            string requestUri = "https://www.googleapis.com/oauth2/v3/tokeninfo?id_token=" + idToken;
            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync(requestUri);
            var profile = await response.Content.ReadAsStringAsync();
            UserProfile userProfile = new UserProfile();
            MemoryStream ms = new MemoryStream(Encoding.UTF8.GetBytes(profile));
            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(UserProfile));
            userProfile = serializer.ReadObject(ms) as UserProfile;
            return userProfile;
        }

        [DataContract]
        public class UserProfile
        {
            [DataMember]
            public string sub { get; set; }
            [DataMember]
            public string email { get; set; }
            [DataMember]
            public string name { get; set; }
            [DataMember]
            public string picture { get; set; }
        }

    }
}
