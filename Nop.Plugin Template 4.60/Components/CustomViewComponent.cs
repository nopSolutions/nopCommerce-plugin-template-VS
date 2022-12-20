using Microsoft.AspNetCore.Mvc;
using Nop.Web.Framework.Components;
using System;

namespace $safeprojectname$.Components
{
    [ViewComponent(Name = "Custom")]
    public class CustomViewComponent : NopViewComponent
    {
        public CustomViewComponent()
        {

        }

        public IViewComponentResult Invoke(int productId)
        {
            throw new NotImplementedException();
        }
    }
}
