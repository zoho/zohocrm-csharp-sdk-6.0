using System;
using System.Reflection;
using System.Collections.Generic;
using Com.Zoho.API.Authenticator;
using HeaderMap = Com.Zoho.Crm.API.HeaderMap;
using Initializer = Com.Zoho.Crm.API.Initializer;
using Environment = Com.Zoho.Crm.API.Dc.DataCenter.Environment;
using APIException = Com.Zoho.Crm.API.Record.APIException;
using ActionHandler = Com.Zoho.Crm.API.Record.ActionHandler;
using ActionResponse = Com.Zoho.Crm.API.Record.ActionResponse;
using ActionWrapper = Com.Zoho.Crm.API.Record.ActionWrapper;
using BodyWrapper = Com.Zoho.Crm.API.Record.BodyWrapper;
using Consent = Com.Zoho.Crm.API.Record.Consent;
using FileDetails = Com.Zoho.Crm.API.Record.FileDetails;
using LineItemProduct = Com.Zoho.Crm.API.Record.LineItemProduct;
using LineTax = Com.Zoho.Crm.API.Record.LineTax;
using RecordOperations = Com.Zoho.Crm.API.Record.RecordOperations;
using SuccessResponse = Com.Zoho.Crm.API.Record.SuccessResponse;
using Tag = Com.Zoho.Crm.API.Tags.Tag;
using Com.Zoho.Crm.API.Util;
using Com.Zoho.Crm.API.Dc;
using Newtonsoft.Json;


namespace Samples.Record.Updaterecords
{
	public class Quotes
	{
		public static void UpdateQuotes_1(string module)
		{
			RecordOperations recordOperations = new RecordOperations();
			BodyWrapper bodyWrapper = new BodyWrapper();
			List<Com.Zoho.Crm.API.Record.Record> records = new List<Com.Zoho.Crm.API.Record.Record>();
			Com.Zoho.Crm.API.Record.Record record1 =  new Com.Zoho.Crm.API.Record.Record();
			record1.Id = 322124347654l;
			Com.Zoho.Crm.API.Record.Record accountName =  new Com.Zoho.Crm.API.Record.Record();
			accountName.AddKeyValue("name", "automated");
	//		accountName.AddFieldValue(Field.Accounts.ID, 440248884001L);
			record1.AddFieldValue(Com.Zoho.Crm.API.Record.Quotes.ACCOUNT_NAME, accountName);
			record1.AddFieldValue(Com.Zoho.Crm.API.Record.Quotes.SUBJECT, "new quote");
			record1.AddFieldValue(Com.Zoho.Crm.API.Record.Quotes.ADJUSTMENT, 10.0);
			record1.AddFieldValue(Com.Zoho.Crm.API.Record.Quotes.VALID_TILL, new DateTime(2023, 12, 10).Date);
			record1.AddFieldValue(Com.Zoho.Crm.API.Record.Quotes.TEAM, "teamName");
			record1.AddFieldValue(Com.Zoho.Crm.API.Record.Quotes.TERMS_AND_CONDITIONS, "details of terms and conditions");
			record1.AddFieldValue(Com.Zoho.Crm.API.Record.Quotes.DESCRIPTION, "description");
			Com.Zoho.Crm.API.Record.Record dealName =  new Com.Zoho.Crm.API.Record.Record();
			dealName.AddFieldValue(Com.Zoho.Crm.API.Record.Deals.ID, 347706111383007l);
			record1.AddFieldValue(Com.Zoho.Crm.API.Record.Quotes.DEAL_NAME, dealName);
			Com.Zoho.Crm.API.Record.Record contactName =  new Com.Zoho.Crm.API.Record.Record();
			contactName.AddFieldValue(Com.Zoho.Crm.API.Record.Contacts.ID, 347706111853001l);
			record1.AddFieldValue(Com.Zoho.Crm.API.Record.Quotes.CONTACT_NAME, contactName);
			record1.AddFieldValue(Com.Zoho.Crm.API.Record.Quotes.QUOTE_STAGE, new Choice<string>("Draft"));
			record1.AddFieldValue(Com.Zoho.Crm.API.Record.Quotes.CARRIER, new Choice<string>("FedEX"));
			List<Com.Zoho.Crm.API.Record.Record> inventoryLineItemList = new List<Com.Zoho.Crm.API.Record.Record>();
			Com.Zoho.Crm.API.Record.Record inventoryLineItem =  new Com.Zoho.Crm.API.Record.Record();
			LineItemProduct lineItemProduct = new LineItemProduct();
			lineItemProduct.Id = 440248954344L;
	//		Com.Zoho.Crm.API.Record.Record data =  new Com.Zoho.Crm.API.Record.Record();
	//		data.Id = 440248954344L;
			inventoryLineItem.AddKeyValue("Description", "asd");
			inventoryLineItem.AddKeyValue("Discount", "5");
			inventoryLineItem.AddKeyValue("Quantity", 10.0);
			inventoryLineItem.AddKeyValue("List_Price", 100.0);
			inventoryLineItem.AddKeyValue("Product_Name", lineItemProduct);
	//		inventoryLineItem.AddKeyValue("Product_Category_1", "hardware");
			inventoryLineItemList.Add (inventoryLineItem);
			record1.AddFieldValue(Com.Zoho.Crm.API.Record.Quotes.QUOTED_ITEMS, inventoryLineItemList);
			List<LineTax> lineTaxes = new List<LineTax>();
			LineTax lineTax = new LineTax();
			lineTax.Name = "MyTax1134";
			lineTax.Percentage = 20.0;
			lineTaxes.Add (lineTax);
			record1.AddKeyValue("$line_tax", lineTaxes);
			// Address info
			record1.AddFieldValue(Com.Zoho.Crm.API.Record.Quotes.BILLING_CITY, "city");
			record1.AddFieldValue(Com.Zoho.Crm.API.Record.Quotes.BILLING_CODE, "12345");
			record1.AddFieldValue(Com.Zoho.Crm.API.Record.Quotes.BILLING_COUNTRY, "country");
			record1.AddFieldValue(Com.Zoho.Crm.API.Record.Quotes.BILLING_STATE, "state");
			record1.AddFieldValue(Com.Zoho.Crm.API.Record.Quotes.BILLING_STREET, "street");
			record1.AddFieldValue(Com.Zoho.Crm.API.Record.Quotes.SHIPPING_CITY, "shipping city");
			record1.AddFieldValue(Com.Zoho.Crm.API.Record.Quotes.SHIPPING_CODE, "shipping code");
			record1.AddFieldValue(Com.Zoho.Crm.API.Record.Quotes.SHIPPING_COUNTRY, "shipping country");
			record1.AddFieldValue(Com.Zoho.Crm.API.Record.Quotes.SHIPPING_STATE, "shipping state");
			record1.AddFieldValue(Com.Zoho.Crm.API.Record.Quotes.SHIPPING_STREET, "shipping street");
			// Used when GDPR is enabled
			Consent dataConsent = new Consent();
			dataConsent.ConsentRemarks = "Approved.";
			dataConsent.ConsentThrough = "Email";
			dataConsent.ContactThroughEmail = true;
			dataConsent.ContactThroughSocial = false;
			dataConsent.ContactThroughPhone = true;
			dataConsent.ContactThroughSurvey = true;
			dataConsent.ConsentDate = new DateTime(2023, 10, 11).Date;
			dataConsent.DataProcessingBasis = "Obtained";
			record1.AddKeyValue("Data_Processing_Basis_Details", dataConsent);
			// for MultiSelectLookUp/custom MultiSelectLookUp
			List<Com.Zoho.Crm.API.Record.Record> Multirecords = new List<Com.Zoho.Crm.API.Record.Record>();
			Com.Zoho.Crm.API.Record.Record record =  new Com.Zoho.Crm.API.Record.Record();
			Com.Zoho.Crm.API.Record.Record linkingRecord =  new Com.Zoho.Crm.API.Record.Record();
			record.AddKeyValue("id", 440248884001L);
			linkingRecord.AddKeyValue("Msl", record);
			Multirecords.Add (linkingRecord);
			record1.AddKeyValue("Msl", Multirecords);
			// for Custom Fields
			record1.AddKeyValue("External", "Value12345");
			record1.AddKeyValue("Custom_field", "Value");
			record1.AddKeyValue("Date_Time_2", new DateTimeOffset(new DateTime(2020, 05, 15, 12, 0, 0, DateTimeKind.Local)));
			record1.AddKeyValue("Date_1", new DateTime(2021, 1, 13).Date);
			record1.AddKeyValue("Subject", "AutomatedSDK");
			record1.AddKeyValue("Product_Name", "AutomatedSDK");
			List<FileDetails> fileDetails = new List<FileDetails>();
			FileDetails fileDetail1 = new FileDetails();
			fileDetail1.FileIdS = "ae9c7cefa418aa5cc2d9ab35c32a6ae23d729ad87c6d90b0bd44183d280";
			fileDetail1.Delete = null;
			fileDetails.Add (fileDetail1);
			FileDetails fileDetail2 = new FileDetails();
			fileDetail2.FileIdS = "ae9c7cefa418aec1d6a5cc2d9ab35c32e0063e7321b5b4ca34519e6cdb2";
			fileDetail2.Delete = null;
			fileDetails.Add (fileDetail2);
			record1.AddKeyValue("File_Upload", fileDetails);
			// for Custom User LookUp
			Com.Zoho.Crm.API.Users.MinifiedUser user =  new Com.Zoho.Crm.API.Users.MinifiedUser();
			user.Id = 440248254001L;
			record1.AddKeyValue("User_1", user);
			// for Custom LookUp
			Com.Zoho.Crm.API.Record.Record data =  new Com.Zoho.Crm.API.Record.Record();
			data.Id = 440248774074L;
			record1.AddKeyValue("Lookup_2", data);
			// for Custom pickList
			record1.AddKeyValue("pick", new Choice<string>("true"));
			// for Custom MultiSelect
			record1.AddKeyValue("Multiselect", new List<Choice<string>>() {new Choice<string>("Option 1"), new Choice<string>("Option 2") });
			// Subform sample code
			List<Com.Zoho.Crm.API.Record.Record> subformList = new List<Com.Zoho.Crm.API.Record.Record>();
			Com.Zoho.Crm.API.Record.Record subform =  new Com.Zoho.Crm.API.Record.Record();
			subform.AddKeyValue("customfield", "customvalue");
			Com.Zoho.Crm.API.Users.MinifiedUser user1 =  new Com.Zoho.Crm.API.Users.MinifiedUser();
			user1.Id = 440248254001L;
			subform.AddKeyValue("Userfield", user1);
			subformList.Add (subform);
			record1.AddKeyValue("Subform_2", subformList);
			// can update another record with same above mention fields
			Com.Zoho.Crm.API.Record.Record record2 =  new Com.Zoho.Crm.API.Record.Record();
			record2.Id = 35002303403L;
			List<Tag> tagList = new List<Tag>();
			Tag tag = new Tag();
			tag.Name = "Testtask";
			tagList.Add (tag);
			record1.Tag = tagList;
			// Add Record instance to the list
			records.Add (record1);
			bodyWrapper.Data = records;
			List<string> trigger = new List<string>();
			trigger.Add ("approval");
			trigger.Add ("workflow");
			trigger.Add ("blueprint");
			bodyWrapper.Trigger = trigger;
	//		bodyWrapper.LarId = "3477061087515";
			HeaderMap headerInstance = new HeaderMap();
	//		headerInstance.Add (CreateRecordsHeader.X_EXTERNAL, "Quotes.Quoted_Items.Product_Name.Products_External");
			APIResponse<ActionHandler> response = recordOperations.UpdateRecords(module, bodyWrapper, headerInstance);
			if (response != null)
			{
				Console.WriteLine ("Status Code: " + response.StatusCode);
				if (response.IsExpected)
				{
					ActionHandler actionHandler = response.Object;
					if (actionHandler is ActionWrapper)
					{
						ActionWrapper actionWrapper = (ActionWrapper) actionHandler;
						List<ActionResponse> actionResponses = actionWrapper.Data;
						foreach (ActionResponse actionResponse in actionResponses)
						{
							if (actionResponse is SuccessResponse)
							{
								SuccessResponse successResponse = (SuccessResponse) actionResponse;
								Console.WriteLine ("Status: " + successResponse.Status.Value);
								Console.WriteLine ("Code: " + successResponse.Code.Value);
								Console.WriteLine ("Details: ");
								foreach (KeyValuePair<string, object> entry in successResponse.Details)
								{
									Console.WriteLine (entry.Key + ": " + entry.Value);
								}
								Console.WriteLine ("Message: " + successResponse.Message.Value);
							}
							else if (actionResponse is APIException)
							{
								APIException exception = (APIException) actionResponse;
								Console.WriteLine ("Status: " + exception.Status.Value);
								Console.WriteLine ("Code: " + exception.Code.Value);
								Console.WriteLine ("Details: ");
								foreach (KeyValuePair<string, object> entry in exception.Details)
								{
									Console.WriteLine (entry.Key + ": " + entry.Value);
								}
								Console.WriteLine ("Message: " + exception.Message.Value);
							}
						}
					}
					else if (actionHandler is APIException)
					{
						APIException exception = (APIException) actionHandler;
						Console.WriteLine ("Status: " + exception.Status.Value);
						Console.WriteLine ("Code: " + exception.Code.Value);
						Console.WriteLine ("Details: ");
						foreach (KeyValuePair<string, object> entry in exception.Details)
						{
							Console.WriteLine (entry.Key + ": " + entry.Value);
						}
						Console.WriteLine ("Message: " + exception.Message.Value);
					}
				}
				else
				{
                    Model responseObject = response.Model;
                    Type type = responseObject.GetType();
                    Console.WriteLine("Type is : {0}", type.Name);
                    PropertyInfo[] props = type.GetProperties();
                    Console.WriteLine("Properties (N = {0}) :", props.Length);
                    foreach (var prop in props)
                    {
                        if (prop.GetIndexParameters().Length == 0)
                        {
                            Console.WriteLine("{0} ({1}) in {2}", prop.Name, prop.PropertyType.Name, prop.GetValue(responseObject));
                        }
                        else
                        {
                            Console.WriteLine("{0} ({1}) in <Indexed>", prop.Name, prop.PropertyType.Name);
                        }
                    }
				}
			}
		}
		public static void Call()
		{
			try
			{
				Environment environment = USDataCenter.PRODUCTION;
				IToken token = new OAuthToken.Builder().ClientId("Client_Id").ClientSecret("Client_Secret").RefreshToken("Refresh_Token").RedirectURL("Redirect_URL" ).Build();
				new Initializer.Builder().Environment(environment).Token(token).Initialize();
				string moduleAPIName = "Quotes";
                UpdateQuotes_1(moduleAPIName);
			}
			catch (Exception e)
			{
				Console.WriteLine(JsonConvert.SerializeObject(e));
			}
		}
	}
}