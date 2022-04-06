/*
 * By: voidotexe
 * https://www.github.com/voidotexe
*/

using SelfLanguage.Models;
using System.Net;
using System.Threading.Tasks;

namespace SelfLanguage.Services
{
    public interface ITranscriptionService
    {
        Task<HttpStatusCode> CallTranscriptionApi(Transcription transcription);
    }
}
