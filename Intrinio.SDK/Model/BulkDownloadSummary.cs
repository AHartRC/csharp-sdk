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
	///     Information about bulk downloads with download links
	/// </summary>
	[DataContract]
	public class BulkDownloadSummary : IEquatable<BulkDownloadSummary>, IValidatableObject
	{
		/// <summary>
		///     Initializes a new instance of the <see cref="BulkDownloadSummary" /> class.
		/// </summary>
		/// <param name="Id">The Intrinio ID of the bulk download.</param>
		/// <param name="Name">The name of the bulk download.</param>
		/// <param name="Format">The file format of the bulk download.</param>
		/// <param name="DataLengthBytes">The total length of the bulk download data in bytes.</param>
		/// <param name="UpdateFrequency">The update frequency for the bulk download.</param>
		/// <param name="Links">Links to all of the files comprising the bulk download. Links expire in 24 hours..</param>
		public BulkDownloadSummary(string Id = default, string Name = default, string Format = default,
			string DataLengthBytes = default, string UpdateFrequency = default, List<BulkDownloadLinks> Links = default)
		{
			this.Id = Id;
			this.Name = Name;
			this.Format = Format;
			this.DataLengthBytes = DataLengthBytes;
			this.UpdateFrequency = UpdateFrequency;
			this.Links = Links;
		}

		/// <summary>
		///     The Intrinio ID of the bulk download
		/// </summary>
		/// <value>The Intrinio ID of the bulk download</value>
		[DataMember(Name = "id", EmitDefaultValue = false)]
		public string Id { get; set; }

		/// <summary>
		///     The name of the bulk download
		/// </summary>
		/// <value>The name of the bulk download</value>
		[DataMember(Name = "name", EmitDefaultValue = false)]
		public string Name { get; set; }

		/// <summary>
		///     The file format of the bulk download
		/// </summary>
		/// <value>The file format of the bulk download</value>
		[DataMember(Name = "format", EmitDefaultValue = false)]
		public string Format { get; set; }

		/// <summary>
		///     The total length of the bulk download data in bytes
		/// </summary>
		/// <value>The total length of the bulk download data in bytes</value>
		[DataMember(Name = "data_length_bytes", EmitDefaultValue = false)]
		public string DataLengthBytes { get; set; }

		/// <summary>
		///     The update frequency for the bulk download
		/// </summary>
		/// <value>The update frequency for the bulk download</value>
		[DataMember(Name = "update_frequency", EmitDefaultValue = false)]
		public string UpdateFrequency { get; set; }

		/// <summary>
		///     Links to all of the files comprising the bulk download. Links expire in 24 hours.
		/// </summary>
		/// <value>Links to all of the files comprising the bulk download. Links expire in 24 hours.</value>
		[DataMember(Name = "links", EmitDefaultValue = false)]
		public List<BulkDownloadLinks> Links { get; set; }

		/// <summary>
		///     Returns true if BulkDownloadSummary instances are equal
		/// </summary>
		/// <param name="input">Instance of BulkDownloadSummary to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(BulkDownloadSummary input)
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
					Format == input.Format ||
					Format != null &&
					Format.Equals(input.Format)
				) &&
				(
					DataLengthBytes == input.DataLengthBytes ||
					DataLengthBytes != null &&
					DataLengthBytes.Equals(input.DataLengthBytes)
				) &&
				(
					UpdateFrequency == input.UpdateFrequency ||
					UpdateFrequency != null &&
					UpdateFrequency.Equals(input.UpdateFrequency)
				) &&
				(
					Links == input.Links ||
					Links != null &&
					Links.SequenceEqual(input.Links)
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
			sb.Append("class BulkDownloadSummary {\n");
			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  Name: ").Append(Name).Append("\n");
			sb.Append("  Format: ").Append(Format).Append("\n");
			sb.Append("  DataLengthBytes: ").Append(DataLengthBytes).Append("\n");
			sb.Append("  UpdateFrequency: ").Append(UpdateFrequency).Append("\n");
			sb.Append("  Links: ").Append(Links).Append("\n");
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
			return Equals(input as BulkDownloadSummary);
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
				if (Format != null)
					hashCode = hashCode * 59 + Format.GetHashCode();
				if (DataLengthBytes != null)
					hashCode = hashCode * 59 + DataLengthBytes.GetHashCode();
				if (UpdateFrequency != null)
					hashCode = hashCode * 59 + UpdateFrequency.GetHashCode();
				if (Links != null)
					hashCode = hashCode * 59 + Links.GetHashCode();
				return hashCode;
			}
		}
	}
}