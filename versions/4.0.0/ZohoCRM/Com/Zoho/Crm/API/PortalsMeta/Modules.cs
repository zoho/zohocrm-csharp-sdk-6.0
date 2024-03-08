using Com.Zoho.Crm.API.Util;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.PortalsMeta
{

	public class Modules : Model
	{
		private string pluralLabel;
		private string sharedType;
		private string apiName;
		private long? id;
		private List<Filters> filters;
		private List<Layouts> layouts;
		private List<Views> views;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public string PluralLabel
		{
			/// <summary>The method to get the pluralLabel</summary>
			/// <returns>string representing the pluralLabel</returns>
			get
			{
				return  this.pluralLabel;

			}
			/// <summary>The method to set the value to pluralLabel</summary>
			/// <param name="pluralLabel">string</param>
			set
			{
				 this.pluralLabel=value;

				 this.keyModified["plural_label"] = 1;

			}
		}

		public string SharedType
		{
			/// <summary>The method to get the sharedType</summary>
			/// <returns>string representing the sharedType</returns>
			get
			{
				return  this.sharedType;

			}
			/// <summary>The method to set the value to sharedType</summary>
			/// <param name="sharedType">string</param>
			set
			{
				 this.sharedType=value;

				 this.keyModified["shared_type"] = 1;

			}
		}

		public string APIName
		{
			/// <summary>The method to get the aPIName</summary>
			/// <returns>string representing the apiName</returns>
			get
			{
				return  this.apiName;

			}
			/// <summary>The method to set the value to aPIName</summary>
			/// <param name="apiName">string</param>
			set
			{
				 this.apiName=value;

				 this.keyModified["api_name"] = 1;

			}
		}

		public long? Id
		{
			/// <summary>The method to get the id</summary>
			/// <returns>long? representing the id</returns>
			get
			{
				return  this.id;

			}
			/// <summary>The method to set the value to id</summary>
			/// <param name="id">long?</param>
			set
			{
				 this.id=value;

				 this.keyModified["id"] = 1;

			}
		}

		public List<Filters> Filters
		{
			/// <summary>The method to get the filters</summary>
			/// <returns>Instance of List<Filters></returns>
			get
			{
				return  this.filters;

			}
			/// <summary>The method to set the value to filters</summary>
			/// <param name="filters">Instance of List<Filters></param>
			set
			{
				 this.filters=value;

				 this.keyModified["filters"] = 1;

			}
		}

		public List<Layouts> Layouts
		{
			/// <summary>The method to get the layouts</summary>
			/// <returns>Instance of List<Layouts></returns>
			get
			{
				return  this.layouts;

			}
			/// <summary>The method to set the value to layouts</summary>
			/// <param name="layouts">Instance of List<Layouts></param>
			set
			{
				 this.layouts=value;

				 this.keyModified["layouts"] = 1;

			}
		}

		public List<Views> Views
		{
			/// <summary>The method to get the views</summary>
			/// <returns>Instance of List<Views></returns>
			get
			{
				return  this.views;

			}
			/// <summary>The method to set the value to views</summary>
			/// <param name="views">Instance of List<Views></param>
			set
			{
				 this.views=value;

				 this.keyModified["views"] = 1;

			}
		}

		/// <summary>The method to check if the user has modified the given key</summary>
		/// <param name="key">string</param>
		/// <returns>int? representing the modification</returns>
		public int? IsKeyModified(string key)
		{
			if((( this.keyModified.ContainsKey(key))))
			{
				return  this.keyModified[key];

			}
			return null;


		}

		/// <summary>The method to mark the given key as modified</summary>
		/// <param name="key">string</param>
		/// <param name="modification">int?</param>
		public void SetKeyModified(string key, int? modification)
		{
			 this.keyModified[key] = modification;


		}


	}
}