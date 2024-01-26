namespace EngineBay.Telemetry
{
    using EngineBay.Core;
    using OpenTelemetry.Metrics;
    using OpenTelemetry.Trace;

    public class TelemetryModule : BaseModule
    {
        public override IServiceCollection RegisterModule(IServiceCollection services, IConfiguration configuration)
        {
            services.AddOpenTelemetry()
                .WithMetrics(metrics =>
                {
                    metrics
                    .AddAspNetCoreInstrumentation()
                    .AddHttpClientInstrumentation()
                    .AddPrometheusExporter()
                    .AddConsoleExporter();
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