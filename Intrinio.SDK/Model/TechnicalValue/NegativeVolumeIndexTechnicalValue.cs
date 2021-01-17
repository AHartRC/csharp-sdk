using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json;

namespace Intrinio.SDK.Model.TechnicalValue
{
	/// <summary>
	///     The date_time and nvi values of a Negative Volume Index technical indicator calculation
	/// </summary>
	[DataContract]
	public class NegativeVolumeIndexTechnicalValue : IEquatable<NegativeVolumeIndexTechnicalValue>, IValidatableObject
	{
		/// <summary>
		///     Initializes a new instance of the <see cref="NegativeVolumeIndexTechnicalValue" /> class.
		/// </summary>
		/// <param name="DateTime">The date_time of the observation.</param>
		/// <param name="Nvi">The Negative Volume Index calculation value.</param>
		public NegativeVolumeIndexTechnicalValue(DateTime? DateTime = default, float? Nvi = default)
		{
			this.DateTime = DateTime;
			this.Nvi = Nvi;
		}

		/// <summary>
		///     The date_time of the observation
		/// </summary>
		/// <value>The date_time of the observation</value>
		[DataMember(Name = "date_time", EmitDefaultValue = false)]
		public DateTime? DateTime { get; set; }

		/// <summary>
		///     The Negative Volume Index calculation value
		/// </summary>
		/// <value>The Negative Volume Index calculation value</value>
		[DataMember(Name = "nvi", EmitDefaultValue = false)]
		public float? Nvi { get; set; }

		/// <summary>
		///     Returns true if NegativeVolumeIndexTechnicalValue instances are equal
		/// </summary>
		/// <param name="input">Instance of NegativeVolumeIndexTechnicalValue to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(NegativeVolumeIndexTechnicalValue input)
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
					Nvi == input.Nvi ||
					Nvi != null &&
					Nvi.Equals(input.Nvi)
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
			sb.Append("class NegativeVolumeIndexTechnicalValue {\n");
			sb.Append("  DateTime: ").Append(DateTime).Append("\n");
			sb.Append("  Nvi: ").Append(Nvi).Append("\n");
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
			return Equals(input as NegativeVolumeIndexTechnicalValue);
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
				if (Nvi != null)
					hashCode = hashCode * 59 + Nvi.GetHashCode();
				return hashCode;
			}
		}
	}
}