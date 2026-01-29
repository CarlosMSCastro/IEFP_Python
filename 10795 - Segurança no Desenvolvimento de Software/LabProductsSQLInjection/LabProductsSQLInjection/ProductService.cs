using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace LabProductsSQLInjection
{
    public class ProductService
    {
        private readonly AppDbContext _context;

        public ProductService()
        {
            _context = new AppDbContext();
        }

        // Método INSEGURO
        public List<Produto> SearchInseguro(string nomeProduto)
        {
            var sql = $"SELECT * FROM Produtos WHERE NomeProduto LIKE '%{nomeProduto}%'";

            return _context.Produtos
                .FromSqlRaw(sql)
                .ToList();
        }

        // Método SEGURO
        public List<Produto> SearchSeguro(string nomeProduto)
        {
            var sql = "SELECT * FROM Produtos WHERE NomeProduto LIKE @search";

            return _context.Produtos
                .FromSqlRaw(sql, new SqlParameter("@search", "%" + nomeProduto + "%"))
                .ToList();
        }

        public List<Produto> GetAll()
        {
            return _context.Produtos.ToList();
        }
    }
}