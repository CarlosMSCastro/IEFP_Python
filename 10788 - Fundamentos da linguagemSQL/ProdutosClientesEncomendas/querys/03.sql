SELECT 
    Encomendas.EncomendaID,
    Clientes.NomeCompleto,
    Enderecos.Cidade,
    Encomendas.Estado
FROM Encomendas
JOIN Clientes ON Encomendas.ClienteID = Clientes.ClienteID
JOIN Enderecos ON Encomendas.EnderecoEnvioID = Enderecos.EnderecoID;
