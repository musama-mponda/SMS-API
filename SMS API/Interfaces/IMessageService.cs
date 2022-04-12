using SMS_API.Models;

namespace SMS_API.Interfaces;

public interface IMessageService
{
    public Task<string> SingleMessageService(MessageDto messageDto);

    public Task<string> MultipleMessageService(List<MessageDto> messageDto);
}