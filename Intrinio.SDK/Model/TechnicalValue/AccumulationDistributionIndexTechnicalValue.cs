using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json;

namespace Intrinio.SDK.Model.TechnicalValue
{
	/// <summary>
	///     The date_time and adi values of a Accumulation/Distribution Index technical indicator calculation
	/// </summary>
	[DataContract]
	public class AccumulationDistributionIndexTechnicalValue : IEquatable<AccumulationDistributionIndexTechnicalValue>,
		IValidatableObject
	{
		/// <summary>
		///     Initializes a new instance of the <see cref="AccumulationDistributionIndexTechnicalValue" /> class.
		/// </summary>
		/// <param name="DateTime">The date_time of the observation.</param>
		/// <param name="Adi">The Accumulation/Distribution Index calculation value.</param>
		public AccumulationDistributionIndexTechnicalValue(DateTime? DateTime = default, float? Adi = default)
		{
			this.DateTime = DateTime;
			this.Adi = Adi;
		}

		/// <summary>
		///     The date_time of the observation
		/// </summary>
		/// <value>The date_time of the observation</value>
		[DataMember(Name = "date_time", EmitDefaultValue = false)]
		public DateTime? DateTime { get; set; }

		/// <summary>
		///     The Accumulation/Distribution Index calculation value
		/// </summary>
		/// <value>The Accumulation/Distribution Index calculation value</value>
		[DataMember(Name = "adi", EmitDefaultValue = false)]
		public float? Adi { get; set; }

		/// <summary>
		///     Returns true if AccumulationDistributionIndexTechnicalValue instances are equal
		/// </summary>
		/// <param name="input">Instance of AccumulationDistributionIndexTechnicalValue to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(AccumulationDistributionIndexTechnicalValue input)
		{
			if (input == null)
				return false;

			return
				(
					DateTime == input.DateTime ||
					DateTime != null &&
					DateTime.Equals(input.DateTime)
				) &&
				(
					Adi == input.Adi ||
					Adi != null &&
					Adi.Equals(input.Adi)
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
			sb.Append("class AccumulationDistributionIndexTechnicalValue {\n");
			sb.Append("  DateTime: ").Append(DateTime).Append("\n");
			sb.Append("  Adi: ").Append(Adi).Append("\n");
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
			return Equals(input as AccumulationDistributionIndexTechnicalValue);
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
				if (DateTime != null)
					hashCode = hashCode * 59 + DateTime.GetHashCode();
				if (Adi != null)
					hashCode = hashCode * 59 + Adi.GetHashCode();
				return hashCode;
			}
		}
	}
}