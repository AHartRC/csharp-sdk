using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using Intrinio.SDK.Enumerator;

namespace Intrinio.SDK.Model
{
	/// <summary>
	///     DataTag
	/// </summary>
	[DataContract]
	public class DataTag : IEquatable<DataTag>, IValidatableObject
	{

		/// <summary>
		///     Initializes a new instance of the <see cref="DataTag" /> class.
		/// </summary>
		/// <param name="Id">The Intrinio ID for the Data Tag.</param>
		/// <param name="Name">The readable name of the Data Tag.</param>
		/// <param name="Tag">The code-name of the Data Tag.</param>
		/// <param name="StatementCode">The code of the financial statement to which this Data Tag belongs.</param>
		/// <param name="StatementType">The format of the financial statment to which this Data Tag belongs.</param>
		/// <param name="Parent">The parent Data Tag forming the statement relationship with the factor.</param>
		/// <param name="Sequence">The order in which the Data Tag appears in its logical group (such as a financial statement).</param>
		/// <param name="Factor">
		///     The operator forming the statement relationship between the child Data Tag (or Data Tags) and the
		///     parent Data Tag.
		/// </param>
		/// <param name="Balance">Whether the Data Tag represents a credit or debit.</param>
		/// <param name="Type">The nature of the Data Tag, operating or nonoperating.</param>
		/// <param name="Unit">The unit of the Data Tag.</param>
		public DataTag(string Id = default, string Name = default, string Tag = default, string StatementCode = default,
			StatementTypeEnum? StatementType = default, string Parent = default, decimal? Sequence = default,
			string Factor = default, string Balance = default, string Type = default, string Unit = default)
		{
			this.Id = Id;
			this.Name = Name;
			this.Tag = Tag;
			this.StatementCode = StatementCode;
			this.StatementType = StatementType;
			this.Parent = Parent;
			this.Sequence = Sequence;
			this.Factor = Factor;
			this.Balance = Balance;
			this.Type = Type;
			this.Unit = Unit;
		}

		/// <summary>
		///     The format of the financial statment to which this Data Tag belongs
		/// </summary>
		/// <value>The format of the financial statment to which this Data Tag belongs</value>
		[DataMember(Name = "statement_type", EmitDefaultValue = false)]
		public StatementTypeEnum? StatementType { get; set; }

		/// <summary>
		///     The Intrinio ID for the Data Tag
		/// </summary>
		/// <value>The Intrinio ID for the Data Tag</value>
		[DataMember(Name = "id", EmitDefaultValue = false)]
		public string Id { get; set; }

		/// <summary>
		///     The readable name of the Data Tag
		/// </summary>
		/// <value>The readable name of the Data Tag</value>
		[DataMember(Name = "name", EmitDefaultValue = false)]
		public string Name { get; set; }

		/// <summary>
		///     The code-name of the Data Tag
		/// </summary>
		/// <value>The code-name of the Data Tag</value>
		[DataMember(Name = "tag", EmitDefaultValue = false)]
		public string Tag { get; set; }

		/// <summary>
		///     The code of the financial statement to which this Data Tag belongs
		/// </summary>
		/// <value>The code of the financial statement to which this Data Tag belongs</value>
		[DataMember(Name = "statement_code", EmitDefaultValue = false)]
		public string StatementCode { get; set; }


		/// <summary>
		///     The parent Data Tag forming the statement relationship with the factor
		/// </summary>
		/// <value>The parent Data Tag forming the statement relationship with the factor</value>
		[DataMember(Name = "parent", EmitDefaultValue = false)]
		public string Parent { get; set; }

		/// <summary>
		///     The order in which the Data Tag appears in its logical group (such as a financial statement)
		/// </summary>
		/// <value>The order in which the Data Tag appears in its logical group (such as a financial statement)</value>
		[DataMember(Name = "sequence", EmitDefaultValue = false)]
		public decimal? Sequence { get; set; }

		/// <summary>
		///     The operator forming the statement relationship between the child Data Tag (or Data Tags) and the parent Data Tag
		/// </summary>
		/// <value>
		///     The operator forming the statement relationship between the child Data Tag (or Data Tags) and the parent Data
		///     Tag
		/// </value>
		[DataMember(Name = "factor", EmitDefaultValue = false)]
		public string Factor { get; set; }

		/// <summary>
		///     Whether the Data Tag represents a credit or debit
		/// </summary>
		/// <value>Whether the Data Tag represents a credit or debit</value>
		[DataMember(Name = "balance", EmitDefaultValue = false)]
		public string Balance { get; set; }

		/// <summary>
		///     The nature of the Data Tag, operating or nonoperating
		/// </summary>
		/// <value>The nature of the Data Tag, operating or nonoperating</value>
		[DataMember(Name = "type", EmitDefaultValue = false)]
		public string Type { get; set; }

		/// <summary>
		///     The unit of the Data Tag
		/// </summary>
		/// <value>The unit of the Data Tag</value>
		[DataMember(Name = "unit", EmitDefaultValue = false)]
		public string Unit { get; set; }

		/// <summary>
		///     Returns true if DataTag instances are equal
		/// </summary>
		/// <param name="input">Instance of DataTag to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(DataTag input)
		{
			if (input == null)
				return false;

			return
				(
					Id == input.Id ||
					Id != null &&
					Id.Equals(input.Id)
				) &&
				(
					Name == input.Name ||
					Name != null &&
					Name.Equals(input.Name)
				) &&
				(
					Tag == input.Tag ||
					Tag != null &&
					Tag.Equals(input.Tag)
				) &&
				(
					StatementCode == input.StatementCode ||
					StatementCode != null &&
					StatementCode.Equals(input.StatementCode)
				) &&
				(
					StatementType == input.StatementType ||
					StatementType != null &&
					StatementType.Equals(input.StatementType)
				) &&
				(
					Parent == input.Parent ||
					Parent != null &&
					Parent.Equals(input.Parent)
				) &&
				(
					Sequence == input.Sequence ||
					Sequence != null &&
					Sequence.Equals(input.Sequence)
				) &&
				(
					Factor == input.Factor ||
					Factor != null &&
					Factor.Equals(input.Factor)
				) &&
				(
					Balance == input.Balance ||
					Balance != null &&
					Balance.Equals(input.Balance)
				) &&
				(
					Type == input.Type ||
					Type != null &&
					Type.Equals(input.Type)
				) &&
				(
					Unit == input.Unit ||
					Unit != null &&
					Unit.Equals(input.Unit)
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
			sb.Append("class DataTag {\n");
			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  Name: ").Append(Name).Append("\n");
			sb.Append("  Tag: ").Append(Tag).Append("\n");
			sb.Append("  StatementCode: ").Append(StatementCode).Append("\n");
			sb.Append("  StatementType: ").Append(StatementType).Append("\n");
			sb.Append("  Parent: ").Append(Parent).Append("\n");
			sb.Append("  Sequence: ").Append(Sequence).Append("\n");
			sb.Append("  Factor: ").Append(Factor).Append("\n");
			sb.Append("  Balance: ").Append(Balance).Append("\n");
			sb.Append("  Type: ").Append(Type).Append("\n");
			sb.Append("  Unit: ").Append(Unit).Append("\n");
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
			return Equals(input as DataTag);
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
				if (Id != null)
					hashCode = hashCode * 59 + Id.GetHashCode();
				if (Name != null)
					hashCode = hashCode * 59 + Name.GetHashCode();
				if (Tag != null)
					hashCode = hashCode * 59 + Tag.GetHashCode();
				if (StatementCode != null)
					hashCode = hashCode * 59 + StatementCode.GetHashCode();
				if (StatementType != null)
					hashCode = hashCode * 59 + StatementType.GetHashCode();
				if (Parent != null)
					hashCode = hashCode * 59 + Parent.GetHashCode();
				if (Sequence != null)
					hashCode = hashCode * 59 + Sequence.GetHashCode();
				if (Factor != null)
					hashCode = hashCode * 59 + Factor.GetHashCode();
				if (Balance != null)
					hashCode = hashCode * 59 + Balance.GetHashCode();
				if (Type != null)
					hashCode = hashCode * 59 + Type.GetHashCode();
				if (Unit != null)
					hashCode = hashCode * 59 + Unit.GetHashCode();
				return hashCode;
			}
		}
	}
}