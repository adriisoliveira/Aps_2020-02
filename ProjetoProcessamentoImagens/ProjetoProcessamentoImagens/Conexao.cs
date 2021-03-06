﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoProcessamentoImagens
{
    class Conexao
    {
        //Cria conexão com o banco
        SqlConnection con;

        //Metodo construtor
        public Conexao()
        {
            con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-9AR7799;Initial Catalog=Ministerio_MeioAmbiente;Integrated Security=True";
        }

        //Método de conexão
        public SqlConnection Conectar()
        {
            //Verificar se há conexão

            //Se a conexão estiver fechada
            if (con.State == System.Data.ConnectionState.Closed)
            {
                //conecta
                con.Open();
            }
            //caso contrario não é necessário conectar

            //retorna a conexão
            return con;
        }

        //Método para desconectar

        public void desconectar()
        {
            //Verificar se ja não está desconectado

            //Se a conexão ja estar fechada
            if (con.State == System.Data.ConnectionState.Open)
            {
                //desconecta
                con.Close();
            }
            //caso contrario não é necessário desconectar
        }
    }
}
