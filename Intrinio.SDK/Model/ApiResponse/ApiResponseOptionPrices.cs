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
	///     ApiResponseOptionPrices
	/// </summary>
	[DataContract]
	public class ApiResponseOptionPrices : IEquatable<ApiResponseOptionPrices>, IValidatableObject
	{
		/// <summary>
		///     Initializes a new instance of the <see cref="ApiResponseOptionPrices" /> class.
		/// </summary>
		/// <param name="Prices">A list of option prices in descending order by date.</param>
		/// <param name="Option">Option.</param>
		/// <param name="NextPage">
		///     The token required to request the next page of the data. If null, no further results are
		///     available..
		/// </param>
		public ApiResponseOptionPrices(List<OptionPrice> Prices = default, Option Option = default,
			string NextPage = default)
		{
			this.Prices = Prices;
			this.Option = Option;
			this.NextPage = NextPage;
		}

		/// <summary>
		///     A list of option prices in descending order by date
		/// </summary>
		/// <value>A list of option prices in descending order by date</value>
		[DataMember(Name = "prices", EmitDefaultValue = false)]
		public List<OptionPrice> Prices { get; set; }

		/// <summary>
		///     Gets or Sets Option
		/// </summary>
		[DataMember(Name = "option", EmitDefaultValue = false)]
		public Option Option { get; set; }

		/// <summary>
		///     The token required to request the next page of the data. If null, no further results are available.
		/// </summary>
		/// <value>The token required to request the next page of the data. If null, no further results are available.</value>
		[DataMember(Name = "next_page", EmitDefaultValue = false)]
		public string NextPage { get; set; }

		/// <summary>
		///     Returns true if ApiResponseOptionPrices instances are equal
		/// </summary>
		/// <param name="input">Instance of ApiResponseOptionPrices to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(ApiResponseOptionPrices input)
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
					Option == input.Option ||
					Option != null &&
					Option.Equals(input.Option)
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
			sb.Append("class ApiResponseOptionPrices {\n");
			sb.Append("  Prices: ").Append(Prices).Append("\n");
			sb.Append("  Option: ").Append(Option).Append("\n");
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
			return Equals(input as ApiResponseOptionPrices);
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
				if (Option != null)
					hashCode = hashCode * 59 + Option.GetHashCode();
				if (NextPage != null)
					hashCode = hashCode * 59 + NextPage.GetHashCode();
				return hashCode;
			}
		}
	}
}