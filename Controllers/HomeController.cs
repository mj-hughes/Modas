using Microsoft.AspNetCore.Mvc;
using Modus.Models;

namespace Modas.Controllers
{
    public class HomeController : Controller
    {
        private IEventRepository repository;
        public HomeController(IEventRepository repo)
        {
            repository = repo;
        }

        public ViewResult Index() => View(repository.Events);
    }
}
