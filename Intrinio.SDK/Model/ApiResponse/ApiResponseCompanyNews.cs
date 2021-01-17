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
	///     ApiResponseCompanyNews
	/// </summary>
	[DataContract]
	public class ApiResponseCompanyNews : IEquatable<ApiResponseCompanyNews>, IValidatableObject
	{
		/// <summary>
		///     Initializes a new instance of the <see cref="ApiResponseCompanyNews" /> class.
		/// </summary>
		/// <param name="News">News.</param>
		/// <param name="Company">Company.</param>
		/// <param name="NextPage">
		///     The token required to request the next page of the data. If null, no further results are
		///     available..
		/// </param>
		public ApiResponseCompanyNews(List<CompanyNewsSummary> News = default, CompanySummary Company = default,
			string NextPage = default)
		{
			this.News = News;
			this.Company = Company;
			this.NextPage = NextPage;
		}

		/// <summary>
		///     Gets or Sets News
		/// </summary>
		[DataMember(Name = "news", EmitDefaultValue = false)]
		public List<CompanyNewsSummary> News { get; set; }

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
		///     Returns true if ApiResponseCompanyNews instances are equal
		/// </summary>
		/// <param name="input">Instance of ApiResponseCompanyNews to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(ApiResponseCompanyNews input)
		{
			if (input == null)
				return false;

			return
				(
					News == input.News ||
					News != null &&
					News.SequenceEqual(input.News)
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
			sb.Append("class ApiResponseCompanyNews {\n");
			sb.Append("  News: ").Append(News).Append("\n");
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
			return Equals(input as ApiResponseCompanyNews);
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
				if (News != null)
					hashCode = hashCode * 59 + News.GetHashCode();
				if (Company != null)
					hashCode = hashCode * 59 + Company.GetHashCode();
				if (NextPage != null)
					hashCode = hashCode * 59 + NextPage.GetHashCode();
				return hashCode;
			}
		}
	}
}