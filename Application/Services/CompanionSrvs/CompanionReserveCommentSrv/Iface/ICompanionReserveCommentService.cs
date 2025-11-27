using Application.Common.Dto.Result;
using Application.Common.Interface;
using Application.Services.CompanionSrvs.CompanionReserveCommentSrv.Dto;
using Entities.Entities.CompanionField;
using System.Threading.Tasks;

namespace Application.Services.CompanionSrvs.CompanionReserveCommentSrv.Iface
{
    public interface ICompanionReserveCommentService : ICommonSrv<CompanionReserveComment, CompanionReserveCommentDto>
    {
        Task<BaseResultDto> UpdateDtoAsync(CompanionReserveCommentDto dto);
        CompanionReserveCommentSearchDto Search(CompanionReserveCommentInputDto baseSearchDto);
        Task UpdateCompanionCommentRateAsync(long Id);
        Task<BaseResultDto<CompanionReserveCommentVDto>> FindAsyncVDto(long id);


    }
}
