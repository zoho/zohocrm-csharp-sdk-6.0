using Com.Zoho.Crm.API.Fields;
using Com.Zoho.Crm.API.Util;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.BulkRead
{

	public class Criteria : Model
	{
		private string type;
		private string apiName;
		private object value;
		private Choice<string> groupOperator;
		private List<Criteria> group;
		private Fields.MinifiedField field;
		private Choice<string> comparator;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public string Type
		{
			/// <summary>The method to get the type</summary>
			/// <returns>string representing the type</returns>
			get
			{
				return  this.type;

			}
			/// <summary>The method to set the value to type</summary>
			/// <param name="type">string</param>
			set
			{
				 this.type=value;

				 this.keyModified["type"] = 1;

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

		public object Value
		{
			/// <summary>The method to get the value</summary>
			/// <returns>object representing the value</returns>
			get
			{
				return  this.value;

			}
			/// <summary>The method to set the value to value</summary>
			/// <param name="value">object</param>
			set
			{
				 this.value=value;

				 this.keyModified["value"] = 1;

			}
		}

		public Choice<string> GroupOperator
		{
			/// <summary>The method to get the groupOperator</summary>
			/// <returns>Instance of Choice<String></returns>
			get
			{
				return  this.groupOperator;

			}
			/// <summary>The method to set the value to groupOperator</summary>
			/// <param name="groupOperator">Instance of Choice<string></param>
			set
			{
				 this.groupOperator=value;

				 this.keyModified["group_operator"] = 1;

			}
		}

		public List<Criteria> Group
		{
			/// <summary>The method to get the group</summary>
			/// <returns>Instance of List<Criteria></returns>
			get
			{
				return  this.group;

			}
			/// <summary>The method to set the value to group</summary>
			/// <param name="group">Instance of List<Criteria></param>
			set
			{
				 this.group=value;

				 this.keyModified["group"] = 1;

			}
		}

		public Fields.MinifiedField Field
		{
			/// <summary>The method to get the field</summary>
			/// <returns>Instance of MinifiedField</returns>
			get
			{
				return  this.field;

			}
			/// <summary>The method to set the value to field</summary>
			/// <param name="field">Instance of MinifiedField</param>
			set
			{
				 this.field=value;

				 this.keyModified["field"] = 1;

			}
		}

		public Choice<string> Comparator
		{
			/// <summary>The method to get the comparator</summary>
			/// <returns>Instance of Choice<String></returns>
			get
			{
				return  this.comparator;

			}
			/// <summary>The method to set the value to comparator</summary>
			/// <param name="comparator">Instance of Choice<string></param>
			set
			{
				 this.comparator=value;

				 this.keyModified["comparator"] = 1;

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