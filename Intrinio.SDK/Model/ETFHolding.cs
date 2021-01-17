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
	///     The Exchange Traded Fund (ETF) holding data
	/// </summary>
	[DataContract]
	public class ETFHolding : IEquatable<ETFHolding>, IValidatableObject
	{
		/// <summary>
		///     Initializes a new instance of the <see cref="ETFHolding" /> class.
		/// </summary>
		/// <param name="AsOfDate">The date on which the holding and their weights correspond.</param>
		/// <param name="Name">The common name for the holding.</param>
		/// <param name="Ticker">The common exchange ticker for the holding.</param>
		/// <param name="Type">
		///     The type of instrument for this holding.  Examples (Bond &#x3D; &#39;BOND&#39;, Equity &#x3D; &#39;
		///     EQUI&#39;, Options &#x3D; &#39;OPTN&#39;).
		/// </param>
		/// <param name="CompositeFigi">The OpenFIGI ticker for the holding.</param>
		/// <param name="Isin">International Securities Identification Number (ISIN) for the holding.</param>
		/// <param name="Ric">Reuters Instrument Code (RIC) for the holding.</param>
		/// <param name="Sedol">Stock Exchange Daily Official List (SEDOL) for the holding.</param>
		/// <param name="Face">Face value of the debt security, if available.</param>
		/// <param name="Coupon">Coupon rate of the debt security, if available.</param>
		/// <param name="MarketValueHeld">The market value of this holding in the ETF as of the &#x60;as_of_date&#x60;.</param>
		/// <param name="NotionalValue">
		///     Notional value of derivatives contracts held in the Exchange Traded Fund (ETF) or Exchange
		///     Traded Note (ETN).
		/// </param>
		/// <param name="Maturity">Maturity date for the debt security, if available.</param>
		/// <param name="QuantityHeld">Number of units of the security held if available.</param>
		/// <param name="Weighting">Fraction of the funds market value held.</param>
		/// <param name="QuantityUnits">
		///     The unit of the &#x60;quanity_held&#x60; field. Examples (&#39;oz&#39;, &#39;shares&#39;,
		///     &#39;contracts&#39;).
		/// </param>
		/// <param name="QuantityPerShare">
		///     Number of units of the security held per units of shares outstanding of the Exchange
		///     Traded Fund (ETF), if available.
		/// </param>
		/// <param name="ContractExpiryDate">
		///     Expiry date for the futures contract held in the Exchange Traded Fund (ETF) or
		///     Exchange Traded Note (ETN).
		/// </param>
		public ETFHolding(DateTime? AsOfDate = default, string Name = default, string Ticker = default,
			string Type = default, string CompositeFigi = default, string Isin = default, string Ric = default,
			string Sedol = default, decimal? Face = default, decimal? Coupon = default,
			decimal? MarketValueHeld = default, decimal? NotionalValue = default, DateTime? Maturity = default,
			decimal? QuantityHeld = default, decimal? Weighting = default, decimal? QuantityUnits = default,
			decimal? QuantityPerShare = default, DateTime? ContractExpiryDate = default)
		{
			this.AsOfDate = AsOfDate;
			this.Name = Name;
			this.Ticker = Ticker;
			this.Type = Type;
			this.CompositeFigi = CompositeFigi;
			this.Isin = Isin;
			this.Ric = Ric;
			this.Sedol = Sedol;
			this.Face = Face;
			this.Coupon = Coupon;
			this.MarketValueHeld = MarketValueHeld;
			this.NotionalValue = NotionalValue;
			this.Maturity = Maturity;
			this.QuantityHeld = QuantityHeld;
			this.Weighting = Weighting;
			this.QuantityUnits = QuantityUnits;
			this.QuantityPerShare = QuantityPerShare;
			this.ContractExpiryDate = ContractExpiryDate;
		}

		/// <summary>
		///     The date on which the holding and their weights correspond
		/// </summary>
		/// <value>The date on which the holding and their weights correspond</value>
		[DataMember(Name = "as_of_date", EmitDefaultValue = false)]
		
		public DateTime? AsOfDate { get; set; }

		/// <summary>
		///     The common name for the holding
		/// </summary>
		/// <value>The common name for the holding</value>
		[DataMember(Name = "name", EmitDefaultValue = false)]
		public string Name { get; set; }

		/// <summary>
		///     The common exchange ticker for the holding
		/// </summary>
		/// <value>The common exchange ticker for the holding</value>
		[DataMember(Name = "ticker", EmitDefaultValue = false)]
		public string Ticker { get; set; }

		/// <summary>
		///     The type of instrument for this holding.  Examples (Bond &#x3D; &#39;BOND&#39;, Equity &#x3D; &#39;EQUI&#39;,
		///     Options &#x3D; &#39;OPTN&#39;)
		/// </summary>
		/// <value>
		///     The type of instrument for this holding.  Examples (Bond &#x3D; &#39;BOND&#39;, Equity &#x3D; &#39;EQUI&#39;,
		///     Options &#x3D; &#39;OPTN&#39;)
		/// </value>
		[DataMember(Name = "type", EmitDefaultValue = false)]
		public string Type { get; set; }

		/// <summary>
		///     The OpenFIGI ticker for the holding
		/// </summary>
		/// <value>The OpenFIGI ticker for the holding</value>
		[DataMember(Name = "composite_figi", EmitDefaultValue = false)]
		public string CompositeFigi { get; set; }

		/// <summary>
		///     International Securities Identification Number (ISIN) for the holding
		/// </summary>
		/// <value>International Securities Identification Number (ISIN) for the holding</value>
		[DataMember(Name = "isin", EmitDefaultValue = false)]
		public string Isin { get; set; }

		/// <summary>
		///     Reuters Instrument Code (RIC) for the holding
		/// </summary>
		/// <value>Reuters Instrument Code (RIC) for the holding</value>
		[DataMember(Name = "ric", EmitDefaultValue = false)]
		public string Ric { get; set; }

		/// <summary>
		///     Stock Exchange Daily Official List (SEDOL) for the holding
		/// </summary>
		/// <value>Stock Exchange Daily Official List (SEDOL) for the holding</value>
		[DataMember(Name = "sedol", EmitDefaultValue = false)]
		public string Sedol { get; set; }

		/// <summary>
		///     Face value of the debt security, if available
		/// </summary>
		/// <value>Face value of the debt security, if available</value>
		[DataMember(Name = "face", EmitDefaultValue = false)]
		public decimal? Face { get; set; }

		/// <summary>
		///     Coupon rate of the debt security, if available
		/// </summary>
		/// <value>Coupon rate of the debt security, if available</value>
		[DataMember(Name = "coupon", EmitDefaultValue = false)]
		public decimal? Coupon { get; set; }

		/// <summary>
		///     The market value of this holding in the ETF as of the &#x60;as_of_date&#x60;
		/// </summary>
		/// <value>The market value of this holding in the ETF as of the &#x60;as_of_date&#x60;</value>
		[DataMember(Name = "market_value_held", EmitDefaultValue = false)]
		public decimal? MarketValueHeld { get; set; }

		/// <summary>
		///     Notional value of derivatives contracts held in the Exchange Traded Fund (ETF) or Exchange Traded Note (ETN)
		/// </summary>
		/// <value>Notional value of derivatives contracts held in the Exchange Traded Fund (ETF) or Exchange Traded Note (ETN)</value>
		[DataMember(Name = "notional_value", EmitDefaultValue = false)]
		public decimal? NotionalValue { get; set; }

		/// <summary>
		///     Maturity date for the debt security, if available
		/// </summary>
		/// <value>Maturity date for the debt security, if available</value>
		[DataMember(Name = "maturity", EmitDefaultValue = false)]
		
		public DateTime? Maturity { get; set; }

		/// <summary>
		///     Number of units of the security held if available
		/// </summary>
		/// <value>Number of units of the security held if available</value>
		[DataMember(Name = "quantity_held", EmitDefaultValue = false)]
		public decimal? QuantityHeld { get; set; }

		/// <summary>
		///     Fraction of the funds market value held
		/// </summary>
		/// <value>Fraction of the funds market value held</value>
		[DataMember(Name = "weighting", EmitDefaultValue = false)]
		public decimal? Weighting { get; set; }

		/// <summary>
		///     The unit of the &#x60;quanity_held&#x60; field. Examples (&#39;oz&#39;, &#39;shares&#39;, &#39;contracts&#39;)
		/// </summary>
		/// <value>The unit of the &#x60;quanity_held&#x60; field. Examples (&#39;oz&#39;, &#39;shares&#39;, &#39;contracts&#39;)</value>
		[DataMember(Name = "quantity_units", EmitDefaultValue = false)]
		public decimal? QuantityUnits { get; set; }

		/// <summary>
		///     Number of units of the security held per units of shares outstanding of the Exchange Traded Fund (ETF), if
		///     available
		/// </summary>
		/// <value>
		///     Number of units of the security held per units of shares outstanding of the Exchange Traded Fund (ETF), if
		///     available
		/// </value>
		[DataMember(Name = "quantity_per_share", EmitDefaultValue = false)]
		public decimal? QuantityPerShare { get; set; }

		/// <summary>
		///     Expiry date for the futures contract held in the Exchange Traded Fund (ETF) or Exchange Traded Note (ETN)
		/// </summary>
		/// <value>Expiry date for the futures contract held in the Exchange Traded Fund (ETF) or Exchange Traded Note (ETN)</value>
		[DataMember(Name = "contract_expiry_date", EmitDefaultValue = false)]
		
		public DateTime? ContractExpiryDate { get; set; }

		/// <summary>
		///     Returns true if ETFHolding instances are equal
		/// </summary>
		/// <param name="input">Instance of ETFHolding to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(ETFHolding input)
		{
			if (input == null)
				return false;

			return
				(
					AsOfDate == input.AsOfDate ||
					AsOfDate != null &&
					AsOfDate.Equals(input.AsOfDate)
				) &&
				(
					Name == input.Name ||
					Name != null &&
					Name.Equals(input.Name)
				) &&
				(
					Ticker == input.Ticker ||
					Ticker != null &&
					Ticker.Equals(input.Ticker)
				) &&
				(
					Type == input.Type ||
					Type != null &&
					Type.Equals(input.Type)
				) &&
				(
					CompositeFigi == input.CompositeFigi ||
					CompositeFigi != null &&
					CompositeFigi.Equals(input.CompositeFigi)
				) &&
				(
					Isin == input.Isin ||
					Isin != null &&
					Isin.Equals(input.Isin)
				) &&
				(
					Ric == input.Ric ||
					Ric != null &&
					Ric.Equals(input.Ric)
				) &&
				(
					Sedol == input.Sedol ||
					Sedol != null &&
					Sedol.Equals(input.Sedol)
				) &&
				(
					Face == input.Face ||
					Face != null &&
					Face.Equals(input.Face)
				) &&
				(
					Coupon == input.Coupon ||
					Coupon != null &&
					Coupon.Equals(input.Coupon)
				) &&
				(
					MarketValueHeld == input.MarketValueHeld ||
					MarketValueHeld != null &&
					MarketValueHeld.Equals(input.MarketValueHeld)
				) &&
				(
					NotionalValue == input.NotionalValue ||
					NotionalValue != null &&
					NotionalValue.Equals(input.NotionalValue)
				) &&
				(
					Maturity == input.Maturity ||
					Maturity != null &&
					Maturity.Equals(input.Maturity)
				) &&
				(
					QuantityHeld == input.QuantityHeld ||
					QuantityHeld != null &&
					QuantityHeld.Equals(input.QuantityHeld)
				) &&
				(
					Weighting == input.Weighting ||
					Weighting != null &&
					Weighting.Equals(input.Weighting)
				) &&
				(
					QuantityUnits == input.QuantityUnits ||
					QuantityUnits != null &&
					QuantityUnits.Equals(input.QuantityUnits)
				) &&
				(
					QuantityPerShare == input.QuantityPerShare ||
					QuantityPerShare != null &&
					QuantityPerShare.Equals(input.QuantityPerShare)
				) &&
				(
					ContractExpiryDate == input.ContractExpiryDate ||
					ContractExpiryDate != null &&
					ContractExpiryDate.Equals(input.ContractExpiryDate)
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
			sb.Append("class ETFHolding {\n");
			sb.Append("  AsOfDate: ").Append(AsOfDate).Append("\n");
			sb.Append("  Name: ").Append(Name).Append("\n");
			sb.Append("  Ticker: ").Append(Ticker).Append("\n");
			sb.Append("  Type: ").Append(Type).Append("\n");
			sb.Append("  CompositeFigi: ").Append(CompositeFigi).Append("\n");
			sb.Append("  Isin: ").Append(Isin).Append("\n");
			sb.Append("  Ric: ").Append(Ric).Append("\n");
			sb.Append("  Sedol: ").Append(Sedol).Append("\n");
			sb.Append("  Face: ").Append(Face).Append("\n");
			sb.Append("  Coupon: ").Append(Coupon).Append("\n");
			sb.Append("  MarketValueHeld: ").Append(MarketValueHeld).Append("\n");
			sb.Append("  NotionalValue: ").Append(NotionalValue).Append("\n");
			sb.Append("  Maturity: ").Append(Maturity).Append("\n");
			sb.Append("  QuantityHeld: ").Append(QuantityHeld).Append("\n");
			sb.Append("  Weighting: ").Append(Weighting).Append("\n");
			sb.Append("  QuantityUnits: ").Append(QuantityUnits).Append("\n");
			sb.Append("  QuantityPerShare: ").Append(QuantityPerShare).Append("\n");
			sb.Append("  ContractExpiryDate: ").Append(ContractExpiryDate).Append("\n");
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
			return Equals(input as ETFHolding);
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
				if (AsOfDate != null)
					hashCode = hashCode * 59 + AsOfDate.GetHashCode();
				if (Name != null)
					hashCode = hashCode * 59 + Name.GetHashCode();
				if (Ticker != null)
					hashCode = hashCode * 59 + Ticker.GetHashCode();
				if (Type != null)
					hashCode = hashCode * 59 + Type.GetHashCode();
				if (CompositeFigi != null)
					hashCode = hashCode * 59 + CompositeFigi.GetHashCode();
				if (Isin != null)
					hashCode = hashCode * 59 + Isin.GetHashCode();
				if (Ric != null)
					hashCode = hashCode * 59 + Ric.GetHashCode();
				if (Sedol != null)
					hashCode = hashCode * 59 + Sedol.GetHashCode();
				if (Face != null)
					hashCode = hashCode * 59 + Face.GetHashCode();
				if (Coupon != null)
					hashCode = hashCode * 59 + Coupon.GetHashCode();
				if (MarketValueHeld != null)
					hashCode = hashCode * 59 + MarketValueHeld.GetHashCode();
				if (NotionalValue != null)
					hashCode = hashCode * 59 + NotionalValue.GetHashCode();
				if (Maturity != null)
					hashCode = hashCode * 59 + Maturity.GetHashCode();
				if (QuantityHeld != null)
					hashCode = hashCode * 59 + QuantityHeld.GetHashCode();
				if (Weighting != null)
					hashCode = hashCode * 59 + Weighting.GetHashCode();
				if (QuantityUnits != null)
					hashCode = hashCode * 59 + QuantityUnits.GetHashCode();
				if (QuantityPerShare != null)
					hashCode = hashCode * 59 + QuantityPerShare.GetHashCode();
				if (ContractExpiryDate != null)
					hashCode = hashCode * 59 + ContractExpiryDate.GetHashCode();
				return hashCode;
			}
		}
	}
}