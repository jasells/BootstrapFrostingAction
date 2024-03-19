namespace Build;

[TaskName("Hello")]
public sealed class HelloTask : FrostingTask<BuildContext>
{
    public override void Run(BuildContext context)
    {
        context.Log.Information("all args: \n");

        foreach (var arg in context.Arguments.GetArguments())
        {
            context.Log.Information($"{arg.Key}:{arg.Value}\n");
        }
    }
}
