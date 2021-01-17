using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json;

namespace Intrinio.SDK.Model.ApiResponse
{
	/// <summary>
	///     ApiResponseReportedFinancials
	/// </summary>
	[DataContract]
	public class ApiResponseReportedFinancials : IEquatable<ApiResponseReportedFinancials>, IValidatableObject
	{
		/// <summary>
		///     Initializes a new instance of the <see cref="ApiResponseReportedFinancials" /> class.
		/// </summary>
		/// <param name="ReportedFinancials">ReportedFinancials.</param>
		/// <param name="Fundamental">Fundamental.</param>
		/// <param name="NextPage">
		///     The token required to request the next page of the data. If null, no further results are
		///     available..
		/// </param>
		public ApiResponseReportedFinancials(List<ReportedFinancial> ReportedFinancials = default,
			Fundamental Fundamental = default, string NextPage = default)
		{
			this.ReportedFinancials = ReportedFinancials;
			this.Fundamental = Fundamental;
			this.NextPage = NextPage;
		}

		/// <summary>
		///     Gets or Sets ReportedFinancials
		/// </summary>
		[DataMember(Name = "reported_financials", EmitDefaultValue = false)]
		public List<ReportedFinancial> ReportedFinancials { get; set; }

		/// <summary>
		///     Gets or Sets Fundamental
		/// </summary>
		[DataMember(Name = "fundamental", EmitDefaultValue = false)]
		public Fundamental Fundamental { get; set; }

		/// <summary>
		///     The token required to request the next page of the data. If null, no further results are available.
		/// </summary>
		/// <value>The token required to request the next page of the data. If null, no further results are available.</value>
		[DataMember(Name = "next_page", EmitDefaultValue = false)]
		public string NextPage { get; set; }

		/// <summary>
		///     Returns true if ApiResponseReportedFinancials instances are equal
		/// </summary>
		/// <param name="input">Instance of ApiResponseReportedFinancials to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(ApiResponseReportedFinancials input)
		{
			if (input == null)
				return false;

			return
				(
					ReportedFinancials == input.ReportedFinancials ||
					ReportedFinancials != null &&
					ReportedFinancials.SequenceEqual(input.ReportedFinancials)
				) &&
				(
					Fundamental == input.Fundamental ||
					Fundamental != null &&
					Fundamental.Equals(input.Fundamental)
				) &&
				(
					NextPage == input.NextPage ||
					NextPage != null &&
					NextPage.Equals(input.NextPage)
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
			sb.Append("class ApiResponseReportedFinancials {\n");
			sb.Append("  ReportedFinancials: ").Append(ReportedFinancials).Append("\n");
			sb.Append("  Fundamental: ").Append(Fundamental).Append("\n");
			sb.Append("  NextPage: ").Append(NextPage).Append("\n");
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
			return Equals(input as ApiResponseReportedFinancials);
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
				if (ReportedFinancials != null)
					hashCode = hashCode * 59 + ReportedFinancials.GetHashCode();
				if (Fundamental != null)
					hashCode = hashCode * 59 + Fundamental.GetHashCode();
				if (NextPage != null)
					hashCode = hashCode * 59 + NextPage.GetHashCode();
				return hashCode;
			}
		}
	}
}