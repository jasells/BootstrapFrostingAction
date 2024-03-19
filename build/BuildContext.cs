namespace Build;

public class BuildContext : FrostingContext
{
    public bool Delay { get; init; }

    public BuildContext(ICakeContext context) : base(context)
    {
        Delay = context.Arguments.HasArgument("delay");

        foreach (var arg in context.Arguments.GetArguments())
        {
            context.Log.Information($"{arg.Key}:{arg.Value}\n");
        }
    }
}
