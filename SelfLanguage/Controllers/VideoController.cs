/*
 * By: voidotexe
 * https://www.github.com/voidotexe
*/

using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SelfLanguage.Models;
using SelfLanguage.Services;
using System.Threading.Tasks;

namespace SelfLanguage.Controllers
{
    public class VideoController : Controller
    {
        private readonly ILogger<VideoController> _logger;
        private readonly IVideoService _videoService;
        private readonly UserManager<User> _userManager;

        public VideoController(ILogger<VideoController> logger, IVideoService videoService, UserManager<User> userManager)
        {
            _logger = logger;
            _videoService = videoService;
            _userManager = userManager;
        }

        [HttpGet]
        public async Task<IActionResult> Index(string link)
        {
            await _videoService.GetSingleVideoApi(link);

            await _videoService.GetCheckUserHasSingleFavoriteVideoApi(_videoService.Video.VideoId, _userManager.GetUserId(User));

            return View(_videoService.Video);
        }
    }
}
