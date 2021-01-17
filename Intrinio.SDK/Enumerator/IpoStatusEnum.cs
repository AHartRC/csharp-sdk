using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace Intrinio.SDK.Enumerator
{
	/// <summary>
	///     The status of the IPO. Upcoming IPOs have not taken place yet but are expected to. Priced IPOs have taken place.
	///     Withdrawn IPOs were expected to take place, but were subsequently withdrawn and did not take place
	/// </summary>
	/// <value>
	///     The status of the IPO. Upcoming IPOs have not taken place yet but are expected to. Priced IPOs have taken place.
	///     Withdrawn IPOs were expected to take place, but were subsequently withdrawn and did not take place
	/// </value>
	// TODO This came from CompanyInitialPublicOffering.cs - Might need rename
	public enum IpoStatusEnum
	{
		/// <summary>
		///     Enum Upcoming for value: upcoming
		/// </summary>
		[EnumMember(Value = "upcoming")] Upcoming = 1,

		/// <summary>
		///     Enum Priced for value: priced
		/// </summary>
		[EnumMember(Value = "priced")] Priced = 2,

		/// <summary>
		///     Enum Withdrawn for value: withdrawn
		/// </summary>
		[EnumMember(Value = "withdrawn")] Withdrawn = 3
	}
}