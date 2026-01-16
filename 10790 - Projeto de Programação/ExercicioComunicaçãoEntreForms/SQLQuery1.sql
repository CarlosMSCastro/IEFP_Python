USE clientes;
GO

CREATE TABLE clientes (
    codigo INT PRIMARY KEY,
    nome VARCHAR(100) NOT NULL,
    morada VARCHAR(200),
    telefone VARCHAR(20),
    contribuinte VARCHAR(20) UNIQUE,
    email VARCHAR(100),
    genero CHAR(1) CHECK (genero IN ('M', 'F'))
);
GO

INSERT INTO clientes (codigo, nome, morada, telefone, contribuinte, email, genero) VALUES
(1, 'Ana Silva', 'Rua das Flores, Lisboa', '912345678', '123456789', 'ana.silva@email.com', 'F'),
(2, 'Jo�o Pereira', 'Av. da Liberdade, Lisboa', '913456789', '234567891', 'joao.pereira@email.com', 'M'),
(3, 'Maria Costa', 'Rua do Sol, Porto', '914567890', '345678912', 'maria.costa@email.com', 'F'),
(4, 'Pedro Santos', 'Rua Central, Braga', '915678901', '456789123', 'pedro.santos@email.com', 'M'),
(5, 'Rita Gomes', 'Av. do Mar, Faro', '916789012', '567891234', 'rita.gomes@email.com', 'F'),
(6, 'Carlos Rocha', 'Rua da Escola, Coimbra', '917890123', '678912345', 'carlos.rocha@email.com', 'M'),
(7, 'Sofia Almeida', 'Rua Nova, Viseu', '918901234', '789123456', 'sofia.almeida@email.com', 'F'),
(8, 'Miguel Fernandes', 'Av. Europa, Aveiro', '919012345', '891234567', 'miguel.fernandes@email.com', 'M'),
(9, 'Patr�cia Lopes', 'Rua da Ponte, Guimar�es', '910123456', '912345678', 'patricia.lopes@email.com', 'F'),
(10, 'Tiago Martins', 'Rua da Serra, Covilh�', '911234567', '923456789', 'tiago.martins@email.com', 'M'),
(11, 'In�s Ribeiro', 'Av. Central, Leiria', '912345679', '934567891', 'ines.ribeiro@email.com', 'F'),
(12, 'Andr� Nunes', 'Rua do Com�rcio, Set�bal', '913456780', '945678912', 'andre.nunes@email.com', 'M'),
(13, 'Cl�udia Pires', 'Rua da Fonte, �vora', '914567801', '956789123', 'claudia.pires@email.com', 'F'),
(14, 'Bruno Teixeira', 'Av. do Parque, Beja', '915678912', '967891234', 'bruno.teixeira@email.com', 'M'),
(15, 'Helena Faria', 'Rua do Castelo, Tomar', '916789123', '978912345', 'helena.faria@email.com', 'F'),
(16, 'Ricardo Matos', 'Rua das Oliveiras, Santar�m', '917890234', '989123456', 'ricardo.matos@email.com', 'M'),
(17, 'Catarina Barros', 'Av. dos Descobrimentos, Lagos', '918901345', '991234567', 'catarina.barros@email.com', 'F'),
(18, 'Daniel Cunha', 'Rua da Praia, Peniche', '919012456', '992345678', 'daniel.cunha@email.com', 'M'),
(19, 'Marta Azevedo', 'Rua da Igreja, Lamego', '910123567', '993456789', 'marta.azevedo@email.com', 'F'),
(20, 'F�bio Correia', 'Av. do Rio, Portalegre', '911234678', '994567891', 'fabio.correia@email.com', 'M'),
(21, 'Vanessa Neves', 'Rua da Esta��o, Entroncamento', '912345789', '995678912', 'vanessa.neves@email.com', 'F'),
(22, 'Hugo Pinto', 'Rua do Mercado, Elvas', '913456890', '996789123', 'hugo.pinto@email.com', 'M'),
(23, 'Liliana Freitas', 'Av. da Rep�blica, Almada', '914567901', '997891234', 'liliana.freitas@email.com', 'F'),
(24, 'Paulo Baptista', 'Rua do Norte, Matosinhos', '915678012', '998912345', 'paulo.baptista@email.com', 'M'),
(25, 'Raquel Torres', 'Rua da Paz, Ovar', '916789234', '999123456', 'raquel.torres@email.com', 'F'),
(26, 'Nuno Sequeira', 'Av. do Atl�ntico, Cascais', '917890345', '111234567', 'nuno.sequeira@email.com', 'M'),
(27, 'S�lvia Monteiro', 'Rua do Pinhal, Pombal', '918901456', '222345678', 'silvia.monteiro@email.com', 'F'),
(28, 'Rui Abreu', 'Rua da Lagoa, Moura', '919012567', '333456789', 'rui.abreu@email.com', 'M'),
(29, 'Teresa Fonseca', 'Av. das Ac�cias, Sintra', '910123678', '444567891', 'teresa.fonseca@email.com', 'F'),
(30, 'V�tor Lopes', 'Rua do Bairro Novo, Amadora', '911234789', '555678912', 'vitor.lopes@email.com', 'M');