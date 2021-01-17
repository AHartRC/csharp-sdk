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
	///     An organized and regulated financial market in which securities are bought and sold.
	/// </summary>
	[DataContract]
	public class StockExchange : IEquatable<StockExchange>, IValidatableObject
	{
		/// <summary>
		///     Initializes a new instance of the <see cref="StockExchange" /> class.
		/// </summary>
		/// <param name="Id">The Intrinio ID for the Stock Exchange.</param>
		/// <param name="Name">The name of the exchange.</param>
		/// <param name="Mic">The Market Identifier Code (MIC) of the exchange.</param>
		/// <param name="Acronym">The acronym of the exchange&#39;s name.</param>
		/// <param name="City">The city in which the exchange is located.</param>
		/// <param name="Country">The country in which the exchange is located.</param>
		/// <param name="CountryCode">The 2-digit code of the exchange&#39;s country.</param>
		/// <param name="Website">The website of the exchange.</param>
		/// <param name="FirstStockPriceDate">The earliest date for which Intrinio has stock prices for the exchange.</param>
		/// <param name="LastStockPriceDate">The latest date for which Intrinio has stock prices for the exchange.</param>
		public StockExchange(string Id = default, string Name = default, string Mic = default, string Acronym = default,
			string City = default, string Country = default, string CountryCode = default, string Website = default,
			DateTime? FirstStockPriceDate = default, DateTime? LastStockPriceDate = default)
		{
			this.Id = Id;
			this.Name = Name;
			this.Mic = Mic;
			this.Acronym = Acronym;
			this.City = City;
			this.Country = Country;
			this.CountryCode = CountryCode;
			this.Website = Website;
			this.FirstStockPriceDate = FirstStockPriceDate;
			this.LastStockPriceDate = LastStockPriceDate;
		}

		/// <summary>
		///     The Intrinio ID for the Stock Exchange
		/// </summary>
		/// <value>The Intrinio ID for the Stock Exchange</value>
		[DataMember(Name = "id", EmitDefaultValue = false)]
		public string Id { get; set; }

		/// <summary>
		///     The name of the exchange
		/// </summary>
		/// <value>The name of the exchange</value>
		[DataMember(Name = "name", EmitDefaultValue = false)]
		public string Name { get; set; }

		/// <summary>
		///     The Market Identifier Code (MIC) of the exchange
		/// </summary>
		/// <value>The Market Identifier Code (MIC) of the exchange</value>
		[DataMember(Name = "mic", EmitDefaultValue = false)]
		public string Mic { get; set; }

		/// <summary>
		///     The acronym of the exchange&#39;s name
		/// </summary>
		/// <value>The acronym of the exchange&#39;s name</value>
		[DataMember(Name = "acronym", EmitDefaultValue = false)]
		public string Acronym { get; set; }

		/// <summary>
		///     The city in which the exchange is located
		/// </summary>
		/// <value>The city in which the exchange is located</value>
		[DataMember(Name = "city", EmitDefaultValue = false)]
		public string City { get; set; }

		/// <summary>
		///     The country in which the exchange is located
		/// </summary>
		/// <value>The country in which the exchange is located</value>
		[DataMember(Name = "country", EmitDefaultValue = false)]
		public string Country { get; set; }

		/// <summary>
		///     The 2-digit code of the exchange&#39;s country
		/// </summary>
		/// <value>The 2-digit code of the exchange&#39;s country</value>
		[DataMember(Name = "country_code", EmitDefaultValue = false)]
		public string CountryCode { get; set; }

		/// <summary>
		///     The website of the exchange
		/// </summary>
		/// <value>The website of the exchange</value>
		[DataMember(Name = "website", EmitDefaultValue = false)]
		public string Website { get; set; }

		/// <summary>
		///     The earliest date for which Intrinio has stock prices for the exchange
		/// </summary>
		/// <value>The earliest date for which Intrinio has stock prices for the exchange</value>
		[DataMember(Name = "first_stock_price_date", EmitDefaultValue = false)]
		
		public DateTime? FirstStockPriceDate { get; set; }

		/// <summary>
		///     The latest date for which Intrinio has stock prices for the exchange
		/// </summary>
		/// <value>The latest date for which Intrinio has stock prices for the exchange</value>
		[DataMember(Name = "last_stock_price_date", EmitDefaultValue = false)]
		
		public DateTime? LastStockPriceDate { get; set; }

		/// <summary>
		///     Returns true if StockExchange instances are equal
		/// </summary>
		/// <param name="input">Instance of StockExchange to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(StockExchange input)
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
					Mic == input.Mic ||
					Mic != null &&
					Mic.Equals(input.Mic)
				) &&
				(
					Acronym == input.Acronym ||
					Acronym != null &&
					Acronym.Equals(input.Acronym)
				) &&
				(
					City == input.City ||
					City != null &&
					City.Equals(input.City)
				) &&
				(
					Country == input.Country ||
					Country != null &&
					Country.Equals(input.Country)
				) &&
				(
					CountryCode == input.CountryCode ||
					CountryCode != null &&
					CountryCode.Equals(input.CountryCode)
				) &&
				(
					Website == input.Website ||
					Website != null &&
					Website.Equals(input.Website)
				) &&
				(
					FirstStockPriceDate == input.FirstStockPriceDate ||
					FirstStockPriceDate != null &&
					FirstStockPriceDate.Equals(input.FirstStockPriceDate)
				) &&
				(
					LastStockPriceDate == input.LastStockPriceDate ||
					LastStockPriceDate != null &&
					LastStockPriceDate.Equals(input.LastStockPriceDate)
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
			sb.Append("class StockExchange {\n");
			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  Name: ").Append(Name).Append("\n");
			sb.Append("  Mic: ").Append(Mic).Append("\n");
			sb.Append("  Acronym: ").Append(Acronym).Append("\n");
			sb.Append("  City: ").Append(City).Append("\n");
			sb.Append("  Country: ").Append(Country).Append("\n");
			sb.Append("  CountryCode: ").Append(CountryCode).Append("\n");
			sb.Append("  Website: ").Append(Website).Append("\n");
			sb.Append("  FirstStockPriceDate: ").Append(FirstStockPriceDate).Append("\n");
			sb.Append("  LastStockPriceDate: ").Append(LastStockPriceDate).Append("\n");
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
			return Equals(input as StockExchange);
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
				if (Mic != null)
					hashCode = hashCode * 59 + Mic.GetHashCode();
				if (Acronym != null)
					hashCode = hashCode * 59 + Acronym.GetHashCode();
				if (City != null)
					hashCode = hashCode * 59 + City.GetHashCode();
				if (Country != null)
					hashCode = hashCode * 59 + Country.GetHashCode();
				if (CountryCode != null)
					hashCode = hashCode * 59 + CountryCode.GetHashCode();
				if (Website != null)
					hashCode = hashCode * 59 + Website.GetHashCode();
				if (FirstStockPriceDate != null)
					hashCode = hashCode * 59 + FirstStockPriceDate.GetHashCode();
				if (LastStockPriceDate != null)
					hashCode = hashCode * 59 + LastStockPriceDate.GetHashCode();
				return hashCode;
			}
		}
	}
}