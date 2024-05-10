using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;

namespace MyPortfolio.ViewComponents
{
    
    public class _FeatureComponentPartial:ViewComponent
    {
        MyPortfolioContext portfolioContext=new MyPortfolioContext();
        public IViewComponentResult Invoke() 
        {  
            var value=portfolioContext.Features.FirstOrDefault();
            return View(value); 
        }
    }
}
