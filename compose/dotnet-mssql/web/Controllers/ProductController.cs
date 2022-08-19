namespace web.Controllers;

using Dapper;
using web.Model;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;


[Route("[controller]")]
public class ProductController : ControllerBase
{
    private readonly string connectionString;

    public ProductController(IConfiguration configuration)
    {
        this.connectionString = configuration.GetConnectionString("DefaultConnection");
    }

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        using var connection = new SqlConnection(connectionString);
        await connection.OpenAsync();
        var products = connection.Query<Product>(@"SELECT TOP 10 * FROM Products");

        return Ok(products);
    }
}
