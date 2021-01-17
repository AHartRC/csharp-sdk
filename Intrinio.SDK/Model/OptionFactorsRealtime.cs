using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json;

namespace Intrinio.SDK.Model
{
	/// <summary>
	///     Realtime factors for calculating stats such as greeks and implied volatility for a specific options contract.
	/// </summary>
	[DataContract]
	public class OptionFactorsRealtime : IEquatable<OptionFactorsRealtime>, IValidatableObject
	{
		/// <summary>
		///     Initializes a new instance of the <see cref="OptionFactorsRealtime" /> class.
		/// </summary>
		/// <param name="MarketPrice">The market price of the options contract.</param>
		/// <param name="UnderlyingPrice">The market price of the underlying asset.</param>
		/// <param name="StrikePrice">The strike price of the options contract.</param>
		/// <param name="DaysToExpiration">The number of days to expiration.</param>
		/// <param name="RiskFreeInterestRate">The current risk-free interest rate, as measured by the 3-month Treasury Bill rate.</param>
		/// <param name="DividendYield">The divident yield of the underlying asset (if applicable).</param>
		public OptionFactorsRealtime(decimal? MarketPrice = default, decimal? UnderlyingPrice = default,
			decimal? StrikePrice = default, decimal? DaysToExpiration = default,
			decimal? RiskFreeInterestRate = default, decimal? DividendYield = default)
		{
			this.MarketPrice = MarketPrice;
			this.UnderlyingPrice = UnderlyingPrice;
			this.StrikePrice = StrikePrice;
			this.DaysToExpiration = DaysToExpiration;
			this.RiskFreeInterestRate = RiskFreeInterestRate;
			this.DividendYield = DividendYield;
		}

		/// <summary>
		///     The market price of the options contract
		/// </summary>
		/// <value>The market price of the options contract</value>
		[DataMember(Name = "market_price", EmitDefaultValue = false)]
		public decimal? MarketPrice { get; set; }

		/// <summary>
		///     The market price of the underlying asset
		/// </summary>
		/// <value>The market price of the underlying asset</value>
		[DataMember(Name = "underlying_price", EmitDefaultValue = false)]
		public decimal? UnderlyingPrice { get; set; }

		/// <summary>
		///     The strike price of the options contract
		/// </summary>
		/// <value>The strike price of the options contract</value>
		[DataMember(Name = "strike_price", EmitDefaultValue = false)]
		public decimal? StrikePrice { get; set; }

		/// <summary>
		///     The number of days to expiration
		/// </summary>
		/// <value>The number of days to expiration</value>
		[DataMember(Name = "days_to_expiration", EmitDefaultValue = false)]
		public decimal? DaysToExpiration { get; set; }

		/// <summary>
		///     The current risk-free interest rate, as measured by the 3-month Treasury Bill rate
		/// </summary>
		/// <value>The current risk-free interest rate, as measured by the 3-month Treasury Bill rate</value>
		[DataMember(Name = "risk_free_interest_rate", EmitDefaultValue = false)]
		public decimal? RiskFreeInterestRate { get; set; }

		/// <summary>
		///     The divident yield of the underlying asset (if applicable)
		/// </summary>
		/// <value>The divident yield of the underlying asset (if applicable)</value>
		[DataMember(Name = "dividend_yield", EmitDefaultValue = false)]
		public decimal? DividendYield { get; set; }

		/// <summary>
		///     Returns true if OptionFactorsRealtime instances are equal
		/// </summary>
		/// <param name="input">Instance of OptionFactorsRealtime to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(OptionFactorsRealtime input)
		{
			if (input == null)
				return false;

			return
				(
					MarketPrice == input.MarketPrice ||
					MarketPrice != null &&
					MarketPrice.Equals(input.MarketPrice)
				) &&
				(
					UnderlyingPrice == input.UnderlyingPrice ||
					UnderlyingPrice != null &&
					UnderlyingPrice.Equals(input.UnderlyingPrice)
				) &&
				(
					StrikePrice == input.StrikePrice ||
					StrikePrice != null &&
					StrikePrice.Equals(input.StrikePrice)
				) &&
				(
					DaysToExpiration == input.DaysToExpiration ||
					DaysToExpiration != null &&
					DaysToExpiration.Equals(input.DaysToExpiration)
				) &&
				(
					RiskFreeInterestRate == input.RiskFreeInterestRate ||
					RiskFreeInterestRate != null &&
					RiskFreeInterestRate.Equals(input.RiskFreeInterestRate)
				) &&
				(
					DividendYield == input.DividendYield ||
					DividendYield != null &&
					DividendYield.Equals(input.DividendYield)
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
			sb.Append("class OptionFactorsRealtime {\n");
			sb.Append("  MarketPrice: ").Append(MarketPrice).Append("\n");
			sb.Append("  UnderlyingPrice: ").Append(UnderlyingPrice).Append("\n");
			sb.Append("  StrikePrice: ").Append(StrikePrice).Append("\n");
			sb.Append("  DaysToExpiration: ").Append(DaysToExpiration).Append("\n");
			sb.Append("  RiskFreeInterestRate: ").Append(RiskFreeInterestRate).Append("\n");
			sb.Append("  DividendYield: ").Append(DividendYield).Append("\n");
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
			return Equals(input as OptionFactorsRealtime);
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
				if (MarketPrice != null)
					hashCode = hashCode * 59 + MarketPrice.GetHashCode();
				if (UnderlyingPrice != null)
					hashCode = hashCode * 59 + UnderlyingPrice.GetHashCode();
				if (StrikePrice != null)
					hashCode = hashCode * 59 + StrikePrice.GetHashCode();
				if (DaysToExpiration != null)
					hashCode = hashCode * 59 + DaysToExpiration.GetHashCode();
				if (RiskFreeInterestRate != null)
					hashCode = hashCode * 59 + RiskFreeInterestRate.GetHashCode();
				if (DividendYield != null)
					hashCode = hashCode * 59 + DividendYield.GetHashCode();
				return hashCode;
			}
		}
	}
}