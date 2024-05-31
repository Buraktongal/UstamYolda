using Microsoft.AspNetCore.Mvc;
using UstamYolda.Core.Aggregates.Entities;
using UstamYolda.Core.Aggregates.Interfaces;

namespace UstamYolda.Web.Controllers
{
    public class UserController : Controller
    {
        private readonly IRepository<User> _userRepository;
        public UserController(IRepository<User> userRepository )
        {
            _userRepository = userRepository;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
