namespace EngineBay.Telemetry
{
    using EngineBay.Core;
    using OpenTelemetry.Metrics;
    using OpenTelemetry.Trace;
    using Proto.OpenTelemetry;

    public class TelemetryModule : BaseModule
    {
        public override IServiceCollection RegisterModule(IServiceCollection services, IConfiguration configuration)
        {
            services.AddOpenTelemetry()
                .WithMetrics((builder) =>
                {
                    builder
                    .AddProtoActorInstrumentation()
                    .AddAspNetCoreInstrumentation()
                    .AddHttpClientInstrumentation()
                    .AddPrometheusExporter();
                });

            return services;
        }

        public override WebApplication AddMiddleware(WebApplication app)
        {
            app.UseOpenTelemetryPrometheusScrapingEndpoint();

            return app;
        }
    }
}