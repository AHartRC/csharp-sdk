using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json;

namespace Intrinio.SDK.Model.TechnicalValue
{
	/// <summary>
	///     The date_time, chikou_span, kijun_sen, senkou_span_a, senkou_span_b, and tenkan_sen values of a Ichimoku Kinko Hyo
	///     technical indicator calculation
	/// </summary>
	[DataContract]
	public class IchimokuKinkoHyoTechnicalValue : IEquatable<IchimokuKinkoHyoTechnicalValue>, IValidatableObject
	{
		/// <summary>
		///     Initializes a new instance of the <see cref="IchimokuKinkoHyoTechnicalValue" /> class.
		/// </summary>
		/// <param name="DateTime">The date_time of the observation.</param>
		/// <param name="ChikouSpan">The Chikou Span (Lagging Span) value of the Ichimoku Kinko Hyo calculation.</param>
		/// <param name="KijunSen">The Kijun-sen (Base Line) value of the Ichimoku Kinko Hyo calculation.</param>
		/// <param name="SenkouSpanA">The Senkou Span A (Leading Span A) value of the Ichimoku Kinko Hyo calculation.</param>
		/// <param name="SenkouSpanB">The Senkou Span B (Leading Span B) value of the Ichimoku Kinko Hyo calculation.</param>
		/// <param name="TenkanSen">The Tenskan-sen (Conversion Line) value of the Ichimoku Kinko Hyo calculation.</param>
		public IchimokuKinkoHyoTechnicalValue(DateTime? DateTime = default, float? ChikouSpan = default,
			float? KijunSen = default, float? SenkouSpanA = default, float? SenkouSpanB = default,
			float? TenkanSen = default)
		{
			this.DateTime = DateTime;
			this.ChikouSpan = ChikouSpan;
			this.KijunSen = KijunSen;
			this.SenkouSpanA = SenkouSpanA;
			this.SenkouSpanB = SenkouSpanB;
			this.TenkanSen = TenkanSen;
		}

		/// <summary>
		///     The date_time of the observation
		/// </summary>
		/// <value>The date_time of the observation</value>
		[DataMember(Name = "date_time", EmitDefaultValue = false)]
		public DateTime? DateTime { get; set; }

		/// <summary>
		///     The Chikou Span (Lagging Span) value of the Ichimoku Kinko Hyo calculation
		/// </summary>
		/// <value>The Chikou Span (Lagging Span) value of the Ichimoku Kinko Hyo calculation</value>
		[DataMember(Name = "chikou_span", EmitDefaultValue = false)]
		public float? ChikouSpan { get; set; }

		/// <summary>
		///     The Kijun-sen (Base Line) value of the Ichimoku Kinko Hyo calculation
		/// </summary>
		/// <value>The Kijun-sen (Base Line) value of the Ichimoku Kinko Hyo calculation</value>
		[DataMember(Name = "kijun_sen", EmitDefaultValue = false)]
		public float? KijunSen { get; set; }

		/// <summary>
		///     The Senkou Span A (Leading Span A) value of the Ichimoku Kinko Hyo calculation
		/// </summary>
		/// <value>The Senkou Span A (Leading Span A) value of the Ichimoku Kinko Hyo calculation</value>
		[DataMember(Name = "senkou_span_a", EmitDefaultValue = false)]
		public float? SenkouSpanA { get; set; }

		/// <summary>
		///     The Senkou Span B (Leading Span B) value of the Ichimoku Kinko Hyo calculation
		/// </summary>
		/// <value>The Senkou Span B (Leading Span B) value of the Ichimoku Kinko Hyo calculation</value>
		[DataMember(Name = "senkou_span_b", EmitDefaultValue = false)]
		public float? SenkouSpanB { get; set; }

		/// <summary>
		///     The Tenskan-sen (Conversion Line) value of the Ichimoku Kinko Hyo calculation
		/// </summary>
		/// <value>The Tenskan-sen (Conversion Line) value of the Ichimoku Kinko Hyo calculation</value>
		[DataMember(Name = "tenkan_sen", EmitDefaultValue = false)]
		public float? TenkanSen { get; set; }

		/// <summary>
		///     Returns true if IchimokuKinkoHyoTechnicalValue instances are equal
		/// </summary>
		/// <param name="input">Instance of IchimokuKinkoHyoTechnicalValue to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(IchimokuKinkoHyoTechnicalValue input)
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
					ChikouSpan == input.ChikouSpan ||
					ChikouSpan != null &&
					ChikouSpan.Equals(input.ChikouSpan)
				) &&
				(
					KijunSen == input.KijunSen ||
					KijunSen != null &&
					KijunSen.Equals(input.KijunSen)
				) &&
				(
					SenkouSpanA == input.SenkouSpanA ||
					SenkouSpanA != null &&
					SenkouSpanA.Equals(input.SenkouSpanA)
				) &&
				(
					SenkouSpanB == input.SenkouSpanB ||
					SenkouSpanB != null &&
					SenkouSpanB.Equals(input.SenkouSpanB)
				) &&
				(
					TenkanSen == input.TenkanSen ||
					TenkanSen != null &&
					TenkanSen.Equals(input.TenkanSen)
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
			sb.Append("class IchimokuKinkoHyoTechnicalValue {\n");
			sb.Append("  DateTime: ").Append(DateTime).Append("\n");
			sb.Append("  ChikouSpan: ").Append(ChikouSpan).Append("\n");
			sb.Append("  KijunSen: ").Append(KijunSen).Append("\n");
			sb.Append("  SenkouSpanA: ").Append(SenkouSpanA).Append("\n");
			sb.Append("  SenkouSpanB: ").Append(SenkouSpanB).Append("\n");
			sb.Append("  TenkanSen: ").Append(TenkanSen).Append("\n");
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
			return Equals(input as IchimokuKinkoHyoTechnicalValue);
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
				if (ChikouSpan != null)
					hashCode = hashCode * 59 + ChikouSpan.GetHashCode();
				if (KijunSen != null)
					hashCode = hashCode * 59 + KijunSen.GetHashCode();
				if (SenkouSpanA != null)
					hashCode = hashCode * 59 + SenkouSpanA.GetHashCode();
				if (SenkouSpanB != null)
					hashCode = hashCode * 59 + SenkouSpanB.GetHashCode();
				if (TenkanSen != null)
					hashCode = hashCode * 59 + TenkanSen.GetHashCode();
				return hashCode;
			}
		}
	}
}