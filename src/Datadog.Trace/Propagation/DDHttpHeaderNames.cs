// <copyright file="HttpHeaderNames.cs" company="Datadog">
// Unless explicitly stated otherwise all files in this repository are licensed under the Apache 2 License.
// This product includes software developed at Datadog (https://www.datadoghq.com/). Copyright 2017 Datadog, Inc.
// </copyright>

namespace Datadog.Trace.Propagation
{
    /// <summary>
    /// Names of HTTP headers that can be used tracing inbound or outbound HTTP requests.
    /// </summary>
    public static class DDHttpHeaderNames
    {
        /// <summary>
        /// ID of a distributed trace.
        /// </summary>
        public const string TraceId = "x-datadog-trace-id";

        /// <summary>
        /// ID of the parent span in a distributed trace.
        /// </summary>
        public const string ParentId = "x-datadog-parent-id";

        /// <summary>
        /// Setting used to determine whether a trace should be sampled or not.
        /// </summary>
        public const string SamplingPriority = "x-datadog-sampling-priority";

        /// <summary>
        /// Origin of the distributed trace.
        /// </summary>
        public const string Origin = "x-datadog-origin";
    }
}
