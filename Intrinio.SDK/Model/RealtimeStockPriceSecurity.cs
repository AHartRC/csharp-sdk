using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json;

namespace Intrinio.SDK.Model
{
	/// <summary>
	///     The Security of the stock price
	/// </summary>
	[DataContract]
	public class RealtimeStockPriceSecurity : IEquatable<RealtimeStockPriceSecurity>, IValidatableObject
	{
		/// <summary>
		///     Initializes a new instance of the <see cref="RealtimeStockPriceSecurity" /> class.
		/// </summary>
		/// <param name="Id">The Intrinio ID for Security.</param>
		/// <param name="Ticker">The common/local ticker of the Security.</param>
		/// <param name="ExchangeTicker">The exchange-level ticker.</param>
		/// <param name="Figi">The OpenFIGI identifier.</param>
		/// <param name="CompositeFigi">The country-composite OpenFIGI identifier.</param>
		public RealtimeStockPriceSecurity(string Id = default, string Ticker = default, string ExchangeTicker = default,
			string Figi = default, string CompositeFigi = default)
		{
			this.Id = Id;
			this.Ticker = Ticker;
			this.ExchangeTicker = ExchangeTicker;
			this.Figi = Figi;
			this.CompositeFigi = CompositeFigi;
		}

		/// <summary>
		///     The Intrinio ID for Security
		/// </summary>
		/// <value>The Intrinio ID for Security</value>
		[DataMember(Name = "id", EmitDefaultValue = false)]
		public string Id { get; set; }

		/// <summary>
		///     The common/local ticker of the Security
		/// </summary>
		/// <value>The common/local ticker of the Security</value>
		[DataMember(Name = "ticker", EmitDefaultValue = false)]
		public string Ticker { get; set; }

		/// <summary>
		///     The exchange-level ticker
		/// </summary>
		/// <value>The exchange-level ticker</value>
		[DataMember(Name = "exchange_ticker", EmitDefaultValue = false)]
		public string ExchangeTicker { get; set; }

		/// <summary>
		///     The OpenFIGI identifier
		/// </summary>
		/// <value>The OpenFIGI identifier</value>
		[DataMember(Name = "figi", EmitDefaultValue = false)]
		public string Figi { get; set; }

		/// <summary>
		///     The country-composite OpenFIGI identifier
		/// </summary>
		/// <value>The country-composite OpenFIGI identifier</value>
		[DataMember(Name = "composite_figi", EmitDefaultValue = false)]
		public string CompositeFigi { get; set; }

		/// <summary>
		///     Returns true if RealtimeStockPriceSecurity instances are equal
		/// </summary>
		/// <param name="input">Instance of RealtimeStockPriceSecurity to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(RealtimeStockPriceSecurity input)
		{
			if (input == null)
				return false;

			return
				(
					Id == input.Id ||
					Id != null &&
					Id.Equals(input.Id)
				) &&
				(
					Ticker == input.Ticker ||
					Ticker != null &&
					Ticker.Equals(input.Ticker)
				) &&
				(
					ExchangeTicker == input.ExchangeTicker ||
					ExchangeTicker != null &&
					ExchangeTicker.Equals(input.ExchangeTicker)
				) &&
				(
					Figi == input.Figi ||
					Figi != null &&
					Figi.Equals(input.Figi)
				) &&
				(
					CompositeFigi == input.CompositeFigi ||
					CompositeFigi != null &&
					CompositeFigi.Equals(input.CompositeFigi)
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
			sb.Append("class RealtimeStockPriceSecurity {\n");
			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  Ticker: ").Append(Ticker).Append("\n");
			sb.Append("  ExchangeTicker: ").Append(ExchangeTicker).Append("\n");
			sb.Append("  Figi: ").Append(Figi).Append("\n");
			sb.Append("  CompositeFigi: ").Append(CompositeFigi).Append("\n");
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
			return Equals(input as RealtimeStockPriceSecurity);
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
				if (Id != null)
					hashCode = hashCode * 59 + Id.GetHashCode();
				if (Ticker != null)
					hashCode = hashCode * 59 + Ticker.GetHashCode();
				if (ExchangeTicker != null)
					hashCode = hashCode * 59 + ExchangeTicker.GetHashCode();
				if (Figi != null)
					hashCode = hashCode * 59 + Figi.GetHashCode();
				if (CompositeFigi != null)
					hashCode = hashCode * 59 + CompositeFigi.GetHashCode();
				return hashCode;
			}
		}
	}
}