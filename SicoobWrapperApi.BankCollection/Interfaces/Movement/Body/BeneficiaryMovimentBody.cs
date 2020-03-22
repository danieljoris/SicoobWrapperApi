using System;

namespace SicoobWrapperApi.BankCollection.Interfaces.Movement.Body
{
    public class BeneficiaryMovimentBody
    {
        public int ContractNumber { get; set; }
        public int MovimentType { get; set; }
        public DateTime InitialDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
