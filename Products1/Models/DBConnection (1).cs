using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.Data.Odbc;

namespace Products1.Models
{
    public class DBConnection
    {
       

        private OleDbConnection aConnection = new OleDbConnection();


        public ProductList GetProducts()
        {
            // create a List
            ProductList aListOfProducts = new ProductList();
            


            // set the connection string
            aConnection.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;
            Data Source=N:\Northwind1023.mdb;";

            // open the connection
            aConnection.Open();

            // create a command object
            OleDbCommand aCommand = aConnection.CreateCommand();

            // Set the SQL statement
            string aSQL = "SELECT ProductId, ProductName, UnitPrice FROM Products";

            aCommand.CommandText = aSQL;


            // run the SQL statement
            OleDbDataReader aReader = aCommand.ExecuteReader();

            while (aReader.Read())
            {

                int aProductId = (int)aReader["ProductId"];
                string aProductName = (string)aReader["ProductName"];
                decimal aUnitPrice = (decimal)aReader["UnitPrice"];

                Product aProduct = new Product();
                aProduct.ProductId = aProductId;
                aProduct.ProductName = aProductName;
                aProduct.UnitPrice = aUnitPrice;

                aListOfProducts.Add(aProduct);

             }
                
            return aListOfProducts;
            
        }

    }
}
