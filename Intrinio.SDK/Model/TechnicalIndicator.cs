using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json;

namespace Intrinio.SDK.Model
{
	/// <summary>
	///     The name and symbol of the Technical Indicator
	/// </summary>
	[DataContract]
	public class TechnicalIndicator : IEquatable<TechnicalIndicator>, IValidatableObject
	{
		/// <summary>
		///     Initializes a new instance of the <see cref="TechnicalIndicator" /> class.
		/// </summary>
		/// <param name="Name">The name of the Technical Indicator.</param>
		/// <param name="Symbol">The symbol of the Technical Indicator.</param>
		public TechnicalIndicator(string Name = default, string Symbol = default)
		{
			this.Name = Name;
			this.Symbol = Symbol;
		}

		/// <summary>
		///     The name of the Technical Indicator
		/// </summary>
		/// <value>The name of the Technical Indicator</value>
		[DataMember(Name = "name", EmitDefaultValue = false)]
		public string Name { get; set; }

		/// <summary>
		///     The symbol of the Technical Indicator
		/// </summary>
		/// <value>The symbol of the Technical Indicator</value>
		[DataMember(Name = "symbol", EmitDefaultValue = false)]
		public string Symbol { get; set; }

		/// <summary>
		///     Returns true if TechnicalIndicator instances are equal
		/// </summary>
		/// <param name="input">Instance of TechnicalIndicator to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(TechnicalIndicator input)
		{
			if (input == null)
				return false;

			return
				(
					Name == input.Name ||
					Name != null &&
					Name.Equals(input.Name)
				) &&
				(
					Symbol == input.Symbol ||
					Symbol != null &&
					Symbol.Equals(input.Symbol)
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
			sb.Append("class TechnicalIndicator {\n");
			sb.Append("  Name: ").Append(Name).Append("\n");
			sb.Append("  Symbol: ").Append(Symbol).Append("\n");
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
			return Equals(input as TechnicalIndicator);
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
				if (Name != null)
					hashCode = hashCode * 59 + Name.GetHashCode();
				if (Symbol != null)
					hashCode = hashCode * 59 + Symbol.GetHashCode();
				return hashCode;
			}
		}
	}
}