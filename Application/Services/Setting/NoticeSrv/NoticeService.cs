using AngleSharp.Dom;
using Application.Common.Dto.Result;
using Application.Common.Enumerable;
using Application.Common.Enumerable.Code;
using Application.Common.Helpers;
using Application.Common.Interface;
using Application.Common.Service;
using Application.Services.CodeSrv.Dto;
using Application.Services.Setting.CodeSrv;
using Application.Services.Setting.CodeSrv.Iface;
using Application.Services.Setting.NoticeSrv.Dto;
using Application.Services.Setting.NoticeSrv.Iface;
using AutoMapper;
using Entities.Entities;
using Microsoft.EntityFrameworkCore;
using Persistence.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.Setting.NoticeSrv
{
    public class NoticeService : CommonSrv<Notice, NoticeDto>, INoticeService
    {
        private readonly IDataBaseContext _context;
        private readonly IMapper mapper;
        private readonly ICurrentUserHelper _currentUser;
        private readonly ICodeService _codeService;

        public NoticeService(IDataBaseContext context, IMapper mapper, ICurrentUserHelper currentUser, ICodeService codeService) : base(_context: context, mapper: mapper)
        {
            _context = context;
            this.mapper = mapper;
            this._currentUser = currentUser;
            this._codeService = codeService;
        }

        public NoticeSearchDto Search(NoticeInputDto baseSearchDto)
        {
            var model = _context.Notices.Include(s => s.User).Include(s => s.Type).AsQueryable();

            if (baseSearchDto.UserId.HasValue)
            {
                model = model.Where(s => s.UserId == baseSearchDto.UserId);
            }
            if (baseSearchDto.TypeId.HasValue)
            {
                model = model.Where(s => s.TypeId == baseSearchDto.TypeId);
            }
            if (baseSearchDto.IsRead == true)
            {
                model = model.Where(s => s.ReadDate.HasValue);
            }
            if (baseSearchDto.IsRead == false)
            {
                model = model.Where(s => s.ReadDate == null);
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

            return new NoticeSearchDto(baseSearchDto, model, mapper);
        }

        public async Task<BaseResultDto<NoticeDto>> FindAsyncUserDto(long id, long? userId)
        {
            var item = await _context.Notices.FirstOrDefaultAsync(s => s.Id == id);

            if (item != null)
            {
                item.ReadDate = DateTime.Now;
                item.UserId = _currentUser.CurrentUser.UserId;

                _context.Entry(item).Property(nameof(item.ReadDate)).IsModified = true;
                _context.Entry(item).Property(nameof(item.UserId)).IsModified = true;

                await _context.SaveChangesAsync();

                item = await _context.Notices.Include(s => s.User).Include(s => s.Type).FirstOrDefaultAsync(s => s.Id == id);
                return new BaseResultDto<NoticeDto>(true, mapper.Map<NoticeDto>(item));
            }

            return new BaseResultDto<NoticeDto>(false, mapper.Map<NoticeDto>(item));
        }

        public override async Task<BaseResultDto<NoticeDto>> InsertAsyncDto(NoticeDto dto)
        {
            try
            {
                var modelCheker = ModelHelper<NoticeDto>.ModelErrors(dto);
                if (!modelCheker.IsSuccess)
                {
                    return modelCheker;
                }
                else
                {
                    var item = mapper.Map<Notice>(dto);
                    item.CreateDate = DateTime.Now;
                    await _context.Notices.AddAsync(item);
                    await _context.SaveChangesAsync();
                    return new BaseResultDto<NoticeDto>(true, mapper.Map<NoticeDto>(item));
                }

            }
            catch (Exception ex)
            {
                return new BaseResultDto<NoticeDto>(isSuccess: false, val: ex.Message, data: dto);
            }
        }

        public override BaseResultDto UpdateDto(NoticeDto dto)
        {
            try
            {
                var modelCheker = ModelHelper<NoticeDto>.ModelErrors(dto);
                if (!modelCheker.IsSuccess)
                {
                    return modelCheker;
                }
                else
                {
                    var item = _context.Notices.FirstOrDefault(x => x.Id == dto.Id);
                    mapper.Map(dto, item);
                    _context.SaveChanges();
                    return new BaseResultDto(isSuccess: true);
                }
            }
            catch (Exception ex)
            {
                return new BaseResultDto(isSuccess: false, val: ex.Message);
            }
        }

        public async Task InsertNoticeAsync(long itemId, NoticeTypeEnum notifTypeEnum, NoticeUserTypeEnum usernotifTypeEnum)
        {
            var notifType = await _codeService.GetByLabelAsync(notifTypeEnum.ToString());
            var usernotifType = await _codeService.GetByLabelAsync(usernotifTypeEnum.ToString());

            var notif = new NoticeDto
            {
                ItemId = itemId,
                TypeId = notifType.Id,
                UserTypeId = usernotifType.Id,
            };
            await InsertAsyncDto(notif);
        }
    }
}
