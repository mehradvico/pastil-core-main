using Application.Common.Dto.Input;
using Application.Common.Service;
using Application.Services.CompanionSrvs.CompanionAssistancePackagePictureSrv.Dto;
using Application.Services.CompanionSrvs.CompanionAssistancePackagePictureSrv.Iface;
using AutoMapper;
using Entities.Entities;
using Entities.Entities.CompanionField;
using Microsoft.EntityFrameworkCore;
using Persistence.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.CompanionSrvs.CompanionAssistancePackagePictureSrv
{
    public class CompanionAssistancePackagePictureService : CommonSrv<CompanionAssistancePackagePicture, CompanionAssistancePackagePictureDto>, ICompanionAssistancePackagePictureService
    {
        private readonly IDataBaseContext _context;
        private readonly IMapper mapper;
        public CompanionAssistancePackagePictureService(IDataBaseContext _context, IMapper mapper) : base(_context, mapper)
        {
            this._context = _context;
            this.mapper = mapper;
        }

        public CompanionAssistancePackagePictureSearchDto SearchDto(CompanionAssistancePackagePictureInputDto dto)
        {

            var model = _context.CompanionAssistancePackagePictures.Include(p => p.Picture).AsQueryable();
            if (dto.CompanionAssistancePackageId.HasValue)
            {
                model = model.Where(s => s.CompanionAssistancePackageId.Equals(dto.CompanionAssistancePackageId));
            }
            return new CompanionAssistancePackagePictureSearchDto(dto, model, mapper);

        }
        public void InsertOrUpdate(CompanionAssistancePackagePictureDto CompanionAssistancePackagePicture)
        {
            var item = _context.CompanionAssistancePackagePictures.FirstOrDefault(s => s.CompanionAssistancePackageId == CompanionAssistancePackagePicture.CompanionAssistancePackageId && s.PictureId == CompanionAssistancePackagePicture.PictureId);
            if (item != null)
            {
                _context.CompanionAssistancePackagePictures.Update(item);
            }
            else
            {
                item = mapper.Map<CompanionAssistancePackagePicture>(CompanionAssistancePackagePicture);
                _context.CompanionAssistancePackagePictures.Add(item);
            }
            _context.SaveChanges();
        }

        public void InsertOrUpdate(CompanionAssistancePackage CompanionAssistancePackage, List<CompanionAssistancePackagePictureDto> CompanionAssistancePackagePicturesDto)
        {
            if (CompanionAssistancePackage.CompanionAssistancePackagePictures != null)
            {
                _context.CompanionAssistancePackagePictures.RemoveRange(CompanionAssistancePackage.CompanionAssistancePackagePictures);
                _context.SaveChanges();
            }
            else
            {
                CompanionAssistancePackage.CompanionAssistancePackagePictures = new List<CompanionAssistancePackagePicture>();
            }
            CompanionAssistancePackagePicturesDto.ForEach(s => s.CompanionAssistancePackageId = CompanionAssistancePackage.Id);
            foreach (var item in CompanionAssistancePackagePicturesDto)
            {
                InsertOrUpdate(item);
            }
        }
    }
}
