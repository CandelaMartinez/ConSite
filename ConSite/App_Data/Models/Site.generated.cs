//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder.Embedded v8.17.1
//
//   Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Web;
using Umbraco.Core.Models;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web;
using Umbraco.ModelsBuilder.Embedded;

namespace Umbraco.Web.PublishedModels
{
	/// <summary>Site</summary>
	[PublishedModel("site")]
	public partial class Site : PublishedContentModel
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.17.1")]
		public new const string ModelTypeAlias = "site";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.17.1")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.17.1")]
		public new static IPublishedContentType GetModelContentType()
			=> PublishedModelUtility.GetModelContentType(ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.17.1")]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Site, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(), selector);
#pragma warning restore 0109

		// ctor
		public Site(IPublishedContent content)
			: base(content)
		{ }

		// properties

		///<summary>
		/// FooterLinkNested
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.17.1")]
		[ImplementPropertyType("footerLinkNested")]
		public virtual global::System.Collections.Generic.IEnumerable<global::Umbraco.Web.PublishedModels.FooterItem> FooterLinkNested => this.Value<global::System.Collections.Generic.IEnumerable<global::Umbraco.Web.PublishedModels.FooterItem>>("footerLinkNested");

		///<summary>
		/// NavBarNested
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.17.1")]
		[ImplementPropertyType("navBarNested")]
		public virtual global::System.Collections.Generic.IEnumerable<global::Umbraco.Web.PublishedModels.NavBarItem> NavBarNested => this.Value<global::System.Collections.Generic.IEnumerable<global::Umbraco.Web.PublishedModels.NavBarItem>>("navBarNested");

		///<summary>
		/// SiteTitle
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.17.1")]
		[ImplementPropertyType("siteTitle")]
		public virtual string SiteTitle => this.Value<string>("siteTitle");

		///<summary>
		/// FrontPage: esta sera la pagina que se mostrara al abrir el link
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.17.1")]
		[ImplementPropertyType("umbracoInternalRedirectId")]
		public virtual global::Umbraco.Core.Models.PublishedContent.IPublishedContent UmbracoInternalRedirectId => this.Value<global::Umbraco.Core.Models.PublishedContent.IPublishedContent>("umbracoInternalRedirectId");
	}
}
