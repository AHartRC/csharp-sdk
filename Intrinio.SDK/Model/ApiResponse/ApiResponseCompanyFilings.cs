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
	///     ApiResponseCompanyFilings
	/// </summary>
	[DataContract]
	public class ApiResponseCompanyFilings : IEquatable<ApiResponseCompanyFilings>, IValidatableObject
	{
		/// <summary>
		///     Initializes a new instance of the <see cref="ApiResponseCompanyFilings" /> class.
		/// </summary>
		/// <param name="Filings">Filings.</param>
		/// <param name="Company">Company.</param>
		/// <param name="NextPage">
		///     The token required to request the next page of the data. If null, no further results are
		///     available..
		/// </param>
		public ApiResponseCompanyFilings(List<FilingSummary> Filings = default, CompanySummary Company = default,
			string NextPage = default)
		{
			this.Filings = Filings;
			this.Company = Company;
			this.NextPage = NextPage;
		}

		/// <summary>
		///     Gets or Sets Filings
		/// </summary>
		[DataMember(Name = "filings", EmitDefaultValue = false)]
		public List<FilingSummary> Filings { get; set; }

		/// <summary>
		///     Gets or Sets Company
		/// </summary>
		[DataMember(Name = "company", EmitDefaultValue = false)]
		public CompanySummary Company { get; set; }

		/// <summary>
		///     The token required to request the next page of the data. If null, no further results are available.
		/// </summary>
		/// <value>The token required to request the next page of the data. If null, no further results are available.</value>
		[DataMember(Name = "next_page", EmitDefaultValue = false)]
		public string NextPage { get; set; }

		/// <summary>
		///     Returns true if ApiResponseCompanyFilings instances are equal
		/// </summary>
		/// <param name="input">Instance of ApiResponseCompanyFilings to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(ApiResponseCompanyFilings input)
		{
			if (input == null)
				return false;

			return
				(
					Filings == input.Filings ||
					Filings != null &&
					Filings.SequenceEqual(input.Filings)
				) &&
				(
					Company == input.Company ||
					Company != null &&
					Company.Equals(input.Company)
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
			sb.Append("class ApiResponseCompanyFilings {\n");
			sb.Append("  Filings: ").Append(Filings).Append("\n");
			sb.Append("  Company: ").Append(Company).Append("\n");
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
			return Equals(input as ApiResponseCompanyFilings);
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
				if (Filings != null)
					hashCode = hashCode * 59 + Filings.GetHashCode();
				if (Company != null)
					hashCode = hashCode * 59 + Company.GetHashCode();
				if (NextPage != null)
					hashCode = hashCode * 59 + NextPage.GetHashCode();
				return hashCode;
			}
		}
	}
}