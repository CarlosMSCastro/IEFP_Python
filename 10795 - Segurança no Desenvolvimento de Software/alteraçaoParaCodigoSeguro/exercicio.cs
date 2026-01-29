string sql = "SELECT * FROM Products WHERE Name LIKE @search";
return _context.Products
    .FromSqlRaw(sql, new SqlParameter("@search", "%" + input + "%"))
    .ToList();