using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json;

namespace Intrinio.SDK.Model
{
	/// <summary>
	///     SecurityScreenResultData
	/// </summary>
	[DataContract]
	public class SecurityScreenResultData : IEquatable<SecurityScreenResultData>, IValidatableObject
	{
		/// <summary>
		///     Initializes a new instance of the <see cref="SecurityScreenResultData" /> class.
		/// </summary>
		/// <param name="Tag">The data tag that was screened-for.</param>
		/// <param name="NumberValue">The numeric value for the tag.</param>
		/// <param name="TextValue">The text value for the tag.</param>
		public SecurityScreenResultData(string Tag = default, string NumberValue = default, string TextValue = default)
		{
			this.Tag = Tag;
			this.NumberValue = NumberValue;
			this.TextValue = TextValue;
		}

		/// <summary>
		///     The data tag that was screened-for
		/// </summary>
		/// <value>The data tag that was screened-for</value>
		[DataMember(Name = "tag", EmitDefaultValue = false)]
		public string Tag { get; set; }

		/// <summary>
		///     The numeric value for the tag
		/// </summary>
		/// <value>The numeric value for the tag</value>
		[DataMember(Name = "number_value", EmitDefaultValue = false)]
		public string NumberValue { get; set; }

		/// <summary>
		///     The text value for the tag
		/// </summary>
		/// <value>The text value for the tag</value>
		[DataMember(Name = "text_value", EmitDefaultValue = false)]
		public string TextValue { get; set; }

		/// <summary>
		///     Returns true if SecurityScreenResultData instances are equal
		/// </summary>
		/// <param name="input">Instance of SecurityScreenResultData to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(SecurityScreenResultData input)
		{
			if (input == null)
				return false;

			return
				(
					Tag == input.Tag ||
					Tag != null &&
					Tag.Equals(input.Tag)
				) &&
				(
					NumberValue == input.NumberValue ||
					NumberValue != null &&
					NumberValue.Equals(input.NumberValue)
				) &&
				(
					TextValue == input.TextValue ||
					TextValue != null &&
					TextValue.Equals(input.TextValue)
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
			sb.Append("class SecurityScreenResultData {\n");
			sb.Append("  Tag: ").Append(Tag).Append("\n");
			sb.Append("  NumberValue: ").Append(NumberValue).Append("\n");
			sb.Append("  TextValue: ").Append(TextValue).Append("\n");
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
			return Equals(input as SecurityScreenResultData);
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
				if (Tag != null)
					hashCode = hashCode * 59 + Tag.GetHashCode();
				if (NumberValue != null)
					hashCode = hashCode * 59 + NumberValue.GetHashCode();
				if (TextValue != null)
					hashCode = hashCode * 59 + TextValue.GetHashCode();
				return hashCode;
			}
		}
	}
}