using Application.Common.Dto.Result;
using Application.Common.Interface;
using Application.Services.Content.DiscussionAnswerLikeSrv.Dto;
using Entities.Entities;
using System.Threading.Tasks;

namespace Application.Services.Content.DiscussionAnswerLikeSrv.Iface
{
    public interface IDiscussionAnswerLikeService : ICommonSrv<DiscussionAnswerLike, DiscussionAnswerLikeDto>
    {
        DiscussionAnswerLikeSearchDto SearchDto(DiscussionAnswerLikeInputDto dto);
        Task<BaseResultDto> InsertOrDeleteAsync(DiscussionAnswerLikeInsertDeleteDto dto);
    }
}
