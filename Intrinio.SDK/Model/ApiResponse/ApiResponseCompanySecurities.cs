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
	///     ApiResponseCompanySecurities
	/// </summary>
	[DataContract]
	public class ApiResponseCompanySecurities : IEquatable<ApiResponseCompanySecurities>, IValidatableObject
	{
		/// <summary>
		///     Initializes a new instance of the <see cref="ApiResponseCompanySecurities" /> class.
		/// </summary>
		/// <param name="Securities">Securities.</param>
		/// <param name="Company">Company.</param>
		/// <param name="NextPage">
		///     The token required to request the next page of the data. If null, no further results are
		///     available..
		/// </param>
		public ApiResponseCompanySecurities(List<SecuritySummary> Securities = default,
			CompanySummary Company = default, string NextPage = default)
		{
			this.Securities = Securities;
			this.Company = Company;
			this.NextPage = NextPage;
		}

		/// <summary>
		///     Gets or Sets Securities
		/// </summary>
		[DataMember(Name = "securities", EmitDefaultValue = false)]
		public List<SecuritySummary> Securities { get; set; }

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
		///     Returns true if ApiResponseCompanySecurities instances are equal
		/// </summary>
		/// <param name="input">Instance of ApiResponseCompanySecurities to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(ApiResponseCompanySecurities input)
		{
			if (input == null)
				return false;

			return
				(
					Securities == input.Securities ||
					Securities != null &&
					Securities.SequenceEqual(input.Securities)
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
			sb.Append("class ApiResponseCompanySecurities {\n");
			sb.Append("  Securities: ").Append(Securities).Append("\n");
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
			return Equals(input as ApiResponseCompanySecurities);
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
				if (Securities != null)
					hashCode = hashCode * 59 + Securities.GetHashCode();
				if (Company != null)
					hashCode = hashCode * 59 + Company.GetHashCode();
				if (NextPage != null)
					hashCode = hashCode * 59 + NextPage.GetHashCode();
				return hashCode;
			}
		}
	}
}