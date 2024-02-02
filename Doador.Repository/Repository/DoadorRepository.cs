using Doador.Domain.Commands;

us﻿using Dapper;



namespace Doador.Repository.Repository
{
    public class DoadorRepository : DoadorRepository
    {
        private string conexao = @"Server=(localdb)\mssqllocaldb;Database=Doador;Trusted_Connection=True;MultipleActiveResultSets=True";



        public async Task<string> PostAsync(DoadorCommand command)
        {
            string queryInsert = @"INSERT INTO Doador(Nome, Cidade, Estado, CEP, Email, Telefone)
                                  VALUES(@Nome, @Cidade, @Estado, @CEP, @Email, @Telefone)";
            using (SqlConnection conn = new SqlConnection(conexao))
            {
                conn.Execute(queryInsert, new
                {
                    Nome = command.Nome,
                    Cidade = command.Cidade,
                    Estado = command.Estado,
                    CEP = command.CEP,
                    Email = command.Email,
                    Telefone = command.Telefone


                });
            }
            return "Doador cadastrado com sucesso";
        }
        public Task<IEnumerable<DoadorCommand>> DoadoresAsync => throw new NotImplementedException();
    }
}