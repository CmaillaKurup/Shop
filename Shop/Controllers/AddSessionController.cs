using Microsoft.AspNetCore.Mvc;

namespace Shop.Controllers
{
    public class AddSessionController : Controller
    {
        public void AddSession()
        {
            var myComplexObject = new ShoppingcartController();
            HttpContext.Session.SetObjectAsJson("Test", myComplexObject);
        }
    }
}