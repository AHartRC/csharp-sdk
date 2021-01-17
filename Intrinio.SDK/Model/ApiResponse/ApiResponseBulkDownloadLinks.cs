using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json;

namespace Intrinio.SDK.Model.ApiResponse
{
	/// <summary>
	///     ApiResponseBulkDownloadLinks
	/// </summary>
	[DataContract]
	public class ApiResponseBulkDownloadLinks : IEquatable<ApiResponseBulkDownloadLinks>, IValidatableObject
	{
		/// <summary>
		///     Initializes a new instance of the <see cref="ApiResponseBulkDownloadLinks" /> class.
		/// </summary>
		/// <param name="BulkDownloads">BulkDownloads.</param>
		public ApiResponseBulkDownloadLinks(List<BulkDownloadSummary> BulkDownloads = default)
		{
			this.BulkDownloads = BulkDownloads;
		}

		/// <summary>
		///     Gets or Sets BulkDownloads
		/// </summary>
		[DataMember(Name = "bulk_downloads", EmitDefaultValue = false)]
		public List<BulkDownloadSummary> BulkDownloads { get; set; }

		/// <summary>
		///     Returns true if ApiResponseBulkDownloadLinks instances are equal
		/// </summary>
		/// <param name="input">Instance of ApiResponseBulkDownloadLinks to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(ApiResponseBulkDownloadLinks input)
		{
			if (input == null)
				return false;

			return
				BulkDownloads == input.BulkDownloads ||
				BulkDownloads != null &&
				BulkDownloads.SequenceEqual(input.BulkDownloads);
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
			sb.Append("class ApiResponseBulkDownloadLinks {\n");
			sb.Append("  BulkDownloads: ").Append(BulkDownloads).Append("\n");
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
			return Equals(input as ApiResponseBulkDownloadLinks);
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
				if (BulkDownloads != null)
					hashCode = hashCode * 59 + BulkDownloads.GetHashCode();
				return hashCode;
			}
		}
	}
}