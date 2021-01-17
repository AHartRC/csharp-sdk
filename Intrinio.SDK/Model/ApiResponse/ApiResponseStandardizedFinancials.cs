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
	///     ApiResponseStandardizedFinancials
	/// </summary>
	[DataContract]
	public class ApiResponseStandardizedFinancials : IEquatable<ApiResponseStandardizedFinancials>, IValidatableObject
	{
		/// <summary>
		///     Initializes a new instance of the <see cref="ApiResponseStandardizedFinancials" /> class.
		/// </summary>
		/// <param name="StandardizedFinancials">StandardizedFinancials.</param>
		/// <param name="Fundamental">Fundamental.</param>
		/// <param name="NextPage">
		///     The token required to request the next page of the data. If null, no further results are
		///     available..
		/// </param>
		public ApiResponseStandardizedFinancials(List<StandardizedFinancial> StandardizedFinancials = default,
			Fundamental Fundamental = default, string NextPage = default)
		{
			this.StandardizedFinancials = StandardizedFinancials;
			this.Fundamental = Fundamental;
			this.NextPage = NextPage;
		}

		/// <summary>
		///     Gets or Sets StandardizedFinancials
		/// </summary>
		[DataMember(Name = "standardized_financials", EmitDefaultValue = false)]
		public List<StandardizedFinancial> StandardizedFinancials { get; set; }

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
		///     Returns true if ApiResponseStandardizedFinancials instances are equal
		/// </summary>
		/// <param name="input">Instance of ApiResponseStandardizedFinancials to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(ApiResponseStandardizedFinancials input)
		{
			if (input == null)
				return false;

			return
				(
					StandardizedFinancials == input.StandardizedFinancials ||
					StandardizedFinancials != null &&
					StandardizedFinancials.SequenceEqual(input.StandardizedFinancials)
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
			sb.Append("class ApiResponseStandardizedFinancials {\n");
			sb.Append("  StandardizedFinancials: ").Append(StandardizedFinancials).Append("\n");
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
			return Equals(input as ApiResponseStandardizedFinancials);
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
				if (StandardizedFinancials != null)
					hashCode = hashCode * 59 + StandardizedFinancials.GetHashCode();
				if (Fundamental != null)
					hashCode = hashCode * 59 + Fundamental.GetHashCode();
				if (NextPage != null)
					hashCode = hashCode * 59 + NextPage.GetHashCode();
				return hashCode;
			}
		}
	}
}