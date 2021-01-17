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
	///     ApiResponseSecurityStockPrices
	/// </summary>
	[DataContract]
	public class ApiResponseSecurityStockPrices : IEquatable<ApiResponseSecurityStockPrices>, IValidatableObject
	{
		/// <summary>
		///     Initializes a new instance of the <see cref="ApiResponseSecurityStockPrices" /> class.
		/// </summary>
		/// <param name="StockPrices">The stock prices for the Security.</param>
		/// <param name="Security">The Security resolved from the given identifier.</param>
		/// <param name="NextPage">
		///     The token required to request the next page of the data. If null, no further results are
		///     available..
		/// </param>
		public ApiResponseSecurityStockPrices(List<StockPriceSummary> StockPrices = default,
			SecuritySummary Security = default, string NextPage = default)
		{
			this.StockPrices = StockPrices;
			this.Security = Security;
			this.NextPage = NextPage;
		}

		/// <summary>
		///     The stock prices for the Security
		/// </summary>
		/// <value>The stock prices for the Security</value>
		[DataMember(Name = "stock_prices", EmitDefaultValue = false)]
		public List<StockPriceSummary> StockPrices { get; set; }

		/// <summary>
		///     The Security resolved from the given identifier
		/// </summary>
		/// <value>The Security resolved from the given identifier</value>
		[DataMember(Name = "security", EmitDefaultValue = false)]
		public SecuritySummary Security { get; set; }

		/// <summary>
		///     The token required to request the next page of the data. If null, no further results are available.
		/// </summary>
		/// <value>The token required to request the next page of the data. If null, no further results are available.</value>
		[DataMember(Name = "next_page", EmitDefaultValue = false)]
		public string NextPage { get; set; }

		/// <summary>
		///     Returns true if ApiResponseSecurityStockPrices instances are equal
		/// </summary>
		/// <param name="input">Instance of ApiResponseSecurityStockPrices to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(ApiResponseSecurityStockPrices input)
		{
			if (input == null)
				return false;

			return
				(
					StockPrices == input.StockPrices ||
					StockPrices != null &&
					StockPrices.SequenceEqual(input.StockPrices)
				) &&
				(
					Security == input.Security ||
					Security != null &&
					Security.Equals(input.Security)
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
			sb.Append("class ApiResponseSecurityStockPrices {\n");
			sb.Append("  StockPrices: ").Append(StockPrices).Append("\n");
			sb.Append("  Security: ").Append(Security).Append("\n");
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
			return Equals(input as ApiResponseSecurityStockPrices);
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
				if (StockPrices != null)
					hashCode = hashCode * 59 + StockPrices.GetHashCode();
				if (Security != null)
					hashCode = hashCode * 59 + Security.GetHashCode();
				if (NextPage != null)
					hashCode = hashCode * 59 + NextPage.GetHashCode();
				return hashCode;
			}
		}
	}
}