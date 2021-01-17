using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json;

namespace Intrinio.SDK.Model
{
	/// <summary>
	///     A filing submitted to the SEC by a company
	/// </summary>
	[DataContract]
	public class FilingNote : IEquatable<FilingNote>, IValidatableObject
	{
		/// <summary>
		///     Initializes a new instance of the <see cref="FilingNote" /> class.
		/// </summary>
		/// <param name="Id">The Intrinio ID of the note.</param>
		/// <param name="XbrlTag">The XBRL Tag used for the note.</param>
		/// <param name="Content">
		///     The plain text (after html has been removed) of the note, or text including html if the
		///     content_format parameter has been set to html.
		/// </param>
		/// <param name="Filing">Filing.</param>
		public FilingNote(string Id = default, string XbrlTag = default, string Content = default,
			FilingNoteFiling Filing = default)
		{
			this.Id = Id;
			this.XbrlTag = XbrlTag;
			this.Content = Content;
			this.Filing = Filing;
		}

		/// <summary>
		///     The Intrinio ID of the note
		/// </summary>
		/// <value>The Intrinio ID of the note</value>
		[DataMember(Name = "id", EmitDefaultValue = false)]
		public string Id { get; set; }

		/// <summary>
		///     The XBRL Tag used for the note
		/// </summary>
		/// <value>The XBRL Tag used for the note</value>
		[DataMember(Name = "xbrl_tag", EmitDefaultValue = false)]
		public string XbrlTag { get; set; }

		/// <summary>
		///     The plain text (after html has been removed) of the note, or text including html if the content_format parameter
		///     has been set to html
		/// </summary>
		/// <value>
		///     The plain text (after html has been removed) of the note, or text including html if the content_format parameter
		///     has been set to html
		/// </value>
		[DataMember(Name = "content", EmitDefaultValue = false)]
		public string Content { get; set; }

		/// <summary>
		///     Gets or Sets Filing
		/// </summary>
		[DataMember(Name = "filing", EmitDefaultValue = false)]
		public FilingNoteFiling Filing { get; set; }

		/// <summary>
		///     Returns true if FilingNote instances are equal
		/// </summary>
		/// <param name="input">Instance of FilingNote to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(FilingNote input)
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
					Content == input.Content ||
					Content != null &&
					Content.Equals(input.Content)
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
			sb.Append("class FilingNote {\n");
			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  XbrlTag: ").Append(XbrlTag).Append("\n");
			sb.Append("  Content: ").Append(Content).Append("\n");
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
			return Equals(input as FilingNote);
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
				if (Content != null)
					hashCode = hashCode * 59 + Content.GetHashCode();
				if (Filing != null)
					hashCode = hashCode * 59 + Filing.GetHashCode();
				return hashCode;
			}
		}
	}
}