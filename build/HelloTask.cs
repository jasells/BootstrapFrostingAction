namespace Build;

[TaskName("Hello")]
public sealed class HelloTask : FrostingTask<BuildContext>
{
    public override void Run(BuildContext context)
    {
        context.Log.Information("all args: \n");

        foreach (var arg in context.Arguments.GetArguments())
        {
            string val = "";

            foreach (var item in arg.Value) { val += item; }

            context.Log.Information($"{arg.Key}:{val}\n");
        }
    }
}
