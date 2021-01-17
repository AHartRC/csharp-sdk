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
	///     ApiResponseEconomicIndices
	/// </summary>
	[DataContract]
	public class ApiResponseEconomicIndices : IEquatable<ApiResponseEconomicIndices>, IValidatableObject
	{
		/// <summary>
		///     Initializes a new instance of the <see cref="ApiResponseEconomicIndices" /> class.
		/// </summary>
		/// <param name="Indices">Indices.</param>
		/// <param name="NextPage">
		///     The token required to request the next page of the data. If null, no further results are
		///     available..
		/// </param>
		public ApiResponseEconomicIndices(List<EconomicIndexSummary> Indices = default, string NextPage = default)
		{
			this.Indices = Indices;
			this.NextPage = NextPage;
		}

		/// <summary>
		///     Gets or Sets Indices
		/// </summary>
		[DataMember(Name = "indices", EmitDefaultValue = false)]
		public List<EconomicIndexSummary> Indices { get; set; }

		/// <summary>
		///     The token required to request the next page of the data. If null, no further results are available.
		/// </summary>
		/// <value>The token required to request the next page of the data. If null, no further results are available.</value>
		[DataMember(Name = "next_page", EmitDefaultValue = false)]
		public string NextPage { get; set; }

		/// <summary>
		///     Returns true if ApiResponseEconomicIndices instances are equal
		/// </summary>
		/// <param name="input">Instance of ApiResponseEconomicIndices to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(ApiResponseEconomicIndices input)
		{
			if (input == null)
				return false;

			return
				(
					Indices == input.Indices ||
					Indices != null &&
					Indices.SequenceEqual(input.Indices)
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
			sb.Append("class ApiResponseEconomicIndices {\n");
			sb.Append("  Indices: ").Append(Indices).Append("\n");
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
			return Equals(input as ApiResponseEconomicIndices);
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
				if (Indices != null)
					hashCode = hashCode * 59 + Indices.GetHashCode();
				if (NextPage != null)
					hashCode = hashCode * 59 + NextPage.GetHashCode();
				return hashCode;
			}
		}
	}
}