using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json;

namespace Intrinio.SDK.Model
{
	/// <summary>
	///     The summary of a financial instrument representing shares of ownership in a publicly-traded company
	/// </summary>
	[DataContract]
	public class SecuritySummary : IEquatable<SecuritySummary>, IValidatableObject
	{
		/// <summary>
		///     Initializes a new instance of the <see cref="SecuritySummary" /> class.
		/// </summary>
		/// <param name="Id">The Intrinio ID for Security.</param>
		/// <param name="CompanyId">The Intrinio ID for the Company for which the Security is issued.</param>
		/// <param name="Name">The name of the Security.</param>
		/// <param name="Code">
		///     A 2-3 digit code classifying the Security (&lt;a href&#x3D;\&quot;
		///     https://docs.intrinio.com/documentation/security_codes\&quot; target&#x3D;\&quot;_blank\&quot;&gt;reference&lt;/a
		///     &gt;).
		/// </param>
		/// <param name="Currency">The currency in which the Security is traded on the exchange.</param>
		/// <param name="Ticker">The common/local ticker of the Security.</param>
		/// <param name="CompositeTicker">The country-composite ticker of the Security.</param>
		/// <param name="Figi">The OpenFIGI identifier.</param>
		/// <param name="CompositeFigi">The country-composite OpenFIGI identifier.</param>
		/// <param name="ShareClassFigi">The global-composite OpenFIGI identifier.</param>
		/// <param name="PrimaryListing">
		///     If true, the Security is the primary issue for the company, otherwise it is a secondary
		///     issue on a secondary stock exchange.
		/// </param>
		public SecuritySummary(string Id = default, string CompanyId = default, string Name = default,
			string Code = default, string Currency = default, string Ticker = default, string CompositeTicker = default,
			string Figi = default, string CompositeFigi = default, string ShareClassFigi = default,
			bool? PrimaryListing = default)
		{
			this.Id = Id;
			this.CompanyId = CompanyId;
			this.Name = Name;
			this.Code = Code;
			this.Currency = Currency;
			this.Ticker = Ticker;
			this.CompositeTicker = CompositeTicker;
			this.Figi = Figi;
			this.CompositeFigi = CompositeFigi;
			this.ShareClassFigi = ShareClassFigi;
			this.PrimaryListing = PrimaryListing;
		}

		/// <summary>
		///     The Intrinio ID for Security
		/// </summary>
		/// <value>The Intrinio ID for Security</value>
		[DataMember(Name = "id", EmitDefaultValue = false)]
		public string Id { get; set; }

		/// <summary>
		///     The Intrinio ID for the Company for which the Security is issued
		/// </summary>
		/// <value>The Intrinio ID for the Company for which the Security is issued</value>
		[DataMember(Name = "company_id", EmitDefaultValue = false)]
		public string CompanyId { get; set; }

		/// <summary>
		///     The name of the Security
		/// </summary>
		/// <value>The name of the Security</value>
		[DataMember(Name = "name", EmitDefaultValue = false)]
		public string Name { get; set; }

		/// <summary>
		///     A 2-3 digit code classifying the Security (&lt;a href&#x3D;\&quot;
		///     https://docs.intrinio.com/documentation/security_codes\&quot; target&#x3D;\&quot;_blank\&quot;&gt;reference&lt;/a
		///     &gt;)
		/// </summary>
		/// <value>
		///     A 2-3 digit code classifying the Security (&lt;a href&#x3D;\&quot;
		///     https://docs.intrinio.com/documentation/security_codes\&quot; target&#x3D;\&quot;_blank\&quot;&gt;reference&lt;/a
		///     &gt;)
		/// </value>
		[DataMember(Name = "code", EmitDefaultValue = false)]
		public string Code { get; set; }

		/// <summary>
		///     The currency in which the Security is traded on the exchange
		/// </summary>
		/// <value>The currency in which the Security is traded on the exchange</value>
		[DataMember(Name = "currency", EmitDefaultValue = false)]
		public string Currency { get; set; }

		/// <summary>
		///     The common/local ticker of the Security
		/// </summary>
		/// <value>The common/local ticker of the Security</value>
		[DataMember(Name = "ticker", EmitDefaultValue = false)]
		public string Ticker { get; set; }

		/// <summary>
		///     The country-composite ticker of the Security
		/// </summary>
		/// <value>The country-composite ticker of the Security</value>
		[DataMember(Name = "composite_ticker", EmitDefaultValue = false)]
		public string CompositeTicker { get; set; }

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
		///     The global-composite OpenFIGI identifier
		/// </summary>
		/// <value>The global-composite OpenFIGI identifier</value>
		[DataMember(Name = "share_class_figi", EmitDefaultValue = false)]
		public string ShareClassFigi { get; set; }

		/// <summary>
		///     If true, the Security is the primary issue for the company, otherwise it is a secondary issue on a secondary stock
		///     exchange
		/// </summary>
		/// <value>
		///     If true, the Security is the primary issue for the company, otherwise it is a secondary issue on a secondary
		///     stock exchange
		/// </value>
		[DataMember(Name = "primary_listing", EmitDefaultValue = false)]
		public bool? PrimaryListing { get; set; }

		/// <summary>
		///     Returns true if SecuritySummary instances are equal
		/// </summary>
		/// <param name="input">Instance of SecuritySummary to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(SecuritySummary input)
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
					CompanyId == input.CompanyId ||
					CompanyId != null &&
					CompanyId.Equals(input.CompanyId)
				) &&
				(
					Name == input.Name ||
					Name != null &&
					Name.Equals(input.Name)
				) &&
				(
					Code == input.Code ||
					Code != null &&
					Code.Equals(input.Code)
				) &&
				(
					Currency == input.Currency ||
					Currency != null &&
					Currency.Equals(input.Currency)
				) &&
				(
					Ticker == input.Ticker ||
					Ticker != null &&
					Ticker.Equals(input.Ticker)
				) &&
				(
					CompositeTicker == input.CompositeTicker ||
					CompositeTicker != null &&
					CompositeTicker.Equals(input.CompositeTicker)
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
				) &&
				(
					ShareClassFigi == input.ShareClassFigi ||
					ShareClassFigi != null &&
					ShareClassFigi.Equals(input.ShareClassFigi)
				) &&
				(
					PrimaryListing == input.PrimaryListing ||
					PrimaryListing != null &&
					PrimaryListing.Equals(input.PrimaryListing)
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
			sb.Append("class SecuritySummary {\n");
			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  CompanyId: ").Append(CompanyId).Append("\n");
			sb.Append("  Name: ").Append(Name).Append("\n");
			sb.Append("  Code: ").Append(Code).Append("\n");
			sb.Append("  Currency: ").Append(Currency).Append("\n");
			sb.Append("  Ticker: ").Append(Ticker).Append("\n");
			sb.Append("  CompositeTicker: ").Append(CompositeTicker).Append("\n");
			sb.Append("  Figi: ").Append(Figi).Append("\n");
			sb.Append("  CompositeFigi: ").Append(CompositeFigi).Append("\n");
			sb.Append("  ShareClassFigi: ").Append(ShareClassFigi).Append("\n");
			sb.Append("  PrimaryListing: ").Append(PrimaryListing).Append("\n");
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
			return Equals(input as SecuritySummary);
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
				if (CompanyId != null)
					hashCode = hashCode * 59 + CompanyId.GetHashCode();
				if (Name != null)
					hashCode = hashCode * 59 + Name.GetHashCode();
				if (Code != null)
					hashCode = hashCode * 59 + Code.GetHashCode();
				if (Currency != null)
					hashCode = hashCode * 59 + Currency.GetHashCode();
				if (Ticker != null)
					hashCode = hashCode * 59 + Ticker.GetHashCode();
				if (CompositeTicker != null)
					hashCode = hashCode * 59 + CompositeTicker.GetHashCode();
				if (Figi != null)
					hashCode = hashCode * 59 + Figi.GetHashCode();
				if (CompositeFigi != null)
					hashCode = hashCode * 59 + CompositeFigi.GetHashCode();
				if (ShareClassFigi != null)
					hashCode = hashCode * 59 + ShareClassFigi.GetHashCode();
				if (PrimaryListing != null)
					hashCode = hashCode * 59 + PrimaryListing.GetHashCode();
				return hashCode;
			}
		}
	}
}