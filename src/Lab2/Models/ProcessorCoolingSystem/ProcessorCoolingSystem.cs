using System.Collections.Generic;
using System.Linq;
using Itmo.ObjectOrientedProgramming.Lab2.Result;
using Itmo.ObjectOrientedProgramming.Lab2.Type;

namespace Itmo.ObjectOrientedProgramming.Lab2.Models.ProcessorCoolingSystem;

public class ProcessorCoolingSystem : IProcessorCoolingSystem
{
    internal ProcessorCoolingSystem(
        IReadOnlyCollection<SocketType> socket,
        CountType tdp,
        SizeType size,
        CountType powerConsumptionV)
    {
        SocketSupported = socket;
        Tdp = tdp;
        this.Size = size;
        PowerConsumptionV = powerConsumptionV;
    }

    public IReadOnlyCollection<SocketType> SocketSupported { get; }
    public CountType Tdp { get; }
    public SizeType Size { get; }
    public CountType PowerConsumptionV { get; }
    public IValidateResult IsCoolingSystemCompatibility(IProcessor processor)
    {
        if (processor.Tdp.Count > Tdp.Count * 1.2)
            return new IsNotCompability<IProcessorCoolingSystem, IProcessor>(this, processor);
        if (!SocketSupported.Contains(processor.Socket))
            return new IsNotCompability<IProcessorCoolingSystem, IProcessor>(this, processor);
        if (processor.Tdp.Count > Tdp.Count && processor.Tdp.Count < Tdp.Count * 1.2)
            return new SuccessValidateResult.DisclaimerWarrantyObligations();

        return new SuccessValidateResult.SuccessCompability();
    }

    public IProcessorCoolingSystemBuilder Direct(IProcessorCoolingSystemBuilder processorCoolingSystemBuilder)
    {
        foreach (SocketType socketType in SocketSupported)
        {
            processorCoolingSystemBuilder.AddSocket(socketType);
        }

        processorCoolingSystemBuilder.AddTdp(Tdp)
            .AddSize(Size)
            .AddPowerConsumptionV(PowerConsumptionV);
        return processorCoolingSystemBuilder;
    }
}