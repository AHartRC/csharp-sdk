using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json;

namespace Intrinio.SDK.Model.ApiResponse
{
	/// <summary>
	///     ApiResponseOptionsStatsRealtime
	/// </summary>
	[DataContract]
	public class ApiResponseOptionsStatsRealtime : IEquatable<ApiResponseOptionsStatsRealtime>, IValidatableObject
	{
		/// <summary>
		///     Initializes a new instance of the <see cref="ApiResponseOptionsStatsRealtime" /> class.
		/// </summary>
		/// <param name="Stats">Stats.</param>
		/// <param name="Factors">Factors.</param>
		/// <param name="Option">Option.</param>
		public ApiResponseOptionsStatsRealtime(OptionStatsRealtime Stats = default,
			OptionFactorsRealtime Factors = default, OptionRealtime Option = default)
		{
			this.Stats = Stats;
			this.Factors = Factors;
			this.Option = Option;
		}

		/// <summary>
		///     Gets or Sets Stats
		/// </summary>
		[DataMember(Name = "stats", EmitDefaultValue = false)]
		public OptionStatsRealtime Stats { get; set; }

		/// <summary>
		///     Gets or Sets Factors
		/// </summary>
		[DataMember(Name = "factors", EmitDefaultValue = false)]
		public OptionFactorsRealtime Factors { get; set; }

		/// <summary>
		///     Gets or Sets Option
		/// </summary>
		[DataMember(Name = "option", EmitDefaultValue = false)]
		public OptionRealtime Option { get; set; }

		/// <summary>
		///     Returns true if ApiResponseOptionsStatsRealtime instances are equal
		/// </summary>
		/// <param name="input">Instance of ApiResponseOptionsStatsRealtime to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(ApiResponseOptionsStatsRealtime input)
		{
			if (input == null)
				return false;

			return
				(
					Stats == input.Stats ||
					Stats != null &&
					Stats.Equals(input.Stats)
				) &&
				(
					Factors == input.Factors ||
					Factors != null &&
					Factors.Equals(input.Factors)
				) &&
				(
					Option == input.Option ||
					Option != null &&
					Option.Equals(input.Option)
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
			sb.Append("class ApiResponseOptionsStatsRealtime {\n");
			sb.Append("  Stats: ").Append(Stats).Append("\n");
			sb.Append("  Factors: ").Append(Factors).Append("\n");
			sb.Append("  Option: ").Append(Option).Append("\n");
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
			return Equals(input as ApiResponseOptionsStatsRealtime);
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
				if (Stats != null)
					hashCode = hashCode * 59 + Stats.GetHashCode();
				if (Factors != null)
					hashCode = hashCode * 59 + Factors.GetHashCode();
				if (Option != null)
					hashCode = hashCode * 59 + Option.GetHashCode();
				return hashCode;
			}
		}
	}
}