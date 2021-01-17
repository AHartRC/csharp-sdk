using System.Threading.Tasks;
using Intrinio.SDK.Client;
using Intrinio.SDK.Model;
using Intrinio.SDK.Model.ApiResponse;

namespace Intrinio.SDK.Interface
{
	/// <summary>
	///     Represents a collection of functions to interact with the API endpoints
	/// </summary>
	public interface ITechnicalApi : IApiAccessor
	{
		#region Synchronous Operations

		/// <summary>
		///     Accumulation/Distribution Index
		/// </summary>
		/// <remarks>
		///     Returns the Accumulation/Distribution Index values of Stock Prices for the Security with the given &#x60;identifier
		///     &#x60;
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
		/// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
		/// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>ApiResponseSecurityAccumulationDistributionIndex</returns>
		ApiResponseSecurityAccumulationDistributionIndex GetSecurityPriceTechnicalsAdi(string identifier,
			string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null);

		/// <summary>
		///     Accumulation/Distribution Index
		/// </summary>
		/// <remarks>
		///     Returns the Accumulation/Distribution Index values of Stock Prices for the Security with the given &#x60;identifier
		///     &#x60;
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
		/// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
		/// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>ApiResponse of ApiResponseSecurityAccumulationDistributionIndex</returns>
		ApiResponse<ApiResponseSecurityAccumulationDistributionIndex> GetSecurityPriceTechnicalsAdiWithHttpInfo(
			string identifier, string startDate = null, string endDate = null, int? pageSize = null,
			string nextPage = null);

		/// <summary>
		///     Average Daily Trading Volume
		/// </summary>
		/// <remarks>
		///     Returns the Average Daily Trading Volume values of Stock Prices for the Security with the given &#x60;identifier
		///     &#x60;
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
		/// <param name="period">
		///     The number of observations, per period, to calculate Average Daily Trading Volume (optional,
		///     default to 22)
		/// </param>
		/// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
		/// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>ApiResponseSecurityAverageDailyTradingVolume</returns>
		ApiResponseSecurityAverageDailyTradingVolume GetSecurityPriceTechnicalsAdtv(string identifier,
			int? period = null, string startDate = null, string endDate = null, int? pageSize = null,
			string nextPage = null);

		/// <summary>
		///     Average Daily Trading Volume
		/// </summary>
		/// <remarks>
		///     Returns the Average Daily Trading Volume values of Stock Prices for the Security with the given &#x60;identifier
		///     &#x60;
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
		/// <param name="period">
		///     The number of observations, per period, to calculate Average Daily Trading Volume (optional,
		///     default to 22)
		/// </param>
		/// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
		/// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>ApiResponse of ApiResponseSecurityAverageDailyTradingVolume</returns>
		ApiResponse<ApiResponseSecurityAverageDailyTradingVolume> GetSecurityPriceTechnicalsAdtvWithHttpInfo(
			string identifier, int? period = null, string startDate = null, string endDate = null, int? pageSize = null,
			string nextPage = null);

		/// <summary>
		///     Average Directional Index
		/// </summary>
		/// <remarks>
		///     Returns the Average Directional Index values of Stock Prices for the Security with the given &#x60;identifier&#x60;
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
		/// <param name="period">
		///     The number of observations, per period, to calculate Average Directional Index (optional, default
		///     to 14)
		/// </param>
		/// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
		/// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>ApiResponseSecurityAverageDirectionalIndex</returns>
		ApiResponseSecurityAverageDirectionalIndex GetSecurityPriceTechnicalsAdx(string identifier, int? period = null,
			string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null);

		/// <summary>
		///     Average Directional Index
		/// </summary>
		/// <remarks>
		///     Returns the Average Directional Index values of Stock Prices for the Security with the given &#x60;identifier&#x60;
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
		/// <param name="period">
		///     The number of observations, per period, to calculate Average Directional Index (optional, default
		///     to 14)
		/// </param>
		/// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
		/// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>ApiResponse of ApiResponseSecurityAverageDirectionalIndex</returns>
		ApiResponse<ApiResponseSecurityAverageDirectionalIndex> GetSecurityPriceTechnicalsAdxWithHttpInfo(
			string identifier, int? period = null, string startDate = null, string endDate = null, int? pageSize = null,
			string nextPage = null);

		/// <summary>
		///     Awesome Oscillator
		/// </summary>
		/// <remarks>
		///     Returns the Awesome Oscillator values of Stock Prices for the Security with the given &#x60;identifier&#x60;
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
		/// <param name="shortPeriod">
		///     The number of observations, per period, to calculate short period Simple Moving Average of
		///     the Awesome Oscillator (optional, default to 5)
		/// </param>
		/// <param name="longPeriod">
		///     The number of observations, per period, to calculate long period Simple Moving Average of the
		///     Awesome Oscillator (optional, default to 34)
		/// </param>
		/// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
		/// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>ApiResponseSecurityAwesomeOscillator</returns>
		ApiResponseSecurityAwesomeOscillator GetSecurityPriceTechnicalsAo(string identifier, int? shortPeriod = null,
			int? longPeriod = null, string startDate = null, string endDate = null, int? pageSize = null,
			string nextPage = null);

		/// <summary>
		///     Awesome Oscillator
		/// </summary>
		/// <remarks>
		///     Returns the Awesome Oscillator values of Stock Prices for the Security with the given &#x60;identifier&#x60;
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
		/// <param name="shortPeriod">
		///     The number of observations, per period, to calculate short period Simple Moving Average of
		///     the Awesome Oscillator (optional, default to 5)
		/// </param>
		/// <param name="longPeriod">
		///     The number of observations, per period, to calculate long period Simple Moving Average of the
		///     Awesome Oscillator (optional, default to 34)
		/// </param>
		/// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
		/// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>ApiResponse of ApiResponseSecurityAwesomeOscillator</returns>
		ApiResponse<ApiResponseSecurityAwesomeOscillator> GetSecurityPriceTechnicalsAoWithHttpInfo(string identifier,
			int? shortPeriod = null, int? longPeriod = null, string startDate = null, string endDate = null,
			int? pageSize = null, string nextPage = null);

		/// <summary>
		///     Average True Range
		/// </summary>
		/// <remarks>
		///     Returns the Average True Range values of Stock Prices for the Security with the given &#x60;identifier&#x60;
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
		/// <param name="period">The number of observations, per period, to calculate Average True Range (optional, default to 14)</param>
		/// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
		/// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>ApiResponseSecurityAverageTrueRange</returns>
		ApiResponseSecurityAverageTrueRange GetSecurityPriceTechnicalsAtr(string identifier, int? period = null,
			string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null);

		/// <summary>
		///     Average True Range
		/// </summary>
		/// <remarks>
		///     Returns the Average True Range values of Stock Prices for the Security with the given &#x60;identifier&#x60;
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
		/// <param name="period">The number of observations, per period, to calculate Average True Range (optional, default to 14)</param>
		/// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
		/// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>ApiResponse of ApiResponseSecurityAverageTrueRange</returns>
		ApiResponse<ApiResponseSecurityAverageTrueRange> GetSecurityPriceTechnicalsAtrWithHttpInfo(string identifier,
			int? period = null, string startDate = null, string endDate = null, int? pageSize = null,
			string nextPage = null);

		/// <summary>
		///     Bollinger Bands
		/// </summary>
		/// <remarks>
		///     Returns the Bollinger Bands values of Stock Prices for the Security with the given &#x60;identifier&#x60;
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
		/// <param name="period">The number of observations, per period, to calculate Bollinger Bands (optional, default to 20)</param>
		/// <param name="standardDeviations">
		///     The number of standard deviations to calculate the upper and lower bands of the
		///     Bollinger Bands (optional, default to 2.0)
		/// </param>
		/// <param name="priceKey">The Stock Price field to use when calculating Bollinger Bands (optional, default to close)</param>
		/// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
		/// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>ApiResponseSecurityBollingerBands</returns>
		ApiResponseSecurityBollingerBands GetSecurityPriceTechnicalsBb(string identifier, int? period = null,
			float? standardDeviations = null, string priceKey = null, string startDate = null, string endDate = null,
			int? pageSize = null, string nextPage = null);

		/// <summary>
		///     Bollinger Bands
		/// </summary>
		/// <remarks>
		///     Returns the Bollinger Bands values of Stock Prices for the Security with the given &#x60;identifier&#x60;
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
		/// <param name="period">The number of observations, per period, to calculate Bollinger Bands (optional, default to 20)</param>
		/// <param name="standardDeviations">
		///     The number of standard deviations to calculate the upper and lower bands of the
		///     Bollinger Bands (optional, default to 2.0)
		/// </param>
		/// <param name="priceKey">The Stock Price field to use when calculating Bollinger Bands (optional, default to close)</param>
		/// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
		/// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>ApiResponse of ApiResponseSecurityBollingerBands</returns>
		ApiResponse<ApiResponseSecurityBollingerBands> GetSecurityPriceTechnicalsBbWithHttpInfo(string identifier,
			int? period = null, float? standardDeviations = null, string priceKey = null, string startDate = null,
			string endDate = null, int? pageSize = null, string nextPage = null);

		/// <summary>
		///     Commodity Channel Index
		/// </summary>
		/// <remarks>
		///     Returns the Commodity Channel Index values of Stock Prices for the Security with the given &#x60;identifier&#x60;
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
		/// <param name="period">
		///     The number of observations, per period, to calculate Commodity Channel Index (optional, default to
		///     20)
		/// </param>
		/// <param name="constant">
		///     The number of observations, per period, to calculate Commodity Channel Index (optional, default
		///     to 0.015)
		/// </param>
		/// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
		/// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>ApiResponseSecurityCommodityChannelIndex</returns>
		ApiResponseSecurityCommodityChannelIndex GetSecurityPriceTechnicalsCci(string identifier, int? period = null,
			float? constant = null, string startDate = null, string endDate = null, int? pageSize = null,
			string nextPage = null);

		/// <summary>
		///     Commodity Channel Index
		/// </summary>
		/// <remarks>
		///     Returns the Commodity Channel Index values of Stock Prices for the Security with the given &#x60;identifier&#x60;
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
		/// <param name="period">
		///     The number of observations, per period, to calculate Commodity Channel Index (optional, default to
		///     20)
		/// </param>
		/// <param name="constant">
		///     The number of observations, per period, to calculate Commodity Channel Index (optional, default
		///     to 0.015)
		/// </param>
		/// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
		/// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>ApiResponse of ApiResponseSecurityCommodityChannelIndex</returns>
		ApiResponse<ApiResponseSecurityCommodityChannelIndex> GetSecurityPriceTechnicalsCciWithHttpInfo(
			string identifier, int? period = null, float? constant = null, string startDate = null,
			string endDate = null, int? pageSize = null, string nextPage = null);

		/// <summary>
		///     Chaikin Money Flow
		/// </summary>
		/// <remarks>
		///     Returns the Chaikin Money Flow values of Stock Prices for the Security with the given &#x60;identifier&#x60;
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
		/// <param name="period">The number of observations, per period, to calculate Chaikin Money Flow (optional, default to 20)</param>
		/// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
		/// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>ApiResponseSecurityChaikinMoneyFlow</returns>
		ApiResponseSecurityChaikinMoneyFlow GetSecurityPriceTechnicalsCmf(string identifier, int? period = null,
			string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null);

		/// <summary>
		///     Chaikin Money Flow
		/// </summary>
		/// <remarks>
		///     Returns the Chaikin Money Flow values of Stock Prices for the Security with the given &#x60;identifier&#x60;
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
		/// <param name="period">The number of observations, per period, to calculate Chaikin Money Flow (optional, default to 20)</param>
		/// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
		/// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>ApiResponse of ApiResponseSecurityChaikinMoneyFlow</returns>
		ApiResponse<ApiResponseSecurityChaikinMoneyFlow> GetSecurityPriceTechnicalsCmfWithHttpInfo(string identifier,
			int? period = null, string startDate = null, string endDate = null, int? pageSize = null,
			string nextPage = null);

		/// <summary>
		///     Donchian Channel
		/// </summary>
		/// <remarks>
		///     Returns the Donchian Channel values of Stock Prices for the Security with the given &#x60;identifier&#x60;
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
		/// <param name="period">The number of observations, per period, to calculate Donchian Channel (optional, default to 20)</param>
		/// <param name="priceKey">The Stock Price field to use when calculating Donchian Channel (optional, default to close)</param>
		/// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
		/// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>ApiResponseSecurityDonchianChannel</returns>
		ApiResponseSecurityDonchianChannel GetSecurityPriceTechnicalsDc(string identifier, int? period = null,
			string priceKey = null, string startDate = null, string endDate = null, int? pageSize = null,
			string nextPage = null);

		/// <summary>
		///     Donchian Channel
		/// </summary>
		/// <remarks>
		///     Returns the Donchian Channel values of Stock Prices for the Security with the given &#x60;identifier&#x60;
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
		/// <param name="period">The number of observations, per period, to calculate Donchian Channel (optional, default to 20)</param>
		/// <param name="priceKey">The Stock Price field to use when calculating Donchian Channel (optional, default to close)</param>
		/// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
		/// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>ApiResponse of ApiResponseSecurityDonchianChannel</returns>
		ApiResponse<ApiResponseSecurityDonchianChannel> GetSecurityPriceTechnicalsDcWithHttpInfo(string identifier,
			int? period = null, string priceKey = null, string startDate = null, string endDate = null,
			int? pageSize = null, string nextPage = null);

		/// <summary>
		///     Detrended Price Oscillator
		/// </summary>
		/// <remarks>
		///     Returns the Detrended Price Oscillator values of Stock Prices for the Security with the given &#x60;identifier
		///     &#x60;
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
		/// <param name="period">
		///     The number of observations, per period, to calculate Detrended Price Oscillator (optional, default
		///     to 20)
		/// </param>
		/// <param name="priceKey">
		///     The Stock Price field to use when calculating Detrended Price Oscillator (optional, default to
		///     close)
		/// </param>
		/// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
		/// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>ApiResponseSecurityDetrendedPriceOscillator</returns>
		ApiResponseSecurityDetrendedPriceOscillator GetSecurityPriceTechnicalsDpo(string identifier, int? period = null,
			string priceKey = null, string startDate = null, string endDate = null, int? pageSize = null,
			string nextPage = null);

		/// <summary>
		///     Detrended Price Oscillator
		/// </summary>
		/// <remarks>
		///     Returns the Detrended Price Oscillator values of Stock Prices for the Security with the given &#x60;identifier
		///     &#x60;
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
		/// <param name="period">
		///     The number of observations, per period, to calculate Detrended Price Oscillator (optional, default
		///     to 20)
		/// </param>
		/// <param name="priceKey">
		///     The Stock Price field to use when calculating Detrended Price Oscillator (optional, default to
		///     close)
		/// </param>
		/// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
		/// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>ApiResponse of ApiResponseSecurityDetrendedPriceOscillator</returns>
		ApiResponse<ApiResponseSecurityDetrendedPriceOscillator> GetSecurityPriceTechnicalsDpoWithHttpInfo(
			string identifier, int? period = null, string priceKey = null, string startDate = null,
			string endDate = null, int? pageSize = null, string nextPage = null);

		/// <summary>
		///     Ease of Movement
		/// </summary>
		/// <remarks>
		///     Returns the Ease of Movement values of Stock Prices for the Security with the given &#x60;identifier&#x60;
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
		/// <param name="period">The number of observations, per period, to calculate Ease of Movement (optional, default to 20)</param>
		/// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
		/// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>ApiResponseSecurityEaseOfMovement</returns>
		ApiResponseSecurityEaseOfMovement GetSecurityPriceTechnicalsEom(string identifier, int? period = null,
			string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null);

		/// <summary>
		///     Ease of Movement
		/// </summary>
		/// <remarks>
		///     Returns the Ease of Movement values of Stock Prices for the Security with the given &#x60;identifier&#x60;
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
		/// <param name="period">The number of observations, per period, to calculate Ease of Movement (optional, default to 20)</param>
		/// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
		/// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>ApiResponse of ApiResponseSecurityEaseOfMovement</returns>
		ApiResponse<ApiResponseSecurityEaseOfMovement> GetSecurityPriceTechnicalsEomWithHttpInfo(string identifier,
			int? period = null, string startDate = null, string endDate = null, int? pageSize = null,
			string nextPage = null);

		/// <summary>
		///     Force Index
		/// </summary>
		/// <remarks>
		///     Returns the Force Index values of Stock Prices for the Security with the given &#x60;identifier&#x60;
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
		/// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
		/// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>ApiResponseSecurityForceIndex</returns>
		ApiResponseSecurityForceIndex GetSecurityPriceTechnicalsFi(string identifier, string startDate = null,
			string endDate = null, int? pageSize = null, string nextPage = null);

		/// <summary>
		///     Force Index
		/// </summary>
		/// <remarks>
		///     Returns the Force Index values of Stock Prices for the Security with the given &#x60;identifier&#x60;
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
		/// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
		/// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>ApiResponse of ApiResponseSecurityForceIndex</returns>
		ApiResponse<ApiResponseSecurityForceIndex> GetSecurityPriceTechnicalsFiWithHttpInfo(string identifier,
			string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null);

		/// <summary>
		///     Ichimoku Kinko Hyo
		/// </summary>
		/// <remarks>
		///     Returns the Ichimoku Kinko Hyo values of Stock Prices for the Security with the given &#x60;identifier&#x60;
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
		/// <param name="lowPeriod">
		///     The number of observations, per period, to calculate Tenkan Sen (Conversion Line) of Ichimoku
		///     Kinko Hyo (optional, default to 9)
		/// </param>
		/// <param name="mediumPeriod">
		///     The number of observations, per period, to calculate Kijun Sen (Base Line), Senkou Span A
		///     (Leading Span A), and Chikou Span (Lagging Span) of Ichimoku Kinko Hyo (optional, default to 26)
		/// </param>
		/// <param name="highPeriod">
		///     The number of observations, per period, to calculate Senkou Span B (Leading Span B) of
		///     Ichimoku Kinko Hyo (optional, default to 52)
		/// </param>
		/// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
		/// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>ApiResponseSecurityIchimokuKinkoHyo</returns>
		ApiResponseSecurityIchimokuKinkoHyo GetSecurityPriceTechnicalsIchimoku(string identifier, int? lowPeriod = null,
			int? mediumPeriod = null, int? highPeriod = null, string startDate = null, string endDate = null,
			int? pageSize = null, string nextPage = null);

		/// <summary>
		///     Ichimoku Kinko Hyo
		/// </summary>
		/// <remarks>
		///     Returns the Ichimoku Kinko Hyo values of Stock Prices for the Security with the given &#x60;identifier&#x60;
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
		/// <param name="lowPeriod">
		///     The number of observations, per period, to calculate Tenkan Sen (Conversion Line) of Ichimoku
		///     Kinko Hyo (optional, default to 9)
		/// </param>
		/// <param name="mediumPeriod">
		///     The number of observations, per period, to calculate Kijun Sen (Base Line), Senkou Span A
		///     (Leading Span A), and Chikou Span (Lagging Span) of Ichimoku Kinko Hyo (optional, default to 26)
		/// </param>
		/// <param name="highPeriod">
		///     The number of observations, per period, to calculate Senkou Span B (Leading Span B) of
		///     Ichimoku Kinko Hyo (optional, default to 52)
		/// </param>
		/// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
		/// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>ApiResponse of ApiResponseSecurityIchimokuKinkoHyo</returns>
		ApiResponse<ApiResponseSecurityIchimokuKinkoHyo> GetSecurityPriceTechnicalsIchimokuWithHttpInfo(
			string identifier, int? lowPeriod = null, int? mediumPeriod = null, int? highPeriod = null,
			string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null);

		/// <summary>
		///     Keltner Channel
		/// </summary>
		/// <remarks>
		///     Returns the Keltner Channel values of Stock Prices for the Security with the given &#x60;identifier&#x60;
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
		/// <param name="period">The number of observations, per period, to calculate Kelter Channel (optional, default to 10)</param>
		/// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
		/// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>ApiResponseSecurityKeltnerChannel</returns>
		ApiResponseSecurityKeltnerChannel GetSecurityPriceTechnicalsKc(string identifier, int? period = null,
			string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null);

		/// <summary>
		///     Keltner Channel
		/// </summary>
		/// <remarks>
		///     Returns the Keltner Channel values of Stock Prices for the Security with the given &#x60;identifier&#x60;
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
		/// <param name="period">The number of observations, per period, to calculate Kelter Channel (optional, default to 10)</param>
		/// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
		/// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>ApiResponse of ApiResponseSecurityKeltnerChannel</returns>
		ApiResponse<ApiResponseSecurityKeltnerChannel> GetSecurityPriceTechnicalsKcWithHttpInfo(string identifier,
			int? period = null, string startDate = null, string endDate = null, int? pageSize = null,
			string nextPage = null);

		/// <summary>
		///     Know Sure Thing
		/// </summary>
		/// <remarks>
		///     Returns the Know Sure Thing values of Stock Prices for the Security with the given &#x60;identifier&#x60;
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
		/// <param name="roc1">
		///     The number of observations, per period, to calculate the rate-of-change for RCMA1 (optional, default
		///     to 10)
		/// </param>
		/// <param name="roc2">
		///     The number of observations, per period, to calculate the rate-of-change for RCMA2 (optional, default
		///     to 15)
		/// </param>
		/// <param name="roc3">
		///     The number of observations, per period, to calculate the rate-of-change for RCMA3 (optional, default
		///     to 20)
		/// </param>
		/// <param name="roc4">
		///     The number of observations, per period, to calculate the rate-of-change for RCMA4 (optional, default
		///     to 30)
		/// </param>
		/// <param name="sma1">
		///     The number of observations, per period, to calculate the Simple Moving Average of the rate-of-change
		///     for RCMA1 (optional, default to 10)
		/// </param>
		/// <param name="sma2">
		///     The number of observations, per period, to calculate the Simple Moving Average of the rate-of-change
		///     for RCMA2 (optional, default to 10)
		/// </param>
		/// <param name="sma3">
		///     The number of observations, per period, to calculate the Simple Moving Average of the rate-of-change
		///     for RCMA3 (optional, default to 10)
		/// </param>
		/// <param name="sma4">
		///     The number of observations, per period, to calculate the Simple Moving Average of the rate-of-change
		///     for RCMA4 (optional, default to 15)
		/// </param>
		/// <param name="priceKey">The Stock Price field to use when calculating Know Sure Thing (optional, default to close)</param>
		/// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
		/// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>ApiResponseSecurityKnowSureThing</returns>
		ApiResponseSecurityKnowSureThing GetSecurityPriceTechnicalsKst(string identifier, int? roc1 = null,
			int? roc2 = null, int? roc3 = null, int? roc4 = null, int? sma1 = null, int? sma2 = null, int? sma3 = null,
			int? sma4 = null, string priceKey = null, string startDate = null, string endDate = null,
			int? pageSize = null, string nextPage = null);

		/// <summary>
		///     Know Sure Thing
		/// </summary>
		/// <remarks>
		///     Returns the Know Sure Thing values of Stock Prices for the Security with the given &#x60;identifier&#x60;
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
		/// <param name="roc1">
		///     The number of observations, per period, to calculate the rate-of-change for RCMA1 (optional, default
		///     to 10)
		/// </param>
		/// <param name="roc2">
		///     The number of observations, per period, to calculate the rate-of-change for RCMA2 (optional, default
		///     to 15)
		/// </param>
		/// <param name="roc3">
		///     The number of observations, per period, to calculate the rate-of-change for RCMA3 (optional, default
		///     to 20)
		/// </param>
		/// <param name="roc4">
		///     The number of observations, per period, to calculate the rate-of-change for RCMA4 (optional, default
		///     to 30)
		/// </param>
		/// <param name="sma1">
		///     The number of observations, per period, to calculate the Simple Moving Average of the rate-of-change
		///     for RCMA1 (optional, default to 10)
		/// </param>
		/// <param name="sma2">
		///     The number of observations, per period, to calculate the Simple Moving Average of the rate-of-change
		///     for RCMA2 (optional, default to 10)
		/// </param>
		/// <param name="sma3">
		///     The number of observations, per period, to calculate the Simple Moving Average of the rate-of-change
		///     for RCMA3 (optional, default to 10)
		/// </param>
		/// <param name="sma4">
		///     The number of observations, per period, to calculate the Simple Moving Average of the rate-of-change
		///     for RCMA4 (optional, default to 15)
		/// </param>
		/// <param name="priceKey">The Stock Price field to use when calculating Know Sure Thing (optional, default to close)</param>
		/// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
		/// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>ApiResponse of ApiResponseSecurityKnowSureThing</returns>
		ApiResponse<ApiResponseSecurityKnowSureThing> GetSecurityPriceTechnicalsKstWithHttpInfo(string identifier,
			int? roc1 = null, int? roc2 = null, int? roc3 = null, int? roc4 = null, int? sma1 = null, int? sma2 = null,
			int? sma3 = null, int? sma4 = null, string priceKey = null, string startDate = null, string endDate = null,
			int? pageSize = null, string nextPage = null);

		/// <summary>
		///     Moving Average Convergence Divergence
		/// </summary>
		/// <remarks>
		///     Returns the Moving Average Convergence Divergence values of Stock Prices for the Security with the given &#x60;
		///     identifier&#x60;
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
		/// <param name="fastPeriod">
		///     The number of observations, per period, to calculate the fast moving Exponential Moving
		///     Average for Moving Average Convergence Divergence (optional, default to 12)
		/// </param>
		/// <param name="slowPeriod">
		///     The number of observations, per period, to calculate the slow moving Exponential Moving
		///     Average for Moving Average Convergence Divergence (optional, default to 26)
		/// </param>
		/// <param name="signalPeriod">
		///     The number of observations, per period, to calculate the signal line for Moving Average
		///     Convergence Divergence (optional, default to 9)
		/// </param>
		/// <param name="priceKey">
		///     The Stock Price field to use when calculating Moving Average Convergence Divergence (optional,
		///     default to close)
		/// </param>
		/// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
		/// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>ApiResponseSecurityMovingAverageConvergenceDivergence</returns>
		ApiResponseSecurityMovingAverageConvergenceDivergence GetSecurityPriceTechnicalsMacd(string identifier,
			int? fastPeriod = null, int? slowPeriod = null, int? signalPeriod = null, string priceKey = null,
			string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null);

		/// <summary>
		///     Moving Average Convergence Divergence
		/// </summary>
		/// <remarks>
		///     Returns the Moving Average Convergence Divergence values of Stock Prices for the Security with the given &#x60;
		///     identifier&#x60;
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
		/// <param name="fastPeriod">
		///     The number of observations, per period, to calculate the fast moving Exponential Moving
		///     Average for Moving Average Convergence Divergence (optional, default to 12)
		/// </param>
		/// <param name="slowPeriod">
		///     The number of observations, per period, to calculate the slow moving Exponential Moving
		///     Average for Moving Average Convergence Divergence (optional, default to 26)
		/// </param>
		/// <param name="signalPeriod">
		///     The number of observations, per period, to calculate the signal line for Moving Average
		///     Convergence Divergence (optional, default to 9)
		/// </param>
		/// <param name="priceKey">
		///     The Stock Price field to use when calculating Moving Average Convergence Divergence (optional,
		///     default to close)
		/// </param>
		/// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
		/// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>ApiResponse of ApiResponseSecurityMovingAverageConvergenceDivergence</returns>
		ApiResponse<ApiResponseSecurityMovingAverageConvergenceDivergence> GetSecurityPriceTechnicalsMacdWithHttpInfo(
			string identifier, int? fastPeriod = null, int? slowPeriod = null, int? signalPeriod = null,
			string priceKey = null, string startDate = null, string endDate = null, int? pageSize = null,
			string nextPage = null);

		/// <summary>
		///     Money Flow Index
		/// </summary>
		/// <remarks>
		///     Returns the Money Flow Index values of Stock Prices for the Security with the given &#x60;identifier&#x60;
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
		/// <param name="period">The number of observations, per period, to calculate Money Flow Index (optional, default to 14)</param>
		/// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
		/// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>ApiResponseSecurityMoneyFlowIndex</returns>
		ApiResponseSecurityMoneyFlowIndex GetSecurityPriceTechnicalsMfi(string identifier, int? period = null,
			string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null);

		/// <summary>
		///     Money Flow Index
		/// </summary>
		/// <remarks>
		///     Returns the Money Flow Index values of Stock Prices for the Security with the given &#x60;identifier&#x60;
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
		/// <param name="period">The number of observations, per period, to calculate Money Flow Index (optional, default to 14)</param>
		/// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
		/// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>ApiResponse of ApiResponseSecurityMoneyFlowIndex</returns>
		ApiResponse<ApiResponseSecurityMoneyFlowIndex> GetSecurityPriceTechnicalsMfiWithHttpInfo(string identifier,
			int? period = null, string startDate = null, string endDate = null, int? pageSize = null,
			string nextPage = null);

		/// <summary>
		///     Mass Index
		/// </summary>
		/// <remarks>
		///     Returns the Mass Index values of Stock Prices for the Security with the given &#x60;identifier&#x60;
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
		/// <param name="emaPeriod">
		///     The number of observations, per period, to calculate the single Exponential Moving Average and
		///     the Double Exponential Moving Average for Mass Index (optional, default to 9)
		/// </param>
		/// <param name="sumPeriod">
		///     The number of observations, per period, to calculate the sum of the Exponetinal Moving Average
		///     Ratios for Mass Index (optional, default to 25)
		/// </param>
		/// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
		/// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>ApiResponseSecurityMassIndex</returns>
		ApiResponseSecurityMassIndex GetSecurityPriceTechnicalsMi(string identifier, int? emaPeriod = null,
			int? sumPeriod = null, string startDate = null, string endDate = null, int? pageSize = null,
			string nextPage = null);

		/// <summary>
		///     Mass Index
		/// </summary>
		/// <remarks>
		///     Returns the Mass Index values of Stock Prices for the Security with the given &#x60;identifier&#x60;
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
		/// <param name="emaPeriod">
		///     The number of observations, per period, to calculate the single Exponential Moving Average and
		///     the Double Exponential Moving Average for Mass Index (optional, default to 9)
		/// </param>
		/// <param name="sumPeriod">
		///     The number of observations, per period, to calculate the sum of the Exponetinal Moving Average
		///     Ratios for Mass Index (optional, default to 25)
		/// </param>
		/// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
		/// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>ApiResponse of ApiResponseSecurityMassIndex</returns>
		ApiResponse<ApiResponseSecurityMassIndex> GetSecurityPriceTechnicalsMiWithHttpInfo(string identifier,
			int? emaPeriod = null, int? sumPeriod = null, string startDate = null, string endDate = null,
			int? pageSize = null, string nextPage = null);

		/// <summary>
		///     Negative Volume Index
		/// </summary>
		/// <remarks>
		///     Returns the Negative Volume Index values of Stock Prices for the Security with the given &#x60;identifier&#x60;
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
		/// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
		/// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>ApiResponseSecurityNegativeVolumeIndex</returns>
		ApiResponseSecurityNegativeVolumeIndex GetSecurityPriceTechnicalsNvi(string identifier, string startDate = null,
			string endDate = null, int? pageSize = null, string nextPage = null);

		/// <summary>
		///     Negative Volume Index
		/// </summary>
		/// <remarks>
		///     Returns the Negative Volume Index values of Stock Prices for the Security with the given &#x60;identifier&#x60;
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
		/// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
		/// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>ApiResponse of ApiResponseSecurityNegativeVolumeIndex</returns>
		ApiResponse<ApiResponseSecurityNegativeVolumeIndex> GetSecurityPriceTechnicalsNviWithHttpInfo(string identifier,
			string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null);

		/// <summary>
		///     On-balance Volume
		/// </summary>
		/// <remarks>
		///     Returns the On-balance Volume values of Stock Prices for the Security with the given &#x60;identifier&#x60;
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
		/// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
		/// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>ApiResponseSecurityOnBalanceVolume</returns>
		ApiResponseSecurityOnBalanceVolume GetSecurityPriceTechnicalsObv(string identifier, string startDate = null,
			string endDate = null, int? pageSize = null, string nextPage = null);

		/// <summary>
		///     On-balance Volume
		/// </summary>
		/// <remarks>
		///     Returns the On-balance Volume values of Stock Prices for the Security with the given &#x60;identifier&#x60;
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
		/// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
		/// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>ApiResponse of ApiResponseSecurityOnBalanceVolume</returns>
		ApiResponse<ApiResponseSecurityOnBalanceVolume> GetSecurityPriceTechnicalsObvWithHttpInfo(string identifier,
			string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null);

		/// <summary>
		///     On-balance Volume Mean
		/// </summary>
		/// <remarks>
		///     Returns the On-balance Volume Mean values of Stock Prices for the Security with the given &#x60;identifier&#x60;
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
		/// <param name="period">
		///     The number of observations, per period, to calculate On-balance Volume Mean (optional, default to
		///     10)
		/// </param>
		/// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
		/// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>ApiResponseSecurityOnBalanceVolumeMean</returns>
		ApiResponseSecurityOnBalanceVolumeMean GetSecurityPriceTechnicalsObvMean(string identifier, int? period = null,
			string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null);

		/// <summary>
		///     On-balance Volume Mean
		/// </summary>
		/// <remarks>
		///     Returns the On-balance Volume Mean values of Stock Prices for the Security with the given &#x60;identifier&#x60;
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
		/// <param name="period">
		///     The number of observations, per period, to calculate On-balance Volume Mean (optional, default to
		///     10)
		/// </param>
		/// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
		/// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>ApiResponse of ApiResponseSecurityOnBalanceVolumeMean</returns>
		ApiResponse<ApiResponseSecurityOnBalanceVolumeMean> GetSecurityPriceTechnicalsObvMeanWithHttpInfo(
			string identifier, int? period = null, string startDate = null, string endDate = null, int? pageSize = null,
			string nextPage = null);

		/// <summary>
		///     Relative Strength Index
		/// </summary>
		/// <remarks>
		///     Returns the Relative Strength Index values of Stock Prices for the Security with the given &#x60;identifier&#x60;
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
		/// <param name="period">
		///     The number of observations, per period, to calculate Relative Strength Index (optional, default to
		///     14)
		/// </param>
		/// <param name="priceKey">
		///     The Stock Price field to use when calculating Relative Strength Index (optional, default to
		///     close)
		/// </param>
		/// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
		/// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>ApiResponseSecurityRelativeStrengthIndex</returns>
		ApiResponseSecurityRelativeStrengthIndex GetSecurityPriceTechnicalsRsi(string identifier, int? period = null,
			string priceKey = null, string startDate = null, string endDate = null, int? pageSize = null,
			string nextPage = null);

		/// <summary>
		///     Relative Strength Index
		/// </summary>
		/// <remarks>
		///     Returns the Relative Strength Index values of Stock Prices for the Security with the given &#x60;identifier&#x60;
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
		/// <param name="period">
		///     The number of observations, per period, to calculate Relative Strength Index (optional, default to
		///     14)
		/// </param>
		/// <param name="priceKey">
		///     The Stock Price field to use when calculating Relative Strength Index (optional, default to
		///     close)
		/// </param>
		/// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
		/// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>ApiResponse of ApiResponseSecurityRelativeStrengthIndex</returns>
		ApiResponse<ApiResponseSecurityRelativeStrengthIndex> GetSecurityPriceTechnicalsRsiWithHttpInfo(
			string identifier, int? period = null, string priceKey = null, string startDate = null,
			string endDate = null, int? pageSize = null, string nextPage = null);

		/// <summary>
		///     Simple Moving Average
		/// </summary>
		/// <remarks>
		///     Returns the Simple Moving Average values of Stock Prices for the Security with the given &#x60;identifier&#x60;
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
		/// <param name="period">
		///     The number of observations, per period, to calculate Simple Moving Average (optional, default to
		///     20)
		/// </param>
		/// <param name="priceKey">The Stock Price field to use when calculating Simple Moving Average (optional, default to close)</param>
		/// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
		/// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>ApiResponseSecuritySimpleMovingAverage</returns>
		ApiResponseSecuritySimpleMovingAverage GetSecurityPriceTechnicalsSma(string identifier, int? period = null,
			string priceKey = null, string startDate = null, string endDate = null, int? pageSize = null,
			string nextPage = null);

		/// <summary>
		///     Simple Moving Average
		/// </summary>
		/// <remarks>
		///     Returns the Simple Moving Average values of Stock Prices for the Security with the given &#x60;identifier&#x60;
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
		/// <param name="period">
		///     The number of observations, per period, to calculate Simple Moving Average (optional, default to
		///     20)
		/// </param>
		/// <param name="priceKey">The Stock Price field to use when calculating Simple Moving Average (optional, default to close)</param>
		/// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
		/// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>ApiResponse of ApiResponseSecuritySimpleMovingAverage</returns>
		ApiResponse<ApiResponseSecuritySimpleMovingAverage> GetSecurityPriceTechnicalsSmaWithHttpInfo(string identifier,
			int? period = null, string priceKey = null, string startDate = null, string endDate = null,
			int? pageSize = null, string nextPage = null);

		/// <summary>
		///     Stochastic Oscillator
		/// </summary>
		/// <remarks>
		///     Returns the Stochastic Oscillator values of Stock Prices for the Security with the given &#x60;identifier&#x60;
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
		/// <param name="period">
		///     The number of observations, per period, to calculate %K of Stochastic Oscillator (optional,
		///     default to 14)
		/// </param>
		/// <param name="signalPeriod">
		///     The number of observations, per period, to calculate the %D (the Simple Moving Average of
		///     %K) as a signal line for Stochastic Oscillator (optional, default to 3)
		/// </param>
		/// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
		/// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>ApiResponseSecurityStochasticOscillator</returns>
		ApiResponseSecurityStochasticOscillator GetSecurityPriceTechnicalsSr(string identifier, int? period = null,
			int? signalPeriod = null, string startDate = null, string endDate = null, int? pageSize = null,
			string nextPage = null);

		/// <summary>
		///     Stochastic Oscillator
		/// </summary>
		/// <remarks>
		///     Returns the Stochastic Oscillator values of Stock Prices for the Security with the given &#x60;identifier&#x60;
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
		/// <param name="period">
		///     The number of observations, per period, to calculate %K of Stochastic Oscillator (optional,
		///     default to 14)
		/// </param>
		/// <param name="signalPeriod">
		///     The number of observations, per period, to calculate the %D (the Simple Moving Average of
		///     %K) as a signal line for Stochastic Oscillator (optional, default to 3)
		/// </param>
		/// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
		/// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>ApiResponse of ApiResponseSecurityStochasticOscillator</returns>
		ApiResponse<ApiResponseSecurityStochasticOscillator> GetSecurityPriceTechnicalsSrWithHttpInfo(string identifier,
			int? period = null, int? signalPeriod = null, string startDate = null, string endDate = null,
			int? pageSize = null, string nextPage = null);

		/// <summary>
		///     Triple Exponential Average
		/// </summary>
		/// <remarks>
		///     Returns the Simple Moving Average values of Stock Prices for the Security with the given &#x60;identifier&#x60;
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
		/// <param name="period">
		///     The number of observations, per period, to calculate Exponential Moving Average for Triple
		///     Exponential Average (optional, default to 15)
		/// </param>
		/// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
		/// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>ApiResponseSecurityTripleExponentialAverage</returns>
		ApiResponseSecurityTripleExponentialAverage GetSecurityPriceTechnicalsTrix(string identifier,
			int? period = null, string startDate = null, string endDate = null, int? pageSize = null,
			string nextPage = null);

		/// <summary>
		///     Triple Exponential Average
		/// </summary>
		/// <remarks>
		///     Returns the Simple Moving Average values of Stock Prices for the Security with the given &#x60;identifier&#x60;
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
		/// <param name="period">
		///     The number of observations, per period, to calculate Exponential Moving Average for Triple
		///     Exponential Average (optional, default to 15)
		/// </param>
		/// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
		/// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>ApiResponse of ApiResponseSecurityTripleExponentialAverage</returns>
		ApiResponse<ApiResponseSecurityTripleExponentialAverage> GetSecurityPriceTechnicalsTrixWithHttpInfo(
			string identifier, int? period = null, string startDate = null, string endDate = null, int? pageSize = null,
			string nextPage = null);

		/// <summary>
		///     True Strength Index
		/// </summary>
		/// <remarks>
		///     Returns the True Strength Index values of Stock Prices for the Security with the given &#x60;identifier&#x60;
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
		/// <param name="lowPeriod">
		///     The number of observations, per period, to calculate low period Exponential Moving Average for
		///     smoothing in True Strength Index (optional, default to 13)
		/// </param>
		/// <param name="highPeriod">
		///     The number of observations, per period, to calculate high period Exponential Moving Average
		///     for smoothing in True Strength Index (optional, default to 25)
		/// </param>
		/// <param name="priceKey">The Stock Price field to use when calculating True Strength Index (optional, default to close)</param>
		/// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
		/// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>ApiResponseSecurityTrueStrengthIndex</returns>
		ApiResponseSecurityTrueStrengthIndex GetSecurityPriceTechnicalsTsi(string identifier, int? lowPeriod = null,
			int? highPeriod = null, string priceKey = null, string startDate = null, string endDate = null,
			int? pageSize = null, string nextPage = null);

		/// <summary>
		///     True Strength Index
		/// </summary>
		/// <remarks>
		///     Returns the True Strength Index values of Stock Prices for the Security with the given &#x60;identifier&#x60;
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
		/// <param name="lowPeriod">
		///     The number of observations, per period, to calculate low period Exponential Moving Average for
		///     smoothing in True Strength Index (optional, default to 13)
		/// </param>
		/// <param name="highPeriod">
		///     The number of observations, per period, to calculate high period Exponential Moving Average
		///     for smoothing in True Strength Index (optional, default to 25)
		/// </param>
		/// <param name="priceKey">The Stock Price field to use when calculating True Strength Index (optional, default to close)</param>
		/// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
		/// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>ApiResponse of ApiResponseSecurityTrueStrengthIndex</returns>
		ApiResponse<ApiResponseSecurityTrueStrengthIndex> GetSecurityPriceTechnicalsTsiWithHttpInfo(string identifier,
			int? lowPeriod = null, int? highPeriod = null, string priceKey = null, string startDate = null,
			string endDate = null, int? pageSize = null, string nextPage = null);

		/// <summary>
		///     Ultimate Oscillator
		/// </summary>
		/// <remarks>
		///     Returns the Ultimate Oscillator values of Stock Prices for the Security with the given &#x60;identifier&#x60;
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
		/// <param name="shortPeriod">
		///     The number of observations, per period, to calculate the short period for Ultimate Oscillator
		///     (optional, default to 7)
		/// </param>
		/// <param name="mediumPeriod">
		///     The number of observations, per period, to calculate the medium period for Ultimate
		///     Oscillator (optional, default to 14)
		/// </param>
		/// <param name="longPeriod">
		///     The number of observations, per period, to calculate the long period for Ultimate Oscillator
		///     (optional, default to 28)
		/// </param>
		/// <param name="shortWeight">
		///     The weight of short Buying Pressure average for Ultimate Oscillator (optional, default to
		///     4.0)
		/// </param>
		/// <param name="mediumWeight">
		///     The weight of medium Buying Pressure average for Ultimate Oscillator (optional, default to
		///     2.0)
		/// </param>
		/// <param name="longWeight">The weight of long Buying Pressure average for Ultimate Oscillator (optional, default to 1.0)</param>
		/// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
		/// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>ApiResponseSecurityUltimateOscillator</returns>
		ApiResponseSecurityUltimateOscillator GetSecurityPriceTechnicalsUo(string identifier, int? shortPeriod = null,
			int? mediumPeriod = null, int? longPeriod = null, float? shortWeight = null, float? mediumWeight = null,
			float? longWeight = null, string startDate = null, string endDate = null, int? pageSize = null,
			string nextPage = null);

		/// <summary>
		///     Ultimate Oscillator
		/// </summary>
		/// <remarks>
		///     Returns the Ultimate Oscillator values of Stock Prices for the Security with the given &#x60;identifier&#x60;
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
		/// <param name="shortPeriod">
		///     The number of observations, per period, to calculate the short period for Ultimate Oscillator
		///     (optional, default to 7)
		/// </param>
		/// <param name="mediumPeriod">
		///     The number of observations, per period, to calculate the medium period for Ultimate
		///     Oscillator (optional, default to 14)
		/// </param>
		/// <param name="longPeriod">
		///     The number of observations, per period, to calculate the long period for Ultimate Oscillator
		///     (optional, default to 28)
		/// </param>
		/// <param name="shortWeight">
		///     The weight of short Buying Pressure average for Ultimate Oscillator (optional, default to
		///     4.0)
		/// </param>
		/// <param name="mediumWeight">
		///     The weight of medium Buying Pressure average for Ultimate Oscillator (optional, default to
		///     2.0)
		/// </param>
		/// <param name="longWeight">The weight of long Buying Pressure average for Ultimate Oscillator (optional, default to 1.0)</param>
		/// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
		/// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>ApiResponse of ApiResponseSecurityUltimateOscillator</returns>
		ApiResponse<ApiResponseSecurityUltimateOscillator> GetSecurityPriceTechnicalsUoWithHttpInfo(string identifier,
			int? shortPeriod = null, int? mediumPeriod = null, int? longPeriod = null, float? shortWeight = null,
			float? mediumWeight = null, float? longWeight = null, string startDate = null, string endDate = null,
			int? pageSize = null, string nextPage = null);

		/// <summary>
		///     Vortex Indicator
		/// </summary>
		/// <remarks>
		///     Returns the Vortex Indicator values of Stock Prices for the Security with the given &#x60;identifier&#x60;
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
		/// <param name="period">The number of observations, per period, to calculate Vortex Indicator (optional, default to 14)</param>
		/// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
		/// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>ApiResponseSecurityVortexIndicator</returns>
		ApiResponseSecurityVortexIndicator GetSecurityPriceTechnicalsVi(string identifier, int? period = null,
			string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null);

		/// <summary>
		///     Vortex Indicator
		/// </summary>
		/// <remarks>
		///     Returns the Vortex Indicator values of Stock Prices for the Security with the given &#x60;identifier&#x60;
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
		/// <param name="period">The number of observations, per period, to calculate Vortex Indicator (optional, default to 14)</param>
		/// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
		/// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>ApiResponse of ApiResponseSecurityVortexIndicator</returns>
		ApiResponse<ApiResponseSecurityVortexIndicator> GetSecurityPriceTechnicalsViWithHttpInfo(string identifier,
			int? period = null, string startDate = null, string endDate = null, int? pageSize = null,
			string nextPage = null);

		/// <summary>
		///     Volume-price Trend
		/// </summary>
		/// <remarks>
		///     Returns the Volume-price Trend values of Stock Prices for the Security with the given &#x60;identifier&#x60;
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
		/// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
		/// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>ApiResponseSecurityVolumePriceTrend</returns>
		ApiResponseSecurityVolumePriceTrend GetSecurityPriceTechnicalsVpt(string identifier, string startDate = null,
			string endDate = null, int? pageSize = null, string nextPage = null);

		/// <summary>
		///     Volume-price Trend
		/// </summary>
		/// <remarks>
		///     Returns the Volume-price Trend values of Stock Prices for the Security with the given &#x60;identifier&#x60;
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
		/// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
		/// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>ApiResponse of ApiResponseSecurityVolumePriceTrend</returns>
		ApiResponse<ApiResponseSecurityVolumePriceTrend> GetSecurityPriceTechnicalsVptWithHttpInfo(string identifier,
			string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null);

		/// <summary>
		///     Volume Weighted Average Price
		/// </summary>
		/// <remarks>
		///     Returns the Volume Weighted Average Price values of Stock Prices for the Security with the given &#x60;identifier
		///     &#x60;
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
		/// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
		/// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>ApiResponseSecurityVolumeWeightedAveragePrice</returns>
		ApiResponseSecurityVolumeWeightedAveragePrice GetSecurityPriceTechnicalsVwap(string identifier,
			string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null);

		/// <summary>
		///     Volume Weighted Average Price
		/// </summary>
		/// <remarks>
		///     Returns the Volume Weighted Average Price values of Stock Prices for the Security with the given &#x60;identifier
		///     &#x60;
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
		/// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
		/// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>ApiResponse of ApiResponseSecurityVolumeWeightedAveragePrice</returns>
		ApiResponse<ApiResponseSecurityVolumeWeightedAveragePrice> GetSecurityPriceTechnicalsVwapWithHttpInfo(
			string identifier, string startDate = null, string endDate = null, int? pageSize = null,
			string nextPage = null);

		/// <summary>
		///     Williams %R
		/// </summary>
		/// <remarks>
		///     Returns the Williams %R values of Stock Prices for the Security with the given &#x60;identifier&#x60;
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
		/// <param name="period">
		///     The number of observations, per period, to look-back when calculating Williams %R (optional,
		///     default to 14)
		/// </param>
		/// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
		/// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>ApiResponseSecurityWilliamsR</returns>
		ApiResponseSecurityWilliamsR GetSecurityPriceTechnicalsWr(string identifier, int? period = null,
			string startDate = null, string endDate = null, decimal? pageSize = null, string nextPage = null);

		/// <summary>
		///     Williams %R
		/// </summary>
		/// <remarks>
		///     Returns the Williams %R values of Stock Prices for the Security with the given &#x60;identifier&#x60;
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
		/// <param name="period">
		///     The number of observations, per period, to look-back when calculating Williams %R (optional,
		///     default to 14)
		/// </param>
		/// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
		/// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>ApiResponse of ApiResponseSecurityWilliamsR</returns>
		ApiResponse<ApiResponseSecurityWilliamsR> GetSecurityPriceTechnicalsWrWithHttpInfo(string identifier,
			int? period = null, string startDate = null, string endDate = null, decimal? pageSize = null,
			string nextPage = null);

		#endregion Synchronous Operations

		#region Asynchronous Operations

		/// <summary>
		///     Accumulation/Distribution Index
		/// </summary>
		/// <remarks>
		///     Returns the Accumulation/Distribution Index values of Stock Prices for the Security with the given &#x60;identifier
		///     &#x60;
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
		/// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
		/// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>Task of ApiResponseSecurityAccumulationDistributionIndex</returns>
		Task<ApiResponseSecurityAccumulationDistributionIndex> GetSecurityPriceTechnicalsAdiAsync(string identifier,
			string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null);

		/// <summary>
		///     Accumulation/Distribution Index
		/// </summary>
		/// <remarks>
		///     Returns the Accumulation/Distribution Index values of Stock Prices for the Security with the given &#x60;identifier
		///     &#x60;
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
		/// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
		/// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>Task of ApiResponse (ApiResponseSecurityAccumulationDistributionIndex)</returns>
		Task<ApiResponse<ApiResponseSecurityAccumulationDistributionIndex>>
			GetSecurityPriceTechnicalsAdiAsyncWithHttpInfo(string identifier, string startDate = null,
				string endDate = null, int? pageSize = null, string nextPage = null);

		/// <summary>
		///     Average Daily Trading Volume
		/// </summary>
		/// <remarks>
		///     Returns the Average Daily Trading Volume values of Stock Prices for the Security with the given &#x60;identifier
		///     &#x60;
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
		/// <param name="period">
		///     The number of observations, per period, to calculate Average Daily Trading Volume (optional,
		///     default to 22)
		/// </param>
		/// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
		/// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>Task of ApiResponseSecurityAverageDailyTradingVolume</returns>
		Task<ApiResponseSecurityAverageDailyTradingVolume> GetSecurityPriceTechnicalsAdtvAsync(string identifier,
			int? period = null, string startDate = null, string endDate = null, int? pageSize = null,
			string nextPage = null);

		/// <summary>
		///     Average Daily Trading Volume
		/// </summary>
		/// <remarks>
		///     Returns the Average Daily Trading Volume values of Stock Prices for the Security with the given &#x60;identifier
		///     &#x60;
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
		/// <param name="period">
		///     The number of observations, per period, to calculate Average Daily Trading Volume (optional,
		///     default to 22)
		/// </param>
		/// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
		/// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>Task of ApiResponse (ApiResponseSecurityAverageDailyTradingVolume)</returns>
		Task<ApiResponse<ApiResponseSecurityAverageDailyTradingVolume>> GetSecurityPriceTechnicalsAdtvAsyncWithHttpInfo(
			string identifier, int? period = null, string startDate = null, string endDate = null, int? pageSize = null,
			string nextPage = null);

		/// <summary>
		///     Average Directional Index
		/// </summary>
		/// <remarks>
		///     Returns the Average Directional Index values of Stock Prices for the Security with the given &#x60;identifier&#x60;
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
		/// <param name="period">
		///     The number of observations, per period, to calculate Average Directional Index (optional, default
		///     to 14)
		/// </param>
		/// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
		/// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>Task of ApiResponseSecurityAverageDirectionalIndex</returns>
		Task<ApiResponseSecurityAverageDirectionalIndex> GetSecurityPriceTechnicalsAdxAsync(string identifier,
			int? period = null, string startDate = null, string endDate = null, int? pageSize = null,
			string nextPage = null);

		/// <summary>
		///     Average Directional Index
		/// </summary>
		/// <remarks>
		///     Returns the Average Directional Index values of Stock Prices for the Security with the given &#x60;identifier&#x60;
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
		/// <param name="period">
		///     The number of observations, per period, to calculate Average Directional Index (optional, default
		///     to 14)
		/// </param>
		/// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
		/// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>Task of ApiResponse (ApiResponseSecurityAverageDirectionalIndex)</returns>
		Task<ApiResponse<ApiResponseSecurityAverageDirectionalIndex>> GetSecurityPriceTechnicalsAdxAsyncWithHttpInfo(
			string identifier, int? period = null, string startDate = null, string endDate = null, int? pageSize = null,
			string nextPage = null);

		/// <summary>
		///     Awesome Oscillator
		/// </summary>
		/// <remarks>
		///     Returns the Awesome Oscillator values of Stock Prices for the Security with the given &#x60;identifier&#x60;
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
		/// <param name="shortPeriod">
		///     The number of observations, per period, to calculate short period Simple Moving Average of
		///     the Awesome Oscillator (optional, default to 5)
		/// </param>
		/// <param name="longPeriod">
		///     The number of observations, per period, to calculate long period Simple Moving Average of the
		///     Awesome Oscillator (optional, default to 34)
		/// </param>
		/// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
		/// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>Task of ApiResponseSecurityAwesomeOscillator</returns>
		Task<ApiResponseSecurityAwesomeOscillator> GetSecurityPriceTechnicalsAoAsync(string identifier,
			int? shortPeriod = null, int? longPeriod = null, string startDate = null, string endDate = null,
			int? pageSize = null, string nextPage = null);

		/// <summary>
		///     Awesome Oscillator
		/// </summary>
		/// <remarks>
		///     Returns the Awesome Oscillator values of Stock Prices for the Security with the given &#x60;identifier&#x60;
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
		/// <param name="shortPeriod">
		///     The number of observations, per period, to calculate short period Simple Moving Average of
		///     the Awesome Oscillator (optional, default to 5)
		/// </param>
		/// <param name="longPeriod">
		///     The number of observations, per period, to calculate long period Simple Moving Average of the
		///     Awesome Oscillator (optional, default to 34)
		/// </param>
		/// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
		/// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>Task of ApiResponse (ApiResponseSecurityAwesomeOscillator)</returns>
		Task<ApiResponse<ApiResponseSecurityAwesomeOscillator>> GetSecurityPriceTechnicalsAoAsyncWithHttpInfo(
			string identifier, int? shortPeriod = null, int? longPeriod = null, string startDate = null,
			string endDate = null, int? pageSize = null, string nextPage = null);

		/// <summary>
		///     Average True Range
		/// </summary>
		/// <remarks>
		///     Returns the Average True Range values of Stock Prices for the Security with the given &#x60;identifier&#x60;
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
		/// <param name="period">The number of observations, per period, to calculate Average True Range (optional, default to 14)</param>
		/// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
		/// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>Task of ApiResponseSecurityAverageTrueRange</returns>
		Task<ApiResponseSecurityAverageTrueRange> GetSecurityPriceTechnicalsAtrAsync(string identifier,
			int? period = null, string startDate = null, string endDate = null, int? pageSize = null,
			string nextPage = null);

		/// <summary>
		///     Average True Range
		/// </summary>
		/// <remarks>
		///     Returns the Average True Range values of Stock Prices for the Security with the given &#x60;identifier&#x60;
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
		/// <param name="period">The number of observations, per period, to calculate Average True Range (optional, default to 14)</param>
		/// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
		/// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>Task of ApiResponse (ApiResponseSecurityAverageTrueRange)</returns>
		Task<ApiResponse<ApiResponseSecurityAverageTrueRange>> GetSecurityPriceTechnicalsAtrAsyncWithHttpInfo(
			string identifier, int? period = null, string startDate = null, string endDate = null, int? pageSize = null,
			string nextPage = null);

		/// <summary>
		///     Bollinger Bands
		/// </summary>
		/// <remarks>
		///     Returns the Bollinger Bands values of Stock Prices for the Security with the given &#x60;identifier&#x60;
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
		/// <param name="period">The number of observations, per period, to calculate Bollinger Bands (optional, default to 20)</param>
		/// <param name="standardDeviations">
		///     The number of standard deviations to calculate the upper and lower bands of the
		///     Bollinger Bands (optional, default to 2.0)
		/// </param>
		/// <param name="priceKey">The Stock Price field to use when calculating Bollinger Bands (optional, default to close)</param>
		/// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
		/// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>Task of ApiResponseSecurityBollingerBands</returns>
		Task<ApiResponseSecurityBollingerBands> GetSecurityPriceTechnicalsBbAsync(string identifier, int? period = null,
			float? standardDeviations = null, string priceKey = null, string startDate = null, string endDate = null,
			int? pageSize = null, string nextPage = null);

		/// <summary>
		///     Bollinger Bands
		/// </summary>
		/// <remarks>
		///     Returns the Bollinger Bands values of Stock Prices for the Security with the given &#x60;identifier&#x60;
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
		/// <param name="period">The number of observations, per period, to calculate Bollinger Bands (optional, default to 20)</param>
		/// <param name="standardDeviations">
		///     The number of standard deviations to calculate the upper and lower bands of the
		///     Bollinger Bands (optional, default to 2.0)
		/// </param>
		/// <param name="priceKey">The Stock Price field to use when calculating Bollinger Bands (optional, default to close)</param>
		/// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
		/// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>Task of ApiResponse (ApiResponseSecurityBollingerBands)</returns>
		Task<ApiResponse<ApiResponseSecurityBollingerBands>> GetSecurityPriceTechnicalsBbAsyncWithHttpInfo(
			string identifier, int? period = null, float? standardDeviations = null, string priceKey = null,
			string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null);

		/// <summary>
		///     Commodity Channel Index
		/// </summary>
		/// <remarks>
		///     Returns the Commodity Channel Index values of Stock Prices for the Security with the given &#x60;identifier&#x60;
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
		/// <param name="period">
		///     The number of observations, per period, to calculate Commodity Channel Index (optional, default to
		///     20)
		/// </param>
		/// <param name="constant">
		///     The number of observations, per period, to calculate Commodity Channel Index (optional, default
		///     to 0.015)
		/// </param>
		/// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
		/// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>Task of ApiResponseSecurityCommodityChannelIndex</returns>
		Task<ApiResponseSecurityCommodityChannelIndex> GetSecurityPriceTechnicalsCciAsync(string identifier,
			int? period = null, float? constant = null, string startDate = null, string endDate = null,
			int? pageSize = null, string nextPage = null);

		/// <summary>
		///     Commodity Channel Index
		/// </summary>
		/// <remarks>
		///     Returns the Commodity Channel Index values of Stock Prices for the Security with the given &#x60;identifier&#x60;
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
		/// <param name="period">
		///     The number of observations, per period, to calculate Commodity Channel Index (optional, default to
		///     20)
		/// </param>
		/// <param name="constant">
		///     The number of observations, per period, to calculate Commodity Channel Index (optional, default
		///     to 0.015)
		/// </param>
		/// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
		/// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>Task of ApiResponse (ApiResponseSecurityCommodityChannelIndex)</returns>
		Task<ApiResponse<ApiResponseSecurityCommodityChannelIndex>> GetSecurityPriceTechnicalsCciAsyncWithHttpInfo(
			string identifier, int? period = null, float? constant = null, string startDate = null,
			string endDate = null, int? pageSize = null, string nextPage = null);

		/// <summary>
		///     Chaikin Money Flow
		/// </summary>
		/// <remarks>
		///     Returns the Chaikin Money Flow values of Stock Prices for the Security with the given &#x60;identifier&#x60;
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
		/// <param name="period">The number of observations, per period, to calculate Chaikin Money Flow (optional, default to 20)</param>
		/// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
		/// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>Task of ApiResponseSecurityChaikinMoneyFlow</returns>
		Task<ApiResponseSecurityChaikinMoneyFlow> GetSecurityPriceTechnicalsCmfAsync(string identifier,
			int? period = null, string startDate = null, string endDate = null, int? pageSize = null,
			string nextPage = null);

		/// <summary>
		///     Chaikin Money Flow
		/// </summary>
		/// <remarks>
		///     Returns the Chaikin Money Flow values of Stock Prices for the Security with the given &#x60;identifier&#x60;
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
		/// <param name="period">The number of observations, per period, to calculate Chaikin Money Flow (optional, default to 20)</param>
		/// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
		/// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>Task of ApiResponse (ApiResponseSecurityChaikinMoneyFlow)</returns>
		Task<ApiResponse<ApiResponseSecurityChaikinMoneyFlow>> GetSecurityPriceTechnicalsCmfAsyncWithHttpInfo(
			string identifier, int? period = null, string startDate = null, string endDate = null, int? pageSize = null,
			string nextPage = null);

		/// <summary>
		///     Donchian Channel
		/// </summary>
		/// <remarks>
		///     Returns the Donchian Channel values of Stock Prices for the Security with the given &#x60;identifier&#x60;
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
		/// <param name="period">The number of observations, per period, to calculate Donchian Channel (optional, default to 20)</param>
		/// <param name="priceKey">The Stock Price field to use when calculating Donchian Channel (optional, default to close)</param>
		/// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
		/// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>Task of ApiResponseSecurityDonchianChannel</returns>
		Task<ApiResponseSecurityDonchianChannel> GetSecurityPriceTechnicalsDcAsync(string identifier,
			int? period = null, string priceKey = null, string startDate = null, string endDate = null,
			int? pageSize = null, string nextPage = null);

		/// <summary>
		///     Donchian Channel
		/// </summary>
		/// <remarks>
		///     Returns the Donchian Channel values of Stock Prices for the Security with the given &#x60;identifier&#x60;
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
		/// <param name="period">The number of observations, per period, to calculate Donchian Channel (optional, default to 20)</param>
		/// <param name="priceKey">The Stock Price field to use when calculating Donchian Channel (optional, default to close)</param>
		/// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
		/// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>Task of ApiResponse (ApiResponseSecurityDonchianChannel)</returns>
		Task<ApiResponse<ApiResponseSecurityDonchianChannel>> GetSecurityPriceTechnicalsDcAsyncWithHttpInfo(
			string identifier, int? period = null, string priceKey = null, string startDate = null,
			string endDate = null, int? pageSize = null, string nextPage = null);

		/// <summary>
		///     Detrended Price Oscillator
		/// </summary>
		/// <remarks>
		///     Returns the Detrended Price Oscillator values of Stock Prices for the Security with the given &#x60;identifier
		///     &#x60;
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
		/// <param name="period">
		///     The number of observations, per period, to calculate Detrended Price Oscillator (optional, default
		///     to 20)
		/// </param>
		/// <param name="priceKey">
		///     The Stock Price field to use when calculating Detrended Price Oscillator (optional, default to
		///     close)
		/// </param>
		/// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
		/// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>Task of ApiResponseSecurityDetrendedPriceOscillator</returns>
		Task<ApiResponseSecurityDetrendedPriceOscillator> GetSecurityPriceTechnicalsDpoAsync(string identifier,
			int? period = null, string priceKey = null, string startDate = null, string endDate = null,
			int? pageSize = null, string nextPage = null);

		/// <summary>
		///     Detrended Price Oscillator
		/// </summary>
		/// <remarks>
		///     Returns the Detrended Price Oscillator values of Stock Prices for the Security with the given &#x60;identifier
		///     &#x60;
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
		/// <param name="period">
		///     The number of observations, per period, to calculate Detrended Price Oscillator (optional, default
		///     to 20)
		/// </param>
		/// <param name="priceKey">
		///     The Stock Price field to use when calculating Detrended Price Oscillator (optional, default to
		///     close)
		/// </param>
		/// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
		/// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>Task of ApiResponse (ApiResponseSecurityDetrendedPriceOscillator)</returns>
		Task<ApiResponse<ApiResponseSecurityDetrendedPriceOscillator>> GetSecurityPriceTechnicalsDpoAsyncWithHttpInfo(
			string identifier, int? period = null, string priceKey = null, string startDate = null,
			string endDate = null, int? pageSize = null, string nextPage = null);

		/// <summary>
		///     Ease of Movement
		/// </summary>
		/// <remarks>
		///     Returns the Ease of Movement values of Stock Prices for the Security with the given &#x60;identifier&#x60;
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
		/// <param name="period">The number of observations, per period, to calculate Ease of Movement (optional, default to 20)</param>
		/// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
		/// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>Task of ApiResponseSecurityEaseOfMovement</returns>
		Task<ApiResponseSecurityEaseOfMovement> GetSecurityPriceTechnicalsEomAsync(string identifier,
			int? period = null, string startDate = null, string endDate = null, int? pageSize = null,
			string nextPage = null);

		/// <summary>
		///     Ease of Movement
		/// </summary>
		/// <remarks>
		///     Returns the Ease of Movement values of Stock Prices for the Security with the given &#x60;identifier&#x60;
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
		/// <param name="period">The number of observations, per period, to calculate Ease of Movement (optional, default to 20)</param>
		/// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
		/// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>Task of ApiResponse (ApiResponseSecurityEaseOfMovement)</returns>
		Task<ApiResponse<ApiResponseSecurityEaseOfMovement>> GetSecurityPriceTechnicalsEomAsyncWithHttpInfo(
			string identifier, int? period = null, string startDate = null, string endDate = null, int? pageSize = null,
			string nextPage = null);

		/// <summary>
		///     Force Index
		/// </summary>
		/// <remarks>
		///     Returns the Force Index values of Stock Prices for the Security with the given &#x60;identifier&#x60;
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
		/// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
		/// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>Task of ApiResponseSecurityForceIndex</returns>
		Task<ApiResponseSecurityForceIndex> GetSecurityPriceTechnicalsFiAsync(string identifier,
			string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null);

		/// <summary>
		///     Force Index
		/// </summary>
		/// <remarks>
		///     Returns the Force Index values of Stock Prices for the Security with the given &#x60;identifier&#x60;
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
		/// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
		/// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>Task of ApiResponse (ApiResponseSecurityForceIndex)</returns>
		Task<ApiResponse<ApiResponseSecurityForceIndex>> GetSecurityPriceTechnicalsFiAsyncWithHttpInfo(
			string identifier, string startDate = null, string endDate = null, int? pageSize = null,
			string nextPage = null);

		/// <summary>
		///     Ichimoku Kinko Hyo
		/// </summary>
		/// <remarks>
		///     Returns the Ichimoku Kinko Hyo values of Stock Prices for the Security with the given &#x60;identifier&#x60;
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
		/// <param name="lowPeriod">
		///     The number of observations, per period, to calculate Tenkan Sen (Conversion Line) of Ichimoku
		///     Kinko Hyo (optional, default to 9)
		/// </param>
		/// <param name="mediumPeriod">
		///     The number of observations, per period, to calculate Kijun Sen (Base Line), Senkou Span A
		///     (Leading Span A), and Chikou Span (Lagging Span) of Ichimoku Kinko Hyo (optional, default to 26)
		/// </param>
		/// <param name="highPeriod">
		///     The number of observations, per period, to calculate Senkou Span B (Leading Span B) of
		///     Ichimoku Kinko Hyo (optional, default to 52)
		/// </param>
		/// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
		/// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>Task of ApiResponseSecurityIchimokuKinkoHyo</returns>
		Task<ApiResponseSecurityIchimokuKinkoHyo> GetSecurityPriceTechnicalsIchimokuAsync(string identifier,
			int? lowPeriod = null, int? mediumPeriod = null, int? highPeriod = null, string startDate = null,
			string endDate = null, int? pageSize = null, string nextPage = null);

		/// <summary>
		///     Ichimoku Kinko Hyo
		/// </summary>
		/// <remarks>
		///     Returns the Ichimoku Kinko Hyo values of Stock Prices for the Security with the given &#x60;identifier&#x60;
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
		/// <param name="lowPeriod">
		///     The number of observations, per period, to calculate Tenkan Sen (Conversion Line) of Ichimoku
		///     Kinko Hyo (optional, default to 9)
		/// </param>
		/// <param name="mediumPeriod">
		///     The number of observations, per period, to calculate Kijun Sen (Base Line), Senkou Span A
		///     (Leading Span A), and Chikou Span (Lagging Span) of Ichimoku Kinko Hyo (optional, default to 26)
		/// </param>
		/// <param name="highPeriod">
		///     The number of observations, per period, to calculate Senkou Span B (Leading Span B) of
		///     Ichimoku Kinko Hyo (optional, default to 52)
		/// </param>
		/// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
		/// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>Task of ApiResponse (ApiResponseSecurityIchimokuKinkoHyo)</returns>
		Task<ApiResponse<ApiResponseSecurityIchimokuKinkoHyo>> GetSecurityPriceTechnicalsIchimokuAsyncWithHttpInfo(
			string identifier, int? lowPeriod = null, int? mediumPeriod = null, int? highPeriod = null,
			string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null);

		/// <summary>
		///     Keltner Channel
		/// </summary>
		/// <remarks>
		///     Returns the Keltner Channel values of Stock Prices for the Security with the given &#x60;identifier&#x60;
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
		/// <param name="period">The number of observations, per period, to calculate Kelter Channel (optional, default to 10)</param>
		/// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
		/// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>Task of ApiResponseSecurityKeltnerChannel</returns>
		Task<ApiResponseSecurityKeltnerChannel> GetSecurityPriceTechnicalsKcAsync(string identifier, int? period = null,
			string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null);

		/// <summary>
		///     Keltner Channel
		/// </summary>
		/// <remarks>
		///     Returns the Keltner Channel values of Stock Prices for the Security with the given &#x60;identifier&#x60;
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
		/// <param name="period">The number of observations, per period, to calculate Kelter Channel (optional, default to 10)</param>
		/// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
		/// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>Task of ApiResponse (ApiResponseSecurityKeltnerChannel)</returns>
		Task<ApiResponse<ApiResponseSecurityKeltnerChannel>> GetSecurityPriceTechnicalsKcAsyncWithHttpInfo(
			string identifier, int? period = null, string startDate = null, string endDate = null, int? pageSize = null,
			string nextPage = null);

		/// <summary>
		///     Know Sure Thing
		/// </summary>
		/// <remarks>
		///     Returns the Know Sure Thing values of Stock Prices for the Security with the given &#x60;identifier&#x60;
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
		/// <param name="roc1">
		///     The number of observations, per period, to calculate the rate-of-change for RCMA1 (optional, default
		///     to 10)
		/// </param>
		/// <param name="roc2">
		///     The number of observations, per period, to calculate the rate-of-change for RCMA2 (optional, default
		///     to 15)
		/// </param>
		/// <param name="roc3">
		///     The number of observations, per period, to calculate the rate-of-change for RCMA3 (optional, default
		///     to 20)
		/// </param>
		/// <param name="roc4">
		///     The number of observations, per period, to calculate the rate-of-change for RCMA4 (optional, default
		///     to 30)
		/// </param>
		/// <param name="sma1">
		///     The number of observations, per period, to calculate the Simple Moving Average of the rate-of-change
		///     for RCMA1 (optional, default to 10)
		/// </param>
		/// <param name="sma2">
		///     The number of observations, per period, to calculate the Simple Moving Average of the rate-of-change
		///     for RCMA2 (optional, default to 10)
		/// </param>
		/// <param name="sma3">
		///     The number of observations, per period, to calculate the Simple Moving Average of the rate-of-change
		///     for RCMA3 (optional, default to 10)
		/// </param>
		/// <param name="sma4">
		///     The number of observations, per period, to calculate the Simple Moving Average of the rate-of-change
		///     for RCMA4 (optional, default to 15)
		/// </param>
		/// <param name="priceKey">The Stock Price field to use when calculating Know Sure Thing (optional, default to close)</param>
		/// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
		/// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>Task of ApiResponseSecurityKnowSureThing</returns>
		Task<ApiResponseSecurityKnowSureThing> GetSecurityPriceTechnicalsKstAsync(string identifier, int? roc1 = null,
			int? roc2 = null, int? roc3 = null, int? roc4 = null, int? sma1 = null, int? sma2 = null, int? sma3 = null,
			int? sma4 = null, string priceKey = null, string startDate = null, string endDate = null,
			int? pageSize = null, string nextPage = null);

		/// <summary>
		///     Know Sure Thing
		/// </summary>
		/// <remarks>
		///     Returns the Know Sure Thing values of Stock Prices for the Security with the given &#x60;identifier&#x60;
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
		/// <param name="roc1">
		///     The number of observations, per period, to calculate the rate-of-change for RCMA1 (optional, default
		///     to 10)
		/// </param>
		/// <param name="roc2">
		///     The number of observations, per period, to calculate the rate-of-change for RCMA2 (optional, default
		///     to 15)
		/// </param>
		/// <param name="roc3">
		///     The number of observations, per period, to calculate the rate-of-change for RCMA3 (optional, default
		///     to 20)
		/// </param>
		/// <param name="roc4">
		///     The number of observations, per period, to calculate the rate-of-change for RCMA4 (optional, default
		///     to 30)
		/// </param>
		/// <param name="sma1">
		///     The number of observations, per period, to calculate the Simple Moving Average of the rate-of-change
		///     for RCMA1 (optional, default to 10)
		/// </param>
		/// <param name="sma2">
		///     The number of observations, per period, to calculate the Simple Moving Average of the rate-of-change
		///     for RCMA2 (optional, default to 10)
		/// </param>
		/// <param name="sma3">
		///     The number of observations, per period, to calculate the Simple Moving Average of the rate-of-change
		///     for RCMA3 (optional, default to 10)
		/// </param>
		/// <param name="sma4">
		///     The number of observations, per period, to calculate the Simple Moving Average of the rate-of-change
		///     for RCMA4 (optional, default to 15)
		/// </param>
		/// <param name="priceKey">The Stock Price field to use when calculating Know Sure Thing (optional, default to close)</param>
		/// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
		/// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>Task of ApiResponse (ApiResponseSecurityKnowSureThing)</returns>
		Task<ApiResponse<ApiResponseSecurityKnowSureThing>> GetSecurityPriceTechnicalsKstAsyncWithHttpInfo(
			string identifier, int? roc1 = null, int? roc2 = null, int? roc3 = null, int? roc4 = null, int? sma1 = null,
			int? sma2 = null, int? sma3 = null, int? sma4 = null, string priceKey = null, string startDate = null,
			string endDate = null, int? pageSize = null, string nextPage = null);

		/// <summary>
		///     Moving Average Convergence Divergence
		/// </summary>
		/// <remarks>
		///     Returns the Moving Average Convergence Divergence values of Stock Prices for the Security with the given &#x60;
		///     identifier&#x60;
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
		/// <param name="fastPeriod">
		///     The number of observations, per period, to calculate the fast moving Exponential Moving
		///     Average for Moving Average Convergence Divergence (optional, default to 12)
		/// </param>
		/// <param name="slowPeriod">
		///     The number of observations, per period, to calculate the slow moving Exponential Moving
		///     Average for Moving Average Convergence Divergence (optional, default to 26)
		/// </param>
		/// <param name="signalPeriod">
		///     The number of observations, per period, to calculate the signal line for Moving Average
		///     Convergence Divergence (optional, default to 9)
		/// </param>
		/// <param name="priceKey">
		///     The Stock Price field to use when calculating Moving Average Convergence Divergence (optional,
		///     default to close)
		/// </param>
		/// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
		/// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>Task of ApiResponseSecurityMovingAverageConvergenceDivergence</returns>
		Task<ApiResponseSecurityMovingAverageConvergenceDivergence> GetSecurityPriceTechnicalsMacdAsync(
			string identifier, int? fastPeriod = null, int? slowPeriod = null, int? signalPeriod = null,
			string priceKey = null, string startDate = null, string endDate = null, int? pageSize = null,
			string nextPage = null);

		/// <summary>
		///     Moving Average Convergence Divergence
		/// </summary>
		/// <remarks>
		///     Returns the Moving Average Convergence Divergence values of Stock Prices for the Security with the given &#x60;
		///     identifier&#x60;
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
		/// <param name="fastPeriod">
		///     The number of observations, per period, to calculate the fast moving Exponential Moving
		///     Average for Moving Average Convergence Divergence (optional, default to 12)
		/// </param>
		/// <param name="slowPeriod">
		///     The number of observations, per period, to calculate the slow moving Exponential Moving
		///     Average for Moving Average Convergence Divergence (optional, default to 26)
		/// </param>
		/// <param name="signalPeriod">
		///     The number of observations, per period, to calculate the signal line for Moving Average
		///     Convergence Divergence (optional, default to 9)
		/// </param>
		/// <param name="priceKey">
		///     The Stock Price field to use when calculating Moving Average Convergence Divergence (optional,
		///     default to close)
		/// </param>
		/// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
		/// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>Task of ApiResponse (ApiResponseSecurityMovingAverageConvergenceDivergence)</returns>
		Task<ApiResponse<ApiResponseSecurityMovingAverageConvergenceDivergence>>
			GetSecurityPriceTechnicalsMacdAsyncWithHttpInfo(string identifier, int? fastPeriod = null,
				int? slowPeriod = null, int? signalPeriod = null, string priceKey = null, string startDate = null,
				string endDate = null, int? pageSize = null, string nextPage = null);

		/// <summary>
		///     Money Flow Index
		/// </summary>
		/// <remarks>
		///     Returns the Money Flow Index values of Stock Prices for the Security with the given &#x60;identifier&#x60;
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
		/// <param name="period">The number of observations, per period, to calculate Money Flow Index (optional, default to 14)</param>
		/// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
		/// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>Task of ApiResponseSecurityMoneyFlowIndex</returns>
		Task<ApiResponseSecurityMoneyFlowIndex> GetSecurityPriceTechnicalsMfiAsync(string identifier,
			int? period = null, string startDate = null, string endDate = null, int? pageSize = null,
			string nextPage = null);

		/// <summary>
		///     Money Flow Index
		/// </summary>
		/// <remarks>
		///     Returns the Money Flow Index values of Stock Prices for the Security with the given &#x60;identifier&#x60;
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
		/// <param name="period">The number of observations, per period, to calculate Money Flow Index (optional, default to 14)</param>
		/// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
		/// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>Task of ApiResponse (ApiResponseSecurityMoneyFlowIndex)</returns>
		Task<ApiResponse<ApiResponseSecurityMoneyFlowIndex>> GetSecurityPriceTechnicalsMfiAsyncWithHttpInfo(
			string identifier, int? period = null, string startDate = null, string endDate = null, int? pageSize = null,
			string nextPage = null);

		/// <summary>
		///     Mass Index
		/// </summary>
		/// <remarks>
		///     Returns the Mass Index values of Stock Prices for the Security with the given &#x60;identifier&#x60;
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
		/// <param name="emaPeriod">
		///     The number of observations, per period, to calculate the single Exponential Moving Average and
		///     the Double Exponential Moving Average for Mass Index (optional, default to 9)
		/// </param>
		/// <param name="sumPeriod">
		///     The number of observations, per period, to calculate the sum of the Exponetinal Moving Average
		///     Ratios for Mass Index (optional, default to 25)
		/// </param>
		/// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
		/// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>Task of ApiResponseSecurityMassIndex</returns>
		Task<ApiResponseSecurityMassIndex> GetSecurityPriceTechnicalsMiAsync(string identifier, int? emaPeriod = null,
			int? sumPeriod = null, string startDate = null, string endDate = null, int? pageSize = null,
			string nextPage = null);

		/// <summary>
		///     Mass Index
		/// </summary>
		/// <remarks>
		///     Returns the Mass Index values of Stock Prices for the Security with the given &#x60;identifier&#x60;
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
		/// <param name="emaPeriod">
		///     The number of observations, per period, to calculate the single Exponential Moving Average and
		///     the Double Exponential Moving Average for Mass Index (optional, default to 9)
		/// </param>
		/// <param name="sumPeriod">
		///     The number of observations, per period, to calculate the sum of the Exponetinal Moving Average
		///     Ratios for Mass Index (optional, default to 25)
		/// </param>
		/// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
		/// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>Task of ApiResponse (ApiResponseSecurityMassIndex)</returns>
		Task<ApiResponse<ApiResponseSecurityMassIndex>> GetSecurityPriceTechnicalsMiAsyncWithHttpInfo(string identifier,
			int? emaPeriod = null, int? sumPeriod = null, string startDate = null, string endDate = null,
			int? pageSize = null, string nextPage = null);

		/// <summary>
		///     Negative Volume Index
		/// </summary>
		/// <remarks>
		///     Returns the Negative Volume Index values of Stock Prices for the Security with the given &#x60;identifier&#x60;
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
		/// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
		/// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>Task of ApiResponseSecurityNegativeVolumeIndex</returns>
		Task<ApiResponseSecurityNegativeVolumeIndex> GetSecurityPriceTechnicalsNviAsync(string identifier,
			string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null);

		/// <summary>
		///     Negative Volume Index
		/// </summary>
		/// <remarks>
		///     Returns the Negative Volume Index values of Stock Prices for the Security with the given &#x60;identifier&#x60;
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
		/// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
		/// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>Task of ApiResponse (ApiResponseSecurityNegativeVolumeIndex)</returns>
		Task<ApiResponse<ApiResponseSecurityNegativeVolumeIndex>> GetSecurityPriceTechnicalsNviAsyncWithHttpInfo(
			string identifier, string startDate = null, string endDate = null, int? pageSize = null,
			string nextPage = null);

		/// <summary>
		///     On-balance Volume
		/// </summary>
		/// <remarks>
		///     Returns the On-balance Volume values of Stock Prices for the Security with the given &#x60;identifier&#x60;
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
		/// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
		/// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>Task of ApiResponseSecurityOnBalanceVolume</returns>
		Task<ApiResponseSecurityOnBalanceVolume> GetSecurityPriceTechnicalsObvAsync(string identifier,
			string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null);

		/// <summary>
		///     On-balance Volume
		/// </summary>
		/// <remarks>
		///     Returns the On-balance Volume values of Stock Prices for the Security with the given &#x60;identifier&#x60;
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
		/// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
		/// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>Task of ApiResponse (ApiResponseSecurityOnBalanceVolume)</returns>
		Task<ApiResponse<ApiResponseSecurityOnBalanceVolume>> GetSecurityPriceTechnicalsObvAsyncWithHttpInfo(
			string identifier, string startDate = null, string endDate = null, int? pageSize = null,
			string nextPage = null);

		/// <summary>
		///     On-balance Volume Mean
		/// </summary>
		/// <remarks>
		///     Returns the On-balance Volume Mean values of Stock Prices for the Security with the given &#x60;identifier&#x60;
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
		/// <param name="period">
		///     The number of observations, per period, to calculate On-balance Volume Mean (optional, default to
		///     10)
		/// </param>
		/// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
		/// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>Task of ApiResponseSecurityOnBalanceVolumeMean</returns>
		Task<ApiResponseSecurityOnBalanceVolumeMean> GetSecurityPriceTechnicalsObvMeanAsync(string identifier,
			int? period = null, string startDate = null, string endDate = null, int? pageSize = null,
			string nextPage = null);

		/// <summary>
		///     On-balance Volume Mean
		/// </summary>
		/// <remarks>
		///     Returns the On-balance Volume Mean values of Stock Prices for the Security with the given &#x60;identifier&#x60;
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
		/// <param name="period">
		///     The number of observations, per period, to calculate On-balance Volume Mean (optional, default to
		///     10)
		/// </param>
		/// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
		/// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>Task of ApiResponse (ApiResponseSecurityOnBalanceVolumeMean)</returns>
		Task<ApiResponse<ApiResponseSecurityOnBalanceVolumeMean>> GetSecurityPriceTechnicalsObvMeanAsyncWithHttpInfo(
			string identifier, int? period = null, string startDate = null, string endDate = null, int? pageSize = null,
			string nextPage = null);

		/// <summary>
		///     Relative Strength Index
		/// </summary>
		/// <remarks>
		///     Returns the Relative Strength Index values of Stock Prices for the Security with the given &#x60;identifier&#x60;
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
		/// <param name="period">
		///     The number of observations, per period, to calculate Relative Strength Index (optional, default to
		///     14)
		/// </param>
		/// <param name="priceKey">
		///     The Stock Price field to use when calculating Relative Strength Index (optional, default to
		///     close)
		/// </param>
		/// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
		/// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>Task of ApiResponseSecurityRelativeStrengthIndex</returns>
		Task<ApiResponseSecurityRelativeStrengthIndex> GetSecurityPriceTechnicalsRsiAsync(string identifier,
			int? period = null, string priceKey = null, string startDate = null, string endDate = null,
			int? pageSize = null, string nextPage = null);

		/// <summary>
		///     Relative Strength Index
		/// </summary>
		/// <remarks>
		///     Returns the Relative Strength Index values of Stock Prices for the Security with the given &#x60;identifier&#x60;
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
		/// <param name="period">
		///     The number of observations, per period, to calculate Relative Strength Index (optional, default to
		///     14)
		/// </param>
		/// <param name="priceKey">
		///     The Stock Price field to use when calculating Relative Strength Index (optional, default to
		///     close)
		/// </param>
		/// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
		/// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>Task of ApiResponse (ApiResponseSecurityRelativeStrengthIndex)</returns>
		Task<ApiResponse<ApiResponseSecurityRelativeStrengthIndex>> GetSecurityPriceTechnicalsRsiAsyncWithHttpInfo(
			string identifier, int? period = null, string priceKey = null, string startDate = null,
			string endDate = null, int? pageSize = null, string nextPage = null);

		/// <summary>
		///     Simple Moving Average
		/// </summary>
		/// <remarks>
		///     Returns the Simple Moving Average values of Stock Prices for the Security with the given &#x60;identifier&#x60;
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
		/// <param name="period">
		///     The number of observations, per period, to calculate Simple Moving Average (optional, default to
		///     20)
		/// </param>
		/// <param name="priceKey">The Stock Price field to use when calculating Simple Moving Average (optional, default to close)</param>
		/// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
		/// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>Task of ApiResponseSecuritySimpleMovingAverage</returns>
		Task<ApiResponseSecuritySimpleMovingAverage> GetSecurityPriceTechnicalsSmaAsync(string identifier,
			int? period = null, string priceKey = null, string startDate = null, string endDate = null,
			int? pageSize = null, string nextPage = null);

		/// <summary>
		///     Simple Moving Average
		/// </summary>
		/// <remarks>
		///     Returns the Simple Moving Average values of Stock Prices for the Security with the given &#x60;identifier&#x60;
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
		/// <param name="period">
		///     The number of observations, per period, to calculate Simple Moving Average (optional, default to
		///     20)
		/// </param>
		/// <param name="priceKey">The Stock Price field to use when calculating Simple Moving Average (optional, default to close)</param>
		/// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
		/// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>Task of ApiResponse (ApiResponseSecuritySimpleMovingAverage)</returns>
		Task<ApiResponse<ApiResponseSecuritySimpleMovingAverage>> GetSecurityPriceTechnicalsSmaAsyncWithHttpInfo(
			string identifier, int? period = null, string priceKey = null, string startDate = null,
			string endDate = null, int? pageSize = null, string nextPage = null);

		/// <summary>
		///     Stochastic Oscillator
		/// </summary>
		/// <remarks>
		///     Returns the Stochastic Oscillator values of Stock Prices for the Security with the given &#x60;identifier&#x60;
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
		/// <param name="period">
		///     The number of observations, per period, to calculate %K of Stochastic Oscillator (optional,
		///     default to 14)
		/// </param>
		/// <param name="signalPeriod">
		///     The number of observations, per period, to calculate the %D (the Simple Moving Average of
		///     %K) as a signal line for Stochastic Oscillator (optional, default to 3)
		/// </param>
		/// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
		/// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>Task of ApiResponseSecurityStochasticOscillator</returns>
		Task<ApiResponseSecurityStochasticOscillator> GetSecurityPriceTechnicalsSrAsync(string identifier,
			int? period = null, int? signalPeriod = null, string startDate = null, string endDate = null,
			int? pageSize = null, string nextPage = null);

		/// <summary>
		///     Stochastic Oscillator
		/// </summary>
		/// <remarks>
		///     Returns the Stochastic Oscillator values of Stock Prices for the Security with the given &#x60;identifier&#x60;
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
		/// <param name="period">
		///     The number of observations, per period, to calculate %K of Stochastic Oscillator (optional,
		///     default to 14)
		/// </param>
		/// <param name="signalPeriod">
		///     The number of observations, per period, to calculate the %D (the Simple Moving Average of
		///     %K) as a signal line for Stochastic Oscillator (optional, default to 3)
		/// </param>
		/// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
		/// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>Task of ApiResponse (ApiResponseSecurityStochasticOscillator)</returns>
		Task<ApiResponse<ApiResponseSecurityStochasticOscillator>> GetSecurityPriceTechnicalsSrAsyncWithHttpInfo(
			string identifier, int? period = null, int? signalPeriod = null, string startDate = null,
			string endDate = null, int? pageSize = null, string nextPage = null);

		/// <summary>
		///     Triple Exponential Average
		/// </summary>
		/// <remarks>
		///     Returns the Simple Moving Average values of Stock Prices for the Security with the given &#x60;identifier&#x60;
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
		/// <param name="period">
		///     The number of observations, per period, to calculate Exponential Moving Average for Triple
		///     Exponential Average (optional, default to 15)
		/// </param>
		/// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
		/// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>Task of ApiResponseSecurityTripleExponentialAverage</returns>
		Task<ApiResponseSecurityTripleExponentialAverage> GetSecurityPriceTechnicalsTrixAsync(string identifier,
			int? period = null, string startDate = null, string endDate = null, int? pageSize = null,
			string nextPage = null);

		/// <summary>
		///     Triple Exponential Average
		/// </summary>
		/// <remarks>
		///     Returns the Simple Moving Average values of Stock Prices for the Security with the given &#x60;identifier&#x60;
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
		/// <param name="period">
		///     The number of observations, per period, to calculate Exponential Moving Average for Triple
		///     Exponential Average (optional, default to 15)
		/// </param>
		/// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
		/// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>Task of ApiResponse (ApiResponseSecurityTripleExponentialAverage)</returns>
		Task<ApiResponse<ApiResponseSecurityTripleExponentialAverage>> GetSecurityPriceTechnicalsTrixAsyncWithHttpInfo(
			string identifier, int? period = null, string startDate = null, string endDate = null, int? pageSize = null,
			string nextPage = null);

		/// <summary>
		///     True Strength Index
		/// </summary>
		/// <remarks>
		///     Returns the True Strength Index values of Stock Prices for the Security with the given &#x60;identifier&#x60;
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
		/// <param name="lowPeriod">
		///     The number of observations, per period, to calculate low period Exponential Moving Average for
		///     smoothing in True Strength Index (optional, default to 13)
		/// </param>
		/// <param name="highPeriod">
		///     The number of observations, per period, to calculate high period Exponential Moving Average
		///     for smoothing in True Strength Index (optional, default to 25)
		/// </param>
		/// <param name="priceKey">The Stock Price field to use when calculating True Strength Index (optional, default to close)</param>
		/// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
		/// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>Task of ApiResponseSecurityTrueStrengthIndex</returns>
		Task<ApiResponseSecurityTrueStrengthIndex> GetSecurityPriceTechnicalsTsiAsync(string identifier,
			int? lowPeriod = null, int? highPeriod = null, string priceKey = null, string startDate = null,
			string endDate = null, int? pageSize = null, string nextPage = null);

		/// <summary>
		///     True Strength Index
		/// </summary>
		/// <remarks>
		///     Returns the True Strength Index values of Stock Prices for the Security with the given &#x60;identifier&#x60;
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
		/// <param name="lowPeriod">
		///     The number of observations, per period, to calculate low period Exponential Moving Average for
		///     smoothing in True Strength Index (optional, default to 13)
		/// </param>
		/// <param name="highPeriod">
		///     The number of observations, per period, to calculate high period Exponential Moving Average
		///     for smoothing in True Strength Index (optional, default to 25)
		/// </param>
		/// <param name="priceKey">The Stock Price field to use when calculating True Strength Index (optional, default to close)</param>
		/// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
		/// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>Task of ApiResponse (ApiResponseSecurityTrueStrengthIndex)</returns>
		Task<ApiResponse<ApiResponseSecurityTrueStrengthIndex>> GetSecurityPriceTechnicalsTsiAsyncWithHttpInfo(
			string identifier, int? lowPeriod = null, int? highPeriod = null, string priceKey = null,
			string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null);

		/// <summary>
		///     Ultimate Oscillator
		/// </summary>
		/// <remarks>
		///     Returns the Ultimate Oscillator values of Stock Prices for the Security with the given &#x60;identifier&#x60;
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
		/// <param name="shortPeriod">
		///     The number of observations, per period, to calculate the short period for Ultimate Oscillator
		///     (optional, default to 7)
		/// </param>
		/// <param name="mediumPeriod">
		///     The number of observations, per period, to calculate the medium period for Ultimate
		///     Oscillator (optional, default to 14)
		/// </param>
		/// <param name="longPeriod">
		///     The number of observations, per period, to calculate the long period for Ultimate Oscillator
		///     (optional, default to 28)
		/// </param>
		/// <param name="shortWeight">
		///     The weight of short Buying Pressure average for Ultimate Oscillator (optional, default to
		///     4.0)
		/// </param>
		/// <param name="mediumWeight">
		///     The weight of medium Buying Pressure average for Ultimate Oscillator (optional, default to
		///     2.0)
		/// </param>
		/// <param name="longWeight">The weight of long Buying Pressure average for Ultimate Oscillator (optional, default to 1.0)</param>
		/// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
		/// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>Task of ApiResponseSecurityUltimateOscillator</returns>
		Task<ApiResponseSecurityUltimateOscillator> GetSecurityPriceTechnicalsUoAsync(string identifier,
			int? shortPeriod = null, int? mediumPeriod = null, int? longPeriod = null, float? shortWeight = null,
			float? mediumWeight = null, float? longWeight = null, string startDate = null, string endDate = null,
			int? pageSize = null, string nextPage = null);

		/// <summary>
		///     Ultimate Oscillator
		/// </summary>
		/// <remarks>
		///     Returns the Ultimate Oscillator values of Stock Prices for the Security with the given &#x60;identifier&#x60;
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
		/// <param name="shortPeriod">
		///     The number of observations, per period, to calculate the short period for Ultimate Oscillator
		///     (optional, default to 7)
		/// </param>
		/// <param name="mediumPeriod">
		///     The number of observations, per period, to calculate the medium period for Ultimate
		///     Oscillator (optional, default to 14)
		/// </param>
		/// <param name="longPeriod">
		///     The number of observations, per period, to calculate the long period for Ultimate Oscillator
		///     (optional, default to 28)
		/// </param>
		/// <param name="shortWeight">
		///     The weight of short Buying Pressure average for Ultimate Oscillator (optional, default to
		///     4.0)
		/// </param>
		/// <param name="mediumWeight">
		///     The weight of medium Buying Pressure average for Ultimate Oscillator (optional, default to
		///     2.0)
		/// </param>
		/// <param name="longWeight">The weight of long Buying Pressure average for Ultimate Oscillator (optional, default to 1.0)</param>
		/// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
		/// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>Task of ApiResponse (ApiResponseSecurityUltimateOscillator)</returns>
		Task<ApiResponse<ApiResponseSecurityUltimateOscillator>> GetSecurityPriceTechnicalsUoAsyncWithHttpInfo(
			string identifier, int? shortPeriod = null, int? mediumPeriod = null, int? longPeriod = null,
			float? shortWeight = null, float? mediumWeight = null, float? longWeight = null, string startDate = null,
			string endDate = null, int? pageSize = null, string nextPage = null);

		/// <summary>
		///     Vortex Indicator
		/// </summary>
		/// <remarks>
		///     Returns the Vortex Indicator values of Stock Prices for the Security with the given &#x60;identifier&#x60;
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
		/// <param name="period">The number of observations, per period, to calculate Vortex Indicator (optional, default to 14)</param>
		/// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
		/// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>Task of ApiResponseSecurityVortexIndicator</returns>
		Task<ApiResponseSecurityVortexIndicator> GetSecurityPriceTechnicalsViAsync(string identifier,
			int? period = null, string startDate = null, string endDate = null, int? pageSize = null,
			string nextPage = null);

		/// <summary>
		///     Vortex Indicator
		/// </summary>
		/// <remarks>
		///     Returns the Vortex Indicator values of Stock Prices for the Security with the given &#x60;identifier&#x60;
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
		/// <param name="period">The number of observations, per period, to calculate Vortex Indicator (optional, default to 14)</param>
		/// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
		/// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>Task of ApiResponse (ApiResponseSecurityVortexIndicator)</returns>
		Task<ApiResponse<ApiResponseSecurityVortexIndicator>> GetSecurityPriceTechnicalsViAsyncWithHttpInfo(
			string identifier, int? period = null, string startDate = null, string endDate = null, int? pageSize = null,
			string nextPage = null);

		/// <summary>
		///     Volume-price Trend
		/// </summary>
		/// <remarks>
		///     Returns the Volume-price Trend values of Stock Prices for the Security with the given &#x60;identifier&#x60;
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
		/// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
		/// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>Task of ApiResponseSecurityVolumePriceTrend</returns>
		Task<ApiResponseSecurityVolumePriceTrend> GetSecurityPriceTechnicalsVptAsync(string identifier,
			string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null);

		/// <summary>
		///     Volume-price Trend
		/// </summary>
		/// <remarks>
		///     Returns the Volume-price Trend values of Stock Prices for the Security with the given &#x60;identifier&#x60;
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
		/// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
		/// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>Task of ApiResponse (ApiResponseSecurityVolumePriceTrend)</returns>
		Task<ApiResponse<ApiResponseSecurityVolumePriceTrend>> GetSecurityPriceTechnicalsVptAsyncWithHttpInfo(
			string identifier, string startDate = null, string endDate = null, int? pageSize = null,
			string nextPage = null);

		/// <summary>
		///     Volume Weighted Average Price
		/// </summary>
		/// <remarks>
		///     Returns the Volume Weighted Average Price values of Stock Prices for the Security with the given &#x60;identifier
		///     &#x60;
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
		/// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
		/// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>Task of ApiResponseSecurityVolumeWeightedAveragePrice</returns>
		Task<ApiResponseSecurityVolumeWeightedAveragePrice> GetSecurityPriceTechnicalsVwapAsync(string identifier,
			string startDate = null, string endDate = null, int? pageSize = null, string nextPage = null);

		/// <summary>
		///     Volume Weighted Average Price
		/// </summary>
		/// <remarks>
		///     Returns the Volume Weighted Average Price values of Stock Prices for the Security with the given &#x60;identifier
		///     &#x60;
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
		/// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
		/// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>Task of ApiResponse (ApiResponseSecurityVolumeWeightedAveragePrice)</returns>
		Task<ApiResponse<ApiResponseSecurityVolumeWeightedAveragePrice>>
			GetSecurityPriceTechnicalsVwapAsyncWithHttpInfo(string identifier, string startDate = null,
				string endDate = null, int? pageSize = null, string nextPage = null);

		/// <summary>
		///     Williams %R
		/// </summary>
		/// <remarks>
		///     Returns the Williams %R values of Stock Prices for the Security with the given &#x60;identifier&#x60;
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
		/// <param name="period">
		///     The number of observations, per period, to look-back when calculating Williams %R (optional,
		///     default to 14)
		/// </param>
		/// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
		/// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>Task of ApiResponseSecurityWilliamsR</returns>
		Task<ApiResponseSecurityWilliamsR> GetSecurityPriceTechnicalsWrAsync(string identifier, int? period = null,
			string startDate = null, string endDate = null, decimal? pageSize = null, string nextPage = null);

		/// <summary>
		///     Williams %R
		/// </summary>
		/// <remarks>
		///     Returns the Williams %R values of Stock Prices for the Security with the given &#x60;identifier&#x60;
		/// </remarks>
		/// <exception cref="Intrinio.SDK.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="identifier">A Security identifier (Ticker, FIGI, ISIN, CUSIP, Intrinio ID)</param>
		/// <param name="period">
		///     The number of observations, per period, to look-back when calculating Williams %R (optional,
		///     default to 14)
		/// </param>
		/// <param name="startDate">Return technical indicator values on or after the date (optional)</param>
		/// <param name="endDate">Return technical indicator values on or before the date (optional)</param>
		/// <param name="pageSize">The number of results to return (optional, default to 100)</param>
		/// <param name="nextPage">Gets the next page of data from a previous API call (optional)</param>
		/// <returns>Task of ApiResponse (ApiResponseSecurityWilliamsR)</returns>
		Task<ApiResponse<ApiResponseSecurityWilliamsR>> GetSecurityPriceTechnicalsWrAsyncWithHttpInfo(string identifier,
			int? period = null, string startDate = null, string endDate = null, decimal? pageSize = null,
			string nextPage = null);

		#endregion Asynchronous Operations
	}
}