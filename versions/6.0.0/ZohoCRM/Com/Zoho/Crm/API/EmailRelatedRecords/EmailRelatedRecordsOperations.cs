using Com.Zoho.Crm.API;
using Com.Zoho.Crm.API.Util;

namespace Com.Zoho.Crm.API.EmailRelatedRecords
{

	public class EmailRelatedRecordsOperations
	{
		private string moduleName;
		private long? recordId;

		/// <summary>		/// Creates an instance of EmailRelatedRecordsOperations with the given parameters
		/// <param name="recordId">long?</param>
		/// <param name="moduleName">string</param>
		
		public EmailRelatedRecordsOperations(long? recordId, string moduleName)
		{
			 this.recordId=recordId;

			 this.moduleName=moduleName;


		}

		/// <summary>The method to get emails related records</summary>
		/// <param name="paramInstance">Instance of ParameterMap</param>
		/// <returns>Instance of APIResponse<ResponseHandler></returns>
		public APIResponse<ResponseHandler> GetEmailsRelatedRecords(ParameterMap paramInstance)
		{
			CommonAPIHandler handlerInstance=new CommonAPIHandler();

			string apiPath="";

			apiPath=string.Concat(apiPath, "/crm/v6/");

			apiPath=string.Concat(apiPath,  this.moduleName.ToString());

			apiPath=string.Concat(apiPath, "/");

			apiPath=string.Concat(apiPath,  this.recordId.ToString());

			apiPath=string.Concat(apiPath, "/Emails");

			handlerInstance.APIPath=apiPath;

			handlerInstance.HttpMethod=Constants.REQUEST_METHOD_GET;

			handlerInstance.CategoryMethod=Constants.REQUEST_CATEGORY_READ;

			handlerInstance.Param=paramInstance;

			return handlerInstance.APICall<ResponseHandler>(typeof(ResponseHandler), "application/json");


		}

		/// <summary>The method to get emails related record</summary>
		/// <param name="messageId">string</param>
		/// <returns>Instance of APIResponse<ResponseHandler></returns>
		public APIResponse<ResponseHandler> GetEmailsRelatedRecord(string messageId)
		{
			CommonAPIHandler handlerInstance=new CommonAPIHandler();

			string apiPath="";

			apiPath=string.Concat(apiPath, "/crm/v6/");

			apiPath=string.Concat(apiPath,  this.moduleName.ToString());

			apiPath=string.Concat(apiPath, "/");

			apiPath=string.Concat(apiPath,  this.recordId.ToString());

			apiPath=string.Concat(apiPath, "/Emails/");

			apiPath=string.Concat(apiPath, messageId.ToString());

			handlerInstance.APIPath=apiPath;

			handlerInstance.HttpMethod=Constants.REQUEST_METHOD_GET;

			handlerInstance.CategoryMethod=Constants.REQUEST_CATEGORY_READ;

			return handlerInstance.APICall<ResponseHandler>(typeof(ResponseHandler), "application/json");


		}


		public static class GetEmailsRelatedRecordsParam
		{
			public static readonly Param<Choice<string>> TYPE=new Param<Choice<string>>("type", "com.zoho.crm.api.EmailRelatedRecords.GetEmailsRelatedRecordsParam");
			public static readonly Param<Criteria> FILTER=new Param<Criteria>("filter", "com.zoho.crm.api.EmailRelatedRecords.GetEmailsRelatedRecordsParam");
			public static readonly Param<string> INDEX=new Param<string>("index", "com.zoho.crm.api.EmailRelatedRecords.GetEmailsRelatedRecordsParam");
			public static readonly Param<long?> OWNER_ID=new Param<long?>("owner_id", "com.zoho.crm.api.EmailRelatedRecords.GetEmailsRelatedRecordsParam");
		}

	}
}