using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Web.Http.Filters;

namespace NewsletterProject.Filters
{
    public class CustomResultFilter : FilterAttribute, IResultFilter
    {
        public void OnResultExecuted(ResultExecutedContext context)
        {
            //view goruntulenmeden
            string saat = DateTime.Now.ToString();
            context.HttpContext.Response.Headers.Add("Request", saat);
        }

        public void OnResultExecuting(ResultExecutingContext context)
        {
            //view goruntulendıkten sonra
            string saat = DateTime.Now.ToString();
            context.HttpContext.Response.Headers.Add("Request",saat);

        }
    }
}
