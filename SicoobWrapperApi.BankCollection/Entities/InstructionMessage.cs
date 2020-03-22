using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SicoobWrapperApi.BankCharges.Entities
{
    public class InstructionMessage
    {
        private IList<string> _messages;

        public InstructionMessage()
        {
            _messages = new List<string>();
        }

        public InstructionMessage(List<string> messages)
        {
            _messages = new List<string>();
            AddMessages(messages);
        }

        public InstructionMessage(int type, List<string> messages)
        {
            Type = type;
            _messages = new List<string>();
            AddMessages(messages);
        }

        /// <summary>
        /// Código adotado pela FEBRABAN para identificação do tipo de impressão da mensagem do boleto de cobrança.
        /// 3 - Corpo de Instruções da Ficha de Compensação do Bloqueto.
        /// (opcional)
        /// </summary>
        [AliasAs("tipoInstrucao")]
        public int Type { get; private set; }

        /// <summary>
        /// Lista de mensagens de instrução.
        /// </summary>
        [AliasAs("mensagens")]
        public IReadOnlyList<string> Messages => _messages.ToList(); 

        /// <summary>
        /// Adicionar mensagem.
        /// </summary>
        /// <param name="message"></param>
        public void AddMessage(string message)
        {
            _messages.Add(message);
        }

        /// <summary>
        /// Adicionar lista de mensagens.
        /// </summary>
        /// <param name="messages"></param>
        public void AddMessages(List<string> messages)
        {
            messages.ForEach((message) => _messages.Add(message.Clone().ToString()));
        }
    }
}
