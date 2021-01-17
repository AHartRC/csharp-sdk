using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json;

namespace Intrinio.SDK.Model
{
	/// <summary>
	///     The summary of a institutional owner
	/// </summary>
	[DataContract]
	public class ZacksInstitutionalHoldingOwnerSummary : IEquatable<ZacksInstitutionalHoldingOwnerSummary>,
		IValidatableObject
	{
		/// <summary>
		///     Initializes a new instance of the <see cref="ZacksInstitutionalHoldingOwnerSummary" /> class.
		/// </summary>
		/// <param name="Name">The owner&#39;s name.</param>
		/// <param name="Cik">
		///     The Central Index Key (CIK) assigned to the company by the SEC as a unique identifier, used in SEC
		///     filings.
		/// </param>
		public ZacksInstitutionalHoldingOwnerSummary(string Name = default, string Cik = default)
		{
			this.Name = Name;
			this.Cik = Cik;
		}

		/// <summary>
		///     The owner&#39;s name
		/// </summary>
		/// <value>The owner&#39;s name</value>
		[DataMember(Name = "name", EmitDefaultValue = false)]
		public string Name { get; set; }

		/// <summary>
		///     The Central Index Key (CIK) assigned to the company by the SEC as a unique identifier, used in SEC filings
		/// </summary>
		/// <value>The Central Index Key (CIK) assigned to the company by the SEC as a unique identifier, used in SEC filings</value>
		[DataMember(Name = "cik", EmitDefaultValue = false)]
		public string Cik { get; set; }

		/// <summary>
		///     Returns true if ZacksInstitutionalHoldingOwnerSummary instances are equal
		/// </summary>
		/// <param name="input">Instance of ZacksInstitutionalHoldingOwnerSummary to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(ZacksInstitutionalHoldingOwnerSummary input)
		{
			if (input == null)
				return false;

			return
				(
					Name == input.Name ||
					Name != null &&
					Name.Equals(input.Name)
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
			sb.Append("class ZacksInstitutionalHoldingOwnerSummary {\n");
			sb.Append("  Name: ").Append(Name).Append("\n");
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
			return Equals(input as ZacksInstitutionalHoldingOwnerSummary);
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
				if (Name != null)
					hashCode = hashCode * 59 + Name.GetHashCode();
				if (Cik != null)
					hashCode = hashCode * 59 + Cik.GetHashCode();
				return hashCode;
			}
		}
	}
}