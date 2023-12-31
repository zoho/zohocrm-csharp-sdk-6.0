using Com.Zoho.Crm.API.Users;
using Com.Zoho.Crm.API.Util;
using System;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.Roles
{

	public class Role : Model
	{
		private string displayLabel;
		private ReportingTo forecastManager;
		private ReportingTo reportingTo;
		private bool? shareWithPeers;
		private string description;
		private long? id;
		private string name;
		private Users.MinifiedUser createdByS;
		private Users.MinifiedUser modifiedByS;
		private DateTimeOffset? modifiedTimeS;
		private DateTimeOffset? createdTimeS;
		private bool? adminUser;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public string DisplayLabel
		{
			/// <summary>The method to get the displayLabel</summary>
			/// <returns>string representing the displayLabel</returns>
			get
			{
				return  this.displayLabel;

			}
			/// <summary>The method to set the value to displayLabel</summary>
			/// <param name="displayLabel">string</param>
			set
			{
				 this.displayLabel=value;

				 this.keyModified["display_label"] = 1;

			}
		}

		public ReportingTo ForecastManager
		{
			/// <summary>The method to get the forecastManager</summary>
			/// <returns>Instance of ReportingTo</returns>
			get
			{
				return  this.forecastManager;

			}
			/// <summary>The method to set the value to forecastManager</summary>
			/// <param name="forecastManager">Instance of ReportingTo</param>
			set
			{
				 this.forecastManager=value;

				 this.keyModified["forecast_manager"] = 1;

			}
		}

		public ReportingTo ReportingTo
		{
			/// <summary>The method to get the reportingTo</summary>
			/// <returns>Instance of ReportingTo</returns>
			get
			{
				return  this.reportingTo;

			}
			/// <summary>The method to set the value to reportingTo</summary>
			/// <param name="reportingTo">Instance of ReportingTo</param>
			set
			{
				 this.reportingTo=value;

				 this.keyModified["reporting_to"] = 1;

			}
		}

		public bool? ShareWithPeers
		{
			/// <summary>The method to get the shareWithPeers</summary>
			/// <returns>bool? representing the shareWithPeers</returns>
			get
			{
				return  this.shareWithPeers;

			}
			/// <summary>The method to set the value to shareWithPeers</summary>
			/// <param name="shareWithPeers">bool?</param>
			set
			{
				 this.shareWithPeers=value;

				 this.keyModified["share_with_peers"] = 1;

			}
		}

		public string Description
		{
			/// <summary>The method to get the description</summary>
			/// <returns>string representing the description</returns>
			get
			{
				return  this.description;

			}
			/// <summary>The method to set the value to description</summary>
			/// <param name="description">string</param>
			set
			{
				 this.description=value;

				 this.keyModified["description"] = 1;

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

		public Users.MinifiedUser CreatedByS
		{
			/// <summary>The method to get the createdByS</summary>
			/// <returns>Instance of MinifiedUser</returns>
			get
			{
				return  this.createdByS;

			}
			/// <summary>The method to set the value to createdByS</summary>
			/// <param name="createdByS">Instance of MinifiedUser</param>
			set
			{
				 this.createdByS=value;

				 this.keyModified["created_by__s"] = 1;

			}
		}

		public Users.MinifiedUser ModifiedByS
		{
			/// <summary>The method to get the modifiedByS</summary>
			/// <returns>Instance of MinifiedUser</returns>
			get
			{
				return  this.modifiedByS;

			}
			/// <summary>The method to set the value to modifiedByS</summary>
			/// <param name="modifiedByS">Instance of MinifiedUser</param>
			set
			{
				 this.modifiedByS=value;

				 this.keyModified["modified_by__s"] = 1;

			}
		}

		public DateTimeOffset? ModifiedTimeS
		{
			/// <summary>The method to get the modifiedTimeS</summary>
			/// <returns>DateTimeOffset? representing the modifiedTimeS</returns>
			get
			{
				return  this.modifiedTimeS;

			}
			/// <summary>The method to set the value to modifiedTimeS</summary>
			/// <param name="modifiedTimeS">DateTimeOffset?</param>
			set
			{
				 this.modifiedTimeS=value;

				 this.keyModified["modified_time__s"] = 1;

			}
		}

		public DateTimeOffset? CreatedTimeS
		{
			/// <summary>The method to get the createdTimeS</summary>
			/// <returns>DateTimeOffset? representing the createdTimeS</returns>
			get
			{
				return  this.createdTimeS;

			}
			/// <summary>The method to set the value to createdTimeS</summary>
			/// <param name="createdTimeS">DateTimeOffset?</param>
			set
			{
				 this.createdTimeS=value;

				 this.keyModified["created_time__s"] = 1;

			}
		}

		public bool? AdminUser
		{
			/// <summary>The method to get the adminUser</summary>
			/// <returns>bool? representing the adminUser</returns>
			get
			{
				return  this.adminUser;

			}
			/// <summary>The method to set the value to adminUser</summary>
			/// <param name="adminUser">bool?</param>
			set
			{
				 this.adminUser=value;

				 this.keyModified["admin_user"] = 1;

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