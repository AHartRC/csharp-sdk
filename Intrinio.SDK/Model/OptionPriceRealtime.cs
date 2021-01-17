using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json;
using Intrinio.SDK.Enumerator;

namespace Intrinio.SDK.Model
{
	/// <summary>
	///     An option price contains price information for a specific options contract.
	/// </summary>
	[DataContract]
	public class OptionPriceRealtime : IEquatable<OptionPriceRealtime>, IValidatableObject
	{
		/// <summary>
		///     Initializes a new instance of the <see cref="OptionPriceRealtime" /> class.
		/// </summary>
		/// <param name="Last">The price of the last trade.</param>
		/// <param name="LastSize">The size of the last trade.</param>
		/// <param name="LastTimestamp">The time of the last trade.</param>
		/// <param name="Volume">The cumulative volume of this options contract that traded that day..</param>
		/// <param name="Ask">The price of the top ask order.</param>
		/// <param name="AskSize">The size of the top ask order.</param>
		/// <param name="AskTimestamp">The timestamp of the top ask order.</param>
		/// <param name="Bid">The price of the top bid order.</param>
		/// <param name="BidSize">The size of the top bid order.</param>
		/// <param name="BidTimestamp">The time of the top bid order.</param>
		/// <param name="OpenInterest">The total number of this options contract that are still open..</param>
		/// <param name="ExerciseStyle">
		///     The exercise style of the option.  (\&quot;A\&quot; &#x3D; \&quot;American\&quot;, \&quot;
		///     E\&quot; &#x3D; \&quot;European\&quot;).
		/// </param>
		public OptionPriceRealtime(decimal? Last = default, int? LastSize = default, DateTime? LastTimestamp = default,
			int? Volume = default, decimal? Ask = default, int? AskSize = default, DateTime? AskTimestamp = default,
			decimal? Bid = default, int? BidSize = default, DateTime? BidTimestamp = default,
			int? OpenInterest = default, OptionPriceRealtimeExerciseStyleEnum? ExerciseStyle = default)
		{
			this.Last = Last;
			this.LastSize = LastSize;
			this.LastTimestamp = LastTimestamp;
			this.Volume = Volume;
			this.Ask = Ask;
			this.AskSize = AskSize;
			this.AskTimestamp = AskTimestamp;
			this.Bid = Bid;
			this.BidSize = BidSize;
			this.BidTimestamp = BidTimestamp;
			this.OpenInterest = OpenInterest;
			this.ExerciseStyle = ExerciseStyle;
		}

		/// <summary>
		///     The exercise style of the option.  (\&quot;A\&quot; &#x3D; \&quot;American\&quot;, \&quot;E\&quot; &#x3D; \&quot;
		///     European\&quot;)
		/// </summary>
		/// <value>
		///     The exercise style of the option.  (\&quot;A\&quot; &#x3D; \&quot;American\&quot;, \&quot;E\&quot; &#x3D; \
		///     &quot;European\&quot;)
		/// </value>
		[DataMember(Name = "exercise_style", EmitDefaultValue = false)]
		public OptionPriceRealtimeExerciseStyleEnum? ExerciseStyle { get; set; }

		/// <summary>
		///     The price of the last trade
		/// </summary>
		/// <value>The price of the last trade</value>
		[DataMember(Name = "last", EmitDefaultValue = false)]
		public decimal? Last { get; set; }

		/// <summary>
		///     The size of the last trade
		/// </summary>
		/// <value>The size of the last trade</value>
		[DataMember(Name = "last_size", EmitDefaultValue = false)]
		public int? LastSize { get; set; }

		/// <summary>
		///     The time of the last trade
		/// </summary>
		/// <value>The time of the last trade</value>
		[DataMember(Name = "last_timestamp", EmitDefaultValue = false)]
		public DateTime? LastTimestamp { get; set; }

		/// <summary>
		///     The cumulative volume of this options contract that traded that day.
		/// </summary>
		/// <value>The cumulative volume of this options contract that traded that day.</value>
		[DataMember(Name = "volume", EmitDefaultValue = false)]
		public int? Volume { get; set; }

		/// <summary>
		///     The price of the top ask order
		/// </summary>
		/// <value>The price of the top ask order</value>
		[DataMember(Name = "ask", EmitDefaultValue = false)]
		public decimal? Ask { get; set; }

		/// <summary>
		///     The size of the top ask order
		/// </summary>
		/// <value>The size of the top ask order</value>
		[DataMember(Name = "ask_size", EmitDefaultValue = false)]
		public int? AskSize { get; set; }

		/// <summary>
		///     The timestamp of the top ask order
		/// </summary>
		/// <value>The timestamp of the top ask order</value>
		[DataMember(Name = "ask_timestamp", EmitDefaultValue = false)]
		public DateTime? AskTimestamp { get; set; }

		/// <summary>
		///     The price of the top bid order
		/// </summary>
		/// <value>The price of the top bid order</value>
		[DataMember(Name = "bid", EmitDefaultValue = false)]
		public decimal? Bid { get; set; }

		/// <summary>
		///     The size of the top bid order
		/// </summary>
		/// <value>The size of the top bid order</value>
		[DataMember(Name = "bid_size", EmitDefaultValue = false)]
		public int? BidSize { get; set; }

		/// <summary>
		///     The time of the top bid order
		/// </summary>
		/// <value>The time of the top bid order</value>
		[DataMember(Name = "bid_timestamp", EmitDefaultValue = false)]
		public DateTime? BidTimestamp { get; set; }

		/// <summary>
		///     The total number of this options contract that are still open.
		/// </summary>
		/// <value>The total number of this options contract that are still open.</value>
		[DataMember(Name = "open_interest", EmitDefaultValue = false)]
		public int? OpenInterest { get; set; }

		/// <summary>
		///     Returns true if OptionPriceRealtime instances are equal
		/// </summary>
		/// <param name="input">Instance of OptionPriceRealtime to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(OptionPriceRealtime input)
		{
			if (input == null)
				return false;

			return
				(
					Last == input.Last ||
					Last != null &&
					Last.Equals(input.Last)
				) &&
				(
					LastSize == input.LastSize ||
					LastSize != null &&
					LastSize.Equals(input.LastSize)
				) &&
				(
					LastTimestamp == input.LastTimestamp ||
					LastTimestamp != null &&
					LastTimestamp.Equals(input.LastTimestamp)
				) &&
				(
					Volume == input.Volume ||
					Volume != null &&
					Volume.Equals(input.Volume)
				) &&
				(
					Ask == input.Ask ||
					Ask != null &&
					Ask.Equals(input.Ask)
				) &&
				(
					AskSize == input.AskSize ||
					AskSize != null &&
					AskSize.Equals(input.AskSize)
				) &&
				(
					AskTimestamp == input.AskTimestamp ||
					AskTimestamp != null &&
					AskTimestamp.Equals(input.AskTimestamp)
				) &&
				(
					Bid == input.Bid ||
					Bid != null &&
					Bid.Equals(input.Bid)
				) &&
				(
					BidSize == input.BidSize ||
					BidSize != null &&
					BidSize.Equals(input.BidSize)
				) &&
				(
					BidTimestamp == input.BidTimestamp ||
					BidTimestamp != null &&
					BidTimestamp.Equals(input.BidTimestamp)
				) &&
				(
					OpenInterest == input.OpenInterest ||
					OpenInterest != null &&
					OpenInterest.Equals(input.OpenInterest)
				) &&
				(
					ExerciseStyle == input.ExerciseStyle ||
					ExerciseStyle != null &&
					ExerciseStyle.Equals(input.ExerciseStyle)
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
			sb.Append("class OptionPriceRealtime {\n");
			sb.Append("  Last: ").Append(Last).Append("\n");
			sb.Append("  LastSize: ").Append(LastSize).Append("\n");
			sb.Append("  LastTimestamp: ").Append(LastTimestamp).Append("\n");
			sb.Append("  Volume: ").Append(Volume).Append("\n");
			sb.Append("  Ask: ").Append(Ask).Append("\n");
			sb.Append("  AskSize: ").Append(AskSize).Append("\n");
			sb.Append("  AskTimestamp: ").Append(AskTimestamp).Append("\n");
			sb.Append("  Bid: ").Append(Bid).Append("\n");
			sb.Append("  BidSize: ").Append(BidSize).Append("\n");
			sb.Append("  BidTimestamp: ").Append(BidTimestamp).Append("\n");
			sb.Append("  OpenInterest: ").Append(OpenInterest).Append("\n");
			sb.Append("  ExerciseStyle: ").Append(ExerciseStyle).Append("\n");
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
			return Equals(input as OptionPriceRealtime);
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
				if (Last != null)
					hashCode = hashCode * 59 + Last.GetHashCode();
				if (LastSize != null)
					hashCode = hashCode * 59 + LastSize.GetHashCode();
				if (LastTimestamp != null)
					hashCode = hashCode * 59 + LastTimestamp.GetHashCode();
				if (Volume != null)
					hashCode = hashCode * 59 + Volume.GetHashCode();
				if (Ask != null)
					hashCode = hashCode * 59 + Ask.GetHashCode();
				if (AskSize != null)
					hashCode = hashCode * 59 + AskSize.GetHashCode();
				if (AskTimestamp != null)
					hashCode = hashCode * 59 + AskTimestamp.GetHashCode();
				if (Bid != null)
					hashCode = hashCode * 59 + Bid.GetHashCode();
				if (BidSize != null)
					hashCode = hashCode * 59 + BidSize.GetHashCode();
				if (BidTimestamp != null)
					hashCode = hashCode * 59 + BidTimestamp.GetHashCode();
				if (OpenInterest != null)
					hashCode = hashCode * 59 + OpenInterest.GetHashCode();
				if (ExerciseStyle != null)
					hashCode = hashCode * 59 + ExerciseStyle.GetHashCode();
				return hashCode;
			}
		}
	}
}