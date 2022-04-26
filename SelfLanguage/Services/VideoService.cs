﻿/*
 * By: voidotexe
 * https://www.github.com/voidotexe
*/

using Newtonsoft.Json;
using SelfLanguage.Models;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace SelfLanguage.Services
{
    public class VideoService : IVideoService
    {
        public IEnumerable<VideoViewModel> Videos { get; set; }
        public VideoViewModel Video { get; set; }

        public async Task<string> PostVideoApi(Video video)
        {
            string json = JsonConvert.SerializeObject(video);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var httpClient = new HttpClient();

            HttpResponseMessage response = await httpClient.PostAsync("https://localhost:5002/video/post", content);

            return await response.Content.ReadAsStringAsync();
        }

        public async Task GetVideoApi()
        {
            var httpClient = new HttpClient();

            HttpResponseMessage response = await httpClient.GetAsync("https://localhost:5002/video/get");

            string json = await response.Content.ReadAsStringAsync();

            Videos = JsonConvert.DeserializeObject<IEnumerable<VideoViewModel>>(json);

            foreach (var video in Videos)
            {
                var youtubeVideoId = video.Link.Replace("https://www.youtube.com/watch?v=", "");

                video.VideoImage = $"https://img.youtube.com/vi/{youtubeVideoId}/hqdefault.jpg";
            }
        }

        public async Task GetSingleVideoApi(string link)
        {
            var httpClient = new HttpClient();

            HttpResponseMessage response = await httpClient.GetAsync($"https://localhost:5002/video/get/bylink/{link}");

            string json = await response.Content.ReadAsStringAsync();

            Video = JsonConvert.DeserializeObject<VideoViewModel>(json);

            var youtubeVideoId = Video.Link.Replace("https://www.youtube.com/watch?v=", "");

            Video.YoutubeEmbed = $"https://www.youtube.com/embed/{youtubeVideoId}";
            Video.VideoImage = $"https://img.youtube.com/vi/{youtubeVideoId}/hqdefault.jpg";
        }

        public async Task GetCheckUserHasSingleFavoriteVideoApi(int videoId, string userId)
        {
            var httpClient = new HttpClient();

            HttpResponseMessage response = await httpClient.GetAsync($"https://localhost:5001/favoritevideo/get/{videoId}/{userId}");

            string result = await response.Content.ReadAsStringAsync();

            Video.IsFavorite = result;
        }
    }
}
