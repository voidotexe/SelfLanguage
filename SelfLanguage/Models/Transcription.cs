/*
 * By: voidotexe
 * https://www.github.com/voidotexe
*/

using System;

namespace SelfLanguage.Models
{
    public class Transcription
    {
        public int VideoId { get; set; }
        public string Content { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }

        public Transcription(int videoId, string content, string createdBy, DateTime createdAt)
        {
            VideoId = videoId;
            Content = content;
            CreatedBy = createdBy;
            CreatedAt = createdAt;
        }
    }
}
