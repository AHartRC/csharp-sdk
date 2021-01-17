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
	public class HistoricalDataApi : IHistoricalDataApi
	{
		private ExceptionFactory _exceptionFactory = (name, response) => null;

		/// <summary>
		///     Initializes a new instance of the <see cref="HistoricalDataApi" /> class.
		/// </summary>
		/// <returns></returns>
		public HistoricalDataApi(string basePath)
		{
			Configuration = new Configuration {BasePath = basePath};

			ExceptionFactory = Configuration.DefaultExceptionFactory;
		}

		/// <summary>
		///     Initializes a new instance of the <see cref="HistoricalDataApi" /> class
		///     using Configuration object
		/// </summary>
		/// <param name="configuration">An instance of Configuration</param>
		/// <returns></returns>
		public HistoricalDataApi(Configuration configuration = null)
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
		///     Historical Data Returns historical values for the given &#x60;tag&#x60; and the entity represented by the given
		///     &#x60;identifier&#x60;
		/// </summary>
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
		public ApiResponseHistoricalData GetHistoricalData(string identifier, string tag, string frequency = null,
			string type = null, DateTime? startDate = null, DateTime? endDate = null, string sortOrder = null,
			int? pageSize = null, string nextPage = null)
		{
			var localVarResponse = GetHistoricalDataWithHttpInfo(identifier, tag, frequency, type, startDate, endDate,
				sortOrder, pageSize, nextPage);
			return localVarResponse.Data;
		}

		/// <summary>
		///     Historical Data Returns historical values for the given &#x60;tag&#x60; and the entity represented by the given
		///     &#x60;identifier&#x60;
		/// </summary>
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
		public ApiResponse<ApiResponseHistoricalData> GetHistoricalDataWithHttpInfo(string identifier, string tag,
			string frequency = null, string type = null, DateTime? startDate = null, DateTime? endDate = null,
			string sortOrder = null, int? pageSize = null, string nextPage = null)
		{
			// verify the required parameter 'identifier' is set
			if (identifier == null)
				throw new ApiException(400,
					"Missing required parameter 'identifier' when calling HistoricalDataApi->GetHistoricalData");
			// verify the required parameter 'tag' is set
			if (tag == null)
				throw new ApiException(400,
					"Missing required parameter 'tag' when calling HistoricalDataApi->GetHistoricalData");

			var localVarPath = "/historical_data/{identifier}/{tag}";
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
				localVarPathParams.Add("identifier",
					Configuration.ApiClient.ParameterToString(identifier)); // path parameter
			if (tag != null)
				localVarPathParams.Add("tag", Configuration.ApiClient.ParameterToString(tag)); // path parameter
			if (frequency != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "frequency", frequency)); // query parameter
			if (type != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "type", type)); // query parameter
			if (startDate != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "start_date", startDate)); // query parameter
			if (endDate != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "end_date", endDate)); // query parameter
			if (sortOrder != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "sort_order", sortOrder)); // query parameter
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
				var exception = ExceptionFactory("GetHistoricalData", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<ApiResponseHistoricalData>(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(ApiResponseHistoricalData) Configuration.ApiClient.Deserialize(localVarResponse,
					typeof(ApiResponseHistoricalData)));
		}

		/// <summary>
		///     Historical Data Returns historical values for the given &#x60;tag&#x60; and the entity represented by the given
		///     &#x60;identifier&#x60;
		/// </summary>
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
		public async Task<ApiResponseHistoricalData> GetHistoricalDataAsync(string identifier, string tag,
			string frequency = null, string type = null, DateTime? startDate = null, DateTime? endDate = null,
			string sortOrder = null, int? pageSize = null, string nextPage = null)
		{
			var localVarResponse = await GetHistoricalDataAsyncWithHttpInfo(identifier, tag, frequency, type, startDate,
				endDate, sortOrder, pageSize, nextPage);
			return localVarResponse.Data;
		}

		/// <summary>
		///     Historical Data Returns historical values for the given &#x60;tag&#x60; and the entity represented by the given
		///     &#x60;identifier&#x60;
		/// </summary>
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
		public async Task<ApiResponse<ApiResponseHistoricalData>> GetHistoricalDataAsyncWithHttpInfo(string identifier,
			string tag, string frequency = null, string type = null, DateTime? startDate = null,
			DateTime? endDate = null, string sortOrder = null, int? pageSize = null, string nextPage = null)
		{
			// verify the required parameter 'identifier' is set
			if (identifier == null)
				throw new ApiException(400,
					"Missing required parameter 'identifier' when calling HistoricalDataApi->GetHistoricalData");
			// verify the required parameter 'tag' is set
			if (tag == null)
				throw new ApiException(400,
					"Missing required parameter 'tag' when calling HistoricalDataApi->GetHistoricalData");

			var localVarPath = "/historical_data/{identifier}/{tag}";
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
				localVarPathParams.Add("identifier",
					Configuration.ApiClient.ParameterToString(identifier)); // path parameter
			if (tag != null)
				localVarPathParams.Add("tag", Configuration.ApiClient.ParameterToString(tag)); // path parameter
			if (frequency != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "frequency", frequency)); // query parameter
			if (type != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "type", type)); // query parameter
			if (startDate != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "start_date", startDate)); // query parameter
			if (endDate != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "end_date", endDate)); // query parameter
			if (sortOrder != null)
				localVarQueryParams.AddRange(
					Configuration.ApiClient.ParameterToKeyValuePairs("", "sort_order", sortOrder)); // query parameter
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
				var exception = ExceptionFactory("GetHistoricalData", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<ApiResponseHistoricalData>(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(ApiResponseHistoricalData) Configuration.ApiClient.Deserialize(localVarResponse,
					typeof(ApiResponseHistoricalData)));
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