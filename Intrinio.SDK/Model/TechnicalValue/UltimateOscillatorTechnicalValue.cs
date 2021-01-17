using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json;

namespace Intrinio.SDK.Model.TechnicalValue
{
	/// <summary>
	///     The date_time and uo values of a Ultimate Oscillator technical indicator calculation
	/// </summary>
	[DataContract]
	public class UltimateOscillatorTechnicalValue : IEquatable<UltimateOscillatorTechnicalValue>, IValidatableObject
	{
		/// <summary>
		///     Initializes a new instance of the <see cref="UltimateOscillatorTechnicalValue" /> class.
		/// </summary>
		/// <param name="DateTime">The date_time of the observation.</param>
		/// <param name="Uo">The Ultimate Oscillator calculation value.</param>
		public UltimateOscillatorTechnicalValue(DateTime? DateTime = default, float? Uo = default)
		{
			this.DateTime = DateTime;
			this.Uo = Uo;
		}

		/// <summary>
		///     The date_time of the observation
		/// </summary>
		/// <value>The date_time of the observation</value>
		[DataMember(Name = "date_time", EmitDefaultValue = false)]
		public DateTime? DateTime { get; set; }

		/// <summary>
		///     The Ultimate Oscillator calculation value
		/// </summary>
		/// <value>The Ultimate Oscillator calculation value</value>
		[DataMember(Name = "uo", EmitDefaultValue = false)]
		public float? Uo { get; set; }

		/// <summary>
		///     Returns true if UltimateOscillatorTechnicalValue instances are equal
		/// </summary>
		/// <param name="input">Instance of UltimateOscillatorTechnicalValue to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(UltimateOscillatorTechnicalValue input)
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
					Uo == input.Uo ||
					Uo != null &&
					Uo.Equals(input.Uo)
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
			sb.Append("class UltimateOscillatorTechnicalValue {\n");
			sb.Append("  DateTime: ").Append(DateTime).Append("\n");
			sb.Append("  Uo: ").Append(Uo).Append("\n");
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
			return Equals(input as UltimateOscillatorTechnicalValue);
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
				if (Uo != null)
					hashCode = hashCode * 59 + Uo.GetHashCode();
				return hashCode;
			}
		}
	}
}