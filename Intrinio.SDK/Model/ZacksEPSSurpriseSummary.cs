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
	///     Zacks EPS Surprises are pre-earnings release consensus EPS estimates from analysts for thousands of stocks. Zack’s
	///     storied research team aggregates and validates the estimates and compares these estimates to non-GAAP EPS reported
	///     by the company, providing the amount and percent surprise on release.
	/// </summary>
	[DataContract]
	public class ZacksEPSSurpriseSummary : IEquatable<ZacksEPSSurpriseSummary>, IValidatableObject
	{
		/// <summary>
		///     Initializes a new instance of the <see cref="ZacksEPSSurpriseSummary" /> class.
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
		/// <param name="EpsActual">The actual Non-GAAP EPS figure released by the company, interpreted by Zacks..</param>
		/// <param name="EpsActualZacksAdj">The adjustments Zacks made to get to Non-GAAP EPS to reconcile with GAAP EPS..</param>
		/// <param name="EpsMeanEstimate">The pre-earnings release mean EPS estimate for the company.</param>
		/// <param name="EpsAmountDiff">The EPS surprise amount difference.</param>
		/// <param name="EpsPercentDiff">The EPS surprise percent difference.</param>
		/// <param name="EpsCountEstimate">The pre-earnings release number of estimates by analysts.</param>
		/// <param name="EpsStdDevEstimate">The pre-earnings release standard deviation of EPS estimates.</param>
		public ZacksEPSSurpriseSummary(string Id = default, decimal? FiscalYear = default,
			string FiscalQuarter = default, decimal? CalendarYear = default, string CalendarQuarter = default,
			DateTime? ActualReportedDate = default, string ActualReportedTime = default,
			string ActualReportedCode = default, string ActualReportedDesc = default, decimal? EpsActual = default,
			decimal? EpsActualZacksAdj = default, decimal? EpsMeanEstimate = default, decimal? EpsAmountDiff = default,
			decimal? EpsPercentDiff = default, decimal? EpsCountEstimate = default,
			decimal? EpsStdDevEstimate = default)
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
			this.EpsActual = EpsActual;
			this.EpsActualZacksAdj = EpsActualZacksAdj;
			this.EpsMeanEstimate = EpsMeanEstimate;
			this.EpsAmountDiff = EpsAmountDiff;
			this.EpsPercentDiff = EpsPercentDiff;
			this.EpsCountEstimate = EpsCountEstimate;
			this.EpsStdDevEstimate = EpsStdDevEstimate;
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
		///     The actual Non-GAAP EPS figure released by the company, interpreted by Zacks.
		/// </summary>
		/// <value>The actual Non-GAAP EPS figure released by the company, interpreted by Zacks.</value>
		[DataMember(Name = "eps_actual", EmitDefaultValue = false)]
		public decimal? EpsActual { get; set; }

		/// <summary>
		///     The adjustments Zacks made to get to Non-GAAP EPS to reconcile with GAAP EPS.
		/// </summary>
		/// <value>The adjustments Zacks made to get to Non-GAAP EPS to reconcile with GAAP EPS.</value>
		[DataMember(Name = "eps_actual_zacks_adj", EmitDefaultValue = false)]
		public decimal? EpsActualZacksAdj { get; set; }

		/// <summary>
		///     The pre-earnings release mean EPS estimate for the company
		/// </summary>
		/// <value>The pre-earnings release mean EPS estimate for the company</value>
		[DataMember(Name = "eps_mean_estimate", EmitDefaultValue = false)]
		public decimal? EpsMeanEstimate { get; set; }

		/// <summary>
		///     The EPS surprise amount difference
		/// </summary>
		/// <value>The EPS surprise amount difference</value>
		[DataMember(Name = "eps_amount_diff", EmitDefaultValue = false)]
		public decimal? EpsAmountDiff { get; set; }

		/// <summary>
		///     The EPS surprise percent difference
		/// </summary>
		/// <value>The EPS surprise percent difference</value>
		[DataMember(Name = "eps_percent_diff", EmitDefaultValue = false)]
		public decimal? EpsPercentDiff { get; set; }

		/// <summary>
		///     The pre-earnings release number of estimates by analysts
		/// </summary>
		/// <value>The pre-earnings release number of estimates by analysts</value>
		[DataMember(Name = "eps_count_estimate", EmitDefaultValue = false)]
		public decimal? EpsCountEstimate { get; set; }

		/// <summary>
		///     The pre-earnings release standard deviation of EPS estimates
		/// </summary>
		/// <value>The pre-earnings release standard deviation of EPS estimates</value>
		[DataMember(Name = "eps_std_dev_estimate", EmitDefaultValue = false)]
		public decimal? EpsStdDevEstimate { get; set; }

		/// <summary>
		///     Returns true if ZacksEPSSurpriseSummary instances are equal
		/// </summary>
		/// <param name="input">Instance of ZacksEPSSurpriseSummary to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(ZacksEPSSurpriseSummary input)
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
					EpsActual == input.EpsActual ||
					EpsActual != null &&
					EpsActual.Equals(input.EpsActual)
				) &&
				(
					EpsActualZacksAdj == input.EpsActualZacksAdj ||
					EpsActualZacksAdj != null &&
					EpsActualZacksAdj.Equals(input.EpsActualZacksAdj)
				) &&
				(
					EpsMeanEstimate == input.EpsMeanEstimate ||
					EpsMeanEstimate != null &&
					EpsMeanEstimate.Equals(input.EpsMeanEstimate)
				) &&
				(
					EpsAmountDiff == input.EpsAmountDiff ||
					EpsAmountDiff != null &&
					EpsAmountDiff.Equals(input.EpsAmountDiff)
				) &&
				(
					EpsPercentDiff == input.EpsPercentDiff ||
					EpsPercentDiff != null &&
					EpsPercentDiff.Equals(input.EpsPercentDiff)
				) &&
				(
					EpsCountEstimate == input.EpsCountEstimate ||
					EpsCountEstimate != null &&
					EpsCountEstimate.Equals(input.EpsCountEstimate)
				) &&
				(
					EpsStdDevEstimate == input.EpsStdDevEstimate ||
					EpsStdDevEstimate != null &&
					EpsStdDevEstimate.Equals(input.EpsStdDevEstimate)
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
			sb.Append("class ZacksEPSSurpriseSummary {\n");
			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  FiscalYear: ").Append(FiscalYear).Append("\n");
			sb.Append("  FiscalQuarter: ").Append(FiscalQuarter).Append("\n");
			sb.Append("  CalendarYear: ").Append(CalendarYear).Append("\n");
			sb.Append("  CalendarQuarter: ").Append(CalendarQuarter).Append("\n");
			sb.Append("  ActualReportedDate: ").Append(ActualReportedDate).Append("\n");
			sb.Append("  ActualReportedTime: ").Append(ActualReportedTime).Append("\n");
			sb.Append("  ActualReportedCode: ").Append(ActualReportedCode).Append("\n");
			sb.Append("  ActualReportedDesc: ").Append(ActualReportedDesc).Append("\n");
			sb.Append("  EpsActual: ").Append(EpsActual).Append("\n");
			sb.Append("  EpsActualZacksAdj: ").Append(EpsActualZacksAdj).Append("\n");
			sb.Append("  EpsMeanEstimate: ").Append(EpsMeanEstimate).Append("\n");
			sb.Append("  EpsAmountDiff: ").Append(EpsAmountDiff).Append("\n");
			sb.Append("  EpsPercentDiff: ").Append(EpsPercentDiff).Append("\n");
			sb.Append("  EpsCountEstimate: ").Append(EpsCountEstimate).Append("\n");
			sb.Append("  EpsStdDevEstimate: ").Append(EpsStdDevEstimate).Append("\n");
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
			return Equals(input as ZacksEPSSurpriseSummary);
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
				if (EpsActual != null)
					hashCode = hashCode * 59 + EpsActual.GetHashCode();
				if (EpsActualZacksAdj != null)
					hashCode = hashCode * 59 + EpsActualZacksAdj.GetHashCode();
				if (EpsMeanEstimate != null)
					hashCode = hashCode * 59 + EpsMeanEstimate.GetHashCode();
				if (EpsAmountDiff != null)
					hashCode = hashCode * 59 + EpsAmountDiff.GetHashCode();
				if (EpsPercentDiff != null)
					hashCode = hashCode * 59 + EpsPercentDiff.GetHashCode();
				if (EpsCountEstimate != null)
					hashCode = hashCode * 59 + EpsCountEstimate.GetHashCode();
				if (EpsStdDevEstimate != null)
					hashCode = hashCode * 59 + EpsStdDevEstimate.GetHashCode();
				return hashCode;
			}
		}
	}
}