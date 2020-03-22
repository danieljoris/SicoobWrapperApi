using Refit;
using SicoobWrapperApi.BankCharges.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SicoobWrapperApi.BankCharges.Interfaces
{
    public interface IBoleto
    {
        /// <summary>
        /// Serviço para consulta de um boleto bancário.
        /// </summary>
        /// <param name="contractNumber">Número que identifica o contrato do beneficiário no Sisbr.</param>
        /// <param name="modality">Identifica a modalidade do boleto.</param>
        /// <param name="identifierNumber">Número identificador do boleto no Sisbr.</param>
        /// <param name="digitableLine">Número da linha digitável do boleto com 47 posições.</param>
        /// <param name="barcode">Número de código de barras do boleto com 44 posições.</param>
        /// <returns>
        /// </returns>
        [Get("/boletos/{numeroContrato}")]
        Task<Boleto> GetBoleto( 
            [AliasAs("numeroContrato")]int contractNumber,
            [AliasAs("modalidade")]int modality,
            [AliasAs("nossoNumero")] int identifierNumber,
            [AliasAs("linhaDigitavel")] string digitableLine,
            [AliasAs("codigoBarras")] string barcode);

        /// <summary>
        /// Serviço para a inclusão de boletos informados.
        /// </summary>
        /// <returns></returns>
        [Post("/boletos")]
        Task<Boleto> AddBoleto([Body(BodySerializationMethod.UrlEncoded)] Boleto boleto);

        /// <summary>
        /// Listar Boletos por Pagador
        /// </summary>
        /// <param name="cpfCnpjNumber">(obrigatório) CPF ou CNPJ do pagador. Tamanho máximo 14.</param>
        /// <param name="contractNumber">(obrigatório) Número que identifica o contrato do beneficiário no Sisbr.</param>
        /// <param name="situationCode">Código da Situação do Boleto. Opções: 1 - Em Aberto; 2 - Baixado; 3 - Liquidado;</param>
        /// <param name="initialDate">Data de Vencimento Inicial.</param>
        /// <param name="endDate">Data de Vencimento Final.</param>
        /// <returns></returns>
        [Get("/boletos/pagadores/{numeroCpfCnpj}")]
        Task<List<Boleto>> ListBoletoByPayer(
            [AliasAs("numeroCpfCnpj")] string cpfCnpjNumber,
            [AliasAs("numeroContrato")] int contractNumber,
            [AliasAs("codigoSituacao")] int situationCode,
            [AliasAs("dataInicio")] string initialDate,
            [AliasAs("dataFim")] string endDate);

        /// <summary>
        /// Emitir segunda via de um boleto.
        /// </summary>
        /// <returns></returns>
        [Get("/boletos/segunda-via")]
        Task<List<Boleto>> GenerateDuplicate(
            [AliasAs("numeroContrato")] int contractNumber,
            [AliasAs("modalidade")] int modality,
            [AliasAs("nossoNumero")] int ourNumber,
            [AliasAs("linhaDigitavel")] string digitableLine,
            [AliasAs("codigoBarras")] string barcode,
            [AliasAs("gerarPdf")] bool generatePdf);

        /// <summary>
        /// Prorrogar a data de vencimento e/ou data limite para pagamento de boletos.
        /// </summary>
        /// <param name="boleto">Boleto a ser prorrogado.</param>
        [Patch("/boletos/prorrogacao")]
        void ExtendDueDate([Body] Boleto boleto);

        /// <summary>
        /// Alterar informações de valor de desconto e/ou data de desconto de boletos.
        /// </summary>
        void ChangeDiscountOrDiscountDate();

        /// <summary>
        /// Alterar o valor de abatimento de boletos.
        /// </summary>


        /// <summary>
        /// Alterar valor de juros de mora e/ou multa de boletos.
        /// </summary>
        void ChangeInterestRateOrPenaltyValue();

        /// <summary>
        /// Alterar o valor nominal de boletos de cartão de crédito.
        /// </summary>


        /// <summary>
        /// Alterar seu número e/ou número de controle da empresa dos boletos.
        /// </summary>
        void ChangeNumberOrControlNumber();

        /// <summary>
        /// Alterar espécie de documento dos boletos.
        /// </summary>
        void ChangeDocumentType();

        /// <summary>
        /// Comandar a baixa de boletos.
        /// </summary>
        void Disable();
    }
}
