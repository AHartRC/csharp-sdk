using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using Intrinio.SDK.Client;
using Intrinio.SDK.Enumerator;

namespace Intrinio.SDK.Model
{
	/// <summary>
	///     An option contract gives the buyer of a contract the right to buy or sell a particular asset at a later date at an
	///     agreed upon price.
	/// </summary>
	[DataContract]
	public class OptionRealtime : IEquatable<OptionRealtime>, IValidatableObject
	{

		/// <summary>
		///     Initializes a new instance of the <see cref="OptionRealtime" /> class.
		/// </summary>
		/// <param name="Code">The Intrinio Code for the Option..</param>
		/// <param name="Ticker">The ticker symbol of the Security for the Option..</param>
		/// <param name="Expiration">
		///     The date on which the Option expires. The Option becomes invalid after this date and cannot be
		///     exercised..
		/// </param>
		/// <param name="Strike">
		///     The strike price is the fixed price at which a derivative can be exercised, and refers to the
		///     price of the derivative’s underlying asset.  In a call option, the strike price is the price at which the option
		///     holder can purchase the underlying security.  For a put option, the strike price is the price at which the option
		///     holder can sell the underlying security..
		/// </param>
		/// <param name="Type">The type of Option (put or call)..</param>
		public OptionRealtime(string Code = default, string Ticker = default, DateTime? Expiration = default,
			decimal? Strike = default, OptionRealtimeTypeEnum? Type = default)
		{
			this.Code = Code;
			this.Ticker = Ticker;
			this.Expiration = Expiration;
			this.Strike = Strike;
			this.Type = Type;
		}

		/// <summary>
		///     The type of Option (put or call).
		/// </summary>
		/// <value>The type of Option (put or call).</value>
		[DataMember(Name = "type", EmitDefaultValue = false)]
		public OptionRealtimeTypeEnum? Type { get; set; }

		/// <summary>
		///     The Intrinio Code for the Option.
		/// </summary>
		/// <value>The Intrinio Code for the Option.</value>
		[DataMember(Name = "code", EmitDefaultValue = false)]
		public string Code { get; set; }

		/// <summary>
		///     The ticker symbol of the Security for the Option.
		/// </summary>
		/// <value>The ticker symbol of the Security for the Option.</value>
		[DataMember(Name = "ticker", EmitDefaultValue = false)]
		public string Ticker { get; set; }

		/// <summary>
		///     The date on which the Option expires. The Option becomes invalid after this date and cannot be exercised.
		/// </summary>
		/// <value>The date on which the Option expires. The Option becomes invalid after this date and cannot be exercised.</value>
		[DataMember(Name = "expiration", EmitDefaultValue = false)]
		
		public DateTime? Expiration { get; set; }

		/// <summary>
		///     The strike price is the fixed price at which a derivative can be exercised, and refers to the price of the
		///     derivative’s underlying asset.  In a call option, the strike price is the price at which the option holder can
		///     purchase the underlying security.  For a put option, the strike price is the price at which the option holder can
		///     sell the underlying security.
		/// </summary>
		/// <value>
		///     The strike price is the fixed price at which a derivative can be exercised, and refers to the price of the
		///     derivative’s underlying asset.  In a call option, the strike price is the price at which the option holder can
		///     purchase the underlying security.  For a put option, the strike price is the price at which the option holder can
		///     sell the underlying security.
		/// </value>
		[DataMember(Name = "strike", EmitDefaultValue = false)]
		public decimal? Strike { get; set; }

		/// <summary>
		///     Returns true if OptionRealtime instances are equal
		/// </summary>
		/// <param name="input">Instance of OptionRealtime to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(OptionRealtime input)
		{
			if (input == null)
				return false;

			return
				(
					Code == input.Code ||
					Code != null &&
					Code.Equals(input.Code)
				) &&
				(
					Ticker == input.Ticker ||
					Ticker != null &&
					Ticker.Equals(input.Ticker)
				) &&
				(
					Expiration == input.Expiration ||
					Expiration != null &&
					Expiration.Equals(input.Expiration)
				) &&
				(
					Strike == input.Strike ||
					Strike != null &&
					Strike.Equals(input.Strike)
				) &&
				(
					Type == input.Type ||
					Type != null &&
					Type.Equals(input.Type)
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
			sb.Append("class OptionRealtime {\n");
			sb.Append("  Code: ").Append(Code).Append("\n");
			sb.Append("  Ticker: ").Append(Ticker).Append("\n");
			sb.Append("  Expiration: ").Append(Expiration).Append("\n");
			sb.Append("  Strike: ").Append(Strike).Append("\n");
			sb.Append("  Type: ").Append(Type).Append("\n");
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
			return Equals(input as OptionRealtime);
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
				if (Code != null)
					hashCode = hashCode * 59 + Code.GetHashCode();
				if (Ticker != null)
					hashCode = hashCode * 59 + Ticker.GetHashCode();
				if (Expiration != null)
					hashCode = hashCode * 59 + Expiration.GetHashCode();
				if (Strike != null)
					hashCode = hashCode * 59 + Strike.GetHashCode();
				if (Type != null)
					hashCode = hashCode * 59 + Type.GetHashCode();
				return hashCode;
			}
		}
	}
}