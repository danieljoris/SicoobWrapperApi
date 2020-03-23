using Refit;
using SicoobWrapperApi.BankCharges.Entities;
using SicoobWrapperApi.BankCharges.Interfaces;
using System;

namespace SicoobWrapperApi.ConsoleAppTests
{
    class Program
    {
        async static void Main(string[] args)
        {
            var sicoobApi = RestService.For<IBoleto>("https://sandbox.sicoob.com.br/cobranca-bancaria/");
            var boleto = new Boleto();

            var teste = await sicoobApi.AddBoleto(boleto);

        }
    }
}
