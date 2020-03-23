using Refit;
using System;
using System.Collections.Generic;
using System.Text;

namespace SicoobWrapperApi.BankCollection.Interfaces.Movement.Response
{
    public class MovementRequestStatusResponse
    {
        /// <summary>
        /// Quantidade Total de Registos encontrados para a movimentação solicitada.
        /// (opcional)
        /// </summary>
        [AliasAs("quantidadeTotalRegistros")]
        public int TotalRecords { get; private set; }

        /// <summary>
        /// Quantidade Máxima de registos por arquivo.
        /// (opcional)
        /// </summary>
        [AliasAs("quantidadeRegistrosArquivo")]
        public int MaxRecordsPerFile { get; private set; }

        /// <summary>
        /// Quantidade de arquivo(s) da movimentação retornada na consulta.
        /// (opcional)
        /// </summary>
        [AliasAs("quantidadeArquivo")]
        public int MovimentsPerFile { get; private set; }

        /// <summary>
        /// Id dos arquivos.
        /// (opcional)
        /// </summary>
        [AliasAs("idArquivos")]
        public IList<int> FilesId { get; private set; } 

    }
}
