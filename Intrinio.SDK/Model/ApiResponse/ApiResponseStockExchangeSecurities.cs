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
	///     ApiResponseStockExchangeSecurities
	/// </summary>
	[DataContract]
	public class ApiResponseStockExchangeSecurities : IEquatable<ApiResponseStockExchangeSecurities>, IValidatableObject
	{
		/// <summary>
		///     Initializes a new instance of the <see cref="ApiResponseStockExchangeSecurities" /> class.
		/// </summary>
		/// <param name="Securities">The securities traded on the Stock Exchange.</param>
		/// <param name="StockExchange">The Stock Exchange resolved from the given identifier.</param>
		/// <param name="NextPage">
		///     The token required to request the next page of the data. If null, no further results are
		///     available..
		/// </param>
		public ApiResponseStockExchangeSecurities(List<SecuritySummary> Securities = default,
			StockExchange StockExchange = default, string NextPage = default)
		{
			this.Securities = Securities;
			this.StockExchange = StockExchange;
			this.NextPage = NextPage;
		}

		/// <summary>
		///     The securities traded on the Stock Exchange
		/// </summary>
		/// <value>The securities traded on the Stock Exchange</value>
		[DataMember(Name = "securities", EmitDefaultValue = false)]
		public List<SecuritySummary> Securities { get; set; }

		/// <summary>
		///     The Stock Exchange resolved from the given identifier
		/// </summary>
		/// <value>The Stock Exchange resolved from the given identifier</value>
		[DataMember(Name = "stock_exchange", EmitDefaultValue = false)]
		public StockExchange StockExchange { get; set; }

		/// <summary>
		///     The token required to request the next page of the data. If null, no further results are available.
		/// </summary>
		/// <value>The token required to request the next page of the data. If null, no further results are available.</value>
		[DataMember(Name = "next_page", EmitDefaultValue = false)]
		public string NextPage { get; set; }

		/// <summary>
		///     Returns true if ApiResponseStockExchangeSecurities instances are equal
		/// </summary>
		/// <param name="input">Instance of ApiResponseStockExchangeSecurities to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(ApiResponseStockExchangeSecurities input)
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
					StockExchange == input.StockExchange ||
					StockExchange != null &&
					StockExchange.Equals(input.StockExchange)
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
			sb.Append("class ApiResponseStockExchangeSecurities {\n");
			sb.Append("  Securities: ").Append(Securities).Append("\n");
			sb.Append("  StockExchange: ").Append(StockExchange).Append("\n");
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
			return Equals(input as ApiResponseStockExchangeSecurities);
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
				if (StockExchange != null)
					hashCode = hashCode * 59 + StockExchange.GetHashCode();
				if (NextPage != null)
					hashCode = hashCode * 59 + NextPage.GetHashCode();
				return hashCode;
			}
		}
	}
}