using Itmo.ObjectOrientedProgramming.Lab1.Entities.SpaceShip;
using Itmo.ObjectOrientedProgramming.Lab1.Service.NavigateRouteResult;

namespace Itmo.ObjectOrientedProgramming.Lab1.Models.Obstacles;

public class ObstacleAsteroid : IObstacleSpace
{
    public int Damage { get; } = 26;
    public int Weight { get; } = 2;

    public bool InteractionWithSpaceShip(SpaceShipBase spaceShip,  int countObstacles, ref NavigateRouteResult navigateRouteResult)
    {
        if (spaceShip.TakeDamage(this, countObstacles))
            return true;

        navigateRouteResult = new NavigateRouteResult.ShipIsDestroyed(spaceShip);
        return false;
    }
}