using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json;

namespace Intrinio.SDK.Model
{
	/// <summary>
	///     A group of clauses and groups combined with a logic operator, used to screen securities
	/// </summary>
	[DataContract]
	public class SecurityScreenGroup : IEquatable<SecurityScreenGroup>, IValidatableObject
	{
		/// <summary>
		///     Initializes a new instance of the <see cref="SecurityScreenGroup" /> class.
		/// </summary>
		/// <param name="Operator">The logic operator for the group (AND, OR, NOT).</param>
		/// <param name="Clauses">The logic clauses in the group.</param>
		/// <param name="Groups">The nested groups within the group.</param>
		public SecurityScreenGroup(string Operator = default, List<SecurityScreenClause> Clauses = default,
			List<SecurityScreenGroup> Groups = default)
		{
			this.Operator = Operator;
			this.Clauses = Clauses;
			this.Groups = Groups;
		}

		/// <summary>
		///     The logic operator for the group (AND, OR, NOT)
		/// </summary>
		/// <value>The logic operator for the group (AND, OR, NOT)</value>
		[DataMember(Name = "operator", EmitDefaultValue = false)]
		public string Operator { get; set; }

		/// <summary>
		///     The logic clauses in the group
		/// </summary>
		/// <value>The logic clauses in the group</value>
		[DataMember(Name = "clauses", EmitDefaultValue = false)]
		public List<SecurityScreenClause> Clauses { get; set; }

		/// <summary>
		///     The nested groups within the group
		/// </summary>
		/// <value>The nested groups within the group</value>
		[DataMember(Name = "groups", EmitDefaultValue = false)]
		public List<SecurityScreenGroup> Groups { get; set; }

		/// <summary>
		///     Returns true if SecurityScreenGroup instances are equal
		/// </summary>
		/// <param name="input">Instance of SecurityScreenGroup to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(SecurityScreenGroup input)
		{
			if (input == null)
				return false;

			return
				(
					Operator == input.Operator ||
					Operator != null &&
					Operator.Equals(input.Operator)
				) &&
				(
					Clauses == input.Clauses ||
					Clauses != null &&
					Clauses.SequenceEqual(input.Clauses)
				) &&
				(
					Groups == input.Groups ||
					Groups != null &&
					Groups.SequenceEqual(input.Groups)
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
			sb.Append("class SecurityScreenGroup {\n");
			sb.Append("  Operator: ").Append(Operator).Append("\n");
			sb.Append("  Clauses: ").Append(Clauses).Append("\n");
			sb.Append("  Groups: ").Append(Groups).Append("\n");
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
			return Equals(input as SecurityScreenGroup);
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
				if (Operator != null)
					hashCode = hashCode * 59 + Operator.GetHashCode();
				if (Clauses != null)
					hashCode = hashCode * 59 + Clauses.GetHashCode();
				if (Groups != null)
					hashCode = hashCode * 59 + Groups.GetHashCode();
				return hashCode;
			}
		}
	}
}