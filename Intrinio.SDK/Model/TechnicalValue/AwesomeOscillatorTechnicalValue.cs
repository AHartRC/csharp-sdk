using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json;

namespace Intrinio.SDK.Model.TechnicalValue
{
	/// <summary>
	///     The date_time and ao values of an Awesome Oscillator technical indicator calculation
	/// </summary>
	[DataContract]
	public class AwesomeOscillatorTechnicalValue : IEquatable<AwesomeOscillatorTechnicalValue>, IValidatableObject
	{
		/// <summary>
		///     Initializes a new instance of the <see cref="AwesomeOscillatorTechnicalValue" /> class.
		/// </summary>
		/// <param name="DateTime">The date_time of the observation.</param>
		/// <param name="Ao">The Awesome Oscillator calculation value.</param>
		public AwesomeOscillatorTechnicalValue(DateTime? DateTime = default, float? Ao = default)
		{
			this.DateTime = DateTime;
			this.Ao = Ao;
		}

		/// <summary>
		///     The date_time of the observation
		/// </summary>
		/// <value>The date_time of the observation</value>
		[DataMember(Name = "date_time", EmitDefaultValue = false)]
		public DateTime? DateTime { get; set; }

		/// <summary>
		///     The Awesome Oscillator calculation value
		/// </summary>
		/// <value>The Awesome Oscillator calculation value</value>
		[DataMember(Name = "ao", EmitDefaultValue = false)]
		public float? Ao { get; set; }

		/// <summary>
		///     Returns true if AwesomeOscillatorTechnicalValue instances are equal
		/// </summary>
		/// <param name="input">Instance of AwesomeOscillatorTechnicalValue to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(AwesomeOscillatorTechnicalValue input)
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
					Ao == input.Ao ||
					Ao != null &&
					Ao.Equals(input.Ao)
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
			sb.Append("class AwesomeOscillatorTechnicalValue {\n");
			sb.Append("  DateTime: ").Append(DateTime).Append("\n");
			sb.Append("  Ao: ").Append(Ao).Append("\n");
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
			return Equals(input as AwesomeOscillatorTechnicalValue);
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
				if (Ao != null)
					hashCode = hashCode * 59 + Ao.GetHashCode();
				return hashCode;
			}
		}
	}
}