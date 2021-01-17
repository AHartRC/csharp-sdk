using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json;

namespace Intrinio.SDK.Model.TechnicalValue
{
	/// <summary>
	///     The date_time, macd_histogram, macd_line, and signal_line values of a Moving Average Convergence Divergence
	///     technical indicator calculation
	/// </summary>
	[DataContract]
	public class
		MovingAverageConvergenceDivergenceTechnicalValue : IEquatable<MovingAverageConvergenceDivergenceTechnicalValue>,
			IValidatableObject
	{
		/// <summary>
		///     Initializes a new instance of the <see cref="MovingAverageConvergenceDivergenceTechnicalValue" /> class.
		/// </summary>
		/// <param name="DateTime">The date_time of the observation.</param>
		/// <param name="MacdHistogram">The histogram value of the Moving Average Convergence Divergence calculation.</param>
		/// <param name="MacdLine">The line value of the Moving Average Convergence Divergence calculation.</param>
		/// <param name="SignalLine">The signal line value of the Moving Average Convergence Divergence calculation.</param>
		public MovingAverageConvergenceDivergenceTechnicalValue(DateTime? DateTime = default,
			float? MacdHistogram = default, float? MacdLine = default, float? SignalLine = default)
		{
			this.DateTime = DateTime;
			this.MacdHistogram = MacdHistogram;
			this.MacdLine = MacdLine;
			this.SignalLine = SignalLine;
		}

		/// <summary>
		///     The date_time of the observation
		/// </summary>
		/// <value>The date_time of the observation</value>
		[DataMember(Name = "date_time", EmitDefaultValue = false)]
		public DateTime? DateTime { get; set; }

		/// <summary>
		///     The histogram value of the Moving Average Convergence Divergence calculation
		/// </summary>
		/// <value>The histogram value of the Moving Average Convergence Divergence calculation</value>
		[DataMember(Name = "macd_histogram", EmitDefaultValue = false)]
		public float? MacdHistogram { get; set; }

		/// <summary>
		///     The line value of the Moving Average Convergence Divergence calculation
		/// </summary>
		/// <value>The line value of the Moving Average Convergence Divergence calculation</value>
		[DataMember(Name = "macd_line", EmitDefaultValue = false)]
		public float? MacdLine { get; set; }

		/// <summary>
		///     The signal line value of the Moving Average Convergence Divergence calculation
		/// </summary>
		/// <value>The signal line value of the Moving Average Convergence Divergence calculation</value>
		[DataMember(Name = "signal_line", EmitDefaultValue = false)]
		public float? SignalLine { get; set; }

		/// <summary>
		///     Returns true if MovingAverageConvergenceDivergenceTechnicalValue instances are equal
		/// </summary>
		/// <param name="input">Instance of MovingAverageConvergenceDivergenceTechnicalValue to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(MovingAverageConvergenceDivergenceTechnicalValue input)
		{
			if (input == null)
				return false;

			return
				(
					DateTime == input.DateTime ||
					DateTime != null &&
					DateTime.Equals(input.DateTime)
				) &&
				(
					MacdHistogram == input.MacdHistogram ||
					MacdHistogram != null &&
					MacdHistogram.Equals(input.MacdHistogram)
				) &&
				(
					MacdLine == input.MacdLine ||
					MacdLine != null &&
					MacdLine.Equals(input.MacdLine)
				) &&
				(
					SignalLine == input.SignalLine ||
					SignalLine != null &&
					SignalLine.Equals(input.SignalLine)
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
			sb.Append("class MovingAverageConvergenceDivergenceTechnicalValue {\n");
			sb.Append("  DateTime: ").Append(DateTime).Append("\n");
			sb.Append("  MacdHistogram: ").Append(MacdHistogram).Append("\n");
			sb.Append("  MacdLine: ").Append(MacdLine).Append("\n");
			sb.Append("  SignalLine: ").Append(SignalLine).Append("\n");
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
			return Equals(input as MovingAverageConvergenceDivergenceTechnicalValue);
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
				if (DateTime != null)
					hashCode = hashCode * 59 + DateTime.GetHashCode();
				if (MacdHistogram != null)
					hashCode = hashCode * 59 + MacdHistogram.GetHashCode();
				if (MacdLine != null)
					hashCode = hashCode * 59 + MacdLine.GetHashCode();
				if (SignalLine != null)
					hashCode = hashCode * 59 + SignalLine.GetHashCode();
				return hashCode;
			}
		}
	}
}