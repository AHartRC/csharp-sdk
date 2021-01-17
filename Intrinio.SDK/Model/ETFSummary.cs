using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json;

namespace Intrinio.SDK.Model
{
	/// <summary>
	///     Exchange Traded Fund (ETF) sourced from FirstBridge
	/// </summary>
	[DataContract]
	public class ETFSummary : IEquatable<ETFSummary>, IValidatableObject
	{
		/// <summary>
		///     Initializes a new instance of the <see cref="ETFSummary" /> class.
		/// </summary>
		/// <param name="Id">The Intrinio ID of the ETF.</param>
		/// <param name="Name">The common name of the ETF.</param>
		/// <param name="Ticker">The common ticker symbol for the ETF.</param>
		/// <param name="FigiTicker">The OpenFIGI ticker for the ETF.</param>
		/// <param name="Ric">Reuters Instrument Code (RIC) for the ETF.</param>
		/// <param name="Isin">International Securities Identification Number (ISIN) for the ETF.</param>
		/// <param name="Sedol">Stock Exchange Daily Official List (SEDOL) for the ETF.</param>
		/// <param name="ExchangeMic">
		///     The exchange Market Identifier Code (MIC) from the International Standards Organization
		///     (ISO).
		/// </param>
		public ETFSummary(string Id = default, string Name = default, string Ticker = default,
			string FigiTicker = default, string Ric = default, string Isin = default, string Sedol = default,
			string ExchangeMic = default)
		{
			this.Id = Id;
			this.Name = Name;
			this.Ticker = Ticker;
			this.FigiTicker = FigiTicker;
			this.Ric = Ric;
			this.Isin = Isin;
			this.Sedol = Sedol;
			this.ExchangeMic = ExchangeMic;
		}

		/// <summary>
		///     The Intrinio ID of the ETF
		/// </summary>
		/// <value>The Intrinio ID of the ETF</value>
		[DataMember(Name = "id", EmitDefaultValue = false)]
		public string Id { get; set; }

		/// <summary>
		///     The common name of the ETF
		/// </summary>
		/// <value>The common name of the ETF</value>
		[DataMember(Name = "name", EmitDefaultValue = false)]
		public string Name { get; set; }

		/// <summary>
		///     The common ticker symbol for the ETF
		/// </summary>
		/// <value>The common ticker symbol for the ETF</value>
		[DataMember(Name = "ticker", EmitDefaultValue = false)]
		public string Ticker { get; set; }

		/// <summary>
		///     The OpenFIGI ticker for the ETF
		/// </summary>
		/// <value>The OpenFIGI ticker for the ETF</value>
		[DataMember(Name = "figi_ticker", EmitDefaultValue = false)]
		public string FigiTicker { get; set; }

		/// <summary>
		///     Reuters Instrument Code (RIC) for the ETF
		/// </summary>
		/// <value>Reuters Instrument Code (RIC) for the ETF</value>
		[DataMember(Name = "ric", EmitDefaultValue = false)]
		public string Ric { get; set; }

		/// <summary>
		///     International Securities Identification Number (ISIN) for the ETF
		/// </summary>
		/// <value>International Securities Identification Number (ISIN) for the ETF</value>
		[DataMember(Name = "isin", EmitDefaultValue = false)]
		public string Isin { get; set; }

		/// <summary>
		///     Stock Exchange Daily Official List (SEDOL) for the ETF
		/// </summary>
		/// <value>Stock Exchange Daily Official List (SEDOL) for the ETF</value>
		[DataMember(Name = "sedol", EmitDefaultValue = false)]
		public string Sedol { get; set; }

		/// <summary>
		///     The exchange Market Identifier Code (MIC) from the International Standards Organization (ISO)
		/// </summary>
		/// <value>The exchange Market Identifier Code (MIC) from the International Standards Organization (ISO)</value>
		[DataMember(Name = "exchange_mic", EmitDefaultValue = false)]
		public string ExchangeMic { get; set; }

		/// <summary>
		///     Returns true if ETFSummary instances are equal
		/// </summary>
		/// <param name="input">Instance of ETFSummary to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(ETFSummary input)
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
					FigiTicker == input.FigiTicker ||
					FigiTicker != null &&
					FigiTicker.Equals(input.FigiTicker)
				) &&
				(
					Ric == input.Ric ||
					Ric != null &&
					Ric.Equals(input.Ric)
				) &&
				(
					Isin == input.Isin ||
					Isin != null &&
					Isin.Equals(input.Isin)
				) &&
				(
					Sedol == input.Sedol ||
					Sedol != null &&
					Sedol.Equals(input.Sedol)
				) &&
				(
					ExchangeMic == input.ExchangeMic ||
					ExchangeMic != null &&
					ExchangeMic.Equals(input.ExchangeMic)
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
			sb.Append("class ETFSummary {\n");
			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  Name: ").Append(Name).Append("\n");
			sb.Append("  Ticker: ").Append(Ticker).Append("\n");
			sb.Append("  FigiTicker: ").Append(FigiTicker).Append("\n");
			sb.Append("  Ric: ").Append(Ric).Append("\n");
			sb.Append("  Isin: ").Append(Isin).Append("\n");
			sb.Append("  Sedol: ").Append(Sedol).Append("\n");
			sb.Append("  ExchangeMic: ").Append(ExchangeMic).Append("\n");
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
			return Equals(input as ETFSummary);
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
				if (Name != null)
					hashCode = hashCode * 59 + Name.GetHashCode();
				if (Ticker != null)
					hashCode = hashCode * 59 + Ticker.GetHashCode();
				if (FigiTicker != null)
					hashCode = hashCode * 59 + FigiTicker.GetHashCode();
				if (Ric != null)
					hashCode = hashCode * 59 + Ric.GetHashCode();
				if (Isin != null)
					hashCode = hashCode * 59 + Isin.GetHashCode();
				if (Sedol != null)
					hashCode = hashCode * 59 + Sedol.GetHashCode();
				if (ExchangeMic != null)
					hashCode = hashCode * 59 + ExchangeMic.GetHashCode();
				return hashCode;
			}
		}
	}
}