using Itmo.ObjectOrientedProgramming.Lab2.Type;

namespace Itmo.ObjectOrientedProgramming.Lab2.Models.VideoCard;

public class VideoCard : IVideoCard
{
    internal VideoCard(
        SizeType videoCardSizeType,
        CountType countVideoMemory,
        PciEVersion pciEVersion,
        CountType frequencyChip,
        CountType powerConsumptionV)
    {
        VideoCardSizeType = videoCardSizeType;
        CountVideoMemory = countVideoMemory;
        PciEVersion = pciEVersion;
        FrequencyChip = frequencyChip;
        PowerConsumptionV = powerConsumptionV;
    }

    public SizeType VideoCardSizeType { get; }
    public CountType CountVideoMemory { get; }
    public PciEVersion PciEVersion { get; }
    public CountType FrequencyChip { get; }
    public CountType PowerConsumptionV { get; }
    public IVideoCardBuilder Direct(IVideoCardBuilder videoCardBuilder)
    {
        videoCardBuilder.AddVideoCardSize(VideoCardSizeType)
            .AddCountVideoMemory(CountVideoMemory)
            .AddPciEVersion(PciEVersion)
            .AddFrequencyChip(FrequencyChip)
            .AddPowerConsumptionV(PowerConsumptionV);
        return videoCardBuilder;
    }
}