using HttpExerciseLib.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace HttpExerciseLib.Service

{
    public class HttpService
    {
        static readonly HttpClient http = new HttpClient();
        static readonly string URL = "https://randomuser.me/api/";
        public async Task<List<User>> GetUsers()
        {
            List<User> users = null;
            HttpResponseMessage message = await http.GetAsync(URL);
            if(message.IsSuccessStatusCode)
            {
                UserApiResponse response = await message.Content.ReadAsAsync<UserApiResponse>();
                users = response.results;
            }
            return users;
        }
    }
}
