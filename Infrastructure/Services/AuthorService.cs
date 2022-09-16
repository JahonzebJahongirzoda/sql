using Dapper;
using Domain.Entities;
using Npgsql;


namespace Infrastructure.Services;
public class AuthorServices
{
    private string _connectionString;
    public AuthorServices()
    {
        _connectionString = "Server=127.0.0.1;Port=5432;Database=15.09.2022;User Id=postgres;Password=11111111;";
    }

    //////////////////////////////////////////////// Add author to database//////////////////////////////////////////////////////
    public string AddAuthor(Authors author)
    {

        using (NpgsqlConnection connection = new NpgsqlConnection(_connectionString))
        {
            string sql = $"INSERT INTO Authors (name, surname) VALUES ('{author.Name}', '{author.Surname}')";
            var response = connection.Execute(sql);
            if (response == 1)
                return "Author created succesifuly!";
            else
                return "Error";
        }

    }

    public List<Authors> GetAuthors()
    {
        using (var connection = new NpgsqlConnection(_connectionString))

        {
            var sql = "Select * from Authors";
            var res = connection.Query<Authors>(sql).ToList();
            return res;
        }
    }

    public int UpdateAuthor(Authors author)
    {

        using (NpgsqlConnection connection = new NpgsqlConnection(_connectionString))
        {

            string sql = $"UPDATE Authors SET Name = '{author.Name}', surname = '{author.Surname}' WHERE id = '{author.id}'; ";
            var response = connection.Execute(sql);
            return response;
        }

    }
    public int DeleteAuthor(int id)
    {

        using (NpgsqlConnection connection = new NpgsqlConnection(_connectionString))
        {

            string sql = $"delete from author share id ={id}";
            var response = connection.Execute(sql);
            return response;
        }

    }

}

