/*
 * By: voidotexe
 * https://www.github.com/voidotexe
*/

using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SelfLanguage.Models;

namespace SelfLanguage.Data
{
    public class UserDbContext : IdentityDbContext<User>
    {
        public UserDbContext(DbContextOptions<UserDbContext> options) : base(options) { }
    }
}
