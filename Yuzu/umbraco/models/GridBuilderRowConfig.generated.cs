//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder.Embedded v9.5.0+1c39c27e220efde6f0f360b94b6e7b6a1f0f0e59
//
//   Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Linq.Expressions;
using Umbraco.Cms.Core.Models.PublishedContent;
using Umbraco.Cms.Core.PublishedCache;
using Umbraco.Cms.Infrastructure.ModelsBuilder;
using Umbraco.Cms.Core;
using Umbraco.Extensions;

namespace YuzuDelivery.UmbracoModels
{
	/// <summary>GridBuilderRowConfig</summary>
	[PublishedModel("gridBuilderRowConfig")]
	public partial class GridBuilderRowConfig : PublishedElementModel
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.5.0+1c39c27e220efde6f0f360b94b6e7b6a1f0f0e59")]
		public new const string ModelTypeAlias = "gridBuilderRowConfig";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.5.0+1c39c27e220efde6f0f360b94b6e7b6a1f0f0e59")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.5.0+1c39c27e220efde6f0f360b94b6e7b6a1f0f0e59")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public new static IPublishedContentType GetModelContentType(IPublishedSnapshotAccessor publishedSnapshotAccessor)
			=> PublishedModelUtility.GetModelContentType(publishedSnapshotAccessor, ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.5.0+1c39c27e220efde6f0f360b94b6e7b6a1f0f0e59")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(IPublishedSnapshotAccessor publishedSnapshotAccessor, Expression<Func<GridBuilderRowConfig, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(publishedSnapshotAccessor), selector);
#pragma warning restore 0109

		private IPublishedValueFallback _publishedValueFallback;

		// ctor
		public GridBuilderRowConfig(IPublishedElement content, IPublishedValueFallback publishedValueFallback)
			: base(content, publishedValueFallback)
		{
			_publishedValueFallback = publishedValueFallback;
		}

		// properties

		///<summary>
		/// Boolean
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.5.0+1c39c27e220efde6f0f360b94b6e7b6a1f0f0e59")]
		[ImplementPropertyType("boolean")]
		public virtual bool Boolean => this.Value<bool>(_publishedValueFallback, "boolean");

		///<summary>
		/// Enum String
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.5.0+1c39c27e220efde6f0f360b94b6e7b6a1f0f0e59")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("enumString")]
		public virtual string EnumString => this.Value<string>(_publishedValueFallback, "enumString");

		///<summary>
		/// Image
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.5.0+1c39c27e220efde6f0f360b94b6e7b6a1f0f0e59")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("image")]
		public virtual global::Umbraco.Cms.Core.Models.MediaWithCrops Image => this.Value<global::Umbraco.Cms.Core.Models.MediaWithCrops>(_publishedValueFallback, "image");

		///<summary>
		/// Link
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.5.0+1c39c27e220efde6f0f360b94b6e7b6a1f0f0e59")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("link")]
		public virtual global::Umbraco.Cms.Core.Models.Link Link => this.Value<global::Umbraco.Cms.Core.Models.Link>(_publishedValueFallback, "link");

		///<summary>
		/// Number
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.5.0+1c39c27e220efde6f0f360b94b6e7b6a1f0f0e59")]
		[ImplementPropertyType("number")]
		public virtual int Number => this.Value<int>(_publishedValueFallback, "number");

		///<summary>
		/// String
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.5.0+1c39c27e220efde6f0f360b94b6e7b6a1f0f0e59")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("string")]
		public virtual string String => this.Value<string>(_publishedValueFallback, "string");
	}
}