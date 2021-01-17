using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json;

namespace Intrinio.SDK.Model
{
	/// <summary>
	///     Metadata for the note retrieved including the Intrinio ID, tag and summary of the filing to which it belongs
	/// </summary>
	[DataContract]
	public class FilingNoteSummary : IEquatable<FilingNoteSummary>, IValidatableObject
	{
		/// <summary>
		///     Initializes a new instance of the <see cref="FilingNoteSummary" /> class.
		/// </summary>
		/// <param name="Id">The Intrinio ID of the note.</param>
		/// <param name="XbrlTag">The XBRL tag used for the note by the filing entity.</param>
		/// <param name="Filing">Filing.</param>
		public FilingNoteSummary(string Id = default, string XbrlTag = default, FilingNoteFiling Filing = default)
		{
			this.Id = Id;
			this.XbrlTag = XbrlTag;
			this.Filing = Filing;
		}

		/// <summary>
		///     The Intrinio ID of the note
		/// </summary>
		/// <value>The Intrinio ID of the note</value>
		[DataMember(Name = "id", EmitDefaultValue = false)]
		public string Id { get; set; }

		/// <summary>
		///     The XBRL tag used for the note by the filing entity
		/// </summary>
		/// <value>The XBRL tag used for the note by the filing entity</value>
		[DataMember(Name = "xbrl_tag", EmitDefaultValue = false)]
		public string XbrlTag { get; set; }

		/// <summary>
		///     Gets or Sets Filing
		/// </summary>
		[DataMember(Name = "filing", EmitDefaultValue = false)]
		public FilingNoteFiling Filing { get; set; }

		/// <summary>
		///     Returns true if FilingNoteSummary instances are equal
		/// </summary>
		/// <param name="input">Instance of FilingNoteSummary to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(FilingNoteSummary input)
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
					XbrlTag == input.XbrlTag ||
					XbrlTag != null &&
					XbrlTag.Equals(input.XbrlTag)
				) &&
				(
					Filing == input.Filing ||
					Filing != null &&
					Filing.Equals(input.Filing)
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
			sb.Append("class FilingNoteSummary {\n");
			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  XbrlTag: ").Append(XbrlTag).Append("\n");
			sb.Append("  Filing: ").Append(Filing).Append("\n");
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
			return Equals(input as FilingNoteSummary);
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
				if (XbrlTag != null)
					hashCode = hashCode * 59 + XbrlTag.GetHashCode();
				if (Filing != null)
					hashCode = hashCode * 59 + Filing.GetHashCode();
				return hashCode;
			}
		}
	}
}