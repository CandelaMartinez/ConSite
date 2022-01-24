using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Umbraco.Web.PublishedModels;

namespace ConSite.ViewModels
{
    public class FooterViewModel
    {
        public IEnumerable<FooterItem> ListaFooterLinks { get; set; }
    }
}