using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json;

namespace Intrinio.SDK.Model.TechnicalValue
{
	/// <summary>
	///     The date_time and obv values of a On-balance Volume technical indicator calculation
	/// </summary>
	[DataContract]
	public class OnBalanceVolumeTechnicalValue : IEquatable<OnBalanceVolumeTechnicalValue>, IValidatableObject
	{
		/// <summary>
		///     Initializes a new instance of the <see cref="OnBalanceVolumeTechnicalValue" /> class.
		/// </summary>
		/// <param name="DateTime">The date_time of the observation.</param>
		/// <param name="Obv">The On-balance Volume calculation value.</param>
		public OnBalanceVolumeTechnicalValue(DateTime? DateTime = default, float? Obv = default)
		{
			this.DateTime = DateTime;
			this.Obv = Obv;
		}

		/// <summary>
		///     The date_time of the observation
		/// </summary>
		/// <value>The date_time of the observation</value>
		[DataMember(Name = "date_time", EmitDefaultValue = false)]
		public DateTime? DateTime { get; set; }

		/// <summary>
		///     The On-balance Volume calculation value
		/// </summary>
		/// <value>The On-balance Volume calculation value</value>
		[DataMember(Name = "obv", EmitDefaultValue = false)]
		public float? Obv { get; set; }

		/// <summary>
		///     Returns true if OnBalanceVolumeTechnicalValue instances are equal
		/// </summary>
		/// <param name="input">Instance of OnBalanceVolumeTechnicalValue to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(OnBalanceVolumeTechnicalValue input)
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
					Obv == input.Obv ||
					Obv != null &&
					Obv.Equals(input.Obv)
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
			sb.Append("class OnBalanceVolumeTechnicalValue {\n");
			sb.Append("  DateTime: ").Append(DateTime).Append("\n");
			sb.Append("  Obv: ").Append(Obv).Append("\n");
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
			return Equals(input as OnBalanceVolumeTechnicalValue);
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
				if (Obv != null)
					hashCode = hashCode * 59 + Obv.GetHashCode();
				return hashCode;
			}
		}
	}
}