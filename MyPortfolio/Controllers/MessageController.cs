using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;

namespace MyPortfolio.Controllers
{
    public class MessageController : Controller
    {
        MyPortfolioContext context=new MyPortfolioContext();
        public IActionResult Inbox()
        {
            var values=context.Messages.ToList();
            return View(values);
        }
        public IActionResult ChangeIsReadToFalse(int id) 
        { 
            var value=context.Messages.Find(id);
            value.IsRead=false;
            context.SaveChanges();
            return RedirectToAction("Inbox");
        }
        public IActionResult ChangeIsReadToTrue(int id)
        {
            var value = context.Messages.Find(id);
            value.IsRead = true;
            context.SaveChanges();
            return RedirectToAction("Inbox");
        }
        public IActionResult MessageDetail(int id) 
        {
            var message = context.Messages.Find(id);    

            return View(message);
        }
    }
}
