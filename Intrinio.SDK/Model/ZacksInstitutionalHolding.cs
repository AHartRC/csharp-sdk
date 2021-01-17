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
	///     Returns a list of all ownership interests and the value of their interests sourced from Zacks.
	/// </summary>
	[DataContract]
	public class ZacksInstitutionalHolding : IEquatable<ZacksInstitutionalHolding>, IValidatableObject
	{
		/// <summary>
		///     Initializes a new instance of the <see cref="ZacksInstitutionalHolding" /> class.
		/// </summary>
		/// <param name="Company">Company.</param>
		/// <param name="Owner">Owner.</param>
		/// <param name="AsOfDate">Quarter end date listed in the most recent 13F report filed by the institution.</param>
		/// <param name="SharesHeld">Number of shares of the stock listed.</param>
		/// <param name="SharedHeldPercent">Percent of shares outstanding held of the stock by the institution listed.</param>
		/// <param name="SharesChange">Change in shares of the stock held by the institution listed.</param>
		/// <param name="SharesChangePercent">Percentage change in shares of the stock held by the institution listed.</param>
		/// <param name="MarketValue">Market value of shares outstanding held of the stock listed.</param>
		/// <param name="MarketValueChange">Change in market value shares of the stock listed.</param>
		/// <param name="LastSecFilingType">The report type of the latest SEC filing.</param>
		/// <param name="LastSecFilingDate">The date of the latest SEC filing.</param>
		/// <param name="LastSecFilingShares">The.</param>
		/// <param name="HistoricalHoldings">HistoricalHoldings.</param>
		public ZacksInstitutionalHolding(ZacksInstitutionalHoldingCompanySummary Company = default,
			ZacksInstitutionalHoldingOwnerSummary Owner = default, DateTime? AsOfDate = default,
			decimal? SharesHeld = default, decimal? SharedHeldPercent = default, decimal? SharesChange = default,
			decimal? SharesChangePercent = default, decimal? MarketValue = default,
			decimal? MarketValueChange = default, string LastSecFilingType = default,
			DateTime? LastSecFilingDate = default, decimal? LastSecFilingShares = default,
			List<ZacksInstitutionalHoldingHistoricalSummary> HistoricalHoldings = default)
		{
			this.Company = Company;
			this.Owner = Owner;
			this.AsOfDate = AsOfDate;
			this.SharesHeld = SharesHeld;
			this.SharedHeldPercent = SharedHeldPercent;
			this.SharesChange = SharesChange;
			this.SharesChangePercent = SharesChangePercent;
			this.MarketValue = MarketValue;
			this.MarketValueChange = MarketValueChange;
			this.LastSecFilingType = LastSecFilingType;
			this.LastSecFilingDate = LastSecFilingDate;
			this.LastSecFilingShares = LastSecFilingShares;
			this.HistoricalHoldings = HistoricalHoldings;
		}

		/// <summary>
		///     Gets or Sets Company
		/// </summary>
		[DataMember(Name = "company", EmitDefaultValue = false)]
		public ZacksInstitutionalHoldingCompanySummary Company { get; set; }

		/// <summary>
		///     Gets or Sets Owner
		/// </summary>
		[DataMember(Name = "owner", EmitDefaultValue = false)]
		public ZacksInstitutionalHoldingOwnerSummary Owner { get; set; }

		/// <summary>
		///     Quarter end date listed in the most recent 13F report filed by the institution
		/// </summary>
		/// <value>Quarter end date listed in the most recent 13F report filed by the institution</value>
		[DataMember(Name = "as_of_date", EmitDefaultValue = false)]
		
		public DateTime? AsOfDate { get; set; }

		/// <summary>
		///     Number of shares of the stock listed
		/// </summary>
		/// <value>Number of shares of the stock listed</value>
		[DataMember(Name = "shares_held", EmitDefaultValue = false)]
		public decimal? SharesHeld { get; set; }

		/// <summary>
		///     Percent of shares outstanding held of the stock by the institution listed
		/// </summary>
		/// <value>Percent of shares outstanding held of the stock by the institution listed</value>
		[DataMember(Name = "shared_held_percent", EmitDefaultValue = false)]
		public decimal? SharedHeldPercent { get; set; }

		/// <summary>
		///     Change in shares of the stock held by the institution listed
		/// </summary>
		/// <value>Change in shares of the stock held by the institution listed</value>
		[DataMember(Name = "shares_change", EmitDefaultValue = false)]
		public decimal? SharesChange { get; set; }

		/// <summary>
		///     Percentage change in shares of the stock held by the institution listed
		/// </summary>
		/// <value>Percentage change in shares of the stock held by the institution listed</value>
		[DataMember(Name = "shares_change_percent", EmitDefaultValue = false)]
		public decimal? SharesChangePercent { get; set; }

		/// <summary>
		///     Market value of shares outstanding held of the stock listed
		/// </summary>
		/// <value>Market value of shares outstanding held of the stock listed</value>
		[DataMember(Name = "market_value", EmitDefaultValue = false)]
		public decimal? MarketValue { get; set; }

		/// <summary>
		///     Change in market value shares of the stock listed
		/// </summary>
		/// <value>Change in market value shares of the stock listed</value>
		[DataMember(Name = "market_value_change", EmitDefaultValue = false)]
		public decimal? MarketValueChange { get; set; }

		/// <summary>
		///     The report type of the latest SEC filing
		/// </summary>
		/// <value>The report type of the latest SEC filing</value>
		[DataMember(Name = "last_sec_filing_type", EmitDefaultValue = false)]
		public string LastSecFilingType { get; set; }

		/// <summary>
		///     The date of the latest SEC filing
		/// </summary>
		/// <value>The date of the latest SEC filing</value>
		[DataMember(Name = "last_sec_filing_date", EmitDefaultValue = false)]
		
		public DateTime? LastSecFilingDate { get; set; }

		/// <summary>
		///     The
		/// </summary>
		/// <value>The</value>
		[DataMember(Name = "last_sec_filing_shares", EmitDefaultValue = false)]
		public decimal? LastSecFilingShares { get; set; }

		/// <summary>
		///     Gets or Sets HistoricalHoldings
		/// </summary>
		[DataMember(Name = "historical_holdings", EmitDefaultValue = false)]
		public List<ZacksInstitutionalHoldingHistoricalSummary> HistoricalHoldings { get; set; }

		/// <summary>
		///     Returns true if ZacksInstitutionalHolding instances are equal
		/// </summary>
		/// <param name="input">Instance of ZacksInstitutionalHolding to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(ZacksInstitutionalHolding input)
		{
			if (input == null)
				return false;

			return
				(
					Company == input.Company ||
					Company != null &&
					Company.Equals(input.Company)
				) &&
				(
					Owner == input.Owner ||
					Owner != null &&
					Owner.Equals(input.Owner)
				) &&
				(
					AsOfDate == input.AsOfDate ||
					AsOfDate != null &&
					AsOfDate.Equals(input.AsOfDate)
				) &&
				(
					SharesHeld == input.SharesHeld ||
					SharesHeld != null &&
					SharesHeld.Equals(input.SharesHeld)
				) &&
				(
					SharedHeldPercent == input.SharedHeldPercent ||
					SharedHeldPercent != null &&
					SharedHeldPercent.Equals(input.SharedHeldPercent)
				) &&
				(
					SharesChange == input.SharesChange ||
					SharesChange != null &&
					SharesChange.Equals(input.SharesChange)
				) &&
				(
					SharesChangePercent == input.SharesChangePercent ||
					SharesChangePercent != null &&
					SharesChangePercent.Equals(input.SharesChangePercent)
				) &&
				(
					MarketValue == input.MarketValue ||
					MarketValue != null &&
					MarketValue.Equals(input.MarketValue)
				) &&
				(
					MarketValueChange == input.MarketValueChange ||
					MarketValueChange != null &&
					MarketValueChange.Equals(input.MarketValueChange)
				) &&
				(
					LastSecFilingType == input.LastSecFilingType ||
					LastSecFilingType != null &&
					LastSecFilingType.Equals(input.LastSecFilingType)
				) &&
				(
					LastSecFilingDate == input.LastSecFilingDate ||
					LastSecFilingDate != null &&
					LastSecFilingDate.Equals(input.LastSecFilingDate)
				) &&
				(
					LastSecFilingShares == input.LastSecFilingShares ||
					LastSecFilingShares != null &&
					LastSecFilingShares.Equals(input.LastSecFilingShares)
				) &&
				(
					HistoricalHoldings == input.HistoricalHoldings ||
					HistoricalHoldings != null &&
					HistoricalHoldings.SequenceEqual(input.HistoricalHoldings)
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
			sb.Append("class ZacksInstitutionalHolding {\n");
			sb.Append("  Company: ").Append(Company).Append("\n");
			sb.Append("  Owner: ").Append(Owner).Append("\n");
			sb.Append("  AsOfDate: ").Append(AsOfDate).Append("\n");
			sb.Append("  SharesHeld: ").Append(SharesHeld).Append("\n");
			sb.Append("  SharedHeldPercent: ").Append(SharedHeldPercent).Append("\n");
			sb.Append("  SharesChange: ").Append(SharesChange).Append("\n");
			sb.Append("  SharesChangePercent: ").Append(SharesChangePercent).Append("\n");
			sb.Append("  MarketValue: ").Append(MarketValue).Append("\n");
			sb.Append("  MarketValueChange: ").Append(MarketValueChange).Append("\n");
			sb.Append("  LastSecFilingType: ").Append(LastSecFilingType).Append("\n");
			sb.Append("  LastSecFilingDate: ").Append(LastSecFilingDate).Append("\n");
			sb.Append("  LastSecFilingShares: ").Append(LastSecFilingShares).Append("\n");
			sb.Append("  HistoricalHoldings: ").Append(HistoricalHoldings).Append("\n");
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
			return Equals(input as ZacksInstitutionalHolding);
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
				if (Company != null)
					hashCode = hashCode * 59 + Company.GetHashCode();
				if (Owner != null)
					hashCode = hashCode * 59 + Owner.GetHashCode();
				if (AsOfDate != null)
					hashCode = hashCode * 59 + AsOfDate.GetHashCode();
				if (SharesHeld != null)
					hashCode = hashCode * 59 + SharesHeld.GetHashCode();
				if (SharedHeldPercent != null)
					hashCode = hashCode * 59 + SharedHeldPercent.GetHashCode();
				if (SharesChange != null)
					hashCode = hashCode * 59 + SharesChange.GetHashCode();
				if (SharesChangePercent != null)
					hashCode = hashCode * 59 + SharesChangePercent.GetHashCode();
				if (MarketValue != null)
					hashCode = hashCode * 59 + MarketValue.GetHashCode();
				if (MarketValueChange != null)
					hashCode = hashCode * 59 + MarketValueChange.GetHashCode();
				if (LastSecFilingType != null)
					hashCode = hashCode * 59 + LastSecFilingType.GetHashCode();
				if (LastSecFilingDate != null)
					hashCode = hashCode * 59 + LastSecFilingDate.GetHashCode();
				if (LastSecFilingShares != null)
					hashCode = hashCode * 59 + LastSecFilingShares.GetHashCode();
				if (HistoricalHoldings != null)
					hashCode = hashCode * 59 + HistoricalHoldings.GetHashCode();
				return hashCode;
			}
		}
	}
}