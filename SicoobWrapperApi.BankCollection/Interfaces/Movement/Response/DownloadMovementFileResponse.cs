using Refit;

namespace SicoobWrapperApi.BankCollection.Interfaces.Movement.Response
{
    public class DownloadMovementFileResponse
    {
        public DownloadMovementFileResponse()
        {
        }

        public DownloadMovementFileResponse(string file, string fileName)
        {
            File = file;
            FileName = fileName;
        }

        /// <summary>
        /// O arquivo será retornado na extensão ZIP e na Base64. UTF8.
        /// (opcional)
        /// </summary>
        [AliasAs("arquivo")]
        public string File { get; private set; }

        /// <summary>
        /// Nome do Arquivo com extensão.
        /// (opcional)
        /// </summary>
        [AliasAs("nomeArquivo")]
        public string FileName { get; private set; }
    }
}
