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
	///     Zacks target price consensus estimates from analysts for thousands of stocks. Zacks storied research team
	///     aggregates and validates the estimates.  Each Growth Rate includes metadata about the corresponding Company.
	/// </summary>
	[DataContract]
	public class ZacksTargetPriceConsensus : IEquatable<ZacksTargetPriceConsensus>, IValidatableObject
	{
		/// <summary>
		///     Initializes a new instance of the <see cref="ZacksTargetPriceConsensus" /> class.
		/// </summary>
		/// <param name="Ticker">The Zacks common exchange ticker.</param>
		/// <param name="CompanyName">The company name.</param>
		/// <param name="IndustryGroupNumber">The Zacks industry group number.</param>
		/// <param name="High">The high target price estimate.</param>
		/// <param name="Low">The low target price estimate.</param>
		/// <param name="Mean">The mean target price estimate.</param>
		/// <param name="StandardDeviation">The standard deviation of target price estimates.</param>
		/// <param name="Total">The number of target price estimates in consensus.</param>
		/// <param name="MostRecentDate">The date of most recent estimate.</param>
		/// <param name="Median">The median target price estimate.</param>
		/// <param name="Raised">The number of estimates raised.</param>
		/// <param name="Lowered">The number of estimates lowered.</param>
		/// <param name="Company">Company.</param>
		public ZacksTargetPriceConsensus(string Ticker = default, string CompanyName = default,
			string IndustryGroupNumber = default, decimal? High = default, decimal? Low = default,
			decimal? Mean = default, decimal? StandardDeviation = default, int? Total = default,
			DateTime? MostRecentDate = default, decimal? Median = default, int? Raised = default,
			int? Lowered = default, CompanySummary Company = default)
		{
			this.Ticker = Ticker;
			this.CompanyName = CompanyName;
			this.IndustryGroupNumber = IndustryGroupNumber;
			this.High = High;
			this.Low = Low;
			this.Mean = Mean;
			this.StandardDeviation = StandardDeviation;
			this.Total = Total;
			this.MostRecentDate = MostRecentDate;
			this.Median = Median;
			this.Raised = Raised;
			this.Lowered = Lowered;
			this.Company = Company;
		}

		/// <summary>
		///     The Zacks common exchange ticker
		/// </summary>
		/// <value>The Zacks common exchange ticker</value>
		[DataMember(Name = "ticker", EmitDefaultValue = false)]
		public string Ticker { get; set; }

		/// <summary>
		///     The company name
		/// </summary>
		/// <value>The company name</value>
		[DataMember(Name = "company_name", EmitDefaultValue = false)]
		public string CompanyName { get; set; }

		/// <summary>
		///     The Zacks industry group number
		/// </summary>
		/// <value>The Zacks industry group number</value>
		[DataMember(Name = "industry_group_number", EmitDefaultValue = false)]
		public string IndustryGroupNumber { get; set; }

		/// <summary>
		///     The high target price estimate
		/// </summary>
		/// <value>The high target price estimate</value>
		[DataMember(Name = "high", EmitDefaultValue = false)]
		public decimal? High { get; set; }

		/// <summary>
		///     The low target price estimate
		/// </summary>
		/// <value>The low target price estimate</value>
		[DataMember(Name = "low", EmitDefaultValue = false)]
		public decimal? Low { get; set; }

		/// <summary>
		///     The mean target price estimate
		/// </summary>
		/// <value>The mean target price estimate</value>
		[DataMember(Name = "mean", EmitDefaultValue = false)]
		public decimal? Mean { get; set; }

		/// <summary>
		///     The standard deviation of target price estimates
		/// </summary>
		/// <value>The standard deviation of target price estimates</value>
		[DataMember(Name = "standard_deviation", EmitDefaultValue = false)]
		public decimal? StandardDeviation { get; set; }

		/// <summary>
		///     The number of target price estimates in consensus
		/// </summary>
		/// <value>The number of target price estimates in consensus</value>
		[DataMember(Name = "total", EmitDefaultValue = false)]
		public int? Total { get; set; }

		/// <summary>
		///     The date of most recent estimate
		/// </summary>
		/// <value>The date of most recent estimate</value>
		[DataMember(Name = "most_recent_date", EmitDefaultValue = false)]
		
		public DateTime? MostRecentDate { get; set; }

		/// <summary>
		///     The median target price estimate
		/// </summary>
		/// <value>The median target price estimate</value>
		[DataMember(Name = "median", EmitDefaultValue = false)]
		public decimal? Median { get; set; }

		/// <summary>
		///     The number of estimates raised
		/// </summary>
		/// <value>The number of estimates raised</value>
		[DataMember(Name = "raised", EmitDefaultValue = false)]
		public int? Raised { get; set; }

		/// <summary>
		///     The number of estimates lowered
		/// </summary>
		/// <value>The number of estimates lowered</value>
		[DataMember(Name = "lowered", EmitDefaultValue = false)]
		public int? Lowered { get; set; }

		/// <summary>
		///     Gets or Sets Company
		/// </summary>
		[DataMember(Name = "company", EmitDefaultValue = false)]
		public CompanySummary Company { get; set; }

		/// <summary>
		///     Returns true if ZacksTargetPriceConsensus instances are equal
		/// </summary>
		/// <param name="input">Instance of ZacksTargetPriceConsensus to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(ZacksTargetPriceConsensus input)
		{
			if (input == null)
				return false;

			return
				(
					Ticker == input.Ticker ||
					Ticker != null &&
					Ticker.Equals(input.Ticker)
				) &&
				(
					CompanyName == input.CompanyName ||
					CompanyName != null &&
					CompanyName.Equals(input.CompanyName)
				) &&
				(
					IndustryGroupNumber == input.IndustryGroupNumber ||
					IndustryGroupNumber != null &&
					IndustryGroupNumber.Equals(input.IndustryGroupNumber)
				) &&
				(
					High == input.High ||
					High != null &&
					High.Equals(input.High)
				) &&
				(
					Low == input.Low ||
					Low != null &&
					Low.Equals(input.Low)
				) &&
				(
					Mean == input.Mean ||
					Mean != null &&
					Mean.Equals(input.Mean)
				) &&
				(
					StandardDeviation == input.StandardDeviation ||
					StandardDeviation != null &&
					StandardDeviation.Equals(input.StandardDeviation)
				) &&
				(
					Total == input.Total ||
					Total != null &&
					Total.Equals(input.Total)
				) &&
				(
					MostRecentDate == input.MostRecentDate ||
					MostRecentDate != null &&
					MostRecentDate.Equals(input.MostRecentDate)
				) &&
				(
					Median == input.Median ||
					Median != null &&
					Median.Equals(input.Median)
				) &&
				(
					Raised == input.Raised ||
					Raised != null &&
					Raised.Equals(input.Raised)
				) &&
				(
					Lowered == input.Lowered ||
					Lowered != null &&
					Lowered.Equals(input.Lowered)
				) &&
				(
					Company == input.Company ||
					Company != null &&
					Company.Equals(input.Company)
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
			sb.Append("class ZacksTargetPriceConsensus {\n");
			sb.Append("  Ticker: ").Append(Ticker).Append("\n");
			sb.Append("  CompanyName: ").Append(CompanyName).Append("\n");
			sb.Append("  IndustryGroupNumber: ").Append(IndustryGroupNumber).Append("\n");
			sb.Append("  High: ").Append(High).Append("\n");
			sb.Append("  Low: ").Append(Low).Append("\n");
			sb.Append("  Mean: ").Append(Mean).Append("\n");
			sb.Append("  StandardDeviation: ").Append(StandardDeviation).Append("\n");
			sb.Append("  Total: ").Append(Total).Append("\n");
			sb.Append("  MostRecentDate: ").Append(MostRecentDate).Append("\n");
			sb.Append("  Median: ").Append(Median).Append("\n");
			sb.Append("  Raised: ").Append(Raised).Append("\n");
			sb.Append("  Lowered: ").Append(Lowered).Append("\n");
			sb.Append("  Company: ").Append(Company).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}

		/// <summary>
		///     Returns the JSON string presentation of the object
		/// </summary>
		/// <returns>JSON string presentation of the object</returns>
		public string ToJson()
		{
			return JsonSerializer.Serialize(this);
		}

		/// <summary>
		///     Returns true if objects are equal
		/// </summary>
		/// <param name="input">Object to be compared</param>
		/// <returns>Boolean</returns>
		public override bool Equals(object input)
		{
			return Equals(input as ZacksTargetPriceConsensus);
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
				if (Ticker != null)
					hashCode = hashCode * 59 + Ticker.GetHashCode();
				if (CompanyName != null)
					hashCode = hashCode * 59 + CompanyName.GetHashCode();
				if (IndustryGroupNumber != null)
					hashCode = hashCode * 59 + IndustryGroupNumber.GetHashCode();
				if (High != null)
					hashCode = hashCode * 59 + High.GetHashCode();
				if (Low != null)
					hashCode = hashCode * 59 + Low.GetHashCode();
				if (Mean != null)
					hashCode = hashCode * 59 + Mean.GetHashCode();
				if (StandardDeviation != null)
					hashCode = hashCode * 59 + StandardDeviation.GetHashCode();
				if (Total != null)
					hashCode = hashCode * 59 + Total.GetHashCode();
				if (MostRecentDate != null)
					hashCode = hashCode * 59 + MostRecentDate.GetHashCode();
				if (Median != null)
					hashCode = hashCode * 59 + Median.GetHashCode();
				if (Raised != null)
					hashCode = hashCode * 59 + Raised.GetHashCode();
				if (Lowered != null)
					hashCode = hashCode * 59 + Lowered.GetHashCode();
				if (Company != null)
					hashCode = hashCode * 59 + Company.GetHashCode();
				return hashCode;
			}
		}
	}
}