//--------------------------------------------------------------------------------------------------
// <auto-generated>
//
//     This code was generated by code generator tool.
//
//     To customize the code use your own partial class. For more info about how to use and customize
//     the generated code see the documentation at http://docs.kentico.com.
//
// </auto-generated>
//--------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;

using CMS;
using CMS.Base;
using CMS.Helpers;
using CMS.DataEngine;
using CMS.DocumentEngine.Types.MedioClinic;
using CMS.DocumentEngine;

[assembly: RegisterDocumentType(MenuContainer.CLASS_NAME, typeof(MenuContainer))]

namespace CMS.DocumentEngine.Types.MedioClinic
{
	/// <summary>
	/// Represents a content item of type MenuContainer.
	/// </summary>
	public partial class MenuContainer : TreeNode
	{
		#region "Constants and variables"

		/// <summary>
		/// The name of the data class.
		/// </summary>
		public const string CLASS_NAME = "MedioClinic.MenuContainer";


		/// <summary>
		/// The instance of the class that provides extended API for working with MenuContainer fields.
		/// </summary>
		private readonly MenuContainerFields mFields;

		#endregion


		#region "Properties"

		/// <summary>
		/// MenuContainerID.
		/// </summary>
		[DatabaseIDField]
		public int MenuContainerID
		{
			get
			{
				return ValidationHelper.GetInteger(GetValue("MenuContainerID"), 0);
			}
			set
			{
				SetValue("MenuContainerID", value);
			}
		}


		/// <summary>
		/// Menu name.
		/// </summary>
		[DatabaseField]
		public string MenuName
		{
			get
			{
				return ValidationHelper.GetString(GetValue("MenuName"), @"");
			}
			set
			{
				SetValue("MenuName", value);
			}
		}


		/// <summary>
		/// Gets an object that provides extended API for working with MenuContainer fields.
		/// </summary>
		[RegisterProperty]
		public MenuContainerFields Fields
		{
			get
			{
				return mFields;
			}
		}


		/// <summary>
		/// Provides extended API for working with MenuContainer fields.
		/// </summary>
		[RegisterAllProperties]
		public partial class MenuContainerFields : AbstractHierarchicalObject<MenuContainerFields>
		{
			/// <summary>
			/// The content item of type MenuContainer that is a target of the extended API.
			/// </summary>
			private readonly MenuContainer mInstance;


			/// <summary>
			/// Initializes a new instance of the <see cref="MenuContainerFields" /> class with the specified content item of type MenuContainer.
			/// </summary>
			/// <param name="instance">The content item of type MenuContainer that is a target of the extended API.</param>
			public MenuContainerFields(MenuContainer instance)
			{
				mInstance = instance;
			}


			/// <summary>
			/// MenuContainerID.
			/// </summary>
			public int ID
			{
				get
				{
					return mInstance.MenuContainerID;
				}
				set
				{
					mInstance.MenuContainerID = value;
				}
			}


			/// <summary>
			/// Menu name.
			/// </summary>
			public string MenuName
			{
				get
				{
					return mInstance.MenuName;
				}
				set
				{
					mInstance.MenuName = value;
				}
			}
		}

		#endregion


		#region "Constructors"

		/// <summary>
		/// Initializes a new instance of the <see cref="MenuContainer" /> class.
		/// </summary>
		public MenuContainer() : base(CLASS_NAME)
		{
			mFields = new MenuContainerFields(this);
		}

		#endregion
	}
}