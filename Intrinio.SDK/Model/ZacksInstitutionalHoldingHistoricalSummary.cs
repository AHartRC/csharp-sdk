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
	///     Returns number of shares held in previous quarters
	/// </summary>
	[DataContract]
	public class ZacksInstitutionalHoldingHistoricalSummary : IEquatable<ZacksInstitutionalHoldingHistoricalSummary>,
		IValidatableObject
	{
		/// <summary>
		///     Initializes a new instance of the <see cref="ZacksInstitutionalHoldingHistoricalSummary" /> class.
		/// </summary>
		/// <param name="AsOfDate">The date of the institutional holding.</param>
		/// <param name="SharesHeld">The number of shares held.</param>
		public ZacksInstitutionalHoldingHistoricalSummary(DateTime? AsOfDate = default, decimal? SharesHeld = default)
		{
			this.AsOfDate = AsOfDate;
			this.SharesHeld = SharesHeld;
		}

		/// <summary>
		///     The date of the institutional holding
		/// </summary>
		/// <value>The date of the institutional holding</value>
		[DataMember(Name = "as_of_date", EmitDefaultValue = false)]
		
		public DateTime? AsOfDate { get; set; }

		/// <summary>
		///     The number of shares held
		/// </summary>
		/// <value>The number of shares held</value>
		[DataMember(Name = "shares_held", EmitDefaultValue = false)]
		public decimal? SharesHeld { get; set; }

		/// <summary>
		///     Returns true if ZacksInstitutionalHoldingHistoricalSummary instances are equal
		/// </summary>
		/// <param name="input">Instance of ZacksInstitutionalHoldingHistoricalSummary to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(ZacksInstitutionalHoldingHistoricalSummary input)
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
					SharesHeld == input.SharesHeld ||
					SharesHeld != null &&
					SharesHeld.Equals(input.SharesHeld)
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
			sb.Append("class ZacksInstitutionalHoldingHistoricalSummary {\n");
			sb.Append("  AsOfDate: ").Append(AsOfDate).Append("\n");
			sb.Append("  SharesHeld: ").Append(SharesHeld).Append("\n");
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
			return Equals(input as ZacksInstitutionalHoldingHistoricalSummary);
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
				if (SharesHeld != null)
					hashCode = hashCode * 59 + SharesHeld.GetHashCode();
				return hashCode;
			}
		}
	}
}