using System;
using System.Threading.Tasks;
using Intrinio.SDK.Client;
using Intrinio.SDK.Model;
using Intrinio.SDK.Model.ApiResponse;
using Intrinio.SDK.Model.Search;

namespace Intrinio.SDK.Interface
{
	/// <summary>
	///     Represents a collection of functions to interact with the API endpoints
	/// </summary>
	public interface IIndexApi : IApiAccessor
	{
		#region Synchronous Operations

		/// <summary>
		///     All Economic Indices
		/// </summary>
		/// <remarks>
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>ApiResponseEconomicIndices</returns>
		ApiResponseEconomicIndices GetAllEconomicIndices(int? pageSize = null, string nextPage = null);

		/// <summary>
		///     All Economic Indices
		/// </summary>
		/// <remarks>
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>ApiResponse of ApiResponseEconomicIndices</returns>
		ApiResponse<ApiResponseEconomicIndices> GetAllEconomicIndicesWithHttpInfo(int? pageSize = null,
			string nextPage = null);

		/// <summary>
		///     All SIC Indices
		/// </summary>
		/// <remarks>
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>ApiResponseSICIndices</returns>
		ApiResponseSICIndices GetAllSicIndices(int? pageSize = null, string nextPage = null);

		/// <summary>
		///     All SIC Indices
		/// </summary>
		/// <remarks>
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>ApiResponse of ApiResponseSICIndices</returns>
		ApiResponse<ApiResponseSICIndices> GetAllSicIndicesWithHttpInfo(int? pageSize = null, string nextPage = null);

		/// <summary>
		///     All Stock Market Indices
		/// </summary>
		/// <remarks>
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>ApiResponseStockMarketIndices</returns>
		ApiResponseStockMarketIndices GetAllStockMarketIndices(int? pageSize = null, string nextPage = null);

		/// <summary>
		///     All Stock Market Indices
		/// </summary>
		/// <remarks>
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>ApiResponse of ApiResponseStockMarketIndices</returns>
		ApiResponse<ApiResponseStockMarketIndices> GetAllStockMarketIndicesWithHttpInfo(int? pageSize = null,
			string nextPage = null);

		/// <summary>
		///     Lookup Economic Index
		/// </summary>
		/// <remarks>
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">An Index Identifier (symbol, Intrinio ID)</param>
		/// <returns>EconomicIndex</returns>
		EconomicIndex GetEconomicIndexById(string identifier);

		/// <summary>
		///     Lookup Economic Index
		/// </summary>
		/// <remarks>
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">An Index Identifier (symbol, Intrinio ID)</param>
		/// <returns>ApiResponse of EconomicIndex</returns>
		ApiResponse<EconomicIndex> GetEconomicIndexByIdWithHttpInfo(string identifier);

		/// <summary>
		///     Data Point (Number) for an Economic Index
		/// </summary>
		/// <remarks>
		///     Returns a numeric value for the given &#x60;tag&#x60; for the Economic Index with the given &#x60;identifier&#x60;
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">An Index Identifier (symbol, Intrinio ID)</param>
		/// <param name="tag">
		///     An Intrinio data tag &lt;a href&#x3D;&#39;https://data.intrinio.com/data-tags/economic&#39;&gt;
		///     reference&lt;/a&gt;
		/// </param>
		/// <returns>decimal?</returns>
		decimal? GetEconomicIndexDataPointNumber(string identifier, string tag);

		/// <summary>
		///     Data Point (Number) for an Economic Index
		/// </summary>
		/// <remarks>
		///     Returns a numeric value for the given &#x60;tag&#x60; for the Economic Index with the given &#x60;identifier&#x60;
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">An Index Identifier (symbol, Intrinio ID)</param>
		/// <param name="tag">
		///     An Intrinio data tag &lt;a href&#x3D;&#39;https://data.intrinio.com/data-tags/economic&#39;&gt;
		///     reference&lt;/a&gt;
		/// </param>
		/// <returns>ApiResponse of decimal?</returns>
		ApiResponse<decimal?> GetEconomicIndexDataPointNumberWithHttpInfo(string identifier, string tag);

		/// <summary>
		///     Data Point (Text) for an Economic Index
		/// </summary>
		/// <remarks>
		///     Returns a text value for the given &#x60;tag&#x60; for the Economic Index with the given &#x60;identifier&#x60;
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">An Index Identifier (symbol, Intrinio ID)</param>
		/// <param name="tag">An Intrinio data tag ID or code-name</param>
		/// <returns>string</returns>
		string GetEconomicIndexDataPointText(string identifier, string tag);

		/// <summary>
		///     Data Point (Text) for an Economic Index
		/// </summary>
		/// <remarks>
		///     Returns a text value for the given &#x60;tag&#x60; for the Economic Index with the given &#x60;identifier&#x60;
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">An Index Identifier (symbol, Intrinio ID)</param>
		/// <param name="tag">An Intrinio data tag ID or code-name</param>
		/// <returns>ApiResponse of string</returns>
		ApiResponse<string> GetEconomicIndexDataPointTextWithHttpInfo(string identifier, string tag);

		/// <summary>
		///     Historical Data for an Economic Index
		/// </summary>
		/// <remarks>
		///     Returns historical values for the given &#x60;tag&#x60; and the Economic Index with the given &#x60;identifier
		///     &#x60;
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">An Index Identifier (symbol, Intrinio ID)</param>
		/// <param name="tag">
		///     An Intrinio data tag &lt;a href&#x3D;&#39;https://data.intrinio.com/data-tags/economic&#39;&gt;
		///     reference&lt;/a&gt;
		/// </param>
		/// <param name="type">Filter by type, when applicable (optional)</param>
		/// <param name="startDate">Get historical data on or after this date (optional)</param>
		/// <param name="endDate">Get historical data on or before this date (optional)</param>
		/// <param name="sortOrder">Sort by date &#x60;asc&#x60; or &#x60;desc&#x60; (optional, default to desc)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>ApiResponseEconomicIndexHistoricalData</returns>
		ApiResponseEconomicIndexHistoricalData GetEconomicIndexHistoricalData(string identifier, string tag,
			string type = null, DateTime? startDate = null, DateTime? endDate = null, string sortOrder = null,
			int? pageSize = null, string nextPage = null);

		/// <summary>
		///     Historical Data for an Economic Index
		/// </summary>
		/// <remarks>
		///     Returns historical values for the given &#x60;tag&#x60; and the Economic Index with the given &#x60;identifier
		///     &#x60;
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">An Index Identifier (symbol, Intrinio ID)</param>
		/// <param name="tag">
		///     An Intrinio data tag &lt;a href&#x3D;&#39;https://data.intrinio.com/data-tags/economic&#39;&gt;
		///     reference&lt;/a&gt;
		/// </param>
		/// <param name="type">Filter by type, when applicable (optional)</param>
		/// <param name="startDate">Get historical data on or after this date (optional)</param>
		/// <param name="endDate">Get historical data on or before this date (optional)</param>
		/// <param name="sortOrder">Sort by date &#x60;asc&#x60; or &#x60;desc&#x60; (optional, default to desc)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>ApiResponse of ApiResponseEconomicIndexHistoricalData</returns>
		ApiResponse<ApiResponseEconomicIndexHistoricalData> GetEconomicIndexHistoricalDataWithHttpInfo(
			string identifier, string tag, string type = null, DateTime? startDate = null, DateTime? endDate = null,
			string sortOrder = null, int? pageSize = null, string nextPage = null);

		/// <summary>
		///     Lookup SIC Index
		/// </summary>
		/// <remarks>
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">An Index Identifier (symbol, Intrinio ID)</param>
		/// <returns>SICIndex</returns>
		SICIndex GetSicIndexById(string identifier);

		/// <summary>
		///     Lookup SIC Index
		/// </summary>
		/// <remarks>
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">An Index Identifier (symbol, Intrinio ID)</param>
		/// <returns>ApiResponse of SICIndex</returns>
		ApiResponse<SICIndex> GetSicIndexByIdWithHttpInfo(string identifier);

		/// <summary>
		///     Data Point (Number) for an SIC Index
		/// </summary>
		/// <remarks>
		///     Returns a numeric value for the given &#x60;tag&#x60; for the SIC Index with the given &#x60;identifier&#x60;
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">An Index Identifier (symbol, Intrinio ID)</param>
		/// <param name="tag">An Intrinio data tag ID or code-name</param>
		/// <returns>decimal?</returns>
		decimal? GetSicIndexDataPointNumber(string identifier, string tag);

		/// <summary>
		///     Data Point (Number) for an SIC Index
		/// </summary>
		/// <remarks>
		///     Returns a numeric value for the given &#x60;tag&#x60; for the SIC Index with the given &#x60;identifier&#x60;
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">An Index Identifier (symbol, Intrinio ID)</param>
		/// <param name="tag">An Intrinio data tag ID or code-name</param>
		/// <returns>ApiResponse of decimal?</returns>
		ApiResponse<decimal?> GetSicIndexDataPointNumberWithHttpInfo(string identifier, string tag);

		/// <summary>
		///     Data Point (Text) for an SIC Index
		/// </summary>
		/// <remarks>
		///     Returns a text value for the given &#x60;tag&#x60; for the SIC Index with the given &#x60;identifier&#x60;
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">An Index Identifier (symbol, Intrinio ID)</param>
		/// <param name="tag">An Intrinio data tag ID or code-name</param>
		/// <returns>string</returns>
		string GetSicIndexDataPointText(string identifier, string tag);

		/// <summary>
		///     Data Point (Text) for an SIC Index
		/// </summary>
		/// <remarks>
		///     Returns a text value for the given &#x60;tag&#x60; for the SIC Index with the given &#x60;identifier&#x60;
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">An Index Identifier (symbol, Intrinio ID)</param>
		/// <param name="tag">An Intrinio data tag ID or code-name</param>
		/// <returns>ApiResponse of string</returns>
		ApiResponse<string> GetSicIndexDataPointTextWithHttpInfo(string identifier, string tag);

		/// <summary>
		///     Historical Data for an SIC Index
		/// </summary>
		/// <remarks>
		///     Returns historical values for the given &#x60;tag&#x60; and the SIC Index with the given &#x60;identifier&#x60;
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">An Index Identifier (symbol, Intrinio ID)</param>
		/// <param name="tag">An Intrinio data tag ID or code-name</param>
		/// <param name="type">Filter by type, when applicable (optional)</param>
		/// <param name="startDate">Get historical data on or after this date (optional)</param>
		/// <param name="endDate">Get historical data on or before this date (optional)</param>
		/// <param name="sortOrder">Sort by date &#x60;asc&#x60; or &#x60;desc&#x60; (optional, default to desc)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>ApiResponseSICIndexHistoricalData</returns>
		ApiResponseSICIndexHistoricalData GetSicIndexHistoricalData(string identifier, string tag, string type = null,
			DateTime? startDate = null, DateTime? endDate = null, string sortOrder = null, int? pageSize = null,
			string nextPage = null);

		/// <summary>
		///     Historical Data for an SIC Index
		/// </summary>
		/// <remarks>
		///     Returns historical values for the given &#x60;tag&#x60; and the SIC Index with the given &#x60;identifier&#x60;
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">An Index Identifier (symbol, Intrinio ID)</param>
		/// <param name="tag">An Intrinio data tag ID or code-name</param>
		/// <param name="type">Filter by type, when applicable (optional)</param>
		/// <param name="startDate">Get historical data on or after this date (optional)</param>
		/// <param name="endDate">Get historical data on or before this date (optional)</param>
		/// <param name="sortOrder">Sort by date &#x60;asc&#x60; or &#x60;desc&#x60; (optional, default to desc)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>ApiResponse of ApiResponseSICIndexHistoricalData</returns>
		ApiResponse<ApiResponseSICIndexHistoricalData> GetSicIndexHistoricalDataWithHttpInfo(string identifier,
			string tag, string type = null, DateTime? startDate = null, DateTime? endDate = null,
			string sortOrder = null, int? pageSize = null, string nextPage = null);

		/// <summary>
		///     Lookup Stock Market Index
		/// </summary>
		/// <remarks>
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">An Index Identifier (symbol, Intrinio ID)</param>
		/// <returns>StockMarketIndex</returns>
		StockMarketIndex GetStockMarketIndexById(string identifier);

		/// <summary>
		///     Lookup Stock Market Index
		/// </summary>
		/// <remarks>
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">An Index Identifier (symbol, Intrinio ID)</param>
		/// <returns>ApiResponse of StockMarketIndex</returns>
		ApiResponse<StockMarketIndex> GetStockMarketIndexByIdWithHttpInfo(string identifier);

		/// <summary>
		///     Data Point (Number) for Stock Market Index
		/// </summary>
		/// <remarks>
		///     Returns a numeric value for the given &#x60;tag&#x60; for the Stock Market Index with the given &#x60;identifier
		///     &#x60;
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">An Index Identifier (symbol, Intrinio ID)</param>
		/// <param name="tag">An Intrinio data tag ID or code-name</param>
		/// <returns>decimal?</returns>
		decimal? GetStockMarketIndexDataPointNumber(string identifier, string tag);

		/// <summary>
		///     Data Point (Number) for Stock Market Index
		/// </summary>
		/// <remarks>
		///     Returns a numeric value for the given &#x60;tag&#x60; for the Stock Market Index with the given &#x60;identifier
		///     &#x60;
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">An Index Identifier (symbol, Intrinio ID)</param>
		/// <param name="tag">An Intrinio data tag ID or code-name</param>
		/// <returns>ApiResponse of decimal?</returns>
		ApiResponse<decimal?> GetStockMarketIndexDataPointNumberWithHttpInfo(string identifier, string tag);

		/// <summary>
		///     Data Point (Text) for Stock Market Index
		/// </summary>
		/// <remarks>
		///     Returns a text value for the given &#x60;tag&#x60; for the Stock Market Index with the given &#x60;identifier&#x60;
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">An Index Identifier (symbol, Intrinio ID)</param>
		/// <param name="tag">An Intrinio data tag ID or code-name</param>
		/// <returns>string</returns>
		string GetStockMarketIndexDataPointText(string identifier, string tag);

		/// <summary>
		///     Data Point (Text) for Stock Market Index
		/// </summary>
		/// <remarks>
		///     Returns a text value for the given &#x60;tag&#x60; for the Stock Market Index with the given &#x60;identifier&#x60;
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">An Index Identifier (symbol, Intrinio ID)</param>
		/// <param name="tag">An Intrinio data tag ID or code-name</param>
		/// <returns>ApiResponse of string</returns>
		ApiResponse<string> GetStockMarketIndexDataPointTextWithHttpInfo(string identifier, string tag);

		/// <summary>
		///     Historical Data for Stock Market Index
		/// </summary>
		/// <remarks>
		///     Returns historical values for the given &#x60;tag&#x60; and the Stock Market Index with the given &#x60;identifier
		///     &#x60;
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">An Index Identifier (symbol, Intrinio ID)</param>
		/// <param name="tag">An Intrinio data tag ID or code-name</param>
		/// <param name="type">Filter by type, when applicable (optional)</param>
		/// <param name="startDate">Get historical data on or after this date (optional)</param>
		/// <param name="endDate">Get historical data on or before this date (optional)</param>
		/// <param name="sortOrder">Sort by date &#x60;asc&#x60; or &#x60;desc&#x60; (optional, default to desc)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>ApiResponseStockMarketIndexHistoricalData</returns>
		ApiResponseStockMarketIndexHistoricalData GetStockMarketIndexHistoricalData(string identifier, string tag,
			string type = null, DateTime? startDate = null, DateTime? endDate = null, string sortOrder = null,
			int? pageSize = null, string nextPage = null);

		/// <summary>
		///     Historical Data for Stock Market Index
		/// </summary>
		/// <remarks>
		///     Returns historical values for the given &#x60;tag&#x60; and the Stock Market Index with the given &#x60;identifier
		///     &#x60;
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">An Index Identifier (symbol, Intrinio ID)</param>
		/// <param name="tag">An Intrinio data tag ID or code-name</param>
		/// <param name="type">Filter by type, when applicable (optional)</param>
		/// <param name="startDate">Get historical data on or after this date (optional)</param>
		/// <param name="endDate">Get historical data on or before this date (optional)</param>
		/// <param name="sortOrder">Sort by date &#x60;asc&#x60; or &#x60;desc&#x60; (optional, default to desc)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>ApiResponse of ApiResponseStockMarketIndexHistoricalData</returns>
		ApiResponse<ApiResponseStockMarketIndexHistoricalData> GetStockMarketIndexHistoricalDataWithHttpInfo(
			string identifier, string tag, string type = null, DateTime? startDate = null, DateTime? endDate = null,
			string sortOrder = null, int? pageSize = null, string nextPage = null);

		/// <summary>
		///     Search Economic Indices
		/// </summary>
		/// <remarks>
		///     Searches for indices using the text in &#x60;query&#x60;
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="query">Search query</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <returns>ApiResponseEconomicIndicesSearch</returns>
		ApiResponseEconomicIndicesSearch SearchEconomicIndices(string query, int? pageSize = null);

		/// <summary>
		///     Search Economic Indices
		/// </summary>
		/// <remarks>
		///     Searches for indices using the text in &#x60;query&#x60;
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="query">Search query</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <returns>ApiResponse of ApiResponseEconomicIndicesSearch</returns>
		ApiResponse<ApiResponseEconomicIndicesSearch> SearchEconomicIndicesWithHttpInfo(string query,
			int? pageSize = null);

		/// <summary>
		///     Search SIC Indices
		/// </summary>
		/// <remarks>
		///     Searches for indices using the text in &#x60;query&#x60;
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="query">Search query</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <returns>ApiResponseSICIndicesSearch</returns>
		ApiResponseSICIndicesSearch SearchSicIndices(string query, int? pageSize = null);

		/// <summary>
		///     Search SIC Indices
		/// </summary>
		/// <remarks>
		///     Searches for indices using the text in &#x60;query&#x60;
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="query">Search query</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <returns>ApiResponse of ApiResponseSICIndicesSearch</returns>
		ApiResponse<ApiResponseSICIndicesSearch> SearchSicIndicesWithHttpInfo(string query, int? pageSize = null);

		/// <summary>
		///     Search Stock Market Indices
		/// </summary>
		/// <remarks>
		///     Searches for indices using the text in &#x60;query&#x60;
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="query">Search query</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <returns>ApiResponseStockMarketIndicesSearch</returns>
		ApiResponseStockMarketIndicesSearch SearchStockMarketsIndices(string query, int? pageSize = null);

		/// <summary>
		///     Search Stock Market Indices
		/// </summary>
		/// <remarks>
		///     Searches for indices using the text in &#x60;query&#x60;
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="query">Search query</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <returns>ApiResponse of ApiResponseStockMarketIndicesSearch</returns>
		ApiResponse<ApiResponseStockMarketIndicesSearch> SearchStockMarketsIndicesWithHttpInfo(string query,
			int? pageSize = null);

		#endregion Synchronous Operations

		#region Asynchronous Operations

		/// <summary>
		///     All Economic Indices
		/// </summary>
		/// <remarks>
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>Task of ApiResponseEconomicIndices</returns>
		Task<ApiResponseEconomicIndices> GetAllEconomicIndicesAsync(int? pageSize = null, string nextPage = null);

		/// <summary>
		///     All Economic Indices
		/// </summary>
		/// <remarks>
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>Task of ApiResponse (ApiResponseEconomicIndices)</returns>
		Task<ApiResponse<ApiResponseEconomicIndices>> GetAllEconomicIndicesAsyncWithHttpInfo(int? pageSize = null,
			string nextPage = null);

		/// <summary>
		///     All SIC Indices
		/// </summary>
		/// <remarks>
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>Task of ApiResponseSICIndices</returns>
		Task<ApiResponseSICIndices> GetAllSicIndicesAsync(int? pageSize = null, string nextPage = null);

		/// <summary>
		///     All SIC Indices
		/// </summary>
		/// <remarks>
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>Task of ApiResponse (ApiResponseSICIndices)</returns>
		Task<ApiResponse<ApiResponseSICIndices>> GetAllSicIndicesAsyncWithHttpInfo(int? pageSize = null,
			string nextPage = null);

		/// <summary>
		///     All Stock Market Indices
		/// </summary>
		/// <remarks>
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>Task of ApiResponseStockMarketIndices</returns>
		Task<ApiResponseStockMarketIndices> GetAllStockMarketIndicesAsync(int? pageSize = null, string nextPage = null);

		/// <summary>
		///     All Stock Market Indices
		/// </summary>
		/// <remarks>
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>Task of ApiResponse (ApiResponseStockMarketIndices)</returns>
		Task<ApiResponse<ApiResponseStockMarketIndices>> GetAllStockMarketIndicesAsyncWithHttpInfo(int? pageSize = null,
			string nextPage = null);

		/// <summary>
		///     Lookup Economic Index
		/// </summary>
		/// <remarks>
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">An Index Identifier (symbol, Intrinio ID)</param>
		/// <returns>Task of EconomicIndex</returns>
		Task<EconomicIndex> GetEconomicIndexByIdAsync(string identifier);

		/// <summary>
		///     Lookup Economic Index
		/// </summary>
		/// <remarks>
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">An Index Identifier (symbol, Intrinio ID)</param>
		/// <returns>Task of ApiResponse (EconomicIndex)</returns>
		Task<ApiResponse<EconomicIndex>> GetEconomicIndexByIdAsyncWithHttpInfo(string identifier);

		/// <summary>
		///     Data Point (Number) for an Economic Index
		/// </summary>
		/// <remarks>
		///     Returns a numeric value for the given &#x60;tag&#x60; for the Economic Index with the given &#x60;identifier&#x60;
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">An Index Identifier (symbol, Intrinio ID)</param>
		/// <param name="tag">
		///     An Intrinio data tag &lt;a href&#x3D;&#39;https://data.intrinio.com/data-tags/economic&#39;&gt;
		///     reference&lt;/a&gt;
		/// </param>
		/// <returns>Task of decimal?</returns>
		Task<decimal?> GetEconomicIndexDataPointNumberAsync(string identifier, string tag);

		/// <summary>
		///     Data Point (Number) for an Economic Index
		/// </summary>
		/// <remarks>
		///     Returns a numeric value for the given &#x60;tag&#x60; for the Economic Index with the given &#x60;identifier&#x60;
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">An Index Identifier (symbol, Intrinio ID)</param>
		/// <param name="tag">
		///     An Intrinio data tag &lt;a href&#x3D;&#39;https://data.intrinio.com/data-tags/economic&#39;&gt;
		///     reference&lt;/a&gt;
		/// </param>
		/// <returns>Task of ApiResponse (decimal?)</returns>
		Task<ApiResponse<decimal?>> GetEconomicIndexDataPointNumberAsyncWithHttpInfo(string identifier, string tag);

		/// <summary>
		///     Data Point (Text) for an Economic Index
		/// </summary>
		/// <remarks>
		///     Returns a text value for the given &#x60;tag&#x60; for the Economic Index with the given &#x60;identifier&#x60;
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">An Index Identifier (symbol, Intrinio ID)</param>
		/// <param name="tag">An Intrinio data tag ID or code-name</param>
		/// <returns>Task of string</returns>
		Task<string> GetEconomicIndexDataPointTextAsync(string identifier, string tag);

		/// <summary>
		///     Data Point (Text) for an Economic Index
		/// </summary>
		/// <remarks>
		///     Returns a text value for the given &#x60;tag&#x60; for the Economic Index with the given &#x60;identifier&#x60;
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">An Index Identifier (symbol, Intrinio ID)</param>
		/// <param name="tag">An Intrinio data tag ID or code-name</param>
		/// <returns>Task of ApiResponse (string)</returns>
		Task<ApiResponse<string>> GetEconomicIndexDataPointTextAsyncWithHttpInfo(string identifier, string tag);

		/// <summary>
		///     Historical Data for an Economic Index
		/// </summary>
		/// <remarks>
		///     Returns historical values for the given &#x60;tag&#x60; and the Economic Index with the given &#x60;identifier
		///     &#x60;
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">An Index Identifier (symbol, Intrinio ID)</param>
		/// <param name="tag">
		///     An Intrinio data tag &lt;a href&#x3D;&#39;https://data.intrinio.com/data-tags/economic&#39;&gt;
		///     reference&lt;/a&gt;
		/// </param>
		/// <param name="type">Filter by type, when applicable (optional)</param>
		/// <param name="startDate">Get historical data on or after this date (optional)</param>
		/// <param name="endDate">Get historical data on or before this date (optional)</param>
		/// <param name="sortOrder">Sort by date &#x60;asc&#x60; or &#x60;desc&#x60; (optional, default to desc)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>Task of ApiResponseEconomicIndexHistoricalData</returns>
		Task<ApiResponseEconomicIndexHistoricalData> GetEconomicIndexHistoricalDataAsync(string identifier, string tag,
			string type = null, DateTime? startDate = null, DateTime? endDate = null, string sortOrder = null,
			int? pageSize = null, string nextPage = null);

		/// <summary>
		///     Historical Data for an Economic Index
		/// </summary>
		/// <remarks>
		///     Returns historical values for the given &#x60;tag&#x60; and the Economic Index with the given &#x60;identifier
		///     &#x60;
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">An Index Identifier (symbol, Intrinio ID)</param>
		/// <param name="tag">
		///     An Intrinio data tag &lt;a href&#x3D;&#39;https://data.intrinio.com/data-tags/economic&#39;&gt;
		///     reference&lt;/a&gt;
		/// </param>
		/// <param name="type">Filter by type, when applicable (optional)</param>
		/// <param name="startDate">Get historical data on or after this date (optional)</param>
		/// <param name="endDate">Get historical data on or before this date (optional)</param>
		/// <param name="sortOrder">Sort by date &#x60;asc&#x60; or &#x60;desc&#x60; (optional, default to desc)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>Task of ApiResponse (ApiResponseEconomicIndexHistoricalData)</returns>
		Task<ApiResponse<ApiResponseEconomicIndexHistoricalData>> GetEconomicIndexHistoricalDataAsyncWithHttpInfo(
			string identifier, string tag, string type = null, DateTime? startDate = null, DateTime? endDate = null,
			string sortOrder = null, int? pageSize = null, string nextPage = null);

		/// <summary>
		///     Lookup SIC Index
		/// </summary>
		/// <remarks>
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">An Index Identifier (symbol, Intrinio ID)</param>
		/// <returns>Task of SICIndex</returns>
		Task<SICIndex> GetSicIndexByIdAsync(string identifier);

		/// <summary>
		///     Lookup SIC Index
		/// </summary>
		/// <remarks>
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">An Index Identifier (symbol, Intrinio ID)</param>
		/// <returns>Task of ApiResponse (SICIndex)</returns>
		Task<ApiResponse<SICIndex>> GetSicIndexByIdAsyncWithHttpInfo(string identifier);

		/// <summary>
		///     Data Point (Number) for an SIC Index
		/// </summary>
		/// <remarks>
		///     Returns a numeric value for the given &#x60;tag&#x60; for the SIC Index with the given &#x60;identifier&#x60;
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">An Index Identifier (symbol, Intrinio ID)</param>
		/// <param name="tag">An Intrinio data tag ID or code-name</param>
		/// <returns>Task of decimal?</returns>
		Task<decimal?> GetSicIndexDataPointNumberAsync(string identifier, string tag);

		/// <summary>
		///     Data Point (Number) for an SIC Index
		/// </summary>
		/// <remarks>
		///     Returns a numeric value for the given &#x60;tag&#x60; for the SIC Index with the given &#x60;identifier&#x60;
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">An Index Identifier (symbol, Intrinio ID)</param>
		/// <param name="tag">An Intrinio data tag ID or code-name</param>
		/// <returns>Task of ApiResponse (decimal?)</returns>
		Task<ApiResponse<decimal?>> GetSicIndexDataPointNumberAsyncWithHttpInfo(string identifier, string tag);

		/// <summary>
		///     Data Point (Text) for an SIC Index
		/// </summary>
		/// <remarks>
		///     Returns a text value for the given &#x60;tag&#x60; for the SIC Index with the given &#x60;identifier&#x60;
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">An Index Identifier (symbol, Intrinio ID)</param>
		/// <param name="tag">An Intrinio data tag ID or code-name</param>
		/// <returns>Task of string</returns>
		Task<string> GetSicIndexDataPointTextAsync(string identifier, string tag);

		/// <summary>
		///     Data Point (Text) for an SIC Index
		/// </summary>
		/// <remarks>
		///     Returns a text value for the given &#x60;tag&#x60; for the SIC Index with the given &#x60;identifier&#x60;
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">An Index Identifier (symbol, Intrinio ID)</param>
		/// <param name="tag">An Intrinio data tag ID or code-name</param>
		/// <returns>Task of ApiResponse (string)</returns>
		Task<ApiResponse<string>> GetSicIndexDataPointTextAsyncWithHttpInfo(string identifier, string tag);

		/// <summary>
		///     Historical Data for an SIC Index
		/// </summary>
		/// <remarks>
		///     Returns historical values for the given &#x60;tag&#x60; and the SIC Index with the given &#x60;identifier&#x60;
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">An Index Identifier (symbol, Intrinio ID)</param>
		/// <param name="tag">An Intrinio data tag ID or code-name</param>
		/// <param name="type">Filter by type, when applicable (optional)</param>
		/// <param name="startDate">Get historical data on or after this date (optional)</param>
		/// <param name="endDate">Get historical data on or before this date (optional)</param>
		/// <param name="sortOrder">Sort by date &#x60;asc&#x60; or &#x60;desc&#x60; (optional, default to desc)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>Task of ApiResponseSICIndexHistoricalData</returns>
		Task<ApiResponseSICIndexHistoricalData> GetSicIndexHistoricalDataAsync(string identifier, string tag,
			string type = null, DateTime? startDate = null, DateTime? endDate = null, string sortOrder = null,
			int? pageSize = null, string nextPage = null);

		/// <summary>
		///     Historical Data for an SIC Index
		/// </summary>
		/// <remarks>
		///     Returns historical values for the given &#x60;tag&#x60; and the SIC Index with the given &#x60;identifier&#x60;
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">An Index Identifier (symbol, Intrinio ID)</param>
		/// <param name="tag">An Intrinio data tag ID or code-name</param>
		/// <param name="type">Filter by type, when applicable (optional)</param>
		/// <param name="startDate">Get historical data on or after this date (optional)</param>
		/// <param name="endDate">Get historical data on or before this date (optional)</param>
		/// <param name="sortOrder">Sort by date &#x60;asc&#x60; or &#x60;desc&#x60; (optional, default to desc)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>Task of ApiResponse (ApiResponseSICIndexHistoricalData)</returns>
		Task<ApiResponse<ApiResponseSICIndexHistoricalData>> GetSicIndexHistoricalDataAsyncWithHttpInfo(
			string identifier, string tag, string type = null, DateTime? startDate = null, DateTime? endDate = null,
			string sortOrder = null, int? pageSize = null, string nextPage = null);

		/// <summary>
		///     Lookup Stock Market Index
		/// </summary>
		/// <remarks>
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">An Index Identifier (symbol, Intrinio ID)</param>
		/// <returns>Task of StockMarketIndex</returns>
		Task<StockMarketIndex> GetStockMarketIndexByIdAsync(string identifier);

		/// <summary>
		///     Lookup Stock Market Index
		/// </summary>
		/// <remarks>
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">An Index Identifier (symbol, Intrinio ID)</param>
		/// <returns>Task of ApiResponse (StockMarketIndex)</returns>
		Task<ApiResponse<StockMarketIndex>> GetStockMarketIndexByIdAsyncWithHttpInfo(string identifier);

		/// <summary>
		///     Data Point (Number) for Stock Market Index
		/// </summary>
		/// <remarks>
		///     Returns a numeric value for the given &#x60;tag&#x60; for the Stock Market Index with the given &#x60;identifier
		///     &#x60;
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">An Index Identifier (symbol, Intrinio ID)</param>
		/// <param name="tag">An Intrinio data tag ID or code-name</param>
		/// <returns>Task of decimal?</returns>
		Task<decimal?> GetStockMarketIndexDataPointNumberAsync(string identifier, string tag);

		/// <summary>
		///     Data Point (Number) for Stock Market Index
		/// </summary>
		/// <remarks>
		///     Returns a numeric value for the given &#x60;tag&#x60; for the Stock Market Index with the given &#x60;identifier
		///     &#x60;
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">An Index Identifier (symbol, Intrinio ID)</param>
		/// <param name="tag">An Intrinio data tag ID or code-name</param>
		/// <returns>Task of ApiResponse (decimal?)</returns>
		Task<ApiResponse<decimal?>> GetStockMarketIndexDataPointNumberAsyncWithHttpInfo(string identifier, string tag);

		/// <summary>
		///     Data Point (Text) for Stock Market Index
		/// </summary>
		/// <remarks>
		///     Returns a text value for the given &#x60;tag&#x60; for the Stock Market Index with the given &#x60;identifier&#x60;
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">An Index Identifier (symbol, Intrinio ID)</param>
		/// <param name="tag">An Intrinio data tag ID or code-name</param>
		/// <returns>Task of string</returns>
		Task<string> GetStockMarketIndexDataPointTextAsync(string identifier, string tag);

		/// <summary>
		///     Data Point (Text) for Stock Market Index
		/// </summary>
		/// <remarks>
		///     Returns a text value for the given &#x60;tag&#x60; for the Stock Market Index with the given &#x60;identifier&#x60;
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">An Index Identifier (symbol, Intrinio ID)</param>
		/// <param name="tag">An Intrinio data tag ID or code-name</param>
		/// <returns>Task of ApiResponse (string)</returns>
		Task<ApiResponse<string>> GetStockMarketIndexDataPointTextAsyncWithHttpInfo(string identifier, string tag);

		/// <summary>
		///     Historical Data for Stock Market Index
		/// </summary>
		/// <remarks>
		///     Returns historical values for the given &#x60;tag&#x60; and the Stock Market Index with the given &#x60;identifier
		///     &#x60;
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">An Index Identifier (symbol, Intrinio ID)</param>
		/// <param name="tag">An Intrinio data tag ID or code-name</param>
		/// <param name="type">Filter by type, when applicable (optional)</param>
		/// <param name="startDate">Get historical data on or after this date (optional)</param>
		/// <param name="endDate">Get historical data on or before this date (optional)</param>
		/// <param name="sortOrder">Sort by date &#x60;asc&#x60; or &#x60;desc&#x60; (optional, default to desc)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>Task of ApiResponseStockMarketIndexHistoricalData</returns>
		Task<ApiResponseStockMarketIndexHistoricalData> GetStockMarketIndexHistoricalDataAsync(string identifier,
			string tag, string type = null, DateTime? startDate = null, DateTime? endDate = null,
			string sortOrder = null, int? pageSize = null, string nextPage = null);

		/// <summary>
		///     Historical Data for Stock Market Index
		/// </summary>
		/// <remarks>
		///     Returns historical values for the given &#x60;tag&#x60; and the Stock Market Index with the given &#x60;identifier
		///     &#x60;
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">An Index Identifier (symbol, Intrinio ID)</param>
		/// <param name="tag">An Intrinio data tag ID or code-name</param>
		/// <param name="type">Filter by type, when applicable (optional)</param>
		/// <param name="startDate">Get historical data on or after this date (optional)</param>
		/// <param name="endDate">Get historical data on or before this date (optional)</param>
		/// <param name="sortOrder">Sort by date &#x60;asc&#x60; or &#x60;desc&#x60; (optional, default to desc)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>Task of ApiResponse (ApiResponseStockMarketIndexHistoricalData)</returns>
		Task<ApiResponse<ApiResponseStockMarketIndexHistoricalData>> GetStockMarketIndexHistoricalDataAsyncWithHttpInfo(
			string identifier, string tag, string type = null, DateTime? startDate = null, DateTime? endDate = null,
			string sortOrder = null, int? pageSize = null, string nextPage = null);

		/// <summary>
		///     Search Economic Indices
		/// </summary>
		/// <remarks>
		///     Searches for indices using the text in &#x60;query&#x60;
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="query">Search query</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <returns>Task of ApiResponseEconomicIndicesSearch</returns>
		Task<ApiResponseEconomicIndicesSearch> SearchEconomicIndicesAsync(string query, int? pageSize = null);

		/// <summary>
		///     Search Economic Indices
		/// </summary>
		/// <remarks>
		///     Searches for indices using the text in &#x60;query&#x60;
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="query">Search query</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <returns>Task of ApiResponse (ApiResponseEconomicIndicesSearch)</returns>
		Task<ApiResponse<ApiResponseEconomicIndicesSearch>> SearchEconomicIndicesAsyncWithHttpInfo(string query,
			int? pageSize = null);

		/// <summary>
		///     Search SIC Indices
		/// </summary>
		/// <remarks>
		///     Searches for indices using the text in &#x60;query&#x60;
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="query">Search query</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <returns>Task of ApiResponseSICIndicesSearch</returns>
		Task<ApiResponseSICIndicesSearch> SearchSicIndicesAsync(string query, int? pageSize = null);

		/// <summary>
		///     Search SIC Indices
		/// </summary>
		/// <remarks>
		///     Searches for indices using the text in &#x60;query&#x60;
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="query">Search query</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <returns>Task of ApiResponse (ApiResponseSICIndicesSearch)</returns>
		Task<ApiResponse<ApiResponseSICIndicesSearch>> SearchSicIndicesAsyncWithHttpInfo(string query,
			int? pageSize = null);

		/// <summary>
		///     Search Stock Market Indices
		/// </summary>
		/// <remarks>
		///     Searches for indices using the text in &#x60;query&#x60;
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="query">Search query</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <returns>Task of ApiResponseStockMarketIndicesSearch</returns>
		Task<ApiResponseStockMarketIndicesSearch> SearchStockMarketsIndicesAsync(string query, int? pageSize = null);

		/// <summary>
		///     Search Stock Market Indices
		/// </summary>
		/// <remarks>
		///     Searches for indices using the text in &#x60;query&#x60;
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="query">Search query</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <returns>Task of ApiResponse (ApiResponseStockMarketIndicesSearch)</returns>
		Task<ApiResponse<ApiResponseStockMarketIndicesSearch>> SearchStockMarketsIndicesAsyncWithHttpInfo(string query,
			int? pageSize = null);

		#endregion Asynchronous Operations
	}
}