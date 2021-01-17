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
	///     ApiResponseForexCurrencies
	/// </summary>
	[DataContract]
	public class ApiResponseForexCurrencies : IEquatable<ApiResponseForexCurrencies>, IValidatableObject
	{
		/// <summary>
		///     Initializes a new instance of the <see cref="ApiResponseForexCurrencies" /> class.
		/// </summary>
		/// <param name="Currencies">Currencies.</param>
		public ApiResponseForexCurrencies(List<ForexCurrency> Currencies = default)
		{
			this.Currencies = Currencies;
		}

		/// <summary>
		///     Gets or Sets Currencies
		/// </summary>
		[DataMember(Name = "currencies", EmitDefaultValue = false)]
		public List<ForexCurrency> Currencies { get; set; }

		/// <summary>
		///     Returns true if ApiResponseForexCurrencies instances are equal
		/// </summary>
		/// <param name="input">Instance of ApiResponseForexCurrencies to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(ApiResponseForexCurrencies input)
		{
			if (input == null)
				return false;

			return
				Currencies == input.Currencies ||
				Currencies != null &&
				Currencies.SequenceEqual(input.Currencies);
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
			sb.Append("class ApiResponseForexCurrencies {\n");
			sb.Append("  Currencies: ").Append(Currencies).Append("\n");
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
			return Equals(input as ApiResponseForexCurrencies);
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
				if (Currencies != null)
					hashCode = hashCode * 59 + Currencies.GetHashCode();
				return hashCode;
			}
		}
	}
}