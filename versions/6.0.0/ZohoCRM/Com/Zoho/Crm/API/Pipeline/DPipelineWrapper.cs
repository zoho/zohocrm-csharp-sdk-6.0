using Com.Zoho.Crm.API.Util;
using System.Collections.Generic;

namespace Com.Zoho.Crm.API.Pipeline
{

	public class DPipelineWrapper : Model
	{
		private List<DPipeline> pipeline;
		private Dictionary<string, int?> keyModified=new Dictionary<string, int?>();

		public List<DPipeline> Pipeline
		{
			/// <summary>The method to get the pipeline</summary>
			/// <returns>Instance of List<DPipeline></returns>
			get
			{
				return  this.pipeline;

			}
			/// <summary>The method to set the value to pipeline</summary>
			/// <param name="pipeline">Instance of List<DPipeline></param>
			set
			{
				 this.pipeline=value;

				 this.keyModified["pipeline"] = 1;

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