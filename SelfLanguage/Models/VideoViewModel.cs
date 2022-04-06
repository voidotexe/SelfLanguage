﻿/*
 * By: voidotexe
 * https://www.github.com/voidotexe
*/

using System;
using System.ComponentModel.DataAnnotations;

namespace SelfLanguage.Models
{
    public class VideoViewModel
    {
		// Video

        [Required]
        [MaxLength(100)]
        public string Title { get; set; }

        [Required]
        [MaxLength(300)]
        public string Link { get; set; }

        [Required]
		[MaxLength(2)]
        public string VideoLanguage { get; set; }

		[Required]
		[MaxLength(13)]
        public string Difficulty { get; set; }

		// Transcription

		[Required]
		public string TranscriptionContent { get; set; }

		// Subtitle

		[Required]
		public string SubtitleContent { get; set; }

		[Required]
		public string SubtitleLanguage { get; set; }

		// All

		public string CreatedBy { get; set; }
		public DateTime CreatedAt { get; set; }
	}
}
