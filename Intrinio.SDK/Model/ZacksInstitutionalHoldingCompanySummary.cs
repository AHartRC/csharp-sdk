using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json;

namespace Intrinio.SDK.Model
{
	/// <summary>
	///     The summary of a company instutionally owned sourced from Zacks.
	/// </summary>
	[DataContract]
	public class ZacksInstitutionalHoldingCompanySummary : IEquatable<ZacksInstitutionalHoldingCompanySummary>,
		IValidatableObject
	{
		/// <summary>
		///     Initializes a new instance of the <see cref="ZacksInstitutionalHoldingCompanySummary" /> class.
		/// </summary>
		/// <param name="Ticker">The Zacks common exchange ticker.</param>
		/// <param name="Name">The company name of the stock listed.</param>
		/// <param name="Exchange">Exhange where the stock is traded whose shares are held by the institution.</param>
		public ZacksInstitutionalHoldingCompanySummary(string Ticker = default, string Name = default,
			string Exchange = default)
		{
			this.Ticker = Ticker;
			this.Name = Name;
			this.Exchange = Exchange;
		}

		/// <summary>
		///     The Zacks common exchange ticker
		/// </summary>
		/// <value>The Zacks common exchange ticker</value>
		[DataMember(Name = "ticker", EmitDefaultValue = false)]
		public string Ticker { get; set; }

		/// <summary>
		///     The company name of the stock listed
		/// </summary>
		/// <value>The company name of the stock listed</value>
		[DataMember(Name = "name", EmitDefaultValue = false)]
		public string Name { get; set; }

		/// <summary>
		///     Exhange where the stock is traded whose shares are held by the institution
		/// </summary>
		/// <value>Exhange where the stock is traded whose shares are held by the institution</value>
		[DataMember(Name = "exchange", EmitDefaultValue = false)]
		public string Exchange { get; set; }

		/// <summary>
		///     Returns true if ZacksInstitutionalHoldingCompanySummary instances are equal
		/// </summary>
		/// <param name="input">Instance of ZacksInstitutionalHoldingCompanySummary to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(ZacksInstitutionalHoldingCompanySummary input)
		{
			if (input == null)
				return false;

			return
				(
					Ticker == input.Ticker ||
					Ticker != null &&
					Ticker.Equals(input.Ticker)
				) &&
				(
					Name == input.Name ||
					Name != null &&
					Name.Equals(input.Name)
				) &&
				(
					Exchange == input.Exchange ||
					Exchange != null &&
					Exchange.Equals(input.Exchange)
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
			sb.Append("class ZacksInstitutionalHoldingCompanySummary {\n");
			sb.Append("  Ticker: ").Append(Ticker).Append("\n");
			sb.Append("  Name: ").Append(Name).Append("\n");
			sb.Append("  Exchange: ").Append(Exchange).Append("\n");
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
			return Equals(input as ZacksInstitutionalHoldingCompanySummary);
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
				if (Ticker != null)
					hashCode = hashCode * 59 + Ticker.GetHashCode();
				if (Name != null)
					hashCode = hashCode * 59 + Name.GetHashCode();
				if (Exchange != null)
					hashCode = hashCode * 59 + Exchange.GetHashCode();
				return hashCode;
			}
		}
	}
}