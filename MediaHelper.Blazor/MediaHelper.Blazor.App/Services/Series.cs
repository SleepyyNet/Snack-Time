using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Blazor;

namespace MediaHelper.Blazor.App.Services
{
    public class Series
    {
        private readonly HttpClient _client;

        public Series(HttpClient client)
        {
            _client = client;
        }

        public async Task<SonarrSharp.Models.Series[]> GetAll()
        {
            return await _client.GetJsonAsync<SonarrSharp.Models.Series[]>("Series");
        }
    }
}