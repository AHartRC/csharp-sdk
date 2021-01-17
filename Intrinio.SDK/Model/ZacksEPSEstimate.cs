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
	///     Zacks consensus earnings-per-share (EPS) estimates from analysts for thousands of stocks.  Zacks storied research
	///     team aggregates and validates the estimates.  Each EPS Estimate includes metadata about the corresponding Company.
	/// </summary>
	[DataContract]
	public class ZacksEPSEstimate : IEquatable<ZacksEPSEstimate>, IValidatableObject
	{
		/// <summary>
		///     Initializes a new instance of the <see cref="ZacksEPSEstimate" /> class.
		/// </summary>
		/// <param name="Company">Company.</param>
		/// <param name="Date">The period end date.</param>
		/// <param name="FiscalYear">The company’s fiscal year for the reported period.</param>
		/// <param name="FiscalQuarter">The company’s fiscal quarter for the reported period.</param>
		/// <param name="CalendarYear">The closest calendar year for the company’s fiscal year.</param>
		/// <param name="CalendarQuarter">The closest calendar quarter for the company’s fiscal year.</param>
		/// <param name="Count">The number of estimates for the period.</param>
		/// <param name="Mean">The earnings per share (EPS) mean estimate for the period.</param>
		/// <param name="Median">The earnings per share (EPS) median estimate for the period.</param>
		/// <param name="High">The earnings per share (EPS) high estimate for the period.</param>
		/// <param name="Low">The earnings per share (EPS) low estimate for the period.</param>
		/// <param name="StandardDeviation">The earnings per share (EPS) standard deviation estimate for the period.</param>
		/// <param name="PercentChange">The earnings per share (EPS) percent change in estimate for the period.</param>
		/// <param name="Mean7DaysAgo">The long term growth mean estimate - 7 Days Ago.</param>
		/// <param name="Mean30DaysAgo">The long term growth mean estimate - 30 Days Ago.</param>
		/// <param name="Mean60DaysAgo">The long term growth mean estimate - 60 Days Ago.</param>
		/// <param name="Mean90DaysAgo">The long term growth mean estimate - 90 Days Ago.</param>
		public ZacksEPSEstimate(CompanySummary Company = default, DateTime? Date = default, int? FiscalYear = default,
			string FiscalQuarter = default, int? CalendarYear = default, string CalendarQuarter = default,
			int? Count = default, decimal? Mean = default, decimal? Median = default, decimal? High = default,
			decimal? Low = default, decimal? StandardDeviation = default, decimal? PercentChange = default,
			decimal? Mean7DaysAgo = default, decimal? Mean30DaysAgo = default, decimal? Mean60DaysAgo = default,
			decimal? Mean90DaysAgo = default)
		{
			this.Company = Company;
			this.Date = Date;
			this.FiscalYear = FiscalYear;
			this.FiscalQuarter = FiscalQuarter;
			this.CalendarYear = CalendarYear;
			this.CalendarQuarter = CalendarQuarter;
			this.Count = Count;
			this.Mean = Mean;
			this.Median = Median;
			this.High = High;
			this.Low = Low;
			this.StandardDeviation = StandardDeviation;
			this.PercentChange = PercentChange;
			this.Mean7DaysAgo = Mean7DaysAgo;
			this.Mean30DaysAgo = Mean30DaysAgo;
			this.Mean60DaysAgo = Mean60DaysAgo;
			this.Mean90DaysAgo = Mean90DaysAgo;
		}

		/// <summary>
		///     Gets or Sets Company
		/// </summary>
		[DataMember(Name = "company", EmitDefaultValue = false)]
		public CompanySummary Company { get; set; }

		/// <summary>
		///     The period end date
		/// </summary>
		/// <value>The period end date</value>
		[DataMember(Name = "date", EmitDefaultValue = false)]
		
		public DateTime? Date { get; set; }

		/// <summary>
		///     The company’s fiscal year for the reported period
		/// </summary>
		/// <value>The company’s fiscal year for the reported period</value>
		[DataMember(Name = "fiscal_year", EmitDefaultValue = false)]
		public int? FiscalYear { get; set; }

		/// <summary>
		///     The company’s fiscal quarter for the reported period
		/// </summary>
		/// <value>The company’s fiscal quarter for the reported period</value>
		[DataMember(Name = "fiscal_quarter", EmitDefaultValue = false)]
		public string FiscalQuarter { get; set; }

		/// <summary>
		///     The closest calendar year for the company’s fiscal year
		/// </summary>
		/// <value>The closest calendar year for the company’s fiscal year</value>
		[DataMember(Name = "calendar_year", EmitDefaultValue = false)]
		public int? CalendarYear { get; set; }

		/// <summary>
		///     The closest calendar quarter for the company’s fiscal year
		/// </summary>
		/// <value>The closest calendar quarter for the company’s fiscal year</value>
		[DataMember(Name = "calendar_quarter", EmitDefaultValue = false)]
		public string CalendarQuarter { get; set; }

		/// <summary>
		///     The number of estimates for the period
		/// </summary>
		/// <value>The number of estimates for the period</value>
		[DataMember(Name = "count", EmitDefaultValue = false)]
		public int? Count { get; set; }

		/// <summary>
		///     The earnings per share (EPS) mean estimate for the period
		/// </summary>
		/// <value>The earnings per share (EPS) mean estimate for the period</value>
		[DataMember(Name = "mean", EmitDefaultValue = false)]
		public decimal? Mean { get; set; }

		/// <summary>
		///     The earnings per share (EPS) median estimate for the period
		/// </summary>
		/// <value>The earnings per share (EPS) median estimate for the period</value>
		[DataMember(Name = "median", EmitDefaultValue = false)]
		public decimal? Median { get; set; }

		/// <summary>
		///     The earnings per share (EPS) high estimate for the period
		/// </summary>
		/// <value>The earnings per share (EPS) high estimate for the period</value>
		[DataMember(Name = "high", EmitDefaultValue = false)]
		public decimal? High { get; set; }

		/// <summary>
		///     The earnings per share (EPS) low estimate for the period
		/// </summary>
		/// <value>The earnings per share (EPS) low estimate for the period</value>
		[DataMember(Name = "low", EmitDefaultValue = false)]
		public decimal? Low { get; set; }

		/// <summary>
		///     The earnings per share (EPS) standard deviation estimate for the period
		/// </summary>
		/// <value>The earnings per share (EPS) standard deviation estimate for the period</value>
		[DataMember(Name = "standard_deviation", EmitDefaultValue = false)]
		public decimal? StandardDeviation { get; set; }

		/// <summary>
		///     The earnings per share (EPS) percent change in estimate for the period
		/// </summary>
		/// <value>The earnings per share (EPS) percent change in estimate for the period</value>
		[DataMember(Name = "percent_change", EmitDefaultValue = false)]
		public decimal? PercentChange { get; set; }

		/// <summary>
		///     The long term growth mean estimate - 7 Days Ago
		/// </summary>
		/// <value>The long term growth mean estimate - 7 Days Ago</value>
		[DataMember(Name = "mean_7_days_ago", EmitDefaultValue = false)]
		public decimal? Mean7DaysAgo { get; set; }

		/// <summary>
		///     The long term growth mean estimate - 30 Days Ago
		/// </summary>
		/// <value>The long term growth mean estimate - 30 Days Ago</value>
		[DataMember(Name = "mean_30_days_ago", EmitDefaultValue = false)]
		public decimal? Mean30DaysAgo { get; set; }

		/// <summary>
		///     The long term growth mean estimate - 60 Days Ago
		/// </summary>
		/// <value>The long term growth mean estimate - 60 Days Ago</value>
		[DataMember(Name = "mean_60_days_ago", EmitDefaultValue = false)]
		public decimal? Mean60DaysAgo { get; set; }

		/// <summary>
		///     The long term growth mean estimate - 90 Days Ago
		/// </summary>
		/// <value>The long term growth mean estimate - 90 Days Ago</value>
		[DataMember(Name = "mean_90_days_ago", EmitDefaultValue = false)]
		public decimal? Mean90DaysAgo { get; set; }

		/// <summary>
		///     Returns true if ZacksEPSEstimate instances are equal
		/// </summary>
		/// <param name="input">Instance of ZacksEPSEstimate to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(ZacksEPSEstimate input)
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
					Date == input.Date ||
					Date != null &&
					Date.Equals(input.Date)
				) &&
				(
					FiscalYear == input.FiscalYear ||
					FiscalYear != null &&
					FiscalYear.Equals(input.FiscalYear)
				) &&
				(
					FiscalQuarter == input.FiscalQuarter ||
					FiscalQuarter != null &&
					FiscalQuarter.Equals(input.FiscalQuarter)
				) &&
				(
					CalendarYear == input.CalendarYear ||
					CalendarYear != null &&
					CalendarYear.Equals(input.CalendarYear)
				) &&
				(
					CalendarQuarter == input.CalendarQuarter ||
					CalendarQuarter != null &&
					CalendarQuarter.Equals(input.CalendarQuarter)
				) &&
				(
					Count == input.Count ||
					Count != null &&
					Count.Equals(input.Count)
				) &&
				(
					Mean == input.Mean ||
					Mean != null &&
					Mean.Equals(input.Mean)
				) &&
				(
					Median == input.Median ||
					Median != null &&
					Median.Equals(input.Median)
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
					StandardDeviation == input.StandardDeviation ||
					StandardDeviation != null &&
					StandardDeviation.Equals(input.StandardDeviation)
				) &&
				(
					PercentChange == input.PercentChange ||
					PercentChange != null &&
					PercentChange.Equals(input.PercentChange)
				) &&
				(
					Mean7DaysAgo == input.Mean7DaysAgo ||
					Mean7DaysAgo != null &&
					Mean7DaysAgo.Equals(input.Mean7DaysAgo)
				) &&
				(
					Mean30DaysAgo == input.Mean30DaysAgo ||
					Mean30DaysAgo != null &&
					Mean30DaysAgo.Equals(input.Mean30DaysAgo)
				) &&
				(
					Mean60DaysAgo == input.Mean60DaysAgo ||
					Mean60DaysAgo != null &&
					Mean60DaysAgo.Equals(input.Mean60DaysAgo)
				) &&
				(
					Mean90DaysAgo == input.Mean90DaysAgo ||
					Mean90DaysAgo != null &&
					Mean90DaysAgo.Equals(input.Mean90DaysAgo)
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
			sb.Append("class ZacksEPSEstimate {\n");
			sb.Append("  Company: ").Append(Company).Append("\n");
			sb.Append("  Date: ").Append(Date).Append("\n");
			sb.Append("  FiscalYear: ").Append(FiscalYear).Append("\n");
			sb.Append("  FiscalQuarter: ").Append(FiscalQuarter).Append("\n");
			sb.Append("  CalendarYear: ").Append(CalendarYear).Append("\n");
			sb.Append("  CalendarQuarter: ").Append(CalendarQuarter).Append("\n");
			sb.Append("  Count: ").Append(Count).Append("\n");
			sb.Append("  Mean: ").Append(Mean).Append("\n");
			sb.Append("  Median: ").Append(Median).Append("\n");
			sb.Append("  High: ").Append(High).Append("\n");
			sb.Append("  Low: ").Append(Low).Append("\n");
			sb.Append("  StandardDeviation: ").Append(StandardDeviation).Append("\n");
			sb.Append("  PercentChange: ").Append(PercentChange).Append("\n");
			sb.Append("  Mean7DaysAgo: ").Append(Mean7DaysAgo).Append("\n");
			sb.Append("  Mean30DaysAgo: ").Append(Mean30DaysAgo).Append("\n");
			sb.Append("  Mean60DaysAgo: ").Append(Mean60DaysAgo).Append("\n");
			sb.Append("  Mean90DaysAgo: ").Append(Mean90DaysAgo).Append("\n");
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
			return Equals(input as ZacksEPSEstimate);
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
				if (Date != null)
					hashCode = hashCode * 59 + Date.GetHashCode();
				if (FiscalYear != null)
					hashCode = hashCode * 59 + FiscalYear.GetHashCode();
				if (FiscalQuarter != null)
					hashCode = hashCode * 59 + FiscalQuarter.GetHashCode();
				if (CalendarYear != null)
					hashCode = hashCode * 59 + CalendarYear.GetHashCode();
				if (CalendarQuarter != null)
					hashCode = hashCode * 59 + CalendarQuarter.GetHashCode();
				if (Count != null)
					hashCode = hashCode * 59 + Count.GetHashCode();
				if (Mean != null)
					hashCode = hashCode * 59 + Mean.GetHashCode();
				if (Median != null)
					hashCode = hashCode * 59 + Median.GetHashCode();
				if (High != null)
					hashCode = hashCode * 59 + High.GetHashCode();
				if (Low != null)
					hashCode = hashCode * 59 + Low.GetHashCode();
				if (StandardDeviation != null)
					hashCode = hashCode * 59 + StandardDeviation.GetHashCode();
				if (PercentChange != null)
					hashCode = hashCode * 59 + PercentChange.GetHashCode();
				if (Mean7DaysAgo != null)
					hashCode = hashCode * 59 + Mean7DaysAgo.GetHashCode();
				if (Mean30DaysAgo != null)
					hashCode = hashCode * 59 + Mean30DaysAgo.GetHashCode();
				if (Mean60DaysAgo != null)
					hashCode = hashCode * 59 + Mean60DaysAgo.GetHashCode();
				if (Mean90DaysAgo != null)
					hashCode = hashCode * 59 + Mean90DaysAgo.GetHashCode();
				return hashCode;
			}
		}
	}
}