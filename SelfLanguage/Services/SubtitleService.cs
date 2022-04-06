/*
 * By: voidotexe
 * https://www.github.com/voidotexe
*/

using Newtonsoft.Json;
using SelfLanguage.Models;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace SelfLanguage.Services
{
    public class SubtitleService : ISubtitleService
    {
        public async Task<HttpStatusCode> CallSubtitleApi(Subtitle subtitle)
        {
            string json = JsonConvert.SerializeObject(subtitle);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var httpClient = new HttpClient();

            HttpResponseMessage response = await httpClient.PostAsync("https://localhost:44379/subtitle/post", content);

            return response.StatusCode;
        }
    }
}
