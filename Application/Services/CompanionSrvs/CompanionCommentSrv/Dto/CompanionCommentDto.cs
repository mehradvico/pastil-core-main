using Application.Services.CommonSrv.CommentSrv.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.CompanionSrvs.CompanionCommentSrv.Dto
{
    public class CompanionCommentDto : CommentDto
    {
        public long CompanionId { get; set; }
    }
}
