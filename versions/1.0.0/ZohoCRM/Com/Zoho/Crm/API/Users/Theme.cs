using Com.Zoho.Crm.API.Util;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.Users
{

	public class Theme : Model
	{
		private Tab normalTab;
		private Tab selectedTab;
		private string newBackground;
		private Choice<string> background;
		private Choice<string> screen;
		private string type;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public Tab NormalTab
		{
			/// <summary>The method to get the normalTab</summary>
			/// <returns>Instance of Tab</returns>
			get
			{
				return  this.normalTab;

			}
			/// <summary>The method to set the value to normalTab</summary>
			/// <param name="normalTab">Instance of Tab</param>
			set
			{
				 this.normalTab=value;

				 this.keyModified["normal_tab"] = 1;

			}
		}

		public Tab SelectedTab
		{
			/// <summary>The method to get the selectedTab</summary>
			/// <returns>Instance of Tab</returns>
			get
			{
				return  this.selectedTab;

			}
			/// <summary>The method to set the value to selectedTab</summary>
			/// <param name="selectedTab">Instance of Tab</param>
			set
			{
				 this.selectedTab=value;

				 this.keyModified["selected_tab"] = 1;

			}
		}

		public string NewBackground
		{
			/// <summary>The method to get the newBackground</summary>
			/// <returns>string representing the newBackground</returns>
			get
			{
				return  this.newBackground;

			}
			/// <summary>The method to set the value to newBackground</summary>
			/// <param name="newBackground">string</param>
			set
			{
				 this.newBackground=value;

				 this.keyModified["new_background"] = 1;

			}
		}

		public Choice<string> Background
		{
			/// <summary>The method to get the background</summary>
			/// <returns>Instance of Choice<String></returns>
			get
			{
				return  this.background;

			}
			/// <summary>The method to set the value to background</summary>
			/// <param name="background">Instance of Choice<string></param>
			set
			{
				 this.background=value;

				 this.keyModified["background"] = 1;

			}
		}

		public Choice<string> Screen
		{
			/// <summary>The method to get the screen</summary>
			/// <returns>Instance of Choice<String></returns>
			get
			{
				return  this.screen;

			}
			/// <summary>The method to set the value to screen</summary>
			/// <param name="screen">Instance of Choice<string></param>
			set
			{
				 this.screen=value;

				 this.keyModified["screen"] = 1;

			}
		}

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