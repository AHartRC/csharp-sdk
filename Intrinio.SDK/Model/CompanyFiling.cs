using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using Intrinio.SDK.Client;

namespace Intrinio.SDK.Model
{
	/// <summary>
	///     A filing submitted to the SEC by a company
	/// </summary>
	[DataContract]
	public class CompanyFiling : IEquatable<CompanyFiling>, IValidatableObject
	{
		/// <summary>
		///     Initializes a new instance of the <see cref="CompanyFiling" /> class.
		/// </summary>
		/// <param name="Id">The Intrinio ID of the Filing.</param>
		/// <param name="FilingDate">The date when the filing was submitted to the SEC by the company.</param>
		/// <param name="AcceptedDate">The date and time when the filing was accepted by SEC.</param>
		/// <param name="PeriodEndDate">The ending date of the fiscal period for the filing.</param>
		/// <param name="ReportType">
		///     The filing &lt;a href&#x3D;\&quot;
		///     https://docs.intrinio.com/documentation/sec_filing_report_types\&quot; target&#x3D;\&quot;_blank\&quot;&gt;report
		///     type&lt;/a&gt;.
		/// </param>
		/// <param name="SecUniqueId">A unique identifier for the filing provided by the SEC.</param>
		/// <param name="FilingUrl">The URL to the filing page on the SEC site.</param>
		/// <param name="ReportUrl">The URL to the actual report on the SEC site.</param>
		/// <param name="InstanceUrl">The URL for the XBRL filing for the report.</param>
		/// <param name="Company">Company.</param>
		public CompanyFiling(string Id = default, DateTime? FilingDate = default, DateTime? AcceptedDate = default,
			DateTime? PeriodEndDate = default, string ReportType = default, string SecUniqueId = default,
			string FilingUrl = default, string ReportUrl = default, string InstanceUrl = default,
			CompanySummary Company = default)
		{
			this.Id = Id;
			this.FilingDate = FilingDate;
			this.AcceptedDate = AcceptedDate;
			this.PeriodEndDate = PeriodEndDate;
			this.ReportType = ReportType;
			this.SecUniqueId = SecUniqueId;
			this.FilingUrl = FilingUrl;
			this.ReportUrl = ReportUrl;
			this.InstanceUrl = InstanceUrl;
			this.Company = Company;
		}

		/// <summary>
		///     The Intrinio ID of the Filing
		/// </summary>
		/// <value>The Intrinio ID of the Filing</value>
		[DataMember(Name = "id", EmitDefaultValue = false)]
		public string Id { get; set; }

		/// <summary>
		///     The date when the filing was submitted to the SEC by the company
		/// </summary>
		/// <value>The date when the filing was submitted to the SEC by the company</value>
		[DataMember(Name = "filing_date", EmitDefaultValue = false)]
		
		public DateTime? FilingDate { get; set; }

		/// <summary>
		///     The date and time when the filing was accepted by SEC
		/// </summary>
		/// <value>The date and time when the filing was accepted by SEC</value>
		[DataMember(Name = "accepted_date", EmitDefaultValue = false)]
		public DateTime? AcceptedDate { get; set; }

		/// <summary>
		///     The ending date of the fiscal period for the filing
		/// </summary>
		/// <value>The ending date of the fiscal period for the filing</value>
		[DataMember(Name = "period_end_date", EmitDefaultValue = false)]
		
		public DateTime? PeriodEndDate { get; set; }

		/// <summary>
		///     The filing &lt;a href&#x3D;\&quot;https://docs.intrinio.com/documentation/sec_filing_report_types\&quot; target
		///     &#x3D;\&quot;_blank\&quot;&gt;report type&lt;/a&gt;
		/// </summary>
		/// <value>
		///     The filing &lt;a href&#x3D;\&quot;https://docs.intrinio.com/documentation/sec_filing_report_types\&quot; target
		///     &#x3D;\&quot;_blank\&quot;&gt;report type&lt;/a&gt;
		/// </value>
		[DataMember(Name = "report_type", EmitDefaultValue = false)]
		public string ReportType { get; set; }

		/// <summary>
		///     A unique identifier for the filing provided by the SEC
		/// </summary>
		/// <value>A unique identifier for the filing provided by the SEC</value>
		[DataMember(Name = "sec_unique_id", EmitDefaultValue = false)]
		public string SecUniqueId { get; set; }

		/// <summary>
		///     The URL to the filing page on the SEC site
		/// </summary>
		/// <value>The URL to the filing page on the SEC site</value>
		[DataMember(Name = "filing_url", EmitDefaultValue = false)]
		public string FilingUrl { get; set; }

		/// <summary>
		///     The URL to the actual report on the SEC site
		/// </summary>
		/// <value>The URL to the actual report on the SEC site</value>
		[DataMember(Name = "report_url", EmitDefaultValue = false)]
		public string ReportUrl { get; set; }

		/// <summary>
		///     The URL for the XBRL filing for the report
		/// </summary>
		/// <value>The URL for the XBRL filing for the report</value>
		[DataMember(Name = "instance_url", EmitDefaultValue = false)]
		public string InstanceUrl { get; set; }

		/// <summary>
		///     Gets or Sets Company
		/// </summary>
		[DataMember(Name = "company", EmitDefaultValue = false)]
		public CompanySummary Company { get; set; }

		/// <summary>
		///     Returns true if CompanyFiling instances are equal
		/// </summary>
		/// <param name="input">Instance of CompanyFiling to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(CompanyFiling input)
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
					FilingDate == input.FilingDate ||
					FilingDate != null &&
					FilingDate.Equals(input.FilingDate)
				) &&
				(
					AcceptedDate == input.AcceptedDate ||
					AcceptedDate != null &&
					AcceptedDate.Equals(input.AcceptedDate)
				) &&
				(
					PeriodEndDate == input.PeriodEndDate ||
					PeriodEndDate != null &&
					PeriodEndDate.Equals(input.PeriodEndDate)
				) &&
				(
					ReportType == input.ReportType ||
					ReportType != null &&
					ReportType.Equals(input.ReportType)
				) &&
				(
					SecUniqueId == input.SecUniqueId ||
					SecUniqueId != null &&
					SecUniqueId.Equals(input.SecUniqueId)
				) &&
				(
					FilingUrl == input.FilingUrl ||
					FilingUrl != null &&
					FilingUrl.Equals(input.FilingUrl)
				) &&
				(
					ReportUrl == input.ReportUrl ||
					ReportUrl != null &&
					ReportUrl.Equals(input.ReportUrl)
				) &&
				(
					InstanceUrl == input.InstanceUrl ||
					InstanceUrl != null &&
					InstanceUrl.Equals(input.InstanceUrl)
				) &&
				(
					Company == input.Company ||
					Company != null &&
					Company.Equals(input.Company)
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
			sb.Append("class CompanyFiling {\n");
			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  FilingDate: ").Append(FilingDate).Append("\n");
			sb.Append("  AcceptedDate: ").Append(AcceptedDate).Append("\n");
			sb.Append("  PeriodEndDate: ").Append(PeriodEndDate).Append("\n");
			sb.Append("  ReportType: ").Append(ReportType).Append("\n");
			sb.Append("  SecUniqueId: ").Append(SecUniqueId).Append("\n");
			sb.Append("  FilingUrl: ").Append(FilingUrl).Append("\n");
			sb.Append("  ReportUrl: ").Append(ReportUrl).Append("\n");
			sb.Append("  InstanceUrl: ").Append(InstanceUrl).Append("\n");
			sb.Append("  Company: ").Append(Company).Append("\n");
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
			return Equals(input as CompanyFiling);
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
				if (FilingDate != null)
					hashCode = hashCode * 59 + FilingDate.GetHashCode();
				if (AcceptedDate != null)
					hashCode = hashCode * 59 + AcceptedDate.GetHashCode();
				if (PeriodEndDate != null)
					hashCode = hashCode * 59 + PeriodEndDate.GetHashCode();
				if (ReportType != null)
					hashCode = hashCode * 59 + ReportType.GetHashCode();
				if (SecUniqueId != null)
					hashCode = hashCode * 59 + SecUniqueId.GetHashCode();
				if (FilingUrl != null)
					hashCode = hashCode * 59 + FilingUrl.GetHashCode();
				if (ReportUrl != null)
					hashCode = hashCode * 59 + ReportUrl.GetHashCode();
				if (InstanceUrl != null)
					hashCode = hashCode * 59 + InstanceUrl.GetHashCode();
				if (Company != null)
					hashCode = hashCode * 59 + Company.GetHashCode();
				return hashCode;
			}
		}
	}
}