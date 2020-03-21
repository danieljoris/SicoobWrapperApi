using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SicoobWrapperApi.BankCharges.Entities
{
    public class Payer
    {
        private IList<string> _emails;

        public Payer()
        {
            _emails = new List<string>();
        }

        /// <summary>
        /// CPF ou CNPJ do pagador do boleto de cobrança.
        /// </summary>
        [AliasAs("numeroCpfCnpj")]
        public string CpfCnpjNumber { get; private set; }

        /// <summary>
        /// Nome completo do pagador do boleto de cobrança.
        /// </summary>
        [AliasAs("nome")]
        public string Name { get; private set; }

        /// <summary>
        /// Endereço do pagador do boleto de cobrança.
        /// </summary>
        [AliasAs("endereco")]
        public string Address { get; private set; }

        /// <summary>
        /// Bairro do pagador do boleto de cobrança.
        /// </summary>
        [AliasAs("bairro")]
        public string Neighborhood { get; private set; }

        /// <summary>
        /// Cidade do pagador do boleto de cobrança.
        /// </summary>
        [AliasAs("cidade")]
        public string City { get; private set; }

        /// <summary>
        /// CEP do pagador.
        /// </summary>
        [AliasAs("cep")]
        public string Zipcode { get; private set; }

        /// <summary>
        /// UF do pagador.
        /// </summary>
        [AliasAs("uf")]
        public string State { get; private set; }

        /// <summary>
        /// Email do pagador.
        /// (optional)
        /// </summary>
        [AliasAs("email")]
        public IReadOnlyList<string> Emails => _emails.ToList();

        /// <summary>
        /// Adicionar email do pagador.
        /// </summary>
        /// <param name="email">Email do pagador.</param>
        public void AddEmail(string email)
        {
            _emails.Add(email);
        }

        /// <summary>
        /// Adicionar emails do pagador.
        /// </summary>
        /// <param name="emails">Lista de emails do pagador.</param>
        public void AddEmail(List<string> emails)
        {
            emails.ForEach((email) => _emails.Add(email.Clone().ToString()));
        }
    }
}
