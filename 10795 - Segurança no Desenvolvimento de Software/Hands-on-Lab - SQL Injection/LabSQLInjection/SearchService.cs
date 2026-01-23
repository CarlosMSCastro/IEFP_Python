using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace LabSQLInjection
{
    public class SearchService
    {
        private readonly AppDbContext _context;

        public SearchService()
        {
            _context = new AppDbContext();
        }

        // 4 - Search com LIKE Inseguro
        public List<User> SearchInseguro(string input)
        {
            var sql = $"SELECT * FROM Users WHERE Username LIKE '%{input}%'";

            return _context.Users
                .FromSqlRaw(sql)
                .ToList();
        }

        // 4 - Search com LIKE Seguro (FromSqlRaw + Parâmetros)
        public List<User> SearchSeguroComParametros(string input)
        {
            var sql = "SELECT * FROM Users WHERE Username LIKE @search";

            return _context.Users
                .FromSqlRaw(sql,
                    new SqlParameter("@search", "%" + input + "%"))
                .ToList();
        }

        // 4 - Search com LINQ (recomendado)
        public List<User> SearchSeguroComLINQ(string input)
        {
            return _context.Users
                .Where(u => u.Username.Contains(input))
                .ToList();
        }

        // 5 - GetUserById Inseguro (sem validação)
        public User? GetByIdInseguro(string id)
        {
            int userId = int.Parse(id);  //Pode crashar
            return _context.Users.Find(userId);
        }

        // 5 - GetUserById Seguro (com validação)
        public User? GetByIdSeguro(string id)
        {
            if (!int.TryParse(id, out int userId))
                throw new ArgumentException("ID inválido");

            return _context.Users.Find(userId);
        }
        // DESAFIO FINAL - GetByRole
        // ==========================================

        // Versão VULNERÁVEL
        public List<User> GetByRoleInseguro(string role)
        {
            var sql = $"SELECT * FROM Users WHERE Role = '{role}'";
            return _context.Users.FromSqlRaw(sql).ToList();
        }

        // Solução 1: Com Parâmetros
        public List<User> GetByRoleSeguroComParametros(string role)
        {
            var sql = "SELECT * FROM Users WHERE Role = @role";
            return _context.Users
                .FromSqlRaw(sql, new SqlParameter("@role", role))
                .ToList();
        }

        // Solução 2: Com LINQ (recomendado)
        public List<User> GetByRoleSeguroComLINQ(string role)
        {
            return _context.Users
                .Where(u => u.Role == role)
                .ToList();
        }
    }
}