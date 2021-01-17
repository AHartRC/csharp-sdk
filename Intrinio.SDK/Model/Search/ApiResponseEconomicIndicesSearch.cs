using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json;

namespace Intrinio.SDK.Model.Search
{
	/// <summary>
	///     ApiResponseEconomicIndicesSearch
	/// </summary>
	[DataContract]
	public class ApiResponseEconomicIndicesSearch : IEquatable<ApiResponseEconomicIndicesSearch>, IValidatableObject
	{
		/// <summary>
		///     Initializes a new instance of the <see cref="ApiResponseEconomicIndicesSearch" /> class.
		/// </summary>
		/// <param name="Indices">Indices.</param>
		public ApiResponseEconomicIndicesSearch(List<EconomicIndexSummary> Indices = default)
		{
			this.Indices = Indices;
		}

		/// <summary>
		///     Gets or Sets Indices
		/// </summary>
		[DataMember(Name = "indices", EmitDefaultValue = false)]
		public List<EconomicIndexSummary> Indices { get; set; }

		/// <summary>
		///     Returns true if ApiResponseEconomicIndicesSearch instances are equal
		/// </summary>
		/// <param name="input">Instance of ApiResponseEconomicIndicesSearch to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(ApiResponseEconomicIndicesSearch input)
		{
			if (input == null)
				return false;

			return
				Indices == input.Indices ||
				Indices != null &&
				Indices.SequenceEqual(input.Indices);
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
			sb.Append("class ApiResponseEconomicIndicesSearch {\n");
			sb.Append("  Indices: ").Append(Indices).Append("\n");
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
			return Equals(input as ApiResponseEconomicIndicesSearch);
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
				return hashCode;
			}
		}
	}
}