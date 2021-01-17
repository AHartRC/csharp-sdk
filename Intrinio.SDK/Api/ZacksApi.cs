using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using Intrinio.SDK.Client;
using Intrinio.SDK.Interface;
using Intrinio.SDK.Model;
using Intrinio.SDK.Model.ApiResponse;

namespace Intrinio.SDK.Api
{
	/// <summary>
	///     Represents a collection of functions to interact with the API endpoints
	/// </summary>
	public class ZacksApi : IZacksApi
	{
		private ExceptionFactory _exceptionFactory = (name, response) => null;

		/// <summary>
		///     Initializes a new instance of the <see cref="ZacksApi" /> class.
		/// </summary>
		/// <returns></returns>
		public ZacksApi(string basePath)
		{
			Configuration = new Configuration {BasePath = basePath};

			ExceptionFactory = Configuration.DefaultExceptionFactory;
		}

		/// <summary>
		///     Initializes a new instance of the <see cref="ZacksApi" /> class
		///     using Configuration object
		/// </summary>
		/// <param name="configuration">An instance of Configuration</param>
		/// <returns></returns>
		public ZacksApi(Configuration configuration = null)
		{
			if (configuration == null) // use the default one in Configuration
				Configuration = Configuration.Default;
			else
				Configuration = configuration;

			ExceptionFactory = Configuration.DefaultExceptionFactory;
		}

		/// <summary>
		///     Gets the base path of the API client.
		/// </summary>
		/// <value>The base path</value>
		public string GetBasePath()
		{
			return Configuration.ApiClient.RestClient.BaseUrl.ToString();
		}

		/// <summary>
		///     Gets or sets the configuration object
		/// </summary>
		/// <value>An instance of the Configuration</value>
		public Configuration Configuration { get; set; }

		/// <summary>
		///     Provides a factory method hook for the creation of exceptions.
		/// </summary>
		public ExceptionFactory ExceptionFactory
		{
			get
			{
				if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
					throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
				return _exceptionFactory;
			}
			set => _exceptionFactory = value;
		}

		/// <summary>
		///     Zacks Analyst Ratings Returns buy, sell, and hold recommendations from analysts at brokerages for all companies in
		///     the Zacks universe. Zack’s storied research team aggregates and validates the ratings from professional analysts.
		/// </summary>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID) (optional)</param>
		/// <param name="startDate">Limit ratings to those on or after this date (optional)</param>
		/// <param name="endDate">Limit ratings to those on or before this date (optional)</param>
		/// <param name="meanGreater">Return only records with a mean (average) higher than this value (optional)</param>
		/// <param name="meanLess">Return only records with a mean (average) lower than this value (optional)</param>
		/// <param name="strongBuysGreater">Return only records with more than this many Strong Buy recommendations (optional)</param>
		/// <param name="strongBuysLess">Return only records with fewer than this many Strong Buy recommendations (optional)</param>
		/// <param name="buysGreater">Return only records with more than this many Buy recommendations (optional)</param>
		/// <param name="buysLess">Return only records with fewer than this many Buy recommendations (optional)</param>
		/// <param name="holdsGreater">Return only records with more than this many Hold recommendations (optional)</param>
		/// <param name="holdsLess">Return only records with fewer than this many Hold recommendations (optional)</param>
		/// <param name="sellsGreater">Return only records with more than this many Sell recommendations (optional)</param>
		/// <param name="sellsLess">Return only records with fewer than this many Sell recommendations (optional)</param>
		/// <param name="strongSellsGreater">Return only records with more than this many Strong Sell recommendations (optional)</param>
		/// <param name="strongSellsLess">Return only records with fewer than this many Strong Sell recommendations (optional)</param>
		/// <param name="totalGreater">Return only records with more than this many recommendations, regardless of type (optional)</param>
		/// <param name="totalLess">Return only records with fewer than this many recommendations, regardless of type (optional)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>ApiResponseZacksAnalystRatings</returns>
		public ApiResponseZacksAnalystRatings GetZacksAnalystRatings(string identifier = null,
			DateTime? startDate = null, DateTime? endDate = null, decimal? meanGreater = null, decimal? meanLess = null,
			int? strongBuysGreater = null, int? strongBuysLess = null, int? buysGreater = null, int? buysLess = null,
			int? holdsGreater = null, int? holdsLess = null, int? sellsGreater = null, int? sellsLess = null,
			int? strongSellsGreater = null, int? strongSellsLess = null, int? totalGreater = null,
			int? totalLess = null, int? pageSize = null, string nextPage = null)
		{
			var localVarResponse = GetZacksAnalystRatingsWithHttpInfo(identifier, startDate, endDate, meanGreater,
				meanLess, strongBuysGreater, strongBuysLess, buysGreater, buysLess, holdsGreater, holdsLess,
				sellsGreater, sellsLess, strongSellsGreater, strongSellsLess, totalGreater, totalLess, pageSize,
				nextPage);
			return localVarResponse.Data;
		}

		/// <summary>
		///     Zacks Analyst Ratings Returns buy, sell, and hold recommendations from analysts at brokerages for all companies in
		///     the Zacks universe. Zack’s storied research team aggregates and validates the ratings from professional analysts.
		/// </summary>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID) (optional)</param>
		/// <param name="startDate">Limit ratings to those on or after this date (optional)</param>
		/// <param name="endDate">Limit ratings to those on or before this date (optional)</param>
		/// <param name="meanGreater">Return only records with a mean (average) higher than this value (optional)</param>
		/// <param name="meanLess">Return only records with a mean (average) lower than this value (optional)</param>
		/// <param name="strongBuysGreater">Return only records with more than this many Strong Buy recommendations (optional)</param>
		/// <param name="strongBuysLess">Return only records with fewer than this many Strong Buy recommendations (optional)</param>
		/// <param name="buysGreater">Return only records with more than this many Buy recommendations (optional)</param>
		/// <param name="buysLess">Return only records with fewer than this many Buy recommendations (optional)</param>
		/// <param name="holdsGreater">Return only records with more than this many Hold recommendations (optional)</param>
		/// <param name="holdsLess">Return only records with fewer than this many Hold recommendations (optional)</param>
		/// <param name="sellsGreater">Return only records with more than this many Sell recommendations (optional)</param>
		/// <param name="sellsLess">Return only records with fewer than this many Sell recommendations (optional)</param>
		/// <param name="strongSellsGreater">Return only records with more than this many Strong Sell recommendations (optional)</param>
		/// <param name="strongSellsLess">Return only records with fewer than this many Strong Sell recommendations (optional)</param>
		/// <param name="totalGreater">Return only records with more than this many recommendations, regardless of type (optional)</param>
		/// <param name="totalLess">Return only records with fewer than this many recommendations, regardless of type (optional)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>ApiResponse of ApiResponseZacksAnalystRatings</returns>
		public ApiResponse<ApiResponseZacksAnalystRatings> GetZacksAnalystRatingsWithHttpInfo(string identifier = null,
			DateTime? startDate = null, DateTime? endDate = null, decimal? meanGreater = null, decimal? meanLess = null,
			int? strongBuysGreater = null, int? strongBuysLess = null, int? buysGreater = null, int? buysLess = null,
			int? holdsGreater = null, int? holdsLess = null, int? sellsGreater = null, int? sellsLess = null,
			int? strongSellsGreater = null, int? strongSellsLess = null, int? totalGreater = null,
			int? totalLess = null, int? pageSize = null, string nextPage = null)
		{
			var localVarPath = "/zacks/analyst_ratings";
			var localVarPathParams = new Dictionary<string, string>();
			var localVarQueryParams = new List<KeyValuePair<string, string>>();
			var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<string, string>();
			var localVarFileParams = new Dictionary<string, FileParameter>();
			object localVarPostBody = null;

			// to determine the Content-Type header
			string[] localVarHttpContentTypes =
			{
			};
			var localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

			// to determine the Accept header
			string[] localVarHttpHeaderAccepts =
			{
				"application/json"
			};
			var localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
			if (localVarHttpHeaderAccept != null)
				localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);


			if (identifier != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "identifier", identifier)); // query parameter
			if (startDate != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "start_date", startDate)); // query parameter
			if (endDate != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "end_date", endDate)); // query parameter
			if (meanGreater != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "mean_greater",
						meanGreater)); // query parameter
			if (meanLess != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "mean_less", meanLess)); // query parameter
			if (strongBuysGreater != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "strong_buys_greater",
						strongBuysGreater)); // query parameter
			if (strongBuysLess != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "strong_buys_less",
						strongBuysLess)); // query parameter
			if (buysGreater != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "buys_greater",
						buysGreater)); // query parameter
			if (buysLess != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "buys_less", buysLess)); // query parameter
			if (holdsGreater != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "holds_greater",
						holdsGreater)); // query parameter
			if (holdsLess != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "holds_less", holdsLess)); // query parameter
			if (sellsGreater != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "sells_greater",
						sellsGreater)); // query parameter
			if (sellsLess != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "sells_less", sellsLess)); // query parameter
			if (strongSellsGreater != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "strong_sells_greater",
						strongSellsGreater)); // query parameter
			if (strongSellsLess != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "strong_sells_less",
						strongSellsLess)); // query parameter
			if (totalGreater != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "total_greater",
						totalGreater)); // query parameter
			if (totalLess != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "total_less", totalLess)); // query parameter
			if (pageSize != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "page_size", pageSize)); // query parameter
			if (nextPage != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "next_page", nextPage)); // query parameter

			// authentication (ApiKeyAuth) required
			if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
				localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key",
					Configuration.GetApiKeyWithPrefix("api_key")));

			// make the HTTP request
			IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
				Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams,
				localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			var localVarStatusCode = (int) localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				var exception = ExceptionFactory("GetZacksAnalystRatings", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<ApiResponseZacksAnalystRatings>(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(ApiResponseZacksAnalystRatings) Configuration.ApiClient.Deserialize(localVarResponse,
					typeof(ApiResponseZacksAnalystRatings)));
		}

		/// <summary>
		///     Zacks Analyst Ratings Returns buy, sell, and hold recommendations from analysts at brokerages for all companies in
		///     the Zacks universe. Zack’s storied research team aggregates and validates the ratings from professional analysts.
		/// </summary>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID) (optional)</param>
		/// <param name="startDate">Limit ratings to those on or after this date (optional)</param>
		/// <param name="endDate">Limit ratings to those on or before this date (optional)</param>
		/// <param name="meanGreater">Return only records with a mean (average) higher than this value (optional)</param>
		/// <param name="meanLess">Return only records with a mean (average) lower than this value (optional)</param>
		/// <param name="strongBuysGreater">Return only records with more than this many Strong Buy recommendations (optional)</param>
		/// <param name="strongBuysLess">Return only records with fewer than this many Strong Buy recommendations (optional)</param>
		/// <param name="buysGreater">Return only records with more than this many Buy recommendations (optional)</param>
		/// <param name="buysLess">Return only records with fewer than this many Buy recommendations (optional)</param>
		/// <param name="holdsGreater">Return only records with more than this many Hold recommendations (optional)</param>
		/// <param name="holdsLess">Return only records with fewer than this many Hold recommendations (optional)</param>
		/// <param name="sellsGreater">Return only records with more than this many Sell recommendations (optional)</param>
		/// <param name="sellsLess">Return only records with fewer than this many Sell recommendations (optional)</param>
		/// <param name="strongSellsGreater">Return only records with more than this many Strong Sell recommendations (optional)</param>
		/// <param name="strongSellsLess">Return only records with fewer than this many Strong Sell recommendations (optional)</param>
		/// <param name="totalGreater">Return only records with more than this many recommendations, regardless of type (optional)</param>
		/// <param name="totalLess">Return only records with fewer than this many recommendations, regardless of type (optional)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>Task of ApiResponseZacksAnalystRatings</returns>
		public async Task<ApiResponseZacksAnalystRatings> GetZacksAnalystRatingsAsync(string identifier = null,
			DateTime? startDate = null, DateTime? endDate = null, decimal? meanGreater = null, decimal? meanLess = null,
			int? strongBuysGreater = null, int? strongBuysLess = null, int? buysGreater = null, int? buysLess = null,
			int? holdsGreater = null, int? holdsLess = null, int? sellsGreater = null, int? sellsLess = null,
			int? strongSellsGreater = null, int? strongSellsLess = null, int? totalGreater = null,
			int? totalLess = null, int? pageSize = null, string nextPage = null)
		{
			var localVarResponse = await GetZacksAnalystRatingsAsyncWithHttpInfo(identifier, startDate, endDate,
				meanGreater, meanLess, strongBuysGreater, strongBuysLess, buysGreater, buysLess, holdsGreater,
				holdsLess, sellsGreater, sellsLess, strongSellsGreater, strongSellsLess, totalGreater, totalLess,
				pageSize, nextPage);
			return localVarResponse.Data;
		}

		/// <summary>
		///     Zacks Analyst Ratings Returns buy, sell, and hold recommendations from analysts at brokerages for all companies in
		///     the Zacks universe. Zack’s storied research team aggregates and validates the ratings from professional analysts.
		/// </summary>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID) (optional)</param>
		/// <param name="startDate">Limit ratings to those on or after this date (optional)</param>
		/// <param name="endDate">Limit ratings to those on or before this date (optional)</param>
		/// <param name="meanGreater">Return only records with a mean (average) higher than this value (optional)</param>
		/// <param name="meanLess">Return only records with a mean (average) lower than this value (optional)</param>
		/// <param name="strongBuysGreater">Return only records with more than this many Strong Buy recommendations (optional)</param>
		/// <param name="strongBuysLess">Return only records with fewer than this many Strong Buy recommendations (optional)</param>
		/// <param name="buysGreater">Return only records with more than this many Buy recommendations (optional)</param>
		/// <param name="buysLess">Return only records with fewer than this many Buy recommendations (optional)</param>
		/// <param name="holdsGreater">Return only records with more than this many Hold recommendations (optional)</param>
		/// <param name="holdsLess">Return only records with fewer than this many Hold recommendations (optional)</param>
		/// <param name="sellsGreater">Return only records with more than this many Sell recommendations (optional)</param>
		/// <param name="sellsLess">Return only records with fewer than this many Sell recommendations (optional)</param>
		/// <param name="strongSellsGreater">Return only records with more than this many Strong Sell recommendations (optional)</param>
		/// <param name="strongSellsLess">Return only records with fewer than this many Strong Sell recommendations (optional)</param>
		/// <param name="totalGreater">Return only records with more than this many recommendations, regardless of type (optional)</param>
		/// <param name="totalLess">Return only records with fewer than this many recommendations, regardless of type (optional)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>Task of ApiResponse (ApiResponseZacksAnalystRatings)</returns>
		public async Task<ApiResponse<ApiResponseZacksAnalystRatings>> GetZacksAnalystRatingsAsyncWithHttpInfo(
			string identifier = null, DateTime? startDate = null, DateTime? endDate = null, decimal? meanGreater = null,
			decimal? meanLess = null, int? strongBuysGreater = null, int? strongBuysLess = null,
			int? buysGreater = null, int? buysLess = null, int? holdsGreater = null, int? holdsLess = null,
			int? sellsGreater = null, int? sellsLess = null, int? strongSellsGreater = null,
			int? strongSellsLess = null, int? totalGreater = null, int? totalLess = null, int? pageSize = null,
			string nextPage = null)
		{
			var localVarPath = "/zacks/analyst_ratings";
			var localVarPathParams = new Dictionary<string, string>();
			var localVarQueryParams = new List<KeyValuePair<string, string>>();
			var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<string, string>();
			var localVarFileParams = new Dictionary<string, FileParameter>();
			object localVarPostBody = null;

			// to determine the Content-Type header
			string[] localVarHttpContentTypes =
			{
			};
			var localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

			// to determine the Accept header
			string[] localVarHttpHeaderAccepts =
			{
				"application/json"
			};
			var localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
			if (localVarHttpHeaderAccept != null)
				localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);


			if (identifier != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "identifier", identifier)); // query parameter
			if (startDate != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "start_date", startDate)); // query parameter
			if (endDate != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "end_date", endDate)); // query parameter
			if (meanGreater != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "mean_greater",
						meanGreater)); // query parameter
			if (meanLess != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "mean_less", meanLess)); // query parameter
			if (strongBuysGreater != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "strong_buys_greater",
						strongBuysGreater)); // query parameter
			if (strongBuysLess != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "strong_buys_less",
						strongBuysLess)); // query parameter
			if (buysGreater != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "buys_greater",
						buysGreater)); // query parameter
			if (buysLess != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "buys_less", buysLess)); // query parameter
			if (holdsGreater != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "holds_greater",
						holdsGreater)); // query parameter
			if (holdsLess != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "holds_less", holdsLess)); // query parameter
			if (sellsGreater != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "sells_greater",
						sellsGreater)); // query parameter
			if (sellsLess != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "sells_less", sellsLess)); // query parameter
			if (strongSellsGreater != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "strong_sells_greater",
						strongSellsGreater)); // query parameter
			if (strongSellsLess != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "strong_sells_less",
						strongSellsLess)); // query parameter
			if (totalGreater != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "total_greater",
						totalGreater)); // query parameter
			if (totalLess != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "total_less", totalLess)); // query parameter
			if (pageSize != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "page_size", pageSize)); // query parameter
			if (nextPage != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "next_page", nextPage)); // query parameter

			// authentication (ApiKeyAuth) required
			if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
				localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key",
					Configuration.GetApiKeyWithPrefix("api_key")));

			// make the HTTP request
			IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
				Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams,
				localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			var localVarStatusCode = (int) localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				var exception = ExceptionFactory("GetZacksAnalystRatings", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<ApiResponseZacksAnalystRatings>(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(ApiResponseZacksAnalystRatings) Configuration.ApiClient.Deserialize(localVarResponse,
					typeof(ApiResponseZacksAnalystRatings)));
		}

		/// <summary>
		///     Zacks EPS Estimates Returns Zacks consensus earnings-per-share (EPS) data for all Companies.
		/// </summary>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID) (optional)</param>
		/// <param name="startDate">Limit EPS estimates to those on or after this date (optional)</param>
		/// <param name="endDate">Limit EPS estimates to those on or before this date (optional)</param>
		/// <param name="fiscalYear">Only for the given fiscal year (optional)</param>
		/// <param name="fiscalPeriod">The fiscal period (optional)</param>
		/// <param name="calendarYear">Only for the given calendar year (optional)</param>
		/// <param name="calendarPeriod">The calendar period (optional)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>ApiResponseZacksEPSEstimates</returns>
		public ApiResponseZacksEPSEstimates GetZacksEpsEstimates(string identifier = null, DateTime? startDate = null,
			DateTime? endDate = null, int? fiscalYear = null, string fiscalPeriod = null, int? calendarYear = null,
			string calendarPeriod = null, int? pageSize = null, string nextPage = null)
		{
			var localVarResponse = GetZacksEpsEstimatesWithHttpInfo(identifier, startDate, endDate, fiscalYear,
				fiscalPeriod, calendarYear, calendarPeriod, pageSize, nextPage);
			return localVarResponse.Data;
		}

		/// <summary>
		///     Zacks EPS Estimates Returns Zacks consensus earnings-per-share (EPS) data for all Companies.
		/// </summary>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID) (optional)</param>
		/// <param name="startDate">Limit EPS estimates to those on or after this date (optional)</param>
		/// <param name="endDate">Limit EPS estimates to those on or before this date (optional)</param>
		/// <param name="fiscalYear">Only for the given fiscal year (optional)</param>
		/// <param name="fiscalPeriod">The fiscal period (optional)</param>
		/// <param name="calendarYear">Only for the given calendar year (optional)</param>
		/// <param name="calendarPeriod">The calendar period (optional)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>ApiResponse of ApiResponseZacksEPSEstimates</returns>
		public ApiResponse<ApiResponseZacksEPSEstimates> GetZacksEpsEstimatesWithHttpInfo(string identifier = null,
			DateTime? startDate = null, DateTime? endDate = null, int? fiscalYear = null, string fiscalPeriod = null,
			int? calendarYear = null, string calendarPeriod = null, int? pageSize = null, string nextPage = null)
		{
			var localVarPath = "/zacks/eps_estimates";
			var localVarPathParams = new Dictionary<string, string>();
			var localVarQueryParams = new List<KeyValuePair<string, string>>();
			var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<string, string>();
			var localVarFileParams = new Dictionary<string, FileParameter>();
			object localVarPostBody = null;

			// to determine the Content-Type header
			string[] localVarHttpContentTypes =
			{
			};
			var localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

			// to determine the Accept header
			string[] localVarHttpHeaderAccepts =
			{
				"application/json"
			};
			var localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
			if (localVarHttpHeaderAccept != null)
				localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);


			if (identifier != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "identifier", identifier)); // query parameter
			if (startDate != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "start_date", startDate)); // query parameter
			if (endDate != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "end_date", endDate)); // query parameter
			if (fiscalYear != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "fiscal_year", fiscalYear)); // query parameter
			if (fiscalPeriod != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "fiscal_period",
						fiscalPeriod)); // query parameter
			if (calendarYear != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "calendar_year",
						calendarYear)); // query parameter
			if (calendarPeriod != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "calendar_period",
						calendarPeriod)); // query parameter
			if (pageSize != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "page_size", pageSize)); // query parameter
			if (nextPage != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "next_page", nextPage)); // query parameter

			// authentication (ApiKeyAuth) required
			if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
				localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key",
					Configuration.GetApiKeyWithPrefix("api_key")));

			// make the HTTP request
			IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
				Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams,
				localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			var localVarStatusCode = (int) localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				var exception = ExceptionFactory("GetZacksEpsEstimates", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<ApiResponseZacksEPSEstimates>(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(ApiResponseZacksEPSEstimates) Configuration.ApiClient.Deserialize(localVarResponse,
					typeof(ApiResponseZacksEPSEstimates)));
		}

		/// <summary>
		///     Zacks EPS Estimates Returns Zacks consensus earnings-per-share (EPS) data for all Companies.
		/// </summary>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID) (optional)</param>
		/// <param name="startDate">Limit EPS estimates to those on or after this date (optional)</param>
		/// <param name="endDate">Limit EPS estimates to those on or before this date (optional)</param>
		/// <param name="fiscalYear">Only for the given fiscal year (optional)</param>
		/// <param name="fiscalPeriod">The fiscal period (optional)</param>
		/// <param name="calendarYear">Only for the given calendar year (optional)</param>
		/// <param name="calendarPeriod">The calendar period (optional)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>Task of ApiResponseZacksEPSEstimates</returns>
		public async Task<ApiResponseZacksEPSEstimates> GetZacksEpsEstimatesAsync(string identifier = null,
			DateTime? startDate = null, DateTime? endDate = null, int? fiscalYear = null, string fiscalPeriod = null,
			int? calendarYear = null, string calendarPeriod = null, int? pageSize = null, string nextPage = null)
		{
			var localVarResponse = await GetZacksEpsEstimatesAsyncWithHttpInfo(identifier, startDate, endDate,
				fiscalYear, fiscalPeriod, calendarYear, calendarPeriod, pageSize, nextPage);
			return localVarResponse.Data;
		}

		/// <summary>
		///     Zacks EPS Estimates Returns Zacks consensus earnings-per-share (EPS) data for all Companies.
		/// </summary>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID) (optional)</param>
		/// <param name="startDate">Limit EPS estimates to those on or after this date (optional)</param>
		/// <param name="endDate">Limit EPS estimates to those on or before this date (optional)</param>
		/// <param name="fiscalYear">Only for the given fiscal year (optional)</param>
		/// <param name="fiscalPeriod">The fiscal period (optional)</param>
		/// <param name="calendarYear">Only for the given calendar year (optional)</param>
		/// <param name="calendarPeriod">The calendar period (optional)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>Task of ApiResponse (ApiResponseZacksEPSEstimates)</returns>
		public async Task<ApiResponse<ApiResponseZacksEPSEstimates>> GetZacksEpsEstimatesAsyncWithHttpInfo(
			string identifier = null, DateTime? startDate = null, DateTime? endDate = null, int? fiscalYear = null,
			string fiscalPeriod = null, int? calendarYear = null, string calendarPeriod = null, int? pageSize = null,
			string nextPage = null)
		{
			var localVarPath = "/zacks/eps_estimates";
			var localVarPathParams = new Dictionary<string, string>();
			var localVarQueryParams = new List<KeyValuePair<string, string>>();
			var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<string, string>();
			var localVarFileParams = new Dictionary<string, FileParameter>();
			object localVarPostBody = null;

			// to determine the Content-Type header
			string[] localVarHttpContentTypes =
			{
			};
			var localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

			// to determine the Accept header
			string[] localVarHttpHeaderAccepts =
			{
				"application/json"
			};
			var localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
			if (localVarHttpHeaderAccept != null)
				localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);


			if (identifier != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "identifier", identifier)); // query parameter
			if (startDate != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "start_date", startDate)); // query parameter
			if (endDate != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "end_date", endDate)); // query parameter
			if (fiscalYear != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "fiscal_year", fiscalYear)); // query parameter
			if (fiscalPeriod != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "fiscal_period",
						fiscalPeriod)); // query parameter
			if (calendarYear != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "calendar_year",
						calendarYear)); // query parameter
			if (calendarPeriod != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "calendar_period",
						calendarPeriod)); // query parameter
			if (pageSize != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "page_size", pageSize)); // query parameter
			if (nextPage != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "next_page", nextPage)); // query parameter

			// authentication (ApiKeyAuth) required
			if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
				localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key",
					Configuration.GetApiKeyWithPrefix("api_key")));

			// make the HTTP request
			IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
				Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams,
				localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			var localVarStatusCode = (int) localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				var exception = ExceptionFactory("GetZacksEpsEstimates", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<ApiResponseZacksEPSEstimates>(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(ApiResponseZacksEPSEstimates) Configuration.ApiClient.Deserialize(localVarResponse,
					typeof(ApiResponseZacksEPSEstimates)));
		}

		/// <summary>
		///     Zacks EPS Growth Rates Returns the latest Zacks EPS growth rates
		/// </summary>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="company">Filings for the given &#x60;company&#x60; identifier (ticker, CIK, LEI, Intrinio ID) (optional)</param>
		/// <param name="industryGroupName">
		///     Return only growth rates for companies in the given Zacks industry group name
		///     (optional)
		/// </param>
		/// <param name="industryGroupNumber">
		///     Return only growth rates for companies in the given Zacks industry group number
		///     (optional)
		/// </param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>ApiResponseZacksEPSGrowthRates</returns>
		public ApiResponseZacksEPSGrowthRates GetZacksEpsGrowthRates(string company = null,
			string industryGroupName = null, string industryGroupNumber = null, int? pageSize = null,
			string nextPage = null)
		{
			var localVarResponse =
				GetZacksEpsGrowthRatesWithHttpInfo(company, industryGroupName, industryGroupNumber, pageSize, nextPage);
			return localVarResponse.Data;
		}

		/// <summary>
		///     Zacks EPS Growth Rates Returns the latest Zacks EPS growth rates
		/// </summary>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="company">Filings for the given &#x60;company&#x60; identifier (ticker, CIK, LEI, Intrinio ID) (optional)</param>
		/// <param name="industryGroupName">
		///     Return only growth rates for companies in the given Zacks industry group name
		///     (optional)
		/// </param>
		/// <param name="industryGroupNumber">
		///     Return only growth rates for companies in the given Zacks industry group number
		///     (optional)
		/// </param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>ApiResponse of ApiResponseZacksEPSGrowthRates</returns>
		public ApiResponse<ApiResponseZacksEPSGrowthRates> GetZacksEpsGrowthRatesWithHttpInfo(string company = null,
			string industryGroupName = null, string industryGroupNumber = null, int? pageSize = null,
			string nextPage = null)
		{
			var localVarPath = "/zacks/eps_growth_rates";
			var localVarPathParams = new Dictionary<string, string>();
			var localVarQueryParams = new List<KeyValuePair<string, string>>();
			var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<string, string>();
			var localVarFileParams = new Dictionary<string, FileParameter>();
			object localVarPostBody = null;

			// to determine the Content-Type header
			string[] localVarHttpContentTypes =
			{
			};
			var localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

			// to determine the Accept header
			string[] localVarHttpHeaderAccepts =
			{
				"application/json"
			};
			var localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
			if (localVarHttpHeaderAccept != null)
				localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);


			if (company != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "company", company)); // query parameter
			if (industryGroupName != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "industry_group_name",
						industryGroupName)); // query parameter
			if (industryGroupNumber != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "industry_group_number",
						industryGroupNumber)); // query parameter
			if (pageSize != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "page_size", pageSize)); // query parameter
			if (nextPage != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "next_page", nextPage)); // query parameter

			// authentication (ApiKeyAuth) required
			if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
				localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key",
					Configuration.GetApiKeyWithPrefix("api_key")));

			// make the HTTP request
			IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
				Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams,
				localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			var localVarStatusCode = (int) localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				var exception = ExceptionFactory("GetZacksEpsGrowthRates", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<ApiResponseZacksEPSGrowthRates>(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(ApiResponseZacksEPSGrowthRates) Configuration.ApiClient.Deserialize(localVarResponse,
					typeof(ApiResponseZacksEPSGrowthRates)));
		}

		/// <summary>
		///     Zacks EPS Growth Rates Returns the latest Zacks EPS growth rates
		/// </summary>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="company">Filings for the given &#x60;company&#x60; identifier (ticker, CIK, LEI, Intrinio ID) (optional)</param>
		/// <param name="industryGroupName">
		///     Return only growth rates for companies in the given Zacks industry group name
		///     (optional)
		/// </param>
		/// <param name="industryGroupNumber">
		///     Return only growth rates for companies in the given Zacks industry group number
		///     (optional)
		/// </param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>Task of ApiResponseZacksEPSGrowthRates</returns>
		public async Task<ApiResponseZacksEPSGrowthRates> GetZacksEpsGrowthRatesAsync(string company = null,
			string industryGroupName = null, string industryGroupNumber = null, int? pageSize = null,
			string nextPage = null)
		{
			var localVarResponse = await GetZacksEpsGrowthRatesAsyncWithHttpInfo(company, industryGroupName,
				industryGroupNumber, pageSize, nextPage);
			return localVarResponse.Data;
		}

		/// <summary>
		///     Zacks EPS Growth Rates Returns the latest Zacks EPS growth rates
		/// </summary>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="company">Filings for the given &#x60;company&#x60; identifier (ticker, CIK, LEI, Intrinio ID) (optional)</param>
		/// <param name="industryGroupName">
		///     Return only growth rates for companies in the given Zacks industry group name
		///     (optional)
		/// </param>
		/// <param name="industryGroupNumber">
		///     Return only growth rates for companies in the given Zacks industry group number
		///     (optional)
		/// </param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>Task of ApiResponse (ApiResponseZacksEPSGrowthRates)</returns>
		public async Task<ApiResponse<ApiResponseZacksEPSGrowthRates>> GetZacksEpsGrowthRatesAsyncWithHttpInfo(
			string company = null, string industryGroupName = null, string industryGroupNumber = null,
			int? pageSize = null, string nextPage = null)
		{
			var localVarPath = "/zacks/eps_growth_rates";
			var localVarPathParams = new Dictionary<string, string>();
			var localVarQueryParams = new List<KeyValuePair<string, string>>();
			var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<string, string>();
			var localVarFileParams = new Dictionary<string, FileParameter>();
			object localVarPostBody = null;

			// to determine the Content-Type header
			string[] localVarHttpContentTypes =
			{
			};
			var localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

			// to determine the Accept header
			string[] localVarHttpHeaderAccepts =
			{
				"application/json"
			};
			var localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
			if (localVarHttpHeaderAccept != null)
				localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);


			if (company != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "company", company)); // query parameter
			if (industryGroupName != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "industry_group_name",
						industryGroupName)); // query parameter
			if (industryGroupNumber != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "industry_group_number",
						industryGroupNumber)); // query parameter
			if (pageSize != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "page_size", pageSize)); // query parameter
			if (nextPage != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "next_page", nextPage)); // query parameter

			// authentication (ApiKeyAuth) required
			if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
				localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key",
					Configuration.GetApiKeyWithPrefix("api_key")));

			// make the HTTP request
			IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
				Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams,
				localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			var localVarStatusCode = (int) localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				var exception = ExceptionFactory("GetZacksEpsGrowthRates", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<ApiResponseZacksEPSGrowthRates>(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(ApiResponseZacksEPSGrowthRates) Configuration.ApiClient.Deserialize(localVarResponse,
					typeof(ApiResponseZacksEPSGrowthRates)));
		}

		/// <summary>
		///     Zacks EPS Surprises Returns Zacks eps surprise data for all Securities.
		/// </summary>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="startDate">Limit EPS surprises to those on or after this date (optional)</param>
		/// <param name="endDate">Limit EPS surprises to those on or before this date (optional)</param>
		/// <param name="epsActualGreater">Return only records with an actual EPS higher than this value (optional)</param>
		/// <param name="epsActualLess">Return only records with an actual EPS lower than this value (optional)</param>
		/// <param name="epsMeanEstimateGreater">Return only records with an EPS mean estimate greater than this value (optional)</param>
		/// <param name="epsMeanEstimateLess">Return only records with an EPS mean estimate lower than this value (optional)</param>
		/// <param name="epsAmountDiffGreater">Return only records with an EPS amount difference greater than this value (optional)</param>
		/// <param name="epsAmountDiffLess">Return only records with an EPS amount difference less than this value (optional)</param>
		/// <param name="epsPercentDiffGreater">
		///     Return only records with an EPS percent difference greater than this value
		///     (optional)
		/// </param>
		/// <param name="epsPercentDiffLess">Return only records with an EPS percent difference less than this value (optional)</param>
		/// <param name="epsCountEstimateGreater">Return only records with an EPS count estimate greater than this value (optional)</param>
		/// <param name="epsCountEstimateLess">Return only records with an EPS count estimate less than this value (optional)</param>
		/// <param name="epsStdDevEstimateGreater">
		///     Return only records with an EPS standard deviation greater than this value
		///     (optional)
		/// </param>
		/// <param name="epsStdDevEstimateLess">Return only records with an EPS standard deviation less than this value (optional)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>ApiResponseZacksEPSSurprises</returns>
		public ApiResponseZacksEPSSurprises GetZacksEpsSurprises(DateTime? startDate = null, DateTime? endDate = null,
			decimal? epsActualGreater = null, decimal? epsActualLess = null, decimal? epsMeanEstimateGreater = null,
			decimal? epsMeanEstimateLess = null, decimal? epsAmountDiffGreater = null,
			decimal? epsAmountDiffLess = null, decimal? epsPercentDiffGreater = null,
			decimal? epsPercentDiffLess = null, decimal? epsCountEstimateGreater = null,
			decimal? epsCountEstimateLess = null, decimal? epsStdDevEstimateGreater = null,
			decimal? epsStdDevEstimateLess = null, int? pageSize = null, string nextPage = null)
		{
			var localVarResponse = GetZacksEpsSurprisesWithHttpInfo(startDate, endDate, epsActualGreater, epsActualLess,
				epsMeanEstimateGreater, epsMeanEstimateLess, epsAmountDiffGreater, epsAmountDiffLess,
				epsPercentDiffGreater, epsPercentDiffLess, epsCountEstimateGreater, epsCountEstimateLess,
				epsStdDevEstimateGreater, epsStdDevEstimateLess, pageSize, nextPage);
			return localVarResponse.Data;
		}

		/// <summary>
		///     Zacks EPS Surprises Returns Zacks eps surprise data for all Securities.
		/// </summary>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="startDate">Limit EPS surprises to those on or after this date (optional)</param>
		/// <param name="endDate">Limit EPS surprises to those on or before this date (optional)</param>
		/// <param name="epsActualGreater">Return only records with an actual EPS higher than this value (optional)</param>
		/// <param name="epsActualLess">Return only records with an actual EPS lower than this value (optional)</param>
		/// <param name="epsMeanEstimateGreater">Return only records with an EPS mean estimate greater than this value (optional)</param>
		/// <param name="epsMeanEstimateLess">Return only records with an EPS mean estimate lower than this value (optional)</param>
		/// <param name="epsAmountDiffGreater">Return only records with an EPS amount difference greater than this value (optional)</param>
		/// <param name="epsAmountDiffLess">Return only records with an EPS amount difference less than this value (optional)</param>
		/// <param name="epsPercentDiffGreater">
		///     Return only records with an EPS percent difference greater than this value
		///     (optional)
		/// </param>
		/// <param name="epsPercentDiffLess">Return only records with an EPS percent difference less than this value (optional)</param>
		/// <param name="epsCountEstimateGreater">Return only records with an EPS count estimate greater than this value (optional)</param>
		/// <param name="epsCountEstimateLess">Return only records with an EPS count estimate less than this value (optional)</param>
		/// <param name="epsStdDevEstimateGreater">
		///     Return only records with an EPS standard deviation greater than this value
		///     (optional)
		/// </param>
		/// <param name="epsStdDevEstimateLess">Return only records with an EPS standard deviation less than this value (optional)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>ApiResponse of ApiResponseZacksEPSSurprises</returns>
		public ApiResponse<ApiResponseZacksEPSSurprises> GetZacksEpsSurprisesWithHttpInfo(DateTime? startDate = null,
			DateTime? endDate = null, decimal? epsActualGreater = null, decimal? epsActualLess = null,
			decimal? epsMeanEstimateGreater = null, decimal? epsMeanEstimateLess = null,
			decimal? epsAmountDiffGreater = null, decimal? epsAmountDiffLess = null,
			decimal? epsPercentDiffGreater = null, decimal? epsPercentDiffLess = null,
			decimal? epsCountEstimateGreater = null, decimal? epsCountEstimateLess = null,
			decimal? epsStdDevEstimateGreater = null, decimal? epsStdDevEstimateLess = null, int? pageSize = null,
			string nextPage = null)
		{
			var localVarPath = "/zacks/eps_surprises";
			var localVarPathParams = new Dictionary<string, string>();
			var localVarQueryParams = new List<KeyValuePair<string, string>>();
			var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<string, string>();
			var localVarFileParams = new Dictionary<string, FileParameter>();
			object localVarPostBody = null;

			// to determine the Content-Type header
			string[] localVarHttpContentTypes =
			{
			};
			var localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

			// to determine the Accept header
			string[] localVarHttpHeaderAccepts =
			{
				"application/json"
			};
			var localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
			if (localVarHttpHeaderAccept != null)
				localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);


			if (startDate != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "start_date", startDate)); // query parameter
			if (endDate != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "end_date", endDate)); // query parameter
			if (epsActualGreater != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "eps_actual_greater",
						epsActualGreater)); // query parameter
			if (epsActualLess != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "eps_actual_less",
						epsActualLess)); // query parameter
			if (epsMeanEstimateGreater != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "eps_mean_estimate_greater",
						epsMeanEstimateGreater)); // query parameter
			if (epsMeanEstimateLess != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "eps_mean_estimate_less",
						epsMeanEstimateLess)); // query parameter
			if (epsAmountDiffGreater != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "eps_amount_diff_greater",
						epsAmountDiffGreater)); // query parameter
			if (epsAmountDiffLess != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "eps_amount_diff_less",
						epsAmountDiffLess)); // query parameter
			if (epsPercentDiffGreater != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "eps_percent_diff_greater",
						epsPercentDiffGreater)); // query parameter
			if (epsPercentDiffLess != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "eps_percent_diff_less",
						epsPercentDiffLess)); // query parameter
			if (epsCountEstimateGreater != null)
				localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("",
					"eps_count_estimate_greater", epsCountEstimateGreater)); // query parameter
			if (epsCountEstimateLess != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "eps_count_estimate_less",
						epsCountEstimateLess)); // query parameter
			if (epsStdDevEstimateGreater != null)
				localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("",
					"eps_std_dev_estimate_greater", epsStdDevEstimateGreater)); // query parameter
			if (epsStdDevEstimateLess != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "eps_std_dev_estimate_less",
						epsStdDevEstimateLess)); // query parameter
			if (pageSize != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "page_size", pageSize)); // query parameter
			if (nextPage != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "next_page", nextPage)); // query parameter

			// authentication (ApiKeyAuth) required
			if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
				localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key",
					Configuration.GetApiKeyWithPrefix("api_key")));

			// make the HTTP request
			IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
				Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams,
				localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			var localVarStatusCode = (int) localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				var exception = ExceptionFactory("GetZacksEpsSurprises", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<ApiResponseZacksEPSSurprises>(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(ApiResponseZacksEPSSurprises) Configuration.ApiClient.Deserialize(localVarResponse,
					typeof(ApiResponseZacksEPSSurprises)));
		}

		/// <summary>
		///     Zacks EPS Surprises Returns Zacks eps surprise data for all Securities.
		/// </summary>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="startDate">Limit EPS surprises to those on or after this date (optional)</param>
		/// <param name="endDate">Limit EPS surprises to those on or before this date (optional)</param>
		/// <param name="epsActualGreater">Return only records with an actual EPS higher than this value (optional)</param>
		/// <param name="epsActualLess">Return only records with an actual EPS lower than this value (optional)</param>
		/// <param name="epsMeanEstimateGreater">Return only records with an EPS mean estimate greater than this value (optional)</param>
		/// <param name="epsMeanEstimateLess">Return only records with an EPS mean estimate lower than this value (optional)</param>
		/// <param name="epsAmountDiffGreater">Return only records with an EPS amount difference greater than this value (optional)</param>
		/// <param name="epsAmountDiffLess">Return only records with an EPS amount difference less than this value (optional)</param>
		/// <param name="epsPercentDiffGreater">
		///     Return only records with an EPS percent difference greater than this value
		///     (optional)
		/// </param>
		/// <param name="epsPercentDiffLess">Return only records with an EPS percent difference less than this value (optional)</param>
		/// <param name="epsCountEstimateGreater">Return only records with an EPS count estimate greater than this value (optional)</param>
		/// <param name="epsCountEstimateLess">Return only records with an EPS count estimate less than this value (optional)</param>
		/// <param name="epsStdDevEstimateGreater">
		///     Return only records with an EPS standard deviation greater than this value
		///     (optional)
		/// </param>
		/// <param name="epsStdDevEstimateLess">Return only records with an EPS standard deviation less than this value (optional)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>Task of ApiResponseZacksEPSSurprises</returns>
		public async Task<ApiResponseZacksEPSSurprises> GetZacksEpsSurprisesAsync(DateTime? startDate = null,
			DateTime? endDate = null, decimal? epsActualGreater = null, decimal? epsActualLess = null,
			decimal? epsMeanEstimateGreater = null, decimal? epsMeanEstimateLess = null,
			decimal? epsAmountDiffGreater = null, decimal? epsAmountDiffLess = null,
			decimal? epsPercentDiffGreater = null, decimal? epsPercentDiffLess = null,
			decimal? epsCountEstimateGreater = null, decimal? epsCountEstimateLess = null,
			decimal? epsStdDevEstimateGreater = null, decimal? epsStdDevEstimateLess = null, int? pageSize = null,
			string nextPage = null)
		{
			var localVarResponse = await GetZacksEpsSurprisesAsyncWithHttpInfo(startDate, endDate, epsActualGreater,
				epsActualLess, epsMeanEstimateGreater, epsMeanEstimateLess, epsAmountDiffGreater, epsAmountDiffLess,
				epsPercentDiffGreater, epsPercentDiffLess, epsCountEstimateGreater, epsCountEstimateLess,
				epsStdDevEstimateGreater, epsStdDevEstimateLess, pageSize, nextPage);
			return localVarResponse.Data;
		}

		/// <summary>
		///     Zacks EPS Surprises Returns Zacks eps surprise data for all Securities.
		/// </summary>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="startDate">Limit EPS surprises to those on or after this date (optional)</param>
		/// <param name="endDate">Limit EPS surprises to those on or before this date (optional)</param>
		/// <param name="epsActualGreater">Return only records with an actual EPS higher than this value (optional)</param>
		/// <param name="epsActualLess">Return only records with an actual EPS lower than this value (optional)</param>
		/// <param name="epsMeanEstimateGreater">Return only records with an EPS mean estimate greater than this value (optional)</param>
		/// <param name="epsMeanEstimateLess">Return only records with an EPS mean estimate lower than this value (optional)</param>
		/// <param name="epsAmountDiffGreater">Return only records with an EPS amount difference greater than this value (optional)</param>
		/// <param name="epsAmountDiffLess">Return only records with an EPS amount difference less than this value (optional)</param>
		/// <param name="epsPercentDiffGreater">
		///     Return only records with an EPS percent difference greater than this value
		///     (optional)
		/// </param>
		/// <param name="epsPercentDiffLess">Return only records with an EPS percent difference less than this value (optional)</param>
		/// <param name="epsCountEstimateGreater">Return only records with an EPS count estimate greater than this value (optional)</param>
		/// <param name="epsCountEstimateLess">Return only records with an EPS count estimate less than this value (optional)</param>
		/// <param name="epsStdDevEstimateGreater">
		///     Return only records with an EPS standard deviation greater than this value
		///     (optional)
		/// </param>
		/// <param name="epsStdDevEstimateLess">Return only records with an EPS standard deviation less than this value (optional)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>Task of ApiResponse (ApiResponseZacksEPSSurprises)</returns>
		public async Task<ApiResponse<ApiResponseZacksEPSSurprises>> GetZacksEpsSurprisesAsyncWithHttpInfo(
			DateTime? startDate = null, DateTime? endDate = null, decimal? epsActualGreater = null,
			decimal? epsActualLess = null, decimal? epsMeanEstimateGreater = null, decimal? epsMeanEstimateLess = null,
			decimal? epsAmountDiffGreater = null, decimal? epsAmountDiffLess = null,
			decimal? epsPercentDiffGreater = null, decimal? epsPercentDiffLess = null,
			decimal? epsCountEstimateGreater = null, decimal? epsCountEstimateLess = null,
			decimal? epsStdDevEstimateGreater = null, decimal? epsStdDevEstimateLess = null, int? pageSize = null,
			string nextPage = null)
		{
			var localVarPath = "/zacks/eps_surprises";
			var localVarPathParams = new Dictionary<string, string>();
			var localVarQueryParams = new List<KeyValuePair<string, string>>();
			var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<string, string>();
			var localVarFileParams = new Dictionary<string, FileParameter>();
			object localVarPostBody = null;

			// to determine the Content-Type header
			string[] localVarHttpContentTypes =
			{
			};
			var localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

			// to determine the Accept header
			string[] localVarHttpHeaderAccepts =
			{
				"application/json"
			};
			var localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
			if (localVarHttpHeaderAccept != null)
				localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);


			if (startDate != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "start_date", startDate)); // query parameter
			if (endDate != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "end_date", endDate)); // query parameter
			if (epsActualGreater != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "eps_actual_greater",
						epsActualGreater)); // query parameter
			if (epsActualLess != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "eps_actual_less",
						epsActualLess)); // query parameter
			if (epsMeanEstimateGreater != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "eps_mean_estimate_greater",
						epsMeanEstimateGreater)); // query parameter
			if (epsMeanEstimateLess != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "eps_mean_estimate_less",
						epsMeanEstimateLess)); // query parameter
			if (epsAmountDiffGreater != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "eps_amount_diff_greater",
						epsAmountDiffGreater)); // query parameter
			if (epsAmountDiffLess != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "eps_amount_diff_less",
						epsAmountDiffLess)); // query parameter
			if (epsPercentDiffGreater != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "eps_percent_diff_greater",
						epsPercentDiffGreater)); // query parameter
			if (epsPercentDiffLess != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "eps_percent_diff_less",
						epsPercentDiffLess)); // query parameter
			if (epsCountEstimateGreater != null)
				localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("",
					"eps_count_estimate_greater", epsCountEstimateGreater)); // query parameter
			if (epsCountEstimateLess != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "eps_count_estimate_less",
						epsCountEstimateLess)); // query parameter
			if (epsStdDevEstimateGreater != null)
				localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("",
					"eps_std_dev_estimate_greater", epsStdDevEstimateGreater)); // query parameter
			if (epsStdDevEstimateLess != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "eps_std_dev_estimate_less",
						epsStdDevEstimateLess)); // query parameter
			if (pageSize != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "page_size", pageSize)); // query parameter
			if (nextPage != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "next_page", nextPage)); // query parameter

			// authentication (ApiKeyAuth) required
			if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
				localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key",
					Configuration.GetApiKeyWithPrefix("api_key")));

			// make the HTTP request
			IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
				Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams,
				localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			var localVarStatusCode = (int) localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				var exception = ExceptionFactory("GetZacksEpsSurprises", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<ApiResponseZacksEPSSurprises>(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(ApiResponseZacksEPSSurprises) Configuration.ApiClient.Deserialize(localVarResponse,
					typeof(ApiResponseZacksEPSSurprises)));
		}

		/// <summary>
		///     Zacks ETF Holdings Returns Zacks ETF holdings data
		/// </summary>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="etfTicker">Return holdings of the ETF with the given ticker (optional)</param>
		/// <param name="holdingSymbol">Return holdings where the instrument being held has the given trading symbol (optional)</param>
		/// <param name="weightGreater">Return on the holdings with a weight greater than (optional)</param>
		/// <param name="weightLess">Return on the holdings with a weight less than (optional)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>ApiResponseZacksETFHoldings</returns>
		public ApiResponseZacksETFHoldings GetZacksEtfHoldings(string etfTicker = null, string holdingSymbol = null,
			decimal? weightGreater = null, decimal? weightLess = null, int? pageSize = null, string nextPage = null)
		{
			var localVarResponse = GetZacksEtfHoldingsWithHttpInfo(etfTicker, holdingSymbol, weightGreater, weightLess,
				pageSize, nextPage);
			return localVarResponse.Data;
		}

		/// <summary>
		///     Zacks ETF Holdings Returns Zacks ETF holdings data
		/// </summary>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="etfTicker">Return holdings of the ETF with the given ticker (optional)</param>
		/// <param name="holdingSymbol">Return holdings where the instrument being held has the given trading symbol (optional)</param>
		/// <param name="weightGreater">Return on the holdings with a weight greater than (optional)</param>
		/// <param name="weightLess">Return on the holdings with a weight less than (optional)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>ApiResponse of ApiResponseZacksETFHoldings</returns>
		public ApiResponse<ApiResponseZacksETFHoldings> GetZacksEtfHoldingsWithHttpInfo(string etfTicker = null,
			string holdingSymbol = null, decimal? weightGreater = null, decimal? weightLess = null,
			int? pageSize = null, string nextPage = null)
		{
			var localVarPath = "/zacks/etf_holdings";
			var localVarPathParams = new Dictionary<string, string>();
			var localVarQueryParams = new List<KeyValuePair<string, string>>();
			var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<string, string>();
			var localVarFileParams = new Dictionary<string, FileParameter>();
			object localVarPostBody = null;

			// to determine the Content-Type header
			string[] localVarHttpContentTypes =
			{
			};
			var localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

			// to determine the Accept header
			string[] localVarHttpHeaderAccepts =
			{
				"application/json"
			};
			var localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
			if (localVarHttpHeaderAccept != null)
				localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);


			if (etfTicker != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "etf_ticker", etfTicker)); // query parameter
			if (holdingSymbol != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "holding_symbol",
						holdingSymbol)); // query parameter
			if (weightGreater != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "weight_greater",
						weightGreater)); // query parameter
			if (weightLess != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "weight_less", weightLess)); // query parameter
			if (pageSize != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "page_size", pageSize)); // query parameter
			if (nextPage != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "next_page", nextPage)); // query parameter

			// authentication (ApiKeyAuth) required
			if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
				localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key",
					Configuration.GetApiKeyWithPrefix("api_key")));

			// make the HTTP request
			IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
				Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams,
				localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			var localVarStatusCode = (int) localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				var exception = ExceptionFactory("GetZacksEtfHoldings", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<ApiResponseZacksETFHoldings>(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(ApiResponseZacksETFHoldings) Configuration.ApiClient.Deserialize(localVarResponse,
					typeof(ApiResponseZacksETFHoldings)));
		}

		/// <summary>
		///     Zacks ETF Holdings Returns Zacks ETF holdings data
		/// </summary>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="etfTicker">Return holdings of the ETF with the given ticker (optional)</param>
		/// <param name="holdingSymbol">Return holdings where the instrument being held has the given trading symbol (optional)</param>
		/// <param name="weightGreater">Return on the holdings with a weight greater than (optional)</param>
		/// <param name="weightLess">Return on the holdings with a weight less than (optional)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>Task of ApiResponseZacksETFHoldings</returns>
		public async Task<ApiResponseZacksETFHoldings> GetZacksEtfHoldingsAsync(string etfTicker = null,
			string holdingSymbol = null, decimal? weightGreater = null, decimal? weightLess = null,
			int? pageSize = null, string nextPage = null)
		{
			var localVarResponse = await GetZacksEtfHoldingsAsyncWithHttpInfo(etfTicker, holdingSymbol, weightGreater,
				weightLess, pageSize, nextPage);
			return localVarResponse.Data;
		}

		/// <summary>
		///     Zacks ETF Holdings Returns Zacks ETF holdings data
		/// </summary>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="etfTicker">Return holdings of the ETF with the given ticker (optional)</param>
		/// <param name="holdingSymbol">Return holdings where the instrument being held has the given trading symbol (optional)</param>
		/// <param name="weightGreater">Return on the holdings with a weight greater than (optional)</param>
		/// <param name="weightLess">Return on the holdings with a weight less than (optional)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>Task of ApiResponse (ApiResponseZacksETFHoldings)</returns>
		public async Task<ApiResponse<ApiResponseZacksETFHoldings>> GetZacksEtfHoldingsAsyncWithHttpInfo(
			string etfTicker = null, string holdingSymbol = null, decimal? weightGreater = null,
			decimal? weightLess = null, int? pageSize = null, string nextPage = null)
		{
			var localVarPath = "/zacks/etf_holdings";
			var localVarPathParams = new Dictionary<string, string>();
			var localVarQueryParams = new List<KeyValuePair<string, string>>();
			var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<string, string>();
			var localVarFileParams = new Dictionary<string, FileParameter>();
			object localVarPostBody = null;

			// to determine the Content-Type header
			string[] localVarHttpContentTypes =
			{
			};
			var localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

			// to determine the Accept header
			string[] localVarHttpHeaderAccepts =
			{
				"application/json"
			};
			var localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
			if (localVarHttpHeaderAccept != null)
				localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);


			if (etfTicker != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "etf_ticker", etfTicker)); // query parameter
			if (holdingSymbol != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "holding_symbol",
						holdingSymbol)); // query parameter
			if (weightGreater != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "weight_greater",
						weightGreater)); // query parameter
			if (weightLess != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "weight_less", weightLess)); // query parameter
			if (pageSize != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "page_size", pageSize)); // query parameter
			if (nextPage != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "next_page", nextPage)); // query parameter

			// authentication (ApiKeyAuth) required
			if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
				localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key",
					Configuration.GetApiKeyWithPrefix("api_key")));

			// make the HTTP request
			IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
				Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams,
				localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			var localVarStatusCode = (int) localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				var exception = ExceptionFactory("GetZacksEtfHoldings", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<ApiResponseZacksETFHoldings>(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(ApiResponseZacksETFHoldings) Configuration.ApiClient.Deserialize(localVarResponse,
					typeof(ApiResponseZacksETFHoldings)));
		}

		/// <summary>
		///     Zacks Institutional Holding Companies Returns Zacks institutional holding companies data
		/// </summary>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="ticker">Return companies with the given ticker (optional)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>ApiResponseZacksInstitutionalHoldingCompanies</returns>
		public ApiResponseZacksInstitutionalHoldingCompanies GetZacksInstitutionalHoldingCompanies(string ticker = null,
			int? pageSize = null, string nextPage = null)
		{
			var localVarResponse = GetZacksInstitutionalHoldingCompaniesWithHttpInfo(ticker, pageSize, nextPage);
			return localVarResponse.Data;
		}

		/// <summary>
		///     Zacks Institutional Holding Companies Returns Zacks institutional holding companies data
		/// </summary>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="ticker">Return companies with the given ticker (optional)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>ApiResponse of ApiResponseZacksInstitutionalHoldingCompanies</returns>
		public ApiResponse<ApiResponseZacksInstitutionalHoldingCompanies>
			GetZacksInstitutionalHoldingCompaniesWithHttpInfo(string ticker = null, int? pageSize = null,
				string nextPage = null)
		{
			var localVarPath = "/zacks/institutional_holdings/companies";
			var localVarPathParams = new Dictionary<string, string>();
			var localVarQueryParams = new List<KeyValuePair<string, string>>();
			var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<string, string>();
			var localVarFileParams = new Dictionary<string, FileParameter>();
			object localVarPostBody = null;

			// to determine the Content-Type header
			string[] localVarHttpContentTypes =
			{
			};
			var localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

			// to determine the Accept header
			string[] localVarHttpHeaderAccepts =
			{
				"application/json"
			};
			var localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
			if (localVarHttpHeaderAccept != null)
				localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);


			if (ticker != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "ticker", ticker)); // query parameter
			if (pageSize != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "page_size", pageSize)); // query parameter
			if (nextPage != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "next_page", nextPage)); // query parameter

			// authentication (ApiKeyAuth) required
			if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
				localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key",
					Configuration.GetApiKeyWithPrefix("api_key")));

			// make the HTTP request
			IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
				Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams,
				localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			var localVarStatusCode = (int) localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				var exception = ExceptionFactory("GetZacksInstitutionalHoldingCompanies", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<ApiResponseZacksInstitutionalHoldingCompanies>(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(ApiResponseZacksInstitutionalHoldingCompanies) Configuration.ApiClient.Deserialize(localVarResponse,
					typeof(ApiResponseZacksInstitutionalHoldingCompanies)));
		}

		/// <summary>
		///     Zacks Institutional Holding Companies Returns Zacks institutional holding companies data
		/// </summary>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="ticker">Return companies with the given ticker (optional)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>Task of ApiResponseZacksInstitutionalHoldingCompanies</returns>
		public async Task<ApiResponseZacksInstitutionalHoldingCompanies> GetZacksInstitutionalHoldingCompaniesAsync(
			string ticker = null, int? pageSize = null, string nextPage = null)
		{
			var localVarResponse =
				await GetZacksInstitutionalHoldingCompaniesAsyncWithHttpInfo(ticker, pageSize, nextPage);
			return localVarResponse.Data;
		}

		/// <summary>
		///     Zacks Institutional Holding Companies Returns Zacks institutional holding companies data
		/// </summary>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="ticker">Return companies with the given ticker (optional)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>Task of ApiResponse (ApiResponseZacksInstitutionalHoldingCompanies)</returns>
		public async Task<ApiResponse<ApiResponseZacksInstitutionalHoldingCompanies>>
			GetZacksInstitutionalHoldingCompaniesAsyncWithHttpInfo(string ticker = null, int? pageSize = null,
				string nextPage = null)
		{
			var localVarPath = "/zacks/institutional_holdings/companies";
			var localVarPathParams = new Dictionary<string, string>();
			var localVarQueryParams = new List<KeyValuePair<string, string>>();
			var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<string, string>();
			var localVarFileParams = new Dictionary<string, FileParameter>();
			object localVarPostBody = null;

			// to determine the Content-Type header
			string[] localVarHttpContentTypes =
			{
			};
			var localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

			// to determine the Accept header
			string[] localVarHttpHeaderAccepts =
			{
				"application/json"
			};
			var localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
			if (localVarHttpHeaderAccept != null)
				localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);


			if (ticker != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "ticker", ticker)); // query parameter
			if (pageSize != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "page_size", pageSize)); // query parameter
			if (nextPage != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "next_page", nextPage)); // query parameter

			// authentication (ApiKeyAuth) required
			if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
				localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key",
					Configuration.GetApiKeyWithPrefix("api_key")));

			// make the HTTP request
			IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
				Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams,
				localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			var localVarStatusCode = (int) localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				var exception = ExceptionFactory("GetZacksInstitutionalHoldingCompanies", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<ApiResponseZacksInstitutionalHoldingCompanies>(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(ApiResponseZacksInstitutionalHoldingCompanies) Configuration.ApiClient.Deserialize(localVarResponse,
					typeof(ApiResponseZacksInstitutionalHoldingCompanies)));
		}

		/// <summary>
		///     Zacks Institutional Holding Owners Returns Zacks institutional holding owners data
		/// </summary>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="cik">Return owners with the given Central Index Key (CIK) (optional)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>ApiResponseZacksInstitutionalHoldingOwners</returns>
		public ApiResponseZacksInstitutionalHoldingOwners GetZacksInstitutionalHoldingOwners(string cik = null,
			int? pageSize = null, string nextPage = null)
		{
			var localVarResponse = GetZacksInstitutionalHoldingOwnersWithHttpInfo(cik, pageSize, nextPage);
			return localVarResponse.Data;
		}

		/// <summary>
		///     Zacks Institutional Holding Owners Returns Zacks institutional holding owners data
		/// </summary>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="cik">Return owners with the given Central Index Key (CIK) (optional)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>ApiResponse of ApiResponseZacksInstitutionalHoldingOwners</returns>
		public ApiResponse<ApiResponseZacksInstitutionalHoldingOwners> GetZacksInstitutionalHoldingOwnersWithHttpInfo(
			string cik = null, int? pageSize = null, string nextPage = null)
		{
			var localVarPath = "/zacks/institutional_holdings/owners";
			var localVarPathParams = new Dictionary<string, string>();
			var localVarQueryParams = new List<KeyValuePair<string, string>>();
			var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<string, string>();
			var localVarFileParams = new Dictionary<string, FileParameter>();
			object localVarPostBody = null;

			// to determine the Content-Type header
			string[] localVarHttpContentTypes =
			{
			};
			var localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

			// to determine the Accept header
			string[] localVarHttpHeaderAccepts =
			{
				"application/json"
			};
			var localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
			if (localVarHttpHeaderAccept != null)
				localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);


			if (cik != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "cik", cik)); // query parameter
			if (pageSize != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "page_size", pageSize)); // query parameter
			if (nextPage != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "next_page", nextPage)); // query parameter

			// authentication (ApiKeyAuth) required
			if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
				localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key",
					Configuration.GetApiKeyWithPrefix("api_key")));

			// make the HTTP request
			IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
				Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams,
				localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			var localVarStatusCode = (int) localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				var exception = ExceptionFactory("GetZacksInstitutionalHoldingOwners", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<ApiResponseZacksInstitutionalHoldingOwners>(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(ApiResponseZacksInstitutionalHoldingOwners) Configuration.ApiClient.Deserialize(localVarResponse,
					typeof(ApiResponseZacksInstitutionalHoldingOwners)));
		}

		/// <summary>
		///     Zacks Institutional Holding Owners Returns Zacks institutional holding owners data
		/// </summary>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="cik">Return owners with the given Central Index Key (CIK) (optional)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>Task of ApiResponseZacksInstitutionalHoldingOwners</returns>
		public async Task<ApiResponseZacksInstitutionalHoldingOwners> GetZacksInstitutionalHoldingOwnersAsync(
			string cik = null, int? pageSize = null, string nextPage = null)
		{
			var localVarResponse = await GetZacksInstitutionalHoldingOwnersAsyncWithHttpInfo(cik, pageSize, nextPage);
			return localVarResponse.Data;
		}

		/// <summary>
		///     Zacks Institutional Holding Owners Returns Zacks institutional holding owners data
		/// </summary>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="cik">Return owners with the given Central Index Key (CIK) (optional)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>Task of ApiResponse (ApiResponseZacksInstitutionalHoldingOwners)</returns>
		public async Task<ApiResponse<ApiResponseZacksInstitutionalHoldingOwners>>
			GetZacksInstitutionalHoldingOwnersAsyncWithHttpInfo(string cik = null, int? pageSize = null,
				string nextPage = null)
		{
			var localVarPath = "/zacks/institutional_holdings/owners";
			var localVarPathParams = new Dictionary<string, string>();
			var localVarQueryParams = new List<KeyValuePair<string, string>>();
			var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<string, string>();
			var localVarFileParams = new Dictionary<string, FileParameter>();
			object localVarPostBody = null;

			// to determine the Content-Type header
			string[] localVarHttpContentTypes =
			{
			};
			var localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

			// to determine the Accept header
			string[] localVarHttpHeaderAccepts =
			{
				"application/json"
			};
			var localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
			if (localVarHttpHeaderAccept != null)
				localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);


			if (cik != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "cik", cik)); // query parameter
			if (pageSize != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "page_size", pageSize)); // query parameter
			if (nextPage != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "next_page", nextPage)); // query parameter

			// authentication (ApiKeyAuth) required
			if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
				localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key",
					Configuration.GetApiKeyWithPrefix("api_key")));

			// make the HTTP request
			IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
				Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams,
				localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			var localVarStatusCode = (int) localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				var exception = ExceptionFactory("GetZacksInstitutionalHoldingOwners", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<ApiResponseZacksInstitutionalHoldingOwners>(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(ApiResponseZacksInstitutionalHoldingOwners) Configuration.ApiClient.Deserialize(localVarResponse,
					typeof(ApiResponseZacksInstitutionalHoldingOwners)));
		}

		/// <summary>
		///     Zacks Institutional Holdings Returns Zacks institutional holdings data
		/// </summary>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="ticker">Return holdings where the company being held has the given ticker (optional)</param>
		/// <param name="ownerCik">Return holdings where the owner/holder has the given Central Index Key (CIK) (optional)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>ApiResponseZacksInstitutionalHoldings</returns>
		public ApiResponseZacksInstitutionalHoldings GetZacksInstitutionalHoldings(string ticker = null,
			string ownerCik = null, int? pageSize = null, string nextPage = null)
		{
			var localVarResponse = GetZacksInstitutionalHoldingsWithHttpInfo(ticker, ownerCik, pageSize, nextPage);
			return localVarResponse.Data;
		}

		/// <summary>
		///     Zacks Institutional Holdings Returns Zacks institutional holdings data
		/// </summary>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="ticker">Return holdings where the company being held has the given ticker (optional)</param>
		/// <param name="ownerCik">Return holdings where the owner/holder has the given Central Index Key (CIK) (optional)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>ApiResponse of ApiResponseZacksInstitutionalHoldings</returns>
		public ApiResponse<ApiResponseZacksInstitutionalHoldings> GetZacksInstitutionalHoldingsWithHttpInfo(
			string ticker = null, string ownerCik = null, int? pageSize = null, string nextPage = null)
		{
			var localVarPath = "/zacks/institutional_holdings";
			var localVarPathParams = new Dictionary<string, string>();
			var localVarQueryParams = new List<KeyValuePair<string, string>>();
			var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<string, string>();
			var localVarFileParams = new Dictionary<string, FileParameter>();
			object localVarPostBody = null;

			// to determine the Content-Type header
			string[] localVarHttpContentTypes =
			{
			};
			var localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

			// to determine the Accept header
			string[] localVarHttpHeaderAccepts =
			{
				"application/json"
			};
			var localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
			if (localVarHttpHeaderAccept != null)
				localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);


			if (ticker != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "ticker", ticker)); // query parameter
			if (ownerCik != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "owner_cik", ownerCik)); // query parameter
			if (pageSize != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "page_size", pageSize)); // query parameter
			if (nextPage != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "next_page", nextPage)); // query parameter

			// authentication (ApiKeyAuth) required
			if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
				localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key",
					Configuration.GetApiKeyWithPrefix("api_key")));

			// make the HTTP request
			IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
				Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams,
				localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			var localVarStatusCode = (int) localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				var exception = ExceptionFactory("GetZacksInstitutionalHoldings", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<ApiResponseZacksInstitutionalHoldings>(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(ApiResponseZacksInstitutionalHoldings) Configuration.ApiClient.Deserialize(localVarResponse,
					typeof(ApiResponseZacksInstitutionalHoldings)));
		}

		/// <summary>
		///     Zacks Institutional Holdings Returns Zacks institutional holdings data
		/// </summary>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="ticker">Return holdings where the company being held has the given ticker (optional)</param>
		/// <param name="ownerCik">Return holdings where the owner/holder has the given Central Index Key (CIK) (optional)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>Task of ApiResponseZacksInstitutionalHoldings</returns>
		public async Task<ApiResponseZacksInstitutionalHoldings> GetZacksInstitutionalHoldingsAsync(
			string ticker = null, string ownerCik = null, int? pageSize = null, string nextPage = null)
		{
			var localVarResponse =
				await GetZacksInstitutionalHoldingsAsyncWithHttpInfo(ticker, ownerCik, pageSize, nextPage);
			return localVarResponse.Data;
		}

		/// <summary>
		///     Zacks Institutional Holdings Returns Zacks institutional holdings data
		/// </summary>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="ticker">Return holdings where the company being held has the given ticker (optional)</param>
		/// <param name="ownerCik">Return holdings where the owner/holder has the given Central Index Key (CIK) (optional)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>Task of ApiResponse (ApiResponseZacksInstitutionalHoldings)</returns>
		public async Task<ApiResponse<ApiResponseZacksInstitutionalHoldings>>
			GetZacksInstitutionalHoldingsAsyncWithHttpInfo(string ticker = null, string ownerCik = null,
				int? pageSize = null, string nextPage = null)
		{
			var localVarPath = "/zacks/institutional_holdings";
			var localVarPathParams = new Dictionary<string, string>();
			var localVarQueryParams = new List<KeyValuePair<string, string>>();
			var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<string, string>();
			var localVarFileParams = new Dictionary<string, FileParameter>();
			object localVarPostBody = null;

			// to determine the Content-Type header
			string[] localVarHttpContentTypes =
			{
			};
			var localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

			// to determine the Accept header
			string[] localVarHttpHeaderAccepts =
			{
				"application/json"
			};
			var localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
			if (localVarHttpHeaderAccept != null)
				localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);


			if (ticker != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "ticker", ticker)); // query parameter
			if (ownerCik != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "owner_cik", ownerCik)); // query parameter
			if (pageSize != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "page_size", pageSize)); // query parameter
			if (nextPage != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "next_page", nextPage)); // query parameter

			// authentication (ApiKeyAuth) required
			if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
				localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key",
					Configuration.GetApiKeyWithPrefix("api_key")));

			// make the HTTP request
			IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
				Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams,
				localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			var localVarStatusCode = (int) localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				var exception = ExceptionFactory("GetZacksInstitutionalHoldings", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<ApiResponseZacksInstitutionalHoldings>(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(ApiResponseZacksInstitutionalHoldings) Configuration.ApiClient.Deserialize(localVarResponse,
					typeof(ApiResponseZacksInstitutionalHoldings)));
		}

		/// <summary>
		///     Zacks Long Term Growth Rates Returns the latest Zacks long term growth rates
		/// </summary>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID) (optional)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>ApiResponseZacksLongTermGrowthRates</returns>
		public ApiResponseZacksLongTermGrowthRates GetZacksLongTermGrowthRates(string identifier = null,
			int? pageSize = null, string nextPage = null)
		{
			var localVarResponse = GetZacksLongTermGrowthRatesWithHttpInfo(identifier, pageSize, nextPage);
			return localVarResponse.Data;
		}

		/// <summary>
		///     Zacks Long Term Growth Rates Returns the latest Zacks long term growth rates
		/// </summary>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID) (optional)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>ApiResponse of ApiResponseZacksLongTermGrowthRates</returns>
		public ApiResponse<ApiResponseZacksLongTermGrowthRates> GetZacksLongTermGrowthRatesWithHttpInfo(
			string identifier = null, int? pageSize = null, string nextPage = null)
		{
			var localVarPath = "/zacks/long_term_growth_rates";
			var localVarPathParams = new Dictionary<string, string>();
			var localVarQueryParams = new List<KeyValuePair<string, string>>();
			var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<string, string>();
			var localVarFileParams = new Dictionary<string, FileParameter>();
			object localVarPostBody = null;

			// to determine the Content-Type header
			string[] localVarHttpContentTypes =
			{
			};
			var localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

			// to determine the Accept header
			string[] localVarHttpHeaderAccepts =
			{
				"application/json"
			};
			var localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
			if (localVarHttpHeaderAccept != null)
				localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);


			if (identifier != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "identifier", identifier)); // query parameter
			if (pageSize != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "page_size", pageSize)); // query parameter
			if (nextPage != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "next_page", nextPage)); // query parameter

			// authentication (ApiKeyAuth) required
			if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
				localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key",
					Configuration.GetApiKeyWithPrefix("api_key")));

			// make the HTTP request
			IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
				Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams,
				localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			var localVarStatusCode = (int) localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				var exception = ExceptionFactory("GetZacksLongTermGrowthRates", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<ApiResponseZacksLongTermGrowthRates>(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(ApiResponseZacksLongTermGrowthRates) Configuration.ApiClient.Deserialize(localVarResponse,
					typeof(ApiResponseZacksLongTermGrowthRates)));
		}

		/// <summary>
		///     Zacks Long Term Growth Rates Returns the latest Zacks long term growth rates
		/// </summary>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID) (optional)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>Task of ApiResponseZacksLongTermGrowthRates</returns>
		public async Task<ApiResponseZacksLongTermGrowthRates> GetZacksLongTermGrowthRatesAsync(
			string identifier = null, int? pageSize = null, string nextPage = null)
		{
			var localVarResponse = await GetZacksLongTermGrowthRatesAsyncWithHttpInfo(identifier, pageSize, nextPage);
			return localVarResponse.Data;
		}

		/// <summary>
		///     Zacks Long Term Growth Rates Returns the latest Zacks long term growth rates
		/// </summary>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID) (optional)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>Task of ApiResponse (ApiResponseZacksLongTermGrowthRates)</returns>
		public async Task<ApiResponse<ApiResponseZacksLongTermGrowthRates>>
			GetZacksLongTermGrowthRatesAsyncWithHttpInfo(string identifier = null, int? pageSize = null,
				string nextPage = null)
		{
			var localVarPath = "/zacks/long_term_growth_rates";
			var localVarPathParams = new Dictionary<string, string>();
			var localVarQueryParams = new List<KeyValuePair<string, string>>();
			var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<string, string>();
			var localVarFileParams = new Dictionary<string, FileParameter>();
			object localVarPostBody = null;

			// to determine the Content-Type header
			string[] localVarHttpContentTypes =
			{
			};
			var localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

			// to determine the Accept header
			string[] localVarHttpHeaderAccepts =
			{
				"application/json"
			};
			var localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
			if (localVarHttpHeaderAccept != null)
				localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);


			if (identifier != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "identifier", identifier)); // query parameter
			if (pageSize != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "page_size", pageSize)); // query parameter
			if (nextPage != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "next_page", nextPage)); // query parameter

			// authentication (ApiKeyAuth) required
			if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
				localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key",
					Configuration.GetApiKeyWithPrefix("api_key")));

			// make the HTTP request
			IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
				Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams,
				localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			var localVarStatusCode = (int) localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				var exception = ExceptionFactory("GetZacksLongTermGrowthRates", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<ApiResponseZacksLongTermGrowthRates>(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(ApiResponseZacksLongTermGrowthRates) Configuration.ApiClient.Deserialize(localVarResponse,
					typeof(ApiResponseZacksLongTermGrowthRates)));
		}

		/// <summary>
		///     Zacks Sales Surprises Returns Zacks sales surprise data for all Securities.
		/// </summary>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="startDate">Limit sales surprises to those on or after this date (optional)</param>
		/// <param name="endDate">Limit sales surprises to those on or before this date (optional)</param>
		/// <param name="salesActualGreater">Return only records with an actual sales higher than this value (optional)</param>
		/// <param name="salesActualLess">Return only records with an actual sales lower than this value (optional)</param>
		/// <param name="salesMeanEstimateGreater">
		///     Return only records with a sales mean estimate greater than this value
		///     (optional)
		/// </param>
		/// <param name="salesMeanEstimateLess">Return only records with a sales mean estimate lower than this value (optional)</param>
		/// <param name="salesAmountDiffGreater">
		///     Return only records with a sales amount difference greater than this value
		///     (optional)
		/// </param>
		/// <param name="salesAmountDiffLess">Return only records with a sales amount difference less than this value (optional)</param>
		/// <param name="salesPercentDiffGreater">
		///     Return only records with a sales percent difference greater than this value
		///     (optional)
		/// </param>
		/// <param name="salesPercentDiffLess">Return only records with a sales percent difference less than this value (optional)</param>
		/// <param name="salesCountEstimateGreater">
		///     Return only records with a sales count estimate greater than this value
		///     (optional)
		/// </param>
		/// <param name="salesCountEstimateLess">Return only records with a sales count estimate less than this value (optional)</param>
		/// <param name="salesStdDevEstimateGreater">
		///     Return only records with a sales standard deviation greater than this value
		///     (optional)
		/// </param>
		/// <param name="salesStdDevEstimateLess">
		///     Return only records with a sales standard deviation less than this value
		///     (optional)
		/// </param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>ApiResponseZacksSalesSurprises</returns>
		public ApiResponseZacksSalesSurprises GetZacksSalesSurprises(DateTime? startDate = null,
			DateTime? endDate = null, decimal? salesActualGreater = null, decimal? salesActualLess = null,
			decimal? salesMeanEstimateGreater = null, decimal? salesMeanEstimateLess = null,
			decimal? salesAmountDiffGreater = null, decimal? salesAmountDiffLess = null,
			decimal? salesPercentDiffGreater = null, decimal? salesPercentDiffLess = null,
			decimal? salesCountEstimateGreater = null, decimal? salesCountEstimateLess = null,
			decimal? salesStdDevEstimateGreater = null, decimal? salesStdDevEstimateLess = null, int? pageSize = null,
			string nextPage = null)
		{
			var localVarResponse = GetZacksSalesSurprisesWithHttpInfo(startDate, endDate, salesActualGreater,
				salesActualLess, salesMeanEstimateGreater, salesMeanEstimateLess, salesAmountDiffGreater,
				salesAmountDiffLess, salesPercentDiffGreater, salesPercentDiffLess, salesCountEstimateGreater,
				salesCountEstimateLess, salesStdDevEstimateGreater, salesStdDevEstimateLess, pageSize, nextPage);
			return localVarResponse.Data;
		}

		/// <summary>
		///     Zacks Sales Surprises Returns Zacks sales surprise data for all Securities.
		/// </summary>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="startDate">Limit sales surprises to those on or after this date (optional)</param>
		/// <param name="endDate">Limit sales surprises to those on or before this date (optional)</param>
		/// <param name="salesActualGreater">Return only records with an actual sales higher than this value (optional)</param>
		/// <param name="salesActualLess">Return only records with an actual sales lower than this value (optional)</param>
		/// <param name="salesMeanEstimateGreater">
		///     Return only records with a sales mean estimate greater than this value
		///     (optional)
		/// </param>
		/// <param name="salesMeanEstimateLess">Return only records with a sales mean estimate lower than this value (optional)</param>
		/// <param name="salesAmountDiffGreater">
		///     Return only records with a sales amount difference greater than this value
		///     (optional)
		/// </param>
		/// <param name="salesAmountDiffLess">Return only records with a sales amount difference less than this value (optional)</param>
		/// <param name="salesPercentDiffGreater">
		///     Return only records with a sales percent difference greater than this value
		///     (optional)
		/// </param>
		/// <param name="salesPercentDiffLess">Return only records with a sales percent difference less than this value (optional)</param>
		/// <param name="salesCountEstimateGreater">
		///     Return only records with a sales count estimate greater than this value
		///     (optional)
		/// </param>
		/// <param name="salesCountEstimateLess">Return only records with a sales count estimate less than this value (optional)</param>
		/// <param name="salesStdDevEstimateGreater">
		///     Return only records with a sales standard deviation greater than this value
		///     (optional)
		/// </param>
		/// <param name="salesStdDevEstimateLess">
		///     Return only records with a sales standard deviation less than this value
		///     (optional)
		/// </param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>ApiResponse of ApiResponseZacksSalesSurprises</returns>
		public ApiResponse<ApiResponseZacksSalesSurprises> GetZacksSalesSurprisesWithHttpInfo(
			DateTime? startDate = null, DateTime? endDate = null, decimal? salesActualGreater = null,
			decimal? salesActualLess = null, decimal? salesMeanEstimateGreater = null,
			decimal? salesMeanEstimateLess = null, decimal? salesAmountDiffGreater = null,
			decimal? salesAmountDiffLess = null, decimal? salesPercentDiffGreater = null,
			decimal? salesPercentDiffLess = null, decimal? salesCountEstimateGreater = null,
			decimal? salesCountEstimateLess = null, decimal? salesStdDevEstimateGreater = null,
			decimal? salesStdDevEstimateLess = null, int? pageSize = null, string nextPage = null)
		{
			var localVarPath = "/zacks/sales_surprises";
			var localVarPathParams = new Dictionary<string, string>();
			var localVarQueryParams = new List<KeyValuePair<string, string>>();
			var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<string, string>();
			var localVarFileParams = new Dictionary<string, FileParameter>();
			object localVarPostBody = null;

			// to determine the Content-Type header
			string[] localVarHttpContentTypes =
			{
			};
			var localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

			// to determine the Accept header
			string[] localVarHttpHeaderAccepts =
			{
				"application/json"
			};
			var localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
			if (localVarHttpHeaderAccept != null)
				localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);


			if (startDate != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "start_date", startDate)); // query parameter
			if (endDate != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "end_date", endDate)); // query parameter
			if (salesActualGreater != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "sales_actual_greater",
						salesActualGreater)); // query parameter
			if (salesActualLess != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "sales_actual_less",
						salesActualLess)); // query parameter
			if (salesMeanEstimateGreater != null)
				localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("",
					"sales_mean_estimate_greater", salesMeanEstimateGreater)); // query parameter
			if (salesMeanEstimateLess != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "sales_mean_estimate_less",
						salesMeanEstimateLess)); // query parameter
			if (salesAmountDiffGreater != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "sales_amount_diff_greater",
						salesAmountDiffGreater)); // query parameter
			if (salesAmountDiffLess != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "sales_amount_diff_less",
						salesAmountDiffLess)); // query parameter
			if (salesPercentDiffGreater != null)
				localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("",
					"sales_percent_diff_greater", salesPercentDiffGreater)); // query parameter
			if (salesPercentDiffLess != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "sales_percent_diff_less",
						salesPercentDiffLess)); // query parameter
			if (salesCountEstimateGreater != null)
				localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("",
					"sales_count_estimate_greater", salesCountEstimateGreater)); // query parameter
			if (salesCountEstimateLess != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "sales_count_estimate_less",
						salesCountEstimateLess)); // query parameter
			if (salesStdDevEstimateGreater != null)
				localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("",
					"sales_std_dev_estimate_greater", salesStdDevEstimateGreater)); // query parameter
			if (salesStdDevEstimateLess != null)
				localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("",
					"sales_std_dev_estimate_less", salesStdDevEstimateLess)); // query parameter
			if (pageSize != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "page_size", pageSize)); // query parameter
			if (nextPage != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "next_page", nextPage)); // query parameter

			// authentication (ApiKeyAuth) required
			if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
				localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key",
					Configuration.GetApiKeyWithPrefix("api_key")));

			// make the HTTP request
			IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
				Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams,
				localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			var localVarStatusCode = (int) localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				var exception = ExceptionFactory("GetZacksSalesSurprises", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<ApiResponseZacksSalesSurprises>(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(ApiResponseZacksSalesSurprises) Configuration.ApiClient.Deserialize(localVarResponse,
					typeof(ApiResponseZacksSalesSurprises)));
		}

		/// <summary>
		///     Zacks Sales Surprises Returns Zacks sales surprise data for all Securities.
		/// </summary>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="startDate">Limit sales surprises to those on or after this date (optional)</param>
		/// <param name="endDate">Limit sales surprises to those on or before this date (optional)</param>
		/// <param name="salesActualGreater">Return only records with an actual sales higher than this value (optional)</param>
		/// <param name="salesActualLess">Return only records with an actual sales lower than this value (optional)</param>
		/// <param name="salesMeanEstimateGreater">
		///     Return only records with a sales mean estimate greater than this value
		///     (optional)
		/// </param>
		/// <param name="salesMeanEstimateLess">Return only records with a sales mean estimate lower than this value (optional)</param>
		/// <param name="salesAmountDiffGreater">
		///     Return only records with a sales amount difference greater than this value
		///     (optional)
		/// </param>
		/// <param name="salesAmountDiffLess">Return only records with a sales amount difference less than this value (optional)</param>
		/// <param name="salesPercentDiffGreater">
		///     Return only records with a sales percent difference greater than this value
		///     (optional)
		/// </param>
		/// <param name="salesPercentDiffLess">Return only records with a sales percent difference less than this value (optional)</param>
		/// <param name="salesCountEstimateGreater">
		///     Return only records with a sales count estimate greater than this value
		///     (optional)
		/// </param>
		/// <param name="salesCountEstimateLess">Return only records with a sales count estimate less than this value (optional)</param>
		/// <param name="salesStdDevEstimateGreater">
		///     Return only records with a sales standard deviation greater than this value
		///     (optional)
		/// </param>
		/// <param name="salesStdDevEstimateLess">
		///     Return only records with a sales standard deviation less than this value
		///     (optional)
		/// </param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>Task of ApiResponseZacksSalesSurprises</returns>
		public async Task<ApiResponseZacksSalesSurprises> GetZacksSalesSurprisesAsync(DateTime? startDate = null,
			DateTime? endDate = null, decimal? salesActualGreater = null, decimal? salesActualLess = null,
			decimal? salesMeanEstimateGreater = null, decimal? salesMeanEstimateLess = null,
			decimal? salesAmountDiffGreater = null, decimal? salesAmountDiffLess = null,
			decimal? salesPercentDiffGreater = null, decimal? salesPercentDiffLess = null,
			decimal? salesCountEstimateGreater = null, decimal? salesCountEstimateLess = null,
			decimal? salesStdDevEstimateGreater = null, decimal? salesStdDevEstimateLess = null, int? pageSize = null,
			string nextPage = null)
		{
			var localVarResponse = await GetZacksSalesSurprisesAsyncWithHttpInfo(startDate, endDate, salesActualGreater,
				salesActualLess, salesMeanEstimateGreater, salesMeanEstimateLess, salesAmountDiffGreater,
				salesAmountDiffLess, salesPercentDiffGreater, salesPercentDiffLess, salesCountEstimateGreater,
				salesCountEstimateLess, salesStdDevEstimateGreater, salesStdDevEstimateLess, pageSize, nextPage);
			return localVarResponse.Data;
		}

		/// <summary>
		///     Zacks Sales Surprises Returns Zacks sales surprise data for all Securities.
		/// </summary>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="startDate">Limit sales surprises to those on or after this date (optional)</param>
		/// <param name="endDate">Limit sales surprises to those on or before this date (optional)</param>
		/// <param name="salesActualGreater">Return only records with an actual sales higher than this value (optional)</param>
		/// <param name="salesActualLess">Return only records with an actual sales lower than this value (optional)</param>
		/// <param name="salesMeanEstimateGreater">
		///     Return only records with a sales mean estimate greater than this value
		///     (optional)
		/// </param>
		/// <param name="salesMeanEstimateLess">Return only records with a sales mean estimate lower than this value (optional)</param>
		/// <param name="salesAmountDiffGreater">
		///     Return only records with a sales amount difference greater than this value
		///     (optional)
		/// </param>
		/// <param name="salesAmountDiffLess">Return only records with a sales amount difference less than this value (optional)</param>
		/// <param name="salesPercentDiffGreater">
		///     Return only records with a sales percent difference greater than this value
		///     (optional)
		/// </param>
		/// <param name="salesPercentDiffLess">Return only records with a sales percent difference less than this value (optional)</param>
		/// <param name="salesCountEstimateGreater">
		///     Return only records with a sales count estimate greater than this value
		///     (optional)
		/// </param>
		/// <param name="salesCountEstimateLess">Return only records with a sales count estimate less than this value (optional)</param>
		/// <param name="salesStdDevEstimateGreater">
		///     Return only records with a sales standard deviation greater than this value
		///     (optional)
		/// </param>
		/// <param name="salesStdDevEstimateLess">
		///     Return only records with a sales standard deviation less than this value
		///     (optional)
		/// </param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>Task of ApiResponse (ApiResponseZacksSalesSurprises)</returns>
		public async Task<ApiResponse<ApiResponseZacksSalesSurprises>> GetZacksSalesSurprisesAsyncWithHttpInfo(
			DateTime? startDate = null, DateTime? endDate = null, decimal? salesActualGreater = null,
			decimal? salesActualLess = null, decimal? salesMeanEstimateGreater = null,
			decimal? salesMeanEstimateLess = null, decimal? salesAmountDiffGreater = null,
			decimal? salesAmountDiffLess = null, decimal? salesPercentDiffGreater = null,
			decimal? salesPercentDiffLess = null, decimal? salesCountEstimateGreater = null,
			decimal? salesCountEstimateLess = null, decimal? salesStdDevEstimateGreater = null,
			decimal? salesStdDevEstimateLess = null, int? pageSize = null, string nextPage = null)
		{
			var localVarPath = "/zacks/sales_surprises";
			var localVarPathParams = new Dictionary<string, string>();
			var localVarQueryParams = new List<KeyValuePair<string, string>>();
			var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<string, string>();
			var localVarFileParams = new Dictionary<string, FileParameter>();
			object localVarPostBody = null;

			// to determine the Content-Type header
			string[] localVarHttpContentTypes =
			{
			};
			var localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

			// to determine the Accept header
			string[] localVarHttpHeaderAccepts =
			{
				"application/json"
			};
			var localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
			if (localVarHttpHeaderAccept != null)
				localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);


			if (startDate != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "start_date", startDate)); // query parameter
			if (endDate != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "end_date", endDate)); // query parameter
			if (salesActualGreater != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "sales_actual_greater",
						salesActualGreater)); // query parameter
			if (salesActualLess != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "sales_actual_less",
						salesActualLess)); // query parameter
			if (salesMeanEstimateGreater != null)
				localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("",
					"sales_mean_estimate_greater", salesMeanEstimateGreater)); // query parameter
			if (salesMeanEstimateLess != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "sales_mean_estimate_less",
						salesMeanEstimateLess)); // query parameter
			if (salesAmountDiffGreater != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "sales_amount_diff_greater",
						salesAmountDiffGreater)); // query parameter
			if (salesAmountDiffLess != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "sales_amount_diff_less",
						salesAmountDiffLess)); // query parameter
			if (salesPercentDiffGreater != null)
				localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("",
					"sales_percent_diff_greater", salesPercentDiffGreater)); // query parameter
			if (salesPercentDiffLess != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "sales_percent_diff_less",
						salesPercentDiffLess)); // query parameter
			if (salesCountEstimateGreater != null)
				localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("",
					"sales_count_estimate_greater", salesCountEstimateGreater)); // query parameter
			if (salesCountEstimateLess != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "sales_count_estimate_less",
						salesCountEstimateLess)); // query parameter
			if (salesStdDevEstimateGreater != null)
				localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("",
					"sales_std_dev_estimate_greater", salesStdDevEstimateGreater)); // query parameter
			if (salesStdDevEstimateLess != null)
				localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("",
					"sales_std_dev_estimate_less", salesStdDevEstimateLess)); // query parameter
			if (pageSize != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "page_size", pageSize)); // query parameter
			if (nextPage != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "next_page", nextPage)); // query parameter

			// authentication (ApiKeyAuth) required
			if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
				localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key",
					Configuration.GetApiKeyWithPrefix("api_key")));

			// make the HTTP request
			IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
				Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams,
				localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			var localVarStatusCode = (int) localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				var exception = ExceptionFactory("GetZacksSalesSurprises", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<ApiResponseZacksSalesSurprises>(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(ApiResponseZacksSalesSurprises) Configuration.ApiClient.Deserialize(localVarResponse,
					typeof(ApiResponseZacksSalesSurprises)));
		}

		/// <summary>
		///     Zacks Target Price Consensuses Returns the latest Zacks target price consensus data
		/// </summary>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">
		///     Filings for the given &#x60;company&#x60; identifier (ticker, CIK, LEI, Intrinio ID)
		///     (optional)
		/// </param>
		/// <param name="industryGroupNumber">
		///     Return only growth rates for companies in the given Zacks industry group number
		///     (optional)
		/// </param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>ApiResponseZacksTargetPriceConsensuses</returns>
		public ApiResponseZacksTargetPriceConsensuses GetZacksTargetPriceConsensuses(string identifier = null,
			string industryGroupNumber = null, int? pageSize = null, string nextPage = null)
		{
			var localVarResponse =
				GetZacksTargetPriceConsensusesWithHttpInfo(identifier, industryGroupNumber, pageSize, nextPage);
			return localVarResponse.Data;
		}

		/// <summary>
		///     Zacks Target Price Consensuses Returns the latest Zacks target price consensus data
		/// </summary>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">
		///     Filings for the given &#x60;company&#x60; identifier (ticker, CIK, LEI, Intrinio ID)
		///     (optional)
		/// </param>
		/// <param name="industryGroupNumber">
		///     Return only growth rates for companies in the given Zacks industry group number
		///     (optional)
		/// </param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>ApiResponse of ApiResponseZacksTargetPriceConsensuses</returns>
		public ApiResponse<ApiResponseZacksTargetPriceConsensuses> GetZacksTargetPriceConsensusesWithHttpInfo(
			string identifier = null, string industryGroupNumber = null, int? pageSize = null, string nextPage = null)
		{
			var localVarPath = "/zacks/target_price_consensuses";
			var localVarPathParams = new Dictionary<string, string>();
			var localVarQueryParams = new List<KeyValuePair<string, string>>();
			var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<string, string>();
			var localVarFileParams = new Dictionary<string, FileParameter>();
			object localVarPostBody = null;

			// to determine the Content-Type header
			string[] localVarHttpContentTypes =
			{
			};
			var localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

			// to determine the Accept header
			string[] localVarHttpHeaderAccepts =
			{
				"application/json"
			};
			var localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
			if (localVarHttpHeaderAccept != null)
				localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);


			if (identifier != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "identifier", identifier)); // query parameter
			if (industryGroupNumber != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "industry_group_number",
						industryGroupNumber)); // query parameter
			if (pageSize != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "page_size", pageSize)); // query parameter
			if (nextPage != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "next_page", nextPage)); // query parameter

			// authentication (ApiKeyAuth) required
			if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
				localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key",
					Configuration.GetApiKeyWithPrefix("api_key")));

			// make the HTTP request
			IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
				Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams,
				localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			var localVarStatusCode = (int) localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				var exception = ExceptionFactory("GetZacksTargetPriceConsensuses", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<ApiResponseZacksTargetPriceConsensuses>(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(ApiResponseZacksTargetPriceConsensuses) Configuration.ApiClient.Deserialize(localVarResponse,
					typeof(ApiResponseZacksTargetPriceConsensuses)));
		}

		/// <summary>
		///     Zacks Target Price Consensuses Returns the latest Zacks target price consensus data
		/// </summary>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">
		///     Filings for the given &#x60;company&#x60; identifier (ticker, CIK, LEI, Intrinio ID)
		///     (optional)
		/// </param>
		/// <param name="industryGroupNumber">
		///     Return only growth rates for companies in the given Zacks industry group number
		///     (optional)
		/// </param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>Task of ApiResponseZacksTargetPriceConsensuses</returns>
		public async Task<ApiResponseZacksTargetPriceConsensuses> GetZacksTargetPriceConsensusesAsync(
			string identifier = null, string industryGroupNumber = null, int? pageSize = null, string nextPage = null)
		{
			var localVarResponse =
				await GetZacksTargetPriceConsensusesAsyncWithHttpInfo(identifier, industryGroupNumber, pageSize,
					nextPage);
			return localVarResponse.Data;
		}

		/// <summary>
		///     Zacks Target Price Consensuses Returns the latest Zacks target price consensus data
		/// </summary>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">
		///     Filings for the given &#x60;company&#x60; identifier (ticker, CIK, LEI, Intrinio ID)
		///     (optional)
		/// </param>
		/// <param name="industryGroupNumber">
		///     Return only growth rates for companies in the given Zacks industry group number
		///     (optional)
		/// </param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>Task of ApiResponse (ApiResponseZacksTargetPriceConsensuses)</returns>
		public async Task<ApiResponse<ApiResponseZacksTargetPriceConsensuses>>
			GetZacksTargetPriceConsensusesAsyncWithHttpInfo(string identifier = null, string industryGroupNumber = null,
				int? pageSize = null, string nextPage = null)
		{
			var localVarPath = "/zacks/target_price_consensuses";
			var localVarPathParams = new Dictionary<string, string>();
			var localVarQueryParams = new List<KeyValuePair<string, string>>();
			var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<string, string>();
			var localVarFileParams = new Dictionary<string, FileParameter>();
			object localVarPostBody = null;

			// to determine the Content-Type header
			string[] localVarHttpContentTypes =
			{
			};
			var localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

			// to determine the Accept header
			string[] localVarHttpHeaderAccepts =
			{
				"application/json"
			};
			var localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
			if (localVarHttpHeaderAccept != null)
				localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);


			if (identifier != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "identifier", identifier)); // query parameter
			if (industryGroupNumber != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "industry_group_number",
						industryGroupNumber)); // query parameter
			if (pageSize != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "page_size", pageSize)); // query parameter
			if (nextPage != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "next_page", nextPage)); // query parameter

			// authentication (ApiKeyAuth) required
			if (!string.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_key")))
				localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "api_key",
					Configuration.GetApiKeyWithPrefix("api_key")));

			// make the HTTP request
			IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
				Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams,
				localVarFileParams,
				localVarPathParams, localVarHttpContentType);

			var localVarStatusCode = (int) localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				var exception = ExceptionFactory("GetZacksTargetPriceConsensuses", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<ApiResponseZacksTargetPriceConsensuses>(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(ApiResponseZacksTargetPriceConsensuses) Configuration.ApiClient.Deserialize(localVarResponse,
					typeof(ApiResponseZacksTargetPriceConsensuses)));
		}

		/// <summary>
		///     Sets the base path of the API client.
		/// </summary>
		/// <value>The base path</value>
		[Obsolete(
			"SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
		public void SetBasePath(string basePath)
		{
			// do nothing
		}

		/// <summary>
		///     Gets the default header.
		/// </summary>
		/// <returns>Dictionary of HTTP header</returns>
		[Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
		public IDictionary<string, string> DefaultHeader()
		{
			return new ReadOnlyDictionary<string, string>(Configuration.DefaultHeader);
		}

		/// <summary>
		///     Add default header.
		/// </summary>
		/// <param name="key">Header field name.</param>
		/// <param name="value">Header field value.</param>
		/// <returns></returns>
		[Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
		public void AddDefaultHeader(string key, string value)
		{
			Configuration.AddDefaultHeader(key, value);
		}
	}
}