using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using Intrinio.SDK.Client;

namespace Intrinio.SDK.Model
{
	/// <summary>
	///     A financial instrument representing shares of ownership in a publicly-traded company
	/// </summary>
	[DataContract]
	public class Security : IEquatable<Security>, IValidatableObject
	{
		/// <summary>
		///     Initializes a new instance of the <see cref="Security" /> class.
		/// </summary>
		/// <param name="Id">The Intrinio ID for the Security.</param>
		/// <param name="CompanyId">The Intrinio ID for the company for which the Security is issued.</param>
		/// <param name="Name">The name of the Security.</param>
		/// <param name="Type">The Security&#39;s type.</param>
		/// <param name="Code">
		///     A 2-3 digit code classifying the Security (&lt;a href&#x3D;\&quot;
		///     https://docs.intrinio.com/documentation/security_codes\&quot; target&#x3D;\&quot;_blank\&quot;&gt;reference&lt;/a
		///     &gt;).
		/// </param>
		/// <param name="ShareClass">The Security&#39;s share class (if applicable).</param>
		/// <param name="Currency">The currency in which the Security is traded on the exchange.</param>
		/// <param name="RoundLotSize">The normal unit of trading.</param>
		/// <param name="Ticker">The common ticker.</param>
		/// <param name="ExchangeTicker">The exchange-level ticker.</param>
		/// <param name="CompositeTicker">The country-composite ticker.</param>
		/// <param name="AlternateTickers">Alternate formats of the common ticker.</param>
		/// <param name="Figi">The exchange-level OpenFIGI identifier.</param>
		/// <param name="Cik">Central Index Key issued by the SEC, which is the unique identifier for all owner filings.</param>
		/// <param name="CompositeFigi">The country-composite OpenFIGI identifier.</param>
		/// <param name="ShareClassFigi">The global-composite OpenFIGI identifier.</param>
		/// <param name="FigiUniqueid">The OpenFIGI unique ID.</param>
		/// <param name="Active">If true, the Security is active and has been recently traded.</param>
		/// <param name="Etf">If true, this Security is an ETF.</param>
		/// <param name="Delisted">If true, the Security is no longer traded on the exchange.</param>
		/// <param name="PrimaryListing">
		///     If true, the Security is the primary issue for the company, otherwise it is a secondary
		///     issue on a secondary stock exchange.
		/// </param>
		/// <param name="PrimarySecurity">
		///     If true, the Security is considered by Intrinio to be the primary Security for its
		///     company.
		/// </param>
		/// <param name="FirstStockPrice">The date of the first recorded stock price.</param>
		/// <param name="LastStockPrice">The date of the last recorded stock price (or the most recent trading day).</param>
		/// <param name="LastStockPriceAdjustment">The date of the last stock price adjustment (dividend, split, etc).</param>
		/// <param name="LastCorporateAction">The date of the last corporate action.</param>
		/// <param name="PreviousTickers">Previous tickers used by this security.</param>
		/// <param name="ListingExchangeMic">The MIC code of the exchange on which this security primarily trades.</param>
		public Security(string Id = default, string CompanyId = default, string Name = default, string Type = default,
			string Code = default, string ShareClass = default, string Currency = default,
			decimal? RoundLotSize = default, string Ticker = default, string ExchangeTicker = default,
			string CompositeTicker = default, List<string> AlternateTickers = default, string Figi = default,
			string Cik = default, string CompositeFigi = default, string ShareClassFigi = default,
			string FigiUniqueid = default, bool? Active = default, bool? Etf = default, bool? Delisted = default,
			bool? PrimaryListing = default, bool? PrimarySecurity = default, DateTime? FirstStockPrice = default,
			DateTime? LastStockPrice = default, DateTime? LastStockPriceAdjustment = default,
			DateTime? LastCorporateAction = default, List<string> PreviousTickers = default,
			string ListingExchangeMic = default)
		{
			this.Id = Id;
			this.CompanyId = CompanyId;
			this.Name = Name;
			this.Type = Type;
			this.Code = Code;
			this.ShareClass = ShareClass;
			this.Currency = Currency;
			this.RoundLotSize = RoundLotSize;
			this.Ticker = Ticker;
			this.ExchangeTicker = ExchangeTicker;
			this.CompositeTicker = CompositeTicker;
			this.AlternateTickers = AlternateTickers;
			this.Figi = Figi;
			this.Cik = Cik;
			this.CompositeFigi = CompositeFigi;
			this.ShareClassFigi = ShareClassFigi;
			this.FigiUniqueid = FigiUniqueid;
			this.Active = Active;
			this.Etf = Etf;
			this.Delisted = Delisted;
			this.PrimaryListing = PrimaryListing;
			this.PrimarySecurity = PrimarySecurity;
			this.FirstStockPrice = FirstStockPrice;
			this.LastStockPrice = LastStockPrice;
			this.LastStockPriceAdjustment = LastStockPriceAdjustment;
			this.LastCorporateAction = LastCorporateAction;
			this.PreviousTickers = PreviousTickers;
			this.ListingExchangeMic = ListingExchangeMic;
		}

		/// <summary>
		///     The Intrinio ID for the Security
		/// </summary>
		/// <value>The Intrinio ID for the Security</value>
		[DataMember(Name = "id", EmitDefaultValue = false)]
		public string Id { get; set; }

		/// <summary>
		///     The Intrinio ID for the company for which the Security is issued
		/// </summary>
		/// <value>The Intrinio ID for the company for which the Security is issued</value>
		[DataMember(Name = "company_id", EmitDefaultValue = false)]
		public string CompanyId { get; set; }

		/// <summary>
		///     The name of the Security
		/// </summary>
		/// <value>The name of the Security</value>
		[DataMember(Name = "name", EmitDefaultValue = false)]
		public string Name { get; set; }

		/// <summary>
		///     The Security&#39;s type
		/// </summary>
		/// <value>The Security&#39;s type</value>
		[DataMember(Name = "type", EmitDefaultValue = false)]
		public string Type { get; set; }

		/// <summary>
		///     A 2-3 digit code classifying the Security (&lt;a href&#x3D;\&quot;
		///     https://docs.intrinio.com/documentation/security_codes\&quot; target&#x3D;\&quot;_blank\&quot;&gt;reference&lt;/a
		///     &gt;)
		/// </summary>
		/// <value>
		///     A 2-3 digit code classifying the Security (&lt;a href&#x3D;\&quot;
		///     https://docs.intrinio.com/documentation/security_codes\&quot; target&#x3D;\&quot;_blank\&quot;&gt;reference&lt;/a
		///     &gt;)
		/// </value>
		[DataMember(Name = "code", EmitDefaultValue = false)]
		public string Code { get; set; }

		/// <summary>
		///     The Security&#39;s share class (if applicable)
		/// </summary>
		/// <value>The Security&#39;s share class (if applicable)</value>
		[DataMember(Name = "share_class", EmitDefaultValue = false)]
		public string ShareClass { get; set; }

		/// <summary>
		///     The currency in which the Security is traded on the exchange
		/// </summary>
		/// <value>The currency in which the Security is traded on the exchange</value>
		[DataMember(Name = "currency", EmitDefaultValue = false)]
		public string Currency { get; set; }

		/// <summary>
		///     The normal unit of trading
		/// </summary>
		/// <value>The normal unit of trading</value>
		[DataMember(Name = "round_lot_size", EmitDefaultValue = false)]
		public decimal? RoundLotSize { get; set; }

		/// <summary>
		///     The common ticker
		/// </summary>
		/// <value>The common ticker</value>
		[DataMember(Name = "ticker", EmitDefaultValue = false)]
		public string Ticker { get; set; }

		/// <summary>
		///     The exchange-level ticker
		/// </summary>
		/// <value>The exchange-level ticker</value>
		[DataMember(Name = "exchange_ticker", EmitDefaultValue = false)]
		public string ExchangeTicker { get; set; }

		/// <summary>
		///     The country-composite ticker
		/// </summary>
		/// <value>The country-composite ticker</value>
		[DataMember(Name = "composite_ticker", EmitDefaultValue = false)]
		public string CompositeTicker { get; set; }

		/// <summary>
		///     Alternate formats of the common ticker
		/// </summary>
		/// <value>Alternate formats of the common ticker</value>
		[DataMember(Name = "alternate_tickers", EmitDefaultValue = false)]
		public List<string> AlternateTickers { get; set; }

		/// <summary>
		///     The exchange-level OpenFIGI identifier
		/// </summary>
		/// <value>The exchange-level OpenFIGI identifier</value>
		[DataMember(Name = "figi", EmitDefaultValue = false)]
		public string Figi { get; set; }

		/// <summary>
		///     Central Index Key issued by the SEC, which is the unique identifier for all owner filings
		/// </summary>
		/// <value>Central Index Key issued by the SEC, which is the unique identifier for all owner filings</value>
		[DataMember(Name = "cik", EmitDefaultValue = false)]
		public string Cik { get; set; }

		/// <summary>
		///     The country-composite OpenFIGI identifier
		/// </summary>
		/// <value>The country-composite OpenFIGI identifier</value>
		[DataMember(Name = "composite_figi", EmitDefaultValue = false)]
		public string CompositeFigi { get; set; }

		/// <summary>
		///     The global-composite OpenFIGI identifier
		/// </summary>
		/// <value>The global-composite OpenFIGI identifier</value>
		[DataMember(Name = "share_class_figi", EmitDefaultValue = false)]
		public string ShareClassFigi { get; set; }

		/// <summary>
		///     The OpenFIGI unique ID
		/// </summary>
		/// <value>The OpenFIGI unique ID</value>
		[DataMember(Name = "figi_uniqueid", EmitDefaultValue = false)]
		public string FigiUniqueid { get; set; }

		/// <summary>
		///     If true, the Security is active and has been recently traded
		/// </summary>
		/// <value>If true, the Security is active and has been recently traded</value>
		[DataMember(Name = "active", EmitDefaultValue = false)]
		public bool? Active { get; set; }

		/// <summary>
		///     If true, this Security is an ETF
		/// </summary>
		/// <value>If true, this Security is an ETF</value>
		[DataMember(Name = "etf", EmitDefaultValue = false)]
		public bool? Etf { get; set; }

		/// <summary>
		///     If true, the Security is no longer traded on the exchange
		/// </summary>
		/// <value>If true, the Security is no longer traded on the exchange</value>
		[DataMember(Name = "delisted", EmitDefaultValue = false)]
		public bool? Delisted { get; set; }

		/// <summary>
		///     If true, the Security is the primary issue for the company, otherwise it is a secondary issue on a secondary stock
		///     exchange
		/// </summary>
		/// <value>
		///     If true, the Security is the primary issue for the company, otherwise it is a secondary issue on a secondary
		///     stock exchange
		/// </value>
		[DataMember(Name = "primary_listing", EmitDefaultValue = false)]
		public bool? PrimaryListing { get; set; }

		/// <summary>
		///     If true, the Security is considered by Intrinio to be the primary Security for its company
		/// </summary>
		/// <value>If true, the Security is considered by Intrinio to be the primary Security for its company</value>
		[DataMember(Name = "primary_security", EmitDefaultValue = false)]
		public bool? PrimarySecurity { get; set; }

		/// <summary>
		///     The date of the first recorded stock price
		/// </summary>
		/// <value>The date of the first recorded stock price</value>
		[DataMember(Name = "first_stock_price", EmitDefaultValue = false)]
		
		public DateTime? FirstStockPrice { get; set; }

		/// <summary>
		///     The date of the last recorded stock price (or the most recent trading day)
		/// </summary>
		/// <value>The date of the last recorded stock price (or the most recent trading day)</value>
		[DataMember(Name = "last_stock_price", EmitDefaultValue = false)]
		
		public DateTime? LastStockPrice { get; set; }

		/// <summary>
		///     The date of the last stock price adjustment (dividend, split, etc)
		/// </summary>
		/// <value>The date of the last stock price adjustment (dividend, split, etc)</value>
		[DataMember(Name = "last_stock_price_adjustment", EmitDefaultValue = false)]
		
		public DateTime? LastStockPriceAdjustment { get; set; }

		/// <summary>
		///     The date of the last corporate action
		/// </summary>
		/// <value>The date of the last corporate action</value>
		[DataMember(Name = "last_corporate_action", EmitDefaultValue = false)]
		
		public DateTime? LastCorporateAction { get; set; }

		/// <summary>
		///     Previous tickers used by this security
		/// </summary>
		/// <value>Previous tickers used by this security</value>
		[DataMember(Name = "previous_tickers", EmitDefaultValue = false)]
		public List<string> PreviousTickers { get; set; }

		/// <summary>
		///     The MIC code of the exchange on which this security primarily trades
		/// </summary>
		/// <value>The MIC code of the exchange on which this security primarily trades</value>
		[DataMember(Name = "listing_exchange_mic", EmitDefaultValue = false)]
		public string ListingExchangeMic { get; set; }

		/// <summary>
		///     Returns true if Security instances are equal
		/// </summary>
		/// <param name="input">Instance of Security to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(Security input)
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
					CompanyId == input.CompanyId ||
					CompanyId != null &&
					CompanyId.Equals(input.CompanyId)
				) &&
				(
					Name == input.Name ||
					Name != null &&
					Name.Equals(input.Name)
				) &&
				(
					Type == input.Type ||
					Type != null &&
					Type.Equals(input.Type)
				) &&
				(
					Code == input.Code ||
					Code != null &&
					Code.Equals(input.Code)
				) &&
				(
					ShareClass == input.ShareClass ||
					ShareClass != null &&
					ShareClass.Equals(input.ShareClass)
				) &&
				(
					Currency == input.Currency ||
					Currency != null &&
					Currency.Equals(input.Currency)
				) &&
				(
					RoundLotSize == input.RoundLotSize ||
					RoundLotSize != null &&
					RoundLotSize.Equals(input.RoundLotSize)
				) &&
				(
					Ticker == input.Ticker ||
					Ticker != null &&
					Ticker.Equals(input.Ticker)
				) &&
				(
					ExchangeTicker == input.ExchangeTicker ||
					ExchangeTicker != null &&
					ExchangeTicker.Equals(input.ExchangeTicker)
				) &&
				(
					CompositeTicker == input.CompositeTicker ||
					CompositeTicker != null &&
					CompositeTicker.Equals(input.CompositeTicker)
				) &&
				(
					AlternateTickers == input.AlternateTickers ||
					AlternateTickers != null &&
					AlternateTickers.SequenceEqual(input.AlternateTickers)
				) &&
				(
					Figi == input.Figi ||
					Figi != null &&
					Figi.Equals(input.Figi)
				) &&
				(
					Cik == input.Cik ||
					Cik != null &&
					Cik.Equals(input.Cik)
				) &&
				(
					CompositeFigi == input.CompositeFigi ||
					CompositeFigi != null &&
					CompositeFigi.Equals(input.CompositeFigi)
				) &&
				(
					ShareClassFigi == input.ShareClassFigi ||
					ShareClassFigi != null &&
					ShareClassFigi.Equals(input.ShareClassFigi)
				) &&
				(
					FigiUniqueid == input.FigiUniqueid ||
					FigiUniqueid != null &&
					FigiUniqueid.Equals(input.FigiUniqueid)
				) &&
				(
					Active == input.Active ||
					Active != null &&
					Active.Equals(input.Active)
				) &&
				(
					Etf == input.Etf ||
					Etf != null &&
					Etf.Equals(input.Etf)
				) &&
				(
					Delisted == input.Delisted ||
					Delisted != null &&
					Delisted.Equals(input.Delisted)
				) &&
				(
					PrimaryListing == input.PrimaryListing ||
					PrimaryListing != null &&
					PrimaryListing.Equals(input.PrimaryListing)
				) &&
				(
					PrimarySecurity == input.PrimarySecurity ||
					PrimarySecurity != null &&
					PrimarySecurity.Equals(input.PrimarySecurity)
				) &&
				(
					FirstStockPrice == input.FirstStockPrice ||
					FirstStockPrice != null &&
					FirstStockPrice.Equals(input.FirstStockPrice)
				) &&
				(
					LastStockPrice == input.LastStockPrice ||
					LastStockPrice != null &&
					LastStockPrice.Equals(input.LastStockPrice)
				) &&
				(
					LastStockPriceAdjustment == input.LastStockPriceAdjustment ||
					LastStockPriceAdjustment != null &&
					LastStockPriceAdjustment.Equals(input.LastStockPriceAdjustment)
				) &&
				(
					LastCorporateAction == input.LastCorporateAction ||
					LastCorporateAction != null &&
					LastCorporateAction.Equals(input.LastCorporateAction)
				) &&
				(
					PreviousTickers == input.PreviousTickers ||
					PreviousTickers != null &&
					PreviousTickers.SequenceEqual(input.PreviousTickers)
				) &&
				(
					ListingExchangeMic == input.ListingExchangeMic ||
					ListingExchangeMic != null &&
					ListingExchangeMic.Equals(input.ListingExchangeMic)
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
			sb.Append("class Security {\n");
			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  CompanyId: ").Append(CompanyId).Append("\n");
			sb.Append("  Name: ").Append(Name).Append("\n");
			sb.Append("  Type: ").Append(Type).Append("\n");
			sb.Append("  Code: ").Append(Code).Append("\n");
			sb.Append("  ShareClass: ").Append(ShareClass).Append("\n");
			sb.Append("  Currency: ").Append(Currency).Append("\n");
			sb.Append("  RoundLotSize: ").Append(RoundLotSize).Append("\n");
			sb.Append("  Ticker: ").Append(Ticker).Append("\n");
			sb.Append("  ExchangeTicker: ").Append(ExchangeTicker).Append("\n");
			sb.Append("  CompositeTicker: ").Append(CompositeTicker).Append("\n");
			sb.Append("  AlternateTickers: ").Append(AlternateTickers).Append("\n");
			sb.Append("  Figi: ").Append(Figi).Append("\n");
			sb.Append("  Cik: ").Append(Cik).Append("\n");
			sb.Append("  CompositeFigi: ").Append(CompositeFigi).Append("\n");
			sb.Append("  ShareClassFigi: ").Append(ShareClassFigi).Append("\n");
			sb.Append("  FigiUniqueid: ").Append(FigiUniqueid).Append("\n");
			sb.Append("  Active: ").Append(Active).Append("\n");
			sb.Append("  Etf: ").Append(Etf).Append("\n");
			sb.Append("  Delisted: ").Append(Delisted).Append("\n");
			sb.Append("  PrimaryListing: ").Append(PrimaryListing).Append("\n");
			sb.Append("  PrimarySecurity: ").Append(PrimarySecurity).Append("\n");
			sb.Append("  FirstStockPrice: ").Append(FirstStockPrice).Append("\n");
			sb.Append("  LastStockPrice: ").Append(LastStockPrice).Append("\n");
			sb.Append("  LastStockPriceAdjustment: ").Append(LastStockPriceAdjustment).Append("\n");
			sb.Append("  LastCorporateAction: ").Append(LastCorporateAction).Append("\n");
			sb.Append("  PreviousTickers: ").Append(PreviousTickers).Append("\n");
			sb.Append("  ListingExchangeMic: ").Append(ListingExchangeMic).Append("\n");
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
			return Equals(input as Security);
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
				if (CompanyId != null)
					hashCode = hashCode * 59 + CompanyId.GetHashCode();
				if (Name != null)
					hashCode = hashCode * 59 + Name.GetHashCode();
				if (Type != null)
					hashCode = hashCode * 59 + Type.GetHashCode();
				if (Code != null)
					hashCode = hashCode * 59 + Code.GetHashCode();
				if (ShareClass != null)
					hashCode = hashCode * 59 + ShareClass.GetHashCode();
				if (Currency != null)
					hashCode = hashCode * 59 + Currency.GetHashCode();
				if (RoundLotSize != null)
					hashCode = hashCode * 59 + RoundLotSize.GetHashCode();
				if (Ticker != null)
					hashCode = hashCode * 59 + Ticker.GetHashCode();
				if (ExchangeTicker != null)
					hashCode = hashCode * 59 + ExchangeTicker.GetHashCode();
				if (CompositeTicker != null)
					hashCode = hashCode * 59 + CompositeTicker.GetHashCode();
				if (AlternateTickers != null)
					hashCode = hashCode * 59 + AlternateTickers.GetHashCode();
				if (Figi != null)
					hashCode = hashCode * 59 + Figi.GetHashCode();
				if (Cik != null)
					hashCode = hashCode * 59 + Cik.GetHashCode();
				if (CompositeFigi != null)
					hashCode = hashCode * 59 + CompositeFigi.GetHashCode();
				if (ShareClassFigi != null)
					hashCode = hashCode * 59 + ShareClassFigi.GetHashCode();
				if (FigiUniqueid != null)
					hashCode = hashCode * 59 + FigiUniqueid.GetHashCode();
				if (Active != null)
					hashCode = hashCode * 59 + Active.GetHashCode();
				if (Etf != null)
					hashCode = hashCode * 59 + Etf.GetHashCode();
				if (Delisted != null)
					hashCode = hashCode * 59 + Delisted.GetHashCode();
				if (PrimaryListing != null)
					hashCode = hashCode * 59 + PrimaryListing.GetHashCode();
				if (PrimarySecurity != null)
					hashCode = hashCode * 59 + PrimarySecurity.GetHashCode();
				if (FirstStockPrice != null)
					hashCode = hashCode * 59 + FirstStockPrice.GetHashCode();
				if (LastStockPrice != null)
					hashCode = hashCode * 59 + LastStockPrice.GetHashCode();
				if (LastStockPriceAdjustment != null)
					hashCode = hashCode * 59 + LastStockPriceAdjustment.GetHashCode();
				if (LastCorporateAction != null)
					hashCode = hashCode * 59 + LastCorporateAction.GetHashCode();
				if (PreviousTickers != null)
					hashCode = hashCode * 59 + PreviousTickers.GetHashCode();
				if (ListingExchangeMic != null)
					hashCode = hashCode * 59 + ListingExchangeMic.GetHashCode();
				return hashCode;
			}
		}
	}
}