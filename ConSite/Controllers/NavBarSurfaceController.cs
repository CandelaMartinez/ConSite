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
    public class NavBarSurfaceController : SurfaceController
    {
       
        public ActionResult  NavBar(int Id)
        {
            //accedo a la pagina donde estoy por el id
            var contentNode = Umbraco.Content(Id);
            //accedo al root llamado Site, es donde tengo mi navegador
            var site = Umbraco.ContentAtRoot().FirstOrDefault(x => x.ContentType.Alias == Site.ModelTypeAlias) as Site;
            //creo mi viewModel y le cargo los valores que traigo de lo publicado en root

            NavBarViewModel navBarVM = new NavBarViewModel()
            {
            
                ListaChildren = site.NavBarNested
            };
            //devuelvo partial view y le paso el viewModel como parametro
            return PartialView(navBarVM);
        }
    }
}