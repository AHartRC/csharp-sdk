using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json;

namespace Intrinio.SDK.Model
{
	/// <summary>
	///     A Forex Price
	/// </summary>
	[DataContract]
	public class ForexPrice : IEquatable<ForexPrice>, IValidatableObject
	{
		/// <summary>
		///     Initializes a new instance of the <see cref="ForexPrice" /> class.
		/// </summary>
		/// <param name="OccurredAt">
		///     The timestamp of the beginning of the timeframe. The open prices would be at this time, while
		///     close prices would be at this time plus the timeframe..
		/// </param>
		/// <param name="OpenBid">Open bid.</param>
		/// <param name="HighBid">High bid.</param>
		/// <param name="LowBid">Low bid.</param>
		/// <param name="CloseBid">Close bid.</param>
		/// <param name="OpenAsk">Open ask.</param>
		/// <param name="HighAsk">High ask.</param>
		/// <param name="LowAsk">Low ask.</param>
		/// <param name="CloseAsk">Close ask.</param>
		/// <param name="TotalTicks">Total ticks.</param>
		public ForexPrice(string OccurredAt = default, float? OpenBid = default, float? HighBid = default,
			float? LowBid = default, float? CloseBid = default, float? OpenAsk = default, float? HighAsk = default,
			float? LowAsk = default, float? CloseAsk = default, int? TotalTicks = default)
		{
			this.OccurredAt = OccurredAt;
			this.OpenBid = OpenBid;
			this.HighBid = HighBid;
			this.LowBid = LowBid;
			this.CloseBid = CloseBid;
			this.OpenAsk = OpenAsk;
			this.HighAsk = HighAsk;
			this.LowAsk = LowAsk;
			this.CloseAsk = CloseAsk;
			this.TotalTicks = TotalTicks;
		}

		/// <summary>
		///     The timestamp of the beginning of the timeframe. The open prices would be at this time, while close prices would be
		///     at this time plus the timeframe.
		/// </summary>
		/// <value>
		///     The timestamp of the beginning of the timeframe. The open prices would be at this time, while close prices would
		///     be at this time plus the timeframe.
		/// </value>
		[DataMember(Name = "occurred_at", EmitDefaultValue = false)]
		public string OccurredAt { get; set; }

		/// <summary>
		///     Open bid
		/// </summary>
		/// <value>Open bid</value>
		[DataMember(Name = "open_bid", EmitDefaultValue = false)]
		public float? OpenBid { get; set; }

		/// <summary>
		///     High bid
		/// </summary>
		/// <value>High bid</value>
		[DataMember(Name = "high_bid", EmitDefaultValue = false)]
		public float? HighBid { get; set; }

		/// <summary>
		///     Low bid
		/// </summary>
		/// <value>Low bid</value>
		[DataMember(Name = "low_bid", EmitDefaultValue = false)]
		public float? LowBid { get; set; }

		/// <summary>
		///     Close bid
		/// </summary>
		/// <value>Close bid</value>
		[DataMember(Name = "close_bid", EmitDefaultValue = false)]
		public float? CloseBid { get; set; }

		/// <summary>
		///     Open ask
		/// </summary>
		/// <value>Open ask</value>
		[DataMember(Name = "open_ask", EmitDefaultValue = false)]
		public float? OpenAsk { get; set; }

		/// <summary>
		///     High ask
		/// </summary>
		/// <value>High ask</value>
		[DataMember(Name = "high_ask", EmitDefaultValue = false)]
		public float? HighAsk { get; set; }

		/// <summary>
		///     Low ask
		/// </summary>
		/// <value>Low ask</value>
		[DataMember(Name = "low_ask", EmitDefaultValue = false)]
		public float? LowAsk { get; set; }

		/// <summary>
		///     Close ask
		/// </summary>
		/// <value>Close ask</value>
		[DataMember(Name = "close_ask", EmitDefaultValue = false)]
		public float? CloseAsk { get; set; }

		/// <summary>
		///     Total ticks
		/// </summary>
		/// <value>Total ticks</value>
		[DataMember(Name = "total_ticks", EmitDefaultValue = false)]
		public int? TotalTicks { get; set; }

		/// <summary>
		///     Returns true if ForexPrice instances are equal
		/// </summary>
		/// <param name="input">Instance of ForexPrice to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(ForexPrice input)
		{
			if (input == null)
				return false;

			return
				(
					OccurredAt == input.OccurredAt ||
					OccurredAt != null &&
					OccurredAt.Equals(input.OccurredAt)
				) &&
				(
					OpenBid == input.OpenBid ||
					OpenBid != null &&
					OpenBid.Equals(input.OpenBid)
				) &&
				(
					HighBid == input.HighBid ||
					HighBid != null &&
					HighBid.Equals(input.HighBid)
				) &&
				(
					LowBid == input.LowBid ||
					LowBid != null &&
					LowBid.Equals(input.LowBid)
				) &&
				(
					CloseBid == input.CloseBid ||
					CloseBid != null &&
					CloseBid.Equals(input.CloseBid)
				) &&
				(
					OpenAsk == input.OpenAsk ||
					OpenAsk != null &&
					OpenAsk.Equals(input.OpenAsk)
				) &&
				(
					HighAsk == input.HighAsk ||
					HighAsk != null &&
					HighAsk.Equals(input.HighAsk)
				) &&
				(
					LowAsk == input.LowAsk ||
					LowAsk != null &&
					LowAsk.Equals(input.LowAsk)
				) &&
				(
					CloseAsk == input.CloseAsk ||
					CloseAsk != null &&
					CloseAsk.Equals(input.CloseAsk)
				) &&
				(
					TotalTicks == input.TotalTicks ||
					TotalTicks != null &&
					TotalTicks.Equals(input.TotalTicks)
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
			sb.Append("class ForexPrice {\n");
			sb.Append("  OccurredAt: ").Append(OccurredAt).Append("\n");
			sb.Append("  OpenBid: ").Append(OpenBid).Append("\n");
			sb.Append("  HighBid: ").Append(HighBid).Append("\n");
			sb.Append("  LowBid: ").Append(LowBid).Append("\n");
			sb.Append("  CloseBid: ").Append(CloseBid).Append("\n");
			sb.Append("  OpenAsk: ").Append(OpenAsk).Append("\n");
			sb.Append("  HighAsk: ").Append(HighAsk).Append("\n");
			sb.Append("  LowAsk: ").Append(LowAsk).Append("\n");
			sb.Append("  CloseAsk: ").Append(CloseAsk).Append("\n");
			sb.Append("  TotalTicks: ").Append(TotalTicks).Append("\n");
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
			return Equals(input as ForexPrice);
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
				if (OccurredAt != null)
					hashCode = hashCode * 59 + OccurredAt.GetHashCode();
				if (OpenBid != null)
					hashCode = hashCode * 59 + OpenBid.GetHashCode();
				if (HighBid != null)
					hashCode = hashCode * 59 + HighBid.GetHashCode();
				if (LowBid != null)
					hashCode = hashCode * 59 + LowBid.GetHashCode();
				if (CloseBid != null)
					hashCode = hashCode * 59 + CloseBid.GetHashCode();
				if (OpenAsk != null)
					hashCode = hashCode * 59 + OpenAsk.GetHashCode();
				if (HighAsk != null)
					hashCode = hashCode * 59 + HighAsk.GetHashCode();
				if (LowAsk != null)
					hashCode = hashCode * 59 + LowAsk.GetHashCode();
				if (CloseAsk != null)
					hashCode = hashCode * 59 + CloseAsk.GetHashCode();
				if (TotalTicks != null)
					hashCode = hashCode * 59 + TotalTicks.GetHashCode();
				return hashCode;
			}
		}
	}
}