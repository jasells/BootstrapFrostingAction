using Cake.Common.Build;
using Cake.Common.IO;

namespace Build;

[TaskName("GitHub-Actions")]
[IsDependentOn(typeof(DefaultTask))]
public sealed class GitHubTask : AsyncFrostingTask<BuildContext>
{
    public override Task RunAsync(BuildContext context)
        => context.GitHubActions().Commands.UploadArtifact(
            context.File("./LICENSE"),
            context.Environment.Platform.Family.ToString("F")
            );
}