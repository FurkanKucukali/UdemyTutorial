using Microsoft.AspNetCore.Mvc.Filters;
using System.Linq;
using WebApplication1.Models;

namespace WebApplication1.Filters
{
    public class ValidFirstName : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            var dictionary = context.ActionArguments.FirstOrDefault(I => I.Key == "customer");
            var customer =   dictionary.Value as Customer;
            base.OnActionExecuting(context);
        }
    }
}
