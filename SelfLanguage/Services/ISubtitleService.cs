/*
 * By: voidotexe
 * https://www.github.com/voidotexe
*/

using SelfLanguage.Models;
using System.Net;
using System.Threading.Tasks;

namespace SelfLanguage.Services
{
    public interface ISubtitleService
    {
        Task<HttpStatusCode> CallSubtitleApi(Subtitle subtitle);
    }
}
