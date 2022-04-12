using AutoMapper;
using Flurl.Http;
using Newtonsoft.Json;
using SMS_API.Entities;
using SMS_API.Interfaces;
using SMS_API.Models;
using JsonSerializer = System.Text.Json.JsonSerializer;

namespace SMS_API.Services;

public class MessageService : IMessageService
{
    private readonly MessageDbContext _messageDbContext;
    private readonly IMapper _mapper;
   
    public MessageService(MessageDbContext messageDbContext, IMapper mapper)
    {
        _messageDbContext = messageDbContext;
        _mapper = mapper;
    }
    
    
    
    private const string Url = "http://41.175.8.68:8181/bulksms/sms/gariSms.php";
    public async Task<string> SingleMessageService(MessageDto messageDto)
    {
        return await SendMessage(messageDto);
    }

    public async Task<string> MultipleMessageService(List<MessageDto> contacts)
    {
        var task = Enumerable.Range(0, contacts.Count)
            .Select(x => SendMessage(contacts[x]));

        var result =  await  Task.WhenAll(task);

        return "Completed";
    }

    private async Task <string> SendMessage(MessageDto messageDto)
    {
        var response = await Url
            .PostJsonAsync(messageDto)
            .ReceiveString();

        var dbResponse = await UpdateMessageDb(messageDto);
        
        return response;
    }

    private async Task<Messages> UpdateMessageDb(MessageDto messageDto)
    {
        Messages currentMessage = new Messages();
        var message = _mapper.Map(messageDto, currentMessage);
        var updateDb = await _messageDbContext.Messages.AddAsync(message);
        await _messageDbContext.SaveChangesAsync();
        
        return updateDb.Entity;
    }
}
    