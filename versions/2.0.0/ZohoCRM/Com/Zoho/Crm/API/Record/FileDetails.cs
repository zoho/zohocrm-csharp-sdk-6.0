using Com.Zoho.Crm.API.Util;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.Record
{

	public class FileDetails : Model
	{
		private string fileNameS;
		private string sizeS;
		private long? id;
		private string fileIdS;
		private string delete;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public string FileNameS
		{
			/// <summary>The method to get the fileNameS</summary>
			/// <returns>string representing the fileNameS</returns>
			get
			{
				return  this.fileNameS;

			}
			/// <summary>The method to set the value to fileNameS</summary>
			/// <param name="fileNameS">string</param>
			set
			{
				 this.fileNameS=value;

				 this.keyModified["File_Name__s"] = 1;

			}
		}

		public string SizeS
		{
			/// <summary>The method to get the sizeS</summary>
			/// <returns>string representing the sizeS</returns>
			get
			{
				return  this.sizeS;

			}
			/// <summary>The method to set the value to sizeS</summary>
			/// <param name="sizeS">string</param>
			set
			{
				 this.sizeS=value;

				 this.keyModified["Size__s"] = 1;

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

		public string FileIdS
		{
			/// <summary>The method to get the fileIdS</summary>
			/// <returns>string representing the fileIdS</returns>
			get
			{
				return  this.fileIdS;

			}
			/// <summary>The method to set the value to fileIdS</summary>
			/// <param name="fileIdS">string</param>
			set
			{
				 this.fileIdS=value;

				 this.keyModified["File_Id__s"] = 1;

			}
		}

		public string Delete
		{
			/// <summary>The method to get the delete</summary>
			/// <returns>string representing the delete</returns>
			get
			{
				return  this.delete;

			}
			/// <summary>The method to set the value to delete</summary>
			/// <param name="delete">string</param>
			set
			{
				 this.delete=value;

				 this.keyModified["_delete"] = 1;

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