using Application.Common.Dto.Field;
using Application.Services.Accounting.UserPetSrv.Dto;
using Application.Services.CompanionSrvs.CompanionInsurancePackageSrv.Dto;
using Application.Services.Order.AddressSrv.Dto;
using Application.Services.Order.RebateSrv.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.CompanionSrvs.CompanionInsurancePackageSaleSrv.Dto
{
    public class CompanionInsurancePackageSaleVDto : Id_FieldDto
    {
        public long CompanionInsurancePackageId { get; set; }
        public double Price { get; set; }
        public long UserPetId { get; set; }
        public long AddressId { get; set; }
        public bool IsPaid { get; set; }

        public double Discount { get; set; }
        public double PaymentPrice { get; set; }
        public long? RebateId { get; set; }
        public double RebatePrice { get; set; }
        public bool FromWallet { get; set; }
        public double WalletPrice { get; set; }
        public DateTime? ManualPayDate { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public UserPetVDto UserPet { get; set; }
        public AddressVDto Address { get; set; }
        public RebateVDto Rebate { get; set; }
        public CompanionInsurancePackageVDto CompanionInsurancePackage { get; set; }
    }
}
