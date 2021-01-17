using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json;

namespace Intrinio.SDK.Model
{
	/// <summary>
	///     A news article about a company
	/// </summary>
	[DataContract]
	public class CompanyNewsSummary : IEquatable<CompanyNewsSummary>, IValidatableObject
	{
		/// <summary>
		///     Initializes a new instance of the <see cref="CompanyNewsSummary" /> class.
		/// </summary>
		/// <param name="Id">The Intrinio ID for the news article.</param>
		/// <param name="Title">The title of the news article.</param>
		/// <param name="PublicationDate">The publication date of the news article.</param>
		/// <param name="Url">The url of the news article.</param>
		/// <param name="Summary">A summary of the news article.</param>
		public CompanyNewsSummary(string Id = default, string Title = default, DateTime? PublicationDate = default,
			string Url = default, string Summary = default)
		{
			this.Id = Id;
			this.Title = Title;
			this.PublicationDate = PublicationDate;
			this.Url = Url;
			this.Summary = Summary;
		}

		/// <summary>
		///     The Intrinio ID for the news article
		/// </summary>
		/// <value>The Intrinio ID for the news article</value>
		[DataMember(Name = "id", EmitDefaultValue = false)]
		public string Id { get; set; }

		/// <summary>
		///     The title of the news article
		/// </summary>
		/// <value>The title of the news article</value>
		[DataMember(Name = "title", EmitDefaultValue = false)]
		public string Title { get; set; }

		/// <summary>
		///     The publication date of the news article
		/// </summary>
		/// <value>The publication date of the news article</value>
		[DataMember(Name = "publication_date", EmitDefaultValue = false)]
		public DateTime? PublicationDate { get; set; }

		/// <summary>
		///     The url of the news article
		/// </summary>
		/// <value>The url of the news article</value>
		[DataMember(Name = "url", EmitDefaultValue = false)]
		public string Url { get; set; }

		/// <summary>
		///     A summary of the news article
		/// </summary>
		/// <value>A summary of the news article</value>
		[DataMember(Name = "summary", EmitDefaultValue = false)]
		public string Summary { get; set; }

		/// <summary>
		///     Returns true if CompanyNewsSummary instances are equal
		/// </summary>
		/// <param name="input">Instance of CompanyNewsSummary to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(CompanyNewsSummary input)
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
					Title == input.Title ||
					Title != null &&
					Title.Equals(input.Title)
				) &&
				(
					PublicationDate == input.PublicationDate ||
					PublicationDate != null &&
					PublicationDate.Equals(input.PublicationDate)
				) &&
				(
					Url == input.Url ||
					Url != null &&
					Url.Equals(input.Url)
				) &&
				(
					Summary == input.Summary ||
					Summary != null &&
					Summary.Equals(input.Summary)
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
			sb.Append("class CompanyNewsSummary {\n");
			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  Title: ").Append(Title).Append("\n");
			sb.Append("  PublicationDate: ").Append(PublicationDate).Append("\n");
			sb.Append("  Url: ").Append(Url).Append("\n");
			sb.Append("  Summary: ").Append(Summary).Append("\n");
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
			return Equals(input as CompanyNewsSummary);
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
				if (Title != null)
					hashCode = hashCode * 59 + Title.GetHashCode();
				if (PublicationDate != null)
					hashCode = hashCode * 59 + PublicationDate.GetHashCode();
				if (Url != null)
					hashCode = hashCode * 59 + Url.GetHashCode();
				if (Summary != null)
					hashCode = hashCode * 59 + Summary.GetHashCode();
				return hashCode;
			}
		}
	}
}