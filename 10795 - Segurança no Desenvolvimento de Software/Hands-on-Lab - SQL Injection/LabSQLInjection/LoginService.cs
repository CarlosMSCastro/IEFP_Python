using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace LabSQLInjection
{
    public class LoginService
    {
        private readonly AppDbContext _context;

        public LoginService()
        {
            _context = new AppDbContext();
        }

        // 1 - Login Normal (Inseguro, vulnerável a SQL Injection)
        public User? LoginInseguro(string username, string password)
        {
            var sql = $"SELECT * FROM Users WHERE Username = '{username}' AND Password = '{password}'";

            return _context.Users
                .FromSqlRaw(sql)
                .FirstOrDefault();
        }

        // 2 - Login SEGURO com SqlParameter
        public User? LoginSeguroComParametros(string username, string password)
        {
            var sql = "SELECT * FROM Users WHERE Username = @username AND Password = @password";

            return _context.Users
                .FromSqlRaw(sql,
                    new SqlParameter("@username", username),
                    new SqlParameter("@password", password))
                .FirstOrDefault();
        }

        // 3 - Login SEGURO com LINQ
        public User? LoginSeguroComLINQ(string username, string password)
        {
            return _context.Users
                .FirstOrDefault(u =>
                    u.Username == username &&
                    u.Password == password);
        }
    }
}