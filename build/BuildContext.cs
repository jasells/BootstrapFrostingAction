namespace Build;

public class BuildContext(ICakeContext context)
    : FrostingContext(context)
{
    public bool Delay { get; init; } = context.Arguments.HasArgument("delay");
}
