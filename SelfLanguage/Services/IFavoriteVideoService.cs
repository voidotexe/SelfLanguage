/*
 * By: voidotexe
 * https://www.github.com/voidotexe
*/

using SelfLanguage.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SelfLanguage.Services
{
    public interface IFavoriteVideoService
    {
        IEnumerable<FavoriteVideoViewModel> FavoriteVideos { get; set; }

        Task ReadByUserIdApi(string userId);
    }
}
