using ConSite.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Umbraco.Web.Mvc;
using Umbraco.Web.PublishedModels;

namespace ConSite.Controllers
{
    public class FooterSurfaceController : SurfaceController
    {
        
        public ActionResult Footer(int Id)
        {
            var contentNode = Umbraco.Content(Id);
            var site = Umbraco.ContentAtRoot().FirstOrDefault(x => x.ContentType.Alias == Site.ModelTypeAlias) as Site;
          

            FooterViewModel footerVM = new FooterViewModel()
            {
                ListaFooterLinks= site.FooterLinkNested

        };
           

            return PartialView(footerVM);
        }
    }
}