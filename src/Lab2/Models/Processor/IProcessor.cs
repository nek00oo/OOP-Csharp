using Itmo.ObjectOrientedProgramming.Lab2.Models.MotherBoard;
using Itmo.ObjectOrientedProgramming.Lab2.Result;
using Itmo.ObjectOrientedProgramming.Lab2.Type;

namespace Itmo.ObjectOrientedProgramming.Lab2.Models;

public interface IProcessor : IProcessorBuilderDirect, IConsumeEnergy, IComputerComponent
{
    public CountType CoreFrequency { get; }
    public CountType CountCore { get; }
    public SocketType Socket { get; }
    public CountType FrequencyMemory { get; }
    public CountType Tdp { get; }

    public IValidateResult IsProcessorCompatibility(IMotherboard motherboard);
}