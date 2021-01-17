using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using Intrinio.SDK.Client;
using Intrinio.SDK.Enumerator;

namespace Intrinio.SDK.Model
{
	/// <summary>
	///     FundamentalSummary
	/// </summary>
	[DataContract]
	public class FundamentalSummary : IEquatable<FundamentalSummary>, IValidatableObject
	{
		/// <summary>
		///     Initializes a new instance of the <see cref="FundamentalSummary" /> class.
		/// </summary>
		/// <param name="Id">The Intrinio ID of the Fundamental.</param>
		/// <param name="StatementCode">The code of the financial statement that the Fundamental represents.</param>
		/// <param name="FiscalYear">The fiscal year.</param>
		/// <param name="FiscalPeriod">The fiscal period.</param>
		/// <param name="Type">The type of Fundamental.</param>
		/// <param name="StartDate">The period start date.</param>
		/// <param name="EndDate">The period start date.</param>
		/// <param name="FilingDate">The date and time when the Fundamental was filed with the SEC.</param>
		public FundamentalSummary(string Id = default, string StatementCode = default, decimal? FiscalYear = default,
			string FiscalPeriod = default, FundamentalSummaryTypeEnum? Type = default, DateTime? StartDate = default,
			DateTime? EndDate = default, DateTime? FilingDate = default)
		{
			this.Id = Id;
			this.StatementCode = StatementCode;
			this.FiscalYear = FiscalYear;
			this.FiscalPeriod = FiscalPeriod;
			this.Type = Type;
			this.StartDate = StartDate;
			this.EndDate = EndDate;
			this.FilingDate = FilingDate;
		}

		/// <summary>
		///     The type of Fundamental
		/// </summary>
		/// <value>The type of Fundamental</value>
		[DataMember(Name = "type", EmitDefaultValue = false)]
		public FundamentalSummaryTypeEnum? Type { get; set; }

		/// <summary>
		///     The Intrinio ID of the Fundamental
		/// </summary>
		/// <value>The Intrinio ID of the Fundamental</value>
		[DataMember(Name = "id", EmitDefaultValue = false)]
		public string Id { get; set; }

		/// <summary>
		///     The code of the financial statement that the Fundamental represents
		/// </summary>
		/// <value>The code of the financial statement that the Fundamental represents</value>
		[DataMember(Name = "statement_code", EmitDefaultValue = false)]
		public string StatementCode { get; set; }

		/// <summary>
		///     The fiscal year
		/// </summary>
		/// <value>The fiscal year</value>
		[DataMember(Name = "fiscal_year", EmitDefaultValue = false)]
		public decimal? FiscalYear { get; set; }

		/// <summary>
		///     The fiscal period
		/// </summary>
		/// <value>The fiscal period</value>
		[DataMember(Name = "fiscal_period", EmitDefaultValue = false)]
		public string FiscalPeriod { get; set; }


		/// <summary>
		///     The period start date
		/// </summary>
		/// <value>The period start date</value>
		[DataMember(Name = "start_date", EmitDefaultValue = false)]
		
		public DateTime? StartDate { get; set; }

		/// <summary>
		///     The period start date
		/// </summary>
		/// <value>The period start date</value>
		[DataMember(Name = "end_date", EmitDefaultValue = false)]
		
		public DateTime? EndDate { get; set; }

		/// <summary>
		///     The date and time when the Fundamental was filed with the SEC
		/// </summary>
		/// <value>The date and time when the Fundamental was filed with the SEC</value>
		[DataMember(Name = "filing_date", EmitDefaultValue = false)]
		public DateTime? FilingDate { get; set; }

		/// <summary>
		///     Returns true if FundamentalSummary instances are equal
		/// </summary>
		/// <param name="input">Instance of FundamentalSummary to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(FundamentalSummary input)
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
					StatementCode == input.StatementCode ||
					StatementCode != null &&
					StatementCode.Equals(input.StatementCode)
				) &&
				(
					FiscalYear == input.FiscalYear ||
					FiscalYear != null &&
					FiscalYear.Equals(input.FiscalYear)
				) &&
				(
					FiscalPeriod == input.FiscalPeriod ||
					FiscalPeriod != null &&
					FiscalPeriod.Equals(input.FiscalPeriod)
				) &&
				(
					Type == input.Type ||
					Type != null &&
					Type.Equals(input.Type)
				) &&
				(
					StartDate == input.StartDate ||
					StartDate != null &&
					StartDate.Equals(input.StartDate)
				) &&
				(
					EndDate == input.EndDate ||
					EndDate != null &&
					EndDate.Equals(input.EndDate)
				) &&
				(
					FilingDate == input.FilingDate ||
					FilingDate != null &&
					FilingDate.Equals(input.FilingDate)
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
			sb.Append("class FundamentalSummary {\n");
			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  StatementCode: ").Append(StatementCode).Append("\n");
			sb.Append("  FiscalYear: ").Append(FiscalYear).Append("\n");
			sb.Append("  FiscalPeriod: ").Append(FiscalPeriod).Append("\n");
			sb.Append("  Type: ").Append(Type).Append("\n");
			sb.Append("  StartDate: ").Append(StartDate).Append("\n");
			sb.Append("  EndDate: ").Append(EndDate).Append("\n");
			sb.Append("  FilingDate: ").Append(FilingDate).Append("\n");
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
			return Equals(input as FundamentalSummary);
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
				if (StatementCode != null)
					hashCode = hashCode * 59 + StatementCode.GetHashCode();
				if (FiscalYear != null)
					hashCode = hashCode * 59 + FiscalYear.GetHashCode();
				if (FiscalPeriod != null)
					hashCode = hashCode * 59 + FiscalPeriod.GetHashCode();
				if (Type != null)
					hashCode = hashCode * 59 + Type.GetHashCode();
				if (StartDate != null)
					hashCode = hashCode * 59 + StartDate.GetHashCode();
				if (EndDate != null)
					hashCode = hashCode * 59 + EndDate.GetHashCode();
				if (FilingDate != null)
					hashCode = hashCode * 59 + FilingDate.GetHashCode();
				return hashCode;
			}
		}
	}
}