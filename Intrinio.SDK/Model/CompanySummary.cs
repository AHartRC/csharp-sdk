using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json;

namespace Intrinio.SDK.Model
{
	/// <summary>
	///     The summary of a company that submits filings to the SEC and has a security traded primarily on a US exchange
	/// </summary>
	[DataContract]
	public class CompanySummary : IEquatable<CompanySummary>, IValidatableObject
	{
		/// <summary>
		///     Initializes a new instance of the <see cref="CompanySummary" /> class.
		/// </summary>
		/// <param name="Id">The Intrinio ID of the company.</param>
		/// <param name="Ticker">The stock market ticker symbol associated with the company&#39;s common stock securities.</param>
		/// <param name="Name">The company&#39;s common name.</param>
		/// <param name="Lei">The Legal Entity Identifier (LEI) assigned to the company.</param>
		/// <param name="Cik">The Central Index Key (CIK) assigned to the company.</param>
		public CompanySummary(string Id = default, string Ticker = default, string Name = default, string Lei = default,
			string Cik = default)
		{
			this.Id = Id;
			this.Ticker = Ticker;
			this.Name = Name;
			this.Lei = Lei;
			this.Cik = Cik;
		}

		/// <summary>
		///     The Intrinio ID of the company
		/// </summary>
		/// <value>The Intrinio ID of the company</value>
		[DataMember(Name = "id", EmitDefaultValue = false)]
		public string Id { get; set; }

		/// <summary>
		///     The stock market ticker symbol associated with the company&#39;s common stock securities
		/// </summary>
		/// <value>The stock market ticker symbol associated with the company&#39;s common stock securities</value>
		[DataMember(Name = "ticker", EmitDefaultValue = false)]
		public string Ticker { get; set; }

		/// <summary>
		///     The company&#39;s common name
		/// </summary>
		/// <value>The company&#39;s common name</value>
		[DataMember(Name = "name", EmitDefaultValue = false)]
		public string Name { get; set; }

		/// <summary>
		///     The Legal Entity Identifier (LEI) assigned to the company
		/// </summary>
		/// <value>The Legal Entity Identifier (LEI) assigned to the company</value>
		[DataMember(Name = "lei", EmitDefaultValue = false)]
		public string Lei { get; set; }

		/// <summary>
		///     The Central Index Key (CIK) assigned to the company
		/// </summary>
		/// <value>The Central Index Key (CIK) assigned to the company</value>
		[DataMember(Name = "cik", EmitDefaultValue = false)]
		public string Cik { get; set; }

		/// <summary>
		///     Returns true if CompanySummary instances are equal
		/// </summary>
		/// <param name="input">Instance of CompanySummary to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(CompanySummary input)
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
					Name == input.Name ||
					Name != null &&
					Name.Equals(input.Name)
				) &&
				(
					Lei == input.Lei ||
					Lei != null &&
					Lei.Equals(input.Lei)
				) &&
				(
					Cik == input.Cik ||
					Cik != null &&
					Cik.Equals(input.Cik)
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
			sb.Append("class CompanySummary {\n");
			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  Ticker: ").Append(Ticker).Append("\n");
			sb.Append("  Name: ").Append(Name).Append("\n");
			sb.Append("  Lei: ").Append(Lei).Append("\n");
			sb.Append("  Cik: ").Append(Cik).Append("\n");
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
			return Equals(input as CompanySummary);
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
				if (Name != null)
					hashCode = hashCode * 59 + Name.GetHashCode();
				if (Lei != null)
					hashCode = hashCode * 59 + Lei.GetHashCode();
				if (Cik != null)
					hashCode = hashCode * 59 + Cik.GetHashCode();
				return hashCode;
			}
		}
	}
}