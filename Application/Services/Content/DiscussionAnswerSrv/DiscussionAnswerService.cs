using Application.Common.Dto.Result;
using Application.Common.Helpers;
using Application.Common.Service;
using Application.Services.Content.DiscussionAnswerSrv.Dto;
using Application.Services.Content.DiscussionAnswerSrv.Iface;
using Application.Services.Content.DiscussionQuestionSrv.Dto;
using Application.Services.Content.DiscussionQuestionSrv.Iface;
using AutoMapper;
using Entities.Entities;
using Microsoft.EntityFrameworkCore;
using Persistence.Interface;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Application.Services.Content.DiscussionAnswerSrv
{
    public class DiscussionAnswerService : CommonSrv<DiscussionAnswer, DiscussionAnswerDto>, IDiscussionAnswerService
    {
        private readonly IDataBaseContext _context;
        private readonly IMapper mapper;
        private readonly IDiscussionQuestionService _topicService;
        public DiscussionAnswerService(IDataBaseContext _context, IMapper mapper, IDiscussionQuestionService topicService) : base(_context, mapper)
        {
            this._context = _context;
            this.mapper = mapper;
            this._topicService = topicService;
        }
        public async Task<BaseResultDto<DiscussionAnswerVDto>> FindAsyncVDto(long id)
        {
            var item = await _context.DiscussionAnswers.Include(s => s.User).Include(s => s.DiscussionQuestion).FirstOrDefaultAsync(s => s.Id == id && s.Active && s.Deleted != true);
            if (item != null)
            {
                return new BaseResultDto<DiscussionAnswerVDto>(true, mapper.Map<DiscussionAnswerVDto>(item));
            }
            return new BaseResultDto<DiscussionAnswerVDto>(false, mapper.Map<DiscussionAnswerVDto>(item));
        }
        public DiscussionAnswerSearchDto Search(DiscussionAnswerInputDto baseSearchDto)
        {
            var model = _context.DiscussionAnswers.Include(s => s.User).Where(s => s.Deleted == false).IgnoreQueryFilters().AsQueryable();

            if (baseSearchDto.Available.HasValue)
            {
                model = model.Where(s => s.Active == baseSearchDto.Available.Value);
            }
            if (baseSearchDto.DiscussionQuestionId.HasValue)
            {
                model = model.Where(s => s.DiscussionQuestionId == baseSearchDto.DiscussionQuestionId);
            }
            if (baseSearchDto.UserId.HasValue)
            {
                model = model.Include(s => s.DiscussionAnswerLikes.Where(a => a.UserId == baseSearchDto.UserId)).Where(s => s.UserId == baseSearchDto.UserId);
            }
            switch (baseSearchDto.SortBy)
            {
                case Common.Enumerable.SortEnum.New:
                    {
                        model = model.OrderByDescending(s => s.Id);
                        break;
                    }
                case Common.Enumerable.SortEnum.Old:
                    {
                        model = model.OrderBy(s => s.Id);
                        break;
                    }
                default:
                    break;
            }
            return new DiscussionAnswerSearchDto(baseSearchDto, model, mapper);
        }
        public override async Task<BaseResultDto<DiscussionAnswerDto>> InsertAsyncDto(DiscussionAnswerDto dto)
        {
            try
            {
                var modelCheker = ModelHelper<DiscussionAnswerDto>.ModelErrors(dto);
                if (!modelCheker.IsSuccess)
                {
                    return modelCheker;
                }
                else
                {
                    var item = mapper.Map<DiscussionAnswer>(dto);
                    item.CreateDate = DateTime.Now;
                    await _context.DiscussionAnswers.AddAsync(item);
                    var updateResult = _topicService.UpdateAnswerCountDto(new DiscussionQuestionDto { Id = dto.DiscussionQuestionId });
                    await _context.SaveChangesAsync();
                    return new BaseResultDto<DiscussionAnswerDto>(true, mapper.Map<DiscussionAnswerDto>(item));
                }

            }
            catch (Exception ex)
            {
                return new BaseResultDto<DiscussionAnswerDto>(isSuccess: false, val: ex.Message, data: dto);
            }
        }
    }
}
