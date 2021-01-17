using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json;

namespace Intrinio.SDK.Model
{
	/// <summary>
	///     The realtime stock price of a security.
	/// </summary>
	[DataContract]
	public class RealtimeStockPrice : IEquatable<RealtimeStockPrice>, IValidatableObject
	{
		/// <summary>
		///     Initializes a new instance of the <see cref="RealtimeStockPrice" /> class.
		/// </summary>
		/// <param name="LastPrice">The price of the last trade..</param>
		/// <param name="LastTime">The date and time when the last trade occurred..</param>
		/// <param name="LastSize">The size of the last trade..</param>
		/// <param name="BidPrice">The price of the top bid order..</param>
		/// <param name="BidSize">The size of the top bid order..</param>
		/// <param name="AskPrice">The price of the top ask order..</param>
		/// <param name="AskSize">The size of the top ask order..</param>
		/// <param name="OpenPrice">The price at the open of the trading day..</param>
		/// <param name="HighPrice">The high price for the trading day..</param>
		/// <param name="LowPrice">The low price for the trading day..</param>
		/// <param name="ExchangeVolume">The number of shares exchanged during the trading day on the exchange..</param>
		/// <param name="MarketVolume">The number of shares exchanged during the trading day for the whole market..</param>
		/// <param name="UpdatedOn">The date and time when the data was last updated..</param>
		/// <param name="Source">The source of the data..</param>
		/// <param name="Security">Security.</param>
		public RealtimeStockPrice(decimal? LastPrice = default, DateTime? LastTime = default,
			decimal? LastSize = default, decimal? BidPrice = default, decimal? BidSize = default,
			decimal? AskPrice = default, decimal? AskSize = default, decimal? OpenPrice = default,
			decimal? HighPrice = default, decimal? LowPrice = default, decimal? ExchangeVolume = default,
			decimal? MarketVolume = default, DateTime? UpdatedOn = default, string Source = default,
			RealtimeStockPriceSecurity Security = default)
		{
			this.LastPrice = LastPrice;
			this.LastTime = LastTime;
			this.LastSize = LastSize;
			this.BidPrice = BidPrice;
			this.BidSize = BidSize;
			this.AskPrice = AskPrice;
			this.AskSize = AskSize;
			this.OpenPrice = OpenPrice;
			this.HighPrice = HighPrice;
			this.LowPrice = LowPrice;
			this.ExchangeVolume = ExchangeVolume;
			this.MarketVolume = MarketVolume;
			this.UpdatedOn = UpdatedOn;
			this.Source = Source;
			this.Security = Security;
		}

		/// <summary>
		///     The price of the last trade.
		/// </summary>
		/// <value>The price of the last trade.</value>
		[DataMember(Name = "last_price", EmitDefaultValue = false)]
		public decimal? LastPrice { get; set; }

		/// <summary>
		///     The date and time when the last trade occurred.
		/// </summary>
		/// <value>The date and time when the last trade occurred.</value>
		[DataMember(Name = "last_time", EmitDefaultValue = false)]
		public DateTime? LastTime { get; set; }

		/// <summary>
		///     The size of the last trade.
		/// </summary>
		/// <value>The size of the last trade.</value>
		[DataMember(Name = "last_size", EmitDefaultValue = false)]
		public decimal? LastSize { get; set; }

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
		///     The price at the open of the trading day.
		/// </summary>
		/// <value>The price at the open of the trading day.</value>
		[DataMember(Name = "open_price", EmitDefaultValue = false)]
		public decimal? OpenPrice { get; set; }

		/// <summary>
		///     The high price for the trading day.
		/// </summary>
		/// <value>The high price for the trading day.</value>
		[DataMember(Name = "high_price", EmitDefaultValue = false)]
		public decimal? HighPrice { get; set; }

		/// <summary>
		///     The low price for the trading day.
		/// </summary>
		/// <value>The low price for the trading day.</value>
		[DataMember(Name = "low_price", EmitDefaultValue = false)]
		public decimal? LowPrice { get; set; }

		/// <summary>
		///     The number of shares exchanged during the trading day on the exchange.
		/// </summary>
		/// <value>The number of shares exchanged during the trading day on the exchange.</value>
		[DataMember(Name = "exchange_volume", EmitDefaultValue = false)]
		public decimal? ExchangeVolume { get; set; }

		/// <summary>
		///     The number of shares exchanged during the trading day for the whole market.
		/// </summary>
		/// <value>The number of shares exchanged during the trading day for the whole market.</value>
		[DataMember(Name = "market_volume", EmitDefaultValue = false)]
		public decimal? MarketVolume { get; set; }

		/// <summary>
		///     The date and time when the data was last updated.
		/// </summary>
		/// <value>The date and time when the data was last updated.</value>
		[DataMember(Name = "updated_on", EmitDefaultValue = false)]
		public DateTime? UpdatedOn { get; set; }

		/// <summary>
		///     The source of the data.
		/// </summary>
		/// <value>The source of the data.</value>
		[DataMember(Name = "source", EmitDefaultValue = false)]
		public string Source { get; set; }

		/// <summary>
		///     Gets or Sets Security
		/// </summary>
		[DataMember(Name = "security", EmitDefaultValue = false)]
		public RealtimeStockPriceSecurity Security { get; set; }

		/// <summary>
		///     Returns true if RealtimeStockPrice instances are equal
		/// </summary>
		/// <param name="input">Instance of RealtimeStockPrice to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(RealtimeStockPrice input)
		{
			if (input == null)
				return false;

			return
				(
					LastPrice == input.LastPrice ||
					LastPrice != null &&
					LastPrice.Equals(input.LastPrice)
				) &&
				(
					LastTime == input.LastTime ||
					LastTime != null &&
					LastTime.Equals(input.LastTime)
				) &&
				(
					LastSize == input.LastSize ||
					LastSize != null &&
					LastSize.Equals(input.LastSize)
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
					OpenPrice == input.OpenPrice ||
					OpenPrice != null &&
					OpenPrice.Equals(input.OpenPrice)
				) &&
				(
					HighPrice == input.HighPrice ||
					HighPrice != null &&
					HighPrice.Equals(input.HighPrice)
				) &&
				(
					LowPrice == input.LowPrice ||
					LowPrice != null &&
					LowPrice.Equals(input.LowPrice)
				) &&
				(
					ExchangeVolume == input.ExchangeVolume ||
					ExchangeVolume != null &&
					ExchangeVolume.Equals(input.ExchangeVolume)
				) &&
				(
					MarketVolume == input.MarketVolume ||
					MarketVolume != null &&
					MarketVolume.Equals(input.MarketVolume)
				) &&
				(
					UpdatedOn == input.UpdatedOn ||
					UpdatedOn != null &&
					UpdatedOn.Equals(input.UpdatedOn)
				) &&
				(
					Source == input.Source ||
					Source != null &&
					Source.Equals(input.Source)
				) &&
				(
					Security == input.Security ||
					Security != null &&
					Security.Equals(input.Security)
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
			sb.Append("class RealtimeStockPrice {\n");
			sb.Append("  LastPrice: ").Append(LastPrice).Append("\n");
			sb.Append("  LastTime: ").Append(LastTime).Append("\n");
			sb.Append("  LastSize: ").Append(LastSize).Append("\n");
			sb.Append("  BidPrice: ").Append(BidPrice).Append("\n");
			sb.Append("  BidSize: ").Append(BidSize).Append("\n");
			sb.Append("  AskPrice: ").Append(AskPrice).Append("\n");
			sb.Append("  AskSize: ").Append(AskSize).Append("\n");
			sb.Append("  OpenPrice: ").Append(OpenPrice).Append("\n");
			sb.Append("  HighPrice: ").Append(HighPrice).Append("\n");
			sb.Append("  LowPrice: ").Append(LowPrice).Append("\n");
			sb.Append("  ExchangeVolume: ").Append(ExchangeVolume).Append("\n");
			sb.Append("  MarketVolume: ").Append(MarketVolume).Append("\n");
			sb.Append("  UpdatedOn: ").Append(UpdatedOn).Append("\n");
			sb.Append("  Source: ").Append(Source).Append("\n");
			sb.Append("  Security: ").Append(Security).Append("\n");
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
			return Equals(input as RealtimeStockPrice);
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
				if (LastPrice != null)
					hashCode = hashCode * 59 + LastPrice.GetHashCode();
				if (LastTime != null)
					hashCode = hashCode * 59 + LastTime.GetHashCode();
				if (LastSize != null)
					hashCode = hashCode * 59 + LastSize.GetHashCode();
				if (BidPrice != null)
					hashCode = hashCode * 59 + BidPrice.GetHashCode();
				if (BidSize != null)
					hashCode = hashCode * 59 + BidSize.GetHashCode();
				if (AskPrice != null)
					hashCode = hashCode * 59 + AskPrice.GetHashCode();
				if (AskSize != null)
					hashCode = hashCode * 59 + AskSize.GetHashCode();
				if (OpenPrice != null)
					hashCode = hashCode * 59 + OpenPrice.GetHashCode();
				if (HighPrice != null)
					hashCode = hashCode * 59 + HighPrice.GetHashCode();
				if (LowPrice != null)
					hashCode = hashCode * 59 + LowPrice.GetHashCode();
				if (ExchangeVolume != null)
					hashCode = hashCode * 59 + ExchangeVolume.GetHashCode();
				if (MarketVolume != null)
					hashCode = hashCode * 59 + MarketVolume.GetHashCode();
				if (UpdatedOn != null)
					hashCode = hashCode * 59 + UpdatedOn.GetHashCode();
				if (Source != null)
					hashCode = hashCode * 59 + Source.GetHashCode();
				if (Security != null)
					hashCode = hashCode * 59 + Security.GetHashCode();
				return hashCode;
			}
		}
	}
}