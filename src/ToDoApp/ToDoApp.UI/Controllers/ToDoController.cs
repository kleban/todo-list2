using Microsoft.AspNetCore.Mvc;
using ToDoApp.Domain;

namespace ToDoApp.UI.Controllers
{
    public class ToDoController : Controller
    {
        private readonly ToDoContext _context;

        public ToDoController(ToDoContext context)
        {
            _context = context;
        }

        public IActionResult Index(string view = "table")
        {
            var tasks = _context.ToDos.ToList();
            if(view == "list")
                return View("List", tasks);

            return View("Table", tasks);
        }
    }
}
