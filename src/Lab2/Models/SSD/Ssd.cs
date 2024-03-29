using System;
using Itmo.ObjectOrientedProgramming.Lab2.Models.MotherBoard;
using Itmo.ObjectOrientedProgramming.Lab2.Type;

namespace Itmo.ObjectOrientedProgramming.Lab2.Models.SSD;

public class Ssd : ISsd
{
    internal Ssd(CountType powerConsumptionV, CountType memoryCapacityGb, SpeedType maxBandWidth, PortType portType)
    {
        PowerConsumptionV = powerConsumptionV;
        MemoryCapacityGb = memoryCapacityGb;
        MaxBandWidth = maxBandWidth;
        PortType = portType;
    }

    public CountType PowerConsumptionV { get; }
    public CountType MemoryCapacityGb { get; }
    public SpeedType MaxBandWidth { get; }
    public PortType PortType { get; }
    public bool IsConnectMotherBoard(IMotherboard motherboard)
    {
        if (PortType is PortType.Sata)
           return motherboard.ConnectToSataPort();
        if (PortType is PortType.PciE)
           return motherboard.ConnectToPciEPort();
        throw new InvalidOperationException("Non-existent port type");
    }

    public ISsdBuilder Direct(ISsdBuilder ssdBuilder)
    {
        ssdBuilder.AddPowerConsumptionV(PowerConsumptionV)
            .AddMemoryCapacityGb(MemoryCapacityGb)
            .AddMaxBandWidth(MaxBandWidth);
        return ssdBuilder;
    }
}