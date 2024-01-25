using Com.Zoho.Crm.API.Util;
using System;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.ShiftHours
{

	public class Users : Model
	{
		private Role role;
		private string name;
		private long? id;
		private string email;
		private string zuid;
		private DateTime? effectiveFrom;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public Role Role
		{
			/// <summary>The method to get the role</summary>
			/// <returns>Instance of Role</returns>
			get
			{
				return  this.role;

			}
			/// <summary>The method to set the value to role</summary>
			/// <param name="role">Instance of Role</param>
			set
			{
				 this.role=value;

				 this.keyModified["role"] = 1;

			}
		}

		public string Name
		{
			/// <summary>The method to get the name</summary>
			/// <returns>string representing the name</returns>
			get
			{
				return  this.name;

			}
			/// <summary>The method to set the value to name</summary>
			/// <param name="name">string</param>
			set
			{
				 this.name=value;

				 this.keyModified["name"] = 1;

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

		public string Email
		{
			/// <summary>The method to get the email</summary>
			/// <returns>string representing the email</returns>
			get
			{
				return  this.email;

			}
			/// <summary>The method to set the value to email</summary>
			/// <param name="email">string</param>
			set
			{
				 this.email=value;

				 this.keyModified["email"] = 1;

			}
		}

		public string Zuid
		{
			/// <summary>The method to get the zuid</summary>
			/// <returns>string representing the zuid</returns>
			get
			{
				return  this.zuid;

			}
			/// <summary>The method to set the value to zuid</summary>
			/// <param name="zuid">string</param>
			set
			{
				 this.zuid=value;

				 this.keyModified["zuid"] = 1;

			}
		}

		public DateTime? EffectiveFrom
		{
			/// <summary>The method to get the effectiveFrom</summary>
			/// <returns>DateTime? representing the effectiveFrom</returns>
			get
			{
				return  this.effectiveFrom;

			}
			/// <summary>The method to set the value to effectiveFrom</summary>
			/// <param name="effectiveFrom">DateTime?</param>
			set
			{
				 this.effectiveFrom=value;

				 this.keyModified["effective_from"] = 1;

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