using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using Intrinio.SDK.Enumerator;

namespace Intrinio.SDK.Model
{
	/// <summary>
	///     A record of a company&#39;s initial public offering (IPO). The act of \&quot;going public\&quot; is initiated by an
	///     IPO, at which point the company&#39;s stock trades on a major stock exchange (such as NYSE or NASDAQ)
	/// </summary>
	[DataContract]
	public class CompanyInitialPublicOffering : IEquatable<CompanyInitialPublicOffering>, IValidatableObject
	{

		/// <summary>
		///     Initializes a new instance of the <see cref="CompanyInitialPublicOffering" /> class.
		/// </summary>
		/// <param name="Id">The Intrinio ID for the IPO.</param>
		/// <param name="Ticker">The ticker under which the Company will be traded after the IPO takes place.</param>
		/// <param name="Date">The date of the IPO, when the stock first trades on a major exchange.</param>
		/// <param name="Status">
		///     The status of the IPO. Upcoming IPOs have not taken place yet but are expected to. Priced IPOs
		///     have taken place. Withdrawn IPOs were expected to take place, but were subsequently withdrawn and did not take
		///     place.
		/// </param>
		/// <param name="Exchange">
		///     The acronym of the stock exchange that the company is going to trade publicly on. Typically NYSE
		///     or NASDAQ.
		/// </param>
		/// <param name="OfferAmount">
		///     The total dollar amount of shares offered in the IPO. Typically this is share price * share
		///     count.
		/// </param>
		/// <param name="SharePrice">The price per share at which the IPO was offered.</param>
		/// <param name="SharePriceLowest">
		///     The expected lowest price per share at which the IPO will be offered. Before an IPO is
		///     priced, companies typically provide a range of prices per share at which they expect to offer the IPO (typically
		///     available for upcoming IPOs).
		/// </param>
		/// <param name="SharePriceHighest">
		///     The expected highest price per share at which the IPO will be offered. Before an IPO is
		///     priced, companies typically provide a range of prices per share at which they expect to offer the IPO (typically
		///     available for upcoming IPOs).
		/// </param>
		/// <param name="ShareCount">The number of shares offered in the IPO.</param>
		/// <param name="ShareCountLowest">
		///     The expected lowest number of shares that will be offered in the IPO. Before an IPO is
		///     priced, companies typically provide a range of shares that they expect to offer in the IPO (typically available for
		///     upcoming IPOs).
		/// </param>
		/// <param name="ShareCountHighest">
		///     The expected highest number of shares that will be offered in the IPO. Before an IPO is
		///     priced, companies typically provide a range of shares that they expect to offer in the IPO (typically available for
		///     upcoming IPOs).
		/// </param>
		/// <param name="AnnouncementUrl">The URL to the company&#39;s announcement of the IPO.</param>
		/// <param name="SecReportUrl">
		///     The IRL to the company&#39;s S-1, S-1/A, F-1, or F-1/A SEC filing, which is required to be
		///     filed before an IPO takes place..
		/// </param>
		/// <param name="OpenPrice">The opening price at the beginning of the first trading day (only available for priced IPOs).</param>
		/// <param name="ClosePrice">The closing price at the end of the first trading day (only available for priced IPOs).</param>
		/// <param name="Volume">The volume at the end of the first trading day (only available for priced IPOs).</param>
		/// <param name="DayChange">
		///     The percentage change between the open price and the close price on the first trading day (only
		///     available for priced IPOs).
		/// </param>
		/// <param name="WeekChange">
		///     The percentage change between the open price on the first trading day and the close price
		///     approximately a week after the first trading day (only available for priced IPOs).
		/// </param>
		/// <param name="MonthChange">
		///     The percentage change between the open price on the first trading day and the close price
		///     approximately a month after the first trading day (only available for priced IPOs).
		/// </param>
		/// <param name="Company">The Company that is going public via the IPO.</param>
		/// <param name="Security">The primary Security for the Company that is going public via the IPO.</param>
		public CompanyInitialPublicOffering(string Id = default, string Ticker = default, DateTime? Date = default,
			IpoStatusEnum? Status = default, string Exchange = default, decimal? OfferAmount = default,
			decimal? SharePrice = default, decimal? SharePriceLowest = default, decimal? SharePriceHighest = default,
			decimal? ShareCount = default, decimal? ShareCountLowest = default, decimal? ShareCountHighest = default,
			string AnnouncementUrl = default, string SecReportUrl = default, decimal? OpenPrice = default,
			decimal? ClosePrice = default, decimal? Volume = default, decimal? DayChange = default,
			decimal? WeekChange = default, decimal? MonthChange = default, CompanySummary Company = default,
			SecuritySummary Security = default)
		{
			this.Id = Id;
			this.Ticker = Ticker;
			this.Date = Date;
			this.Status = Status;
			this.Exchange = Exchange;
			this.OfferAmount = OfferAmount;
			this.SharePrice = SharePrice;
			this.SharePriceLowest = SharePriceLowest;
			this.SharePriceHighest = SharePriceHighest;
			this.ShareCount = ShareCount;
			this.ShareCountLowest = ShareCountLowest;
			this.ShareCountHighest = ShareCountHighest;
			this.AnnouncementUrl = AnnouncementUrl;
			this.SecReportUrl = SecReportUrl;
			this.OpenPrice = OpenPrice;
			this.ClosePrice = ClosePrice;
			this.Volume = Volume;
			this.DayChange = DayChange;
			this.WeekChange = WeekChange;
			this.MonthChange = MonthChange;
			this.Company = Company;
			this.Security = Security;
		}

		/// <summary>
		///     The status of the IPO. Upcoming IPOs have not taken place yet but are expected to. Priced IPOs have taken place.
		///     Withdrawn IPOs were expected to take place, but were subsequently withdrawn and did not take place
		/// </summary>
		/// <value>
		///     The status of the IPO. Upcoming IPOs have not taken place yet but are expected to. Priced IPOs have taken place.
		///     Withdrawn IPOs were expected to take place, but were subsequently withdrawn and did not take place
		/// </value>
		[DataMember(Name = "status", EmitDefaultValue = false)]
		public IpoStatusEnum? Status { get; set; }

		/// <summary>
		///     The Intrinio ID for the IPO
		/// </summary>
		/// <value>The Intrinio ID for the IPO</value>
		[DataMember(Name = "id", EmitDefaultValue = false)]
		public string Id { get; set; }

		/// <summary>
		///     The ticker under which the Company will be traded after the IPO takes place
		/// </summary>
		/// <value>The ticker under which the Company will be traded after the IPO takes place</value>
		[DataMember(Name = "ticker", EmitDefaultValue = false)]
		public string Ticker { get; set; }

		/// <summary>
		///     The date of the IPO, when the stock first trades on a major exchange
		/// </summary>
		/// <value>The date of the IPO, when the stock first trades on a major exchange</value>
		[DataMember(Name = "date", EmitDefaultValue = false)]
		public DateTime? Date { get; set; }


		/// <summary>
		///     The acronym of the stock exchange that the company is going to trade publicly on. Typically NYSE or NASDAQ
		/// </summary>
		/// <value>The acronym of the stock exchange that the company is going to trade publicly on. Typically NYSE or NASDAQ</value>
		[DataMember(Name = "exchange", EmitDefaultValue = false)]
		public string Exchange { get; set; }

		/// <summary>
		///     The total dollar amount of shares offered in the IPO. Typically this is share price * share count
		/// </summary>
		/// <value>The total dollar amount of shares offered in the IPO. Typically this is share price * share count</value>
		[DataMember(Name = "offer_amount", EmitDefaultValue = false)]
		public decimal? OfferAmount { get; set; }

		/// <summary>
		///     The price per share at which the IPO was offered
		/// </summary>
		/// <value>The price per share at which the IPO was offered</value>
		[DataMember(Name = "share_price", EmitDefaultValue = false)]
		public decimal? SharePrice { get; set; }

		/// <summary>
		///     The expected lowest price per share at which the IPO will be offered. Before an IPO is priced, companies typically
		///     provide a range of prices per share at which they expect to offer the IPO (typically available for upcoming IPOs)
		/// </summary>
		/// <value>
		///     The expected lowest price per share at which the IPO will be offered. Before an IPO is priced, companies
		///     typically provide a range of prices per share at which they expect to offer the IPO (typically available for
		///     upcoming IPOs)
		/// </value>
		[DataMember(Name = "share_price_lowest", EmitDefaultValue = false)]
		public decimal? SharePriceLowest { get; set; }

		/// <summary>
		///     The expected highest price per share at which the IPO will be offered. Before an IPO is priced, companies typically
		///     provide a range of prices per share at which they expect to offer the IPO (typically available for upcoming IPOs)
		/// </summary>
		/// <value>
		///     The expected highest price per share at which the IPO will be offered. Before an IPO is priced, companies
		///     typically provide a range of prices per share at which they expect to offer the IPO (typically available for
		///     upcoming IPOs)
		/// </value>
		[DataMember(Name = "share_price_highest", EmitDefaultValue = false)]
		public decimal? SharePriceHighest { get; set; }

		/// <summary>
		///     The number of shares offered in the IPO
		/// </summary>
		/// <value>The number of shares offered in the IPO</value>
		[DataMember(Name = "share_count", EmitDefaultValue = false)]
		public decimal? ShareCount { get; set; }

		/// <summary>
		///     The expected lowest number of shares that will be offered in the IPO. Before an IPO is priced, companies typically
		///     provide a range of shares that they expect to offer in the IPO (typically available for upcoming IPOs)
		/// </summary>
		/// <value>
		///     The expected lowest number of shares that will be offered in the IPO. Before an IPO is priced, companies
		///     typically provide a range of shares that they expect to offer in the IPO (typically available for upcoming IPOs)
		/// </value>
		[DataMember(Name = "share_count_lowest", EmitDefaultValue = false)]
		public decimal? ShareCountLowest { get; set; }

		/// <summary>
		///     The expected highest number of shares that will be offered in the IPO. Before an IPO is priced, companies typically
		///     provide a range of shares that they expect to offer in the IPO (typically available for upcoming IPOs)
		/// </summary>
		/// <value>
		///     The expected highest number of shares that will be offered in the IPO. Before an IPO is priced, companies
		///     typically provide a range of shares that they expect to offer in the IPO (typically available for upcoming IPOs)
		/// </value>
		[DataMember(Name = "share_count_highest", EmitDefaultValue = false)]
		public decimal? ShareCountHighest { get; set; }

		/// <summary>
		///     The URL to the company&#39;s announcement of the IPO
		/// </summary>
		/// <value>The URL to the company&#39;s announcement of the IPO</value>
		[DataMember(Name = "announcement_url", EmitDefaultValue = false)]
		public string AnnouncementUrl { get; set; }

		/// <summary>
		///     The IRL to the company&#39;s S-1, S-1/A, F-1, or F-1/A SEC filing, which is required to be filed before an IPO
		///     takes place.
		/// </summary>
		/// <value>
		///     The IRL to the company&#39;s S-1, S-1/A, F-1, or F-1/A SEC filing, which is required to be filed before an IPO
		///     takes place.
		/// </value>
		[DataMember(Name = "sec_report_url", EmitDefaultValue = false)]
		public string SecReportUrl { get; set; }

		/// <summary>
		///     The opening price at the beginning of the first trading day (only available for priced IPOs)
		/// </summary>
		/// <value>The opening price at the beginning of the first trading day (only available for priced IPOs)</value>
		[DataMember(Name = "open_price", EmitDefaultValue = false)]
		public decimal? OpenPrice { get; set; }

		/// <summary>
		///     The closing price at the end of the first trading day (only available for priced IPOs)
		/// </summary>
		/// <value>The closing price at the end of the first trading day (only available for priced IPOs)</value>
		[DataMember(Name = "close_price", EmitDefaultValue = false)]
		public decimal? ClosePrice { get; set; }

		/// <summary>
		///     The volume at the end of the first trading day (only available for priced IPOs)
		/// </summary>
		/// <value>The volume at the end of the first trading day (only available for priced IPOs)</value>
		[DataMember(Name = "volume", EmitDefaultValue = false)]
		public decimal? Volume { get; set; }

		/// <summary>
		///     The percentage change between the open price and the close price on the first trading day (only available for
		///     priced IPOs)
		/// </summary>
		/// <value>
		///     The percentage change between the open price and the close price on the first trading day (only available for
		///     priced IPOs)
		/// </value>
		[DataMember(Name = "day_change", EmitDefaultValue = false)]
		public decimal? DayChange { get; set; }

		/// <summary>
		///     The percentage change between the open price on the first trading day and the close price approximately a week
		///     after the first trading day (only available for priced IPOs)
		/// </summary>
		/// <value>
		///     The percentage change between the open price on the first trading day and the close price approximately a week
		///     after the first trading day (only available for priced IPOs)
		/// </value>
		[DataMember(Name = "week_change", EmitDefaultValue = false)]
		public decimal? WeekChange { get; set; }

		/// <summary>
		///     The percentage change between the open price on the first trading day and the close price approximately a month
		///     after the first trading day (only available for priced IPOs)
		/// </summary>
		/// <value>
		///     The percentage change between the open price on the first trading day and the close price approximately a month
		///     after the first trading day (only available for priced IPOs)
		/// </value>
		[DataMember(Name = "month_change", EmitDefaultValue = false)]
		public decimal? MonthChange { get; set; }

		/// <summary>
		///     The Company that is going public via the IPO
		/// </summary>
		/// <value>The Company that is going public via the IPO</value>
		[DataMember(Name = "company", EmitDefaultValue = false)]
		public CompanySummary Company { get; set; }

		/// <summary>
		///     The primary Security for the Company that is going public via the IPO
		/// </summary>
		/// <value>The primary Security for the Company that is going public via the IPO</value>
		[DataMember(Name = "security", EmitDefaultValue = false)]
		public SecuritySummary Security { get; set; }

		/// <summary>
		///     Returns true if CompanyInitialPublicOffering instances are equal
		/// </summary>
		/// <param name="input">Instance of CompanyInitialPublicOffering to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(CompanyInitialPublicOffering input)
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
					Date == input.Date ||
					Date != null &&
					Date.Equals(input.Date)
				) &&
				(
					Status == input.Status ||
					Status != null &&
					Status.Equals(input.Status)
				) &&
				(
					Exchange == input.Exchange ||
					Exchange != null &&
					Exchange.Equals(input.Exchange)
				) &&
				(
					OfferAmount == input.OfferAmount ||
					OfferAmount != null &&
					OfferAmount.Equals(input.OfferAmount)
				) &&
				(
					SharePrice == input.SharePrice ||
					SharePrice != null &&
					SharePrice.Equals(input.SharePrice)
				) &&
				(
					SharePriceLowest == input.SharePriceLowest ||
					SharePriceLowest != null &&
					SharePriceLowest.Equals(input.SharePriceLowest)
				) &&
				(
					SharePriceHighest == input.SharePriceHighest ||
					SharePriceHighest != null &&
					SharePriceHighest.Equals(input.SharePriceHighest)
				) &&
				(
					ShareCount == input.ShareCount ||
					ShareCount != null &&
					ShareCount.Equals(input.ShareCount)
				) &&
				(
					ShareCountLowest == input.ShareCountLowest ||
					ShareCountLowest != null &&
					ShareCountLowest.Equals(input.ShareCountLowest)
				) &&
				(
					ShareCountHighest == input.ShareCountHighest ||
					ShareCountHighest != null &&
					ShareCountHighest.Equals(input.ShareCountHighest)
				) &&
				(
					AnnouncementUrl == input.AnnouncementUrl ||
					AnnouncementUrl != null &&
					AnnouncementUrl.Equals(input.AnnouncementUrl)
				) &&
				(
					SecReportUrl == input.SecReportUrl ||
					SecReportUrl != null &&
					SecReportUrl.Equals(input.SecReportUrl)
				) &&
				(
					OpenPrice == input.OpenPrice ||
					OpenPrice != null &&
					OpenPrice.Equals(input.OpenPrice)
				) &&
				(
					ClosePrice == input.ClosePrice ||
					ClosePrice != null &&
					ClosePrice.Equals(input.ClosePrice)
				) &&
				(
					Volume == input.Volume ||
					Volume != null &&
					Volume.Equals(input.Volume)
				) &&
				(
					DayChange == input.DayChange ||
					DayChange != null &&
					DayChange.Equals(input.DayChange)
				) &&
				(
					WeekChange == input.WeekChange ||
					WeekChange != null &&
					WeekChange.Equals(input.WeekChange)
				) &&
				(
					MonthChange == input.MonthChange ||
					MonthChange != null &&
					MonthChange.Equals(input.MonthChange)
				) &&
				(
					Company == input.Company ||
					Company != null &&
					Company.Equals(input.Company)
				) &&
				(
					Security == input.Security ||
					Security != null &&
					Security.Equals(input.Security)
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
			sb.Append("class CompanyInitialPublicOffering {\n");
			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  Ticker: ").Append(Ticker).Append("\n");
			sb.Append("  Date: ").Append(Date).Append("\n");
			sb.Append("  Status: ").Append(Status).Append("\n");
			sb.Append("  Exchange: ").Append(Exchange).Append("\n");
			sb.Append("  OfferAmount: ").Append(OfferAmount).Append("\n");
			sb.Append("  SharePrice: ").Append(SharePrice).Append("\n");
			sb.Append("  SharePriceLowest: ").Append(SharePriceLowest).Append("\n");
			sb.Append("  SharePriceHighest: ").Append(SharePriceHighest).Append("\n");
			sb.Append("  ShareCount: ").Append(ShareCount).Append("\n");
			sb.Append("  ShareCountLowest: ").Append(ShareCountLowest).Append("\n");
			sb.Append("  ShareCountHighest: ").Append(ShareCountHighest).Append("\n");
			sb.Append("  AnnouncementUrl: ").Append(AnnouncementUrl).Append("\n");
			sb.Append("  SecReportUrl: ").Append(SecReportUrl).Append("\n");
			sb.Append("  OpenPrice: ").Append(OpenPrice).Append("\n");
			sb.Append("  ClosePrice: ").Append(ClosePrice).Append("\n");
			sb.Append("  Volume: ").Append(Volume).Append("\n");
			sb.Append("  DayChange: ").Append(DayChange).Append("\n");
			sb.Append("  WeekChange: ").Append(WeekChange).Append("\n");
			sb.Append("  MonthChange: ").Append(MonthChange).Append("\n");
			sb.Append("  Company: ").Append(Company).Append("\n");
			sb.Append("  Security: ").Append(Security).Append("\n");
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
			return Equals(input as CompanyInitialPublicOffering);
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
				if (Date != null)
					hashCode = hashCode * 59 + Date.GetHashCode();
				if (Status != null)
					hashCode = hashCode * 59 + Status.GetHashCode();
				if (Exchange != null)
					hashCode = hashCode * 59 + Exchange.GetHashCode();
				if (OfferAmount != null)
					hashCode = hashCode * 59 + OfferAmount.GetHashCode();
				if (SharePrice != null)
					hashCode = hashCode * 59 + SharePrice.GetHashCode();
				if (SharePriceLowest != null)
					hashCode = hashCode * 59 + SharePriceLowest.GetHashCode();
				if (SharePriceHighest != null)
					hashCode = hashCode * 59 + SharePriceHighest.GetHashCode();
				if (ShareCount != null)
					hashCode = hashCode * 59 + ShareCount.GetHashCode();
				if (ShareCountLowest != null)
					hashCode = hashCode * 59 + ShareCountLowest.GetHashCode();
				if (ShareCountHighest != null)
					hashCode = hashCode * 59 + ShareCountHighest.GetHashCode();
				if (AnnouncementUrl != null)
					hashCode = hashCode * 59 + AnnouncementUrl.GetHashCode();
				if (SecReportUrl != null)
					hashCode = hashCode * 59 + SecReportUrl.GetHashCode();
				if (OpenPrice != null)
					hashCode = hashCode * 59 + OpenPrice.GetHashCode();
				if (ClosePrice != null)
					hashCode = hashCode * 59 + ClosePrice.GetHashCode();
				if (Volume != null)
					hashCode = hashCode * 59 + Volume.GetHashCode();
				if (DayChange != null)
					hashCode = hashCode * 59 + DayChange.GetHashCode();
				if (WeekChange != null)
					hashCode = hashCode * 59 + WeekChange.GetHashCode();
				if (MonthChange != null)
					hashCode = hashCode * 59 + MonthChange.GetHashCode();
				if (Company != null)
					hashCode = hashCode * 59 + Company.GetHashCode();
				if (Security != null)
					hashCode = hashCode * 59 + Security.GetHashCode();
				return hashCode;
			}
		}
	}
}