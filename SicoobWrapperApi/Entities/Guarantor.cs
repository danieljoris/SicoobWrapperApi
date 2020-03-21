using Refit;
using System;
using System.Collections.Generic;
using System.Text;

namespace SicoobWrapperApi.BankCharges.Entities
{
    public class Guarantor
    {
        /// <summary>
        /// CPF ou CNPJ do Sacador avalista. Tamanho máximo 14
        /// (opcional)
        /// </summary>
        [AliasAs("numeroCpfCnpjSacadorAvalista")]
        public string CpfCnpjNumber { get; private set; }

        /// <summary>
        /// Nome do Sacador avalista.
        /// (opcional)
        /// </summary>
        [AliasAs("nomeSacadorAvalista")]
        public string Name { get; private set; }
    }
}
