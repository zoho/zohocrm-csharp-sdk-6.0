using Com.Zoho.Crm.API.Tags;
using Com.Zoho.Crm.API.Users;
using Com.Zoho.Crm.API.Util;
using System;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.Record
{

	public class PricingDetails : Record , Model
	{

		public double? ToRange
		{
			/// <summary>The method to get the toRange</summary>
			/// <returns>double? representing the toRange</returns>
			get
			{
				if((( this.GetKeyValue("to_range")) != (null)))
				{
					return (double?) this.GetKeyValue("to_range");

				}
					return null;


			}
			/// <summary>The method to set the value to toRange</summary>
			/// <param name="toRange">double?</param>
			set
			{
				 this.AddKeyValue("to_range", value);

			}
		}

		public double? Discount
		{
			/// <summary>The method to get the discount</summary>
			/// <returns>double? representing the discount</returns>
			get
			{
				if((( this.GetKeyValue("discount")) != (null)))
				{
					return (double?) this.GetKeyValue("discount");

				}
					return null;


			}
			/// <summary>The method to set the value to discount</summary>
			/// <param name="discount">double?</param>
			set
			{
				 this.AddKeyValue("discount", value);

			}
		}

		public double? FromRange
		{
			/// <summary>The method to get the fromRange</summary>
			/// <returns>double? representing the fromRange</returns>
			get
			{
				if((( this.GetKeyValue("from_range")) != (null)))
				{
					return (double?) this.GetKeyValue("from_range");

				}
					return null;


			}
			/// <summary>The method to set the value to fromRange</summary>
			/// <param name="fromRange">double?</param>
			set
			{
				 this.AddKeyValue("from_range", value);

			}
		}

		public long? Id
		{
			/// <summary>The method to get the id</summary>
			/// <returns>long? representing the id</returns>
			get
			{
				if((( this.GetKeyValue("id")) != (null)))
				{
					return (long?) this.GetKeyValue("id");

				}
					return null;


			}
			/// <summary>The method to set the value to id</summary>
			/// <param name="id">long?</param>
			set
			{
				 this.AddKeyValue("id", value);

			}
		}

		public Users.MinifiedUser CreatedBy
		{
			/// <summary>The method to get the createdBy</summary>
			/// <returns>Instance of MinifiedUser</returns>
			get
			{
				if((( this.GetKeyValue("Created_By")) != (null)))
				{
					return (Users.MinifiedUser) this.GetKeyValue("Created_By");

				}
					return null;


			}
			/// <summary>The method to set the value to createdBy</summary>
			/// <param name="createdBy">Instance of MinifiedUser</param>
			set
			{
				 this.AddKeyValue("Created_By", value);

			}
		}

		public DateTimeOffset? CreatedTime
		{
			/// <summary>The method to get the createdTime</summary>
			/// <returns>DateTimeOffset? representing the createdTime</returns>
			get
			{
				if((( this.GetKeyValue("Created_Time")) != (null)))
				{
					return (DateTimeOffset?) this.GetKeyValue("Created_Time");

				}
					return null;


			}
			/// <summary>The method to set the value to createdTime</summary>
			/// <param name="createdTime">DateTimeOffset?</param>
			set
			{
				 this.AddKeyValue("Created_Time", value);

			}
		}

		public Users.MinifiedUser ModifiedBy
		{
			/// <summary>The method to get the modifiedBy</summary>
			/// <returns>Instance of MinifiedUser</returns>
			get
			{
				if((( this.GetKeyValue("Modified_By")) != (null)))
				{
					return (Users.MinifiedUser) this.GetKeyValue("Modified_By");

				}
					return null;


			}
			/// <summary>The method to set the value to modifiedBy</summary>
			/// <param name="modifiedBy">Instance of MinifiedUser</param>
			set
			{
				 this.AddKeyValue("Modified_By", value);

			}
		}

		public DateTimeOffset? ModifiedTime
		{
			/// <summary>The method to get the modifiedTime</summary>
			/// <returns>DateTimeOffset? representing the modifiedTime</returns>
			get
			{
				if((( this.GetKeyValue("Modified_Time")) != (null)))
				{
					return (DateTimeOffset?) this.GetKeyValue("Modified_Time");

				}
					return null;


			}
			/// <summary>The method to set the value to modifiedTime</summary>
			/// <param name="modifiedTime">DateTimeOffset?</param>
			set
			{
				 this.AddKeyValue("Modified_Time", value);

			}
		}

		public List<Tags.Tag> Tag
		{
			/// <summary>The method to get the tag</summary>
			/// <returns>Instance of List<Tag></returns>
			get
			{
				if((( this.GetKeyValue("Tag")) != (null)))
				{
					return (List<Tags.Tag>) this.GetKeyValue("Tag");

				}
					return null;


			}
			/// <summary>The method to set the value to tag</summary>
			/// <param name="tag">Instance of List<Tag></param>
			set
			{
				 this.AddKeyValue("Tag", value);

			}
		}

		public string Name
		{
			/// <summary>The method to get the name</summary>
			/// <returns>string representing the name</returns>
			get
			{
				if((( this.GetKeyValue("name")) != (null)))
				{
					return (string) this.GetKeyValue("name");

				}
					return null;


			}
			/// <summary>The method to set the value to name</summary>
			/// <param name="name">string</param>
			set
			{
				 this.AddKeyValue("name", value);

			}
		}


	}
}