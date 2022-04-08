/*
 * By: voidotexe
 * https://www.github.com/voidotexe
*/

using SelfLanguage.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SelfLanguage.Services
{
    public interface IVideoService
    {
        IEnumerable<VideoViewModel> Videos { get; set; }
        VideoViewModel Video { get; set; }
        Task<string> PostVideoApi(Video video);
        Task GetVideoApi();
        Task GetSingleVideoApi(string link);
    }
}
