namespace Build;

[TaskName("Default")]
[IsDependentOn(typeof(GitHubTask))]
public class DefaultTask : FrostingTask
{
}