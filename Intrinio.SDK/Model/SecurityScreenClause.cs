using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json;
using Intrinio.SDK.Enumerator;

namespace Intrinio.SDK.Model
{
	/// <summary>
	///     A conditional clause used tp screen securities
	/// </summary>
	[DataContract]
	public class SecurityScreenClause : IEquatable<SecurityScreenClause>, IValidatableObject
	{
		/// <summary>
		///     Initializes a new instance of the <see cref="SecurityScreenClause" /> class.
		/// </summary>
		/// <param name="Field">The field to use when screening, such as an Intrinio Data Tag.</param>
		/// <param name="Operator">The logic operator to use when screening.</param>
		/// <param name="Value">The value to screen by.</param>
		public SecurityScreenClause(string Field = default, SecurityScreenClauseOperatorEnum? Operator = default, string Value = default)
		{
			this.Field = Field;
			this.Operator = Operator;
			this.Value = Value;
		}

		/// <summary>
		///     The logic operator to use when screening
		/// </summary>
		/// <value>The logic operator to use when screening</value>
		[DataMember(Name = "operator", EmitDefaultValue = false)]
		public SecurityScreenClauseOperatorEnum? Operator { get; set; }

		/// <summary>
		///     The field to use when screening, such as an Intrinio Data Tag
		/// </summary>
		/// <value>The field to use when screening, such as an Intrinio Data Tag</value>
		[DataMember(Name = "field", EmitDefaultValue = false)]
		public string Field { get; set; }


		/// <summary>
		///     The value to screen by
		/// </summary>
		/// <value>The value to screen by</value>
		[DataMember(Name = "value", EmitDefaultValue = false)]
		public string Value { get; set; }

		/// <summary>
		///     Returns true if SecurityScreenClause instances are equal
		/// </summary>
		/// <param name="input">Instance of SecurityScreenClause to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(SecurityScreenClause input)
		{
			if (input == null)
				return false;

			return
				(
					Field == input.Field ||
					Field != null &&
					Field.Equals(input.Field)
				) &&
				(
					Operator == input.Operator ||
					Operator != null &&
					Operator.Equals(input.Operator)
				) &&
				(
					Value == input.Value ||
					Value != null &&
					Value.Equals(input.Value)
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
			sb.Append("class SecurityScreenClause {\n");
			sb.Append("  Field: ").Append(Field).Append("\n");
			sb.Append("  Operator: ").Append(Operator).Append("\n");
			sb.Append("  Value: ").Append(Value).Append("\n");
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
			return Equals(input as SecurityScreenClause);
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
				if (Field != null)
					hashCode = hashCode * 59 + Field.GetHashCode();
				if (Operator != null)
					hashCode = hashCode * 59 + Operator.GetHashCode();
				if (Value != null)
					hashCode = hashCode * 59 + Value.GetHashCode();
				return hashCode;
			}
		}
	}
}