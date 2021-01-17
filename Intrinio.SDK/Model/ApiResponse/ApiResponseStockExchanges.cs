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
	///     ApiResponseStockExchanges
	/// </summary>
	[DataContract]
	public class ApiResponseStockExchanges : IEquatable<ApiResponseStockExchanges>, IValidatableObject
	{
		/// <summary>
		///     Initializes a new instance of the <see cref="ApiResponseStockExchanges" /> class.
		/// </summary>
		/// <param name="StockExchanges">StockExchanges.</param>
		/// <param name="NextPage">
		///     The token required to request the next page of the data. If null, no further results are
		///     available..
		/// </param>
		public ApiResponseStockExchanges(List<StockExchange> StockExchanges = default, string NextPage = default)
		{
			this.StockExchanges = StockExchanges;
			this.NextPage = NextPage;
		}

		/// <summary>
		///     Gets or Sets StockExchanges
		/// </summary>
		[DataMember(Name = "stock_exchanges", EmitDefaultValue = false)]
		public List<StockExchange> StockExchanges { get; set; }

		/// <summary>
		///     The token required to request the next page of the data. If null, no further results are available.
		/// </summary>
		/// <value>The token required to request the next page of the data. If null, no further results are available.</value>
		[DataMember(Name = "next_page", EmitDefaultValue = false)]
		public string NextPage { get; set; }

		/// <summary>
		///     Returns true if ApiResponseStockExchanges instances are equal
		/// </summary>
		/// <param name="input">Instance of ApiResponseStockExchanges to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(ApiResponseStockExchanges input)
		{
			if (input == null)
				return false;

			return
				(
					StockExchanges == input.StockExchanges ||
					StockExchanges != null &&
					StockExchanges.SequenceEqual(input.StockExchanges)
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
			sb.Append("class ApiResponseStockExchanges {\n");
			sb.Append("  StockExchanges: ").Append(StockExchanges).Append("\n");
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
			return Equals(input as ApiResponseStockExchanges);
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
				if (StockExchanges != null)
					hashCode = hashCode * 59 + StockExchanges.GetHashCode();
				if (NextPage != null)
					hashCode = hashCode * 59 + NextPage.GetHashCode();
				return hashCode;
			}
		}
	}
}