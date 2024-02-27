using Com.Zoho.Crm.API.Util;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.Backup
{

	public class ActionWrapper : Model, ActionHandler
	{
		private ActionResponse backup;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public ActionResponse Backup
		{
			/// <summary>The method to get the backup</summary>
			/// <returns>Instance of ActionResponse</returns>
			get
			{
				return  this.backup;

			}
			/// <summary>The method to set the value to backup</summary>
			/// <param name="backup">Instance of ActionResponse</param>
			set
			{
				 this.backup=value;

				 this.keyModified["backup"] = 1;

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