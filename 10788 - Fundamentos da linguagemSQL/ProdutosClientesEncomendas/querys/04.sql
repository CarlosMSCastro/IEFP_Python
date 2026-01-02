SELECT 
    Encomendas.EncomendaID,
    Clientes.NomeCompleto,
    SUM(ItensEncomenda.Quantidade * ItensEncomenda.PrecoUnitario) AS TotalFaturado
FROM Encomendas
JOIN Clientes ON Encomendas.ClienteID = Clientes.ClienteID
JOIN ItensEncomenda ON Encomendas.EncomendaID = ItensEncomenda.EncomendaID
GROUP BY Encomendas.EncomendaID, Clientes.NomeCompleto
ORDER BY Encomendas.EncomendaID;
