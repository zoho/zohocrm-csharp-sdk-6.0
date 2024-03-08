using Com.Zoho.Crm.API.Util;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.UnsubscribeLinks
{

	public class ResponseWrapper : Model, ResponseHandler
	{
		private List<UnsubscribeLinks> unsubscribeLinks;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public List<UnsubscribeLinks> UnsubscribeLinks
		{
			/// <summary>The method to get the unsubscribeLinks</summary>
			/// <returns>Instance of List<UnsubscribeLinks></returns>
			get
			{
				return  this.unsubscribeLinks;

			}
			/// <summary>The method to set the value to unsubscribeLinks</summary>
			/// <param name="unsubscribeLinks">Instance of List<UnsubscribeLinks></param>
			set
			{
				 this.unsubscribeLinks=value;

				 this.keyModified["unsubscribe_links"] = 1;

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