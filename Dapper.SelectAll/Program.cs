using Dapper;
using Dapper.SelectAll;
using Microsoft.Data.SqlClient;
using System.Data;

public class Program()
{
    public static void Main()
    {
        string connectionString = "Data Source = .\\ALI; Initial Catalog = MyProducts; Integrated Security = True; Trust Server Certificate = True;";
        IDbConnection db = new SqlConnection(connectionString);

        var sql = "SELECT * FROM Products";
        var result =  db.Query<Product>(sql);

        foreach(var product in result)
        {
            Console.WriteLine($"{product.Id} - {product.Name} - {product.Price}");
        }

    }
}
