using AutoMapper;
using SMS_API.Entities;
using SMS_API.Models;

namespace SMS_API.Mappings;

public class MessageMapper : Profile
{
    public MessageMapper()
    {
        CreateMap<MessageDto, Messages>()
            .ForAllMembers(options =>
            {
                options.DoNotAllowNull();
            });
    }
    
}