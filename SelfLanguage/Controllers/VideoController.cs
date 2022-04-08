/*
 * By: voidotexe
 * https://www.github.com/voidotexe
*/

using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SelfLanguage.Models;
using SelfLanguage.Services;
using System.Diagnostics;
using System.Threading.Tasks;

namespace SelfLanguage.Controllers
{
    public class VideoController : Controller
    {
        private readonly ILogger<VideoController> _logger;
        private readonly IVideoService _videoService;

        public VideoController(ILogger<VideoController> logger, IVideoService videoService)
        {
            _logger = logger;
            _videoService = videoService;
        }

        [HttpGet]
        public async Task<IActionResult> Index(string link)
        {
            await _videoService.GetSingleVideoApi(link);

            return View(_videoService.Video);
        }
    }
}
