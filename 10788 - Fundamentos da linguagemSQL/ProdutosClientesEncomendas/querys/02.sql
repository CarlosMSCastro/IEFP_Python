SELECT 
    ProdutoID,
    NomeProduto,
    Preco,
    Stock,
    Ativo
FROM Produtos
WHERE Ativo = 1
  AND Stock < 10
ORDER BY Stock ASC;
