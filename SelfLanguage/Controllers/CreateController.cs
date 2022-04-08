/*
 * By: voidotexe
 * https://www.github.com/voidotexe
*/

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SelfLanguage.Models;
using SelfLanguage.Services;
using System;
using System.Threading.Tasks;

namespace SelfLanguage.Controllers
{
    [Authorize]
    public class CreateController : Controller
    {
        private readonly UserManager<User> _userManager;

        private readonly IVideoService _videoService;
        private readonly ITranscriptionService _transcriptionService;
        private readonly ISubtitleService _subtitleService;

        public CreateController(UserManager<User> userManager, IVideoService videoService, ITranscriptionService transcriptionService, ISubtitleService subtitleService)
        {
            _userManager = userManager;
            
            _videoService = videoService;
            _transcriptionService = transcriptionService;
            _subtitleService = subtitleService;
        }

        [HttpGet]
        public IActionResult Video()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Video(VideoViewModel videoViewModel)
        {
            videoViewModel.CreatedBy = _userManager.GetUserId(User);
            videoViewModel.CreatedAt = DateTime.Now;

            var video = new Video(videoViewModel.Title, videoViewModel.Link, videoViewModel.VideoLanguage, videoViewModel.Difficulty, videoViewModel.CreatedBy, videoViewModel.CreatedAt);
            string videoResponse = await _videoService.PostVideoApi(video);
            int videoId = Convert.ToInt32(videoResponse);

            var transcription = new Transcription(videoId, videoViewModel.TranscriptionContent, videoViewModel.CreatedBy, videoViewModel.CreatedAt);
            await _transcriptionService.CallTranscriptionApi(transcription);

            var subtitle = new Subtitle(videoId, videoViewModel.SubtitleContent, videoViewModel.SubtitleLanguage, videoViewModel.CreatedBy, videoViewModel.CreatedAt);
            await _subtitleService.CallSubtitleApi(subtitle);

            return View(videoViewModel);
        }
    }
}
