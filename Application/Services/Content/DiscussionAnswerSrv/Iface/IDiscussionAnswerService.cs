using Application.Common.Interface;
using Application.Services.Content.DiscussionAnswerSrv.Dto;
using Entities.Entities;

namespace Application.Services.Content.DiscussionAnswerSrv.Iface
{
    public interface IDiscussionAnswerService : ICommonSrv<DiscussionAnswer, DiscussionAnswerDto>
    {
        DiscussionAnswerSearchDto Search(DiscussionAnswerInputDto baseSearchDto);
    }
}
