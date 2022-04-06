/*
 * By: voidotexe
 * https://www.github.com/voidotexe
*/

using System;

namespace SelfLanguage.Models
{
    public class Video
    {
        public string Title { get; set; }
        public string Link { get; set; }
        public string Language { get; set; }
        public string Difficulty { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }

        public Video(string title, string link, string videoLanguage, string difficulty, string createdBy, DateTime createdAt)
        {
            Title = title;
            Link = link;
            Language = videoLanguage;
            Difficulty = difficulty;
            CreatedBy = createdBy;
            CreatedAt = createdAt;
        }
    }
}
