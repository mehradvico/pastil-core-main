using Entities.Entities.CommonField;
using System;

namespace Entities.Entities.CompanionField
{
    public class CompanionInsurancePackageSale : Id_Field
    {
        public long CompanionInsurancePackageId { get; set; }
        public double Price { get; set; }
        public double PaymentPrice { get; set; }
        public bool FromWallet { get; set; }
        public double WalletPrice { get; set; }
        public long UserPetId { get; set; }
        public long AddressId { get; set; }
        public bool IsPaid { get; set; }
        public long? RebateId { get; set; }
        public double RebatePrice { get; set; }
        public double Discount { get; set; }
        public DateTime? ManualPayDate { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public UserPet UserPet { get; set; }
        public Address Address { get; set; }
        public Rebate Rebate { get; set; }
        public CompanionInsurancePackage CompanionInsurancePackage { get; set; }
        public Wallet Wallet { get; set; }
    }
}
