using Refit;
using SicoobWrapperApi.BankCollection.Interfaces.Movement.Result;
using System.Threading.Tasks;

namespace SicoobWrapperApi.BankCollection.Interfaces
{
    /// <summary>
    /// Cobrança Bancária - Movimentação
    /// </summary>
    public interface IMovement
    {
        /// <summary>
        /// Serviço para consultar a situação da solicitação da movimentação.
        /// </summary>
        /// <param name="requestCode">Código da solicitação que deseja consultar a quantidade de arquivos que serão gerados.</param>
        [Get("/boletos/solicitacoes/movimentacao?codigoSolicitacao={codigoSolicitacao}")]
        Task<MovementRequestStatusResult> GetMovimentRequestStatus([AliasAs("codigoSolicitacao")]int requestCode);

        /// <summary>
        /// Serviço para solicitar a movimentação da carteira de cobrança registrada para beneficiário informado. 
        /// Os movimentos disponíveis para solicitaçao são:
        /// 1. Entrada 
        /// 2. Prorrogação 
        /// 3. A Vencer 
        /// 4. Vencido 
        /// 5. Liquidação 6. Baixa;
        /// </summary>
        /// <remarks>As consultas estão limitadas em um período máximo de 2 dias.</remarks>
        [Post("/boletos/solicitacoes/movimentacao")]
        Task<BeneficiaryMovementResult> GetBeneficiaryRegisteredCollectionMoviment([Body] BeneficiaryMovimentBody body);

        /// <summary>
        /// Serviço para obter um arquivo de movimentação.
        /// </summary>
        /// <param name="requestCode">Código da solicitação que deseja consultar a quantidade de arquivos que serão gerados.</param>
        /// <param name="fileId">ID do arquivo para download.</param>
        /// <returns></returns>
        [Get("/boletos/movimentacao-download?codigoSolicitacao={codigoSolicitacao}&idArquivo={idArquivo}")]
        Task<DownloadMovementFileResult> DownloadMovimentFile([AliasAs("codigoSolicitacao")]int requestCode, [AliasAs("idArquivo")]int fileId);
    }
}
