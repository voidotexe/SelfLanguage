/*
 * By: voidotexe
 * https://www.github.com/voidotexe
*/

using System;

namespace SelfLanguage.Models
{
    public class Subtitle
    {
        public int VideoId { get; set; }
        public string Content { get; set; }
        public string Language { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }

        public Subtitle(int videoId, string content, string language, string createdBy, DateTime createdAt)
        {
            VideoId = videoId;
            Content = content;
            Language = language;
            CreatedBy = createdBy;
            CreatedAt = createdAt;
        }
    }
}
