using System.Diagnostics.CodeAnalysis;
using Contracts.Users;

namespace Console.Scenarios.MakeWithdrawal;

public class MakeWithdrawalScenarioProvider : IScenarioProvider
{
    private readonly IUserService _service;
    private readonly ICurrentUserService _currentUser;

    public MakeWithdrawalScenarioProvider(
        IUserService service,
        ICurrentUserService currentUser)
    {
        _service = service;
        _currentUser = currentUser;
    }

    public bool TryGetScenario(
        [NotNullWhen(true)] out IScenario? scenario)
    {
        if (_currentUser?.UserAccount is not null)
        {
            scenario = new MakeWithdrawalScenario(_service);
            return true;
        }

        scenario = null;
        return false;
    }
}