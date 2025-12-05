using Application.Common.Interface;
using Application.Services.CompanionSrvs.CompanionCommentSrv.Dto;
using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.CompanionSrvs.CompanionCommentSrv.Iface
{
    public interface ICompanionCommentService : ICommonSrv<CompanionComment, CompanionCommentDto>
    {
        CompanionCommentSearchDto Search(CompanionCommentInputDto baseSearchDto);
    }
}
