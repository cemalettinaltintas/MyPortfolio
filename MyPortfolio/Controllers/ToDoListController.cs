using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;

namespace MyPortfolio.Controllers
{
    public class ToDoListController : Controller
    {
        MyPortfolioContext context=new MyPortfolioContext();
        public IActionResult Index()
        {
            var values=context.ToDoLists.ToList();
            return View(values);
        }
        public IActionResult ChangeStatusToFalse(int id)
        {
            var value = context.ToDoLists.Find(id);
            value.Status = false;
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult ChangeStatusToTrue(int id)
        {
            var value = context.ToDoLists.Find(id);
            value.Status = true;
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
