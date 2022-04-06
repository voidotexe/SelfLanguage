/*
 * By: voidotexe
 * https://www.github.com/voidotexe
*/

using System;

namespace SelfLanguage.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
