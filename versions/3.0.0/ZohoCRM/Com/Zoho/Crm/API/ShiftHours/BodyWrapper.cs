using Com.Zoho.Crm.API.Util;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.ShiftHours
{

	public class BodyWrapper : Model
	{
		private List<ShiftHours> shiftHours;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public List<ShiftHours> ShiftHours
		{
			/// <summary>The method to get the shiftHours</summary>
			/// <returns>Instance of List<ShiftHours></returns>
			get
			{
				return  this.shiftHours;

			}
			/// <summary>The method to set the value to shiftHours</summary>
			/// <param name="shiftHours">Instance of List<ShiftHours></param>
			set
			{
				 this.shiftHours=value;

				 this.keyModified["shift_hours"] = 1;

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