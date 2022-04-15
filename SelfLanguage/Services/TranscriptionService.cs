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
    public class TranscriptionService : ITranscriptionService
    {
        public async Task<HttpStatusCode> CallTranscriptionApi(Transcription transcription)
        {
            string json = JsonConvert.SerializeObject(transcription);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var httpClient = new HttpClient();

            HttpResponseMessage response = await httpClient.PostAsync("https://localhost:5002/transcription/post", content);

            return response.StatusCode;
        }
    }
}
