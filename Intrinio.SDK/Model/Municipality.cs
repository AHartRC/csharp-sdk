using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json;

namespace Intrinio.SDK.Model
{
	/// <summary>
	///     A local Municipality
	/// </summary>
	[DataContract]
	public class Municipality : IEquatable<Municipality>, IValidatableObject
	{
		/// <summary>
		///     Initializes a new instance of the <see cref="Municipality" /> class.
		/// </summary>
		/// <param name="Id">The Intrinio ID for Municipality.</param>
		/// <param name="CensusId">The ID for the census.</param>
		/// <param name="GovernmentName">The government name of the Municipality.</param>
		/// <param name="GovernmentType">The type of government of the Municipality.</param>
		/// <param name="PrimaryContactType">The primary contact type of the Municipality.</param>
		/// <param name="Address1">The first line of the address.</param>
		/// <param name="Address2">The second line of the address (i.e. suite number).</param>
		/// <param name="City">The city in which the Municipality is located in.</param>
		/// <param name="State">The state in which the Municipality is located in.</param>
		/// <param name="Zip">The zip code in which the Municipality is located in.</param>
		/// <param name="WebSite">The web site of the Municipality.</param>
		/// <param name="Population">The population of the Municipality.</param>
		/// <param name="PopulationAsOfYear">The year from which the population of the Municipality was measured.</param>
		/// <param name="Enrollment">The enrollment of the Municipality.</param>
		/// <param name="EnrollmentAsOfYear">The year from which the enrollment of the Municipality was measured.</param>
		/// <param name="AreaName">The name of the area of the Municipality.</param>
		/// <param name="AreaType">The type of area of the Municipality.</param>
		/// <param name="Latitude">The latitude of the location of the Municipality.</param>
		/// <param name="Longitude">The longitude of the location of the Municipality.</param>
		public Municipality(string Id = default, decimal? CensusId = default, string GovernmentName = default,
			string GovernmentType = default, string PrimaryContactType = default, string Address1 = default,
			string Address2 = default, string City = default, string State = default, string Zip = default,
			string WebSite = default, decimal? Population = default, decimal? PopulationAsOfYear = default,
			decimal? Enrollment = default, decimal? EnrollmentAsOfYear = default, string AreaName = default,
			string AreaType = default, float? Latitude = default, float? Longitude = default)
		{
			this.Id = Id;
			this.CensusId = CensusId;
			this.GovernmentName = GovernmentName;
			this.GovernmentType = GovernmentType;
			this.PrimaryContactType = PrimaryContactType;
			this.Address1 = Address1;
			this.Address2 = Address2;
			this.City = City;
			this.State = State;
			this.Zip = Zip;
			this.WebSite = WebSite;
			this.Population = Population;
			this.PopulationAsOfYear = PopulationAsOfYear;
			this.Enrollment = Enrollment;
			this.EnrollmentAsOfYear = EnrollmentAsOfYear;
			this.AreaName = AreaName;
			this.AreaType = AreaType;
			this.Latitude = Latitude;
			this.Longitude = Longitude;
		}

		/// <summary>
		///     The Intrinio ID for Municipality
		/// </summary>
		/// <value>The Intrinio ID for Municipality</value>
		[DataMember(Name = "id", EmitDefaultValue = false)]
		public string Id { get; set; }

		/// <summary>
		///     The ID for the census
		/// </summary>
		/// <value>The ID for the census</value>
		[DataMember(Name = "census_id", EmitDefaultValue = false)]
		public decimal? CensusId { get; set; }

		/// <summary>
		///     The government name of the Municipality
		/// </summary>
		/// <value>The government name of the Municipality</value>
		[DataMember(Name = "government_name", EmitDefaultValue = false)]
		public string GovernmentName { get; set; }

		/// <summary>
		///     The type of government of the Municipality
		/// </summary>
		/// <value>The type of government of the Municipality</value>
		[DataMember(Name = "government_type", EmitDefaultValue = false)]
		public string GovernmentType { get; set; }

		/// <summary>
		///     The primary contact type of the Municipality
		/// </summary>
		/// <value>The primary contact type of the Municipality</value>
		[DataMember(Name = "primary_contact_type", EmitDefaultValue = false)]
		public string PrimaryContactType { get; set; }

		/// <summary>
		///     The first line of the address
		/// </summary>
		/// <value>The first line of the address</value>
		[DataMember(Name = "address1", EmitDefaultValue = false)]
		public string Address1 { get; set; }

		/// <summary>
		///     The second line of the address (i.e. suite number)
		/// </summary>
		/// <value>The second line of the address (i.e. suite number)</value>
		[DataMember(Name = "address2", EmitDefaultValue = false)]
		public string Address2 { get; set; }

		/// <summary>
		///     The city in which the Municipality is located in
		/// </summary>
		/// <value>The city in which the Municipality is located in</value>
		[DataMember(Name = "city", EmitDefaultValue = false)]
		public string City { get; set; }

		/// <summary>
		///     The state in which the Municipality is located in
		/// </summary>
		/// <value>The state in which the Municipality is located in</value>
		[DataMember(Name = "state", EmitDefaultValue = false)]
		public string State { get; set; }

		/// <summary>
		///     The zip code in which the Municipality is located in
		/// </summary>
		/// <value>The zip code in which the Municipality is located in</value>
		[DataMember(Name = "zip", EmitDefaultValue = false)]
		public string Zip { get; set; }

		/// <summary>
		///     The web site of the Municipality
		/// </summary>
		/// <value>The web site of the Municipality</value>
		[DataMember(Name = "web_site", EmitDefaultValue = false)]
		public string WebSite { get; set; }

		/// <summary>
		///     The population of the Municipality
		/// </summary>
		/// <value>The population of the Municipality</value>
		[DataMember(Name = "population", EmitDefaultValue = false)]
		public decimal? Population { get; set; }

		/// <summary>
		///     The year from which the population of the Municipality was measured
		/// </summary>
		/// <value>The year from which the population of the Municipality was measured</value>
		[DataMember(Name = "population_as_of_year", EmitDefaultValue = false)]
		public decimal? PopulationAsOfYear { get; set; }

		/// <summary>
		///     The enrollment of the Municipality
		/// </summary>
		/// <value>The enrollment of the Municipality</value>
		[DataMember(Name = "enrollment", EmitDefaultValue = false)]
		public decimal? Enrollment { get; set; }

		/// <summary>
		///     The year from which the enrollment of the Municipality was measured
		/// </summary>
		/// <value>The year from which the enrollment of the Municipality was measured</value>
		[DataMember(Name = "enrollment_as_of_year", EmitDefaultValue = false)]
		public decimal? EnrollmentAsOfYear { get; set; }

		/// <summary>
		///     The name of the area of the Municipality
		/// </summary>
		/// <value>The name of the area of the Municipality</value>
		[DataMember(Name = "area_name", EmitDefaultValue = false)]
		public string AreaName { get; set; }

		/// <summary>
		///     The type of area of the Municipality
		/// </summary>
		/// <value>The type of area of the Municipality</value>
		[DataMember(Name = "area_type", EmitDefaultValue = false)]
		public string AreaType { get; set; }

		/// <summary>
		///     The latitude of the location of the Municipality
		/// </summary>
		/// <value>The latitude of the location of the Municipality</value>
		[DataMember(Name = "latitude", EmitDefaultValue = false)]
		public float? Latitude { get; set; }

		/// <summary>
		///     The longitude of the location of the Municipality
		/// </summary>
		/// <value>The longitude of the location of the Municipality</value>
		[DataMember(Name = "longitude", EmitDefaultValue = false)]
		public float? Longitude { get; set; }

		/// <summary>
		///     Returns true if Municipality instances are equal
		/// </summary>
		/// <param name="input">Instance of Municipality to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(Municipality input)
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
					CensusId == input.CensusId ||
					CensusId != null &&
					CensusId.Equals(input.CensusId)
				) &&
				(
					GovernmentName == input.GovernmentName ||
					GovernmentName != null &&
					GovernmentName.Equals(input.GovernmentName)
				) &&
				(
					GovernmentType == input.GovernmentType ||
					GovernmentType != null &&
					GovernmentType.Equals(input.GovernmentType)
				) &&
				(
					PrimaryContactType == input.PrimaryContactType ||
					PrimaryContactType != null &&
					PrimaryContactType.Equals(input.PrimaryContactType)
				) &&
				(
					Address1 == input.Address1 ||
					Address1 != null &&
					Address1.Equals(input.Address1)
				) &&
				(
					Address2 == input.Address2 ||
					Address2 != null &&
					Address2.Equals(input.Address2)
				) &&
				(
					City == input.City ||
					City != null &&
					City.Equals(input.City)
				) &&
				(
					State == input.State ||
					State != null &&
					State.Equals(input.State)
				) &&
				(
					Zip == input.Zip ||
					Zip != null &&
					Zip.Equals(input.Zip)
				) &&
				(
					WebSite == input.WebSite ||
					WebSite != null &&
					WebSite.Equals(input.WebSite)
				) &&
				(
					Population == input.Population ||
					Population != null &&
					Population.Equals(input.Population)
				) &&
				(
					PopulationAsOfYear == input.PopulationAsOfYear ||
					PopulationAsOfYear != null &&
					PopulationAsOfYear.Equals(input.PopulationAsOfYear)
				) &&
				(
					Enrollment == input.Enrollment ||
					Enrollment != null &&
					Enrollment.Equals(input.Enrollment)
				) &&
				(
					EnrollmentAsOfYear == input.EnrollmentAsOfYear ||
					EnrollmentAsOfYear != null &&
					EnrollmentAsOfYear.Equals(input.EnrollmentAsOfYear)
				) &&
				(
					AreaName == input.AreaName ||
					AreaName != null &&
					AreaName.Equals(input.AreaName)
				) &&
				(
					AreaType == input.AreaType ||
					AreaType != null &&
					AreaType.Equals(input.AreaType)
				) &&
				(
					Latitude == input.Latitude ||
					Latitude != null &&
					Latitude.Equals(input.Latitude)
				) &&
				(
					Longitude == input.Longitude ||
					Longitude != null &&
					Longitude.Equals(input.Longitude)
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
			sb.Append("class Municipality {\n");
			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  CensusId: ").Append(CensusId).Append("\n");
			sb.Append("  GovernmentName: ").Append(GovernmentName).Append("\n");
			sb.Append("  GovernmentType: ").Append(GovernmentType).Append("\n");
			sb.Append("  PrimaryContactType: ").Append(PrimaryContactType).Append("\n");
			sb.Append("  Address1: ").Append(Address1).Append("\n");
			sb.Append("  Address2: ").Append(Address2).Append("\n");
			sb.Append("  City: ").Append(City).Append("\n");
			sb.Append("  State: ").Append(State).Append("\n");
			sb.Append("  Zip: ").Append(Zip).Append("\n");
			sb.Append("  WebSite: ").Append(WebSite).Append("\n");
			sb.Append("  Population: ").Append(Population).Append("\n");
			sb.Append("  PopulationAsOfYear: ").Append(PopulationAsOfYear).Append("\n");
			sb.Append("  Enrollment: ").Append(Enrollment).Append("\n");
			sb.Append("  EnrollmentAsOfYear: ").Append(EnrollmentAsOfYear).Append("\n");
			sb.Append("  AreaName: ").Append(AreaName).Append("\n");
			sb.Append("  AreaType: ").Append(AreaType).Append("\n");
			sb.Append("  Latitude: ").Append(Latitude).Append("\n");
			sb.Append("  Longitude: ").Append(Longitude).Append("\n");
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
			return Equals(input as Municipality);
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
				if (CensusId != null)
					hashCode = hashCode * 59 + CensusId.GetHashCode();
				if (GovernmentName != null)
					hashCode = hashCode * 59 + GovernmentName.GetHashCode();
				if (GovernmentType != null)
					hashCode = hashCode * 59 + GovernmentType.GetHashCode();
				if (PrimaryContactType != null)
					hashCode = hashCode * 59 + PrimaryContactType.GetHashCode();
				if (Address1 != null)
					hashCode = hashCode * 59 + Address1.GetHashCode();
				if (Address2 != null)
					hashCode = hashCode * 59 + Address2.GetHashCode();
				if (City != null)
					hashCode = hashCode * 59 + City.GetHashCode();
				if (State != null)
					hashCode = hashCode * 59 + State.GetHashCode();
				if (Zip != null)
					hashCode = hashCode * 59 + Zip.GetHashCode();
				if (WebSite != null)
					hashCode = hashCode * 59 + WebSite.GetHashCode();
				if (Population != null)
					hashCode = hashCode * 59 + Population.GetHashCode();
				if (PopulationAsOfYear != null)
					hashCode = hashCode * 59 + PopulationAsOfYear.GetHashCode();
				if (Enrollment != null)
					hashCode = hashCode * 59 + Enrollment.GetHashCode();
				if (EnrollmentAsOfYear != null)
					hashCode = hashCode * 59 + EnrollmentAsOfYear.GetHashCode();
				if (AreaName != null)
					hashCode = hashCode * 59 + AreaName.GetHashCode();
				if (AreaType != null)
					hashCode = hashCode * 59 + AreaType.GetHashCode();
				if (Latitude != null)
					hashCode = hashCode * 59 + Latitude.GetHashCode();
				if (Longitude != null)
					hashCode = hashCode * 59 + Longitude.GetHashCode();
				return hashCode;
			}
		}
	}
}