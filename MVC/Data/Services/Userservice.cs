using Microsoft.AspNetCore.Http;
using System.Security.Claims;

namespace MVC.Data.Services
{
    public class Userservice : IUserservice
    {
        private readonly IHttpContextAccessor _ihttpContext;
        public Userservice(IHttpContextAccessor ihttpContext)
        {
            _ihttpContext = ihttpContext;
        }

        public string GetUserId()
        {
            return _ihttpContext.HttpContext.User?.FindFirstValue(ClaimTypes.NameIdentifier);
        }
        public string GetUser()
        {
            return _ihttpContext.HttpContext.User?.FindFirstValue(ClaimTypes.Name);
        }

    }
}
