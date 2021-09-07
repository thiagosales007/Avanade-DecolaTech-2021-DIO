using AgenciaBancaria.Dominio;
using System;

namespace AgenciaBancaria.App
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Endereco endereco = new Endereco("Rua do teste, 001", "60.010-000", "Fortaleza", "CE"); //Criando Conta
                Cliente cliente = new Cliente("Thiago Sales", "100.100.101-01", "99919209999", endereco);
                ContaCorrente conta = new ContaCorrente(cliente, 100);
                
                Console.WriteLine
                    ("Conta: " + 
                    conta.Situacao + ": " + 
                    conta.NumeroConta + "-" + 
                    conta.DigitoVerificador);

                string senha = "abc987654321"; // Abertura da Conta
                conta.Abrir(senha);

                Console.WriteLine
                    ("Conta: " + 
                    conta.Situacao + ": " + 
                    conta.NumeroConta + "-" + 
                    conta.DigitoVerificador);

                conta.Sacar(10, senha); // Utilização da Conta
                Console.WriteLine(conta.VerSaldo());

                conta.Depositar(50); // Utilização da Conta
                Console.WriteLine(conta.VerSaldo());

                conta.Sacar(20, senha); // Utilização da Conta
                Console.WriteLine(conta.VerSaldo());

                conta.Depositar(10); // Utilização da Conta
                Console.WriteLine(conta.VerSaldo());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
