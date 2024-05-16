using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;

namespace MyPortfolio.ViewComponents
{
    public class _SkillComponentPartial:ViewComponent
    {
        MyPortfolioContext portfolioContext=new MyPortfolioContext();
        public IViewComponentResult Invoke() 
        {
            var degerler=portfolioContext.Skills.ToList();
            return View(degerler); 
        }
    }
}
