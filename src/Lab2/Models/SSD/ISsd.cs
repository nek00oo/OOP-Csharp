using Itmo.ObjectOrientedProgramming.Lab2.Models.MotherBoard;
using Itmo.ObjectOrientedProgramming.Lab2.Type;

namespace Itmo.ObjectOrientedProgramming.Lab2.Models.SSD;

public interface ISsd : ISsdBuilderDirect, IExternalMemory, IComputerComponent
{
    // вариант подключения SATA или PCI-E (скорее всего через интерфейс)
    public SpeedType MaxBandWidth { get; } // макс скорость работы
    public bool IsConnectMotherBoard(IMotherboard motherboard);
}