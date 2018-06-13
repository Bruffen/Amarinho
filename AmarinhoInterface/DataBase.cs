using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace AmarinhoInterface
{
    public class DataBase
    {
        public SqlConnection DataBaseConnection;

        public DataBase()
        {
            DataBaseConnection = new SqlConnection("Data Source = localhost; Initial Catalog = Amarinho; Integrated Security = True");
            DataBaseConnection.Open();
        }

        public void AdicionarCasta(int id, string nome, string local, string tipo, string desc)
        {
            String query = "Insert into Casta " +
                "values ({id}, '{nome}', '{local}', '{tipo}', '{desc}')";
            SqlCommand addCasta = new SqlCommand(query, DataBaseConnection);
        }

        public void AdicionarTipoProduto(int id, string desc, float teor, float capacidade)
        {
            String query = "Insert into Tipo_Produto " +
                "values ({id}, '{desc}', {teor}, {capacidade})";
            SqlCommand addCasta = new SqlCommand(query, DataBaseConnection);
        }

        public DataTable MostarTudo(string nomeTabela)
        {
            String query = "select * from {nomeTabela}";
            SqlCommand command = new SqlCommand(query, DataBaseConnection);
            SqlDataReader data = command.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(data);
            return table;
        }
    }
}
