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
            String query =
                "Set Identity_Insert Casta ON " +
                "Insert Casta(Casta_ID, Nome_Casta, Origem_Local, Casta_Tipo, Casta_Desc) " +
                "values (" + id + ", '" + nome + "', '" + local + "', '" + tipo + "', '" + desc + "')";
            SqlCommand addCasta = new SqlCommand(query, DataBaseConnection);
            addCasta.ExecuteNonQuery();
        }

        public void AdicionarTipoProduto(int id, string desc, int teor, float capacidade)
        {
            String query =
                "Set Identity_Insert Tipo_Produto ON " +
                "Insert Tipo_Produto(Tipo_Produto_ID, Desc_Produto, Teor_Alcoolico, Capacidade_Produto) " +
                "values (" + id + ", '" + desc + "', " + teor + ", " + capacidade + ")";
            SqlCommand addTipoProduto = new SqlCommand(query, DataBaseConnection);
            addTipoProduto.ExecuteNonQuery();
        }

        public void AdicionarProduto(int castaID, int tipoProdutoID)
        {
            int ano = DateTime.Now.Year;
            String query =
                "Insert Produto(Ano_Epoca, Casta_ID, Tipo_Produto_Id) " +
                "values (" + ano + ", " + castaID + ", " + tipoProdutoID + ")";
            SqlCommand addProduto = new SqlCommand(query, DataBaseConnection);
            addProduto.ExecuteNonQuery();
        }

        public void RemoverCasta(int id)
        {
            String query = "Delete from Casta where Casta_ID = " + id;
            SqlCommand removeCasta = new SqlCommand(query, DataBaseConnection);
            removeCasta.ExecuteNonQuery();
        }

        public void RemoverTipoProduto(int id)
        {
            String query = "Delete from Tipo_Produto where Tipo_Produto_ID = " + id;
            SqlCommand removeCasta = new SqlCommand(query, DataBaseConnection);
            removeCasta.ExecuteNonQuery();
        }

        public DataTable MostarTudo(string nomeTabela)
        {
            String query = "select * from " + nomeTabela;
            SqlCommand command = new SqlCommand(query, DataBaseConnection);
            SqlDataReader data = command.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(data);
            return table;
        }
    }
}
