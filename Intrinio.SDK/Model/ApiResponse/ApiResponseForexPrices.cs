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
	///     ApiResponseForexPrices
	/// </summary>
	[DataContract]
	public class ApiResponseForexPrices : IEquatable<ApiResponseForexPrices>, IValidatableObject
	{
		/// <summary>
		///     Initializes a new instance of the <see cref="ApiResponseForexPrices" /> class.
		/// </summary>
		/// <param name="Prices">Prices.</param>
		/// <param name="Pair">The Forex currency pair for which prices were requested.</param>
		/// <param name="NextPage">
		///     The token required to request the next page of the data. If null, no further results are
		///     available..
		/// </param>
		public ApiResponseForexPrices(List<ForexPrice> Prices = default, ForexPair Pair = default,
			string NextPage = default)
		{
			this.Prices = Prices;
			this.Pair = Pair;
			this.NextPage = NextPage;
		}

		/// <summary>
		///     Gets or Sets Prices
		/// </summary>
		[DataMember(Name = "prices", EmitDefaultValue = false)]
		public List<ForexPrice> Prices { get; set; }

		/// <summary>
		///     The Forex currency pair for which prices were requested
		/// </summary>
		/// <value>The Forex currency pair for which prices were requested</value>
		[DataMember(Name = "pair", EmitDefaultValue = false)]
		public ForexPair Pair { get; set; }

		/// <summary>
		///     The token required to request the next page of the data. If null, no further results are available.
		/// </summary>
		/// <value>The token required to request the next page of the data. If null, no further results are available.</value>
		[DataMember(Name = "next_page", EmitDefaultValue = false)]
		public string NextPage { get; set; }

		/// <summary>
		///     Returns true if ApiResponseForexPrices instances are equal
		/// </summary>
		/// <param name="input">Instance of ApiResponseForexPrices to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(ApiResponseForexPrices input)
		{
			if (input == null)
				return false;

			return
				(
					Prices == input.Prices ||
					Prices != null &&
					Prices.SequenceEqual(input.Prices)
				) &&
				(
					Pair == input.Pair ||
					Pair != null &&
					Pair.Equals(input.Pair)
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
			sb.Append("class ApiResponseForexPrices {\n");
			sb.Append("  Prices: ").Append(Prices).Append("\n");
			sb.Append("  Pair: ").Append(Pair).Append("\n");
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
			return Equals(input as ApiResponseForexPrices);
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
				if (Prices != null)
					hashCode = hashCode * 59 + Prices.GetHashCode();
				if (Pair != null)
					hashCode = hashCode * 59 + Pair.GetHashCode();
				if (NextPage != null)
					hashCode = hashCode * 59 + NextPage.GetHashCode();
				return hashCode;
			}
		}
	}
}