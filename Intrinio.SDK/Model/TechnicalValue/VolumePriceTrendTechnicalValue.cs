using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json;

namespace Intrinio.SDK.Model.TechnicalValue
{
	/// <summary>
	///     The date_time and vpt values of a Volume-price Trend technical indicator calculation
	/// </summary>
	[DataContract]
	public class VolumePriceTrendTechnicalValue : IEquatable<VolumePriceTrendTechnicalValue>, IValidatableObject
	{
		/// <summary>
		///     Initializes a new instance of the <see cref="VolumePriceTrendTechnicalValue" /> class.
		/// </summary>
		/// <param name="DateTime">The date_time of the observation.</param>
		/// <param name="Vpt">The Volume-price Trend calculation value.</param>
		public VolumePriceTrendTechnicalValue(DateTime? DateTime = default, float? Vpt = default)
		{
			this.DateTime = DateTime;
			this.Vpt = Vpt;
		}

		/// <summary>
		///     The date_time of the observation
		/// </summary>
		/// <value>The date_time of the observation</value>
		[DataMember(Name = "date_time", EmitDefaultValue = false)]
		public DateTime? DateTime { get; set; }

		/// <summary>
		///     The Volume-price Trend calculation value
		/// </summary>
		/// <value>The Volume-price Trend calculation value</value>
		[DataMember(Name = "vpt", EmitDefaultValue = false)]
		public float? Vpt { get; set; }

		/// <summary>
		///     Returns true if VolumePriceTrendTechnicalValue instances are equal
		/// </summary>
		/// <param name="input">Instance of VolumePriceTrendTechnicalValue to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(VolumePriceTrendTechnicalValue input)
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
					Vpt == input.Vpt ||
					Vpt != null &&
					Vpt.Equals(input.Vpt)
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
			sb.Append("class VolumePriceTrendTechnicalValue {\n");
			sb.Append("  DateTime: ").Append(DateTime).Append("\n");
			sb.Append("  Vpt: ").Append(Vpt).Append("\n");
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
			return Equals(input as VolumePriceTrendTechnicalValue);
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
				if (Vpt != null)
					hashCode = hashCode * 59 + Vpt.GetHashCode();
				return hashCode;
			}
		}
	}
}