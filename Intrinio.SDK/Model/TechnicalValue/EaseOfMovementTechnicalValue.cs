using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json;

namespace Intrinio.SDK.Model.TechnicalValue
{
	/// <summary>
	///     The date_time and eom values of a Ease of Movement technical indicator calculation
	/// </summary>
	[DataContract]
	public class EaseOfMovementTechnicalValue : IEquatable<EaseOfMovementTechnicalValue>, IValidatableObject
	{
		/// <summary>
		///     Initializes a new instance of the <see cref="EaseOfMovementTechnicalValue" /> class.
		/// </summary>
		/// <param name="DateTime">The date_time of the observation.</param>
		/// <param name="Eom">The Ease of Movement calculation value.</param>
		public EaseOfMovementTechnicalValue(DateTime? DateTime = default, float? Eom = default)
		{
			this.DateTime = DateTime;
			this.Eom = Eom;
		}

		/// <summary>
		///     The date_time of the observation
		/// </summary>
		/// <value>The date_time of the observation</value>
		[DataMember(Name = "date_time", EmitDefaultValue = false)]
		public DateTime? DateTime { get; set; }

		/// <summary>
		///     The Ease of Movement calculation value
		/// </summary>
		/// <value>The Ease of Movement calculation value</value>
		[DataMember(Name = "eom", EmitDefaultValue = false)]
		public float? Eom { get; set; }

		/// <summary>
		///     Returns true if EaseOfMovementTechnicalValue instances are equal
		/// </summary>
		/// <param name="input">Instance of EaseOfMovementTechnicalValue to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(EaseOfMovementTechnicalValue input)
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
					Eom == input.Eom ||
					Eom != null &&
					Eom.Equals(input.Eom)
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
			sb.Append("class EaseOfMovementTechnicalValue {\n");
			sb.Append("  DateTime: ").Append(DateTime).Append("\n");
			sb.Append("  Eom: ").Append(Eom).Append("\n");
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
			return Equals(input as EaseOfMovementTechnicalValue);
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
				if (Eom != null)
					hashCode = hashCode * 59 + Eom.GetHashCode();
				return hashCode;
			}
		}
	}
}