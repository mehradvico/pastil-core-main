using Application.Common.Dto.Result;
using Application.Common.Helpers;
using Application.Common.Interface;
using Application.Common.Service;
using Application.Services.Content.DiscussionQuestionSrv.Dto;
using Application.Services.Content.DiscussionQuestionSrv.Iface;
using AutoMapper;
using Entities.Entities;
using Microsoft.EntityFrameworkCore;
using Persistence.Interface;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Application.Services.Content.DiscussionQuestionSrv
{
    public class DiscussionQuestionService : CommonSrv<DiscussionQuestion, DiscussionQuestionDto>, IDiscussionQuestionService
    {
        private readonly IDataBaseContext _context;
        private readonly IMapper mapper;
        private readonly ICurrentUserHelper _currentUser;

        public DiscussionQuestionService(IDataBaseContext _context, IMapper mapper, ICurrentUserHelper currentUser) : base(_context, mapper)
        {
            this._context = _context;
            this.mapper = mapper;
            this._currentUser = currentUser;
        }
        public async Task<BaseResultDto<DiscussionQuestionVDto>> FindAsyncVDto(long id, bool visit = true)
        {
            var item = await _context.DiscussionQuestions.Include(s => s.DiscussionAnswers.Where(s => s.Active)).ThenInclude(s => s.User).FirstOrDefaultAsync(s => s.Id == id && s.Active && !s.Deleted);
            if (item != null)
            {
                return new BaseResultDto<DiscussionQuestionVDto>(true, mapper.Map<DiscussionQuestionVDto>(item));
            }
            return new BaseResultDto<DiscussionQuestionVDto>(false, mapper.Map<DiscussionQuestionVDto>(item));
        }

        public override async Task<BaseResultDto<DiscussionQuestionDto>> FindAsyncDto(long id)
        {
            var item = await _context.DiscussionQuestions.Include(s => s.User).Include(s => s.Product).FirstOrDefaultAsync(s => s.Id == id && !s.Deleted);
            if (item != null)
            {
                return new BaseResultDto<DiscussionQuestionDto>(true, mapper.Map<DiscussionQuestionDto>(item));
            }
            return new BaseResultDto<DiscussionQuestionDto>(false, mapper.Map<DiscussionQuestionDto>(item));
        }

        public DiscussionQuestionSearchDto Search(DiscussionQuestionInputDto baseSearchDto)
        {
            var query = _context.DiscussionQuestions.Include(s => s.DiscussionAnswers.Where(s => s.Active)).ThenInclude(s => s.User).Include(s => s.User).Include(s => s.Product).Where(s => !s.Deleted).AsQueryable();
            DateTime now = DateTime.Now;

            if (baseSearchDto.Available == true)
            {
                query = query.Where(s => s.Active && s.AdminConfirm == true);
            }
            if (baseSearchDto.ProductId.HasValue)
            {
                query = query.Where(s => s.ProductId == baseSearchDto.ProductId.Value);
            }
            if (baseSearchDto.FromDate.HasValue)
            {
                query = query.Where(s => s.CreateDate.Date >= baseSearchDto.FromDate.Value.Date);
            }
            if (baseSearchDto.ToDate.HasValue)
            {
                query = query.Where(s => s.CreateDate.Date <= baseSearchDto.ToDate.Value.Date);
            }
            if (baseSearchDto.Active.HasValue)
            {
                query = query.Where(s => s.Active == baseSearchDto.Active.Value);
            }
            switch (baseSearchDto.SortBy)
            {
                case Common.Enumerable.SortEnum.New:
                    {
                        query = query.OrderByDescending(s => s.Id);
                        break;
                    }
                case Common.Enumerable.SortEnum.Old:
                    {
                        query = query.OrderBy(s => s.Id);
                        break;
                    }
                default:
                    break;
            }
            return new DiscussionQuestionSearchDto(baseSearchDto, query, mapper);
        }

        public override async Task<BaseResultDto<DiscussionQuestionDto>> InsertAsyncDto(DiscussionQuestionDto dto)
        {
            try
            {
                var modelCheker = ModelHelper<DiscussionQuestionDto>.ModelErrors(dto);
                if (!modelCheker.IsSuccess)
                {
                    return modelCheker;
                }
                else
                {
                    var item = mapper.Map<DiscussionQuestion>(dto);
                    item.CreateDate = DateTime.Now;
                    await _context.DiscussionQuestions.AddAsync(item);
                    await _context.SaveChangesAsync();
                    return new BaseResultDto<DiscussionQuestionDto>(true, mapper.Map<DiscussionQuestionDto>(item));
                }

            }
            catch (Exception ex)
            {
                return new BaseResultDto<DiscussionQuestionDto>(isSuccess: false, val: ex.Message, data: dto);
            }
        }

        public override BaseResultDto UpdateDto(DiscussionQuestionDto dto)
        {
            try
            {
                var modelCheker = ModelHelper<DiscussionQuestionDto>.ModelErrors(dto);
                if (!modelCheker.IsSuccess)
                {
                    return modelCheker;
                }
                else
                {
                    var item = mapper.Map<DiscussionQuestion>(dto);
                    _context.DiscussionQuestions.Attach(item);
                    _context.Entry(item).State = EntityState.Modified;
                    _context.SaveChanges();
                    return new BaseResultDto(isSuccess: true);
                }
            }
            catch (Exception ex)
            {
                return new BaseResultDto(isSuccess: false, val: ex.Message);
            }
        }

        public BaseResultDto UpdateAnswerCountDto(DiscussionQuestionDto dto)
        {
            var topic = _context.DiscussionQuestions.Include(t => t.DiscussionAnswers).FirstOrDefault(t => t.Id == dto.Id && t.Active && !t.Deleted);
            topic.AnswerCount = topic.DiscussionAnswers.Count() + 1;
            _context.DiscussionQuestions.Update(topic);
            _context.SaveChanges();
            return new BaseResultDto(isSuccess: true);
        }
    }
}
