using Flurl.Http;
using System.Threading.Tasks;
using MeetAndGo.Model;
using MeetAndGo.WinUI.Properties;

namespace MeetAndGo.WinUI
{
    public class ApiService
    {
        private string _route = null;
        public string endpoint = $"{Settings.Default.ApiURL}";

        public ApiService(string route)
        {
            _route = route;
        }

        public static string UserName { get; set; }
        public static string Password { get; set; }

        public async Task<T> GetAll<T>(object request = null)
        {
            var url = $"{endpoint}/{_route}";

            if (request != null)
            {
                url += "?";
                url += await request.ToQueryString();
            }

            var result = await url.WithBasicAuth(UserName, Password).GetJsonAsync<T>();
            return result;
        }

        public async Task<T> GetById<T>(object id)
        {
            var url = $"{endpoint}/{_route}/{id}";
            var result = await url.WithBasicAuth(UserName, Password).GetJsonAsync<T>();

            return result;
        }

        public async Task<T> Insert<T>(object request)
        {
            var url = $"{endpoint}/{_route}";
            var result = await url.WithBasicAuth(UserName, Password).PostJsonAsync(request).ReceiveJson<T>();

            return result;
        }

        public async Task<T> Update<T>(object id, object request)
        {
            var url = $"{endpoint}/{_route}/{id}";
            var result = await url.WithBasicAuth(UserName, Password).PutJsonAsync(request).ReceiveJson<T>();

            return result;
        }

        public async Task<T> Delete<T>(int id)
        {
            var url = $"{endpoint}/{_route}/{id}";
            var result = await url.WithBasicAuth(UserName, Password).DeleteAsync().ReceiveJson<T>();

            return result;
        }

        public async Task<T> GetUserAccountByUsername<T>(string username)
        {
            var url = $"{endpoint}/{_route}/Username/{username}";
            var result = await url.WithBasicAuth(UserName, Password).GetJsonAsync<T>();

            return result;
        }

        public async Task<T> GetRoleByUserAccountId<T>(int userAccountId)
        {
            var url = $"{endpoint}/{_route}/UserAccount/{userAccountId}";
            var result = await url.WithBasicAuth(UserName, Password).GetJsonAsync<T>();

            return result;
        }

        public async Task<T> GetAllRentedBuildings<T>()
        {
            var url = $"{endpoint}/{_route}/all";
            var result = await url.WithBasicAuth(UserName, Password).GetJsonAsync<T>();

            return result;
        }


        public async Task<T> GetAllRentedOffices<T>()
        {
            var url = $"{endpoint}/{_route}/all";
            var result = await url.WithBasicAuth(UserName, Password).GetJsonAsync<T>();

            return result;
        }
    }
}