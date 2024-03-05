namespace HealthChecks.Hangfire;

/// <summary>
/// Options for <see cref="HangfireHealthCheck"/>.
/// </summary>
public class HangfireOptions
{
    public int? MaximumJobsFailed { get; set; }

    public int? MinimumAvailableServers { get; set; }

    public int? MaximumQueuedJobs { get; set; }

    public string? JobQueue { get; set; }
}
