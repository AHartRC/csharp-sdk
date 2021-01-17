using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json;

namespace Intrinio.SDK.Model
{
	/// <summary>
	///     An intraday stock price for a Security.
	/// </summary>
	[DataContract]
	public class IntradayStockPrice : IEquatable<IntradayStockPrice>, IValidatableObject
	{
		/// <summary>
		///     Initializes a new instance of the <see cref="IntradayStockPrice" /> class.
		/// </summary>
		/// <param name="Time">The timestamp that the &#x60;last_price&#x60; represents..</param>
		/// <param name="LastPrice">The price of the last trade..</param>
		/// <param name="AskPrice">The price of the top ask order..</param>
		/// <param name="AskSize">The size of the top ask order..</param>
		/// <param name="BidPrice">The price of the top bid order..</param>
		/// <param name="BidSize">The size of the top bid order..</param>
		/// <param name="Volume">The number of shares exchanged during the trading day on the exchange..</param>
		/// <param name="Source">The source of the data..</param>
		public IntradayStockPrice(DateTime? Time = default, decimal? LastPrice = default, decimal? AskPrice = default,
			decimal? AskSize = default, decimal? BidPrice = default, decimal? BidSize = default,
			decimal? Volume = default, string Source = default)
		{
			this.Time = Time;
			this.LastPrice = LastPrice;
			this.AskPrice = AskPrice;
			this.AskSize = AskSize;
			this.BidPrice = BidPrice;
			this.BidSize = BidSize;
			this.Volume = Volume;
			this.Source = Source;
		}

		/// <summary>
		///     The timestamp that the &#x60;last_price&#x60; represents.
		/// </summary>
		/// <value>The timestamp that the &#x60;last_price&#x60; represents.</value>
		[DataMember(Name = "time", EmitDefaultValue = false)]
		public DateTime? Time { get; set; }

		/// <summary>
		///     The price of the last trade.
		/// </summary>
		/// <value>The price of the last trade.</value>
		[DataMember(Name = "last_price", EmitDefaultValue = false)]
		public decimal? LastPrice { get; set; }

		/// <summary>
		///     The price of the top ask order.
		/// </summary>
		/// <value>The price of the top ask order.</value>
		[DataMember(Name = "ask_price", EmitDefaultValue = false)]
		public decimal? AskPrice { get; set; }

		/// <summary>
		///     The size of the top ask order.
		/// </summary>
		/// <value>The size of the top ask order.</value>
		[DataMember(Name = "ask_size", EmitDefaultValue = false)]
		public decimal? AskSize { get; set; }

		/// <summary>
		///     The price of the top bid order.
		/// </summary>
		/// <value>The price of the top bid order.</value>
		[DataMember(Name = "bid_price", EmitDefaultValue = false)]
		public decimal? BidPrice { get; set; }

		/// <summary>
		///     The size of the top bid order.
		/// </summary>
		/// <value>The size of the top bid order.</value>
		[DataMember(Name = "bid_size", EmitDefaultValue = false)]
		public decimal? BidSize { get; set; }

		/// <summary>
		///     The number of shares exchanged during the trading day on the exchange.
		/// </summary>
		/// <value>The number of shares exchanged during the trading day on the exchange.</value>
		[DataMember(Name = "volume", EmitDefaultValue = false)]
		public decimal? Volume { get; set; }

		/// <summary>
		///     The source of the data.
		/// </summary>
		/// <value>The source of the data.</value>
		[DataMember(Name = "source", EmitDefaultValue = false)]
		public string Source { get; set; }

		/// <summary>
		///     Returns true if IntradayStockPrice instances are equal
		/// </summary>
		/// <param name="input">Instance of IntradayStockPrice to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(IntradayStockPrice input)
		{
			if (input == null)
				return false;

			return
				(
					Time == input.Time ||
					Time != null &&
					Time.Equals(input.Time)
				) &&
				(
					LastPrice == input.LastPrice ||
					LastPrice != null &&
					LastPrice.Equals(input.LastPrice)
				) &&
				(
					AskPrice == input.AskPrice ||
					AskPrice != null &&
					AskPrice.Equals(input.AskPrice)
				) &&
				(
					AskSize == input.AskSize ||
					AskSize != null &&
					AskSize.Equals(input.AskSize)
				) &&
				(
					BidPrice == input.BidPrice ||
					BidPrice != null &&
					BidPrice.Equals(input.BidPrice)
				) &&
				(
					BidSize == input.BidSize ||
					BidSize != null &&
					BidSize.Equals(input.BidSize)
				) &&
				(
					Volume == input.Volume ||
					Volume != null &&
					Volume.Equals(input.Volume)
				) &&
				(
					Source == input.Source ||
					Source != null &&
					Source.Equals(input.Source)
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
			sb.Append("class IntradayStockPrice {\n");
			sb.Append("  Time: ").Append(Time).Append("\n");
			sb.Append("  LastPrice: ").Append(LastPrice).Append("\n");
			sb.Append("  AskPrice: ").Append(AskPrice).Append("\n");
			sb.Append("  AskSize: ").Append(AskSize).Append("\n");
			sb.Append("  BidPrice: ").Append(BidPrice).Append("\n");
			sb.Append("  BidSize: ").Append(BidSize).Append("\n");
			sb.Append("  Volume: ").Append(Volume).Append("\n");
			sb.Append("  Source: ").Append(Source).Append("\n");
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
			return Equals(input as IntradayStockPrice);
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
				if (Time != null)
					hashCode = hashCode * 59 + Time.GetHashCode();
				if (LastPrice != null)
					hashCode = hashCode * 59 + LastPrice.GetHashCode();
				if (AskPrice != null)
					hashCode = hashCode * 59 + AskPrice.GetHashCode();
				if (AskSize != null)
					hashCode = hashCode * 59 + AskSize.GetHashCode();
				if (BidPrice != null)
					hashCode = hashCode * 59 + BidPrice.GetHashCode();
				if (BidSize != null)
					hashCode = hashCode * 59 + BidSize.GetHashCode();
				if (Volume != null)
					hashCode = hashCode * 59 + Volume.GetHashCode();
				if (Source != null)
					hashCode = hashCode * 59 + Source.GetHashCode();
				return hashCode;
			}
		}
	}
}