using Application.Common.Dto.Result;
using Application.Services.CompanionSrvs.CompanionInsurancePackageSaleSrv.Dto;
using Application.Services.CompanionSrvs.CompanionInsurancePackageSaleSrv.Iface;
using AutoMapper;
using Entities.Entities.CompanionField;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.CompanionSrvs.CompanionInsurancePackageSaleSaleSrv.Dto
{
    public class CompanionInsurancePackageSaleSearchDto : BaseSearchDto<CompanionInsurancePackageSale, CompanionInsurancePackageSaleVDto>, ICompanionInsurancePackageSaleSearchFields
    {
        public CompanionInsurancePackageSaleSearchDto(CompanionInsurancePackageSaleInputDto dto, IQueryable<CompanionInsurancePackageSale> list, IMapper mapper) : base(dto, list, mapper)
        {
            this.CompanionInsurancePackageId = dto.CompanionInsurancePackageId;
            this.UserPetId = dto.UserPetId;
            this.FromDate = dto.FromDate;
            this.ToDate = dto.ToDate;
            this.IsPaid = dto.IsPaid;
            this.ManualPay = dto.ManualPay;
            this.CompanionId = dto.CompanionId;
            this.UserId = dto.UserId;
        }
        public long? CompanionInsurancePackageId { get; set; }
        public long? UserPetId { get; set; }
        public long? UserId { get; set; }
        public bool? IsPaid { get; set; }
        public long? CompanionId { get; set; }
        public bool? ManualPay { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
    }
}
