/*
 * By: voidotexe
 * https://www.github.com/voidotexe
*/

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SelfLanguage.Models;
using SelfLanguage.Services;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;

namespace SelfLanguage.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IVideoService _videoService;

        public HomeController(ILogger<HomeController> logger, IVideoService videoService)
        {
            _logger = logger;
            _videoService = videoService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            await _videoService.GetVideoApi();

            return View(_videoService.Videos);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
