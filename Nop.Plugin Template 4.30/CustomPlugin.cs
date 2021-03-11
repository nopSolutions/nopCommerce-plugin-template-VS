using Nop.Services.Cms;
using Nop.Services.Plugins;
using Nop.Web.Framework.Infrastructure;
using System.Collections.Generic;

namespace $safeprojectname$
{
    /// <summary>
    /// Rename this file and change to the correct name.
    /// </summary>
    public class CustomPlugin : BasePlugin, IWidgetPlugin
    {
        /// <summary>
        /// Gets a value indicating whether to hide this plugin on the widget list page in the admin area
        /// </summary>
        public bool HideInWidgetList => true;

        /// <summary>
        /// Gets a name of a view component for displaying widget
        /// </summary>
        /// <param name="widgetZone">Name of the widget zone</param>
        /// <returns>View component name</returns>
        public string GetWidgetViewComponentName(string widgetZone)
        {
            return "ProductViewTracker";
        }

        /// <summary>
        /// Gets widget zones where this widget should be rendered
        /// </summary>
        /// <returns>Widget zones</returns>
        public IList<string> GetWidgetZones()
        {
            return new List<string> { PublicWidgetZones.ProductDetailsTop };
        }


        /// <summary>
        /// Install the plugin
        /// </summary>
        public override void Install()
        {
            base.Install();
        }

        /// <summary>
        /// Uninstall the plugin
        /// </summary>
        public override void Uninstall()
        {
            base.Uninstall();
        }
    }
}
