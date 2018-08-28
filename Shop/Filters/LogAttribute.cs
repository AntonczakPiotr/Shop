using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Shop.Filters
{
    public class LogAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContex)
        {
            base.OnActionExecuting(filterContex);
        }

        public override void OnActionExecuted(ActionExecutedContext filterContex)
        {
            base.OnActionExecuted(filterContex);
        }
    }
}