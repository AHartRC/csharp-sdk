using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using Intrinio.SDK.Client;
using Intrinio.SDK.Enumerator;

namespace Intrinio.SDK.Model
{
	/// <summary>
	///     An earnings record for the identifier
	/// </summary>
	[DataContract]
	public class EarningsRecord : IEquatable<EarningsRecord>, IValidatableObject
	{
		/// <summary>
		///     Initializes a new instance of the <see cref="EarningsRecord" /> class.
		/// </summary>
		/// <param name="Quarter">The letter “Q” followed by the quarter number the earnings information applies to.</param>
		/// <param name="TimeOfDay">Indicates the time of the announcement.</param>
		/// <param name="BroadcastUrl">Link for Conference Call recording.</param>
		/// <param name="TranscriptUrl">Link to the earnings release transcript.</param>
		/// <param name="TranscriptQuarter">The letter “Q” followed by the quarter number the earnings transcript applies to.</param>
		/// <param name="TranscriptFiscalYear">Fiscal year in YYYY format for the earnings transcript.</param>
		/// <param name="ConferenceCallDate">Date of the conference call.</param>
		/// <param name="ConferenceCallTime">Published time of the conference call.</param>
		/// <param name="ConferenceCallPhoneNumber">Publicly available phone number for replay conference call.</param>
		/// <param name="ConferenceCallPasscode">Passcode for replay conference call.</param>
		/// <param name="LastConfirmationDate">Date of last earnings date update by a WSH analyst.</param>
		/// <param name="BoardOfDirectorsMeetingDate">Date of Board/Shareholder Meeting.</param>
		/// <param name="BoardOfDirectorsMeetingType">
		///     The type of meeting - \&quot;B\&quot; indicates a Board of Directors meeting
		///     and \&quot;S\&quot; indicates a Shareholder meeting.
		/// </param>
		/// <param name="CompanyWebsite">Website link for the company.</param>
		/// <param name="Q1Date">Earnings Date for 1st quarter.</param>
		/// <param name="Q2Date">Earnings Date for 2nd quarter.</param>
		/// <param name="Q3Date">Earnings Date for 3rd quarter.</param>
		/// <param name="Q4Date">Earnings Date for 4th quarter.</param>
		/// <param name="Type">
		///     The nature of the next reported earnings date - \&quot;V\&quot; indicates a Verified date, \&quot;T\
		///     &quot; indicates that the date was gathered from the company, but is still considered Tentative, and \&quot;I\
		///     &quot; indicates that the date is forecased or Inferred.
		/// </param>
		/// <param name="NextEarningsDate">Next earnings date.</param>
		/// <param name="NextEarningsQuarter">The quarter of the next earnings release.</param>
		/// <param name="NextEarningsFiscalYear">The fiscal year associated with next earnings date and next earnings quarter.</param>
		/// <param name="PreliminaryEarningsDate">The release date of a preliminary earnings report.</param>
		/// <param name="Security">Security.</param>
		public EarningsRecord(string Quarter = default, EarningsTimeOfDayEnum? TimeOfDay = default,
			string BroadcastUrl = default, string TranscriptUrl = default, string TranscriptQuarter = default,
			string TranscriptFiscalYear = default, DateTime? ConferenceCallDate = default,
			string ConferenceCallTime = default, string ConferenceCallPhoneNumber = default,
			string ConferenceCallPasscode = default, DateTime? LastConfirmationDate = default,
			DateTime? BoardOfDirectorsMeetingDate = default,
			EarningsBoardOfDirectorsMeetingTypeEnum? BoardOfDirectorsMeetingType = default, string CompanyWebsite = default,
			DateTime? Q1Date = default, DateTime? Q2Date = default, DateTime? Q3Date = default,
			DateTime? Q4Date = default, EarningsTypeEnum? Type = default, DateTime? NextEarningsDate = default,
			string NextEarningsQuarter = default, int? NextEarningsFiscalYear = default,
			DateTime? PreliminaryEarningsDate = default, SecuritySummary Security = default)
		{
			this.Quarter = Quarter;
			this.TimeOfDay = TimeOfDay;
			this.BroadcastUrl = BroadcastUrl;
			this.TranscriptUrl = TranscriptUrl;
			this.TranscriptQuarter = TranscriptQuarter;
			this.TranscriptFiscalYear = TranscriptFiscalYear;
			this.ConferenceCallDate = ConferenceCallDate;
			this.ConferenceCallTime = ConferenceCallTime;
			this.ConferenceCallPhoneNumber = ConferenceCallPhoneNumber;
			this.ConferenceCallPasscode = ConferenceCallPasscode;
			this.LastConfirmationDate = LastConfirmationDate;
			this.BoardOfDirectorsMeetingDate = BoardOfDirectorsMeetingDate;
			this.BoardOfDirectorsMeetingType = BoardOfDirectorsMeetingType;
			this.CompanyWebsite = CompanyWebsite;
			this.Q1Date = Q1Date;
			this.Q2Date = Q2Date;
			this.Q3Date = Q3Date;
			this.Q4Date = Q4Date;
			this.Type = Type;
			this.NextEarningsDate = NextEarningsDate;
			this.NextEarningsQuarter = NextEarningsQuarter;
			this.NextEarningsFiscalYear = NextEarningsFiscalYear;
			this.PreliminaryEarningsDate = PreliminaryEarningsDate;
			this.Security = Security;
		}

		/// <summary>
		///     Indicates the time of the announcement
		/// </summary>
		/// <value>Indicates the time of the announcement</value>
		[DataMember(Name = "time_of_day", EmitDefaultValue = false)]
		public EarningsTimeOfDayEnum? TimeOfDay { get; set; }

		/// <summary>
		///     The type of meeting - \&quot;B\&quot; indicates a Board of Directors meeting and \&quot;S\&quot; indicates a
		///     Shareholder meeting
		/// </summary>
		/// <value>
		///     The type of meeting - \&quot;B\&quot; indicates a Board of Directors meeting and \&quot;S\&quot; indicates a
		///     Shareholder meeting
		/// </value>
		[DataMember(Name = "board_of_directors_meeting_type", EmitDefaultValue = false)]
		public EarningsBoardOfDirectorsMeetingTypeEnum? BoardOfDirectorsMeetingType { get; set; }

		/// <summary>
		///     The nature of the next reported earnings date - \&quot;V\&quot; indicates a Verified date, \&quot;T\&quot;
		///     indicates that the date was gathered from the company, but is still considered Tentative, and \&quot;I\&quot;
		///     indicates that the date is forecased or Inferred
		/// </summary>
		/// <value>
		///     The nature of the next reported earnings date - \&quot;V\&quot; indicates a Verified date, \&quot;T\&quot;
		///     indicates that the date was gathered from the company, but is still considered Tentative, and \&quot;I\&quot;
		///     indicates that the date is forecased or Inferred
		/// </value>
		[DataMember(Name = "type", EmitDefaultValue = false)]
		public EarningsTypeEnum? Type { get; set; }

		/// <summary>
		///     The letter “Q” followed by the quarter number the earnings information applies to
		/// </summary>
		/// <value>The letter “Q” followed by the quarter number the earnings information applies to</value>
		[DataMember(Name = "quarter", EmitDefaultValue = false)]
		public string Quarter { get; set; }


		/// <summary>
		///     Link for Conference Call recording
		/// </summary>
		/// <value>Link for Conference Call recording</value>
		[DataMember(Name = "broadcast_url", EmitDefaultValue = false)]
		public string BroadcastUrl { get; set; }

		/// <summary>
		///     Link to the earnings release transcript
		/// </summary>
		/// <value>Link to the earnings release transcript</value>
		[DataMember(Name = "transcript_url", EmitDefaultValue = false)]
		public string TranscriptUrl { get; set; }

		/// <summary>
		///     The letter “Q” followed by the quarter number the earnings transcript applies to
		/// </summary>
		/// <value>The letter “Q” followed by the quarter number the earnings transcript applies to</value>
		[DataMember(Name = "transcript_quarter", EmitDefaultValue = false)]
		public string TranscriptQuarter { get; set; }

		/// <summary>
		///     Fiscal year in YYYY format for the earnings transcript
		/// </summary>
		/// <value>Fiscal year in YYYY format for the earnings transcript</value>
		[DataMember(Name = "transcript_fiscal_year", EmitDefaultValue = false)]
		public string TranscriptFiscalYear { get; set; }

		/// <summary>
		///     Date of the conference call
		/// </summary>
		/// <value>Date of the conference call</value>
		[DataMember(Name = "conference_call_date", EmitDefaultValue = false)]
		
		public DateTime? ConferenceCallDate { get; set; }

		/// <summary>
		///     Published time of the conference call
		/// </summary>
		/// <value>Published time of the conference call</value>
		[DataMember(Name = "conference_call_time", EmitDefaultValue = false)]
		public string ConferenceCallTime { get; set; }

		/// <summary>
		///     Publicly available phone number for replay conference call
		/// </summary>
		/// <value>Publicly available phone number for replay conference call</value>
		[DataMember(Name = "conference_call_phone_number", EmitDefaultValue = false)]
		public string ConferenceCallPhoneNumber { get; set; }

		/// <summary>
		///     Passcode for replay conference call
		/// </summary>
		/// <value>Passcode for replay conference call</value>
		[DataMember(Name = "conference_call_passcode", EmitDefaultValue = false)]
		public string ConferenceCallPasscode { get; set; }

		/// <summary>
		///     Date of last earnings date update by a WSH analyst
		/// </summary>
		/// <value>Date of last earnings date update by a WSH analyst</value>
		[DataMember(Name = "last_confirmation_date", EmitDefaultValue = false)]
		
		public DateTime? LastConfirmationDate { get; set; }

		/// <summary>
		///     Date of Board/Shareholder Meeting
		/// </summary>
		/// <value>Date of Board/Shareholder Meeting</value>
		[DataMember(Name = "board_of_directors_meeting_date", EmitDefaultValue = false)]
		
		public DateTime? BoardOfDirectorsMeetingDate { get; set; }


		/// <summary>
		///     Website link for the company
		/// </summary>
		/// <value>Website link for the company</value>
		[DataMember(Name = "company_website", EmitDefaultValue = false)]
		public string CompanyWebsite { get; set; }

		/// <summary>
		///     Earnings Date for 1st quarter
		/// </summary>
		/// <value>Earnings Date for 1st quarter</value>
		[DataMember(Name = "q1_date", EmitDefaultValue = false)]
		
		public DateTime? Q1Date { get; set; }

		/// <summary>
		///     Earnings Date for 2nd quarter
		/// </summary>
		/// <value>Earnings Date for 2nd quarter</value>
		[DataMember(Name = "q2_date", EmitDefaultValue = false)]
		
		public DateTime? Q2Date { get; set; }

		/// <summary>
		///     Earnings Date for 3rd quarter
		/// </summary>
		/// <value>Earnings Date for 3rd quarter</value>
		[DataMember(Name = "q3_date", EmitDefaultValue = false)]
		
		public DateTime? Q3Date { get; set; }

		/// <summary>
		///     Earnings Date for 4th quarter
		/// </summary>
		/// <value>Earnings Date for 4th quarter</value>
		[DataMember(Name = "q4_date", EmitDefaultValue = false)]
		
		public DateTime? Q4Date { get; set; }


		/// <summary>
		///     Next earnings date
		/// </summary>
		/// <value>Next earnings date</value>
		[DataMember(Name = "next_earnings_date", EmitDefaultValue = false)]
		
		public DateTime? NextEarningsDate { get; set; }

		/// <summary>
		///     The quarter of the next earnings release
		/// </summary>
		/// <value>The quarter of the next earnings release</value>
		[DataMember(Name = "next_earnings_quarter", EmitDefaultValue = false)]
		public string NextEarningsQuarter { get; set; }

		/// <summary>
		///     The fiscal year associated with next earnings date and next earnings quarter
		/// </summary>
		/// <value>The fiscal year associated with next earnings date and next earnings quarter</value>
		[DataMember(Name = "next_earnings_fiscal_year", EmitDefaultValue = false)]
		public int? NextEarningsFiscalYear { get; set; }

		/// <summary>
		///     The release date of a preliminary earnings report
		/// </summary>
		/// <value>The release date of a preliminary earnings report</value>
		[DataMember(Name = "preliminary_earnings_date", EmitDefaultValue = false)]
		
		public DateTime? PreliminaryEarningsDate { get; set; }

		/// <summary>
		///     Gets or Sets Security
		/// </summary>
		[DataMember(Name = "security", EmitDefaultValue = false)]
		public SecuritySummary Security { get; set; }

		/// <summary>
		///     Returns true if EarningsRecord instances are equal
		/// </summary>
		/// <param name="input">Instance of EarningsRecord to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(EarningsRecord input)
		{
			if (input == null)
				return false;

			return
				(
					Quarter == input.Quarter ||
					Quarter != null &&
					Quarter.Equals(input.Quarter)
				) &&
				(
					TimeOfDay == input.TimeOfDay ||
					TimeOfDay != null &&
					TimeOfDay.Equals(input.TimeOfDay)
				) &&
				(
					BroadcastUrl == input.BroadcastUrl ||
					BroadcastUrl != null &&
					BroadcastUrl.Equals(input.BroadcastUrl)
				) &&
				(
					TranscriptUrl == input.TranscriptUrl ||
					TranscriptUrl != null &&
					TranscriptUrl.Equals(input.TranscriptUrl)
				) &&
				(
					TranscriptQuarter == input.TranscriptQuarter ||
					TranscriptQuarter != null &&
					TranscriptQuarter.Equals(input.TranscriptQuarter)
				) &&
				(
					TranscriptFiscalYear == input.TranscriptFiscalYear ||
					TranscriptFiscalYear != null &&
					TranscriptFiscalYear.Equals(input.TranscriptFiscalYear)
				) &&
				(
					ConferenceCallDate == input.ConferenceCallDate ||
					ConferenceCallDate != null &&
					ConferenceCallDate.Equals(input.ConferenceCallDate)
				) &&
				(
					ConferenceCallTime == input.ConferenceCallTime ||
					ConferenceCallTime != null &&
					ConferenceCallTime.Equals(input.ConferenceCallTime)
				) &&
				(
					ConferenceCallPhoneNumber == input.ConferenceCallPhoneNumber ||
					ConferenceCallPhoneNumber != null &&
					ConferenceCallPhoneNumber.Equals(input.ConferenceCallPhoneNumber)
				) &&
				(
					ConferenceCallPasscode == input.ConferenceCallPasscode ||
					ConferenceCallPasscode != null &&
					ConferenceCallPasscode.Equals(input.ConferenceCallPasscode)
				) &&
				(
					LastConfirmationDate == input.LastConfirmationDate ||
					LastConfirmationDate != null &&
					LastConfirmationDate.Equals(input.LastConfirmationDate)
				) &&
				(
					BoardOfDirectorsMeetingDate == input.BoardOfDirectorsMeetingDate ||
					BoardOfDirectorsMeetingDate != null &&
					BoardOfDirectorsMeetingDate.Equals(input.BoardOfDirectorsMeetingDate)
				) &&
				(
					BoardOfDirectorsMeetingType == input.BoardOfDirectorsMeetingType ||
					BoardOfDirectorsMeetingType != null &&
					BoardOfDirectorsMeetingType.Equals(input.BoardOfDirectorsMeetingType)
				) &&
				(
					CompanyWebsite == input.CompanyWebsite ||
					CompanyWebsite != null &&
					CompanyWebsite.Equals(input.CompanyWebsite)
				) &&
				(
					Q1Date == input.Q1Date ||
					Q1Date != null &&
					Q1Date.Equals(input.Q1Date)
				) &&
				(
					Q2Date == input.Q2Date ||
					Q2Date != null &&
					Q2Date.Equals(input.Q2Date)
				) &&
				(
					Q3Date == input.Q3Date ||
					Q3Date != null &&
					Q3Date.Equals(input.Q3Date)
				) &&
				(
					Q4Date == input.Q4Date ||
					Q4Date != null &&
					Q4Date.Equals(input.Q4Date)
				) &&
				(
					Type == input.Type ||
					Type != null &&
					Type.Equals(input.Type)
				) &&
				(
					NextEarningsDate == input.NextEarningsDate ||
					NextEarningsDate != null &&
					NextEarningsDate.Equals(input.NextEarningsDate)
				) &&
				(
					NextEarningsQuarter == input.NextEarningsQuarter ||
					NextEarningsQuarter != null &&
					NextEarningsQuarter.Equals(input.NextEarningsQuarter)
				) &&
				(
					NextEarningsFiscalYear == input.NextEarningsFiscalYear ||
					NextEarningsFiscalYear != null &&
					NextEarningsFiscalYear.Equals(input.NextEarningsFiscalYear)
				) &&
				(
					PreliminaryEarningsDate == input.PreliminaryEarningsDate ||
					PreliminaryEarningsDate != null &&
					PreliminaryEarningsDate.Equals(input.PreliminaryEarningsDate)
				) &&
				(
					Security == input.Security ||
					Security != null &&
					Security.Equals(input.Security)
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
			sb.Append("class EarningsRecord {\n");
			sb.Append("  Quarter: ").Append(Quarter).Append("\n");
			sb.Append("  TimeOfDay: ").Append(TimeOfDay).Append("\n");
			sb.Append("  BroadcastUrl: ").Append(BroadcastUrl).Append("\n");
			sb.Append("  TranscriptUrl: ").Append(TranscriptUrl).Append("\n");
			sb.Append("  TranscriptQuarter: ").Append(TranscriptQuarter).Append("\n");
			sb.Append("  TranscriptFiscalYear: ").Append(TranscriptFiscalYear).Append("\n");
			sb.Append("  ConferenceCallDate: ").Append(ConferenceCallDate).Append("\n");
			sb.Append("  ConferenceCallTime: ").Append(ConferenceCallTime).Append("\n");
			sb.Append("  ConferenceCallPhoneNumber: ").Append(ConferenceCallPhoneNumber).Append("\n");
			sb.Append("  ConferenceCallPasscode: ").Append(ConferenceCallPasscode).Append("\n");
			sb.Append("  LastConfirmationDate: ").Append(LastConfirmationDate).Append("\n");
			sb.Append("  BoardOfDirectorsMeetingDate: ").Append(BoardOfDirectorsMeetingDate).Append("\n");
			sb.Append("  BoardOfDirectorsMeetingType: ").Append(BoardOfDirectorsMeetingType).Append("\n");
			sb.Append("  CompanyWebsite: ").Append(CompanyWebsite).Append("\n");
			sb.Append("  Q1Date: ").Append(Q1Date).Append("\n");
			sb.Append("  Q2Date: ").Append(Q2Date).Append("\n");
			sb.Append("  Q3Date: ").Append(Q3Date).Append("\n");
			sb.Append("  Q4Date: ").Append(Q4Date).Append("\n");
			sb.Append("  Type: ").Append(Type).Append("\n");
			sb.Append("  NextEarningsDate: ").Append(NextEarningsDate).Append("\n");
			sb.Append("  NextEarningsQuarter: ").Append(NextEarningsQuarter).Append("\n");
			sb.Append("  NextEarningsFiscalYear: ").Append(NextEarningsFiscalYear).Append("\n");
			sb.Append("  PreliminaryEarningsDate: ").Append(PreliminaryEarningsDate).Append("\n");
			sb.Append("  Security: ").Append(Security).Append("\n");
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
			return Equals(input as EarningsRecord);
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
				if (Quarter != null)
					hashCode = hashCode * 59 + Quarter.GetHashCode();
				if (TimeOfDay != null)
					hashCode = hashCode * 59 + TimeOfDay.GetHashCode();
				if (BroadcastUrl != null)
					hashCode = hashCode * 59 + BroadcastUrl.GetHashCode();
				if (TranscriptUrl != null)
					hashCode = hashCode * 59 + TranscriptUrl.GetHashCode();
				if (TranscriptQuarter != null)
					hashCode = hashCode * 59 + TranscriptQuarter.GetHashCode();
				if (TranscriptFiscalYear != null)
					hashCode = hashCode * 59 + TranscriptFiscalYear.GetHashCode();
				if (ConferenceCallDate != null)
					hashCode = hashCode * 59 + ConferenceCallDate.GetHashCode();
				if (ConferenceCallTime != null)
					hashCode = hashCode * 59 + ConferenceCallTime.GetHashCode();
				if (ConferenceCallPhoneNumber != null)
					hashCode = hashCode * 59 + ConferenceCallPhoneNumber.GetHashCode();
				if (ConferenceCallPasscode != null)
					hashCode = hashCode * 59 + ConferenceCallPasscode.GetHashCode();
				if (LastConfirmationDate != null)
					hashCode = hashCode * 59 + LastConfirmationDate.GetHashCode();
				if (BoardOfDirectorsMeetingDate != null)
					hashCode = hashCode * 59 + BoardOfDirectorsMeetingDate.GetHashCode();
				if (BoardOfDirectorsMeetingType != null)
					hashCode = hashCode * 59 + BoardOfDirectorsMeetingType.GetHashCode();
				if (CompanyWebsite != null)
					hashCode = hashCode * 59 + CompanyWebsite.GetHashCode();
				if (Q1Date != null)
					hashCode = hashCode * 59 + Q1Date.GetHashCode();
				if (Q2Date != null)
					hashCode = hashCode * 59 + Q2Date.GetHashCode();
				if (Q3Date != null)
					hashCode = hashCode * 59 + Q3Date.GetHashCode();
				if (Q4Date != null)
					hashCode = hashCode * 59 + Q4Date.GetHashCode();
				if (Type != null)
					hashCode = hashCode * 59 + Type.GetHashCode();
				if (NextEarningsDate != null)
					hashCode = hashCode * 59 + NextEarningsDate.GetHashCode();
				if (NextEarningsQuarter != null)
					hashCode = hashCode * 59 + NextEarningsQuarter.GetHashCode();
				if (NextEarningsFiscalYear != null)
					hashCode = hashCode * 59 + NextEarningsFiscalYear.GetHashCode();
				if (PreliminaryEarningsDate != null)
					hashCode = hashCode * 59 + PreliminaryEarningsDate.GetHashCode();
				if (Security != null)
					hashCode = hashCode * 59 + Security.GetHashCode();
				return hashCode;
			}
		}
	}
}