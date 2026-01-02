SELECT 
    Clientes.ClienteID,
    Clientes.NomeCompleto,
    COUNT(Encomendas.EncomendaID) AS TotalEncomendas
FROM Clientes
LEFT JOIN Encomendas ON Clientes.ClienteID = Encomendas.ClienteID
GROUP BY Clientes.ClienteID, Clientes.NomeCompleto
ORDER BY TotalEncomendas DESC;
