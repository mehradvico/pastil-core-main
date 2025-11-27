using Entities.Entities.CommonField;
using System;

namespace Entities.Entities
{
    public class Cargo : Id_Field
    {
        public DateTime DateGone { get; set; }
        public DateTime? DateReturn { get; set; }
        public DateTime CreateDate { get; set; }
        public long FromStateId { get; set; }
        public long ToStateId { get; set; }
        public long UserPetId { get; set; }
        public bool Accompany { get; set; }
        public double Price { get; set; }
        public bool FromWallet { get; set; }
        public double WalletPrice { get; set; }
        public double PaymentPrice { get; set; }
        public long? RebateId { get; set; }
        public double RebatePrice { get; set; }
        public double Discount { get; set; }
        public double DefaultPrice { get; set; }
        public double? NotAccompanyPrice { get; set; }
        public double? ReturnPrice { get; set; }
        public bool IsPaid { get; set; }
        public long StatusId { get; set; }
        public string StatusDetail { get; set; }
        public UserPet UserPet { get; set; }
        public State FromState { get; set; }
        public State ToState { get; set; }
        public Code Status { get; set; }
        public Rebate Rebate { get; set; }
        public Wallet Wallet { get; set; }
    }
}
