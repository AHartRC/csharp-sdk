using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json;

namespace Intrinio.SDK.Model
{
	/// <summary>
	///     Zacks long term growth rates from analysts for thousands of stocks.  Zacks storied research team aggregates and
	///     validates the estimates.  Each Growth Rate includes metadata about the corresponding Security.
	/// </summary>
	[DataContract]
	public class ZacksLongTermGrowthRate : IEquatable<ZacksLongTermGrowthRate>, IValidatableObject
	{
		/// <summary>
		///     Initializes a new instance of the <see cref="ZacksLongTermGrowthRate" /> class.
		/// </summary>
		/// <param name="Mean">The mean long term growth estimate.</param>
		/// <param name="Median">The median long term growth estimate.</param>
		/// <param name="Count">The number of long term growth estimates.</param>
		/// <param name="High">The high long term growth estimate.</param>
		/// <param name="Low">The low long term growth estimate.</param>
		/// <param name="StdDev">The standard deviation long term growth estimate.</param>
		/// <param name="RevisionsUpward">The number of long term growth estimate revisions upward.</param>
		/// <param name="RevisionsDownward">The number of long term growth estimate revisions downward.</param>
		/// <param name="Mean7DaysAgo">The mean long term growth estimate 7 days ago.</param>
		/// <param name="Mean30DaysAgo">The mean long term growth estimate 30 days ago.</param>
		/// <param name="Mean60DaysAgo">The mean long term growth estimate 60 days ago.</param>
		/// <param name="Mean90DaysAgo">The mean long term growth estimate 90 days ago.</param>
		/// <param name="RevisionsUpwardLast7Days">The number of long term growth estimate revisions upward in the last 7 days.</param>
		/// <param name="RevisionsDownwardLast7Days">The number of long term growth estimate revisions downward in the last 7 days.</param>
		/// <param name="RevisionsUpwardLast30Days">The number of long term growth estimate revisions upward in the last 30 days.</param>
		/// <param name="RevisionsDownwardLast30Days">
		///     The number of long term growth estimate revisions downward in the last 30
		///     days.
		/// </param>
		/// <param name="RevisionsUpwardLast60Days">The number of long term growth estimate revisions upward in the last 60 days.</param>
		/// <param name="RevisionsDownwardLast60Days">
		///     The number of long term growth estimate revisions downward in the last 60
		///     days.
		/// </param>
		/// <param name="RevisionsUpwardLast90Days">The number of long term growth estimate revisions upward in the last 90 days.</param>
		/// <param name="RevisionsDownwardLast90Days">
		///     The number of long term growth estimate revisions downward in the last 90
		///     days.
		/// </param>
		/// <param name="RevisionsUpwardLast120Days">The number of long term growth estimate revisions upward in the last 120 days.</param>
		/// <param name="RevisionsDownwardLast120Days">
		///     The number of long term growth estimate revisions downward in the last 120
		///     days.
		/// </param>
		/// <param name="RevisionsUpwardLast150Days">The number of long term growth estimate revisions upward in the last 150 days.</param>
		/// <param name="RevisionsDownwardLast150Days">
		///     The number of long term growth estimate revisions downward in the last 150
		///     days.
		/// </param>
		/// <param name="Security">The Security of the Zacks long term growth estimate.</param>
		public ZacksLongTermGrowthRate(decimal? Mean = default, decimal? Median = default, int? Count = default,
			decimal? High = default, decimal? Low = default, string StdDev = default, int? RevisionsUpward = default,
			int? RevisionsDownward = default, string Mean7DaysAgo = default, string Mean30DaysAgo = default,
			string Mean60DaysAgo = default, string Mean90DaysAgo = default, string RevisionsUpwardLast7Days = default,
			string RevisionsDownwardLast7Days = default, string RevisionsUpwardLast30Days = default,
			string RevisionsDownwardLast30Days = default, string RevisionsUpwardLast60Days = default,
			string RevisionsDownwardLast60Days = default, string RevisionsUpwardLast90Days = default,
			string RevisionsDownwardLast90Days = default, string RevisionsUpwardLast120Days = default,
			string RevisionsDownwardLast120Days = default, string RevisionsUpwardLast150Days = default,
			string RevisionsDownwardLast150Days = default, SecuritySummary Security = default)
		{
			this.Mean = Mean;
			this.Median = Median;
			this.Count = Count;
			this.High = High;
			this.Low = Low;
			this.StdDev = StdDev;
			this.RevisionsUpward = RevisionsUpward;
			this.RevisionsDownward = RevisionsDownward;
			this.Mean7DaysAgo = Mean7DaysAgo;
			this.Mean30DaysAgo = Mean30DaysAgo;
			this.Mean60DaysAgo = Mean60DaysAgo;
			this.Mean90DaysAgo = Mean90DaysAgo;
			this.RevisionsUpwardLast7Days = RevisionsUpwardLast7Days;
			this.RevisionsDownwardLast7Days = RevisionsDownwardLast7Days;
			this.RevisionsUpwardLast30Days = RevisionsUpwardLast30Days;
			this.RevisionsDownwardLast30Days = RevisionsDownwardLast30Days;
			this.RevisionsUpwardLast60Days = RevisionsUpwardLast60Days;
			this.RevisionsDownwardLast60Days = RevisionsDownwardLast60Days;
			this.RevisionsUpwardLast90Days = RevisionsUpwardLast90Days;
			this.RevisionsDownwardLast90Days = RevisionsDownwardLast90Days;
			this.RevisionsUpwardLast120Days = RevisionsUpwardLast120Days;
			this.RevisionsDownwardLast120Days = RevisionsDownwardLast120Days;
			this.RevisionsUpwardLast150Days = RevisionsUpwardLast150Days;
			this.RevisionsDownwardLast150Days = RevisionsDownwardLast150Days;
			this.Security = Security;
		}

		/// <summary>
		///     The mean long term growth estimate
		/// </summary>
		/// <value>The mean long term growth estimate</value>
		[DataMember(Name = "mean", EmitDefaultValue = false)]
		public decimal? Mean { get; set; }

		/// <summary>
		///     The median long term growth estimate
		/// </summary>
		/// <value>The median long term growth estimate</value>
		[DataMember(Name = "median", EmitDefaultValue = false)]
		public decimal? Median { get; set; }

		/// <summary>
		///     The number of long term growth estimates
		/// </summary>
		/// <value>The number of long term growth estimates</value>
		[DataMember(Name = "count", EmitDefaultValue = false)]
		public int? Count { get; set; }

		/// <summary>
		///     The high long term growth estimate
		/// </summary>
		/// <value>The high long term growth estimate</value>
		[DataMember(Name = "high", EmitDefaultValue = false)]
		public decimal? High { get; set; }

		/// <summary>
		///     The low long term growth estimate
		/// </summary>
		/// <value>The low long term growth estimate</value>
		[DataMember(Name = "low", EmitDefaultValue = false)]
		public decimal? Low { get; set; }

		/// <summary>
		///     The standard deviation long term growth estimate
		/// </summary>
		/// <value>The standard deviation long term growth estimate</value>
		[DataMember(Name = "std_dev", EmitDefaultValue = false)]
		public string StdDev { get; set; }

		/// <summary>
		///     The number of long term growth estimate revisions upward
		/// </summary>
		/// <value>The number of long term growth estimate revisions upward</value>
		[DataMember(Name = "revisions_upward", EmitDefaultValue = false)]
		public int? RevisionsUpward { get; set; }

		/// <summary>
		///     The number of long term growth estimate revisions downward
		/// </summary>
		/// <value>The number of long term growth estimate revisions downward</value>
		[DataMember(Name = "revisions_downward", EmitDefaultValue = false)]
		public int? RevisionsDownward { get; set; }

		/// <summary>
		///     The mean long term growth estimate 7 days ago
		/// </summary>
		/// <value>The mean long term growth estimate 7 days ago</value>
		[DataMember(Name = "mean_7_days_ago", EmitDefaultValue = false)]
		public string Mean7DaysAgo { get; set; }

		/// <summary>
		///     The mean long term growth estimate 30 days ago
		/// </summary>
		/// <value>The mean long term growth estimate 30 days ago</value>
		[DataMember(Name = "mean_30_days_ago", EmitDefaultValue = false)]
		public string Mean30DaysAgo { get; set; }

		/// <summary>
		///     The mean long term growth estimate 60 days ago
		/// </summary>
		/// <value>The mean long term growth estimate 60 days ago</value>
		[DataMember(Name = "mean_60_days_ago", EmitDefaultValue = false)]
		public string Mean60DaysAgo { get; set; }

		/// <summary>
		///     The mean long term growth estimate 90 days ago
		/// </summary>
		/// <value>The mean long term growth estimate 90 days ago</value>
		[DataMember(Name = "mean_90_days_ago", EmitDefaultValue = false)]
		public string Mean90DaysAgo { get; set; }

		/// <summary>
		///     The number of long term growth estimate revisions upward in the last 7 days
		/// </summary>
		/// <value>The number of long term growth estimate revisions upward in the last 7 days</value>
		[DataMember(Name = "revisions_upward_last_7_days", EmitDefaultValue = false)]
		public string RevisionsUpwardLast7Days { get; set; }

		/// <summary>
		///     The number of long term growth estimate revisions downward in the last 7 days
		/// </summary>
		/// <value>The number of long term growth estimate revisions downward in the last 7 days</value>
		[DataMember(Name = "revisions_downward_last_7_days", EmitDefaultValue = false)]
		public string RevisionsDownwardLast7Days { get; set; }

		/// <summary>
		///     The number of long term growth estimate revisions upward in the last 30 days
		/// </summary>
		/// <value>The number of long term growth estimate revisions upward in the last 30 days</value>
		[DataMember(Name = "revisions_upward_last_30_days", EmitDefaultValue = false)]
		public string RevisionsUpwardLast30Days { get; set; }

		/// <summary>
		///     The number of long term growth estimate revisions downward in the last 30 days
		/// </summary>
		/// <value>The number of long term growth estimate revisions downward in the last 30 days</value>
		[DataMember(Name = "revisions_downward_last_30_days", EmitDefaultValue = false)]
		public string RevisionsDownwardLast30Days { get; set; }

		/// <summary>
		///     The number of long term growth estimate revisions upward in the last 60 days
		/// </summary>
		/// <value>The number of long term growth estimate revisions upward in the last 60 days</value>
		[DataMember(Name = "revisions_upward_last_60_days", EmitDefaultValue = false)]
		public string RevisionsUpwardLast60Days { get; set; }

		/// <summary>
		///     The number of long term growth estimate revisions downward in the last 60 days
		/// </summary>
		/// <value>The number of long term growth estimate revisions downward in the last 60 days</value>
		[DataMember(Name = "revisions_downward_last_60_days", EmitDefaultValue = false)]
		public string RevisionsDownwardLast60Days { get; set; }

		/// <summary>
		///     The number of long term growth estimate revisions upward in the last 90 days
		/// </summary>
		/// <value>The number of long term growth estimate revisions upward in the last 90 days</value>
		[DataMember(Name = "revisions_upward_last_90_days", EmitDefaultValue = false)]
		public string RevisionsUpwardLast90Days { get; set; }

		/// <summary>
		///     The number of long term growth estimate revisions downward in the last 90 days
		/// </summary>
		/// <value>The number of long term growth estimate revisions downward in the last 90 days</value>
		[DataMember(Name = "revisions_downward_last_90_days", EmitDefaultValue = false)]
		public string RevisionsDownwardLast90Days { get; set; }

		/// <summary>
		///     The number of long term growth estimate revisions upward in the last 120 days
		/// </summary>
		/// <value>The number of long term growth estimate revisions upward in the last 120 days</value>
		[DataMember(Name = "revisions_upward_last_120_days", EmitDefaultValue = false)]
		public string RevisionsUpwardLast120Days { get; set; }

		/// <summary>
		///     The number of long term growth estimate revisions downward in the last 120 days
		/// </summary>
		/// <value>The number of long term growth estimate revisions downward in the last 120 days</value>
		[DataMember(Name = "revisions_downward_last_120_days", EmitDefaultValue = false)]
		public string RevisionsDownwardLast120Days { get; set; }

		/// <summary>
		///     The number of long term growth estimate revisions upward in the last 150 days
		/// </summary>
		/// <value>The number of long term growth estimate revisions upward in the last 150 days</value>
		[DataMember(Name = "revisions_upward_last_150_days", EmitDefaultValue = false)]
		public string RevisionsUpwardLast150Days { get; set; }

		/// <summary>
		///     The number of long term growth estimate revisions downward in the last 150 days
		/// </summary>
		/// <value>The number of long term growth estimate revisions downward in the last 150 days</value>
		[DataMember(Name = "revisions_downward_last_150_days", EmitDefaultValue = false)]
		public string RevisionsDownwardLast150Days { get; set; }

		/// <summary>
		///     The Security of the Zacks long term growth estimate
		/// </summary>
		/// <value>The Security of the Zacks long term growth estimate</value>
		[DataMember(Name = "security", EmitDefaultValue = false)]
		public SecuritySummary Security { get; set; }

		/// <summary>
		///     Returns true if ZacksLongTermGrowthRate instances are equal
		/// </summary>
		/// <param name="input">Instance of ZacksLongTermGrowthRate to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(ZacksLongTermGrowthRate input)
		{
			if (input == null)
				return false;

			return
				(
					Mean == input.Mean ||
					Mean != null &&
					Mean.Equals(input.Mean)
				) &&
				(
					Median == input.Median ||
					Median != null &&
					Median.Equals(input.Median)
				) &&
				(
					Count == input.Count ||
					Count != null &&
					Count.Equals(input.Count)
				) &&
				(
					High == input.High ||
					High != null &&
					High.Equals(input.High)
				) &&
				(
					Low == input.Low ||
					Low != null &&
					Low.Equals(input.Low)
				) &&
				(
					StdDev == input.StdDev ||
					StdDev != null &&
					StdDev.Equals(input.StdDev)
				) &&
				(
					RevisionsUpward == input.RevisionsUpward ||
					RevisionsUpward != null &&
					RevisionsUpward.Equals(input.RevisionsUpward)
				) &&
				(
					RevisionsDownward == input.RevisionsDownward ||
					RevisionsDownward != null &&
					RevisionsDownward.Equals(input.RevisionsDownward)
				) &&
				(
					Mean7DaysAgo == input.Mean7DaysAgo ||
					Mean7DaysAgo != null &&
					Mean7DaysAgo.Equals(input.Mean7DaysAgo)
				) &&
				(
					Mean30DaysAgo == input.Mean30DaysAgo ||
					Mean30DaysAgo != null &&
					Mean30DaysAgo.Equals(input.Mean30DaysAgo)
				) &&
				(
					Mean60DaysAgo == input.Mean60DaysAgo ||
					Mean60DaysAgo != null &&
					Mean60DaysAgo.Equals(input.Mean60DaysAgo)
				) &&
				(
					Mean90DaysAgo == input.Mean90DaysAgo ||
					Mean90DaysAgo != null &&
					Mean90DaysAgo.Equals(input.Mean90DaysAgo)
				) &&
				(
					RevisionsUpwardLast7Days == input.RevisionsUpwardLast7Days ||
					RevisionsUpwardLast7Days != null &&
					RevisionsUpwardLast7Days.Equals(input.RevisionsUpwardLast7Days)
				) &&
				(
					RevisionsDownwardLast7Days == input.RevisionsDownwardLast7Days ||
					RevisionsDownwardLast7Days != null &&
					RevisionsDownwardLast7Days.Equals(input.RevisionsDownwardLast7Days)
				) &&
				(
					RevisionsUpwardLast30Days == input.RevisionsUpwardLast30Days ||
					RevisionsUpwardLast30Days != null &&
					RevisionsUpwardLast30Days.Equals(input.RevisionsUpwardLast30Days)
				) &&
				(
					RevisionsDownwardLast30Days == input.RevisionsDownwardLast30Days ||
					RevisionsDownwardLast30Days != null &&
					RevisionsDownwardLast30Days.Equals(input.RevisionsDownwardLast30Days)
				) &&
				(
					RevisionsUpwardLast60Days == input.RevisionsUpwardLast60Days ||
					RevisionsUpwardLast60Days != null &&
					RevisionsUpwardLast60Days.Equals(input.RevisionsUpwardLast60Days)
				) &&
				(
					RevisionsDownwardLast60Days == input.RevisionsDownwardLast60Days ||
					RevisionsDownwardLast60Days != null &&
					RevisionsDownwardLast60Days.Equals(input.RevisionsDownwardLast60Days)
				) &&
				(
					RevisionsUpwardLast90Days == input.RevisionsUpwardLast90Days ||
					RevisionsUpwardLast90Days != null &&
					RevisionsUpwardLast90Days.Equals(input.RevisionsUpwardLast90Days)
				) &&
				(
					RevisionsDownwardLast90Days == input.RevisionsDownwardLast90Days ||
					RevisionsDownwardLast90Days != null &&
					RevisionsDownwardLast90Days.Equals(input.RevisionsDownwardLast90Days)
				) &&
				(
					RevisionsUpwardLast120Days == input.RevisionsUpwardLast120Days ||
					RevisionsUpwardLast120Days != null &&
					RevisionsUpwardLast120Days.Equals(input.RevisionsUpwardLast120Days)
				) &&
				(
					RevisionsDownwardLast120Days == input.RevisionsDownwardLast120Days ||
					RevisionsDownwardLast120Days != null &&
					RevisionsDownwardLast120Days.Equals(input.RevisionsDownwardLast120Days)
				) &&
				(
					RevisionsUpwardLast150Days == input.RevisionsUpwardLast150Days ||
					RevisionsUpwardLast150Days != null &&
					RevisionsUpwardLast150Days.Equals(input.RevisionsUpwardLast150Days)
				) &&
				(
					RevisionsDownwardLast150Days == input.RevisionsDownwardLast150Days ||
					RevisionsDownwardLast150Days != null &&
					RevisionsDownwardLast150Days.Equals(input.RevisionsDownwardLast150Days)
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
			sb.Append("class ZacksLongTermGrowthRate {\n");
			sb.Append("  Mean: ").Append(Mean).Append("\n");
			sb.Append("  Median: ").Append(Median).Append("\n");
			sb.Append("  Count: ").Append(Count).Append("\n");
			sb.Append("  High: ").Append(High).Append("\n");
			sb.Append("  Low: ").Append(Low).Append("\n");
			sb.Append("  StdDev: ").Append(StdDev).Append("\n");
			sb.Append("  RevisionsUpward: ").Append(RevisionsUpward).Append("\n");
			sb.Append("  RevisionsDownward: ").Append(RevisionsDownward).Append("\n");
			sb.Append("  Mean7DaysAgo: ").Append(Mean7DaysAgo).Append("\n");
			sb.Append("  Mean30DaysAgo: ").Append(Mean30DaysAgo).Append("\n");
			sb.Append("  Mean60DaysAgo: ").Append(Mean60DaysAgo).Append("\n");
			sb.Append("  Mean90DaysAgo: ").Append(Mean90DaysAgo).Append("\n");
			sb.Append("  RevisionsUpwardLast7Days: ").Append(RevisionsUpwardLast7Days).Append("\n");
			sb.Append("  RevisionsDownwardLast7Days: ").Append(RevisionsDownwardLast7Days).Append("\n");
			sb.Append("  RevisionsUpwardLast30Days: ").Append(RevisionsUpwardLast30Days).Append("\n");
			sb.Append("  RevisionsDownwardLast30Days: ").Append(RevisionsDownwardLast30Days).Append("\n");
			sb.Append("  RevisionsUpwardLast60Days: ").Append(RevisionsUpwardLast60Days).Append("\n");
			sb.Append("  RevisionsDownwardLast60Days: ").Append(RevisionsDownwardLast60Days).Append("\n");
			sb.Append("  RevisionsUpwardLast90Days: ").Append(RevisionsUpwardLast90Days).Append("\n");
			sb.Append("  RevisionsDownwardLast90Days: ").Append(RevisionsDownwardLast90Days).Append("\n");
			sb.Append("  RevisionsUpwardLast120Days: ").Append(RevisionsUpwardLast120Days).Append("\n");
			sb.Append("  RevisionsDownwardLast120Days: ").Append(RevisionsDownwardLast120Days).Append("\n");
			sb.Append("  RevisionsUpwardLast150Days: ").Append(RevisionsUpwardLast150Days).Append("\n");
			sb.Append("  RevisionsDownwardLast150Days: ").Append(RevisionsDownwardLast150Days).Append("\n");
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
			return Equals(input as ZacksLongTermGrowthRate);
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
				if (Mean != null)
					hashCode = hashCode * 59 + Mean.GetHashCode();
				if (Median != null)
					hashCode = hashCode * 59 + Median.GetHashCode();
				if (Count != null)
					hashCode = hashCode * 59 + Count.GetHashCode();
				if (High != null)
					hashCode = hashCode * 59 + High.GetHashCode();
				if (Low != null)
					hashCode = hashCode * 59 + Low.GetHashCode();
				if (StdDev != null)
					hashCode = hashCode * 59 + StdDev.GetHashCode();
				if (RevisionsUpward != null)
					hashCode = hashCode * 59 + RevisionsUpward.GetHashCode();
				if (RevisionsDownward != null)
					hashCode = hashCode * 59 + RevisionsDownward.GetHashCode();
				if (Mean7DaysAgo != null)
					hashCode = hashCode * 59 + Mean7DaysAgo.GetHashCode();
				if (Mean30DaysAgo != null)
					hashCode = hashCode * 59 + Mean30DaysAgo.GetHashCode();
				if (Mean60DaysAgo != null)
					hashCode = hashCode * 59 + Mean60DaysAgo.GetHashCode();
				if (Mean90DaysAgo != null)
					hashCode = hashCode * 59 + Mean90DaysAgo.GetHashCode();
				if (RevisionsUpwardLast7Days != null)
					hashCode = hashCode * 59 + RevisionsUpwardLast7Days.GetHashCode();
				if (RevisionsDownwardLast7Days != null)
					hashCode = hashCode * 59 + RevisionsDownwardLast7Days.GetHashCode();
				if (RevisionsUpwardLast30Days != null)
					hashCode = hashCode * 59 + RevisionsUpwardLast30Days.GetHashCode();
				if (RevisionsDownwardLast30Days != null)
					hashCode = hashCode * 59 + RevisionsDownwardLast30Days.GetHashCode();
				if (RevisionsUpwardLast60Days != null)
					hashCode = hashCode * 59 + RevisionsUpwardLast60Days.GetHashCode();
				if (RevisionsDownwardLast60Days != null)
					hashCode = hashCode * 59 + RevisionsDownwardLast60Days.GetHashCode();
				if (RevisionsUpwardLast90Days != null)
					hashCode = hashCode * 59 + RevisionsUpwardLast90Days.GetHashCode();
				if (RevisionsDownwardLast90Days != null)
					hashCode = hashCode * 59 + RevisionsDownwardLast90Days.GetHashCode();
				if (RevisionsUpwardLast120Days != null)
					hashCode = hashCode * 59 + RevisionsUpwardLast120Days.GetHashCode();
				if (RevisionsDownwardLast120Days != null)
					hashCode = hashCode * 59 + RevisionsDownwardLast120Days.GetHashCode();
				if (RevisionsUpwardLast150Days != null)
					hashCode = hashCode * 59 + RevisionsUpwardLast150Days.GetHashCode();
				if (RevisionsDownwardLast150Days != null)
					hashCode = hashCode * 59 + RevisionsDownwardLast150Days.GetHashCode();
				if (Security != null)
					hashCode = hashCode * 59 + Security.GetHashCode();
				return hashCode;
			}
		}
	}
}