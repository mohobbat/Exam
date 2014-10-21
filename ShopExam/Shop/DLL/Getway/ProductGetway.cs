using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shop.DLL.DAO;

namespace Shop.DLL.Getway
{
    class ProductGetway
    {
        private SqlConnection connection;

        public ProductGetway()
        {
            string con = ConfigurationManager.ConnectionStrings["SHOP"].ConnectionString;
            connection=new SqlConnection(con);
            connection.ConnectionString = con;

        }

        public string Save(Product aProduct)
        {
            connection.Open();
            string query = string.Format("INSERT INTO Product VALUES('{0}','{1}','{2}')", aProduct.Code,aProduct.Name,aProduct.Quantity);
            SqlCommand command = new SqlCommand(query, connection);

            int affectedRows = command.ExecuteNonQuery();
            connection.Close();
            if (affectedRows > 0)
                return "insert success";
            return "something wrong";
            
        }

        public bool HasThisCodeValid(string code)
        {
            connection.Open();
            string query = string.Format("SELECT * FROM Product WHERE Code='{0}'",code);
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader aReader = command.ExecuteReader();
            bool Hasrow = aReader.HasRows;
            connection.Close();
            return Hasrow;
        }

        public bool HasThisNameValid(string name)
        {
            connection.Open();
            string query = string.Format("SELECT * FROM Product WHERE Name='{0}'", name);
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader aReader = command.ExecuteReader();
            bool Hasrow = aReader.HasRows;
            connection.Close();
            return Hasrow;
        }
    }
}
