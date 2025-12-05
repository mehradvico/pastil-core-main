using Application.Common.Dto.Input;
using Application.Services.CompanionSrvs.CompanionCommentSrv.Iface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.CompanionSrvs.CompanionCommentSrv.Dto
{
    public class CompanionCommentInputDto : BaseInputDto, ICompanionCommentSearchFields
    {

        public long? CompanionId { get; set; }
        public bool? AllStatus { get; set; }

    }
}
