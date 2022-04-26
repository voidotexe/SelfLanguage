/*
 * By: voidotexe
 * https://www.github.com/voidotexe
*/

using System;

namespace SelfLanguage.Models
{
    public class FavoriteVideoViewModel
    {
        public string Title { get; set; }
        public string Link { get; set; }
        public string Language { get; set; }
		public string Difficulty { get; set; }
        public DateTime CreatedAt { get; set; }
	}
}
