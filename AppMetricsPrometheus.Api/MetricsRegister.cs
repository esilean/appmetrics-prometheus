﻿using App.Metrics;
using App.Metrics.Counter;

namespace AppMetricsPrometheus.Api
{
    public class MetricsRegister
    {
        public static CounterOptions CreatedPromesCounter => new CounterOptions
        {
            Name = "Created Promes",
            Context = "AppMetricsPrometheusApi",
            MeasurementUnit = Unit.Calls
        };

        public static CounterOptions CalledAllPromesCounter => new CounterOptions
        {
            Name = "Called All Promes",
            Context = "AppMetricsPrometheusApi",
            MeasurementUnit = Unit.Calls
        };

    }
}
