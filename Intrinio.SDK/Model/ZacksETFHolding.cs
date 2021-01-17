using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using Intrinio.SDK.Client;

namespace Intrinio.SDK.Model
{
	/// <summary>
	///     Returns detailed information and classifications on exchange traded funds sourced from Zacks.
	/// </summary>
	[DataContract]
	public class ZacksETFHolding : IEquatable<ZacksETFHolding>, IValidatableObject
	{
		/// <summary>
		///     Initializes a new instance of the <see cref="ZacksETFHolding" /> class.
		/// </summary>
		/// <param name="EtfTicker">The ETF&#39;s common ticker.</param>
		/// <param name="EtfName">The ETF&#39;s name.</param>
		/// <param name="HoldingSymbol">The holding&#39;s common ticker.</param>
		/// <param name="HoldingName">The holding&#39;s name.</param>
		/// <param name="DateOfHolding">The date of the holding.</param>
		/// <param name="Shares">The number of shares.</param>
		/// <param name="Weight">The weight of the holding.</param>
		public ZacksETFHolding(string EtfTicker = default, string EtfName = default, string HoldingSymbol = default,
			string HoldingName = default, DateTime? DateOfHolding = default, decimal? Shares = default,
			decimal? Weight = default)
		{
			this.EtfTicker = EtfTicker;
			this.EtfName = EtfName;
			this.HoldingSymbol = HoldingSymbol;
			this.HoldingName = HoldingName;
			this.DateOfHolding = DateOfHolding;
			this.Shares = Shares;
			this.Weight = Weight;
		}

		/// <summary>
		///     The ETF&#39;s common ticker
		/// </summary>
		/// <value>The ETF&#39;s common ticker</value>
		[DataMember(Name = "etf_ticker", EmitDefaultValue = false)]
		public string EtfTicker { get; set; }

		/// <summary>
		///     The ETF&#39;s name
		/// </summary>
		/// <value>The ETF&#39;s name</value>
		[DataMember(Name = "etf_name", EmitDefaultValue = false)]
		public string EtfName { get; set; }

		/// <summary>
		///     The holding&#39;s common ticker
		/// </summary>
		/// <value>The holding&#39;s common ticker</value>
		[DataMember(Name = "holding_symbol", EmitDefaultValue = false)]
		public string HoldingSymbol { get; set; }

		/// <summary>
		///     The holding&#39;s name
		/// </summary>
		/// <value>The holding&#39;s name</value>
		[DataMember(Name = "holding_name", EmitDefaultValue = false)]
		public string HoldingName { get; set; }

		/// <summary>
		///     The date of the holding
		/// </summary>
		/// <value>The date of the holding</value>
		[DataMember(Name = "date_of_holding", EmitDefaultValue = false)]
		
		public DateTime? DateOfHolding { get; set; }

		/// <summary>
		///     The number of shares
		/// </summary>
		/// <value>The number of shares</value>
		[DataMember(Name = "shares", EmitDefaultValue = false)]
		public decimal? Shares { get; set; }

		/// <summary>
		///     The weight of the holding
		/// </summary>
		/// <value>The weight of the holding</value>
		[DataMember(Name = "weight", EmitDefaultValue = false)]
		public decimal? Weight { get; set; }

		/// <summary>
		///     Returns true if ZacksETFHolding instances are equal
		/// </summary>
		/// <param name="input">Instance of ZacksETFHolding to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(ZacksETFHolding input)
		{
			if (input == null)
				return false;

			return
				(
					EtfTicker == input.EtfTicker ||
					EtfTicker != null &&
					EtfTicker.Equals(input.EtfTicker)
				) &&
				(
					EtfName == input.EtfName ||
					EtfName != null &&
					EtfName.Equals(input.EtfName)
				) &&
				(
					HoldingSymbol == input.HoldingSymbol ||
					HoldingSymbol != null &&
					HoldingSymbol.Equals(input.HoldingSymbol)
				) &&
				(
					HoldingName == input.HoldingName ||
					HoldingName != null &&
					HoldingName.Equals(input.HoldingName)
				) &&
				(
					DateOfHolding == input.DateOfHolding ||
					DateOfHolding != null &&
					DateOfHolding.Equals(input.DateOfHolding)
				) &&
				(
					Shares == input.Shares ||
					Shares != null &&
					Shares.Equals(input.Shares)
				) &&
				(
					Weight == input.Weight ||
					Weight != null &&
					Weight.Equals(input.Weight)
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
			sb.Append("class ZacksETFHolding {\n");
			sb.Append("  EtfTicker: ").Append(EtfTicker).Append("\n");
			sb.Append("  EtfName: ").Append(EtfName).Append("\n");
			sb.Append("  HoldingSymbol: ").Append(HoldingSymbol).Append("\n");
			sb.Append("  HoldingName: ").Append(HoldingName).Append("\n");
			sb.Append("  DateOfHolding: ").Append(DateOfHolding).Append("\n");
			sb.Append("  Shares: ").Append(Shares).Append("\n");
			sb.Append("  Weight: ").Append(Weight).Append("\n");
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
			return Equals(input as ZacksETFHolding);
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
				if (EtfTicker != null)
					hashCode = hashCode * 59 + EtfTicker.GetHashCode();
				if (EtfName != null)
					hashCode = hashCode * 59 + EtfName.GetHashCode();
				if (HoldingSymbol != null)
					hashCode = hashCode * 59 + HoldingSymbol.GetHashCode();
				if (HoldingName != null)
					hashCode = hashCode * 59 + HoldingName.GetHashCode();
				if (DateOfHolding != null)
					hashCode = hashCode * 59 + DateOfHolding.GetHashCode();
				if (Shares != null)
					hashCode = hashCode * 59 + Shares.GetHashCode();
				if (Weight != null)
					hashCode = hashCode * 59 + Weight.GetHashCode();
				return hashCode;
			}
		}
	}
}