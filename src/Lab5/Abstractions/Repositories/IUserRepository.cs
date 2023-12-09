using Contracts.Users;
using Models.Accounts;
namespace Abstractions.Repositories;

public interface IUserRepository
{
    public Task<UserAccount?> FindAccountUserByAccountNumberAndPasswordAsync(long accountNumber, string password);
    public Task<long?> ToUpBalanceAsync(long id, long amountMoney);
    public Task<MakeWithdrawalResult?> MakeWithdrawalAsync(long id, long amountMoney);
    public Task<long?> CheckBalance(long id);
}