using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json;

namespace Intrinio.SDK.Model
{
	/// <summary>
	///     An Index representing a Standard Industrial Classification (SIC) code.
	/// </summary>
	[DataContract]
	public class SICIndex : IEquatable<SICIndex>, IValidatableObject
	{
		/// <summary>
		///     Initializes a new instance of the <see cref="SICIndex" /> class.
		/// </summary>
		/// <param name="Id">Intrinio ID for the Index.</param>
		/// <param name="Symbol">The symbol used to identify the Index.</param>
		/// <param name="Name">The name of the Index.</param>
		/// <param name="Continent">The continent of the country of focus for the Index.</param>
		/// <param name="Country">The country of focus for the Index.</param>
		public SICIndex(string Id = default, string Symbol = default, string Name = default, string Continent = default,
			string Country = default)
		{
			this.Id = Id;
			this.Symbol = Symbol;
			this.Name = Name;
			this.Continent = Continent;
			this.Country = Country;
		}

		/// <summary>
		///     Intrinio ID for the Index
		/// </summary>
		/// <value>Intrinio ID for the Index</value>
		[DataMember(Name = "id", EmitDefaultValue = false)]
		public string Id { get; set; }

		/// <summary>
		///     The symbol used to identify the Index
		/// </summary>
		/// <value>The symbol used to identify the Index</value>
		[DataMember(Name = "symbol", EmitDefaultValue = false)]
		public string Symbol { get; set; }

		/// <summary>
		///     The name of the Index
		/// </summary>
		/// <value>The name of the Index</value>
		[DataMember(Name = "name", EmitDefaultValue = false)]
		public string Name { get; set; }

		/// <summary>
		///     The continent of the country of focus for the Index
		/// </summary>
		/// <value>The continent of the country of focus for the Index</value>
		[DataMember(Name = "continent", EmitDefaultValue = false)]
		public string Continent { get; set; }

		/// <summary>
		///     The country of focus for the Index
		/// </summary>
		/// <value>The country of focus for the Index</value>
		[DataMember(Name = "country", EmitDefaultValue = false)]
		public string Country { get; set; }

		/// <summary>
		///     Returns true if SICIndex instances are equal
		/// </summary>
		/// <param name="input">Instance of SICIndex to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(SICIndex input)
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
					Symbol == input.Symbol ||
					Symbol != null &&
					Symbol.Equals(input.Symbol)
				) &&
				(
					Name == input.Name ||
					Name != null &&
					Name.Equals(input.Name)
				) &&
				(
					Continent == input.Continent ||
					Continent != null &&
					Continent.Equals(input.Continent)
				) &&
				(
					Country == input.Country ||
					Country != null &&
					Country.Equals(input.Country)
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
			sb.Append("class SICIndex {\n");
			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  Symbol: ").Append(Symbol).Append("\n");
			sb.Append("  Name: ").Append(Name).Append("\n");
			sb.Append("  Continent: ").Append(Continent).Append("\n");
			sb.Append("  Country: ").Append(Country).Append("\n");
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
			return Equals(input as SICIndex);
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
				if (Symbol != null)
					hashCode = hashCode * 59 + Symbol.GetHashCode();
				if (Name != null)
					hashCode = hashCode * 59 + Name.GetHashCode();
				if (Continent != null)
					hashCode = hashCode * 59 + Continent.GetHashCode();
				if (Country != null)
					hashCode = hashCode * 59 + Country.GetHashCode();
				return hashCode;
			}
		}
	}
}