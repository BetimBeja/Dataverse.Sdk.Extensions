﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dataverse.Sdk.Extensions.Tests.EarlyBoundEntities
{
    [System.Runtime.Serialization.DataContractAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "9.0.0.9369")]
    public enum LeadState
    {

        [System.Runtime.Serialization.EnumMemberAttribute()]
        Open = 0,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        Qualified = 1,

        [System.Runtime.Serialization.EnumMemberAttribute()]
        Disqualified = 2,
    }

    /// <summary>
    /// Prospect or potential sales opportunity. Leads are converted into accounts, contacts, or opportunities when they are qualified. Otherwise, they are deleted or archived.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("lead")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "9.0.0.9369")]
    public partial class Lead : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        public static class Fields
        {
            public const string AccountId = "accountid";
            public const string Address1_AddressId = "address1_addressid";
            public const string Address1_AddressTypeCode = "address1_addresstypecode";
            public const string Address1_City = "address1_city";
            public const string Address1_Composite = "address1_composite";
            public const string Address1_Country = "address1_country";
            public const string Address1_County = "address1_county";
            public const string Address1_Fax = "address1_fax";
            public const string Address1_Latitude = "address1_latitude";
            public const string Address1_Line1 = "address1_line1";
            public const string Address1_Line2 = "address1_line2";
            public const string Address1_Line3 = "address1_line3";
            public const string Address1_Longitude = "address1_longitude";
            public const string Address1_Name = "address1_name";
            public const string Address1_PostalCode = "address1_postalcode";
            public const string Address1_PostOfficeBox = "address1_postofficebox";
            public const string Address1_ShippingMethodCode = "address1_shippingmethodcode";
            public const string Address1_StateOrProvince = "address1_stateorprovince";
            public const string Address1_Telephone1 = "address1_telephone1";
            public const string Address1_Telephone2 = "address1_telephone2";
            public const string Address1_Telephone3 = "address1_telephone3";
            public const string Address1_UPSZone = "address1_upszone";
            public const string Address1_UTCOffset = "address1_utcoffset";
            public const string Address2_AddressId = "address2_addressid";
            public const string Address2_AddressTypeCode = "address2_addresstypecode";
            public const string Address2_City = "address2_city";
            public const string Address2_Composite = "address2_composite";
            public const string Address2_Country = "address2_country";
            public const string Address2_County = "address2_county";
            public const string Address2_Fax = "address2_fax";
            public const string Address2_Latitude = "address2_latitude";
            public const string Address2_Line1 = "address2_line1";
            public const string Address2_Line2 = "address2_line2";
            public const string Address2_Line3 = "address2_line3";
            public const string Address2_Longitude = "address2_longitude";
            public const string Address2_Name = "address2_name";
            public const string Address2_PostalCode = "address2_postalcode";
            public const string Address2_PostOfficeBox = "address2_postofficebox";
            public const string Address2_ShippingMethodCode = "address2_shippingmethodcode";
            public const string Address2_StateOrProvince = "address2_stateorprovince";
            public const string Address2_Telephone1 = "address2_telephone1";
            public const string Address2_Telephone2 = "address2_telephone2";
            public const string Address2_Telephone3 = "address2_telephone3";
            public const string Address2_UPSZone = "address2_upszone";
            public const string Address2_UTCOffset = "address2_utcoffset";
            public const string BudgetAmount = "budgetamount";
            public const string BudgetAmount_Base = "budgetamount_base";
            public const string BudgetStatus = "budgetstatus";
            public const string CampaignId = "campaignid";
            public const string CompanyName = "companyname";
            public const string ConfirmInterest = "confirminterest";
            public const string ContactId = "contactid";
            public const string CreatedBy = "createdby";
            public const string CreatedOn = "createdon";
            public const string CreatedOnBehalfBy = "createdonbehalfby";
            public const string CustomerId = "customerid";
            public const string DecisionMaker = "decisionmaker";
            public const string Description = "description";
            public const string DoNotBulkEMail = "donotbulkemail";
            public const string DoNotEMail = "donotemail";
            public const string DoNotFax = "donotfax";
            public const string DoNotPhone = "donotphone";
            public const string DoNotPostalMail = "donotpostalmail";
            public const string DoNotSendMM = "donotsendmm";
            public const string EMailAddress1 = "emailaddress1";
            public const string EMailAddress2 = "emailaddress2";
            public const string EMailAddress3 = "emailaddress3";
            public const string EntityImage = "entityimage";
            public const string EntityImage_Timestamp = "entityimage_timestamp";
            public const string EntityImage_URL = "entityimage_url";
            public const string EntityImageId = "entityimageid";
            public const string EstimatedAmount = "estimatedamount";
            public const string EstimatedAmount_Base = "estimatedamount_base";
            public const string EstimatedCloseDate = "estimatedclosedate";
            public const string EstimatedValue = "estimatedvalue";
            public const string EvaluateFit = "evaluatefit";
            public const string ExchangeRate = "exchangerate";
            public const string Fax = "fax";
            public const string FirstName = "firstname";
            public const string FollowEmail = "followemail";
            public const string FullName = "fullname";
            public const string ImportSequenceNumber = "importsequencenumber";
            public const string IndustryCode = "industrycode";
            public const string InitialCommunication = "initialcommunication";
            public const string JobTitle = "jobtitle";
            public const string LastName = "lastname";
            public const string LastOnHoldTime = "lastonholdtime";
            public const string LastUsedInCampaign = "lastusedincampaign";
            public const string LeadId = "leadid";
            public const string Id = "leadid";
            public const string LeadQualityCode = "leadqualitycode";
            public const string LeadSourceCode = "leadsourcecode";
            public const string MasterId = "masterid";
            public const string Merged = "merged";
            public const string MiddleName = "middlename";
            public const string MobilePhone = "mobilephone";
            public const string ModifiedBy = "modifiedby";
            public const string ModifiedOn = "modifiedon";
            public const string ModifiedOnBehalfBy = "modifiedonbehalfby";
            public const string msdyn_gdproptout = "msdyn_gdproptout";
            public const string msdyn_ordertype = "msdyn_ordertype";
            public const string Need = "need";
            public const string NumberOfEmployees = "numberofemployees";
            public const string OnHoldTime = "onholdtime";
            public const string OriginatingCaseId = "originatingcaseid";
            public const string OverriddenCreatedOn = "overriddencreatedon";
            public const string OwnerId = "ownerid";
            public const string OwningBusinessUnit = "owningbusinessunit";
            public const string OwningTeam = "owningteam";
            public const string OwningUser = "owninguser";
            public const string Pager = "pager";
            public const string ParentAccountId = "parentaccountid";
            public const string ParentContactId = "parentcontactid";
            public const string ParticipatesInWorkflow = "participatesinworkflow";
            public const string PreferredContactMethodCode = "preferredcontactmethodcode";
            public const string PriorityCode = "prioritycode";
            public const string ProcessId = "processid";
            public const string PurchaseProcess = "purchaseprocess";
            public const string PurchaseTimeFrame = "purchasetimeframe";
            public const string QualificationComments = "qualificationcomments";
            public const string QualifyingOpportunityId = "qualifyingopportunityid";
            public const string RelatedObjectId = "relatedobjectid";
            public const string Revenue = "revenue";
            public const string Revenue_Base = "revenue_base";
            public const string SalesStage = "salesstage";
            public const string SalesStageCode = "salesstagecode";
            public const string Salutation = "salutation";
            public const string ScheduleFollowUp_Prospect = "schedulefollowup_prospect";
            public const string ScheduleFollowUp_Qualify = "schedulefollowup_qualify";
            public const string SIC = "sic";
            public const string SLAId = "slaid";
            public const string SLAInvokedId = "slainvokedid";
            public const string StageId = "stageid";
            public const string StateCode = "statecode";
            public const string StatusCode = "statuscode";
            public const string Subject = "subject";
            public const string TeamsFollowed = "teamsfollowed";
            public const string Telephone1 = "telephone1";
            public const string Telephone2 = "telephone2";
            public const string Telephone3 = "telephone3";
            public const string TimeSpentByMeOnEmailAndMeetings = "timespentbymeonemailandmeetings";
            public const string TimeZoneRuleVersionNumber = "timezoneruleversionnumber";
            public const string TransactionCurrencyId = "transactioncurrencyid";
            public const string TraversedPath = "traversedpath";
            public const string UTCConversionTimeZoneCode = "utcconversiontimezonecode";
            public const string VersionNumber = "versionnumber";
            public const string WebSiteUrl = "websiteurl";
            public const string YomiCompanyName = "yomicompanyname";
            public const string YomiFirstName = "yomifirstname";
            public const string YomiFullName = "yomifullname";
            public const string YomiLastName = "yomilastname";
            public const string YomiMiddleName = "yomimiddlename";
            public const string business_unit_leads = "business_unit_leads";
            public const string campaign_leads = "campaign_leads";
            public const string CampaignResponse_Lead = "CampaignResponse_Lead";
            public const string lead_customer_accounts = "lead_customer_accounts";
            public const string lead_customer_contacts = "lead_customer_contacts";
            public const string Referencinglead_master_lead = "lead_master_lead";
            public const string lead_owning_team = "lead_owning_team";
            public const string lead_owning_user = "lead_owning_user";
            public const string lead_parent_account = "lead_parent_account";
            public const string lead_parent_contact = "lead_parent_contact";
            public const string lead_qualifying_opportunity = "lead_qualifying_opportunity";
            public const string lk_lead_createdonbehalfby = "lk_lead_createdonbehalfby";
            public const string lk_lead_modifiedonbehalfby = "lk_lead_modifiedonbehalfby";
            public const string lk_leadbase_createdby = "lk_leadbase_createdby";
            public const string lk_leadbase_modifiedby = "lk_leadbase_modifiedby";
            public const string manualsla_lead = "manualsla_lead";
            public const string OriginatingCase_Lead = "OriginatingCase_Lead";
            public const string processstage_lead = "processstage_lead";
            public const string sla_lead = "sla_lead";
            public const string transactioncurrency_lead = "transactioncurrency_lead";
        }

        /// <summary>
        /// Default Constructor.
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCode()]
        public Lead() :
            base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "lead";

        public const string PrimaryIdAttribute = "leadid";

        public const string PrimaryNameAttribute = "fullname";

        public const int EntityTypeCode = 4;

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;

        [System.Diagnostics.DebuggerNonUserCode()]
        private void OnPropertyChanged(string propertyName)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }

        [System.Diagnostics.DebuggerNonUserCode()]
        private void OnPropertyChanging(string propertyName)
        {
            if ((this.PropertyChanging != null))
            {
                this.PropertyChanging(this, new System.ComponentModel.PropertyChangingEventArgs(propertyName));
            }
        }

        /// <summary>
        /// Unique identifier of the account with which the lead is associated.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("accountid")]
        public Microsoft.Xrm.Sdk.EntityReference AccountId
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("accountid"); }
        }

        /// <summary>
        /// Unique identifier for address 1.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_addressid")]
        public System.Nullable<System.Guid> Address1_AddressId
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("address1_addressid"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Address1_AddressId");
                this.SetAttributeValue("address1_addressid", value);
                this.OnPropertyChanged("Address1_AddressId");
            }
        }

        /// <summary>
        /// Select the primary address type.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_addresstypecode")]
        public Microsoft.Xrm.Sdk.OptionSetValue Address1_AddressTypeCode
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("address1_addresstypecode"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Address1_AddressTypeCode");
                this.SetAttributeValue("address1_addresstypecode", value);
                this.OnPropertyChanged("Address1_AddressTypeCode");
            }
        }

        /// <summary>
        /// Type the city for the primary address.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_city")]
        public string Address1_City
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<string>("address1_city"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Address1_City");
                this.SetAttributeValue("address1_city", value);
                this.OnPropertyChanged("Address1_City");
            }
        }

        /// <summary>
        /// Shows the complete primary address.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_composite")]
        public string Address1_Composite
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<string>("address1_composite"); }
        }

        /// <summary>
        /// Type the country or region for the primary address.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_country")]
        public string Address1_Country
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<string>("address1_country"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Address1_Country");
                this.SetAttributeValue("address1_country", value);
                this.OnPropertyChanged("Address1_Country");
            }
        }

        /// <summary>
        /// Type the county for the primary address.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_county")]
        public string Address1_County
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<string>("address1_county"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Address1_County");
                this.SetAttributeValue("address1_county", value);
                this.OnPropertyChanged("Address1_County");
            }
        }

        /// <summary>
        /// Type the fax number associated with the primary address.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_fax")]
        public string Address1_Fax
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<string>("address1_fax"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Address1_Fax");
                this.SetAttributeValue("address1_fax", value);
                this.OnPropertyChanged("Address1_Fax");
            }
        }

        /// <summary>
        /// Type the latitude value for the primary address for use in mapping and other applications.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_latitude")]
        public System.Nullable<double> Address1_Latitude
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<System.Nullable<double>>("address1_latitude"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Address1_Latitude");
                this.SetAttributeValue("address1_latitude", value);
                this.OnPropertyChanged("Address1_Latitude");
            }
        }

        /// <summary>
        /// Type the first line of the primary address.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_line1")]
        public string Address1_Line1
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<string>("address1_line1"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Address1_Line1");
                this.SetAttributeValue("address1_line1", value);
                this.OnPropertyChanged("Address1_Line1");
            }
        }

        /// <summary>
        /// Type the second line of the primary address.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_line2")]
        public string Address1_Line2
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<string>("address1_line2"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Address1_Line2");
                this.SetAttributeValue("address1_line2", value);
                this.OnPropertyChanged("Address1_Line2");
            }
        }

        /// <summary>
        /// Type the third line of the primary address.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_line3")]
        public string Address1_Line3
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<string>("address1_line3"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Address1_Line3");
                this.SetAttributeValue("address1_line3", value);
                this.OnPropertyChanged("Address1_Line3");
            }
        }

        /// <summary>
        /// Type the longitude value for the primary address for use in mapping and other applications.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_longitude")]
        public System.Nullable<double> Address1_Longitude
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<System.Nullable<double>>("address1_longitude"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Address1_Longitude");
                this.SetAttributeValue("address1_longitude", value);
                this.OnPropertyChanged("Address1_Longitude");
            }
        }

        /// <summary>
        /// Type a descriptive name for the primary address, such as Corporate Headquarters.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_name")]
        public string Address1_Name
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<string>("address1_name"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Address1_Name");
                this.SetAttributeValue("address1_name", value);
                this.OnPropertyChanged("Address1_Name");
            }
        }

        /// <summary>
        /// Type the ZIP Code or postal code for the primary address.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_postalcode")]
        public string Address1_PostalCode
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<string>("address1_postalcode"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Address1_PostalCode");
                this.SetAttributeValue("address1_postalcode", value);
                this.OnPropertyChanged("Address1_PostalCode");
            }
        }

        /// <summary>
        /// Type the post office box number of the primary address.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_postofficebox")]
        public string Address1_PostOfficeBox
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<string>("address1_postofficebox"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Address1_PostOfficeBox");
                this.SetAttributeValue("address1_postofficebox", value);
                this.OnPropertyChanged("Address1_PostOfficeBox");
            }
        }

        /// <summary>
        /// Select a shipping method for deliveries sent to this address.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_shippingmethodcode")]
        public Microsoft.Xrm.Sdk.OptionSetValue Address1_ShippingMethodCode
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("address1_shippingmethodcode"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Address1_ShippingMethodCode");
                this.SetAttributeValue("address1_shippingmethodcode", value);
                this.OnPropertyChanged("Address1_ShippingMethodCode");
            }
        }

        /// <summary>
        /// Type the state or province of the primary address.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_stateorprovince")]
        public string Address1_StateOrProvince
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<string>("address1_stateorprovince"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Address1_StateOrProvince");
                this.SetAttributeValue("address1_stateorprovince", value);
                this.OnPropertyChanged("Address1_StateOrProvince");
            }
        }

        /// <summary>
        /// Type the main phone number associated with the primary address.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_telephone1")]
        public string Address1_Telephone1
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<string>("address1_telephone1"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Address1_Telephone1");
                this.SetAttributeValue("address1_telephone1", value);
                this.OnPropertyChanged("Address1_Telephone1");
            }
        }

        /// <summary>
        /// Type a second phone number associated with the primary address.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_telephone2")]
        public string Address1_Telephone2
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<string>("address1_telephone2"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Address1_Telephone2");
                this.SetAttributeValue("address1_telephone2", value);
                this.OnPropertyChanged("Address1_Telephone2");
            }
        }

        /// <summary>
        /// Type a third phone number associated with the primary address.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_telephone3")]
        public string Address1_Telephone3
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<string>("address1_telephone3"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Address1_Telephone3");
                this.SetAttributeValue("address1_telephone3", value);
                this.OnPropertyChanged("Address1_Telephone3");
            }
        }

        /// <summary>
        /// Type the UPS zone of the primary address to make sure shipping charges are calculated correctly and deliveries are made promptly, if shipped by UPS.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_upszone")]
        public string Address1_UPSZone
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<string>("address1_upszone"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Address1_UPSZone");
                this.SetAttributeValue("address1_upszone", value);
                this.OnPropertyChanged("Address1_UPSZone");
            }
        }

        /// <summary>
        /// Select the time zone, or UTC offset, for this address so that other people can reference it when they contact someone at this address.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_utcoffset")]
        public System.Nullable<int> Address1_UTCOffset
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<System.Nullable<int>>("address1_utcoffset"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Address1_UTCOffset");
                this.SetAttributeValue("address1_utcoffset", value);
                this.OnPropertyChanged("Address1_UTCOffset");
            }
        }

        /// <summary>
        /// Unique identifier for address 2.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_addressid")]
        public System.Nullable<System.Guid> Address2_AddressId
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("address2_addressid"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Address2_AddressId");
                this.SetAttributeValue("address2_addressid", value);
                this.OnPropertyChanged("Address2_AddressId");
            }
        }

        /// <summary>
        /// Select the secondary address type.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_addresstypecode")]
        public Microsoft.Xrm.Sdk.OptionSetValue Address2_AddressTypeCode
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("address2_addresstypecode"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Address2_AddressTypeCode");
                this.SetAttributeValue("address2_addresstypecode", value);
                this.OnPropertyChanged("Address2_AddressTypeCode");
            }
        }

        /// <summary>
        /// Type the city for the secondary address.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_city")]
        public string Address2_City
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<string>("address2_city"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Address2_City");
                this.SetAttributeValue("address2_city", value);
                this.OnPropertyChanged("Address2_City");
            }
        }

        /// <summary>
        /// Shows the complete secondary address.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_composite")]
        public string Address2_Composite
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<string>("address2_composite"); }
        }

        /// <summary>
        /// Type the country or region for the secondary address.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_country")]
        public string Address2_Country
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<string>("address2_country"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Address2_Country");
                this.SetAttributeValue("address2_country", value);
                this.OnPropertyChanged("Address2_Country");
            }
        }

        /// <summary>
        /// Type the county for the secondary address.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_county")]
        public string Address2_County
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<string>("address2_county"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Address2_County");
                this.SetAttributeValue("address2_county", value);
                this.OnPropertyChanged("Address2_County");
            }
        }

        /// <summary>
        /// Type the fax number associated with the secondary address.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_fax")]
        public string Address2_Fax
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<string>("address2_fax"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Address2_Fax");
                this.SetAttributeValue("address2_fax", value);
                this.OnPropertyChanged("Address2_Fax");
            }
        }

        /// <summary>
        /// Type the latitude value for the secondary address for use in mapping and other applications.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_latitude")]
        public System.Nullable<double> Address2_Latitude
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<System.Nullable<double>>("address2_latitude"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Address2_Latitude");
                this.SetAttributeValue("address2_latitude", value);
                this.OnPropertyChanged("Address2_Latitude");
            }
        }

        /// <summary>
        /// Type the first line of the secondary address.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_line1")]
        public string Address2_Line1
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<string>("address2_line1"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Address2_Line1");
                this.SetAttributeValue("address2_line1", value);
                this.OnPropertyChanged("Address2_Line1");
            }
        }

        /// <summary>
        /// Type the second line of the secondary address.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_line2")]
        public string Address2_Line2
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<string>("address2_line2"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Address2_Line2");
                this.SetAttributeValue("address2_line2", value);
                this.OnPropertyChanged("Address2_Line2");
            }
        }

        /// <summary>
        /// Type the third line of the secondary address.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_line3")]
        public string Address2_Line3
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<string>("address2_line3"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Address2_Line3");
                this.SetAttributeValue("address2_line3", value);
                this.OnPropertyChanged("Address2_Line3");
            }
        }

        /// <summary>
        /// Type the longitude value for the secondary address for use in mapping and other applications.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_longitude")]
        public System.Nullable<double> Address2_Longitude
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<System.Nullable<double>>("address2_longitude"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Address2_Longitude");
                this.SetAttributeValue("address2_longitude", value);
                this.OnPropertyChanged("Address2_Longitude");
            }
        }

        /// <summary>
        /// Type a descriptive name for the secondary address, such as Corporate Headquarters.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_name")]
        public string Address2_Name
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<string>("address2_name"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Address2_Name");
                this.SetAttributeValue("address2_name", value);
                this.OnPropertyChanged("Address2_Name");
            }
        }

        /// <summary>
        /// Type the ZIP Code or postal code for the secondary address.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_postalcode")]
        public string Address2_PostalCode
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<string>("address2_postalcode"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Address2_PostalCode");
                this.SetAttributeValue("address2_postalcode", value);
                this.OnPropertyChanged("Address2_PostalCode");
            }
        }

        /// <summary>
        /// Type the post office box number of the secondary address.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_postofficebox")]
        public string Address2_PostOfficeBox
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<string>("address2_postofficebox"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Address2_PostOfficeBox");
                this.SetAttributeValue("address2_postofficebox", value);
                this.OnPropertyChanged("Address2_PostOfficeBox");
            }
        }

        /// <summary>
        /// Select a shipping method for deliveries sent to this address.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_shippingmethodcode")]
        public Microsoft.Xrm.Sdk.OptionSetValue Address2_ShippingMethodCode
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("address2_shippingmethodcode"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Address2_ShippingMethodCode");
                this.SetAttributeValue("address2_shippingmethodcode", value);
                this.OnPropertyChanged("Address2_ShippingMethodCode");
            }
        }

        /// <summary>
        /// Type the state or province of the secondary address.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_stateorprovince")]
        public string Address2_StateOrProvince
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<string>("address2_stateorprovince"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Address2_StateOrProvince");
                this.SetAttributeValue("address2_stateorprovince", value);
                this.OnPropertyChanged("Address2_StateOrProvince");
            }
        }

        /// <summary>
        /// Type the main phone number associated with the secondary address.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_telephone1")]
        public string Address2_Telephone1
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<string>("address2_telephone1"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Address2_Telephone1");
                this.SetAttributeValue("address2_telephone1", value);
                this.OnPropertyChanged("Address2_Telephone1");
            }
        }

        /// <summary>
        /// Type a second phone number associated with the secondary address.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_telephone2")]
        public string Address2_Telephone2
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<string>("address2_telephone2"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Address2_Telephone2");
                this.SetAttributeValue("address2_telephone2", value);
                this.OnPropertyChanged("Address2_Telephone2");
            }
        }

        /// <summary>
        /// Type a third phone number associated with the secondary address.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_telephone3")]
        public string Address2_Telephone3
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<string>("address2_telephone3"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Address2_Telephone3");
                this.SetAttributeValue("address2_telephone3", value);
                this.OnPropertyChanged("Address2_Telephone3");
            }
        }

        /// <summary>
        /// Type the UPS zone of the secondary address to make sure shipping charges are calculated correctly and deliveries are made promptly, if shipped by UPS.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_upszone")]
        public string Address2_UPSZone
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<string>("address2_upszone"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Address2_UPSZone");
                this.SetAttributeValue("address2_upszone", value);
                this.OnPropertyChanged("Address2_UPSZone");
            }
        }

        /// <summary>
        /// Select the time zone, or UTC offset, for this address so that other people can reference it when they contact someone at this address.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_utcoffset")]
        public System.Nullable<int> Address2_UTCOffset
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<System.Nullable<int>>("address2_utcoffset"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Address2_UTCOffset");
                this.SetAttributeValue("address2_utcoffset", value);
                this.OnPropertyChanged("Address2_UTCOffset");
            }
        }

        /// <summary>
        /// Information about the budget amount of the lead's company or organization.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("budgetamount")]
        public Microsoft.Xrm.Sdk.Money BudgetAmount
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("budgetamount"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("BudgetAmount");
                this.SetAttributeValue("budgetamount", value);
                this.OnPropertyChanged("BudgetAmount");
            }
        }

        /// <summary>
        /// Base currency equivalent of the estimated budget of the lead.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("budgetamount_base")]
        public Microsoft.Xrm.Sdk.Money BudgetAmount_Base
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("budgetamount_base"); }
        }

        /// <summary>
        /// Information about the budget status of the lead's company or organization.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("budgetstatus")]
        public Microsoft.Xrm.Sdk.OptionSetValue BudgetStatus
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("budgetstatus"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("BudgetStatus");
                this.SetAttributeValue("budgetstatus", value);
                this.OnPropertyChanged("BudgetStatus");
            }
        }

        /// <summary>
        /// campaign_leads
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("campaignid")]
        public Microsoft.Xrm.Sdk.EntityReference CampaignId
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("campaignid"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("CampaignId");
                this.SetAttributeValue("campaignid", value);
                this.OnPropertyChanged("CampaignId");
            }
        }

        /// <summary>
        /// Type the name of the company associated with the lead. This becomes the account name when the lead is qualified and converted to a customer account.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("companyname")]
        public string CompanyName
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<string>("companyname"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("CompanyName");
                this.SetAttributeValue("companyname", value);
                this.OnPropertyChanged("CompanyName");
            }
        }

        /// <summary>
        /// Select whether the lead confirmed interest in your offerings. This helps in determining the lead quality.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("confirminterest")]
        public System.Nullable<bool> ConfirmInterest
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<System.Nullable<bool>>("confirminterest"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("ConfirmInterest");
                this.SetAttributeValue("confirminterest", value);
                this.OnPropertyChanged("ConfirmInterest");
            }
        }

        /// <summary>
        /// Unique identifier of the contact with which the lead is associated.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("contactid")]
        public Microsoft.Xrm.Sdk.EntityReference ContactId
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("contactid"); }
        }

        /// <summary>
        /// Shows who created the record.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        public Microsoft.Xrm.Sdk.EntityReference CreatedBy
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdby"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("CreatedBy");
                this.SetAttributeValue("createdby", value);
                this.OnPropertyChanged("CreatedBy");
            }
        }

        /// <summary>
        /// Shows the date and time when the record was created. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdon")]
        public System.Nullable<System.DateTime> CreatedOn
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("createdon"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("CreatedOn");
                this.SetAttributeValue("createdon", value);
                this.OnPropertyChanged("CreatedOn");
            }
        }

        /// <summary>
        /// lk_lead_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        public Microsoft.Xrm.Sdk.EntityReference CreatedOnBehalfBy
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdonbehalfby"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("CreatedOnBehalfBy");
                this.SetAttributeValue("createdonbehalfby", value);
                this.OnPropertyChanged("CreatedOnBehalfBy");
            }
        }

        /// <summary>
        /// lead_customer_contacts
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("customerid")]
        public Microsoft.Xrm.Sdk.EntityReference CustomerId
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("customerid"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("CustomerId");
                this.SetAttributeValue("customerid", value);
                this.OnPropertyChanged("CustomerId");
            }
        }

        /// <summary>
        /// Select whether your notes include information about who makes the purchase decisions at the lead's company.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("decisionmaker")]
        public System.Nullable<bool> DecisionMaker
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<System.Nullable<bool>>("decisionmaker"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("DecisionMaker");
                this.SetAttributeValue("decisionmaker", value);
                this.OnPropertyChanged("DecisionMaker");
            }
        }

        /// <summary>
        /// Type additional information to describe the lead, such as an excerpt from the company's website.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("description")]
        public string Description
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<string>("description"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Description");
                this.SetAttributeValue("description", value);
                this.OnPropertyChanged("Description");
            }
        }

        /// <summary>
        /// Select whether the lead accepts bulk email sent through marketing campaigns or quick campaigns. If Do Not Allow is selected, the lead can be added to marketing lists, but will be excluded from the email.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("donotbulkemail")]
        public System.Nullable<bool> DoNotBulkEMail
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<System.Nullable<bool>>("donotbulkemail"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("DoNotBulkEMail");
                this.SetAttributeValue("donotbulkemail", value);
                this.OnPropertyChanged("DoNotBulkEMail");
            }
        }

        /// <summary>
        /// Select whether the lead allows direct email sent from Microsoft Dynamics 365.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("donotemail")]
        public System.Nullable<bool> DoNotEMail
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<System.Nullable<bool>>("donotemail"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("DoNotEMail");
                this.SetAttributeValue("donotemail", value);
                this.OnPropertyChanged("DoNotEMail");
            }
        }

        /// <summary>
        /// Select whether the lead allows faxes.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("donotfax")]
        public System.Nullable<bool> DoNotFax
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<System.Nullable<bool>>("donotfax"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("DoNotFax");
                this.SetAttributeValue("donotfax", value);
                this.OnPropertyChanged("DoNotFax");
            }
        }

        /// <summary>
        /// Select whether the lead allows phone calls.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("donotphone")]
        public System.Nullable<bool> DoNotPhone
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<System.Nullable<bool>>("donotphone"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("DoNotPhone");
                this.SetAttributeValue("donotphone", value);
                this.OnPropertyChanged("DoNotPhone");
            }
        }

        /// <summary>
        /// Select whether the lead allows direct mail.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("donotpostalmail")]
        public System.Nullable<bool> DoNotPostalMail
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<System.Nullable<bool>>("donotpostalmail"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("DoNotPostalMail");
                this.SetAttributeValue("donotpostalmail", value);
                this.OnPropertyChanged("DoNotPostalMail");
            }
        }

        /// <summary>
        /// Select whether the lead accepts marketing materials, such as brochures or catalogs. Leads that opt out can be excluded from marketing initiatives.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("donotsendmm")]
        public System.Nullable<bool> DoNotSendMM
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<System.Nullable<bool>>("donotsendmm"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("DoNotSendMM");
                this.SetAttributeValue("donotsendmm", value);
                this.OnPropertyChanged("DoNotSendMM");
            }
        }

        /// <summary>
        /// Type the primary email address for the lead.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("emailaddress1")]
        public string EMailAddress1
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<string>("emailaddress1"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("EMailAddress1");
                this.SetAttributeValue("emailaddress1", value);
                this.OnPropertyChanged("EMailAddress1");
            }
        }

        /// <summary>
        /// Type the secondary email address for the lead.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("emailaddress2")]
        public string EMailAddress2
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<string>("emailaddress2"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("EMailAddress2");
                this.SetAttributeValue("emailaddress2", value);
                this.OnPropertyChanged("EMailAddress2");
            }
        }

        /// <summary>
        /// Type a third email address for the lead.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("emailaddress3")]
        public string EMailAddress3
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<string>("emailaddress3"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("EMailAddress3");
                this.SetAttributeValue("emailaddress3", value);
                this.OnPropertyChanged("EMailAddress3");
            }
        }

        /// <summary>
        /// Shows the default image for the record.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("entityimage")]
        public byte[] EntityImage
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<byte[]>("entityimage"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("EntityImage");
                this.SetAttributeValue("entityimage", value);
                this.OnPropertyChanged("EntityImage");
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("entityimage_timestamp")]
        public System.Nullable<long> EntityImage_Timestamp
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<System.Nullable<long>>("entityimage_timestamp"); }
        }

        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("entityimage_url")]
        public string EntityImage_URL
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<string>("entityimage_url"); }
        }

        /// <summary>
        /// For internal use only.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("entityimageid")]
        public System.Nullable<System.Guid> EntityImageId
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("entityimageid"); }
        }

        /// <summary>
        /// Type the estimated revenue value that this lead will generate to assist in sales forecasting and planning.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("estimatedamount")]
        public Microsoft.Xrm.Sdk.Money EstimatedAmount
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("estimatedamount"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("EstimatedAmount");
                this.SetAttributeValue("estimatedamount", value);
                this.OnPropertyChanged("EstimatedAmount");
            }
        }

        /// <summary>
        /// Shows the Est. Value field converted to the system's default base currency. The calculation uses the exchange rate specified in the Currencies area.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("estimatedamount_base")]
        public Microsoft.Xrm.Sdk.Money EstimatedAmount_Base
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("estimatedamount_base"); }
        }

        /// <summary>
        /// Enter the expected close date for the lead, so that the sales team can schedule timely follow-up meetings to move the prospect to the next sales stage.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("estimatedclosedate")]
        public System.Nullable<System.DateTime> EstimatedCloseDate
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("estimatedclosedate"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("EstimatedCloseDate");
                this.SetAttributeValue("estimatedclosedate", value);
                this.OnPropertyChanged("EstimatedCloseDate");
            }
        }

        /// <summary>
        /// Type a numeric value of the lead's estimated value, such as a product quantity, if no revenue amount can be specified in the Est. Value field. This can be used for sales forecasting and planning.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("estimatedvalue")]
        public System.Nullable<double> EstimatedValue
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<System.Nullable<double>>("estimatedvalue"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("EstimatedValue");
                this.SetAttributeValue("estimatedvalue", value);
                this.OnPropertyChanged("EstimatedValue");
            }
        }

        /// <summary>
        /// Select whether the fit between the lead's requirements and your offerings was evaluated.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("evaluatefit")]
        public System.Nullable<bool> EvaluateFit
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<System.Nullable<bool>>("evaluatefit"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("EvaluateFit");
                this.SetAttributeValue("evaluatefit", value);
                this.OnPropertyChanged("EvaluateFit");
            }
        }

        /// <summary>
        /// Shows the conversion rate of the record's currency. The exchange rate is used to convert all money fields in the record from the local currency to the system's default currency.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("exchangerate")]
        public System.Nullable<decimal> ExchangeRate
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<System.Nullable<decimal>>("exchangerate"); }
        }

        /// <summary>
        /// Type the fax number for the primary contact for the lead.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("fax")]
        public string Fax
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<string>("fax"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Fax");
                this.SetAttributeValue("fax", value);
                this.OnPropertyChanged("Fax");
            }
        }

        /// <summary>
        /// Type the first name of the primary contact for the lead to make sure the prospect is addressed correctly in sales calls, email, and marketing campaigns.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("firstname")]
        public string FirstName
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<string>("firstname"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("FirstName");
                this.SetAttributeValue("firstname", value);
                this.OnPropertyChanged("FirstName");
            }
        }

        /// <summary>
        /// Information about whether to allow following email activity like opens, attachment views and link clicks for emails sent to the lead.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("followemail")]
        public System.Nullable<bool> FollowEmail
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<System.Nullable<bool>>("followemail"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("FollowEmail");
                this.SetAttributeValue("followemail", value);
                this.OnPropertyChanged("FollowEmail");
            }
        }

        /// <summary>
        /// Combines and shows the lead's first and last names so the full name can be displayed in views and reports.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("fullname")]
        public string FullName
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<string>("fullname"); }
        }

        /// <summary>
        /// Unique identifier of the data import or data migration that created this record.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("importsequencenumber")]
        public System.Nullable<int> ImportSequenceNumber
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<System.Nullable<int>>("importsequencenumber"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("ImportSequenceNumber");
                this.SetAttributeValue("importsequencenumber", value);
                this.OnPropertyChanged("ImportSequenceNumber");
            }
        }

        /// <summary>
        /// Select the primary industry in which the lead's business is focused, for use in marketing segmentation and demographic analysis.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("industrycode")]
        public Microsoft.Xrm.Sdk.OptionSetValue IndustryCode
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("industrycode"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("IndustryCode");
                this.SetAttributeValue("industrycode", value);
                this.OnPropertyChanged("IndustryCode");
            }
        }

        /// <summary>
        /// Choose whether someone from the sales team contacted this lead earlier.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("initialcommunication")]
        public Microsoft.Xrm.Sdk.OptionSetValue InitialCommunication
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("initialcommunication"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("InitialCommunication");
                this.SetAttributeValue("initialcommunication", value);
                this.OnPropertyChanged("InitialCommunication");
            }
        }

        /// <summary>
        /// Type the job title of the primary contact for this lead to make sure the prospect is addressed correctly in sales calls, email, and marketing campaigns.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("jobtitle")]
        public string JobTitle
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<string>("jobtitle"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("JobTitle");
                this.SetAttributeValue("jobtitle", value);
                this.OnPropertyChanged("JobTitle");
            }
        }

        /// <summary>
        /// Type the last name of the primary contact for the lead to make sure the prospect is addressed correctly in sales calls, email, and marketing campaigns.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("lastname")]
        public string LastName
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<string>("lastname"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("LastName");
                this.SetAttributeValue("lastname", value);
                this.OnPropertyChanged("LastName");
            }
        }

        /// <summary>
        /// Contains the date and time stamp of the last on hold time.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("lastonholdtime")]
        public System.Nullable<System.DateTime> LastOnHoldTime
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("lastonholdtime"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("LastOnHoldTime");
                this.SetAttributeValue("lastonholdtime", value);
                this.OnPropertyChanged("LastOnHoldTime");
            }
        }

        /// <summary>
        /// Shows the date when the lead was last included in a marketing campaign or quick campaign.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("lastusedincampaign")]
        public System.Nullable<System.DateTime> LastUsedInCampaign
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("lastusedincampaign"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("LastUsedInCampaign");
                this.SetAttributeValue("lastusedincampaign", value);
                this.OnPropertyChanged("LastUsedInCampaign");
            }
        }

        /// <summary>
        /// Unique identifier of the lead.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("leadid")]
        public System.Nullable<System.Guid> LeadId
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("leadid"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("LeadId");
                this.SetAttributeValue("leadid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = System.Guid.Empty;
                }

                this.OnPropertyChanged("LeadId");
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("leadid")]
        public override System.Guid Id
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return base.Id; }
            [System.Diagnostics.DebuggerNonUserCode()]
            set { this.LeadId = value; }
        }

        /// <summary>
        /// Select a rating value to indicate the lead's potential to become a customer.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("leadqualitycode")]
        public Microsoft.Xrm.Sdk.OptionSetValue LeadQualityCode
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("leadqualitycode"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("LeadQualityCode");
                this.SetAttributeValue("leadqualitycode", value);
                this.OnPropertyChanged("LeadQualityCode");
            }
        }

        /// <summary>
        /// Select the primary marketing source that prompted the lead to contact you.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("leadsourcecode")]
        public Microsoft.Xrm.Sdk.OptionSetValue LeadSourceCode
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("leadsourcecode"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("LeadSourceCode");
                this.SetAttributeValue("leadsourcecode", value);
                this.OnPropertyChanged("LeadSourceCode");
            }
        }

        /// <summary>
        /// lead_master_lead
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("masterid")]
        public Microsoft.Xrm.Sdk.EntityReference MasterId
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("masterid"); }
        }

        /// <summary>
        /// Tells whether the lead has been merged with another lead.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("merged")]
        public System.Nullable<bool> Merged
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<System.Nullable<bool>>("merged"); }
        }

        /// <summary>
        /// Type the middle name or initial of the primary contact for the lead to make sure the prospect is addressed correctly.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("middlename")]
        public string MiddleName
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<string>("middlename"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("MiddleName");
                this.SetAttributeValue("middlename", value);
                this.OnPropertyChanged("MiddleName");
            }
        }

        /// <summary>
        /// Type the mobile phone number for the primary contact for the lead.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("mobilephone")]
        public string MobilePhone
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<string>("mobilephone"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("MobilePhone");
                this.SetAttributeValue("mobilephone", value);
                this.OnPropertyChanged("MobilePhone");
            }
        }

        /// <summary>
        /// Shows who last updated the record.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        public Microsoft.Xrm.Sdk.EntityReference ModifiedBy
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedby"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("ModifiedBy");
                this.SetAttributeValue("modifiedby", value);
                this.OnPropertyChanged("ModifiedBy");
            }
        }

        /// <summary>
        /// Shows the date and time when the record was last updated. The date and time are displayed in the time zone selected in Microsoft Dynamics 365 options.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedon")]
        public System.Nullable<System.DateTime> ModifiedOn
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("modifiedon"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("ModifiedOn");
                this.SetAttributeValue("modifiedon", value);
                this.OnPropertyChanged("ModifiedOn");
            }
        }

        /// <summary>
        /// lk_lead_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        public Microsoft.Xrm.Sdk.EntityReference ModifiedOnBehalfBy
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedonbehalfby"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("ModifiedOnBehalfBy");
                this.SetAttributeValue("modifiedonbehalfby", value);
                this.OnPropertyChanged("ModifiedOnBehalfBy");
            }
        }

        /// <summary>
        /// Describes whether lead is opted out or not
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_gdproptout")]
        public System.Nullable<bool> msdyn_gdproptout
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<System.Nullable<bool>>("msdyn_gdproptout"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("msdyn_gdproptout");
                this.SetAttributeValue("msdyn_gdproptout", value);
                this.OnPropertyChanged("msdyn_gdproptout");
            }
        }

        /// <summary>
        /// Whether the Opportunity created when qualifying this Lead is for an Item- based or a Work-based sale
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_ordertype")]
        public Microsoft.Xrm.Sdk.OptionSetValue msdyn_ordertype
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("msdyn_ordertype"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("msdyn_ordertype");
                this.SetAttributeValue("msdyn_ordertype", value);
                this.OnPropertyChanged("msdyn_ordertype");
            }
        }

        /// <summary>
        /// Choose how high the level of need is for the lead's company.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("need")]
        public Microsoft.Xrm.Sdk.OptionSetValue Need
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("need"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Need");
                this.SetAttributeValue("need", value);
                this.OnPropertyChanged("Need");
            }
        }

        /// <summary>
        /// Type the number of employees that work at the company associated with the lead, for use in marketing segmentation and demographic analysis.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("numberofemployees")]
        public System.Nullable<int> NumberOfEmployees
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<System.Nullable<int>>("numberofemployees"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("NumberOfEmployees");
                this.SetAttributeValue("numberofemployees", value);
                this.OnPropertyChanged("NumberOfEmployees");
            }
        }

        /// <summary>
        /// Shows how long, in minutes, that the record was on hold.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("onholdtime")]
        public System.Nullable<int> OnHoldTime
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<System.Nullable<int>>("onholdtime"); }
        }

        /// <summary>
        /// OriginatingCase_Lead
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("originatingcaseid")]
        public Microsoft.Xrm.Sdk.EntityReference OriginatingCaseId
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("originatingcaseid"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("OriginatingCaseId");
                this.SetAttributeValue("originatingcaseid", value);
                this.OnPropertyChanged("OriginatingCaseId");
            }
        }

        /// <summary>
        /// Date and time that the record was migrated.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("overriddencreatedon")]
        public System.Nullable<System.DateTime> OverriddenCreatedOn
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("overriddencreatedon"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("OverriddenCreatedOn");
                this.SetAttributeValue("overriddencreatedon", value);
                this.OnPropertyChanged("OverriddenCreatedOn");
            }
        }

        /// <summary>
        /// owner_leads
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ownerid")]
        public Microsoft.Xrm.Sdk.EntityReference OwnerId
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("ownerid"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("OwnerId");
                this.SetAttributeValue("ownerid", value);
                this.OnPropertyChanged("OwnerId");
            }
        }

        /// <summary>
        /// business_unit_leads
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
        public Microsoft.Xrm.Sdk.EntityReference OwningBusinessUnit
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owningbusinessunit"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("OwningBusinessUnit");
                this.SetAttributeValue("owningbusinessunit", value);
                this.OnPropertyChanged("OwningBusinessUnit");
            }
        }

        /// <summary>
        /// lead_owning_team
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningteam")]
        public Microsoft.Xrm.Sdk.EntityReference OwningTeam
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owningteam"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("OwningTeam");
                this.SetAttributeValue("owningteam", value);
                this.OnPropertyChanged("OwningTeam");
            }
        }

        /// <summary>
        /// lead_owning_user
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
        public Microsoft.Xrm.Sdk.EntityReference OwningUser
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owninguser"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("OwningUser");
                this.SetAttributeValue("owninguser", value);
                this.OnPropertyChanged("OwningUser");
            }
        }

        /// <summary>
        /// Type the pager number for the primary contact for the lead.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("pager")]
        public string Pager
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<string>("pager"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Pager");
                this.SetAttributeValue("pager", value);
                this.OnPropertyChanged("Pager");
            }
        }

        /// <summary>
        /// lead_parent_account
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("parentaccountid")]
        public Microsoft.Xrm.Sdk.EntityReference ParentAccountId
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("parentaccountid"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("ParentAccountId");
                this.SetAttributeValue("parentaccountid", value);
                this.OnPropertyChanged("ParentAccountId");
            }
        }

        /// <summary>
        /// lead_parent_contact
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("parentcontactid")]
        public Microsoft.Xrm.Sdk.EntityReference ParentContactId
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("parentcontactid"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("ParentContactId");
                this.SetAttributeValue("parentcontactid", value);
                this.OnPropertyChanged("ParentContactId");
            }
        }

        /// <summary>
        /// Shows whether the lead participates in workflow rules.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("participatesinworkflow")]
        public System.Nullable<bool> ParticipatesInWorkflow
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<System.Nullable<bool>>("participatesinworkflow"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("ParticipatesInWorkflow");
                this.SetAttributeValue("participatesinworkflow", value);
                this.OnPropertyChanged("ParticipatesInWorkflow");
            }
        }

        /// <summary>
        /// Select the preferred method of contact.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("preferredcontactmethodcode")]
        public Microsoft.Xrm.Sdk.OptionSetValue PreferredContactMethodCode
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("preferredcontactmethodcode"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("PreferredContactMethodCode");
                this.SetAttributeValue("preferredcontactmethodcode", value);
                this.OnPropertyChanged("PreferredContactMethodCode");
            }
        }

        /// <summary>
        /// Select the priority so that preferred customers or critical issues are handled quickly.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("prioritycode")]
        public Microsoft.Xrm.Sdk.OptionSetValue PriorityCode
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("prioritycode"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("PriorityCode");
                this.SetAttributeValue("prioritycode", value);
                this.OnPropertyChanged("PriorityCode");
            }
        }

        /// <summary>
        /// Shows the ID of the process.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("processid")]
        public System.Nullable<System.Guid> ProcessId
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("processid"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("ProcessId");
                this.SetAttributeValue("processid", value);
                this.OnPropertyChanged("ProcessId");
            }
        }

        /// <summary>
        /// Choose whether an individual or a committee will be involved in the  purchase process for the lead.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("purchaseprocess")]
        public Microsoft.Xrm.Sdk.OptionSetValue PurchaseProcess
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("purchaseprocess"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("PurchaseProcess");
                this.SetAttributeValue("purchaseprocess", value);
                this.OnPropertyChanged("PurchaseProcess");
            }
        }

        /// <summary>
        /// Choose how long the lead will likely take to make the purchase, so the sales team will be aware.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("purchasetimeframe")]
        public Microsoft.Xrm.Sdk.OptionSetValue PurchaseTimeFrame
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("purchasetimeframe"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("PurchaseTimeFrame");
                this.SetAttributeValue("purchasetimeframe", value);
                this.OnPropertyChanged("PurchaseTimeFrame");
            }
        }

        /// <summary>
        /// Type comments about the qualification or scoring of the lead.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("qualificationcomments")]
        public string QualificationComments
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<string>("qualificationcomments"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("QualificationComments");
                this.SetAttributeValue("qualificationcomments", value);
                this.OnPropertyChanged("QualificationComments");
            }
        }

        /// <summary>
        /// lead_qualifying_opportunity
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("qualifyingopportunityid")]
        public Microsoft.Xrm.Sdk.EntityReference QualifyingOpportunityId
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("qualifyingopportunityid"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("QualifyingOpportunityId");
                this.SetAttributeValue("qualifyingopportunityid", value);
                this.OnPropertyChanged("QualifyingOpportunityId");
            }
        }

        /// <summary>
        /// CampaignResponse_Lead
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("relatedobjectid")]
        public Microsoft.Xrm.Sdk.EntityReference RelatedObjectId
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("relatedobjectid"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("RelatedObjectId");
                this.SetAttributeValue("relatedobjectid", value);
                this.OnPropertyChanged("RelatedObjectId");
            }
        }

        /// <summary>
        /// Type the annual revenue of the company associated with the lead to provide an understanding of the prospect's business.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("revenue")]
        public Microsoft.Xrm.Sdk.Money Revenue
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("revenue"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Revenue");
                this.SetAttributeValue("revenue", value);
                this.OnPropertyChanged("Revenue");
            }
        }

        /// <summary>
        /// Shows the Annual Revenue field converted to the system's default base currency. The calculation uses the exchange rate specified in the Currencies area.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("revenue_base")]
        public Microsoft.Xrm.Sdk.Money Revenue_Base
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("revenue_base"); }
        }

        /// <summary>
        /// Select the sales stage of this lead to aid the sales team in their efforts to convert this lead to an opportunity.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("salesstage")]
        public Microsoft.Xrm.Sdk.OptionSetValue SalesStage
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("salesstage"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("SalesStage");
                this.SetAttributeValue("salesstage", value);
                this.OnPropertyChanged("SalesStage");
            }
        }

        /// <summary>
        /// Select the sales process stage for the lead to help determine the probability of the lead converting to an opportunity.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("salesstagecode")]
        public Microsoft.Xrm.Sdk.OptionSetValue SalesStageCode
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("salesstagecode"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("SalesStageCode");
                this.SetAttributeValue("salesstagecode", value);
                this.OnPropertyChanged("SalesStageCode");
            }
        }

        /// <summary>
        /// Type the salutation of the primary contact for this lead to make sure the prospect is addressed correctly in sales calls, email messages, and marketing campaigns.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("salutation")]
        public string Salutation
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<string>("salutation"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Salutation");
                this.SetAttributeValue("salutation", value);
                this.OnPropertyChanged("Salutation");
            }
        }

        /// <summary>
        /// Enter the date and time of the prospecting follow-up meeting with the lead.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("schedulefollowup_prospect")]
        public System.Nullable<System.DateTime> ScheduleFollowUp_Prospect
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("schedulefollowup_prospect"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("ScheduleFollowUp_Prospect");
                this.SetAttributeValue("schedulefollowup_prospect", value);
                this.OnPropertyChanged("ScheduleFollowUp_Prospect");
            }
        }

        /// <summary>
        /// Enter the date and time of the qualifying follow-up meeting with the lead.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("schedulefollowup_qualify")]
        public System.Nullable<System.DateTime> ScheduleFollowUp_Qualify
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("schedulefollowup_qualify"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("ScheduleFollowUp_Qualify");
                this.SetAttributeValue("schedulefollowup_qualify", value);
                this.OnPropertyChanged("ScheduleFollowUp_Qualify");
            }
        }

        /// <summary>
        /// Type the Standard Industrial Classification (SIC) code that indicates the lead's primary industry of business for use in marketing segmentation and demographic analysis.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sic")]
        public string SIC
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<string>("sic"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("SIC");
                this.SetAttributeValue("sic", value);
                this.OnPropertyChanged("SIC");
            }
        }

        /// <summary>
        /// manualsla_lead
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("slaid")]
        public Microsoft.Xrm.Sdk.EntityReference SLAId
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("slaid"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("SLAId");
                this.SetAttributeValue("slaid", value);
                this.OnPropertyChanged("SLAId");
            }
        }

        /// <summary>
        /// sla_lead
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("slainvokedid")]
        public Microsoft.Xrm.Sdk.EntityReference SLAInvokedId
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("slainvokedid"); }
        }

        /// <summary>
        /// processstage_lead
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("stageid")]
        public System.Nullable<System.Guid> StageId
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("stageid"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("StageId");
                this.SetAttributeValue("stageid", value);
                this.OnPropertyChanged("StageId");
            }
        }

        /// <summary>
        /// Shows whether the lead is open, qualified, or disqualified. Qualified and disqualified leads are read-only and can't be edited unless they are reactivated.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statecode")]
        public System.Nullable<LeadState> StateCode
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get
            {
                Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statecode");
                if ((optionSet != null))
                {
                    return ((LeadState) (System.Enum.ToObject(typeof(LeadState), optionSet.Value)));
                }
                else
                {
                    return null;
                }
            }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("StateCode");
                if ((value == null))
                {
                    this.SetAttributeValue("statecode", null);
                }
                else
                {
                    this.SetAttributeValue("statecode", new Microsoft.Xrm.Sdk.OptionSetValue(((int) (value))));
                }

                this.OnPropertyChanged("StateCode");
            }
        }

        /// <summary>
        /// Select the lead's status.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statuscode")]
        public Microsoft.Xrm.Sdk.OptionSetValue StatusCode
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statuscode"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("StatusCode");
                this.SetAttributeValue("statuscode", value);
                this.OnPropertyChanged("StatusCode");
            }
        }

        /// <summary>
        /// Type a subject or descriptive name, such as the expected order, company name, or marketing source list, to identify the lead.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("subject")]
        public string Subject
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<string>("subject"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Subject");
                this.SetAttributeValue("subject", value);
                this.OnPropertyChanged("Subject");
            }
        }

        /// <summary>
        /// Number of users or conversations followed the record
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("teamsfollowed")]
        public System.Nullable<int> TeamsFollowed
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<System.Nullable<int>>("teamsfollowed"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("TeamsFollowed");
                this.SetAttributeValue("teamsfollowed", value);
                this.OnPropertyChanged("TeamsFollowed");
            }
        }

        /// <summary>
        /// Type the work phone number for the primary contact for the lead.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("telephone1")]
        public string Telephone1
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<string>("telephone1"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Telephone1");
                this.SetAttributeValue("telephone1", value);
                this.OnPropertyChanged("Telephone1");
            }
        }

        /// <summary>
        /// Type the home phone number for the primary contact for the lead.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("telephone2")]
        public string Telephone2
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<string>("telephone2"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Telephone2");
                this.SetAttributeValue("telephone2", value);
                this.OnPropertyChanged("Telephone2");
            }
        }

        /// <summary>
        /// Type an alternate phone number for the primary contact for the lead.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("telephone3")]
        public string Telephone3
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<string>("telephone3"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("Telephone3");
                this.SetAttributeValue("telephone3", value);
                this.OnPropertyChanged("Telephone3");
            }
        }

        /// <summary>
        /// Total time spent for emails (read and write) and meetings by me in relation to the lead record.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("timespentbymeonemailandmeetings")]
        public string TimeSpentByMeOnEmailAndMeetings
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<string>("timespentbymeonemailandmeetings"); }
        }

        /// <summary>
        /// For internal use only.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("timezoneruleversionnumber")]
        public System.Nullable<int> TimeZoneRuleVersionNumber
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<System.Nullable<int>>("timezoneruleversionnumber"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("TimeZoneRuleVersionNumber");
                this.SetAttributeValue("timezoneruleversionnumber", value);
                this.OnPropertyChanged("TimeZoneRuleVersionNumber");
            }
        }

        /// <summary>
        /// Choose the local currency for the record to make sure budgets are reported in the correct currency.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("transactioncurrencyid")]
        public Microsoft.Xrm.Sdk.EntityReference TransactionCurrencyId
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("transactioncurrencyid"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("TransactionCurrencyId");
                this.SetAttributeValue("transactioncurrencyid", value);
                this.OnPropertyChanged("TransactionCurrencyId");
            }
        }

        /// <summary>
        /// For internal use only.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("traversedpath")]
        public string TraversedPath
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<string>("traversedpath"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("TraversedPath");
                this.SetAttributeValue("traversedpath", value);
                this.OnPropertyChanged("TraversedPath");
            }
        }

        /// <summary>
        /// Time zone code that was in use when the record was created.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("utcconversiontimezonecode")]
        public System.Nullable<int> UTCConversionTimeZoneCode
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<System.Nullable<int>>("utcconversiontimezonecode"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("UTCConversionTimeZoneCode");
                this.SetAttributeValue("utcconversiontimezonecode", value);
                this.OnPropertyChanged("UTCConversionTimeZoneCode");
            }
        }

        /// <summary>
        /// Version number of the lead.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("versionnumber")]
        public System.Nullable<long> VersionNumber
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<System.Nullable<long>>("versionnumber"); }
        }

        /// <summary>
        /// Type the website URL for the company associated with this lead.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("websiteurl")]
        public string WebSiteUrl
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<string>("websiteurl"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("WebSiteUrl");
                this.SetAttributeValue("websiteurl", value);
                this.OnPropertyChanged("WebSiteUrl");
            }
        }

        /// <summary>
        /// Type the phonetic spelling of the lead's company name, if the name is specified in Japanese, to make sure the name is pronounced correctly in phone calls with the prospect.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("yomicompanyname")]
        public string YomiCompanyName
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<string>("yomicompanyname"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("YomiCompanyName");
                this.SetAttributeValue("yomicompanyname", value);
                this.OnPropertyChanged("YomiCompanyName");
            }
        }

        /// <summary>
        /// Type the phonetic spelling of the lead's first name, if the name is specified in Japanese, to make sure the name is pronounced correctly in phone calls with the prospect.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("yomifirstname")]
        public string YomiFirstName
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<string>("yomifirstname"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("YomiFirstName");
                this.SetAttributeValue("yomifirstname", value);
                this.OnPropertyChanged("YomiFirstName");
            }
        }

        /// <summary>
        /// Combines and shows the lead's Yomi first and last names so the full phonetic name can be displayed in views and reports.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("yomifullname")]
        public string YomiFullName
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<string>("yomifullname"); }
        }

        /// <summary>
        /// Type the phonetic spelling of the lead's last name, if the name is specified in Japanese, to make sure the name is pronounced correctly in phone calls with the prospect.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("yomilastname")]
        public string YomiLastName
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<string>("yomilastname"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("YomiLastName");
                this.SetAttributeValue("yomilastname", value);
                this.OnPropertyChanged("YomiLastName");
            }
        }

        /// <summary>
        /// Type the phonetic spelling of the lead's middle name, if the name is specified in Japanese, to make sure the name is pronounced correctly in phone calls with the prospect.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("yomimiddlename")]
        public string YomiMiddleName
        {
            [System.Diagnostics.DebuggerNonUserCode()]
            get { return this.GetAttributeValue<string>("yomimiddlename"); }
            [System.Diagnostics.DebuggerNonUserCode()]
            set
            {
                this.OnPropertyChanging("YomiMiddleName");
                this.SetAttributeValue("yomimiddlename", value);
                this.OnPropertyChanged("YomiMiddleName");
            }
        }
    }
}
