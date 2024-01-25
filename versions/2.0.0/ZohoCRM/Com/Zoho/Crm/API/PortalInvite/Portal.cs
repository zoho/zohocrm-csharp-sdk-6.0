using Com.Zoho.Crm.API.Util;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.PortalInvite
{

	public class Portal : Model
	{
		private long? id;
		private long? userTypeId;
		private Choice<string> type;
		private Choice<string> language;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

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

		public long? UserTypeId
		{
			/// <summary>The method to get the userTypeId</summary>
			/// <returns>long? representing the userTypeId</returns>
			get
			{
				return  this.userTypeId;

			}
			/// <summary>The method to set the value to userTypeId</summary>
			/// <param name="userTypeId">long?</param>
			set
			{
				 this.userTypeId=value;

				 this.keyModified["user_type_id"] = 1;

			}
		}

		public Choice<string> Type
		{
			/// <summary>The method to get the type</summary>
			/// <returns>Instance of Choice<String></returns>
			get
			{
				return  this.type;

			}
			/// <summary>The method to set the value to type</summary>
			/// <param name="type">Instance of Choice<string></param>
			set
			{
				 this.type=value;

				 this.keyModified["type"] = 1;

			}
		}

		public Choice<string> Language
		{
			/// <summary>The method to get the language</summary>
			/// <returns>Instance of Choice<String></returns>
			get
			{
				return  this.language;

			}
			/// <summary>The method to set the value to language</summary>
			/// <param name="language">Instance of Choice<string></param>
			set
			{
				 this.language=value;

				 this.keyModified["language"] = 1;

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