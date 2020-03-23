using System;
using System.Collections.Generic;
using System.Text;

namespace SicoobWrapperApi.BankCollection.Interfaces.Movement.Response
{
    public class BeneficiaryMovementResponse
    {
        public BeneficiaryMovementResponse()
        {
        }

        public BeneficiaryMovementResponse(string message, int requestCode)
        {
            Message = message;
            RequestCode = requestCode;
        }

        /// <summary>
        /// Mensagem da solicitação.
        /// (opcional)
        /// </summary>
        public string Message { get; private set; }

        /// <summary>
        /// Código da Solicitação.
        /// (opcional)
        /// </summary>
        public int RequestCode { get; private set; }
    }
}
