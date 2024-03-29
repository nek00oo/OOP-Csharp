using Itmo.ObjectOrientedProgramming.Lab1.Service.TransferDamage;

namespace Itmo.ObjectOrientedProgramming.Lab1.Models.Deflector;

public class DeflectorFirstClass : IDeflector
{
    private const int HealthPointsDeflectorFirstClass = 60;
    private const int CoefficientAbsorptionSmallDamageForDeflectorFirstClass = 2;
    private const int CoefficientAbsorptionAverageDamageForDeflectorFirsClass = 2;
    private const int SmallDamage = 70;
    private const int AverageDamage = 170;
    public int HealthPoints { get; private set; } = HealthPointsDeflectorFirstClass;
    public bool IsDisabled() => HealthPoints < 0;

    public DamageResult TakeDamageResult(int damage, int countObstacles)
    {
        if (IsDisabled())
            return new DamageResult.DamageOverflow(countObstacles);
        for (int i = 0; i < countObstacles; i++)
        {
            if (damage < SmallDamage)
                HealthPoints -= damage / CoefficientAbsorptionSmallDamageForDeflectorFirstClass;
            else if (damage < AverageDamage)
                HealthPoints -= damage / CoefficientAbsorptionAverageDamageForDeflectorFirsClass;
            else
                HealthPoints -= damage;
            if (IsDisabled())
                return new DamageResult.DamageOverflow(countObstacles - i);
        }

        return new DamageResult.DamageSustained();
    }
}