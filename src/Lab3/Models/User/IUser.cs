using Itmo.ObjectOrientedProgramming.Lab3.Models.Message;

namespace Itmo.ObjectOrientedProgramming.Lab3.Models.User;

public interface IUser : IMessageReceiver
{
    void MarkMessageRead(IMessage message);
    bool IsMessageRead(IMessage message);
}