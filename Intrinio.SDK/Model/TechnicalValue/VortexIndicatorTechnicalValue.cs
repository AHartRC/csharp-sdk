using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json;

namespace Intrinio.SDK.Model.TechnicalValue
{
	/// <summary>
	///     The date_time, negative_vi, and positive_vi values of a Vortex Indicator technical indicator calculation
	/// </summary>
	[DataContract]
	public class VortexIndicatorTechnicalValue : IEquatable<VortexIndicatorTechnicalValue>, IValidatableObject
	{
		/// <summary>
		///     Initializes a new instance of the <see cref="VortexIndicatorTechnicalValue" /> class.
		/// </summary>
		/// <param name="DateTime">The date_time of the observation.</param>
		/// <param name="NegativeVi">The negative Vortex Indicator value.</param>
		/// <param name="PositiveVi">The positive Vortex Indicator value.</param>
		public VortexIndicatorTechnicalValue(DateTime? DateTime = default, float? NegativeVi = default,
			float? PositiveVi = default)
		{
			this.DateTime = DateTime;
			this.NegativeVi = NegativeVi;
			this.PositiveVi = PositiveVi;
		}

		/// <summary>
		///     The date_time of the observation
		/// </summary>
		/// <value>The date_time of the observation</value>
		[DataMember(Name = "date_time", EmitDefaultValue = false)]
		public DateTime? DateTime { get; set; }

		/// <summary>
		///     The negative Vortex Indicator value
		/// </summary>
		/// <value>The negative Vortex Indicator value</value>
		[DataMember(Name = "negative_vi", EmitDefaultValue = false)]
		public float? NegativeVi { get; set; }

		/// <summary>
		///     The positive Vortex Indicator value
		/// </summary>
		/// <value>The positive Vortex Indicator value</value>
		[DataMember(Name = "positive_vi", EmitDefaultValue = false)]
		public float? PositiveVi { get; set; }

		/// <summary>
		///     Returns true if VortexIndicatorTechnicalValue instances are equal
		/// </summary>
		/// <param name="input">Instance of VortexIndicatorTechnicalValue to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(VortexIndicatorTechnicalValue input)
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
					NegativeVi == input.NegativeVi ||
					NegativeVi != null &&
					NegativeVi.Equals(input.NegativeVi)
				) &&
				(
					PositiveVi == input.PositiveVi ||
					PositiveVi != null &&
					PositiveVi.Equals(input.PositiveVi)
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
			sb.Append("class VortexIndicatorTechnicalValue {\n");
			sb.Append("  DateTime: ").Append(DateTime).Append("\n");
			sb.Append("  NegativeVi: ").Append(NegativeVi).Append("\n");
			sb.Append("  PositiveVi: ").Append(PositiveVi).Append("\n");
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
			return Equals(input as VortexIndicatorTechnicalValue);
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
				if (NegativeVi != null)
					hashCode = hashCode * 59 + NegativeVi.GetHashCode();
				if (PositiveVi != null)
					hashCode = hashCode * 59 + PositiveVi.GetHashCode();
				return hashCode;
			}
		}
	}
}