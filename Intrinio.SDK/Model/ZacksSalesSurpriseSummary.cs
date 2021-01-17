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
	///     Zacks Sales Surprises are pre-earnings release consensus sales estimates from analysts for thousands of stocks.
	///     Zack’s storied research team aggregates and validates the estimates and compares these estimates to non-GAAP sales
	///     reported by the company, providing the amount and percent surprise on release.
	/// </summary>
	[DataContract]
	public class ZacksSalesSurpriseSummary : IEquatable<ZacksSalesSurpriseSummary>, IValidatableObject
	{
		/// <summary>
		///     Initializes a new instance of the <see cref="ZacksSalesSurpriseSummary" /> class.
		/// </summary>
		/// <param name="Id">The Intrinio ID for the record.</param>
		/// <param name="FiscalYear">The company’s fiscal year for the reported period.</param>
		/// <param name="FiscalQuarter">The company’s fiscal quarter for the reported period.</param>
		/// <param name="CalendarYear">The closest calendar year for the company’s fiscal year.</param>
		/// <param name="CalendarQuarter">The closest calendar quarter for the company’s fiscal year.</param>
		/// <param name="ActualReportedDate">The actual report date for the earnings release.</param>
		/// <param name="ActualReportedTime">The actual report time for the earnings release.</param>
		/// <param name="ActualReportedCode">
		///     The code cooresponding to the earnings release  BTO &#x3D; BEFORE THE OPEN | DTM
		///     &#x3D; DURING THE MARKET | AMC &#x3D; AFTER MARKET CLOSE.
		/// </param>
		/// <param name="ActualReportedDesc">The description for the type of earnings release.</param>
		/// <param name="LastRevDate">The last revision date for the analyst estimates.</param>
		/// <param name="SalesActual">The actual Non-GAAP sales figure released by the company, interpreted by Zacks..</param>
		/// <param name="SalesActualZacksAdj">The adjustments Zacks made to get to Non-GAAP sales to reconcile with GAAP sales..</param>
		/// <param name="SalesActualGaap">The actual GAAP sales figured released by the company.</param>
		/// <param name="SalesMeanEstimate">
		///     The pre-earnings release mean sales estimate for the company sales_count_estimate; the
		///     pre-earnings release number of estimates by analysts.
		/// </param>
		/// <param name="SalesAmountDiff">The sales surprise amount difference.</param>
		/// <param name="SalesPercentDiff">The sales surprise percent difference.</param>
		/// <param name="SalesStdDevEstimate">The pre-earnings release standard deviation of sales estimates.</param>
		/// <param name="Security">The Security of the Zacks Sales Surprise.</param>
		public ZacksSalesSurpriseSummary(string Id = default, decimal? FiscalYear = default,
			string FiscalQuarter = default, decimal? CalendarYear = default, string CalendarQuarter = default,
			DateTime? ActualReportedDate = default, string ActualReportedTime = default,
			string ActualReportedCode = default, string ActualReportedDesc = default, DateTime? LastRevDate = default,
			decimal? SalesActual = default, decimal? SalesActualZacksAdj = default, decimal? SalesActualGaap = default,
			decimal? SalesMeanEstimate = default, decimal? SalesAmountDiff = default,
			decimal? SalesPercentDiff = default, decimal? SalesStdDevEstimate = default,
			SecuritySummary Security = default)
		{
			this.Id = Id;
			this.FiscalYear = FiscalYear;
			this.FiscalQuarter = FiscalQuarter;
			this.CalendarYear = CalendarYear;
			this.CalendarQuarter = CalendarQuarter;
			this.ActualReportedDate = ActualReportedDate;
			this.ActualReportedTime = ActualReportedTime;
			this.ActualReportedCode = ActualReportedCode;
			this.ActualReportedDesc = ActualReportedDesc;
			this.LastRevDate = LastRevDate;
			this.SalesActual = SalesActual;
			this.SalesActualZacksAdj = SalesActualZacksAdj;
			this.SalesActualGaap = SalesActualGaap;
			this.SalesMeanEstimate = SalesMeanEstimate;
			this.SalesAmountDiff = SalesAmountDiff;
			this.SalesPercentDiff = SalesPercentDiff;
			this.SalesStdDevEstimate = SalesStdDevEstimate;
			this.Security = Security;
		}

		/// <summary>
		///     The Intrinio ID for the record
		/// </summary>
		/// <value>The Intrinio ID for the record</value>
		[DataMember(Name = "id", EmitDefaultValue = false)]
		public string Id { get; set; }

		/// <summary>
		///     The company’s fiscal year for the reported period
		/// </summary>
		/// <value>The company’s fiscal year for the reported period</value>
		[DataMember(Name = "fiscal_year", EmitDefaultValue = false)]
		public decimal? FiscalYear { get; set; }

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
		public decimal? CalendarYear { get; set; }

		/// <summary>
		///     The closest calendar quarter for the company’s fiscal year
		/// </summary>
		/// <value>The closest calendar quarter for the company’s fiscal year</value>
		[DataMember(Name = "calendar_quarter", EmitDefaultValue = false)]
		public string CalendarQuarter { get; set; }

		/// <summary>
		///     The actual report date for the earnings release
		/// </summary>
		/// <value>The actual report date for the earnings release</value>
		[DataMember(Name = "actual_reported_date", EmitDefaultValue = false)]
		
		public DateTime? ActualReportedDate { get; set; }

		/// <summary>
		///     The actual report time for the earnings release
		/// </summary>
		/// <value>The actual report time for the earnings release</value>
		[DataMember(Name = "actual_reported_time", EmitDefaultValue = false)]
		public string ActualReportedTime { get; set; }

		/// <summary>
		///     The code cooresponding to the earnings release  BTO &#x3D; BEFORE THE OPEN | DTM &#x3D; DURING THE MARKET | AMC
		///     &#x3D; AFTER MARKET CLOSE
		/// </summary>
		/// <value>
		///     The code cooresponding to the earnings release  BTO &#x3D; BEFORE THE OPEN | DTM &#x3D; DURING THE MARKET | AMC
		///     &#x3D; AFTER MARKET CLOSE
		/// </value>
		[DataMember(Name = "actual_reported_code", EmitDefaultValue = false)]
		public string ActualReportedCode { get; set; }

		/// <summary>
		///     The description for the type of earnings release
		/// </summary>
		/// <value>The description for the type of earnings release</value>
		[DataMember(Name = "actual_reported_desc", EmitDefaultValue = false)]
		public string ActualReportedDesc { get; set; }

		/// <summary>
		///     The last revision date for the analyst estimates
		/// </summary>
		/// <value>The last revision date for the analyst estimates</value>
		[DataMember(Name = "last_rev_date", EmitDefaultValue = false)]
		
		public DateTime? LastRevDate { get; set; }

		/// <summary>
		///     The actual Non-GAAP sales figure released by the company, interpreted by Zacks.
		/// </summary>
		/// <value>The actual Non-GAAP sales figure released by the company, interpreted by Zacks.</value>
		[DataMember(Name = "sales_actual", EmitDefaultValue = false)]
		public decimal? SalesActual { get; set; }

		/// <summary>
		///     The adjustments Zacks made to get to Non-GAAP sales to reconcile with GAAP sales.
		/// </summary>
		/// <value>The adjustments Zacks made to get to Non-GAAP sales to reconcile with GAAP sales.</value>
		[DataMember(Name = "sales_actual_zacks_adj", EmitDefaultValue = false)]
		public decimal? SalesActualZacksAdj { get; set; }

		/// <summary>
		///     The actual GAAP sales figured released by the company
		/// </summary>
		/// <value>The actual GAAP sales figured released by the company</value>
		[DataMember(Name = "sales_actual_gaap", EmitDefaultValue = false)]
		public decimal? SalesActualGaap { get; set; }

		/// <summary>
		///     The pre-earnings release mean sales estimate for the company sales_count_estimate; the pre-earnings release number
		///     of estimates by analysts
		/// </summary>
		/// <value>
		///     The pre-earnings release mean sales estimate for the company sales_count_estimate; the pre-earnings release
		///     number of estimates by analysts
		/// </value>
		[DataMember(Name = "sales_mean_estimate", EmitDefaultValue = false)]
		public decimal? SalesMeanEstimate { get; set; }

		/// <summary>
		///     The sales surprise amount difference
		/// </summary>
		/// <value>The sales surprise amount difference</value>
		[DataMember(Name = "sales_amount_diff", EmitDefaultValue = false)]
		public decimal? SalesAmountDiff { get; set; }

		/// <summary>
		///     The sales surprise percent difference
		/// </summary>
		/// <value>The sales surprise percent difference</value>
		[DataMember(Name = "sales_percent_diff", EmitDefaultValue = false)]
		public decimal? SalesPercentDiff { get; set; }

		/// <summary>
		///     The pre-earnings release standard deviation of sales estimates
		/// </summary>
		/// <value>The pre-earnings release standard deviation of sales estimates</value>
		[DataMember(Name = "sales_std_dev_estimate", EmitDefaultValue = false)]
		public decimal? SalesStdDevEstimate { get; set; }

		/// <summary>
		///     The Security of the Zacks Sales Surprise
		/// </summary>
		/// <value>The Security of the Zacks Sales Surprise</value>
		[DataMember(Name = "security", EmitDefaultValue = false)]
		public SecuritySummary Security { get; set; }

		/// <summary>
		///     Returns true if ZacksSalesSurpriseSummary instances are equal
		/// </summary>
		/// <param name="input">Instance of ZacksSalesSurpriseSummary to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(ZacksSalesSurpriseSummary input)
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
					ActualReportedDate == input.ActualReportedDate ||
					ActualReportedDate != null &&
					ActualReportedDate.Equals(input.ActualReportedDate)
				) &&
				(
					ActualReportedTime == input.ActualReportedTime ||
					ActualReportedTime != null &&
					ActualReportedTime.Equals(input.ActualReportedTime)
				) &&
				(
					ActualReportedCode == input.ActualReportedCode ||
					ActualReportedCode != null &&
					ActualReportedCode.Equals(input.ActualReportedCode)
				) &&
				(
					ActualReportedDesc == input.ActualReportedDesc ||
					ActualReportedDesc != null &&
					ActualReportedDesc.Equals(input.ActualReportedDesc)
				) &&
				(
					LastRevDate == input.LastRevDate ||
					LastRevDate != null &&
					LastRevDate.Equals(input.LastRevDate)
				) &&
				(
					SalesActual == input.SalesActual ||
					SalesActual != null &&
					SalesActual.Equals(input.SalesActual)
				) &&
				(
					SalesActualZacksAdj == input.SalesActualZacksAdj ||
					SalesActualZacksAdj != null &&
					SalesActualZacksAdj.Equals(input.SalesActualZacksAdj)
				) &&
				(
					SalesActualGaap == input.SalesActualGaap ||
					SalesActualGaap != null &&
					SalesActualGaap.Equals(input.SalesActualGaap)
				) &&
				(
					SalesMeanEstimate == input.SalesMeanEstimate ||
					SalesMeanEstimate != null &&
					SalesMeanEstimate.Equals(input.SalesMeanEstimate)
				) &&
				(
					SalesAmountDiff == input.SalesAmountDiff ||
					SalesAmountDiff != null &&
					SalesAmountDiff.Equals(input.SalesAmountDiff)
				) &&
				(
					SalesPercentDiff == input.SalesPercentDiff ||
					SalesPercentDiff != null &&
					SalesPercentDiff.Equals(input.SalesPercentDiff)
				) &&
				(
					SalesStdDevEstimate == input.SalesStdDevEstimate ||
					SalesStdDevEstimate != null &&
					SalesStdDevEstimate.Equals(input.SalesStdDevEstimate)
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
			sb.Append("class ZacksSalesSurpriseSummary {\n");
			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  FiscalYear: ").Append(FiscalYear).Append("\n");
			sb.Append("  FiscalQuarter: ").Append(FiscalQuarter).Append("\n");
			sb.Append("  CalendarYear: ").Append(CalendarYear).Append("\n");
			sb.Append("  CalendarQuarter: ").Append(CalendarQuarter).Append("\n");
			sb.Append("  ActualReportedDate: ").Append(ActualReportedDate).Append("\n");
			sb.Append("  ActualReportedTime: ").Append(ActualReportedTime).Append("\n");
			sb.Append("  ActualReportedCode: ").Append(ActualReportedCode).Append("\n");
			sb.Append("  ActualReportedDesc: ").Append(ActualReportedDesc).Append("\n");
			sb.Append("  LastRevDate: ").Append(LastRevDate).Append("\n");
			sb.Append("  SalesActual: ").Append(SalesActual).Append("\n");
			sb.Append("  SalesActualZacksAdj: ").Append(SalesActualZacksAdj).Append("\n");
			sb.Append("  SalesActualGaap: ").Append(SalesActualGaap).Append("\n");
			sb.Append("  SalesMeanEstimate: ").Append(SalesMeanEstimate).Append("\n");
			sb.Append("  SalesAmountDiff: ").Append(SalesAmountDiff).Append("\n");
			sb.Append("  SalesPercentDiff: ").Append(SalesPercentDiff).Append("\n");
			sb.Append("  SalesStdDevEstimate: ").Append(SalesStdDevEstimate).Append("\n");
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
			return Equals(input as ZacksSalesSurpriseSummary);
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
				if (FiscalYear != null)
					hashCode = hashCode * 59 + FiscalYear.GetHashCode();
				if (FiscalQuarter != null)
					hashCode = hashCode * 59 + FiscalQuarter.GetHashCode();
				if (CalendarYear != null)
					hashCode = hashCode * 59 + CalendarYear.GetHashCode();
				if (CalendarQuarter != null)
					hashCode = hashCode * 59 + CalendarQuarter.GetHashCode();
				if (ActualReportedDate != null)
					hashCode = hashCode * 59 + ActualReportedDate.GetHashCode();
				if (ActualReportedTime != null)
					hashCode = hashCode * 59 + ActualReportedTime.GetHashCode();
				if (ActualReportedCode != null)
					hashCode = hashCode * 59 + ActualReportedCode.GetHashCode();
				if (ActualReportedDesc != null)
					hashCode = hashCode * 59 + ActualReportedDesc.GetHashCode();
				if (LastRevDate != null)
					hashCode = hashCode * 59 + LastRevDate.GetHashCode();
				if (SalesActual != null)
					hashCode = hashCode * 59 + SalesActual.GetHashCode();
				if (SalesActualZacksAdj != null)
					hashCode = hashCode * 59 + SalesActualZacksAdj.GetHashCode();
				if (SalesActualGaap != null)
					hashCode = hashCode * 59 + SalesActualGaap.GetHashCode();
				if (SalesMeanEstimate != null)
					hashCode = hashCode * 59 + SalesMeanEstimate.GetHashCode();
				if (SalesAmountDiff != null)
					hashCode = hashCode * 59 + SalesAmountDiff.GetHashCode();
				if (SalesPercentDiff != null)
					hashCode = hashCode * 59 + SalesPercentDiff.GetHashCode();
				if (SalesStdDevEstimate != null)
					hashCode = hashCode * 59 + SalesStdDevEstimate.GetHashCode();
				if (Security != null)
					hashCode = hashCode * 59 + Security.GetHashCode();
				return hashCode;
			}
		}
	}
}