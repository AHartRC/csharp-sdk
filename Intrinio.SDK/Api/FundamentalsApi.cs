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
	public class FundamentalsApi : IFundamentalsApi
	{
		private ExceptionFactory _exceptionFactory = (name, response) => null;

		/// <summary>
		///     Initializes a new instance of the <see cref="FundamentalsApi" /> class.
		/// </summary>
		/// <returns></returns>
		public FundamentalsApi(string basePath)
		{
			Configuration = new Configuration {BasePath = basePath};

			ExceptionFactory = Configuration.DefaultExceptionFactory;
		}

		/// <summary>
		///     Initializes a new instance of the <see cref="FundamentalsApi" /> class
		///     using Configuration object
		/// </summary>
		/// <param name="configuration">An instance of Configuration</param>
		/// <returns></returns>
		public FundamentalsApi(Configuration configuration = null)
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
		///     Fundamental by ID Returns detailed fundamental data for the given &#x60;id&#x60;.
		/// </summary>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="id">The Intrinio ID for the Fundamental</param>
		/// <returns>Fundamental</returns>
		public Fundamental GetFundamentalById(string id)
		{
			var localVarResponse = GetFundamentalByIdWithHttpInfo(id);
			return localVarResponse.Data;
		}

		/// <summary>
		///     Fundamental by ID Returns detailed fundamental data for the given &#x60;id&#x60;.
		/// </summary>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="id">The Intrinio ID for the Fundamental</param>
		/// <returns>ApiResponse of Fundamental</returns>
		public ApiResponse<Fundamental> GetFundamentalByIdWithHttpInfo(string id)
		{
			// verify the required parameter 'id' is set
			if (id == null)
				throw new ApiException(400,
					"Missing required parameter 'id' when calling FundamentalsApi->GetFundamentalById");

			var localVarPath = "/fundamentals/{id}";
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


			if (id != null)
				localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter

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
				var exception = ExceptionFactory("GetFundamentalById", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<Fundamental>(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(Fundamental) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Fundamental)));
		}

		/// <summary>
		///     Fundamental by ID Returns detailed fundamental data for the given &#x60;id&#x60;.
		/// </summary>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="id">The Intrinio ID for the Fundamental</param>
		/// <returns>Task of Fundamental</returns>
		public async Task<Fundamental> GetFundamentalByIdAsync(string id)
		{
			var localVarResponse = await GetFundamentalByIdAsyncWithHttpInfo(id);
			return localVarResponse.Data;
		}

		/// <summary>
		///     Fundamental by ID Returns detailed fundamental data for the given &#x60;id&#x60;.
		/// </summary>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="id">The Intrinio ID for the Fundamental</param>
		/// <returns>Task of ApiResponse (Fundamental)</returns>
		public async Task<ApiResponse<Fundamental>> GetFundamentalByIdAsyncWithHttpInfo(string id)
		{
			// verify the required parameter 'id' is set
			if (id == null)
				throw new ApiException(400,
					"Missing required parameter 'id' when calling FundamentalsApi->GetFundamentalById");

			var localVarPath = "/fundamentals/{id}";
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


			if (id != null)
				localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter

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
				var exception = ExceptionFactory("GetFundamentalById", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<Fundamental>(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(Fundamental) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Fundamental)));
		}

		/// <summary>
		///     Reported Financials Returns the As-Reported Financials directly from the financial statements of the XBRL filings
		///     from the company
		/// </summary>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="id">The Intrinio ID or lookup code (ticker-statement-year-period) for the Fundamental</param>
		/// <returns>ApiResponseReportedFinancials</returns>
		public ApiResponseReportedFinancials GetFundamentalReportedFinancials(string id)
		{
			var localVarResponse = GetFundamentalReportedFinancialsWithHttpInfo(id);
			return localVarResponse.Data;
		}

		/// <summary>
		///     Reported Financials Returns the As-Reported Financials directly from the financial statements of the XBRL filings
		///     from the company
		/// </summary>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="id">The Intrinio ID or lookup code (ticker-statement-year-period) for the Fundamental</param>
		/// <returns>ApiResponse of ApiResponseReportedFinancials</returns>
		public ApiResponse<ApiResponseReportedFinancials> GetFundamentalReportedFinancialsWithHttpInfo(string id)
		{
			// verify the required parameter 'id' is set
			if (id == null)
				throw new ApiException(400,
					"Missing required parameter 'id' when calling FundamentalsApi->GetFundamentalReportedFinancials");

			var localVarPath = "/fundamentals/{id}/reported_financials";
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


			if (id != null)
				localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter

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
				var exception = ExceptionFactory("GetFundamentalReportedFinancials", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<ApiResponseReportedFinancials>(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(ApiResponseReportedFinancials) Configuration.ApiClient.Deserialize(localVarResponse,
					typeof(ApiResponseReportedFinancials)));
		}

		/// <summary>
		///     Reported Financials Returns the As-Reported Financials directly from the financial statements of the XBRL filings
		///     from the company
		/// </summary>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="id">The Intrinio ID or lookup code (ticker-statement-year-period) for the Fundamental</param>
		/// <returns>Task of ApiResponseReportedFinancials</returns>
		public async Task<ApiResponseReportedFinancials> GetFundamentalReportedFinancialsAsync(string id)
		{
			var localVarResponse = await GetFundamentalReportedFinancialsAsyncWithHttpInfo(id);
			return localVarResponse.Data;
		}

		/// <summary>
		///     Reported Financials Returns the As-Reported Financials directly from the financial statements of the XBRL filings
		///     from the company
		/// </summary>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="id">The Intrinio ID or lookup code (ticker-statement-year-period) for the Fundamental</param>
		/// <returns>Task of ApiResponse (ApiResponseReportedFinancials)</returns>
		public async Task<ApiResponse<ApiResponseReportedFinancials>>
			GetFundamentalReportedFinancialsAsyncWithHttpInfo(string id)
		{
			// verify the required parameter 'id' is set
			if (id == null)
				throw new ApiException(400,
					"Missing required parameter 'id' when calling FundamentalsApi->GetFundamentalReportedFinancials");

			var localVarPath = "/fundamentals/{id}/reported_financials";
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


			if (id != null)
				localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter

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
				var exception = ExceptionFactory("GetFundamentalReportedFinancials", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<ApiResponseReportedFinancials>(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(ApiResponseReportedFinancials) Configuration.ApiClient.Deserialize(localVarResponse,
					typeof(ApiResponseReportedFinancials)));
		}

		/// <summary>
		///     Standardized Financials Returns professional-grade historical financial data. This data is standardized, cleansed
		///     and verified to ensure the highest quality data sourced directly from the XBRL financial statements. The primary
		///     purpose of standardized financials are to facilitate comparability across a single company’s fundamentals and
		///     across all companies&#39; fundamentals.
		/// </summary>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="id">The Intrinio ID or lookup code (ticker-statement-year-period) for the Fundamental</param>
		/// <returns>ApiResponseStandardizedFinancials</returns>
		public ApiResponseStandardizedFinancials GetFundamentalStandardizedFinancials(string id)
		{
			var localVarResponse = GetFundamentalStandardizedFinancialsWithHttpInfo(id);
			return localVarResponse.Data;
		}

		/// <summary>
		///     Standardized Financials Returns professional-grade historical financial data. This data is standardized, cleansed
		///     and verified to ensure the highest quality data sourced directly from the XBRL financial statements. The primary
		///     purpose of standardized financials are to facilitate comparability across a single company’s fundamentals and
		///     across all companies&#39; fundamentals.
		/// </summary>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="id">The Intrinio ID or lookup code (ticker-statement-year-period) for the Fundamental</param>
		/// <returns>ApiResponse of ApiResponseStandardizedFinancials</returns>
		public ApiResponse<ApiResponseStandardizedFinancials> GetFundamentalStandardizedFinancialsWithHttpInfo(
			string id)
		{
			// verify the required parameter 'id' is set
			if (id == null)
				throw new ApiException(400,
					"Missing required parameter 'id' when calling FundamentalsApi->GetFundamentalStandardizedFinancials");

			var localVarPath = "/fundamentals/{id}/standardized_financials";
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


			if (id != null)
				localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter

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
				var exception = ExceptionFactory("GetFundamentalStandardizedFinancials", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<ApiResponseStandardizedFinancials>(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(ApiResponseStandardizedFinancials) Configuration.ApiClient.Deserialize(localVarResponse,
					typeof(ApiResponseStandardizedFinancials)));
		}

		/// <summary>
		///     Standardized Financials Returns professional-grade historical financial data. This data is standardized, cleansed
		///     and verified to ensure the highest quality data sourced directly from the XBRL financial statements. The primary
		///     purpose of standardized financials are to facilitate comparability across a single company’s fundamentals and
		///     across all companies&#39; fundamentals.
		/// </summary>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="id">The Intrinio ID or lookup code (ticker-statement-year-period) for the Fundamental</param>
		/// <returns>Task of ApiResponseStandardizedFinancials</returns>
		public async Task<ApiResponseStandardizedFinancials> GetFundamentalStandardizedFinancialsAsync(string id)
		{
			var localVarResponse = await GetFundamentalStandardizedFinancialsAsyncWithHttpInfo(id);
			return localVarResponse.Data;
		}

		/// <summary>
		///     Standardized Financials Returns professional-grade historical financial data. This data is standardized, cleansed
		///     and verified to ensure the highest quality data sourced directly from the XBRL financial statements. The primary
		///     purpose of standardized financials are to facilitate comparability across a single company’s fundamentals and
		///     across all companies&#39; fundamentals.
		/// </summary>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="id">The Intrinio ID or lookup code (ticker-statement-year-period) for the Fundamental</param>
		/// <returns>Task of ApiResponse (ApiResponseStandardizedFinancials)</returns>
		public async Task<ApiResponse<ApiResponseStandardizedFinancials>>
			GetFundamentalStandardizedFinancialsAsyncWithHttpInfo(string id)
		{
			// verify the required parameter 'id' is set
			if (id == null)
				throw new ApiException(400,
					"Missing required parameter 'id' when calling FundamentalsApi->GetFundamentalStandardizedFinancials");

			var localVarPath = "/fundamentals/{id}/standardized_financials";
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


			if (id != null)
				localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter

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
				var exception = ExceptionFactory("GetFundamentalStandardizedFinancials", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<ApiResponseStandardizedFinancials>(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(ApiResponseStandardizedFinancials) Configuration.ApiClient.Deserialize(localVarResponse,
					typeof(ApiResponseStandardizedFinancials)));
		}

		/// <summary>
		///     Lookup Fundamental Returns the Fundamental for the Company with the given &#x60;identifier&#x60; and with the given
		///     parameters
		/// </summary>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
		/// <param name="statementCode">The statement code</param>
		/// <param name="fiscalYear">The fiscal year</param>
		/// <param name="fiscalPeriod">The fiscal period</param>
		/// <returns>Fundamental</returns>
		public Fundamental LookupFundamental(string identifier, string statementCode, int? fiscalYear,
			string fiscalPeriod)
		{
			var localVarResponse = LookupFundamentalWithHttpInfo(identifier, statementCode, fiscalYear, fiscalPeriod);
			return localVarResponse.Data;
		}

		/// <summary>
		///     Lookup Fundamental Returns the Fundamental for the Company with the given &#x60;identifier&#x60; and with the given
		///     parameters
		/// </summary>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
		/// <param name="statementCode">The statement code</param>
		/// <param name="fiscalYear">The fiscal year</param>
		/// <param name="fiscalPeriod">The fiscal period</param>
		/// <returns>ApiResponse of Fundamental</returns>
		public ApiResponse<Fundamental> LookupFundamentalWithHttpInfo(string identifier, string statementCode,
			int? fiscalYear, string fiscalPeriod)
		{
			// verify the required parameter 'identifier' is set
			if (identifier == null)
				throw new ApiException(400,
					"Missing required parameter 'identifier' when calling FundamentalsApi->LookupFundamental");
			// verify the required parameter 'statementCode' is set
			if (statementCode == null)
				throw new ApiException(400,
					"Missing required parameter 'statementCode' when calling FundamentalsApi->LookupFundamental");
			// verify the required parameter 'fiscalYear' is set
			if (fiscalYear == null)
				throw new ApiException(400,
					"Missing required parameter 'fiscalYear' when calling FundamentalsApi->LookupFundamental");
			// verify the required parameter 'fiscalPeriod' is set
			if (fiscalPeriod == null)
				throw new ApiException(400,
					"Missing required parameter 'fiscalPeriod' when calling FundamentalsApi->LookupFundamental");

			var localVarPath = "/fundamentals/lookup/{identifier}/{statement_code}/{fiscal_year}/{fiscal_period}";
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
			if (statementCode != null)
				localVarPathParams.Add("statement_code",
					Configuration.ApiClient.ParameterToString(statementCode)); // path parameter
			if (fiscalYear != null)
				localVarPathParams.Add("fiscal_year",
					Configuration.ApiClient.ParameterToString(fiscalYear)); // path parameter
			if (fiscalPeriod != null)
				localVarPathParams.Add("fiscal_period",
					Configuration.ApiClient.ParameterToString(fiscalPeriod)); // path parameter

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
				var exception = ExceptionFactory("LookupFundamental", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<Fundamental>(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(Fundamental) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Fundamental)));
		}

		/// <summary>
		///     Lookup Fundamental Returns the Fundamental for the Company with the given &#x60;identifier&#x60; and with the given
		///     parameters
		/// </summary>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
		/// <param name="statementCode">The statement code</param>
		/// <param name="fiscalYear">The fiscal year</param>
		/// <param name="fiscalPeriod">The fiscal period</param>
		/// <returns>Task of Fundamental</returns>
		public async Task<Fundamental> LookupFundamentalAsync(string identifier, string statementCode, int? fiscalYear,
			string fiscalPeriod)
		{
			var localVarResponse =
				await LookupFundamentalAsyncWithHttpInfo(identifier, statementCode, fiscalYear, fiscalPeriod);
			return localVarResponse.Data;
		}

		/// <summary>
		///     Lookup Fundamental Returns the Fundamental for the Company with the given &#x60;identifier&#x60; and with the given
		///     parameters
		/// </summary>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">A Company identifier (Ticker, CIK, LEI, Intrinio ID)</param>
		/// <param name="statementCode">The statement code</param>
		/// <param name="fiscalYear">The fiscal year</param>
		/// <param name="fiscalPeriod">The fiscal period</param>
		/// <returns>Task of ApiResponse (Fundamental)</returns>
		public async Task<ApiResponse<Fundamental>> LookupFundamentalAsyncWithHttpInfo(string identifier,
			string statementCode, int? fiscalYear, string fiscalPeriod)
		{
			// verify the required parameter 'identifier' is set
			if (identifier == null)
				throw new ApiException(400,
					"Missing required parameter 'identifier' when calling FundamentalsApi->LookupFundamental");
			// verify the required parameter 'statementCode' is set
			if (statementCode == null)
				throw new ApiException(400,
					"Missing required parameter 'statementCode' when calling FundamentalsApi->LookupFundamental");
			// verify the required parameter 'fiscalYear' is set
			if (fiscalYear == null)
				throw new ApiException(400,
					"Missing required parameter 'fiscalYear' when calling FundamentalsApi->LookupFundamental");
			// verify the required parameter 'fiscalPeriod' is set
			if (fiscalPeriod == null)
				throw new ApiException(400,
					"Missing required parameter 'fiscalPeriod' when calling FundamentalsApi->LookupFundamental");

			var localVarPath = "/fundamentals/lookup/{identifier}/{statement_code}/{fiscal_year}/{fiscal_period}";
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
			if (statementCode != null)
				localVarPathParams.Add("statement_code",
					Configuration.ApiClient.ParameterToString(statementCode)); // path parameter
			if (fiscalYear != null)
				localVarPathParams.Add("fiscal_year",
					Configuration.ApiClient.ParameterToString(fiscalYear)); // path parameter
			if (fiscalPeriod != null)
				localVarPathParams.Add("fiscal_period",
					Configuration.ApiClient.ParameterToString(fiscalPeriod)); // path parameter

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
				var exception = ExceptionFactory("LookupFundamental", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<Fundamental>(localVarStatusCode,
				localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
				(Fundamental) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Fundamental)));
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