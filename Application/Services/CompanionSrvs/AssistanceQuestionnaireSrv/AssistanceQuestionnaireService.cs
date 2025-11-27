using Application.Common.Dto.Result;
using Application.Common.Service;
using Application.Services.CompanionSrvs.AssistanceQuestionnaireSrv.Dto;
using Application.Services.CompanionSrvs.AssistanceQuestionnaireSrv.Iface;
using AutoMapper;
using Entities.Entities;
using Microsoft.EntityFrameworkCore;
using Persistence.Interface;
using System.Linq;
using System.Threading.Tasks;

namespace Application.Services.CompanionSrvs.AssistanceQuestionnaireSrv
{
    public class AssistanceQuestionnaireService : CommonSrv<AssistanceQuestionnaire, AssistanceQuestionnaireDto>, IAssistanceQuestionnaireService
    {
        private readonly IDataBaseContext _context;
        private readonly IMapper mapper;
        public AssistanceQuestionnaireService(IDataBaseContext _context, IMapper mapper) : base(_context, mapper)
        {
            this._context = _context;
            this.mapper = mapper;
        }

        public async Task<BaseResultDto<AssistanceQuestionnaireVDto>> FindAsyncVDto(long id)
        {
            var item = await _context.AssistanceQuestionnaires.Include(s => s.Assistance).FirstOrDefaultAsync(s => s.Id == id && !s.Deleted);
            if (item != null)
            {
                return new BaseResultDto<AssistanceQuestionnaireVDto>(true, mapper.Map<AssistanceQuestionnaireVDto>(item));
            }
            return new BaseResultDto<AssistanceQuestionnaireVDto>(false, mapper.Map<AssistanceQuestionnaireVDto>(item));
        }

        public AssistanceQuestionnaireSearchDto Search(AssistanceQuestionnaireInputDto baseSearchDto)
        {
            var model = _context.AssistanceQuestionnaires.Include(s => s.Assistance).AsQueryable().Where(s => !s.Deleted);

            if (baseSearchDto.Available.HasValue)
            {
                model = model.Where(s => s.Active == baseSearchDto.Available.Value);
            }
            if (baseSearchDto.AssistanceId.HasValue)
            {
                model = model.Where(s => s.AssistanceId == baseSearchDto.AssistanceId.Value);
            }
            switch (baseSearchDto.SortBy)
            {
                case Common.Enumerable.SortEnum.Default:
                    {
                        model = model.OrderByDescending(s => s.Priority);
                        break;
                    }
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
                case Common.Enumerable.SortEnum.MorePriority:
                    {
                        model = model.OrderByDescending(s => s.Priority);
                        break;
                    }
                case Common.Enumerable.SortEnum.LessPriority:
                    {
                        model = model.OrderBy(s => s.Priority);
                        break;
                    }
                default:
                    break;
            }
            return new AssistanceQuestionnaireSearchDto(baseSearchDto, model, mapper);
        }
    }
}
