/*
 * College Football Data API
 *
 * This is an API for query various college football datasets and analytics. API keys can be acquired from the CollegeFootballData.com website.
 *
 * The version of the OpenAPI document: 5.6.10
 * Contact: admin@collegefootballdata.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

#nullable enable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Net.Http;
using Microsoft.Extensions.DependencyInjection;
using CollegeFootballData.Api;
using CollegeFootballData.Model;

namespace CollegeFootballData.Client
{
    /// <summary>
    /// Provides hosting configuration for CollegeFootballData
    /// </summary>
    public class HostConfiguration
    {
        private readonly IServiceCollection _services;
        private readonly JsonSerializerOptions _jsonOptions = new JsonSerializerOptions();

        internal bool HttpClientsAdded { get; private set; }

        /// <summary>
        /// Instantiates the class 
        /// </summary>
        /// <param name="services"></param>
        public HostConfiguration(IServiceCollection services)
        {
            _services = services;
            _jsonOptions.Converters.Add(new JsonStringEnumConverter());
            _jsonOptions.Converters.Add(new DateTimeJsonConverter());
            _jsonOptions.Converters.Add(new DateTimeNullableJsonConverter());
            _jsonOptions.Converters.Add(new DateOnlyJsonConverter());
            _jsonOptions.Converters.Add(new DateOnlyNullableJsonConverter());
            _jsonOptions.Converters.Add(new AdjustedTeamMetricsJsonConverter());
            _jsonOptions.Converters.Add(new AdjustedTeamMetricsEpaJsonConverter());
            _jsonOptions.Converters.Add(new AdjustedTeamMetricsRushingJsonConverter());
            _jsonOptions.Converters.Add(new AdjustedTeamMetricsSuccessRateJsonConverter());
            _jsonOptions.Converters.Add(new AdvancedBoxScoreJsonConverter());
            _jsonOptions.Converters.Add(new AdvancedBoxScoreGameInfoJsonConverter());
            _jsonOptions.Converters.Add(new AdvancedBoxScorePlayersJsonConverter());
            _jsonOptions.Converters.Add(new AdvancedBoxScoreTeamsJsonConverter());
            _jsonOptions.Converters.Add(new AdvancedGameStatJsonConverter());
            _jsonOptions.Converters.Add(new AdvancedGameStatOffenseJsonConverter());
            _jsonOptions.Converters.Add(new AdvancedGameStatOffensePassingDownsJsonConverter());
            _jsonOptions.Converters.Add(new AdvancedGameStatOffensePassingPlaysJsonConverter());
            _jsonOptions.Converters.Add(new AdvancedSeasonStatJsonConverter());
            _jsonOptions.Converters.Add(new AdvancedSeasonStatDefenseJsonConverter());
            _jsonOptions.Converters.Add(new AdvancedSeasonStatOffenseJsonConverter());
            _jsonOptions.Converters.Add(new AdvancedSeasonStatOffenseFieldPositionJsonConverter());
            _jsonOptions.Converters.Add(new AdvancedSeasonStatOffenseHavocJsonConverter());
            _jsonOptions.Converters.Add(new AdvancedSeasonStatOffensePassingDownsJsonConverter());
            _jsonOptions.Converters.Add(new AdvancedSeasonStatOffensePassingPlaysJsonConverter());
            _jsonOptions.Converters.Add(new AggregatedTeamRecruitingJsonConverter());
            _jsonOptions.Converters.Add(new BettingGameJsonConverter());
            _jsonOptions.Converters.Add(new CalendarWeekJsonConverter());
            _jsonOptions.Converters.Add(new CoachJsonConverter());
            _jsonOptions.Converters.Add(new CoachSeasonJsonConverter());
            _jsonOptions.Converters.Add(new ConferenceJsonConverter());
            _jsonOptions.Converters.Add(new ConferenceSPJsonConverter());
            _jsonOptions.Converters.Add(new ConferenceSPDefenseJsonConverter());
            _jsonOptions.Converters.Add(new ConferenceSPOffenseJsonConverter());
            _jsonOptions.Converters.Add(new DivisionClassificationJsonConverter());
            _jsonOptions.Converters.Add(new DivisionClassificationNullableJsonConverter());
            _jsonOptions.Converters.Add(new DraftPickJsonConverter());
            _jsonOptions.Converters.Add(new DraftPickHometownInfoJsonConverter());
            _jsonOptions.Converters.Add(new DraftPositionJsonConverter());
            _jsonOptions.Converters.Add(new DraftTeamJsonConverter());
            _jsonOptions.Converters.Add(new DriveJsonConverter());
            _jsonOptions.Converters.Add(new FieldGoalEPJsonConverter());
            _jsonOptions.Converters.Add(new GameJsonConverter());
            _jsonOptions.Converters.Add(new GameLineJsonConverter());
            _jsonOptions.Converters.Add(new GameMediaJsonConverter());
            _jsonOptions.Converters.Add(new GamePlayerStatCategoriesJsonConverter());
            _jsonOptions.Converters.Add(new GamePlayerStatPlayerJsonConverter());
            _jsonOptions.Converters.Add(new GamePlayerStatTypesJsonConverter());
            _jsonOptions.Converters.Add(new GamePlayerStatsJsonConverter());
            _jsonOptions.Converters.Add(new GamePlayerStatsTeamJsonConverter());
            _jsonOptions.Converters.Add(new GameStatusJsonConverter());
            _jsonOptions.Converters.Add(new GameStatusNullableJsonConverter());
            _jsonOptions.Converters.Add(new GameTeamStatsJsonConverter());
            _jsonOptions.Converters.Add(new GameTeamStatsTeamJsonConverter());
            _jsonOptions.Converters.Add(new GameTeamStatsTeamStatJsonConverter());
            _jsonOptions.Converters.Add(new GameWeatherJsonConverter());
            _jsonOptions.Converters.Add(new KickerPAARJsonConverter());
            _jsonOptions.Converters.Add(new LiveGameJsonConverter());
            _jsonOptions.Converters.Add(new LiveGameDriveJsonConverter());
            _jsonOptions.Converters.Add(new LiveGamePlayJsonConverter());
            _jsonOptions.Converters.Add(new LiveGameTeamJsonConverter());
            _jsonOptions.Converters.Add(new MatchupJsonConverter());
            _jsonOptions.Converters.Add(new MatchupGameJsonConverter());
            _jsonOptions.Converters.Add(new MediaTypeJsonConverter());
            _jsonOptions.Converters.Add(new MediaTypeNullableJsonConverter());
            _jsonOptions.Converters.Add(new PlayJsonConverter());
            _jsonOptions.Converters.Add(new PlayClockJsonConverter());
            _jsonOptions.Converters.Add(new PlayStatJsonConverter());
            _jsonOptions.Converters.Add(new PlayStatClockJsonConverter());
            _jsonOptions.Converters.Add(new PlayStatTypeJsonConverter());
            _jsonOptions.Converters.Add(new PlayTypeJsonConverter());
            _jsonOptions.Converters.Add(new PlayWinProbabilityJsonConverter());
            _jsonOptions.Converters.Add(new PlayerGamePredictedPointsAddedJsonConverter());
            _jsonOptions.Converters.Add(new PlayerGamePredictedPointsAddedAveragePPAJsonConverter());
            _jsonOptions.Converters.Add(new PlayerGameUsageJsonConverter());
            _jsonOptions.Converters.Add(new PlayerPPAJsonConverter());
            _jsonOptions.Converters.Add(new PlayerPPAChartItemJsonConverter());
            _jsonOptions.Converters.Add(new PlayerSearchResultJsonConverter());
            _jsonOptions.Converters.Add(new PlayerSeasonPredictedPointsAddedJsonConverter());
            _jsonOptions.Converters.Add(new PlayerSeasonPredictedPointsAddedAveragePPAJsonConverter());
            _jsonOptions.Converters.Add(new PlayerStatJsonConverter());
            _jsonOptions.Converters.Add(new PlayerStatsByQuarterJsonConverter());
            _jsonOptions.Converters.Add(new PlayerTransferJsonConverter());
            _jsonOptions.Converters.Add(new PlayerUsageJsonConverter());
            _jsonOptions.Converters.Add(new PlayerUsageUsageJsonConverter());
            _jsonOptions.Converters.Add(new PlayerWeightedEPAJsonConverter());
            _jsonOptions.Converters.Add(new PollJsonConverter());
            _jsonOptions.Converters.Add(new PollRankJsonConverter());
            _jsonOptions.Converters.Add(new PollWeekJsonConverter());
            _jsonOptions.Converters.Add(new PredictedPointsValueJsonConverter());
            _jsonOptions.Converters.Add(new PregameWinProbabilityJsonConverter());
            _jsonOptions.Converters.Add(new RecruitJsonConverter());
            _jsonOptions.Converters.Add(new RecruitClassificationJsonConverter());
            _jsonOptions.Converters.Add(new RecruitClassificationNullableJsonConverter());
            _jsonOptions.Converters.Add(new RecruitHometownInfoJsonConverter());
            _jsonOptions.Converters.Add(new ReturningProductionJsonConverter());
            _jsonOptions.Converters.Add(new RosterPlayerJsonConverter());
            _jsonOptions.Converters.Add(new ScoreboardGameJsonConverter());
            _jsonOptions.Converters.Add(new ScoreboardGameBettingJsonConverter());
            _jsonOptions.Converters.Add(new ScoreboardGameHomeTeamJsonConverter());
            _jsonOptions.Converters.Add(new ScoreboardGameVenueJsonConverter());
            _jsonOptions.Converters.Add(new ScoreboardGameWeatherJsonConverter());
            _jsonOptions.Converters.Add(new SeasonTypeJsonConverter());
            _jsonOptions.Converters.Add(new SeasonTypeNullableJsonConverter());
            _jsonOptions.Converters.Add(new StatsByQuarterJsonConverter());
            _jsonOptions.Converters.Add(new TeamJsonConverter());
            _jsonOptions.Converters.Add(new TeamEloJsonConverter());
            _jsonOptions.Converters.Add(new TeamExplosivenessJsonConverter());
            _jsonOptions.Converters.Add(new TeamFPIJsonConverter());
            _jsonOptions.Converters.Add(new TeamFPIEfficienciesJsonConverter());
            _jsonOptions.Converters.Add(new TeamFPIResumeRanksJsonConverter());
            _jsonOptions.Converters.Add(new TeamFieldPositionJsonConverter());
            _jsonOptions.Converters.Add(new TeamGamePredictedPointsAddedJsonConverter());
            _jsonOptions.Converters.Add(new TeamGamePredictedPointsAddedOffenseJsonConverter());
            _jsonOptions.Converters.Add(new TeamHavocJsonConverter());
            _jsonOptions.Converters.Add(new TeamPPAJsonConverter());
            _jsonOptions.Converters.Add(new TeamRecordJsonConverter());
            _jsonOptions.Converters.Add(new TeamRecordsJsonConverter());
            _jsonOptions.Converters.Add(new TeamRecruitingRankingJsonConverter());
            _jsonOptions.Converters.Add(new TeamRushingStatsJsonConverter());
            _jsonOptions.Converters.Add(new TeamSPJsonConverter());
            _jsonOptions.Converters.Add(new TeamSPDefenseJsonConverter());
            _jsonOptions.Converters.Add(new TeamSPOffenseJsonConverter());
            _jsonOptions.Converters.Add(new TeamSPSpecialTeamsJsonConverter());
            _jsonOptions.Converters.Add(new TeamSRSJsonConverter());
            _jsonOptions.Converters.Add(new TeamScoringOpportunitiesJsonConverter());
            _jsonOptions.Converters.Add(new TeamSeasonPredictedPointsAddedJsonConverter());
            _jsonOptions.Converters.Add(new TeamSeasonPredictedPointsAddedOffenseJsonConverter());
            _jsonOptions.Converters.Add(new TeamStatJsonConverter());
            _jsonOptions.Converters.Add(new TeamStatStatValueJsonConverter());
            _jsonOptions.Converters.Add(new TeamSuccessRatesJsonConverter());
            _jsonOptions.Converters.Add(new TeamTalentJsonConverter());
            _jsonOptions.Converters.Add(new TransferEligibilityJsonConverter());
            _jsonOptions.Converters.Add(new TransferEligibilityNullableJsonConverter());
            _jsonOptions.Converters.Add(new VenueJsonConverter());
            JsonSerializerOptionsProvider jsonSerializerOptionsProvider = new(_jsonOptions);
            _services.AddSingleton(jsonSerializerOptionsProvider);
            _services.AddSingleton<IApiFactory, ApiFactory>();
            _services.AddSingleton<AdjustedMetricsApiEvents>();
            _services.AddTransient<IAdjustedMetricsApi, AdjustedMetricsApi>();
            _services.AddSingleton<BettingApiEvents>();
            _services.AddTransient<IBettingApi, BettingApi>();
            _services.AddSingleton<CoachesApiEvents>();
            _services.AddTransient<ICoachesApi, CoachesApi>();
            _services.AddSingleton<ConferencesApiEvents>();
            _services.AddTransient<IConferencesApi, ConferencesApi>();
            _services.AddSingleton<DraftApiEvents>();
            _services.AddTransient<IDraftApi, DraftApi>();
            _services.AddSingleton<DrivesApiEvents>();
            _services.AddTransient<IDrivesApi, DrivesApi>();
            _services.AddSingleton<GamesApiEvents>();
            _services.AddTransient<IGamesApi, GamesApi>();
            _services.AddSingleton<MetricsApiEvents>();
            _services.AddTransient<IMetricsApi, MetricsApi>();
            _services.AddSingleton<PlayersApiEvents>();
            _services.AddTransient<IPlayersApi, PlayersApi>();
            _services.AddSingleton<PlaysApiEvents>();
            _services.AddTransient<IPlaysApi, PlaysApi>();
            _services.AddSingleton<RankingsApiEvents>();
            _services.AddTransient<IRankingsApi, RankingsApi>();
            _services.AddSingleton<RatingsApiEvents>();
            _services.AddTransient<IRatingsApi, RatingsApi>();
            _services.AddSingleton<RecruitingApiEvents>();
            _services.AddTransient<IRecruitingApi, RecruitingApi>();
            _services.AddSingleton<StatsApiEvents>();
            _services.AddTransient<IStatsApi, StatsApi>();
            _services.AddSingleton<TeamsApiEvents>();
            _services.AddTransient<ITeamsApi, TeamsApi>();
            _services.AddSingleton<VenuesApiEvents>();
            _services.AddTransient<IVenuesApi, VenuesApi>();
        }

        /// <summary>
        /// Configures the HttpClients.
        /// </summary>
        /// <param name="client"></param>
        /// <param name="builder"></param>
        /// <returns></returns>
        public HostConfiguration AddApiHttpClients
        (
            Action<HttpClient>? client = null, Action<IHttpClientBuilder>? builder = null)
        {
            if (client == null)
                client = c => c.BaseAddress = new Uri(ClientUtils.BASE_ADDRESS);

            List<IHttpClientBuilder> builders = new List<IHttpClientBuilder>();

            builders.Add(_services.AddHttpClient<IAdjustedMetricsApi, AdjustedMetricsApi>(client));
            builders.Add(_services.AddHttpClient<IBettingApi, BettingApi>(client));
            builders.Add(_services.AddHttpClient<ICoachesApi, CoachesApi>(client));
            builders.Add(_services.AddHttpClient<IConferencesApi, ConferencesApi>(client));
            builders.Add(_services.AddHttpClient<IDraftApi, DraftApi>(client));
            builders.Add(_services.AddHttpClient<IDrivesApi, DrivesApi>(client));
            builders.Add(_services.AddHttpClient<IGamesApi, GamesApi>(client));
            builders.Add(_services.AddHttpClient<IMetricsApi, MetricsApi>(client));
            builders.Add(_services.AddHttpClient<IPlayersApi, PlayersApi>(client));
            builders.Add(_services.AddHttpClient<IPlaysApi, PlaysApi>(client));
            builders.Add(_services.AddHttpClient<IRankingsApi, RankingsApi>(client));
            builders.Add(_services.AddHttpClient<IRatingsApi, RatingsApi>(client));
            builders.Add(_services.AddHttpClient<IRecruitingApi, RecruitingApi>(client));
            builders.Add(_services.AddHttpClient<IStatsApi, StatsApi>(client));
            builders.Add(_services.AddHttpClient<ITeamsApi, TeamsApi>(client));
            builders.Add(_services.AddHttpClient<IVenuesApi, VenuesApi>(client));
            
            if (builder != null)
                foreach (IHttpClientBuilder instance in builders)
                    builder(instance);

            HttpClientsAdded = true;

            return this;
        }

        /// <summary>
        /// Configures the JsonSerializerSettings
        /// </summary>
        /// <param name="options"></param>
        /// <returns></returns>
        public HostConfiguration ConfigureJsonOptions(Action<JsonSerializerOptions> options)
        {
            options(_jsonOptions);

            return this;
        }

        /// <summary>
        /// Adds tokens to your IServiceCollection
        /// </summary>
        /// <typeparam name="TTokenBase"></typeparam>
        /// <param name="token"></param>
        /// <returns></returns>
        public HostConfiguration AddTokens<TTokenBase>(TTokenBase token) where TTokenBase : TokenBase
        {
            return AddTokens(new TTokenBase[]{ token });
        }

        /// <summary>
        /// Adds tokens to your IServiceCollection
        /// </summary>
        /// <typeparam name="TTokenBase"></typeparam>
        /// <param name="tokens"></param>
        /// <returns></returns>
        public HostConfiguration AddTokens<TTokenBase>(IEnumerable<TTokenBase> tokens) where TTokenBase : TokenBase
        {
            TokenContainer<TTokenBase> container = new TokenContainer<TTokenBase>(tokens);
            _services.AddSingleton(services => container);

            return this;
        }

        /// <summary>
        /// Adds a token provider to your IServiceCollection
        /// </summary>
        /// <typeparam name="TTokenProvider"></typeparam>
        /// <typeparam name="TTokenBase"></typeparam>
        /// <returns></returns>
        public HostConfiguration UseProvider<TTokenProvider, TTokenBase>() 
            where TTokenProvider : TokenProvider<TTokenBase>
            where TTokenBase : TokenBase
        {
            _services.AddSingleton<TTokenProvider>();
            _services.AddSingleton<TokenProvider<TTokenBase>>(services => services.GetRequiredService<TTokenProvider>());

            return this;
        }
    }
}
