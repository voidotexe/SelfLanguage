/*
 * By: voidotexe
 * https://www.github.com/voidotexe
*/

using Newtonsoft.Json;
using SelfLanguage.Models;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace SelfLanguage.Services
{
    public class FavoriteVideoService : IFavoriteVideoService
    {
        public IEnumerable<FavoriteVideoViewModel> FavoriteVideos { get; set; }

        public async Task ReadByUserIdApi(string userId)
        {
            var client = new HttpClient();

            HttpResponseMessage response = await client.GetAsync($"https://localhost:5001/favoritevideo/get/{userId}");
            string json = await response.Content.ReadAsStringAsync();

            FavoriteVideos = JsonConvert.DeserializeObject<IEnumerable<FavoriteVideoViewModel>>(json);
        }
    }
}
