using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json;

namespace Intrinio.SDK.Model
{
	/// <summary>
	///     Realtime stats such as greeks and implied volatility for a specific options contract.
	/// </summary>
	[DataContract]
	public class OptionStatsRealtime : IEquatable<OptionStatsRealtime>, IValidatableObject
	{
		/// <summary>
		///     Initializes a new instance of the <see cref="OptionStatsRealtime" /> class.
		/// </summary>
		/// <param name="ImpliedVolatility">The implied volatility of the contract calculated using the Black-Scholes Model..</param>
		/// <param name="Delta">
		///     Delta represents the rate of change between the option&#39;s price and a $1 change in the
		///     underlying asset&#39;s price..
		/// </param>
		/// <param name="Gamma">
		///     Gamma represents the rate of change between an option&#39;s delta and the underlying asset&#39;s
		///     price..
		/// </param>
		/// <param name="Theta">
		///     Theta represents the rate of change between the option price and time, or time sensitivity -
		///     sometimes known as an option&#39;s time decay..
		/// </param>
		/// <param name="Vega">
		///     Vega represents the rate of change between an option&#39;s value and the underlying asset&#39;s
		///     implied volatility..
		/// </param>
		public OptionStatsRealtime(decimal? ImpliedVolatility = default, decimal? Delta = default,
			decimal? Gamma = default, decimal? Theta = default, decimal? Vega = default)
		{
			this.ImpliedVolatility = ImpliedVolatility;
			this.Delta = Delta;
			this.Gamma = Gamma;
			this.Theta = Theta;
			this.Vega = Vega;
		}

		/// <summary>
		///     The implied volatility of the contract calculated using the Black-Scholes Model.
		/// </summary>
		/// <value>The implied volatility of the contract calculated using the Black-Scholes Model.</value>
		[DataMember(Name = "implied_volatility", EmitDefaultValue = false)]
		public decimal? ImpliedVolatility { get; set; }

		/// <summary>
		///     Delta represents the rate of change between the option&#39;s price and a $1 change in the underlying asset&#39;s
		///     price.
		/// </summary>
		/// <value>
		///     Delta represents the rate of change between the option&#39;s price and a $1 change in the underlying asset&#39;s
		///     price.
		/// </value>
		[DataMember(Name = "delta", EmitDefaultValue = false)]
		public decimal? Delta { get; set; }

		/// <summary>
		///     Gamma represents the rate of change between an option&#39;s delta and the underlying asset&#39;s price.
		/// </summary>
		/// <value>Gamma represents the rate of change between an option&#39;s delta and the underlying asset&#39;s price.</value>
		[DataMember(Name = "gamma", EmitDefaultValue = false)]
		public decimal? Gamma { get; set; }

		/// <summary>
		///     Theta represents the rate of change between the option price and time, or time sensitivity - sometimes known as an
		///     option&#39;s time decay.
		/// </summary>
		/// <value>
		///     Theta represents the rate of change between the option price and time, or time sensitivity - sometimes known as
		///     an option&#39;s time decay.
		/// </value>
		[DataMember(Name = "theta", EmitDefaultValue = false)]
		public decimal? Theta { get; set; }

		/// <summary>
		///     Vega represents the rate of change between an option&#39;s value and the underlying asset&#39;s implied volatility.
		/// </summary>
		/// <value>
		///     Vega represents the rate of change between an option&#39;s value and the underlying asset&#39;s implied
		///     volatility.
		/// </value>
		[DataMember(Name = "vega", EmitDefaultValue = false)]
		public decimal? Vega { get; set; }

		/// <summary>
		///     Returns true if OptionStatsRealtime instances are equal
		/// </summary>
		/// <param name="input">Instance of OptionStatsRealtime to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(OptionStatsRealtime input)
		{
			if (input == null)
				return false;

			return
				(
					ImpliedVolatility == input.ImpliedVolatility ||
					ImpliedVolatility != null &&
					ImpliedVolatility.Equals(input.ImpliedVolatility)
				) &&
				(
					Delta == input.Delta ||
					Delta != null &&
					Delta.Equals(input.Delta)
				) &&
				(
					Gamma == input.Gamma ||
					Gamma != null &&
					Gamma.Equals(input.Gamma)
				) &&
				(
					Theta == input.Theta ||
					Theta != null &&
					Theta.Equals(input.Theta)
				) &&
				(
					Vega == input.Vega ||
					Vega != null &&
					Vega.Equals(input.Vega)
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
			sb.Append("class OptionStatsRealtime {\n");
			sb.Append("  ImpliedVolatility: ").Append(ImpliedVolatility).Append("\n");
			sb.Append("  Delta: ").Append(Delta).Append("\n");
			sb.Append("  Gamma: ").Append(Gamma).Append("\n");
			sb.Append("  Theta: ").Append(Theta).Append("\n");
			sb.Append("  Vega: ").Append(Vega).Append("\n");
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
			return Equals(input as OptionStatsRealtime);
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
				if (ImpliedVolatility != null)
					hashCode = hashCode * 59 + ImpliedVolatility.GetHashCode();
				if (Delta != null)
					hashCode = hashCode * 59 + Delta.GetHashCode();
				if (Gamma != null)
					hashCode = hashCode * 59 + Gamma.GetHashCode();
				if (Theta != null)
					hashCode = hashCode * 59 + Theta.GetHashCode();
				if (Vega != null)
					hashCode = hashCode * 59 + Vega.GetHashCode();
				return hashCode;
			}
		}
	}
}