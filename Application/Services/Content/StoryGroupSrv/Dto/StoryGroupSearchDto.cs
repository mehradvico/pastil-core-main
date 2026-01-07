using Application.Common.Dto.Result;
using Application.Services.Content.StoryGroupSrv.Dto;
using Application.Services.Content.StoryGroupSrv.Iface;
using AutoMapper;
using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.Content.StoryGroupSrv.Dto
{
    public class StoryGroupSearchDto : BaseSearchDto<StoryGroup, StoryGroupVDto>, IStoryGroupSearchFields
    {
        public StoryGroupSearchDto(StoryGroupInputDto dto, IQueryable<StoryGroup> list, IMapper mapper) : base(dto, list, mapper)
        {
        }
    }
}
