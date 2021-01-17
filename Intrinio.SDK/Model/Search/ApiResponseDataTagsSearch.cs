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
	///     ApiResponseDataTagsSearch
	/// </summary>
	[DataContract]
	public class ApiResponseDataTagsSearch : IEquatable<ApiResponseDataTagsSearch>, IValidatableObject
	{
		/// <summary>
		///     Initializes a new instance of the <see cref="ApiResponseDataTagsSearch" /> class.
		/// </summary>
		/// <param name="Tags">Tags.</param>
		public ApiResponseDataTagsSearch(List<DataTag> Tags = default)
		{
			this.Tags = Tags;
		}

		/// <summary>
		///     Gets or Sets Tags
		/// </summary>
		[DataMember(Name = "tags", EmitDefaultValue = false)]
		public List<DataTag> Tags { get; set; }

		/// <summary>
		///     Returns true if ApiResponseDataTagsSearch instances are equal
		/// </summary>
		/// <param name="input">Instance of ApiResponseDataTagsSearch to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(ApiResponseDataTagsSearch input)
		{
			if (input == null)
				return false;

			return
				Tags == input.Tags ||
				Tags != null &&
				Tags.SequenceEqual(input.Tags);
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
			sb.Append("class ApiResponseDataTagsSearch {\n");
			sb.Append("  Tags: ").Append(Tags).Append("\n");
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
			return Equals(input as ApiResponseDataTagsSearch);
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
				if (Tags != null)
					hashCode = hashCode * 59 + Tags.GetHashCode();
				return hashCode;
			}
		}
	}
}