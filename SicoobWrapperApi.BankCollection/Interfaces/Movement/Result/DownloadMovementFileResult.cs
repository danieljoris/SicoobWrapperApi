using Refit;

namespace SicoobWrapperApi.BankCollection.Interfaces.Movement.Result
{
    public class DownloadMovementFileResult
    {
        public DownloadMovementFileResult()
        {
        }

        public DownloadMovementFileResult(string file, string fileName)
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
