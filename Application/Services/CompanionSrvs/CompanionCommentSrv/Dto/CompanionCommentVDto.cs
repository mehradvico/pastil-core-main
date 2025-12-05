using Application.Services.CommonSrv.CommentSrv.Dto;
using Application.Services.CompanionSrvs.CompanionSrv.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.CompanionSrvs.CompanionCommentSrv.Dto
{
    public class CompanionCommentVDto : CommentVDto
    {
        public long CompanionId { get; set; }
    }
}
