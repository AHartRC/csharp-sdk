using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json;

namespace Intrinio.SDK.Model.TechnicalValue
{
	/// <summary>
	///     The date_time and kst values of a Know Sure Thing technical indicator calculation
	/// </summary>
	[DataContract]
	public class KnowSureThingTechnicalValue : IEquatable<KnowSureThingTechnicalValue>, IValidatableObject
	{
		/// <summary>
		///     Initializes a new instance of the <see cref="KnowSureThingTechnicalValue" /> class.
		/// </summary>
		/// <param name="DateTime">The date_time of the observation.</param>
		/// <param name="Kst">The Know Sure Thing calculation value.</param>
		public KnowSureThingTechnicalValue(DateTime? DateTime = default, float? Kst = default)
		{
			this.DateTime = DateTime;
			this.Kst = Kst;
		}

		/// <summary>
		///     The date_time of the observation
		/// </summary>
		/// <value>The date_time of the observation</value>
		[DataMember(Name = "date_time", EmitDefaultValue = false)]
		public DateTime? DateTime { get; set; }

		/// <summary>
		///     The Know Sure Thing calculation value
		/// </summary>
		/// <value>The Know Sure Thing calculation value</value>
		[DataMember(Name = "kst", EmitDefaultValue = false)]
		public float? Kst { get; set; }

		/// <summary>
		///     Returns true if KnowSureThingTechnicalValue instances are equal
		/// </summary>
		/// <param name="input">Instance of KnowSureThingTechnicalValue to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(KnowSureThingTechnicalValue input)
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
					Kst == input.Kst ||
					Kst != null &&
					Kst.Equals(input.Kst)
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
			sb.Append("class KnowSureThingTechnicalValue {\n");
			sb.Append("  DateTime: ").Append(DateTime).Append("\n");
			sb.Append("  Kst: ").Append(Kst).Append("\n");
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
			return Equals(input as KnowSureThingTechnicalValue);
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
				if (Kst != null)
					hashCode = hashCode * 59 + Kst.GetHashCode();
				return hashCode;
			}
		}
	}
}