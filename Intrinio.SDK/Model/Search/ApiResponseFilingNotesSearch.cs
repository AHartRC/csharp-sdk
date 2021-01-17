using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json;

namespace Intrinio.SDK.Model.Search
{
	/// <summary>
	///     ApiResponseFilingNotesSearch
	/// </summary>
	[DataContract]
	public class ApiResponseFilingNotesSearch : IEquatable<ApiResponseFilingNotesSearch>, IValidatableObject
	{
		/// <summary>
		///     Initializes a new instance of the <see cref="ApiResponseFilingNotesSearch" /> class.
		/// </summary>
		/// <param name="FilingNotes">FilingNotes.</param>
		public ApiResponseFilingNotesSearch(List<FilingNoteSummary> FilingNotes = default)
		{
			this.FilingNotes = FilingNotes;
		}

		/// <summary>
		///     Gets or Sets FilingNotes
		/// </summary>
		[DataMember(Name = "filing_notes", EmitDefaultValue = false)]
		public List<FilingNoteSummary> FilingNotes { get; set; }

		/// <summary>
		///     Returns true if ApiResponseFilingNotesSearch instances are equal
		/// </summary>
		/// <param name="input">Instance of ApiResponseFilingNotesSearch to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(ApiResponseFilingNotesSearch input)
		{
			if (input == null)
				return false;

			return
				FilingNotes == input.FilingNotes ||
				FilingNotes != null &&
				FilingNotes.SequenceEqual(input.FilingNotes);
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
			sb.Append("class ApiResponseFilingNotesSearch {\n");
			sb.Append("  FilingNotes: ").Append(FilingNotes).Append("\n");
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
			return Equals(input as ApiResponseFilingNotesSearch);
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
				if (FilingNotes != null)
					hashCode = hashCode * 59 + FilingNotes.GetHashCode();
				return hashCode;
			}
		}
	}
}