using Dapper;
using Dapper.Insert;
using Microsoft.Data.SqlClient;
using System.Net.Http.Headers;

public class Program()
{
    public static void Main()
    {
        var connetionString = "Data Source = .\\ALI; Initial Catalog = MyProducts; Integrated Security = True; Trust Server Certificate = True;";

        var db = new SqlConnection(connetionString);

        var product = new Product()
        {
            Id = 2,
            Name = "Phone",
            Price = 29000
        };

        string sql = "INSERT INTO Products VALUES (@Id, @Name, @Price)";

        db.Execute(sql, product);

        Console.WriteLine("1 row affected");
    }
}
