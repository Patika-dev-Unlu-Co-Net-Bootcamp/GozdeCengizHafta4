using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using NewsletterProject.Models.Auth;
using System.Threading.Tasks;

namespace NewsletterProject.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class RoleController : ControllerBase
    {
        readonly RoleManager<AppRole> _roleManager;
        readonly UserManager<AppUser> _userManager;
        public RoleController(RoleManager<AppRole> roleManager,UserManager<AppUser> userManager)
        {
            _roleManager = roleManager;
            _userManager = userManager;
        }
        public async Task<IActionResult> RoleAssign(string id)
        {
            AppUser user = await _userManager.FindByIdAsync(id);

            await _userManager.AddToRoleAsync(user, "Administrator");
            await _userManager.AddToRoleAsync(user, "Moderator");
            await _userManager.AddToRoleAsync(user, "Editor");
            return Ok();
        }
    }
}
