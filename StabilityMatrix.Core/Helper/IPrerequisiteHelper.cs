﻿using System.Runtime.Versioning;
using StabilityMatrix.Core.Models.Progress;
using StabilityMatrix.Core.Processes;

namespace StabilityMatrix.Core.Helper;

public interface IPrerequisiteHelper
{
    string GitBinPath { get; }

    bool IsPythonInstalled { get; }

    Task InstallAllIfNecessary(IProgress<ProgressReport>? progress = null);
    Task UnpackResourcesIfNecessary(IProgress<ProgressReport>? progress = null);
    Task InstallGitIfNecessary(IProgress<ProgressReport>? progress = null);
    Task InstallPythonIfNecessary(IProgress<ProgressReport>? progress = null);

    [SupportedOSPlatform("Windows")]
    Task InstallVcRedistIfNecessary(IProgress<ProgressReport>? progress = null);

    /// <summary>
    /// Run embedded git with the given arguments.
    /// </summary>
    Task RunGit(ProcessArgs args, Action<ProcessOutput>? onProcessOutput, string? workingDirectory = null);

    /// <summary>
    /// Run embedded git with the given arguments.
    /// </summary>
    Task RunGit(ProcessArgs args, string? workingDirectory = null);

    Task<ProcessResult> GetGitOutput(ProcessArgs args, string? workingDirectory = null);

    async Task<bool> CheckIsGitRepository(string directory)
    {
        var result = await GetGitOutput(["rev-parse", "--is-inside-work-tree"], directory)
            .ConfigureAwait(false);

        return result.ExitCode == 0 && result.StandardOutput?.Trim().ToLowerInvariant() == "true";
    }

    Task InstallTkinterIfNecessary(IProgress<ProgressReport>? progress = null);
}
