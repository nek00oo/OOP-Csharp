namespace Itmo.ObjectOrientedProgramming.Lab4.ExecutionContext;

public abstract record OperationResult
{
    private OperationResult() { }

    public sealed record Success : OperationResult;
    public sealed record ExecutionError : OperationResult;
}