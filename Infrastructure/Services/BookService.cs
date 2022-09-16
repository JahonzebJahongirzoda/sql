using Dapper;
using Domain.Entities;
using Npgsql;


namespace Infrastructure.Services;
public class BookServices
{
    private string _connectionString;
    public BookServices()
    {
        _connectionString = "Server=127.0.0.1;Port=5432;Database=15.09.2022;User Id=postgres;Password=11111111;";
    }

    //////////////////////////////////////////////// Add book to database//////////////////////////////////////////////////////
    public string AddBook(Books book)
    {

        using (NpgsqlConnection connection = new NpgsqlConnection(_connectionString))
        {
            string sql = $"INSERT INTO Books (Title, Authorid) VALUES ('{book.Title}', '{book.Authorid}')";
            var response = connection.Execute(sql);
            if (response == 1)
                return "Book created succesifuly!";
            else
                return "Error";
        }

    }

    public List<Books> GetBooks()
    {
        using (var connection = new NpgsqlConnection(_connectionString))

        {
            var sql = "Select * from Books";
            var res = connection.Query<Books>(sql).ToList();
            return res;
        }
    }

    public int UpdateBook(Books book)
    {

        using (NpgsqlConnection connection = new NpgsqlConnection(_connectionString))
        {

            string sql = $"UPDATE Books SET Title = '{book.Title}', surname = '{book.Authorid}' WHERE ID = '{book.id}'; ";
            var response = connection.Execute(sql);
            return response;
        }

    }
    public int DeleteBook(int id)
    {

        using (NpgsqlConnection connection = new NpgsqlConnection(_connectionString))
        {

            string sql = $"delete from book share id ={id}";
            var response = connection.Execute(sql);
            return response;
        }

    }

}

