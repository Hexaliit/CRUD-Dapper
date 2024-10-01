using Dapper;
using Dapper.SelectWithId;
using Microsoft.Data.SqlClient;
using System.Data;

public class Program()
{
    public static void Main()
    {
        string connectionString = "Data Source = .\\ALI; Initial Catalog = MyProducts; Integrated Security = True; Trust Server Certificate = True;";

        IDbConnection connection = new SqlConnection(connectionString);

        var product = new Product() { Id = 2 };

        var sql = "SELECT * FROM Products WHERE Id=@Id";

        var result = connection.QueryFirstOrDefault<Product>(sql, product);

        if (result != null)
        {
            Console.WriteLine($"{result.Id} - {result.Name} - {result.Price}");
        }
        else { Console.WriteLine("No result found"); }
    }
}
