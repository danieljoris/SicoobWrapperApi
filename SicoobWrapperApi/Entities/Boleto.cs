using Refit;
using System;
using System.Collections.Generic;
using System.Text;

namespace SicoobWrapperApi.BankCharges.Entities
{
    public class Boleto
    {

        /// <summary>
        /// Número que identifica o contrato do beneficiário no Sisbr.
        /// (opcional)
        /// </summary>
        [AliasAs("numeroContrato")]
        public int ContractNumber { get; private set; }

        /// <summary>
        /// Número que identifica a modalidade do boleto. 
        /// Infomar 1 - SIMPLES COM REGISTRO
        /// </summary>
        [AliasAs("modalidade")]
        public int Modality { get; private set; }

        /// <summary>
        /// Número da Conta Corrente onde será realizado o crédito da liquidação do boleto.
        /// (opcional)
        /// </summary>
        [AliasAs("numeroContaCorrente")]
        public int teste2 { get; private set; }

        /// <summary>
        /// Espécie do Documento.
        /// Informar valores listados:
        /// CH - Cheque
        /// DM - Duplicata Mercantil
        /// DMI - Duplicata Mercantil Indicação
        /// DS - Duplicata de Serviço
        /// DSI - Duplicata Serviço Indicação
        /// DR - Duplicata Rural
        /// LC - Letra de Câmbio
        /// NCC - Nota de Crédito Comercial
        /// NCE - Nota de Crédito Exportação
        /// NCI - Nota de Crédito Industrial
        /// NCR - Nota de Crédito Rural
        /// NP - Nota Promissória
        /// NPR - Nota Promissória Rural
        /// TM - Triplicata Mercantil
        /// TS - Triplicata de Serviço
        /// NS - Nota de Seguro
        /// RC - Recibo
        /// FAT - Fatura
        /// ND - Nota de Débito
        /// AP - Apólice de Seguro
        /// ME - Mensalidade Escolar
        /// PC - Pagamento de Consórcio
        /// NF - Nota Fiscal
        /// DD - Documento de Dívida
        /// CC - Cartão de Crédito
        /// BDP - Boleto Proposta
        /// OU - Outros
        /// (opcional)
        /// </summary>
        [AliasAs("especieDocumento")]
        public string DocumentType { get; private set; }

        /// <summary>
        /// Data de emissão do boleto.
        /// Caso não seja informado, o sistema atribui a data de registro do boleto no Sisbr.
        /// </summary>
        [AliasAs("dataEmissao")]
        public string IssueDate { get; private set; }

        /// <summary>
        /// Número que identifica o boleto de cobrança no Sisbr. 
        /// Caso o beneficiário possua reserva de faixa de nosso número, poderá ser informado. 
        /// Caso não possua, o sistema atribui um número correspondente.
        /// (opcional)
        /// </summary>
        [AliasAs("nossoNumero")]
        public int OurNumber { get; private set; }

        /// <summary>
        /// Número identificador do boleto no sistema do beneficiário.
        /// (opcional)
        /// </summary>
        [AliasAs("seuNumero")]
        public string YourNumber { get; private set; }

        /// <summary>
        /// Campo destinado para uso da empresa do beneficiário para identificação do boleto. 
        /// (opcional)
        /// </summary>
        [AliasAs("identificacaoBoletoEmpresa")]
        public string CompanyBoletoIdentification { get; private set; }

        /// <summary>
        /// Código de identificação de emissão do boleto.Informar os valores listados abaixo.
        /// 1 Banco Emite
        /// 2 Cliente Emite
        /// </summary>
        [AliasAs("identificacaoEmissaoBoleto")]
        public int BoletoEmissionIdentification { get; private set; }

        /// <summary>
        /// Código de identificação de distribuição do boleto.Informar os valores listados abaixo:
        /// 1 Banco Distribui 
        /// 2 Cliente Distribui
        /// </summary>
        [AliasAs("identificacaoDistribuicaoBoleto")]
        public int BoletoDistributionIdentification { get; private set; }

        /// <summary>
        /// Valor nominal do boleto.
        /// </summary>
        [AliasAs("valor")]
        public decimal Value { get; private set; }

        /// <summary>
        /// Data de vencimento do boleto.
        /// </summary>
        [AliasAs("dataVencimento")]
        public string ExpirationDate { get; private set; }

        /// <summary>
        /// Data de limite para pagamento do boleto.
        /// (opcional)
        /// </summary>
        [AliasAs("dataLimitePagamento")]
        public string PaymentLimitDate { get; private set; }

        /// <summary>
        /// Valor do abatimento a ser aplicado no boleto.
        /// (opcional)
        /// </summary>
        [AliasAs("valorAbatimento")]
        public decimal ReductionValue { get; private set; }

        /// <summary>
        /// Informar o tipo de desconto atribuido ao boleto de cobrança.
        /// Informar os valores listados abaixo:
        /// 0 Sem Desconto
        /// 1 Valor Fixo Até a Data Informada
        /// </summary>
        [AliasAs("tipoDesconto")]
        public int DiscountType { get; private set; }

        /// <summary>
        /// Data do primeiro desconto.
        /// (opcional)
        /// </summary>
        [AliasAs("dataPrimeiroDesconto")]
        public string FirstDiscountDate { get; private set; }

        /// <summary>
        /// Valor do primeiro desconto. 
        /// Deve ser informado caso a data do primeiro desconto seja preenchida.
        /// (opcional)
        /// </summary>
        [AliasAs("valorPrimeiroDesconto")]
        public decimal FirstDiscountValue { get; private set; }

        /// <summary>
        /// Data do segundo desconto.
        /// (opcional)
        /// </summary>
        [AliasAs("dataSegundoDesconto")]
        public string SecondDiscountDate { get; private set; }

        /// <summary>
        /// Valor do segundo desconto. 
        /// Deve ser informado caso a data do segundo desconto seja preenchida.
        /// (opcional)
        /// </summary>
        [AliasAs("valorSegundoDesconto")]
        public decimal SecondDiscountValue { get; private set; }

        /// <summary>
        /// Data do terceiro desconto.
        /// (opcional)
        /// </summary>
        [AliasAs("dataTerceiroDesconto")]
        public decimal ThirdDiscountDate { get; private set; }

        /// <summary>
        /// Valor do terceiro desconto.
        /// Deve ser preenchido caso a data do terceiro desconto seja preenchida.
        /// (opcional)
        /// </summary>
        [AliasAs("valorTerceiroDesconto")]
        public decimal ThirdDiscountValue{ get; private set; }

        /// <summary>
        /// Tipo de multa a ser aplicado no boleto. 
        /// Informar os valores listados abaixo. 
        /// 0 Isento
        /// 2 Percentual
        /// (opcional)
        /// </summary>
        [AliasAs("tipoMulta")]
        public int PenaltyType { get; private set; }

        /// <summary>
        /// Deve ser maior que a data de vencimento do boleto e menor ou igual que data limite de pagamento.
        /// (opcional)
        /// </summary>
        [AliasAs("dataMulta")]
        public string PenaltyDate { get; private set; }

        /// <summary>
        /// Valor da multa. 
        /// Deve ser preenchido caso o campo dataMulta seja preenchido.
        /// (opcional)
        /// </summary>
        [AliasAs("valorMulta")]
        public decimal PenaltyValues { get; private set; }

        /// <summary>
        /// Tipo de juros de mora. 
        /// Informar os valores listados abaixo.
        /// 2 Taxa Mensal 
        /// 3 Isento
        /// (opcional)
        /// </summary>
        [AliasAs("tipoJurosMora")]
        public int tipoJurosMora { get; private set; }

        /// <summary>
        /// Deve ser maior que a data de vencimento do boleto e menor ou igual que data limite de pagamento.
        /// (opcional)
        /// </summary>
        [AliasAs("dataJurosMora")]
        public string dataJurosMora { get; private set; }

        /// <summary>
        /// Valor do juros de mora. 
        /// Deve ser preenchido caso o campo dataJurosMora seja preenchido.
        /// (opcional)
        /// </summary>
        [AliasAs("valorJurosMora")]
        public decimal valorJurosMora { get; private set; }

        /// <summary>
        /// Número da parcela do boleto.
        /// Valor máximo permitido '99'.
        /// </summary>
        [AliasAs("numeroParcela")]
        public int ParcelNumber { get; private set; }

        /// <summary>
        /// Identificador do aceite do boleto.
        /// (opcional)
        /// </summary>
        [AliasAs("aceite")]
        public bool aceite { get; private set; }

        /// <summary>
        /// Código de negativação do boleto. 
        /// Informar os valores abaixo. 
        /// 2 Negativar Dias Úteis
        /// 3 Não Negativar
        /// </summary>
        [AliasAs("codigoNegativacao")]
        public int NegativationCode { get; private set; }

        /// <summary>
        /// Número de dias para negativação do boleto. 
        /// Deve ser preenchido caso o campo codigoNegativacao seja igual a '2'
        /// </summary>
        [AliasAs("numeroDiasNegativacao")]
        public int DaysUntilNegativation { get; private set; }

        /// <summary>
        /// Código de protesto do boleto. 
        /// Informar os valores abaixo.
        /// 1 Protestar Dias Corridos
        /// 3 Não Protestar
        /// </summary>
        [AliasAs("codigoProtesto")]
        public int ProtestCode { get; private set; }

        /// <summary>
        /// Número de dias para protesto do boleto. 
        /// Deve ser preenchido caso o campo codigoProtesto seja '1'.
        /// </summary>
        [AliasAs("numeroDiasProtesto")]
        public int DaysUntilProtest { get; private set; }

        /// <summary>
        /// Pagador do boleto.
        /// </summary>
        [AliasAs("pagador")]
        public Payer Payer { get; private set; }

        /// <summary>
        /// Sacador Avalista do Boleto
        /// (opcional)
        /// </summary>
        [AliasAs("sacadorAvalista")]
        public Guarantor SacadorAvalista { get; private set; }

        /// <summary>
        /// Mensagem/Mensagens de instrução para o boleto.
        /// </summary>
        [AliasAs("mensagensInstrucao")]
        public InstructionMessage InstructionMessage { get; private set; }

        /// <summary>
        /// Identificador para o sistema devolver ou não o PDF do Boleto. 
        /// O PDF será retornado na Base64.
        /// </summary>
        [AliasAs("gerarPdf")]
        public bool GeneratePdf { get; private set; }

    }
}
