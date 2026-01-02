SELECT 
    Encomendas.EncomendaID,
    Clientes.NomeCompleto,
    Encomendas.DataEncomenda,
    Encomendas.Estado
FROM Encomendas
JOIN Clientes ON Encomendas.ClienteID = Clientes.ClienteID
WHERE Encomendas.Estado = 'Cancelada'
  AND Encomendas.DataEncomenda >= DATEADD(MONTH, -18, GETDATE())
ORDER BY Encomendas.DataEncomenda DESC;
