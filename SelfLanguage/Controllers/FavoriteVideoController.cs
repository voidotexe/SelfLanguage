/*
 * By: voidotexe
 * https://www.github.com/voidotexe
*/

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SelfLanguage.Models;
using SelfLanguage.Services;
using System.Threading.Tasks;

namespace SelfLanguage.Controllers
{
    [Authorize]
    public class FavoriteVideoController : Controller
    {
        private readonly ILogger<FavoriteVideoController> _logger;
        private readonly IFavoriteVideoService _favoriteVideoService;
        private readonly UserManager<User> _userManager;

        public FavoriteVideoController(ILogger<FavoriteVideoController> logger, IFavoriteVideoService favoriteVideoService, UserManager<User> userManager)
        {
            _logger = logger;
            _favoriteVideoService = favoriteVideoService;
            _userManager = userManager;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            await _favoriteVideoService.ReadByUserIdApi(_userManager.GetUserId(User));

            return View(_favoriteVideoService.FavoriteVideos);
        }
    }
}
