using System;
using System.Threading.Tasks;
using Intrinio.SDK.Client;
using Intrinio.SDK.Model;
using Intrinio.SDK.Model.ApiResponse;

namespace Intrinio.SDK.Interface
{
	/// <summary>
	///     Represents a collection of functions to interact with the API endpoints
	/// </summary>
	public interface IHistoricalDataApi : IApiAccessor
	{
		#region Synchronous Operations

		/// <summary>
		///     Historical Data
		/// </summary>
		/// <remarks>
		///     Returns historical values for the given &#x60;tag&#x60; and the entity represented by the given &#x60;identifier
		///     &#x60;
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">
		///     An identifier for an entity such as a Company, Security, Index, etc (Ticker, FIGI, ISIN,
		///     CUSIP, CIK, LEI, Intrinio ID)
		/// </param>
		/// <param name="tag">
		///     An Intrinio data tag ID or code (&lt;a href&#x3D;&#39;https://data.intrinio.com/data-tags&#39;&gt;
		///     reference&lt;/a&gt;)
		/// </param>
		/// <param name="frequency">Return historical data in the given frequency (optional, default to daily)</param>
		/// <param name="type">Filter by type, when applicable (optional)</param>
		/// <param name="startDate">Get historical data on or after this date (optional)</param>
		/// <param name="endDate">Get historical date on or before this date (optional)</param>
		/// <param name="sortOrder">Sort by date &#x60;asc&#x60; or &#x60;desc&#x60; (optional, default to desc)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>ApiResponseHistoricalData</returns>
		ApiResponseHistoricalData GetHistoricalData(string identifier, string tag, string frequency = null,
			string type = null, DateTime? startDate = null, DateTime? endDate = null, string sortOrder = null,
			int? pageSize = null, string nextPage = null);

		/// <summary>
		///     Historical Data
		/// </summary>
		/// <remarks>
		///     Returns historical values for the given &#x60;tag&#x60; and the entity represented by the given &#x60;identifier
		///     &#x60;
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">
		///     An identifier for an entity such as a Company, Security, Index, etc (Ticker, FIGI, ISIN,
		///     CUSIP, CIK, LEI, Intrinio ID)
		/// </param>
		/// <param name="tag">
		///     An Intrinio data tag ID or code (&lt;a href&#x3D;&#39;https://data.intrinio.com/data-tags&#39;&gt;
		///     reference&lt;/a&gt;)
		/// </param>
		/// <param name="frequency">Return historical data in the given frequency (optional, default to daily)</param>
		/// <param name="type">Filter by type, when applicable (optional)</param>
		/// <param name="startDate">Get historical data on or after this date (optional)</param>
		/// <param name="endDate">Get historical date on or before this date (optional)</param>
		/// <param name="sortOrder">Sort by date &#x60;asc&#x60; or &#x60;desc&#x60; (optional, default to desc)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>ApiResponse of ApiResponseHistoricalData</returns>
		ApiResponse<ApiResponseHistoricalData> GetHistoricalDataWithHttpInfo(string identifier, string tag,
			string frequency = null, string type = null, DateTime? startDate = null, DateTime? endDate = null,
			string sortOrder = null, int? pageSize = null, string nextPage = null);

		#endregion Synchronous Operations

		#region Asynchronous Operations

		/// <summary>
		///     Historical Data
		/// </summary>
		/// <remarks>
		///     Returns historical values for the given &#x60;tag&#x60; and the entity represented by the given &#x60;identifier
		///     &#x60;
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">
		///     An identifier for an entity such as a Company, Security, Index, etc (Ticker, FIGI, ISIN,
		///     CUSIP, CIK, LEI, Intrinio ID)
		/// </param>
		/// <param name="tag">
		///     An Intrinio data tag ID or code (&lt;a href&#x3D;&#39;https://data.intrinio.com/data-tags&#39;&gt;
		///     reference&lt;/a&gt;)
		/// </param>
		/// <param name="frequency">Return historical data in the given frequency (optional, default to daily)</param>
		/// <param name="type">Filter by type, when applicable (optional)</param>
		/// <param name="startDate">Get historical data on or after this date (optional)</param>
		/// <param name="endDate">Get historical date on or before this date (optional)</param>
		/// <param name="sortOrder">Sort by date &#x60;asc&#x60; or &#x60;desc&#x60; (optional, default to desc)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>Task of ApiResponseHistoricalData</returns>
		Task<ApiResponseHistoricalData> GetHistoricalDataAsync(string identifier, string tag, string frequency = null,
			string type = null, DateTime? startDate = null, DateTime? endDate = null, string sortOrder = null,
			int? pageSize = null, string nextPage = null);

		/// <summary>
		///     Historical Data
		/// </summary>
		/// <remarks>
		///     Returns historical values for the given &#x60;tag&#x60; and the entity represented by the given &#x60;identifier
		///     &#x60;
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">
		///     An identifier for an entity such as a Company, Security, Index, etc (Ticker, FIGI, ISIN,
		///     CUSIP, CIK, LEI, Intrinio ID)
		/// </param>
		/// <param name="tag">
		///     An Intrinio data tag ID or code (&lt;a href&#x3D;&#39;https://data.intrinio.com/data-tags&#39;&gt;
		///     reference&lt;/a&gt;)
		/// </param>
		/// <param name="frequency">Return historical data in the given frequency (optional, default to daily)</param>
		/// <param name="type">Filter by type, when applicable (optional)</param>
		/// <param name="startDate">Get historical data on or after this date (optional)</param>
		/// <param name="endDate">Get historical date on or before this date (optional)</param>
		/// <param name="sortOrder">Sort by date &#x60;asc&#x60; or &#x60;desc&#x60; (optional, default to desc)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>Task of ApiResponse (ApiResponseHistoricalData)</returns>
		Task<ApiResponse<ApiResponseHistoricalData>> GetHistoricalDataAsyncWithHttpInfo(string identifier, string tag,
			string frequency = null, string type = null, DateTime? startDate = null, DateTime? endDate = null,
			string sortOrder = null, int? pageSize = null, string nextPage = null);

		#endregion Asynchronous Operations
	}
}