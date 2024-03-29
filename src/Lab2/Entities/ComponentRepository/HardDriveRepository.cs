using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab2.Models.HardDrive;
using Itmo.ObjectOrientedProgramming.Lab2.Type;

namespace Itmo.ObjectOrientedProgramming.Lab2.Entities.ComponentRepository;

public class HardDriveRepository
{
    private readonly List<IHardDrive> _hardDrives;

    public HardDriveRepository()
    {
        _hardDrives = new List<IHardDrive>
        {
            new Models.HardDrive.HardDrive(new CountType(30), new CountType(300), new SpeedType(10000)),
            new Models.HardDrive.HardDrive(new CountType(30), new CountType(500), new SpeedType(12000)),
        };
    }

    public IEnumerable<IHardDrive> ReturnHardDrives() => _hardDrives;

    public void AddHardDrive(IHardDrive hardDrive)
    {
        _hardDrives.Add(hardDrive);
    }
}