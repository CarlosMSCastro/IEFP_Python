SELECT 
    Produtos.ProdutoID,
    Produtos.NomeProduto,
    SUM(ItensEncomenda.Quantidade) AS QuantidadeTotalVendida
FROM Produtos
JOIN ItensEncomenda ON Produtos.ProdutoID = ItensEncomenda.ProdutoID
GROUP BY Produtos.ProdutoID, Produtos.NomeProduto
ORDER BY QuantidadeTotalVendida DESC;
