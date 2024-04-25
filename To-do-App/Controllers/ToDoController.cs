using Microsoft.AspNetCore.Mvc;
using To_do_App.Models;

namespace To_do_App.Controllers
{
    public class ToDoController : Controller
    {
        private readonly AppDbContext _db;
        public ToDoController(AppDbContext db)
        {
            _db = db;
        }


        [HttpGet]
        public IActionResult Index()
        {
            var ToDoList = _db.ToDoSet.OrderBy(i => i.DueDate).ToList();

            return View(ToDoList);
        }
      // Create 
        public IActionResult New()
        {
            return View();
        }
        [HttpPost]
        public IActionResult New(ToDo item)
        {
            if (ModelState.IsValid)
            {
                _db.ToDoSet.Add(item);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(item);
        }
        // Delete
        public IActionResult Delete(int id)
        {
            var item = _db.ToDoSet.Find(id);
            _db.ToDoSet.Remove(item);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        // Edit

        public IActionResult Edit(int id)
        {
            var item = _db.ToDoSet.Find(id);
            return View(item);
        }
        [HttpPost]
        public IActionResult Edit(ToDo item)
        {
            _db.ToDoSet.Update(item);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult EditStatus(int id)
        {
            var item = _db.ToDoSet.Find(id);
            if (item.Status == "In Progress")
            {
                item.Status = "Finished";
                _db.ToDoSet.Update(item);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
          
            else
            {
                return RedirectToAction("Index");
            }
            
        }

    }
}
