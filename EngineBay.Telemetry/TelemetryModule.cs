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
#pragma warning disable CS0618 //OpenTelemetryServicesExtensions.AddOpenTelemetryMetrics is marked as obsolete. Need to refactor this configuration to align to the new interface.

            services.AddOpenTelemetryMetrics((builder) =>
            {
                builder
                .AddProtoActorInstrumentation()
                .AddAspNetCoreInstrumentation()
                .AddHttpClientInstrumentation()
                .AddPrometheusExporter();
            });

#pragma warning restore CS0618

            return services;
        }

        public override WebApplication AddMiddleware(WebApplication app)
        {
            app.UseOpenTelemetryPrometheusScrapingEndpoint();

            return app;
        }
    }
}