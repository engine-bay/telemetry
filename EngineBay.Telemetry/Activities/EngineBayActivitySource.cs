namespace EngineBay.Telemetry
{
    using System.Diagnostics;

    public static class EngineBayActivitySource
    {
        public const string Name = "EngineBay.Tracing";

        public static ActivitySource Source { get; } = new ActivitySource(Name);
    }
}
