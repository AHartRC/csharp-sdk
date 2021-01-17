using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json;

namespace Intrinio.SDK.Model
{
	/// <summary>
	///     An option price contains price information for a specific options contract.
	/// </summary>
	[DataContract]
	public class OptionPrice : IEquatable<OptionPrice>, IValidatableObject
	{
		/// <summary>
		///     Initializes a new instance of the <see cref="OptionPrice" /> class.
		/// </summary>
		/// <param name="Date">The date of the price, in the format YYYY-MM-DD.</param>
		/// <param name="Close">The closing price of the options contract..</param>
		/// <param name="CloseBid">The closing bid price of the options contract..</param>
		/// <param name="CloseAsk">The closing ask price of the options contract..</param>
		/// <param name="Volume">The cumulative volume of this options contract that traded that day..</param>
		/// <param name="VolumeBid">The cumulative volume of this options contract that traded on the bid price that day..</param>
		/// <param name="VolumeAsk">The cumulative volume of this options contract that traded on the ask price that day..</param>
		/// <param name="Trades">The number of trades executed that for this options contract on that day..</param>
		/// <param name="OpenInterest">The total number of this options contract that are still open..</param>
		/// <param name="OpenInterestChange">
		///     The change in the total number of this options contract that are still open from the
		///     previous day..
		/// </param>
		/// <param name="NextDayOpenInterest">
		///     The total number of this options contract that are still open at the start of the
		///     next day..
		/// </param>
		/// <param name="ImpliedVolatility">
		///     The estimated volatility of the Security&#39;s price. Volatility is a statistical
		///     measure of dispersion of returns for the Security. Standard deviation of a Security&#39;s returns and a market
		///     index is an example of a measurement of volatility. Implied volatility approximates the future value of an option,
		///     and the option&#39;s current value takes this into consideration..
		/// </param>
		/// <param name="ImpliedVolatilityChange">The change in implied volatility for that day..</param>
		/// <param name="Delta">
		///     Delta measures the degree to which an options contract is exposed to shifts in the price of the
		///     underlying Security. Values of delta range from 0.0 to 1.0 for call options and -1.0 to 0.0 for put options. For
		///     example, if a put option has a delta of -0.50, if the price of the underlying Security increases by $1, the price
		///     of the put option will decrease by $0.50..
		/// </param>
		public OptionPrice(string Date = default, decimal? Close = default, decimal? CloseBid = default,
			decimal? CloseAsk = default, int? Volume = default, int? VolumeBid = default, int? VolumeAsk = default,
			int? Trades = default, int? OpenInterest = default, int? OpenInterestChange = default,
			int? NextDayOpenInterest = default, decimal? ImpliedVolatility = default,
			decimal? ImpliedVolatilityChange = default, decimal? Delta = default)
		{
			this.Date = Date;
			this.Close = Close;
			this.CloseBid = CloseBid;
			this.CloseAsk = CloseAsk;
			this.Volume = Volume;
			this.VolumeBid = VolumeBid;
			this.VolumeAsk = VolumeAsk;
			this.Trades = Trades;
			this.OpenInterest = OpenInterest;
			this.OpenInterestChange = OpenInterestChange;
			this.NextDayOpenInterest = NextDayOpenInterest;
			this.ImpliedVolatility = ImpliedVolatility;
			this.ImpliedVolatilityChange = ImpliedVolatilityChange;
			this.Delta = Delta;
		}

		/// <summary>
		///     The date of the price, in the format YYYY-MM-DD
		/// </summary>
		/// <value>The date of the price, in the format YYYY-MM-DD</value>
		[DataMember(Name = "date", EmitDefaultValue = false)]
		public string Date { get; set; }

		/// <summary>
		///     The closing price of the options contract.
		/// </summary>
		/// <value>The closing price of the options contract.</value>
		[DataMember(Name = "close", EmitDefaultValue = false)]
		public decimal? Close { get; set; }

		/// <summary>
		///     The closing bid price of the options contract.
		/// </summary>
		/// <value>The closing bid price of the options contract.</value>
		[DataMember(Name = "close_bid", EmitDefaultValue = false)]
		public decimal? CloseBid { get; set; }

		/// <summary>
		///     The closing ask price of the options contract.
		/// </summary>
		/// <value>The closing ask price of the options contract.</value>
		[DataMember(Name = "close_ask", EmitDefaultValue = false)]
		public decimal? CloseAsk { get; set; }

		/// <summary>
		///     The cumulative volume of this options contract that traded that day.
		/// </summary>
		/// <value>The cumulative volume of this options contract that traded that day.</value>
		[DataMember(Name = "volume", EmitDefaultValue = false)]
		public int? Volume { get; set; }

		/// <summary>
		///     The cumulative volume of this options contract that traded on the bid price that day.
		/// </summary>
		/// <value>The cumulative volume of this options contract that traded on the bid price that day.</value>
		[DataMember(Name = "volume_bid", EmitDefaultValue = false)]
		public int? VolumeBid { get; set; }

		/// <summary>
		///     The cumulative volume of this options contract that traded on the ask price that day.
		/// </summary>
		/// <value>The cumulative volume of this options contract that traded on the ask price that day.</value>
		[DataMember(Name = "volume_ask", EmitDefaultValue = false)]
		public int? VolumeAsk { get; set; }

		/// <summary>
		///     The number of trades executed that for this options contract on that day.
		/// </summary>
		/// <value>The number of trades executed that for this options contract on that day.</value>
		[DataMember(Name = "trades", EmitDefaultValue = false)]
		public int? Trades { get; set; }

		/// <summary>
		///     The total number of this options contract that are still open.
		/// </summary>
		/// <value>The total number of this options contract that are still open.</value>
		[DataMember(Name = "open_interest", EmitDefaultValue = false)]
		public int? OpenInterest { get; set; }

		/// <summary>
		///     The change in the total number of this options contract that are still open from the previous day.
		/// </summary>
		/// <value>The change in the total number of this options contract that are still open from the previous day.</value>
		[DataMember(Name = "open_interest_change", EmitDefaultValue = false)]
		public int? OpenInterestChange { get; set; }

		/// <summary>
		///     The total number of this options contract that are still open at the start of the next day.
		/// </summary>
		/// <value>The total number of this options contract that are still open at the start of the next day.</value>
		[DataMember(Name = "next_day_open_interest", EmitDefaultValue = false)]
		public int? NextDayOpenInterest { get; set; }

		/// <summary>
		///     The estimated volatility of the Security&#39;s price. Volatility is a statistical measure of dispersion of returns
		///     for the Security. Standard deviation of a Security&#39;s returns and a market index is an example of a measurement
		///     of volatility. Implied volatility approximates the future value of an option, and the option&#39;s current value
		///     takes this into consideration.
		/// </summary>
		/// <value>
		///     The estimated volatility of the Security&#39;s price. Volatility is a statistical measure of dispersion of
		///     returns for the Security. Standard deviation of a Security&#39;s returns and a market index is an example of a
		///     measurement of volatility. Implied volatility approximates the future value of an option, and the option&#39;s
		///     current value takes this into consideration.
		/// </value>
		[DataMember(Name = "implied_volatility", EmitDefaultValue = false)]
		public decimal? ImpliedVolatility { get; set; }

		/// <summary>
		///     The change in implied volatility for that day.
		/// </summary>
		/// <value>The change in implied volatility for that day.</value>
		[DataMember(Name = "implied_volatility_change", EmitDefaultValue = false)]
		public decimal? ImpliedVolatilityChange { get; set; }

		/// <summary>
		///     Delta measures the degree to which an options contract is exposed to shifts in the price of the underlying
		///     Security. Values of delta range from 0.0 to 1.0 for call options and -1.0 to 0.0 for put options. For example, if a
		///     put option has a delta of -0.50, if the price of the underlying Security increases by $1, the price of the put
		///     option will decrease by $0.50.
		/// </summary>
		/// <value>
		///     Delta measures the degree to which an options contract is exposed to shifts in the price of the underlying
		///     Security. Values of delta range from 0.0 to 1.0 for call options and -1.0 to 0.0 for put options. For example, if a
		///     put option has a delta of -0.50, if the price of the underlying Security increases by $1, the price of the put
		///     option will decrease by $0.50.
		/// </value>
		[DataMember(Name = "delta", EmitDefaultValue = false)]
		public decimal? Delta { get; set; }

		/// <summary>
		///     Returns true if OptionPrice instances are equal
		/// </summary>
		/// <param name="input">Instance of OptionPrice to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(OptionPrice input)
		{
			if (input == null)
				return false;

			return
				(
					Date == input.Date ||
					Date != null &&
					Date.Equals(input.Date)
				) &&
				(
					Close == input.Close ||
					Close != null &&
					Close.Equals(input.Close)
				) &&
				(
					CloseBid == input.CloseBid ||
					CloseBid != null &&
					CloseBid.Equals(input.CloseBid)
				) &&
				(
					CloseAsk == input.CloseAsk ||
					CloseAsk != null &&
					CloseAsk.Equals(input.CloseAsk)
				) &&
				(
					Volume == input.Volume ||
					Volume != null &&
					Volume.Equals(input.Volume)
				) &&
				(
					VolumeBid == input.VolumeBid ||
					VolumeBid != null &&
					VolumeBid.Equals(input.VolumeBid)
				) &&
				(
					VolumeAsk == input.VolumeAsk ||
					VolumeAsk != null &&
					VolumeAsk.Equals(input.VolumeAsk)
				) &&
				(
					Trades == input.Trades ||
					Trades != null &&
					Trades.Equals(input.Trades)
				) &&
				(
					OpenInterest == input.OpenInterest ||
					OpenInterest != null &&
					OpenInterest.Equals(input.OpenInterest)
				) &&
				(
					OpenInterestChange == input.OpenInterestChange ||
					OpenInterestChange != null &&
					OpenInterestChange.Equals(input.OpenInterestChange)
				) &&
				(
					NextDayOpenInterest == input.NextDayOpenInterest ||
					NextDayOpenInterest != null &&
					NextDayOpenInterest.Equals(input.NextDayOpenInterest)
				) &&
				(
					ImpliedVolatility == input.ImpliedVolatility ||
					ImpliedVolatility != null &&
					ImpliedVolatility.Equals(input.ImpliedVolatility)
				) &&
				(
					ImpliedVolatilityChange == input.ImpliedVolatilityChange ||
					ImpliedVolatilityChange != null &&
					ImpliedVolatilityChange.Equals(input.ImpliedVolatilityChange)
				) &&
				(
					Delta == input.Delta ||
					Delta != null &&
					Delta.Equals(input.Delta)
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
			sb.Append("class OptionPrice {\n");
			sb.Append("  Date: ").Append(Date).Append("\n");
			sb.Append("  Close: ").Append(Close).Append("\n");
			sb.Append("  CloseBid: ").Append(CloseBid).Append("\n");
			sb.Append("  CloseAsk: ").Append(CloseAsk).Append("\n");
			sb.Append("  Volume: ").Append(Volume).Append("\n");
			sb.Append("  VolumeBid: ").Append(VolumeBid).Append("\n");
			sb.Append("  VolumeAsk: ").Append(VolumeAsk).Append("\n");
			sb.Append("  Trades: ").Append(Trades).Append("\n");
			sb.Append("  OpenInterest: ").Append(OpenInterest).Append("\n");
			sb.Append("  OpenInterestChange: ").Append(OpenInterestChange).Append("\n");
			sb.Append("  NextDayOpenInterest: ").Append(NextDayOpenInterest).Append("\n");
			sb.Append("  ImpliedVolatility: ").Append(ImpliedVolatility).Append("\n");
			sb.Append("  ImpliedVolatilityChange: ").Append(ImpliedVolatilityChange).Append("\n");
			sb.Append("  Delta: ").Append(Delta).Append("\n");
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
			return Equals(input as OptionPrice);
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
				if (Date != null)
					hashCode = hashCode * 59 + Date.GetHashCode();
				if (Close != null)
					hashCode = hashCode * 59 + Close.GetHashCode();
				if (CloseBid != null)
					hashCode = hashCode * 59 + CloseBid.GetHashCode();
				if (CloseAsk != null)
					hashCode = hashCode * 59 + CloseAsk.GetHashCode();
				if (Volume != null)
					hashCode = hashCode * 59 + Volume.GetHashCode();
				if (VolumeBid != null)
					hashCode = hashCode * 59 + VolumeBid.GetHashCode();
				if (VolumeAsk != null)
					hashCode = hashCode * 59 + VolumeAsk.GetHashCode();
				if (Trades != null)
					hashCode = hashCode * 59 + Trades.GetHashCode();
				if (OpenInterest != null)
					hashCode = hashCode * 59 + OpenInterest.GetHashCode();
				if (OpenInterestChange != null)
					hashCode = hashCode * 59 + OpenInterestChange.GetHashCode();
				if (NextDayOpenInterest != null)
					hashCode = hashCode * 59 + NextDayOpenInterest.GetHashCode();
				if (ImpliedVolatility != null)
					hashCode = hashCode * 59 + ImpliedVolatility.GetHashCode();
				if (ImpliedVolatilityChange != null)
					hashCode = hashCode * 59 + ImpliedVolatilityChange.GetHashCode();
				if (Delta != null)
					hashCode = hashCode * 59 + Delta.GetHashCode();
				return hashCode;
			}
		}
	}
}