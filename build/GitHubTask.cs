using Cake.Common.Build;
using Cake.Common.IO;

namespace Build;

[TaskName("GitHub-Actions")]
[IsDependentOn(typeof(WorldTask))]
public sealed class GitHubTask : AsyncFrostingTask<BuildContext>
{
    public override Task RunAsync(BuildContext context)
        => context.GitHubActions().Commands.UploadArtifact(
            context.File("./build.cake"),
            context.Environment.Platform.Family.ToString("F"));
}