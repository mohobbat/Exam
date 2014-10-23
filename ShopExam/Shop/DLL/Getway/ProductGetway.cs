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
            string con = ConfigurationManager.ConnectionStrings["Shop"].ConnectionString;
            connection=new SqlConnection(con);
            connection.ConnectionString = con;

        }

        public string Save(Product aProduct)
        {
            connection.Open();
            
            string query = "INSERT INTO t_Product(Code,Name,Quantity) VALUES(@Code,@Name,@Quantity)";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Code", aProduct.Code);
            command.Parameters.AddWithValue("@Name", aProduct.Name);
            command.Parameters.AddWithValue("@Quantity", aProduct.Quantity);

            int affectedRows = command.ExecuteNonQuery();
            connection.Close();
            if (affectedRows > 0)
                return "insert success";
            return "something wrong";
        }

        public bool HasThisCodeValid(string code)
        {
            connection.Open();
            string query = string.Format("SELECT * FROM t_Product WHERE Code='{0}'", code);
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader aReader = command.ExecuteReader();
            bool Hasrow = aReader.HasRows;
            connection.Close();
            return Hasrow;
        }

        public bool HasThisNameValid(string name)
        {
            connection.Open();
            string query = string.Format("SELECT * FROM t_Product WHERE Name='{0}'", name);
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader aReader = command.ExecuteReader();
            bool Hasrow = aReader.HasRows;
            connection.Close();
            return Hasrow;
        }

        public List<Product> GetTottalProductInfo()
        {
            connection.Open();
            string query = "SELECT *FROM t_Product";
           SqlCommand command=new SqlCommand(query,connection);
            SqlDataReader aDataReader = command.ExecuteReader();

            List<Product>products=new List<Product>();

            if (aDataReader.HasRows)
            {
                while (aDataReader.Read())
                {
                    Product aProduct=new Product();
                    aProduct.Code = aDataReader[1].ToString();
                    aProduct.Name = aDataReader[2].ToString();
                    aProduct.Quantity =Convert.ToInt32((aDataReader[3].ToString()));
                    products.Add(aProduct);

                   
                }
                connection.Close();
            }
            return products;
        }

        public int GetTotalQuantiy()
        {

            int totalQuentity =0;
            connection.Open();
            string query = string.Format("SELECT SUM (Quantity) FROM t_Product");
            SqlCommand cmd = new SqlCommand(query, connection);
            SqlDataReader aDataReader = cmd.ExecuteReader();

            if (aDataReader.HasRows)
            {
                while (aDataReader.Read())
                {
                    totalQuentity = (int) aDataReader.GetValue(0);
                }

            }
            connection.Close();
            return totalQuentity;


            
        }
    }
}
