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
	///     ApiResponseForexPairs
	/// </summary>
	[DataContract]
	public class ApiResponseForexPairs : IEquatable<ApiResponseForexPairs>, IValidatableObject
	{
		/// <summary>
		///     Initializes a new instance of the <see cref="ApiResponseForexPairs" /> class.
		/// </summary>
		/// <param name="Pairs">Pairs.</param>
		public ApiResponseForexPairs(List<ForexPair> Pairs = default)
		{
			this.Pairs = Pairs;
		}

		/// <summary>
		///     Gets or Sets Pairs
		/// </summary>
		[DataMember(Name = "pairs", EmitDefaultValue = false)]
		public List<ForexPair> Pairs { get; set; }

		/// <summary>
		///     Returns true if ApiResponseForexPairs instances are equal
		/// </summary>
		/// <param name="input">Instance of ApiResponseForexPairs to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(ApiResponseForexPairs input)
		{
			if (input == null)
				return false;

			return
				Pairs == input.Pairs ||
				Pairs != null &&
				Pairs.SequenceEqual(input.Pairs);
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
			sb.Append("class ApiResponseForexPairs {\n");
			sb.Append("  Pairs: ").Append(Pairs).Append("\n");
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
			return Equals(input as ApiResponseForexPairs);
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
				if (Pairs != null)
					hashCode = hashCode * 59 + Pairs.GetHashCode();
				return hashCode;
			}
		}
	}
}