using Com.Zoho.Crm.API.Util;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.Blueprint
{

	public class ConvertMapping : Model
	{
		private ModuleMapping contacts;
		private ModuleMapping deals;
		private ModuleMapping accounts;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public ModuleMapping Contacts
		{
			/// <summary>The method to get the contacts</summary>
			/// <returns>Instance of ModuleMapping</returns>
			get
			{
				return  this.contacts;

			}
			/// <summary>The method to set the value to contacts</summary>
			/// <param name="contacts">Instance of ModuleMapping</param>
			set
			{
				 this.contacts=value;

				 this.keyModified["Contacts"] = 1;

			}
		}

		public ModuleMapping Deals
		{
			/// <summary>The method to get the deals</summary>
			/// <returns>Instance of ModuleMapping</returns>
			get
			{
				return  this.deals;

			}
			/// <summary>The method to set the value to deals</summary>
			/// <param name="deals">Instance of ModuleMapping</param>
			set
			{
				 this.deals=value;

				 this.keyModified["Deals"] = 1;

			}
		}

		public ModuleMapping Accounts
		{
			/// <summary>The method to get the accounts</summary>
			/// <returns>Instance of ModuleMapping</returns>
			get
			{
				return  this.accounts;

			}
			/// <summary>The method to set the value to accounts</summary>
			/// <param name="accounts">Instance of ModuleMapping</param>
			set
			{
				 this.accounts=value;

				 this.keyModified["Accounts"] = 1;

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