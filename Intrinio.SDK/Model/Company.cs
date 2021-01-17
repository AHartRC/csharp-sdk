using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using Intrinio.SDK.Client;

namespace Intrinio.SDK.Model
{
	/// <summary>
	///     A company that submits filings to the SEC and has a security traded primarily on a US exchange
	/// </summary>
	[DataContract]
	public class Company : IEquatable<Company>, IValidatableObject
	{
		/// <summary>
		///     Initializes a new instance of the <see cref="Company" /> class.
		/// </summary>
		/// <param name="Id">The Intrinio ID of the company.</param>
		/// <param name="Ticker">The stock market ticker symbol associated with the company&#39;s common stock securities.</param>
		/// <param name="Name">The company&#39;s common name.</param>
		/// <param name="Lei">The Legal Entity Identifier (LEI) assigned to the company.</param>
		/// <param name="LegalName">The company&#39;s official legal name.</param>
		/// <param name="StockExchange">The Stock Exchange where the company&#39;s common stock is primarily traded.</param>
		/// <param name="Sic">The Standard Industrial Classification (SIC) determined by the company and filed with the SEC.</param>
		/// <param name="ShortDescription">A one or two sentence description of the company&#39;s operations.</param>
		/// <param name="LongDescription">A one paragraph description of the company&#39;s operations and other corporate actions.</param>
		/// <param name="Ceo">The Chief Executive Officer of the company.</param>
		/// <param name="CompanyUrl">The URL of the company&#39;s primary corporate website or primary internet property.</param>
		/// <param name="BusinessAddress">The company&#39;s business address.</param>
		/// <param name="MailingAddress">The mailing address reported by the company.</param>
		/// <param name="BusinessPhoneNo">The phone number reported by the company.</param>
		/// <param name="HqAddress1">The company&#39;s headquarters address - line 1.</param>
		/// <param name="HqAddress2">The company&#39;s headquarters address - line 2.</param>
		/// <param name="HqAddressCity">The company&#39;s headquarters city.</param>
		/// <param name="HqAddressPostalCode">The company&#39;s headquarters postal code.</param>
		/// <param name="EntityLegalForm">The company&#39;s legal organization form.</param>
		/// <param name="Cik">
		///     The Central Index Key (CIK) assigned to the company by the SEC as a unique identifier, used in SEC
		///     filings.
		/// </param>
		/// <param name="LatestFilingDate">The date of the company&#39;s last filing with the SEC.</param>
		/// <param name="HqState">The state (US &amp; Canada Only) where the company headquarters are located.</param>
		/// <param name="HqCountry">The country where the company headquarters are located.</param>
		/// <param name="IncState">The state (US &amp; Canada Only) where the company is incorporated.</param>
		/// <param name="IncCountry">The country where the company is incorporated.</param>
		/// <param name="Employees">The number of employees working for the company.</param>
		/// <param name="EntityStatus">EntityStatus.</param>
		/// <param name="Sector">The company&#39;s operating sector.</param>
		/// <param name="IndustryCategory">The company&#39;s operating industry category.</param>
		/// <param name="IndustryGroup">The company&#39;s operating industry group.</param>
		/// <param name="Template">The financial statement template used by Intrinio to standardize the as reported data.</param>
		/// <param name="StandardizedActive">
		///     If true, the company has standardized and as reported fundamental data via the
		///     Intrinio API; if false, the company has as-reported data only.
		/// </param>
		/// <param name="FirstFundamentalDate">The period end date of the company&#39;s first reported fundamental.</param>
		/// <param name="LastFundamentalDate">The period end date of the company&#39;s last reported fundamental.</param>
		/// <param name="FirstStockPriceDate">
		///     The date of the company&#39;s first stock price, based on the company&#39;s primary
		///     security, which is typically traded on US exchages.
		/// </param>
		/// <param name="LastStockPriceDate">
		///     The date of the company&#39;s last stock price, based on the company&#39;s primary
		///     security, which is typically traded on US exchages.
		/// </param>
		public Company(string Id = default, string Ticker = default, string Name = default, string Lei = default,
			string LegalName = default, string StockExchange = default, string Sic = default,
			string ShortDescription = default, string LongDescription = default, string Ceo = default,
			string CompanyUrl = default, string BusinessAddress = default, string MailingAddress = default,
			string BusinessPhoneNo = default, string HqAddress1 = default, string HqAddress2 = default,
			string HqAddressCity = default, string HqAddressPostalCode = default, string EntityLegalForm = default,
			string Cik = default, DateTime? LatestFilingDate = default, string HqState = default,
			string HqCountry = default, string IncState = default, string IncCountry = default,
			int? Employees = default, string EntityStatus = default, string Sector = default,
			string IndustryCategory = default, string IndustryGroup = default, string Template = default,
			bool? StandardizedActive = default, DateTime? FirstFundamentalDate = default,
			DateTime? LastFundamentalDate = default, DateTime? FirstStockPriceDate = default,
			DateTime? LastStockPriceDate = default)
		{
			this.Id = Id;
			this.Ticker = Ticker;
			this.Name = Name;
			this.Lei = Lei;
			this.LegalName = LegalName;
			this.StockExchange = StockExchange;
			this.Sic = Sic;
			this.ShortDescription = ShortDescription;
			this.LongDescription = LongDescription;
			this.Ceo = Ceo;
			this.CompanyUrl = CompanyUrl;
			this.BusinessAddress = BusinessAddress;
			this.MailingAddress = MailingAddress;
			this.BusinessPhoneNo = BusinessPhoneNo;
			this.HqAddress1 = HqAddress1;
			this.HqAddress2 = HqAddress2;
			this.HqAddressCity = HqAddressCity;
			this.HqAddressPostalCode = HqAddressPostalCode;
			this.EntityLegalForm = EntityLegalForm;
			this.Cik = Cik;
			this.LatestFilingDate = LatestFilingDate;
			this.HqState = HqState;
			this.HqCountry = HqCountry;
			this.IncState = IncState;
			this.IncCountry = IncCountry;
			this.Employees = Employees;
			this.EntityStatus = EntityStatus;
			this.Sector = Sector;
			this.IndustryCategory = IndustryCategory;
			this.IndustryGroup = IndustryGroup;
			this.Template = Template;
			this.StandardizedActive = StandardizedActive;
			this.FirstFundamentalDate = FirstFundamentalDate;
			this.LastFundamentalDate = LastFundamentalDate;
			this.FirstStockPriceDate = FirstStockPriceDate;
			this.LastStockPriceDate = LastStockPriceDate;
		}

		/// <summary>
		///     The Intrinio ID of the company
		/// </summary>
		/// <value>The Intrinio ID of the company</value>
		[DataMember(Name = "id", EmitDefaultValue = false)]
		public string Id { get; set; }

		/// <summary>
		///     The stock market ticker symbol associated with the company&#39;s common stock securities
		/// </summary>
		/// <value>The stock market ticker symbol associated with the company&#39;s common stock securities</value>
		[DataMember(Name = "ticker", EmitDefaultValue = false)]
		public string Ticker { get; set; }

		/// <summary>
		///     The company&#39;s common name
		/// </summary>
		/// <value>The company&#39;s common name</value>
		[DataMember(Name = "name", EmitDefaultValue = false)]
		public string Name { get; set; }

		/// <summary>
		///     The Legal Entity Identifier (LEI) assigned to the company
		/// </summary>
		/// <value>The Legal Entity Identifier (LEI) assigned to the company</value>
		[DataMember(Name = "lei", EmitDefaultValue = false)]
		public string Lei { get; set; }

		/// <summary>
		///     The company&#39;s official legal name
		/// </summary>
		/// <value>The company&#39;s official legal name</value>
		[DataMember(Name = "legal_name", EmitDefaultValue = false)]
		public string LegalName { get; set; }

		/// <summary>
		///     The Stock Exchange where the company&#39;s common stock is primarily traded
		/// </summary>
		/// <value>The Stock Exchange where the company&#39;s common stock is primarily traded</value>
		[DataMember(Name = "stock_exchange", EmitDefaultValue = false)]
		public string StockExchange { get; set; }

		/// <summary>
		///     The Standard Industrial Classification (SIC) determined by the company and filed with the SEC
		/// </summary>
		/// <value>The Standard Industrial Classification (SIC) determined by the company and filed with the SEC</value>
		[DataMember(Name = "sic", EmitDefaultValue = false)]
		public string Sic { get; set; }

		/// <summary>
		///     A one or two sentence description of the company&#39;s operations
		/// </summary>
		/// <value>A one or two sentence description of the company&#39;s operations</value>
		[DataMember(Name = "short_description", EmitDefaultValue = false)]
		public string ShortDescription { get; set; }

		/// <summary>
		///     A one paragraph description of the company&#39;s operations and other corporate actions
		/// </summary>
		/// <value>A one paragraph description of the company&#39;s operations and other corporate actions</value>
		[DataMember(Name = "long_description", EmitDefaultValue = false)]
		public string LongDescription { get; set; }

		/// <summary>
		///     The Chief Executive Officer of the company
		/// </summary>
		/// <value>The Chief Executive Officer of the company</value>
		[DataMember(Name = "ceo", EmitDefaultValue = false)]
		public string Ceo { get; set; }

		/// <summary>
		///     The URL of the company&#39;s primary corporate website or primary internet property
		/// </summary>
		/// <value>The URL of the company&#39;s primary corporate website or primary internet property</value>
		[DataMember(Name = "company_url", EmitDefaultValue = false)]
		public string CompanyUrl { get; set; }

		/// <summary>
		///     The company&#39;s business address
		/// </summary>
		/// <value>The company&#39;s business address</value>
		[DataMember(Name = "business_address", EmitDefaultValue = false)]
		public string BusinessAddress { get; set; }

		/// <summary>
		///     The mailing address reported by the company
		/// </summary>
		/// <value>The mailing address reported by the company</value>
		[DataMember(Name = "mailing_address", EmitDefaultValue = false)]
		public string MailingAddress { get; set; }

		/// <summary>
		///     The phone number reported by the company
		/// </summary>
		/// <value>The phone number reported by the company</value>
		[DataMember(Name = "business_phone_no", EmitDefaultValue = false)]
		public string BusinessPhoneNo { get; set; }

		/// <summary>
		///     The company&#39;s headquarters address - line 1
		/// </summary>
		/// <value>The company&#39;s headquarters address - line 1</value>
		[DataMember(Name = "hq_address1", EmitDefaultValue = false)]
		public string HqAddress1 { get; set; }

		/// <summary>
		///     The company&#39;s headquarters address - line 2
		/// </summary>
		/// <value>The company&#39;s headquarters address - line 2</value>
		[DataMember(Name = "hq_address2", EmitDefaultValue = false)]
		public string HqAddress2 { get; set; }

		/// <summary>
		///     The company&#39;s headquarters city
		/// </summary>
		/// <value>The company&#39;s headquarters city</value>
		[DataMember(Name = "hq_address_city", EmitDefaultValue = false)]
		public string HqAddressCity { get; set; }

		/// <summary>
		///     The company&#39;s headquarters postal code
		/// </summary>
		/// <value>The company&#39;s headquarters postal code</value>
		[DataMember(Name = "hq_address_postal_code", EmitDefaultValue = false)]
		public string HqAddressPostalCode { get; set; }

		/// <summary>
		///     The company&#39;s legal organization form
		/// </summary>
		/// <value>The company&#39;s legal organization form</value>
		[DataMember(Name = "entity_legal_form", EmitDefaultValue = false)]
		public string EntityLegalForm { get; set; }

		/// <summary>
		///     The Central Index Key (CIK) assigned to the company by the SEC as a unique identifier, used in SEC filings
		/// </summary>
		/// <value>The Central Index Key (CIK) assigned to the company by the SEC as a unique identifier, used in SEC filings</value>
		[DataMember(Name = "cik", EmitDefaultValue = false)]
		public string Cik { get; set; }

		/// <summary>
		///     The date of the company&#39;s last filing with the SEC
		/// </summary>
		/// <value>The date of the company&#39;s last filing with the SEC</value>
		[DataMember(Name = "latest_filing_date", EmitDefaultValue = false)]
		
		public DateTime? LatestFilingDate { get; set; }

		/// <summary>
		///     The state (US &amp; Canada Only) where the company headquarters are located
		/// </summary>
		/// <value>The state (US &amp; Canada Only) where the company headquarters are located</value>
		[DataMember(Name = "hq_state", EmitDefaultValue = false)]
		public string HqState { get; set; }

		/// <summary>
		///     The country where the company headquarters are located
		/// </summary>
		/// <value>The country where the company headquarters are located</value>
		[DataMember(Name = "hq_country", EmitDefaultValue = false)]
		public string HqCountry { get; set; }

		/// <summary>
		///     The state (US &amp; Canada Only) where the company is incorporated
		/// </summary>
		/// <value>The state (US &amp; Canada Only) where the company is incorporated</value>
		[DataMember(Name = "inc_state", EmitDefaultValue = false)]
		public string IncState { get; set; }

		/// <summary>
		///     The country where the company is incorporated
		/// </summary>
		/// <value>The country where the company is incorporated</value>
		[DataMember(Name = "inc_country", EmitDefaultValue = false)]
		public string IncCountry { get; set; }

		/// <summary>
		///     The number of employees working for the company
		/// </summary>
		/// <value>The number of employees working for the company</value>
		[DataMember(Name = "employees", EmitDefaultValue = false)]
		public int? Employees { get; set; }

		/// <summary>
		///     Gets or Sets EntityStatus
		/// </summary>
		[DataMember(Name = "entity_status", EmitDefaultValue = false)]
		public string EntityStatus { get; set; }

		/// <summary>
		///     The company&#39;s operating sector
		/// </summary>
		/// <value>The company&#39;s operating sector</value>
		[DataMember(Name = "sector", EmitDefaultValue = false)]
		public string Sector { get; set; }

		/// <summary>
		///     The company&#39;s operating industry category
		/// </summary>
		/// <value>The company&#39;s operating industry category</value>
		[DataMember(Name = "industry_category", EmitDefaultValue = false)]
		public string IndustryCategory { get; set; }

		/// <summary>
		///     The company&#39;s operating industry group
		/// </summary>
		/// <value>The company&#39;s operating industry group</value>
		[DataMember(Name = "industry_group", EmitDefaultValue = false)]
		public string IndustryGroup { get; set; }

		/// <summary>
		///     The financial statement template used by Intrinio to standardize the as reported data
		/// </summary>
		/// <value>The financial statement template used by Intrinio to standardize the as reported data</value>
		[DataMember(Name = "template", EmitDefaultValue = false)]
		public string Template { get; set; }

		/// <summary>
		///     If true, the company has standardized and as reported fundamental data via the Intrinio API; if false, the company
		///     has as-reported data only
		/// </summary>
		/// <value>
		///     If true, the company has standardized and as reported fundamental data via the Intrinio API; if false, the
		///     company has as-reported data only
		/// </value>
		[DataMember(Name = "standardized_active", EmitDefaultValue = false)]
		public bool? StandardizedActive { get; set; }

		/// <summary>
		///     The period end date of the company&#39;s first reported fundamental
		/// </summary>
		/// <value>The period end date of the company&#39;s first reported fundamental</value>
		[DataMember(Name = "first_fundamental_date", EmitDefaultValue = false)]
		
		public DateTime? FirstFundamentalDate { get; set; }

		/// <summary>
		///     The period end date of the company&#39;s last reported fundamental
		/// </summary>
		/// <value>The period end date of the company&#39;s last reported fundamental</value>
		[DataMember(Name = "last_fundamental_date", EmitDefaultValue = false)]
		
		public DateTime? LastFundamentalDate { get; set; }

		/// <summary>
		///     The date of the company&#39;s first stock price, based on the company&#39;s primary security, which is typically
		///     traded on US exchages
		/// </summary>
		/// <value>
		///     The date of the company&#39;s first stock price, based on the company&#39;s primary security, which is typically
		///     traded on US exchages
		/// </value>
		[DataMember(Name = "first_stock_price_date", EmitDefaultValue = false)]
		
		public DateTime? FirstStockPriceDate { get; set; }

		/// <summary>
		///     The date of the company&#39;s last stock price, based on the company&#39;s primary security, which is typically
		///     traded on US exchages
		/// </summary>
		/// <value>
		///     The date of the company&#39;s last stock price, based on the company&#39;s primary security, which is typically
		///     traded on US exchages
		/// </value>
		[DataMember(Name = "last_stock_price_date", EmitDefaultValue = false)]
		
		public DateTime? LastStockPriceDate { get; set; }

		/// <summary>
		///     Returns true if Company instances are equal
		/// </summary>
		/// <param name="input">Instance of Company to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(Company input)
		{
			if (input == null)
				return false;

			return
				(
					Id == input.Id ||
					Id != null &&
					Id.Equals(input.Id)
				) &&
				(
					Ticker == input.Ticker ||
					Ticker != null &&
					Ticker.Equals(input.Ticker)
				) &&
				(
					Name == input.Name ||
					Name != null &&
					Name.Equals(input.Name)
				) &&
				(
					Lei == input.Lei ||
					Lei != null &&
					Lei.Equals(input.Lei)
				) &&
				(
					LegalName == input.LegalName ||
					LegalName != null &&
					LegalName.Equals(input.LegalName)
				) &&
				(
					StockExchange == input.StockExchange ||
					StockExchange != null &&
					StockExchange.Equals(input.StockExchange)
				) &&
				(
					Sic == input.Sic ||
					Sic != null &&
					Sic.Equals(input.Sic)
				) &&
				(
					ShortDescription == input.ShortDescription ||
					ShortDescription != null &&
					ShortDescription.Equals(input.ShortDescription)
				) &&
				(
					LongDescription == input.LongDescription ||
					LongDescription != null &&
					LongDescription.Equals(input.LongDescription)
				) &&
				(
					Ceo == input.Ceo ||
					Ceo != null &&
					Ceo.Equals(input.Ceo)
				) &&
				(
					CompanyUrl == input.CompanyUrl ||
					CompanyUrl != null &&
					CompanyUrl.Equals(input.CompanyUrl)
				) &&
				(
					BusinessAddress == input.BusinessAddress ||
					BusinessAddress != null &&
					BusinessAddress.Equals(input.BusinessAddress)
				) &&
				(
					MailingAddress == input.MailingAddress ||
					MailingAddress != null &&
					MailingAddress.Equals(input.MailingAddress)
				) &&
				(
					BusinessPhoneNo == input.BusinessPhoneNo ||
					BusinessPhoneNo != null &&
					BusinessPhoneNo.Equals(input.BusinessPhoneNo)
				) &&
				(
					HqAddress1 == input.HqAddress1 ||
					HqAddress1 != null &&
					HqAddress1.Equals(input.HqAddress1)
				) &&
				(
					HqAddress2 == input.HqAddress2 ||
					HqAddress2 != null &&
					HqAddress2.Equals(input.HqAddress2)
				) &&
				(
					HqAddressCity == input.HqAddressCity ||
					HqAddressCity != null &&
					HqAddressCity.Equals(input.HqAddressCity)
				) &&
				(
					HqAddressPostalCode == input.HqAddressPostalCode ||
					HqAddressPostalCode != null &&
					HqAddressPostalCode.Equals(input.HqAddressPostalCode)
				) &&
				(
					EntityLegalForm == input.EntityLegalForm ||
					EntityLegalForm != null &&
					EntityLegalForm.Equals(input.EntityLegalForm)
				) &&
				(
					Cik == input.Cik ||
					Cik != null &&
					Cik.Equals(input.Cik)
				) &&
				(
					LatestFilingDate == input.LatestFilingDate ||
					LatestFilingDate != null &&
					LatestFilingDate.Equals(input.LatestFilingDate)
				) &&
				(
					HqState == input.HqState ||
					HqState != null &&
					HqState.Equals(input.HqState)
				) &&
				(
					HqCountry == input.HqCountry ||
					HqCountry != null &&
					HqCountry.Equals(input.HqCountry)
				) &&
				(
					IncState == input.IncState ||
					IncState != null &&
					IncState.Equals(input.IncState)
				) &&
				(
					IncCountry == input.IncCountry ||
					IncCountry != null &&
					IncCountry.Equals(input.IncCountry)
				) &&
				(
					Employees == input.Employees ||
					Employees != null &&
					Employees.Equals(input.Employees)
				) &&
				(
					EntityStatus == input.EntityStatus ||
					EntityStatus != null &&
					EntityStatus.Equals(input.EntityStatus)
				) &&
				(
					Sector == input.Sector ||
					Sector != null &&
					Sector.Equals(input.Sector)
				) &&
				(
					IndustryCategory == input.IndustryCategory ||
					IndustryCategory != null &&
					IndustryCategory.Equals(input.IndustryCategory)
				) &&
				(
					IndustryGroup == input.IndustryGroup ||
					IndustryGroup != null &&
					IndustryGroup.Equals(input.IndustryGroup)
				) &&
				(
					Template == input.Template ||
					Template != null &&
					Template.Equals(input.Template)
				) &&
				(
					StandardizedActive == input.StandardizedActive ||
					StandardizedActive != null &&
					StandardizedActive.Equals(input.StandardizedActive)
				) &&
				(
					FirstFundamentalDate == input.FirstFundamentalDate ||
					FirstFundamentalDate != null &&
					FirstFundamentalDate.Equals(input.FirstFundamentalDate)
				) &&
				(
					LastFundamentalDate == input.LastFundamentalDate ||
					LastFundamentalDate != null &&
					LastFundamentalDate.Equals(input.LastFundamentalDate)
				) &&
				(
					FirstStockPriceDate == input.FirstStockPriceDate ||
					FirstStockPriceDate != null &&
					FirstStockPriceDate.Equals(input.FirstStockPriceDate)
				) &&
				(
					LastStockPriceDate == input.LastStockPriceDate ||
					LastStockPriceDate != null &&
					LastStockPriceDate.Equals(input.LastStockPriceDate)
				);
		}

		/// <summary>
		///     To validate all properties of the instance
		/// </summary>
		/// <param name="validationContext">Validation context</param>
		/// <returns>Validation Result</returns>
		IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
		{
			yield break;
		}

		/// <summary>
		///     Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class Company {\n");
			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  Ticker: ").Append(Ticker).Append("\n");
			sb.Append("  Name: ").Append(Name).Append("\n");
			sb.Append("  Lei: ").Append(Lei).Append("\n");
			sb.Append("  LegalName: ").Append(LegalName).Append("\n");
			sb.Append("  StockExchange: ").Append(StockExchange).Append("\n");
			sb.Append("  Sic: ").Append(Sic).Append("\n");
			sb.Append("  ShortDescription: ").Append(ShortDescription).Append("\n");
			sb.Append("  LongDescription: ").Append(LongDescription).Append("\n");
			sb.Append("  Ceo: ").Append(Ceo).Append("\n");
			sb.Append("  CompanyUrl: ").Append(CompanyUrl).Append("\n");
			sb.Append("  BusinessAddress: ").Append(BusinessAddress).Append("\n");
			sb.Append("  MailingAddress: ").Append(MailingAddress).Append("\n");
			sb.Append("  BusinessPhoneNo: ").Append(BusinessPhoneNo).Append("\n");
			sb.Append("  HqAddress1: ").Append(HqAddress1).Append("\n");
			sb.Append("  HqAddress2: ").Append(HqAddress2).Append("\n");
			sb.Append("  HqAddressCity: ").Append(HqAddressCity).Append("\n");
			sb.Append("  HqAddressPostalCode: ").Append(HqAddressPostalCode).Append("\n");
			sb.Append("  EntityLegalForm: ").Append(EntityLegalForm).Append("\n");
			sb.Append("  Cik: ").Append(Cik).Append("\n");
			sb.Append("  LatestFilingDate: ").Append(LatestFilingDate).Append("\n");
			sb.Append("  HqState: ").Append(HqState).Append("\n");
			sb.Append("  HqCountry: ").Append(HqCountry).Append("\n");
			sb.Append("  IncState: ").Append(IncState).Append("\n");
			sb.Append("  IncCountry: ").Append(IncCountry).Append("\n");
			sb.Append("  Employees: ").Append(Employees).Append("\n");
			sb.Append("  EntityStatus: ").Append(EntityStatus).Append("\n");
			sb.Append("  Sector: ").Append(Sector).Append("\n");
			sb.Append("  IndustryCategory: ").Append(IndustryCategory).Append("\n");
			sb.Append("  IndustryGroup: ").Append(IndustryGroup).Append("\n");
			sb.Append("  Template: ").Append(Template).Append("\n");
			sb.Append("  StandardizedActive: ").Append(StandardizedActive).Append("\n");
			sb.Append("  FirstFundamentalDate: ").Append(FirstFundamentalDate).Append("\n");
			sb.Append("  LastFundamentalDate: ").Append(LastFundamentalDate).Append("\n");
			sb.Append("  FirstStockPriceDate: ").Append(FirstStockPriceDate).Append("\n");
			sb.Append("  LastStockPriceDate: ").Append(LastStockPriceDate).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}

		/// <summary>
		///     Returns the JSON string presentation of the object
		/// </summary>
		/// <returns>JSON string presentation of the object</returns>
		public string ToJson()
		{
			return JsonSerializer.Serialize(this, new JsonSerializerOptions {WriteIndented = true});
		}

		/// <summary>
		///     Returns true if objects are equal
		/// </summary>
		/// <param name="input">Object to be compared</param>
		/// <returns>Boolean</returns>
		public override bool Equals(object input)
		{
			return Equals(input as Company);
		}

		/// <summary>
		///     Gets the hash code
		/// </summary>
		/// <returns>Hash code</returns>
		public override int GetHashCode()
		{
			unchecked // Overflow is fine, just wrap
			{
				var hashCode = 41;
				if (Id != null)
					hashCode = hashCode * 59 + Id.GetHashCode();
				if (Ticker != null)
					hashCode = hashCode * 59 + Ticker.GetHashCode();
				if (Name != null)
					hashCode = hashCode * 59 + Name.GetHashCode();
				if (Lei != null)
					hashCode = hashCode * 59 + Lei.GetHashCode();
				if (LegalName != null)
					hashCode = hashCode * 59 + LegalName.GetHashCode();
				if (StockExchange != null)
					hashCode = hashCode * 59 + StockExchange.GetHashCode();
				if (Sic != null)
					hashCode = hashCode * 59 + Sic.GetHashCode();
				if (ShortDescription != null)
					hashCode = hashCode * 59 + ShortDescription.GetHashCode();
				if (LongDescription != null)
					hashCode = hashCode * 59 + LongDescription.GetHashCode();
				if (Ceo != null)
					hashCode = hashCode * 59 + Ceo.GetHashCode();
				if (CompanyUrl != null)
					hashCode = hashCode * 59 + CompanyUrl.GetHashCode();
				if (BusinessAddress != null)
					hashCode = hashCode * 59 + BusinessAddress.GetHashCode();
				if (MailingAddress != null)
					hashCode = hashCode * 59 + MailingAddress.GetHashCode();
				if (BusinessPhoneNo != null)
					hashCode = hashCode * 59 + BusinessPhoneNo.GetHashCode();
				if (HqAddress1 != null)
					hashCode = hashCode * 59 + HqAddress1.GetHashCode();
				if (HqAddress2 != null)
					hashCode = hashCode * 59 + HqAddress2.GetHashCode();
				if (HqAddressCity != null)
					hashCode = hashCode * 59 + HqAddressCity.GetHashCode();
				if (HqAddressPostalCode != null)
					hashCode = hashCode * 59 + HqAddressPostalCode.GetHashCode();
				if (EntityLegalForm != null)
					hashCode = hashCode * 59 + EntityLegalForm.GetHashCode();
				if (Cik != null)
					hashCode = hashCode * 59 + Cik.GetHashCode();
				if (LatestFilingDate != null)
					hashCode = hashCode * 59 + LatestFilingDate.GetHashCode();
				if (HqState != null)
					hashCode = hashCode * 59 + HqState.GetHashCode();
				if (HqCountry != null)
					hashCode = hashCode * 59 + HqCountry.GetHashCode();
				if (IncState != null)
					hashCode = hashCode * 59 + IncState.GetHashCode();
				if (IncCountry != null)
					hashCode = hashCode * 59 + IncCountry.GetHashCode();
				if (Employees != null)
					hashCode = hashCode * 59 + Employees.GetHashCode();
				if (EntityStatus != null)
					hashCode = hashCode * 59 + EntityStatus.GetHashCode();
				if (Sector != null)
					hashCode = hashCode * 59 + Sector.GetHashCode();
				if (IndustryCategory != null)
					hashCode = hashCode * 59 + IndustryCategory.GetHashCode();
				if (IndustryGroup != null)
					hashCode = hashCode * 59 + IndustryGroup.GetHashCode();
				if (Template != null)
					hashCode = hashCode * 59 + Template.GetHashCode();
				if (StandardizedActive != null)
					hashCode = hashCode * 59 + StandardizedActive.GetHashCode();
				if (FirstFundamentalDate != null)
					hashCode = hashCode * 59 + FirstFundamentalDate.GetHashCode();
				if (LastFundamentalDate != null)
					hashCode = hashCode * 59 + LastFundamentalDate.GetHashCode();
				if (FirstStockPriceDate != null)
					hashCode = hashCode * 59 + FirstStockPriceDate.GetHashCode();
				if (LastStockPriceDate != null)
					hashCode = hashCode * 59 + LastStockPriceDate.GetHashCode();
				return hashCode;
			}
		}
	}
}